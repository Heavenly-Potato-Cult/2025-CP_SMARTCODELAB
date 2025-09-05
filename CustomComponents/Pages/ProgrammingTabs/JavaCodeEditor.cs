using SmartCodeLab.Models;
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
        private Process javaProcess;
        string latestOutput = "";
        private bool isWaitingForInput = false;
        private readonly string[] inputPrompts = {
    "Enter", "Input", "Please enter", "Type", ">", ":",
    "choice", "option", "select", "Press any key"
};

        public JavaCodeEditor(string filePath, TaskModel task) : base(filePath, task){
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
            SaveCode(srcCode.Text);
            CompileCode();
            latestOutput = "==============\n";
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string compile = $"/c java -cp \"{directory}\" {classname}";

            javaProcess = JavaProcess(compile);

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
        }

        public override void CompileCode()
        {
            SaveCode(srcCode.Text);
            latestOutput = "";
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            javaProcess = JavaProcess($"/c javac -cp \"{directory}\" {filePath}");

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
            javaProcess.WaitForExit();
        }

        public override void RunTest()
        {
            SaveCode(srcCode.Text);
            CompileCode();
            latestOutput = "==========\n";
            Task.Run(() =>
            {
                int i = 1;
                foreach (var item in _task._testCases)
                {
                    string directory = Path.GetDirectoryName(filePath);
                    string testerFile = Path.Combine(directory, "Tester.java");

                    // read + replace + write
                    string testSrcCode = File.ReadAllText(testerFile);
                    File.WriteAllText(testerFile, testSrcCode.Replace("userInput", item.Key));
                    string compile = $"/c cd {directory} && javac Tester.java && java Tester";
                    javaProcess = JavaProcess(compile);
                    javaProcess.OutputDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            this.Invoke((Action)(() => output.AppendText($"""
                            Test Case {i++}
                            Input:{item.Key + Environment.NewLine}
                            Expected Output : {item.Value}
                            Actual Output   : {e.Data}
                            Result          : {(item.Value.Equals(e.Data) ? "Correct" : "Wrong")}
                            """+ Environment.NewLine)));
                        }
                    };

                    javaProcess.ErrorDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            this.Invoke((Action)(() => output.AppendText($"""
                            Test Case {i++}
                            Input:
                                {item.Key + Environment.NewLine}
                            Expected Output : {item.Value}
                            Actual Output   : {e.Data}
                            """ + Environment.NewLine)));
                        }
                    };

                    javaProcess.Start();
                    javaProcess.BeginOutputReadLine();
                    javaProcess.BeginErrorReadLine();
                    javaProcess.WaitForExit(); // safe here, since inside Task.Run
                    File.WriteAllText(testerFile, testSrcCode.Replace(item.Key,"userInput"));
                }
            });
        }

        private void SendInput(string input)
        {
            if (javaProcess != null && !javaProcess.HasExited)
            {
                javaProcess.StandardInput.WriteLine(input);
                javaProcess.StandardInput.Flush();
            }
        }

        private Process JavaProcess(string command)
        {
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = "cmd.exe";
            newProcess.StartInfo.Arguments = command; // or java ClassName
            newProcess.StartInfo.UseShellExecute = false;
            newProcess.StartInfo.RedirectStandardInput = true;
            newProcess.StartInfo.RedirectStandardOutput = true;
            newProcess.StartInfo.RedirectStandardError = true;
            newProcess.StartInfo.CreateNoWindow = true;

            return newProcess;
        }
    }
}
