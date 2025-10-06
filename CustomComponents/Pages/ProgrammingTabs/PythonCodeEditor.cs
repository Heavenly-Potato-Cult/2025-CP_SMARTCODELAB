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
        public PythonCodeEditor(string filePath, TaskModel task, string username, StudentCodingProgress progress, Action<int, int> updateStats) : base(filePath, task, username, progress, updateStats) 
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
            commandLine = $"/c {ProgrammingConfiguration.pythonExe} \"{testerFile}\"";
            base .RunTest();
        }

        public async override void RunLinting()
        {
            SaveCode();
            Debug.WriteLine($"/c {ProgrammingConfiguration.pylintExe} --rcfile={ProgrammingConfiguration.pylintConfig} {filePath}");
            process = CommandRunner($"/c {ProgrammingConfiguration.pylintExe} --rcfile={ProgrammingConfiguration.pylintConfig} {filePath}");
            string lintOutput = "Output";
            await StartprocessAsyncExit(
                process,
                err => lintOutput += (err + Environment.NewLine),
                err => lintOutput += (err + Environment.NewLine),
                () => Debug.WriteLine(lintOutput));
        }
    }
}
