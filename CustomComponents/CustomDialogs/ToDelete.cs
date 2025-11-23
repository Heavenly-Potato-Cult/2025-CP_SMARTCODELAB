using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string jdtRoot = @"C:\JDTLS\java\jdt-language-server-1.51.0-202509042040";
            string launcherJar = Path.Combine(jdtRoot, @"plugins\org.eclipse.equinox.launcher_1.7.0.v20250519-0528.jar");
            string configWin = Path.Combine(jdtRoot, "config_win");

            // Original Java file
            string originalJavaFile = @"C:\Projects\Capstone 2\2025-CP_SMARTCODELAB\bin\Release\net9.0-windows\SmartCodeLabActivities\java\Jimmuel_2\Main.java";

            // Temporary workspace for JDT LS
            string workspacePath = Path.Combine(Path.GetTempPath(), "JDTLS_Workspace");
            if (Directory.Exists(workspacePath))
            {
                try { Directory.Delete(workspacePath, true); } catch { }
            }
            Directory.CreateDirectory(workspacePath);

            // Create minimal project
            string projectPath = Path.Combine(workspacePath, "TestProject");
            Debug.WriteLine($"Project Path: {projectPath}");
            Directory.CreateDirectory(projectPath);

            // Create .project file
            File.WriteAllText(Path.Combine(projectPath, ".project"),
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<projectDescription>
    <name>TestProject</name>
    <comment></comment>
    <projects></projects>
    <buildSpec>
        <buildCommand>
            <name>org.eclipse.jdt.core.javabuilder</name>
        </buildCommand>
    </buildSpec>
    <natures>
        <nature>org.eclipse.jdt.core.javanature</nature>
    </natures>
</projectDescription>");

            // Create .classpath file
            File.WriteAllText(Path.Combine(projectPath, ".classpath"),
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<classpath>
    <classpathentry kind=""src"" path=""src""/>
    <classpathentry kind=""con"" path=""org.eclipse.jdt.launching.JRE_CONTAINER""/>
    <classpathentry kind=""output"" path=""bin""/>
</classpath>");

            // Create src folder and copy Main.java
            string srcFolder = Path.Combine(projectPath, "src");
            Directory.CreateDirectory(srcFolder);
            string javaFilePath = Path.Combine(srcFolder, "Main.java");

            // Read and modify Java code
            string javaCode = File.ReadAllText(originalJavaFile);

            // Insert test variable in main
            javaCode = javaCode.Replace(
                "public static void main(String[] args) {",
                "public static void main(String[] args) {\n        String theString = \"hello\";"
            );

            File.WriteAllText(javaFilePath, javaCode);

            // FIXED: Use proper URI format (file:/// with forward slashes)
            string javaFileUri = new Uri(javaFilePath).AbsoluteUri;
            Debug.WriteLine($"File URI: {javaFileUri}");

            // Start JDT LS
            var psi = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{launcherJar}\" -configuration \"{configWin}\" -data \"{workspacePath}\"",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8
            };

            var process = new Process { StartInfo = psi };

            process.ErrorDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                    Debug.WriteLine($"[JDTLS Error] {args.Data}");
            };

            try
            {
                if (!process.Start())
                {
                    Invoker("Failed to start JDT LS");
                    return;
                }

                process.BeginErrorReadLine();
                var writer = process.StandardInput;
                var reader = process.StandardOutput;

                // FIXED: Send initialize and wait for response
                await SendInitialize(writer, projectPath);

                // Wait for initialize response
                bool initialized = false;
                DateTime initStart = DateTime.Now;

                while ((DateTime.Now - initStart).TotalSeconds < 10 && !initialized)
                {
                    string message = await ReadLspMessageAsync(reader);
                    if (message != null)
                    {
                        var json = JObject.Parse(message);
                        if (json["id"]?.Value<int>() == 0 && json["result"] != null)
                        {
                            Invoker("[JDTLS] Initialized successfully");
                            initialized = true;

                            // Send initialized notification
                            JObject initializedNotification = new JObject
                            {
                                ["jsonrpc"] = "2.0",
                                ["method"] = "initialized",
                                ["params"] = new JObject()
                            };
                            SendMessage(writer, initializedNotification);
                            break;
                        }
                    }
                    await Task.Delay(100);
                }

                if (!initialized)
                {
                    Invoker("JDT LS initialization timeout");
                    return;
                }

                // Send didOpen notification
                JObject didOpen = new JObject
                {
                    ["jsonrpc"] = "2.0",
                    ["method"] = "textDocument/didOpen",
                    ["params"] = new JObject
                    {
                        ["textDocument"] = new JObject
                        {
                            ["uri"] = javaFileUri,
                            ["languageId"] = "java",
                            ["version"] = 1,
                            ["text"] = javaCode
                        }
                    }
                };
                SendMessage(writer, didOpen);
                Debug.WriteLine("[JDTLS] Sent didOpen");

                // Wait for indexing and diagnostics
                await Task.Delay(3000);

                // FIXED: Calculate correct position for completion
                // Find the line with "String theString = "hello";"
                string[] lines = javaCode.Split('\n');
                int lineIndex = -1;
                int characterPosition = -1;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("String theString"))
                    {
                        lineIndex = i;
                        // Position after "theString" and before semicolon
                        // To get methods, we need to add a dot: "theString."
                        characterPosition = lines[i].IndexOf("theString") + "theString".Length;
                        break;
                    }
                }

                if (lineIndex == -1)
                {
                    Invoker("Could not find theString variable");
                    return;
                }

                Debug.WriteLine($"[JDTLS] Requesting completion at line {lineIndex}, char {characterPosition}");

                // Send completion request
                JObject completion = new JObject
                {
                    ["jsonrpc"] = "2.0",
                    ["id"] = 1,
                    ["method"] = "textDocument/completion",
                    ["params"] = new JObject
                    {
                        ["textDocument"] = new JObject { ["uri"] = javaFileUri },
                        ["position"] = new JObject
                        {
                            ["line"] = lineIndex,
                            ["character"] = characterPosition
                        },
                        ["context"] = new JObject
                        {
                            ["triggerKind"] = 1 // Invoked
                        }
                    }
                };
                SendMessage(writer, completion);

                // Read completion response
                DateTime startTime = DateTime.Now;
                bool foundResponse = false;

                while ((DateTime.Now - startTime).TotalSeconds < 15 && !foundResponse)
                {
                    string message = await ReadLspMessageAsync(reader);
                    if (message != null)
                    {
                        Invoker(message);
                        var json = JObject.Parse(message);

                        if (json["id"]?.Value<int>() == 1)
                        {
                            foundResponse = true;
                            var result = json["result"];

                            if (result != null)
                            {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendLine("=== Completion Results ===");

                                // Handle both array and object with items
                                JArray items = result is JArray arr ? arr : result["items"] as JArray;

                                if (items != null && items.Count > 0)
                                {
                                    foreach (var item in items)
                                    {
                                        string label = item["label"]?.ToString() ?? "Unknown";
                                        string kind = item["kind"]?.ToString() ?? "";
                                        sb.AppendLine($"- {label} (kind: {kind})");
                                    }
                                }
                                else
                                {
                                    sb.AppendLine("No completion items found");
                                }

                                Invoker(sb.ToString());
                                Invoker(sb.ToString());
                            }
                            else
                            {
                                Invoker("[JDTLS] No completion result");
                                Invoker("No completion result received");
                            }
                        }
                        else if (json["error"] != null)
                        {
                            string errorMsg = json["error"].ToString();
                            Invoker($"[JDTLS Error] {errorMsg}");
                            Invoker($"LSP Error: {errorMsg}");
                            foundResponse = true;
                        }
                    }
                    await Task.Delay(100);
                }

                if (!foundResponse)
                {
                    Invoker("Completion request timeout");
                }

                // Send shutdown and exit
                JObject shutdown = new JObject
                {
                    ["jsonrpc"] = "2.0",
                    ["id"] = 2,
                    ["method"] = "shutdown",
                    ["params"] = null
                };
                SendMessage(writer, shutdown);

                await Task.Delay(500);

                JObject exit = new JObject
                {
                    ["jsonrpc"] = "2.0",
                    ["method"] = "exit"
                };
                SendMessage(writer, exit);
            }
            catch (Exception ex)
            {
                Invoker($"[Exception] {ex.Message}\n{ex.StackTrace}");
                Invoker($"Error: {ex.Message}");
            }
            finally
            {
                if (process != null && !process.HasExited)
                {
                    try
                    {
                        process.Kill();
                        await Task.Delay(500);
                    }
                    catch { }
                }
                process?.Dispose();

                // Cleanup workspace
                await Task.Delay(1000); // Give time for file handles to release
                try
                {
                    if (Directory.Exists(workspacePath))
                        Directory.Delete(workspacePath, true);
                }
                catch (Exception ex)
                {
                    Invoker($"[Cleanup] Failed to delete workspace: {ex.Message}");
                }
            }
        }

        public void Invoker(string msg)
        {
            this.Invoke(new Action(() =>
            {
                MessageBox.Show(this, msg);
            }));
        }

        private async Task SendInitialize(StreamWriter writer, string projectPath)
        {
            string projectUri = new Uri(projectPath).AbsoluteUri;

            JObject initialize = new JObject
            {
                ["jsonrpc"] = "2.0",
                ["id"] = 0,
                ["method"] = "initialize",
                ["params"] = new JObject
                {
                    ["processId"] = Process.GetCurrentProcess().Id,
                    ["rootUri"] = projectUri,
                    ["capabilities"] = new JObject
                    {
                        ["textDocument"] = new JObject
                        {
                            ["completion"] = new JObject
                            {
                                ["completionItem"] = new JObject
                                {
                                    ["snippetSupport"] = false
                                }
                            }
                        }
                    }
                }
            };
            SendMessage(writer, initialize);
            Debug.WriteLine("[JDTLS] Sent initialize request");
        }

        static void SendMessage(StreamWriter writer, JObject message)
        {
            string json = message.ToString(Newtonsoft.Json.Formatting.None);
            byte[] bytes = Encoding.UTF8.GetBytes(json);

            string header = $"Content-Length: {bytes.Length}\r\n\r\n";
            byte[] headerBytes = Encoding.UTF8.GetBytes(header);

            writer.BaseStream.Write(headerBytes, 0, headerBytes.Length);
            writer.BaseStream.Write(bytes, 0, bytes.Length);
            writer.BaseStream.Flush();
        }

        static async Task<string> ReadLspMessageAsync(StreamReader reader)
        {
            try
            {
                // Read headers
                int contentLength = 0;
                string line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                        break; // Empty line separates headers from content

                    if (line.StartsWith("Content-Length:", StringComparison.OrdinalIgnoreCase))
                    {
                        contentLength = int.Parse(line.Substring("Content-Length:".Length).Trim());
                    }
                }

                if (contentLength == 0) return null;

                // Read exact number of bytes
                char[] buffer = new char[contentLength];
                int totalRead = 0;

                while (totalRead < contentLength)
                {
                    int read = await reader.ReadAsync(buffer, totalRead, contentLength - totalRead);
                    if (read == 0) break;
                    totalRead += read;
                }

                return new string(buffer, 0, totalRead);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ReadLspMessage] Error: {ex.Message}");
                return null;
            }
        }
    }
}