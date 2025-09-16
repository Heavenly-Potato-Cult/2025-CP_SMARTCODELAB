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
        public CppCodeEditor(string filePath, TaskModel task) : base(filePath, task) 
        {

        }

        public override void RunCode()
        {
            string fileExe = Path.GetFileNameWithoutExtension(filePath);
            commandLine = $"/c cd {ProgrammingConfiguration.gccBin} && g++ {filePath} -o {fileExe}.exe && {fileExe}.exe";
            base.RunCode();
        }

        public override void RunTest()
        {
            commandLine = $"/c cd {ProgrammingConfiguration.gccBin} && g++ {Path.GetDirectoryName(filePath)+"\\Tester.cpp"} -o test.exe && test.exe";
            base.RunCode();
        }
    }
}
