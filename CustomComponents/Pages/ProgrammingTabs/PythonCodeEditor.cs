using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class PythonCodeEditor : BaseCodeEditor
    {
        public PythonCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, List<string>> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
           
        }

        public override void RunCode()
        {
            commandLine = $"/c {ProgrammingConfiguration.pythonExe} {filePath}";
            base.RunCode();
        }

        public override void RunTest()
        {
            string directory = Path.GetDirectoryName(filePath);
            testerFile = Path.Combine(directory, "Tester.py");
            commandLine = $"/c \"{ProgrammingConfiguration.pythonExe}\" \"{testerFile}\"";
            base .RunTest();
        }

        public async override void RunLinting()
        {
            SaveCode();
            NoError();
            List<string> readabilityCommands = [
                $"/c \"{ProgrammingConfiguration.pylintExe}\" --rcfile={ProgrammingConfiguration.readabilityConfig} {filePath}",
                $"/c \"{ProgrammingConfiguration.ruffExe}\" check {filePath} --config {ProgrammingConfiguration.ruffConfig}"];

            //for error checking
            process = CommandRunner($"/c \"{ProgrammingConfiguration.pylintExe}\" --rcfile={ProgrammingConfiguration.errorConfig} {filePath}");
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
                    catch (ArgumentOutOfRangeException) { }
                }
            );

            //checks readability status
            int i = 0;
            int errorCounts = 0;
            foreach (var item in readabilityCommands)
            {
                process = CommandRunner(item);
                string lintOutput = "";
                await StartprocessAsyncExit(
                    process,
                    err => lintOutput += (err + '\n'),
                    null,
                    () =>
                    {
                        string errorMessage = string.Empty;
                        int line = 0;
                        if(!lintOutput.Contains("All checks passed!"))//this means the linter used was pylint
                        {
                            lintOutput = lintOutput.Replace("************* Module Main\n", "");

                            if(i == 1)
                                lintOutput = lintOutput.Remove(lintOutput.LastIndexOf("Found "));

                            lintOutput = lintOutput.Remove(lintOutput.LastIndexOf('\n'));
                            string[] errors = lintOutput.Split("\n");
                            List<string> standardErrors = new List<string>();
                            foreach (var error in errors)
                            {
                                string[] splicedErrorLine = error.Split(':');
                                int splicedLength = splicedErrorLine.Length;

                                //if i == 0, this means pylint was used and error message is in index 5, while it will be on index 4 if ruff was used
                                errorMessage = splicedErrorLine[i == 0 ? 5 : 4];
                                line = int.Parse(splicedErrorLine[2]) - 1;
                                standardErrors.Add(errorMessage);
                                errorCounts++;
                                base.HighLightStandardError(line, errorMessage);
                            }
                            updateStats?.Invoke(2, errorCounts, standardErrors);
                        }
                    }
                );
                i++;
            }
        }
    }
}
