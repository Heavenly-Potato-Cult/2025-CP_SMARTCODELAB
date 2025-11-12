using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace SmartCodeLab.Services
{
    public class SourceCodeInitializer
    {
        public static readonly Dictionary<LanguageSupported, string> extension = new Dictionary<LanguageSupported, string>() 
        {
            {LanguageSupported.Java,".java" },
            {LanguageSupported.Python,".py" },
            {LanguageSupported.Cpp, ".cpp"}
        };

        public static readonly Dictionary<LanguageSupported, string> activityLocation = new Dictionary<LanguageSupported, string>()
        {
            {LanguageSupported.Java,ProgrammingConfiguration.javaFolder },
            {LanguageSupported.Python,ProgrammingConfiguration.pythonFolder },
            {LanguageSupported.Cpp, ProgrammingConfiguration.cppFolder }
        };

        public static string ValidName(string fileName)
        {
            while (Char.IsDigit(fileName[0]))
                fileName = fileName.Substring(1);
            fileName = Regex.Replace(fileName, @"[^a-zA-Z0-9]", "_");
            return fileName;
        }

        public static void InitializeEfficiencyCode(LanguageSupported language, string sourceCode, string directory)
        {
            string filePath = Path.Combine(directory,"BestOperatorsCounter" + extension[language]);
            File.WriteAllText(filePath, sourceCode);
            InitializeEfficiencyCode2(language, filePath, true);
        }

        public static void InitializeEfficiencyCode2(LanguageSupported language, string filePath, bool isBestCode)
        {
            string fromWho = isBestCode ? "Teacher" : "Student";
            string runnerFile = language == LanguageSupported.Python ? ProgrammingConfiguration.PYTHON_COUNTER_INITIALIZER : ProgrammingConfiguration.CPP_COUNTER_INITIALIZER;
            if (language == LanguageSupported.Java)
            {
                ExecuteCommand($"/c \"java -jar \"{ProgrammingConfiguration.JAVA_COUNTER_INITIALIZER}\" \"{filePath}\" \"{fromWho}\"\"");
            }
            else
            {
                ExecuteCommand($"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{runnerFile}\" \"{filePath}\" \"{fromWho}\"\"");
            }
        }

        public static void ExecuteCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                return;

            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                // /C runs the command then exits. Wrap the command in quotes if it contains special chars.
                Arguments =command,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                RedirectStandardInput = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            try
            {
                using var proc = new Process { StartInfo = psi };
                proc.Start();
                // Do not wait for exit per your requirement (fire-and-forget).
                // If you later want to wait, call proc.WaitForExit();
            }
            catch (Exception)
            {
                // Swallowing exceptions per "expects nothing else".
                // Consider logging in real apps.
            }
        }

        public static string InitializeActivityDirectory(LanguageSupported language, string userName, string taskName, string sourceCode = "")
        {
            string activityDirectory = Path.Combine(activityLocation[language], userName+'_'+taskName);
            //activityDirectory = activityDirectory.Replace(' ', '_');
            string mainFile = Path.Combine(activityDirectory, $"Main{extension[language]}");
            string srcCode = sourceCode;
            if (!Directory.Exists(activityDirectory))
                Directory.CreateDirectory(activityDirectory);

            if (srcCode == "")
            {
                switch (language)
                {//other languages implementations will come next
                    case LanguageSupported.Java:
                        srcCode =
                            """
                    public class Main{
                        public static void main(String[] args) {
                            System.out.println("Hello, World!");
                        }
                    }
                    """;
                        break;
                    case LanguageSupported.Python:
                        srcCode =
                            """
                    #start coding now
                    """;
                        break;
                    default:
                        srcCode = """
                    #include <iostream>

                    int main() {
                        std::cout << "Hello, World!" << std::endl;

                        return 0;
                    }
                    """;
                        break;
                }
            }
            File.WriteAllText(mainFile, srcCode);
            InitializeTesterSourceCode(language, activityDirectory);
            return mainFile;
        }
        public static void InitializeTesterSourceCode(LanguageSupported language,string filePath) 
        {
            string srcCode = string.Empty;
            string exeDirectory = Path.Combine(filePath,"Main.exe").Replace("\\", "\\\\");
            switch (language) 
            {
                case LanguageSupported.Java:
                    srcCode = """
                        import java.io.ByteArrayInputStream;
                        import java.io.ByteArrayOutputStream;
                        import java.io.PrintStream;
                        public class Tester {
                            public static void main(String[] args) {
                                PrintStream originalOut = System.out;
                                var baos = new ByteArrayOutputStream();
                                System.setOut(new PrintStream(baos));
                                System.setIn(new ByteArrayInputStream(
                                \"\"\"
                                userInput
                                \"\"\".getBytes())); //change theInput
                                Main.main(null);

                                System.setOut(originalOut);
                                System.out.println(baos.toString());
                            }
                        }
                        """.Replace("\\","");
                    break;
                case LanguageSupported.Python:
                    srcCode = $$"""
                        import subprocess,os

                        base = os.path.dirname(__file__)  # folder where Tester.py is located
                        script = os.path.join(base, "Main.py")

                        subprocess.run(["python", script], input="userInput", text=True)
                        """;
                    break;
                default:
                    srcCode = $$"""
                                #include <cstdlib>
                                #include <iostream>

                                int main() {
                                    int result = system(
                                        "cd /d \"gccBin\" && "
                                        "g++ \"filePath\" "
                                        "-o \"exeDirectory\" && "
                                        "(userInput) | \"exeDirectory\""
                                        );
                                    return result;
                                }
                                """
                                .Replace("gccBin", ProgrammingConfiguration.gccBin.Replace("\\","\\\\"))
                                .Replace("filePath", Path.Combine(filePath,"Main.cpp").Replace("\\", "\\\\"))
                                .Replace("exeDirectory",exeDirectory);
                    break;
            }
            string fileAbsolutePath = filePath + "\\Tester"+extension[language];
            File.WriteAllText(fileAbsolutePath, srcCode);
        }
    }
}
