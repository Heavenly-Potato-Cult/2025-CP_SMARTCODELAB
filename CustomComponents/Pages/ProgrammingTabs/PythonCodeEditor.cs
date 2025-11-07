using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class PythonCodeEditor : BaseCodeEditor
    {
        private Dictionary<string, string> linterCommands;
        private string[] checksToRun = [string.Empty, string.Empty, ProgrammingConfiguration.ruffReadability, ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability];
        private List<string> linters = new List<string>() {ProgrammingConfiguration.ruffReadability, ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability};
        public PythonCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, List<string>> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
            foreach (var item in linters)
            {
                string content = LintersServices.pythonLinters[item];

                if(item == ProgrammingConfiguration.ruffMaintainability && task.ratingFactors.ContainsKey(4))
                {
                    maintainabilityCheck = content.Replace("999", Convert.ToInt32(task.ratingFactors[4][1]).ToString());
                    content = maintainabilityCheck;
                }
                LintersServices.initializeLinter(item, content);
            }

            linterCommands = new Dictionary<string, string>()
            {
                {ProgrammingConfiguration.ruffReadability, $"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffReadability}\"\"" },
                {ProgrammingConfiguration.ruffRobustness, $"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffRobustness}\"\"" },
                {ProgrammingConfiguration.ruffMaintainability, $"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffMaintainability}\"\"" }

            };
        }

        public override void RunCode()
        {
            commandLine = $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{filePath}\"\"";
            base.RunCode();
        }

        public override void RunTest()
        {
            string directory = Path.GetDirectoryName(filePath);
            testerFile = Path.Combine(directory, "Tester.py");
            commandLine = $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{testerFile}\"\"";
            base.RunTest();
        }

        public override async Task RunLinting()
        {
            SaveCode();
            NoError();
            //for error checking
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.pylintExe}\" --rcfile=\"{ProgrammingConfiguration.errorConfig}\" \"{filePath}\"\"");
            string errorOutput = "";
            await StartprocessAsyncExit(
                process,
                err => {
                    if (err.Contains("Main.py"))
                    {
                        int mainPyIndex = err.IndexOf("Main.py");
                        if (mainPyIndex > 0)
                            errorOutput += err.Substring(err.IndexOf("Main.py") + 8) + Environment.NewLine;
                    }
                },
                null,
                async () => 
                {
                    try
                    {
                        if(errorOutput == "")//means no syntax error
                        {
                            for (int i = 2; i < 5; i++)
                            {
                                await checkStandards(checksToRun[i], standardClearer(i), violationsHighLighter(i), i);
                            }
                        }
                        else
                        {
                            errorOutput = errorOutput.Remove(errorOutput.LastIndexOf(Environment.NewLine));
                            string[] errors = errorOutput.Split(Environment.NewLine);
                            foreach (var error in errors)
                            {
                                string[] splicedErrorLine = error.Split(':');
                                string errorMessage = splicedErrorLine[2];
                                int line = int.Parse(splicedErrorLine[0]) - 1;
                                errorMessage = error.Substring(error.IndexOf(errorMessage) + errorMessage.Length + 2);
                                HighlightError(line, errorMessage);
                            }
                        }

                    }
                    catch (ArgumentOutOfRangeException)//will be thrown if no syntax error detected 
                    {}
                }
            );
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
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        checksViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                err => Debug.WriteLine("Err "+ err),
                () =>
                {
                    if (checksViolations != "")
                    {
                        int violationCounts = 0;
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
                        updateStats?.Invoke(updateStatsNum, violationCounts, new List<string>());
                    }
                }
            );
        }

        private Action<int, string> violationsHighLighter(int i)
        {
            if (i == 2)
                return new Action<int, string>((int num, string msg) =>
                {
                    base.HighlightReadabilityIssue(num, msg);
                });
            else if (i == 3)
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

        private async Task checkReadability()
        {
            if (!File.Exists(ProgrammingConfiguration.ruffReadability))
                LintersServices.initializeLinter(ProgrammingConfiguration.ruffReadability, LintersServices.pythonLinters[ProgrammingConfiguration.ruffReadability]);


            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffReadability}\"\"");
            string readabilityViolations = "";
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        readabilityViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                null,
                () =>
                {
                    if(readabilityViolations != "")
                    {
                        int violationCounts = 0;
                        foreach (var item in readabilityViolations.Split(Environment.NewLine))
                        {
                            try
                            {
                                string[] slicedViolation = item.Split(':');
                                int errorLine = int.Parse(slicedViolation[0]);
                                string errorMessage = ToolTipProgrammingMessages.pythonRuffRules[ruffCodeRetriever(slicedViolation[2])];

                                HighlightReadabilityIssue(errorLine - 1, errorMessage);
                                readabilityRules.Add(ruffCodeRetriever(errorMessage));
                                violationCounts++;
                            }
                            catch (ArgumentOutOfRangeException) { }
                            catch(FormatException) { }
                            catch(KeyNotFoundException) { }
                        }
                        updateStats?.Invoke(2, violationCounts, new List<string>());
                    }
                }
            );
        }
        private async Task checkMaintainability()
        {
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffMaintainability}\"\"");
            string maintainabilityViolations = "";
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        maintainabilityViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                null,
                () =>
                {
                    if (maintainabilityViolations != "")
                    {
                        int violationCounts = 0;
                        foreach (var item in maintainabilityViolations.Split(Environment.NewLine))
                        {
                            try
                            {
                                string[] slicedViolation = item.Split(':');
                                int errorLine = int.Parse(slicedViolation[0]);
                                string errorMessage = ToolTipProgrammingMessages.pythonRuffRules[ruffCodeRetriever(slicedViolation[2])];

                                HighlightMaintainabilityIssue(errorLine - 1, errorMessage);
                                violationCounts++;
                            }
                            catch (ArgumentOutOfRangeException) { }
                            catch (FormatException) { }
                            catch (KeyNotFoundException) { }
                        }
                        updateStats?.Invoke(4, violationCounts, new List<string>());
                    }
                }
            );
        }
        private async Task checkRobustness()
        {

            if (!File.Exists(ProgrammingConfiguration.ruffRobustness))
                LintersServices.initializeLinter(ProgrammingConfiguration.ruffRobustness, LintersServices.pythonLinters[ProgrammingConfiguration.ruffRobustness]);

            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ProgrammingConfiguration.ruffRobustness}\"\"");
            string robustnessViolations = "";
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        robustnessViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                null,
                () =>
                {
                    if (robustnessViolations != "")
                    {
                        int violationCounts = 0;
                        foreach (var item in robustnessViolations.Split(Environment.NewLine))
                        {
                            try
                            {
                                string[] slicedViolation = item.Split(':');
                                int errorLine = int.Parse(slicedViolation[0]);
                                string errorMessage = ToolTipProgrammingMessages.pythonRuffRules[ruffCodeRetriever(slicedViolation[2])];

                                HighlightRobustnessIssue(errorLine - 1, errorMessage);
                                robustnessRules.Add(ruffCodeRetriever(errorMessage));
                                violationCounts++;
                            }
                            catch (ArgumentOutOfRangeException) { }
                            catch (FormatException) { }
                            catch (KeyNotFoundException) { }
                        }
                        updateStats?.Invoke(3, violationCounts, new List<string>());
                    }
                }
            );
        }

        private string ruffCodeRetriever(string errorMsg)
        {
            string newMsg = errorMsg.Remove(0, 1);
            return newMsg.Split(" ")[0];
        }
    }
}
