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
    public class CppCodeEditor : BaseCodeEditor
    {
        public CppCodeEditor(string filePath, TaskModel task, string username) : base(filePath, task, username) 
        {

        }

        public async override void RunCode()
        {
            string fileExe = filePath.Replace(".cpp", ".exe");
            commandLine = $"/c {ProgrammingConfiguration.gccExe} {filePath} -o {fileExe} && {fileExe}";
            base.RunCode();
        }

        public override void RunTest()
        {
            commandLine = $"/c cd {ProgrammingConfiguration.gccBin} && g++ {Path.GetDirectoryName(filePath)+"\\Tester.cpp"} -o test.exe && test.exe";
            testerFile = Path.GetDirectoryName(filePath) + "\\\\" + "Tester.cpp";
            base.RunTest();
        }

        protected override void SendInput(string input)
        {
            if (process != null && !process.HasExited)
            {
                process.StandardInput.Write(input + Environment.NewLine);
                process.StandardInput.Flush();
            }
        }
    }
}
