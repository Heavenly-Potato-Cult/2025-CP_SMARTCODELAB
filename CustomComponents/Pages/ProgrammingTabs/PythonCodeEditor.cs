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
    public class PythonCodeEditor : CodeEditorBase
    {
        public PythonCodeEditor(string filePath, TaskModel task) : base(filePath, task) 
        {
            
        }

        public async override void RunCode()
        {
            SaveCode();
            latestoutput = " ";
            this.Invoke((Action)(() =>
            {
                output.ReadOnly = false;
            }));
            string compileCmd = $"/c {ProgrammingConfiguration.pythonExe} {filePath}";
            process = CommandRunner(compileCmd);
            await StartprocessAsync(
                process,
                outp => this.Invoke((Action)(() => { 
                    output.AppendText(outp + Environment.NewLine);
                    latestoutput = output.Text;
                    Debug.WriteLine(latestoutput);
                })),
                errorL => this.Invoke((Action)(() => output.AppendText(errorL + Environment.NewLine))),
                () => this.Invoke((Action)(() =>
                {
                    output.AppendText("\n=== Process finished ===\n");
                    output.ReadOnly = true;
                }))
            );
        }
    }
}
