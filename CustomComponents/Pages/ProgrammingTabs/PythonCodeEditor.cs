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
            process = CommandRunner($"/c {ProgrammingConfiguration.pylintExe} {filePath}");
            string lintOutput = "";
            await StartprocessAsyncExit(
                process,
                err => lintOutput += (err + Environment.NewLine),
                null,
                () => Debug.WriteLine(lintOutput));
        }
    }
}
