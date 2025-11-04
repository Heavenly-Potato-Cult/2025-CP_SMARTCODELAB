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
        public PythonCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, List<string>> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
           
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
            base .RunTest();
        }

        public override async Task RunLinting()
        {
            SaveCode();
            NoError();
            List<string> readabilityCommands = [
                $"/c \"\"{ProgrammingConfiguration.pylintExe}\" --rcfile={ProgrammingConfiguration.readabilityConfig} \"{filePath}\"\"",
                $"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config {ProgrammingConfiguration.ruffConfig}\""];

            //for error checking
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.pylintExe}\" --rcfile={ProgrammingConfiguration.errorConfig} \"{filePath}\"\"");
            string errorOutput = "";
            await StartprocessAsyncExit(
                process,
                err => errorOutput += (err + '\n'),
                err => errorOutput += (err),
                () => 
                {
                    try
                    {
                        errorOutput = errorOutput.Replace("************* Module Main\n", "");
                        errorOutput = errorOutput.Remove(errorOutput.LastIndexOf('\n'));
                        string[] errors = errorOutput.Split("\n");
                        foreach (var error in errors)
                        {
                            string[] splicedErrorLine = error.Split(':');
                            int splicedLength = splicedErrorLine.Length;
                            string errorMessage = splicedErrorLine[5];
                            int line = int.Parse(splicedErrorLine[2]) - 1;
                            HighlightError(line, errorMessage);
                        }
                    }
                    catch (ArgumentOutOfRangeException) { Debug.WriteLine("No syntax error detected"); }//will be thrown if no syntax error detected
                }
            );

            await checkReadability();
            await checkMaintainability();
            await checkRobustness();
        }

        private async Task checkReadability()
        {
            readabilityRules.Clear();
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
            maintainabilityRules.Clear();
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
            robustnessRules.Clear();
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
