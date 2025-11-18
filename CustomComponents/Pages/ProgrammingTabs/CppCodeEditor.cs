using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class CppCodeEditor : BaseCodeEditor
    {
        private readonly List<string> toCheck = new List<string>() {"robustness", "maintainability" };
        private readonly Dictionary<string, Action<int, string>> highlighter = new Dictionary<string, Action<int, string>>();
        private string fileExe;
        public CppCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
            highlighter = new Dictionary<string, Action<int, string>>()
            {
                { "maintainability", HighlightMaintainabilityIssue },
                { "robustness", HighlightRobustnessIssue }
            };
            fileExe = filePath.Replace(".cpp", ".exe");
        }

        public override async Task RunCode()
        {
            await CompileCode();
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

        private async Task CompileCode()
        {
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{filePath}\" -o \"{fileExe}\"\"");
            await StartprocessAsyncExit(
                process,
                null,
                null,
                null);
        }

        public async override void RunTest()
        {

            CompileCode();
            commandLine = $"/c \"{fileExe}\"";
            SourceCodeInitializer.InitializeEfficiencyCode2(Models.Enums.LanguageSupported.Cpp, filePath, false);
            base.RunTest();
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
            {
                //await checkOperatorsCount();
                await checkEfficiencyComparison();
            }
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"\"{ProgrammingConfiguration.gccExe}\" \"{Path.Combine(directory, "OperatorsCounter.cpp")}\" -o \"{Path.Combine(directory, "OperatorsCounter.exe")}\" && \"{Path.Combine(directory, "OperatorsCounter.exe")}\"\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"\"{ProgrammingConfiguration.gccExe}\" \"{Path.Combine(directory, "BestOperatorsCounter.cpp")}\" -o \"{Path.Combine(directory, "BestOperatorsCounter.exe")}\" && \"{Path.Combine(directory, "BestOperatorsCounter.exe")}\"\"", testIntput));
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
                async () => {
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

        private async Task checkStandards(string check, Action<int, string> highlighter, int updateStatsNum)
        {
            string errors = string.Empty;
            commandLine = $"/c \"\"{ProgrammingConfiguration.CLANG_TIDY_EXE}\" \"{filePath}\" {LintersServices.cppLinterClangTidy[check]}\"";
            process = CommandRunner(commandLine);
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    if (output.StartsWith(filePath))
                    {
                        errors += output.Replace(filePath + ":", "") + Environment.NewLine;
                    }
                },
                null,
                () =>
                {
                    int violationCounts = 0;
                    foreach (var item in errors.Split(Environment.NewLine))
                    {
                        if (item != string.Empty)
                        {
                            (int line, string msg) = GetErrorLineMessage(item);
                            highlighter?.Invoke(line - 1, msg);
                            violationCounts++;
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

        private (int,string) GetErrorLineMessage(string line)
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
            errorMessage = errorMessage.Remove(0, errorMessage.IndexOf(':') + 1).Replace(" error:","");
            return (int.Parse(lineError), errorMessage);
        }

        private (int, string) GetViolationLineMessage(string line)
        {
            string violationMessage = line.Replace($"{filePath}:", "");
            string lineError = string.Empty;
            int secondColon = 1;

            foreach (var item in violationMessage.ToCharArray())
            {
                if (char.IsDigit(item))
                    lineError += item;
                else
                    break;

                secondColon++;
            }
            violationMessage = violationMessage.Remove(0, secondColon+2);

            return (int.Parse(lineError), violationMessage);
        }
    }
}
