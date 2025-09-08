using FastColoredTextBoxNS;
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

        public JavaCodeEditor(string filePath, TaskModel task) : base(filePath, task)
        {
            output.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
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
            this.Invoke((Action)(() =>
            {
                output.Text = "";
            }));
            _ = Task.Run(() => {
                SaveCode(srcCode.Text);
                CompileCode();
                string classname = Path.GetFileNameWithoutExtension(filePath);
                string directory = Path.GetDirectoryName(filePath);
                string compile = $"/c java -cp \"{directory}\" {classname}";
                if (compiledSuccess)
                {
                    latestOutput = "Process Started";
                    this.Invoke((Action)(() =>
                    {
                        output.Text = "Process Started" + Environment.NewLine;
                        output.ReadOnly = false;
                    }));
                    javaProcess = JavaProcess(compile);
                    StartJavaProcess(
                        javaProcess,
                        outputLine =>
                        {
                            this.Invoke((Action)(() => output.AppendText(outputLine + Environment.NewLine)));
                            latestOutput = output.Text;
                        },
                        errorLine => this.Invoke((Action)(() => output.AppendText(errorLine + Environment.NewLine))),
                        () => this.Invoke((Action)(() =>
                        {
                            output.AppendText("\n=== Process finished ===\n");
                            output.ReadOnly = true;
                        }))
                    );
                }
            });
        }

        private bool compiledSuccess = false;
        public override void CompileCode()
        {
            SaveCode(srcCode.Text);
            latestOutput = "";
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            javaProcess = JavaProcess($"/c javac -cp \"{directory}\" {filePath}");
            StartJavaProcess(
                javaProcess,
                null,
                withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }
        public override void RunLinting()
        {
            _ = Task.Run(() => {
                SaveCode(srcCode.Text);
                latestOutput = "";
                string fileName = Path.GetFileName(filePath);
                string directory = Path.GetDirectoryName(filePath);
                javaProcess = JavaProcess($"/c cd {directory} && javac -Xlint {fileName}");

                this.Invoke((Action)(() => output.Text = ""));

                javaProcess.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        this.Invoke((Action)(() => output.AppendText(e.Data + Environment.NewLine)));
                        latestOutput = output.Text;
                    }
                };

                string errorLine = "";
                javaProcess.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        errorLine += e.Data;

                    }
                };
                javaProcess.Start();
                javaProcess.BeginOutputReadLine();
                javaProcess.BeginErrorReadLine();
                javaProcess.WaitForExit();

                if(errorLine != "")
                {
                    string[] lines = errorLine.Split(":");
                    int lineIndex = int.Parse(lines[1]) - 1;
                    HighlightError(lineIndex);
                }else
                    srcCode.Range.ClearStyle(StyleIndex.All);
            });
        }

        public override void RunTest()
        {
            SaveCode(srcCode.Text);
            CompileCode();
            latestOutput = "Process Started";
            this.Invoke((Action)(() =>
            {
                output.Text = "Process Started" + Environment.NewLine;
                output.ReadOnly = true;
            }));
            Task.Run(() =>
            {
                int score = 0;
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
                    string outputResult = "";
                    string errorResult = "";
                    StartJavaProcess(
                        javaProcess,
                        outputMsg => outputResult+=outputMsg,
                        errorMsg => outputResult+=errorMsg,
                        null
                        );

                    string result = "";
                    score = (item.Value.Equals(outputResult)) ? score+1 : score;
                    if (outputResult != "")
                        result = $"""
                            Test Case {i++}
                            Input:{item.Key + Environment.NewLine}
                            Expected Output : {item.Value}
                            Actual Output   : {outputResult}
                            Result          : {(item.Value.Equals(outputResult) ? "Correct" : "Wrong")}
                            """ + Environment.NewLine;
                    else
                        result = $"""
                            Test Case {i++}
                            Input:{item.Key + Environment.NewLine}
                            Expected Output : {item.Value}
                            Actual Output   : {errorResult}
                            Result          : Wrong
                            """ + Environment.NewLine;

                    this.Invoke((Action)(() => { 
                        output.AppendText(result+ Environment.NewLine);
                        }));
                    File.WriteAllText(testerFile, testSrcCode.Replace(item.Key, "userInput"));
                }
                this.Invoke((Action)(() => {
                    output.AppendText($"Score : {score}/{_task._testCases.Count}");
                }));
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

        private void StartJavaProcess(Process javaProcess, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            javaProcess.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    onOutput?.Invoke(e.Data);
                }
            };

            javaProcess.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };


            if (onExit != null)
            {
                javaProcess.Exited += (s, e) => onExit();
            }

            javaProcess.EnableRaisingEvents = true;
            javaProcess.Start();
            javaProcess.BeginOutputReadLine();
            javaProcess.BeginErrorReadLine();
            javaProcess.WaitForExit();

            compiledSuccess = javaProcess.ExitCode == 0;
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