using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class JavaCodeEditor : CodeEditorBase
    {
        private Process javaProcess;
        string latestOutput = "";
        private bool isWaitingForInput = false;
        private readonly string[] inputPrompts = {
    "Enter", "Input", "Please enter", "Type", ">", ":",
    "choice", "option", "select", "Press any key"
};

        public JavaCodeEditor(string filePath) : base(filePath){
            output.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    SendInput(output.Text.Replace(latestOutput, ""));
                }
            };
        }

        private string EnsureFlushAfterPrint()
        {
            string temporaryCode = "";
            string[] lines = srcCode.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                temporaryCode += line + Environment.NewLine;
                if (line.Contains(".print("))//naay bug pag dli println ang gamit kay mag expect pirmi ug \n ang code
                {
                    temporaryCode += "System.out.flush();" + Environment.NewLine;
                }
            }
            MessageBox.Show(temporaryCode);
            return temporaryCode;
        }

        public override void RunCode()
        {
            SaveCode(EnsureFlushAfterPrint());
            latestOutput = "";
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string compile = $"/c javac -cp \"{directory}\" {filePath} && java -cp \"{directory}\" {classname}";

            javaProcess = new Process();
            javaProcess.StartInfo.FileName = "cmd.exe";
            javaProcess.StartInfo.Arguments = compile; // or java ClassName
            javaProcess.StartInfo.UseShellExecute = false;
            javaProcess.StartInfo.RedirectStandardInput = true;
            javaProcess.StartInfo.RedirectStandardOutput = true;
            javaProcess.StartInfo.RedirectStandardError = true;
            javaProcess.StartInfo.CreateNoWindow = true;

            this.Invoke((Action)(() => output.Text = ""));

            javaProcess.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    this.Invoke((Action)(() => output.AppendText(e.Data + Environment.NewLine)));
                    latestOutput = output.Text;
                }
            };

            javaProcess.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    this.Invoke((Action)(() => output.AppendText(e.Data + Environment.NewLine)));
                }
            };
            javaProcess.Start();
            javaProcess.BeginOutputReadLine();
            javaProcess.BeginErrorReadLine();
            SaveCode(srcCode.Text);
        }

        private void SendInput(string input)
        {
            if (javaProcess != null && !javaProcess.HasExited)
            {
                javaProcess.StandardInput.WriteLine(input);
                javaProcess.StandardInput.Flush();
            }
        }
    }
}
