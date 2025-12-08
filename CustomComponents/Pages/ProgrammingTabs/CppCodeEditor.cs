using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class CppCodeEditor : BaseCodeEditor
    {
        private readonly List<string> toCheck = new List<string>() { "robustness", "maintainability" };
        private readonly Dictionary<string, Action<int, string>> highlighter = new Dictionary<string, Action<int, string>>();
        private readonly Dictionary<string, string> clang_tidy_checks = new Dictionary<string, string>()
        {
            { "robustness", ProgrammingConfiguration.CPP_ROBUSTNESS_CHECKS },
            { "maintainability", ProgrammingConfiguration.CPP_MAINTAINABILITY_CHECKS }
        };
        private string fileExe;
        private string testerExe;
        private int standardComplexity;
        private string testerCpp;
        public CppCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress)
        {
            highlighter = new Dictionary<string, Action<int, string>>()
            {
                { "maintainability", HighlightMaintainabilityIssue },
                { "robustness", HighlightRobustnessIssue }
            };
            testerCpp = Path.Combine(Path.GetDirectoryName(filePath), "Tester.cpp");
            fileExe = filePath.Replace(".cpp", ".exe");
            testerExe = Path.Combine(Path.GetDirectoryName(filePath), "Tester.exe");

            if (task.ratingFactors.ContainsKey(4))
                standardComplexity = Convert.ToInt16(task.ratingFactors[4][1]);
        }

        public override async Task RunCode()
        {
            await CompileCode(fileExe);
            process?.Dispose();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $"\"{fileExe}\"",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            await base.RunCode();
        }

        private async Task CompileCode(string output)
        {
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{filePath}\" -o \"{output}\"\"");
            await StartprocessAsyncExit(
                process,
                null,
                null,
                null);
        }

        public async override void RunTest()
        {
            if (new SingleStatementBodyChecker().CheckForSingleStatementBodies(srcCode.Text).HasSingleStatementBodies)
            {
                this.BeginInvoke((Action)(() => MessageBox.Show("Unbraced statements should be avoided because they can cause ambiguity and lead to inaccurate code analysis or operation counting. Always use braces to ensure clarity and prevent evaluation errors.")));
                return;
            }
            File.WriteAllText(testerCpp, srcCode.Text);
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{testerCpp}\" -o \"{testerExe}\"\"");
            await StartprocessAsyncExit(
                process,
                null,
                null,
                null);

            commandLine = $"/c \"{testerExe}\"";
            SourceCodeInitializer.InitializeEfficiencyCode2(Models.Enums.LanguageSupported.Cpp, testerCpp, false);
            base.RunTest();
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
            {
                //await checkOperatorsCount();
                await checkEfficiencyComparison();
            }
        }

        public override void UpdateTask(TaskModel task)
        {

            //await Task.Run(() =>
            //{
            if (task.ratingFactors.ContainsKey(4))
                standardComplexity = Convert.ToInt32(task.ratingFactors[4][1]);

            if (task.ratingFactors.ContainsKey(2))
            {
                SourceCodeInitializer.InitializeEfficiencyCode(LanguageSupported.Cpp, task._referenceFile, Path.GetDirectoryName(filePath));
            }
            //});

            base.UpdateTask(task);
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"\"{Path.Combine(directory, "OperatorsCounter.exe")}\"\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"\"{Path.Combine(directory, "BestOperatorsCounter.exe")}\"\"", testIntput));
            MessageBox.Show($"Sayo : {studentsGrowth} \nTeacher : {bestGrowth}");
            updateStats?.Invoke(2, computeEfficiency(studentsGrowth, bestGrowth), "cpp");
            return Task.CompletedTask;
        }

        public override async Task RunLinting()
        {
            NoError();
            SaveCode();
            string errors = string.Empty;
            commandLine = $"/c \"\"{ProgrammingConfiguration.gccExe}\" -fsyntax-only \"{filePath}\"\"";
            process = CommandRunner(commandLine);
            await StartprocessAsyncExit(
                process,
                output => Debug.WriteLine("At output"),
                error =>
                {
                    if (error.Split(':').Length >= 6)
                        errors += error;
                },
                async () =>
                {
                    if (errors != string.Empty)
                        foreach (var error in errors.Split(Environment.NewLine))
                        {
                            (int errorLine, string errorMsg) = GetErrorLineMessage(error);
                            HighlightError(errorLine - 1, errorMsg);
                        }
                    else
                    {
                        int i = 3;
                        foreach (var item in toCheck)
                        {
                            await checkStandards(item, highlighter[item], i++);
                        }
                    }
                }
            );
        }

        protected Process PowerShellCommandRunner(string command, bool didRunCode = false)
        {
            if (process != null)
            {
                try
                {
                    process.Dispose();
                }
                catch (InvalidOperationException) { }
            }
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = "powershell.exe";
            newProcess.StartInfo.Arguments = command + (didRunCode ? " & pause" : "");
            newProcess.StartInfo.UseShellExecute = didRunCode;
            newProcess.StartInfo.RedirectStandardInput = !didRunCode;
            newProcess.StartInfo.RedirectStandardOutput = !didRunCode;
            newProcess.StartInfo.RedirectStandardError = !didRunCode;
            newProcess.StartInfo.CreateNoWindow = !didRunCode;

            return newProcess;
        }
        private async Task checkStandards(string check, Action<int, string> highlighter, int updateStatsNum)
        {
            string errors = string.Empty;
            string checkToAdd = string.Empty;
            string tidyCommand = $"& '{ProgrammingConfiguration.CLANG_TIDY_EXE}' '{filePath}' -config (Get-Content '{clang_tidy_checks[check]}' -Raw)";
            string formatCommand = $"& '{ProgrammingConfiguration.CLANG_FORMAT_EXE}' --style=LLVM -verbose -dry-run '{filePath}'";

            string powerShellScript;
            if (check == "maintainability")
            {
                powerShellScript = $"{tidyCommand}; {formatCommand}";
            }
            else
            {
                powerShellScript = tidyCommand;
            }

            byte[] encodedCommand = Encoding.Unicode.GetBytes(powerShellScript);
            string encoded = Convert.ToBase64String(encodedCommand);
            commandLine = $"-EncodedCommand {encoded}";
            process = PowerShellCommandRunner(commandLine);
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    if (output.StartsWith(filePath) && output.Contains(" warning:"))
                    {
                        errors += output.Replace(filePath + ":", "") + Environment.NewLine;
                    }
                },
                err =>
                {
                    if (err.StartsWith(filePath) && err.Contains(" warning:"))
                        errors += err.Replace(filePath + ":", "") + Environment.NewLine;
                },
                () =>
                {
                    int violationCounts = 0;
                    foreach (var item in errors.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (item != string.Empty && !item.Contains("clang-diagnostic-error"))
                        {
                            (int line, string msg) = GetErrorLineMessage(item);
                            highlighter?.Invoke(line - 1, GetErrorType(msg));
                            violationCounts++;
                        }
                    }

                    int currentComplexity = 0;
                    if (check == "maintainability" && task.ratingFactors.ContainsKey(4))
                    {
                        currentComplexity = CodeComplexityReference.CodeComplexityCounter(filePath, false);
                        if (standardComplexity < currentComplexity)
                        {
                            violationCounts += 10;
                            highlighter?.Invoke(0, "Code complexity exceeds recommended limits. Reduce the number of if-statements, switch cases, and loops in your code.");
                        }
                    }
                    updateStats?.Invoke(updateStatsNum, violationCounts, "cpp");
                }
            );
        }

        private async Task getOperatorsCount()
        {
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{ProgrammingConfiguration.CPP_OPERATOR_COUNTER}\" \"{filePath}\"\"");
            int count = 0;
            await StartprocessAsyncExit(
                process,
                output => count = int.Parse(output),
                err => Debug.WriteLine($"cpp err : {err}"),
                () => updateStats?.Invoke(2, count, "cpp")
            );
        }

        private (int, string) GetErrorLineMessage(string line)
        {
            string errorMessage = line.Replace($"{filePath}:", "");
            string lineError = string.Empty;
            int secondColon = 1;

            foreach (var item in errorMessage.ToCharArray())
            {
                if (char.IsDigit(item))
                    lineError += item;
                else
                    break;

                secondColon++;
            }
            errorMessage = errorMessage.Remove(0, secondColon);
            errorMessage = errorMessage.Remove(0, errorMessage.IndexOf(':') + 1).Replace(" error:", "");
            return (int.Parse(lineError), errorMessage);
        }

        private string GetErrorType(string lineError)
        {
            if (lineError.Contains("code should be clang-formatted", StringComparison.OrdinalIgnoreCase))
                return "Apply consistent formatting for better readability.";
            try
            {
                int startIndex = lineError.LastIndexOf("[");
                return lineError.Substring(9, startIndex - 9);
            }
            catch (ArgumentOutOfRangeException) { return lineError; }
        }
    }
}
