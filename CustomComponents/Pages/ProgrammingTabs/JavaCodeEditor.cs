using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class JavaCodeEditor : CodeEditorBase
    {
        private Process javaProcess;
        string latestOutput = "";

        private readonly string checkStylePath;
        private readonly string configFile;

        public JavaCodeEditor(string filePath, TaskModel task) : base(filePath, task)
        {
        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            checkStylePath = Path.Combine(baseDirectory, "linters", "java", "checkstyle-11.0.1-all.jar");
            configFile = Path.Combine(baseDirectory, "linters", "java", "simple_checks.xml");
            output.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && javaProcess != null && !javaProcess.HasExited)
                {
                    e.SuppressKeyPress = true; // prevent new line in textbox

                    string inputLine = GetLastLine(output.Text);
                    SendInput(inputLine);
                    output.AppendText(Environment.NewLine); // mimic Enter
                }
            };
        }

        public async override void RunCode()
        {
            this.Invoke((Action)(() => { 
                output.Text = "";
                output.ReadOnly = false;
            })); // clear
            SaveCode(srcCode.Text);
            CompileCode();

            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string compile = $"/c java -cp \"{directory}\" {classname}";

            if (compiledSuccess)
            {
                javaProcess = JavaProcess(compile);

                await StartJavaProcessAsync(
                    javaProcess,
                    outputLine => this.Invoke((Action)(() => output.AppendText(outputLine + Environment.NewLine))),
                    errorLine => this.Invoke((Action)(() => output.AppendText(errorLine + Environment.NewLine))),
                    () => this.Invoke((Action)(() =>
                    {
                        output.AppendText("\n=== Process finished ===\n");
                        output.ReadOnly = true;
                    }))
                );
            }
        }


        private bool compiledSuccess = false;
        public async override void CompileCode()
        {
            SaveCode(srcCode.Text);
            latestOutput = "";
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            javaProcess = JavaProcess($"/c javac -cp \"{directory}\" {filePath}");
            await StartJavaProcessAsync(
                javaProcess,
                null,
                withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }
        public async override void RunLinting()
        {
            SaveCode(srcCode.Text);
            latestOutput = "";
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            javaProcess = JavaProcess($"/c cd {directory} && javac -Xlint {fileName}");

            await StartJavaProcessAsyncExit(
                javaProcess,
                null,
                error => errorLine += error,
                null);

            if (errorLine != "")
            {
                string[] lines = errorLine.Split(":");
                int lineIndex = int.Parse(lines[1]) - 1;
                HighlightError(lineIndex, lines[3]);
            }
            else
            {
                NoError();
                CheckCodingStandards();
            }
        }

        public async override void CheckCodingStandards()
        {
            standardError.Clear();
            javaProcess = JavaProcess($"/c java -jar {checkStylePath} -c {configFile} {filePath}");
            string errorLine = "";
            await StartJavaProcessAsyncExit(
                javaProcess,
                outp => errorLine+=(outp+Environment.NewLine),
                null,
                null);
            //Debug.WriteLine(errorLine.Replace("Starting audit..." + Environment.NewLine, "").Replace("Audit done." + Environment.NewLine, ""));
            string[] errors = (errorLine.Replace("Starting audit..."+Environment.NewLine,"").Replace("Audit done." + Environment.NewLine, "")).Split(Environment.NewLine);
            foreach (string standardError in errors)
            {
                if (errors[errors.Length-1] != standardError) 
                {
                    string[] e = standardError.Split(':');
                    HighLightStandardError(int.Parse(e[2]) - 1, e[4]);
                }
            }
        }

        public async override void RunTest()
        {
            SaveCode(srcCode.Text);
            CompileCode();
            this.Invoke((Action)(() =>
            {
                output.Text = "Process Started" + Environment.NewLine;
                output.ReadOnly = true;
            }));
            int score = 0;
            int i = 1;
            foreach (var item in _task._testCases)
            {
                string directory = Path.GetDirectoryName(filePath);
                string testerFile = Path.Combine(directory, "Tester.java");

                // read + replace + write
                string testSrcCode = File.ReadAllText(testerFile);
                File.WriteAllText(testerFile, testSrcCode.Replace("userInput", item.Key));
                string compile = $"/c cd {directory} && javac Tester.java && java Tester";
                javaProcess = JavaProcess(compile);
                string outputResult = "";
                string errorResult = "";
                await StartJavaProcessAsyncExit(
                    javaProcess,
                    outputMsg => outputResult+=outputMsg,
                    errorMsg => outputResult+=errorMsg,
                    null
                    );

                string result = "";
                string textOutput = string.IsNullOrEmpty(outputResult) ? errorResult : outputResult;
                score = (item.Value.Equals(outputResult)) ? score+1 : score;
                result = $"""
                    Test Case {i++}
                    Input:{item.Key + Environment.NewLine}
                    Expected Output : {item.Value}
                    Actual Output   : {textOutput}
                    Result          : {(item.Value.Equals(textOutput) ? "Correct" : "Wrong")}
                    """ + Environment.NewLine;

                this.Invoke((Action)(() => { 
                    output.AppendText(result+ Environment.NewLine);
                    }));
                File.WriteAllText(testerFile, testSrcCode.Replace(item.Key, "userInput"));
            }
            this.Invoke((Action)(() => {
                output.AppendText($"Score : {score}/{_task._testCases.Count}");
            }));
        }

        private void SendInput(string input)
        {
            if (javaProcess != null && !javaProcess.HasExited)
            {
                javaProcess.StandardInput.WriteLine(input);
                javaProcess.StandardInput.Flush();
            }
        }
        private string GetLastLine(string text)
        {
            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            return lines.LastOrDefault()?.Trim() ?? string.Empty;
        }

        private async Task StartJavaProcessAsync(Process javaProcess, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            this.Invoke((Action)(() => output.Text = "Process Started" + Environment.NewLine));
            javaProcess.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onOutput?.Invoke(e.Data);
            };

            javaProcess.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };

            javaProcess.Exited += (s, e) =>
            {
                compiledSuccess = javaProcess.ExitCode == 0;
                onExit?.Invoke();
            };

            javaProcess.EnableRaisingEvents = true;
            javaProcess.Start();
            javaProcess.BeginOutputReadLine();
            javaProcess.BeginErrorReadLine();
        }

        private async Task StartJavaProcessAsyncExit(Process javaProcess, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            javaProcess.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onOutput?.Invoke(e.Data);
            };

            javaProcess.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };

            javaProcess.Exited += (s, e) =>
            {
                compiledSuccess = javaProcess.ExitCode == 0;
                onExit?.Invoke();
            };

            javaProcess.EnableRaisingEvents = true;
            javaProcess.Start();
            javaProcess.BeginOutputReadLine();
            javaProcess.BeginErrorReadLine();
            await javaProcess.WaitForExitAsync();
        }

        private Process JavaProcess(string command)
        {
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = "cmd.exe";
            newProcess.StartInfo.Arguments = command; // or java ClassName
            newProcess.StartInfo.UseShellExecute = false;
            newProcess.StartInfo.RedirectStandardInput = true;
            newProcess.StartInfo.RedirectStandardOutput = true;
            newProcess.StartInfo.RedirectStandardError = true;
            newProcess.StartInfo.CreateNoWindow = true;

            return newProcess;
        }
    }
}