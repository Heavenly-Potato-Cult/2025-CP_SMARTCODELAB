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
    public class CppCodeEditor : BaseCodeEditor
    {
        public CppCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, List<string>> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {

        }

        public override void RunCode()
        {
            string fileExe = filePath.Replace(".cpp", ".exe");
            commandLine = $"/c \"\"{ProgrammingConfiguration.gccExe}\" \"{filePath}\" -o \"{fileExe}\" && \"{fileExe}\"\"";
            base.RunCode();
        }

        public override void RunTest()
        {
            commandLine = $"/c \"cd \"{ProgrammingConfiguration.gccBin}\" && g++ \"{Path.GetDirectoryName(filePath)+"\\Tester.cpp"}\" -o test.exe && test.exe\"";
            testerFile = Path.GetDirectoryName(filePath) + "\\\\" + "Tester.cpp";
            base.RunTest();
        }

        public override async Task RunLinting()
        {
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
                () => {
                    NoError();
                    if (errors != string.Empty)
                        foreach (var error in errors.Split(Environment.NewLine))
                        {
                            (int errorLine, string errorMsg) = GetErrorLineMessage(error);
                            HighlightError(errorLine - 1, errorMsg);
                        }
                }
            );
            string fileDirectory = Path.GetDirectoryName(filePath);

            if(!File.Exists(Path.Combine(fileDirectory, "syntax_checker.cpplintrc"))) //if the config file does not exist in the file directory, copy it there
            {
                File.Copy(ProgrammingConfiguration.CPPLINT_CONFIG, Path.Combine(fileDirectory, "syntax_checker.cpplintrc"));
            }
            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.CPPLINT_EXE}\" --config=syntax_checker.cpplintrc {filePath}\"");
            string standardsViolations = string.Empty;
            await StartprocessAsyncExit(
                process,
                output => Debug.WriteLine("At output"),
                violation =>
                {
                    if (violation.StartsWith(filePath))
                        standardsViolations += violation + Environment.NewLine;
                },
                () => {
                    if (!standardsViolations.Trim().IsWhiteSpace())
                    {
                        standardsViolations = standardsViolations.Remove(standardsViolations.Length - 1);
                        foreach (var violation in standardsViolations.Split(Environment.NewLine))
                        {
                            (int violationLine, string violationMsg) = GetViolationLineMessage(violation);
                            violationLine = violationLine == 0 ? 0 : violationLine - 1;
                            base.HighLightStandardError(violationLine, violationMsg);
                        }
                    }
                }
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
