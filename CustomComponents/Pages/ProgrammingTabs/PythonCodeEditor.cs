using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class PythonCodeEditor : BaseCodeEditor
    {
        private string[] checksToRun = [string.Empty, string.Empty, string.Empty, ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability];
        private List<string> linters = new List<string>() {ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability};
        public PythonCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
            foreach (var item in linters)
            {
                string content = LintersServices.pythonLinters[item];

                if(item == ProgrammingConfiguration.ruffMaintainability && task.ratingFactors.ContainsKey(4))
                {
                    maintainabilityCheck = content.Replace("999999", Convert.ToInt32(task.ratingFactors[4][1]).ToString());
                    content = maintainabilityCheck;
                }
                LintersServices.initializeLinter(item, content);
            }
        }

        public override async Task RunCode()
        {
            process?.Dispose();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "py",
                    Arguments = $"\"{filePath}\"",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            await base.RunCode();
        }

        public override async void RunTest()
        {
            SourceCodeInitializer.InitializeEfficiencyCode2(Models.Enums.LanguageSupported.Python, filePath, false);
            commandLine = $"/c \"py \"{filePath}\"\"";
            base.RunTest();
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
                await checkEfficiencyComparison();
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"py \"{Path.Combine(directory,"OperatorsCounter.py")}\"\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"py \"{Path.Combine(directory, "BestOperatorsCounter.py")}\"\"", testIntput));
            MessageBox.Show($"Sayo : {studentsGrowth} \nTeacher : {bestGrowth}");
            updateStats?.Invoke(2, computeEfficiency(studentsGrowth, bestGrowth), "java");

            return Task.CompletedTask;
        }

        public override async Task RunLinting()
        {
            SaveCode();
            NoError();
            //for error checking
            process = CommandRunner($"/c \"py \"{ProgrammingConfiguration.SYNTAX_CHECKER}\" \"{filePath}\"\"");
            string errorOutput = "";
            await StartprocessAsync(
                process,
                err =>
                {
                    errorOutput += err + Environment.NewLine;
                },
                null,
                async () =>
                {
                    try
                    {
                        if (errorOutput == "")//means no syntax error
                        {
                            for (int i = 3; i < 5; i++)
                            {
                                await checkStandards(checksToRun[i], standardClearer(i), violationsHighLighter(i), i);
                            }
                        }
                        else
                        {
                            string[] errors = errorOutput.Split(Environment.NewLine);
                            int line = int.Parse(errors[0]);
                            string errorMsg = errors[1];
                            HighlightError(line, errorMsg);
                        }
                    }
                    catch (ArgumentOutOfRangeException)//will be thrown if no syntax error detected 
                    { }
                }
            );
        }

        public override void UpdateTask(TaskModel newTask)
        {
            if (task.ratingFactors.ContainsKey(4))
            {
                string item = ProgrammingConfiguration.ruffMaintainability;
                if (task.ratingFactors.ContainsKey(4))
                    maintainabilityCheck = LintersServices.pythonLinters[item].Replace("999999", Convert.ToInt32(task.ratingFactors[4][1]).ToString());

                LintersServices.initializeLinter(item, maintainabilityCheck);
            }
            if (task.ratingFactors.ContainsKey(2))
            {
                SourceCodeInitializer.InitializeEfficiencyCode(LanguageSupported.Python, task._referenceFile, Path.GetDirectoryName(filePath));
            }
            base.UpdateTask(newTask);
        }

        private async Task checkStandards(string ruffFilePath, Action warningClearer, Action<int, string> highlighter, int updateStatsNum)
        {
            warningClearer?.Invoke();

            if (!File.Exists(ruffFilePath) && ruffFilePath == ProgrammingConfiguration.ruffMaintainability)
                LintersServices.initializeLinter(ruffFilePath, maintainabilityCheck);
            else if(!File.Exists(ruffFilePath))
                LintersServices.initializeLinter(ruffFilePath, LintersServices.pythonLinters[filePath]);

            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ruffFilePath}\"\"");
            string checksViolations = "";
            string totalError = "";
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        checksViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                err => totalError+=err + '\n',
                () =>
                {
                    int violationCounts = 0;
                    if (checksViolations != "")
                    {
                        foreach (var item in checksViolations.Split(Environment.NewLine))
                        {
                            try
                            {
                                string[] slicedViolation = item.Split(':');
                                int errorLine = int.Parse(slicedViolation[0]);
                                string errorMessage = ToolTipProgrammingMessages.pythonRuffRules[ruffCodeRetriever(slicedViolation[2])];

                                highlighter.Invoke(errorLine - 1, errorMessage);
                                violationCounts++;
                            }
                            catch (ArgumentOutOfRangeException) { }
                            catch (FormatException) { }
                            catch (TypeInitializationException) { }
                            catch (KeyNotFoundException knfe) 
                            {
                                Debug.WriteLine(knfe.Message);
                            }
                        }
                    }
                    updateStats?.Invoke(updateStatsNum, violationCounts, "python");
                }
            );
        }

        private Action<int, string> violationsHighLighter(int i)
        {
            if (i == 3)
                return new Action<int, string>((int num, string msg) =>
                {
                    base.HighlightRobustnessIssue(num, msg);
                });
            else
                return new Action<int, string>((int num, string msg) =>
                {
                    base.HighlightMaintainabilityIssue(num, msg);
                });
        }

        private Action standardClearer(int lintercheck) //2 = readability , 3 = robustness, else = maintainability
        {
            if (lintercheck == 2)
                return new Action(() =>
                {
                    readabilityRules.Clear();
                    readabilityWarning.Clear();
                });
            else if (lintercheck == 3)
                return new Action(() =>
                {
                    robustnessRules.Clear();
                    robustnessWarning.Clear();
                });
            else
                return new Action(() =>
                {
                    maintainabilityRules.Clear();
                    maintainabilityWarning.Clear();
                });
        }

        private string ruffCodeRetriever(string errorMsg)
        {
            string newMsg = errorMsg.Remove(0, 1);
            return newMsg.Split(" ")[0];
        }
    }
}
