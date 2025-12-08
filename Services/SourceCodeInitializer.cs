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
            string directory = Path.GetDirectoryName(filePath);

            if (language == LanguageSupported.Java)
            {
                string fileName = $"{(isBestCode ? "BestOperatorsCounter" : "OperatorsCounter")}.java";
                ExecuteCommand($"/c \"java -jar \"{ProgrammingConfiguration.JAVA_SYNTAX_FORMATTER}\" --replace --skip-removing-unused-imports \"{filePath}\"\"");
                string compDelCommand = $" && cd \"{directory}\" && javac {fileName} && del {fileName}";
                ExecuteCommand($"/c \"java -jar \"{ProgrammingConfiguration.JAVA_COUNTER_INITIALIZER}\" \"{filePath}\" \"{fromWho}\" {compDelCommand}\"");
            }
            else if (language == LanguageSupported.Cpp)
            {
                ExecuteCommand($"/c \" \"{ProgrammingConfiguration.CLANG_FORMAT_EXE}\" -i \"{filePath}\" && \"{ProgrammingConfiguration.pythonExe}\" \"{runnerFile}\" \"{filePath}\" \"{fromWho}\"\"");
                string fileName = $"{(isBestCode ? "BestOperatorsCounter" : "OperatorsCounter")}.cpp";
                string exeFile = Path.Combine(directory, $"{(isBestCode ? "BestOperatorsCounter" : "OperatorsCounter")}.exe");
                string operatorFile = Path.Combine(directory, fileName);
                Task.Delay(200);
                //turn the cpp file into exe and delete the cpp file after that                              
                ExecuteCommand($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{operatorFile}\" -o \"{exeFile}\" && del \"{operatorFile}\"\"");
            }
            else 
            {
                Task.Delay(200);
                ExecuteCommand($"/c \"\"{ProgrammingConfiguration.blackExe}\" \"{filePath}\" && \"{runnerFile}\" \"{filePath}\" \"{fromWho}\"\"");
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
                proc.WaitForExit();
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
                    using namespace std;
                    int main() {
                      cout << "Hello, World!" << endl;

                      return 0;
                    }
                    """;
                        break;
                }
            }
            File.WriteAllText(mainFile, srcCode);
            return mainFile;
        }
    }
}
