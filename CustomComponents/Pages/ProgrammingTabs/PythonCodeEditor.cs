using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class PythonCodeEditor : BaseCodeEditor
    {
        public PythonCodeEditor(string filePath, TaskModel task, string username, Action<int, int> updateStats) : base(filePath, task, username, updateStats) 
        {
            
        }

        public override void RunCode()
        {
            commandLine = $"/c {ProgrammingConfiguration.pythonExe} {filePath}";
            base.RunCode();
            //SaveCode();
            //latestoutput = " ";
            //this.Invoke((Action)(() =>
            //{
            //    output.ReadOnly = false;
            //}));
            //process = CommandRunner(compileCmd);
            //await StartprocessAsync(
            //    process,
            //    outp => this.Invoke((Action)(() => { 
            //        output.AppendText(outp + Environment.NewLine);
            //        latestoutput = output.Text;
            //    })),
            //    errorL => this.Invoke((Action)(() => output.AppendText(errorL + Environment.NewLine))),
            //    () => this.Invoke((Action)(() =>
            //    {
            //        output.AppendText("\n=== Process finished ===\n");
            //        output.ReadOnly = true;
            //    }))
            //);
        }

        public override void RunTest()
        {
            string directory = Path.GetDirectoryName(filePath);
            testerFile = Path.Combine(directory, "Tester.py");
            commandLine = $"/c {ProgrammingConfiguration.pythonExe} \"{testerFile}\"";
            base .RunTest();
            //SaveCode();
            //this.Invoke((Action)(() =>
            //{
            //    output.Text = "Process Started" + Environment.NewLine;
            //    output.ReadOnly = true;
            //}));
            //int score = 0;
            //int i = 1;
            //foreach (var item in _task._testCases)
            //{
            //    // read + replace + write
            //    string testSrcCode = File.ReadAllText(testerFile);
            //    File.WriteAllText(testerFile, testSrcCode.Replace("userInput", item.Key));
            //    process = CommandRunner(compile);
            //    string outputResult = "";
            //    string errorResult = "";
            //    await StartprocessAsyncExit(
            //        process,
            //        outputMsg => outputResult += outputMsg,
            //        errorMsg => outputResult += errorMsg,
            //        null
            //        );

            //    string result = "";
            //    string textOutput = string.IsNullOrEmpty(outputResult) ? errorResult : outputResult;
            //    score = (item.Value.Equals(outputResult)) ? score + 1 : score;
            //    result = $"""
            //        Test Case {i++}
            //        Input:{item.Key + Environment.NewLine}
            //        Expected Output : {item.Value}
            //        Actual Output   : {textOutput}
            //        Result          : {(item.Value.Equals(textOutput) ? "Correct" : "Wrong")}
            //        """ + Environment.NewLine;

            //    this.Invoke((Action)(() => {
            //        output.AppendText(result + Environment.NewLine);
            //    }));
            //    File.WriteAllText(testerFile, testSrcCode.Replace(item.Key, "userInput"));
            //}
            //this.Invoke((Action)(() => {
            //    output.AppendText($"Score : {score}/{_task._testCases.Count}");
            //}));
        }
    }
}
