using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
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
        public JavaCodeEditor(string filePath, TaskModel task) : base(filePath, task)
        {
        }

        public async override void RunCode()
        {
            latestoutput = " ";
            this.Invoke((Action)(() => {
                output.ReadOnly = false;
            })); // clear
            SaveCode();
            CompileCode();

            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string compile = $"/c {ProgrammingConfiguration.javaExe} -cp \"{directory}\" {classname}";

            if (compiledSuccess)
            {
                process = CommandRunner(compile);

                await StartprocessAsync(
                    process,
                    outputLine => this.Invoke((Action)(() => { 
                        output.AppendText(outputLine + Environment.NewLine);
                        latestoutput = output.Text;
                    })),
                    errorLine => this.Invoke((Action)(() => output.AppendText(errorLine + Environment.NewLine))),
                    () => this.Invoke((Action)(() =>
                    {
                        output.AppendText("\n=== Process finished ===\n");
                        output.ReadOnly = true;
                    }))
                );
            }
        }
        public async override void CompileCode()
        {
            SaveCode();
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            process = CommandRunner($"/c {ProgrammingConfiguration.javac} -cp \"{directory}\" {filePath}");
            await StartprocessAsync(
                process,
                null,
                withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }
        public async override void RunLinting()
        {
            SaveCode();
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            process = CommandRunner($"/c cd {directory} && {ProgrammingConfiguration.javac} -Xlint {fileName}");

            await StartprocessAsyncExit(
                process,
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
            process = CommandRunner($"/c {ProgrammingConfiguration.javaExe} -jar {ProgrammingConfiguration.checkStylePath} -c {ProgrammingConfiguration.checkStyleConfig} {filePath}");
            string errorLine = "";
            await StartprocessAsyncExit(
                process,
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
            SaveCode();
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
                string compile = $"/c cd {directory} && {ProgrammingConfiguration.javac} Tester.java && {ProgrammingConfiguration.javaExe} Tester";
                process = CommandRunner(compile);
                string outputResult = "";
                string errorResult = "";
                await StartprocessAsyncExit(
                    process,
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
    }
}