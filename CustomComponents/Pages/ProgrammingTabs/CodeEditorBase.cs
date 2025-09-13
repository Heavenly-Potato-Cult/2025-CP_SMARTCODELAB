using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class CodeEditorBase : UserControl
    {
        ToolTip toolTip;
        protected string filePath;
        protected TaskModel _task;
        private readonly WavyLineStyle redWavy = new WavyLineStyle(255, Color.Red);
        private readonly WavyLineStyle yellowWavy = new WavyLineStyle(255, Color.Yellow);
        private System.Threading.Timer _debounceTimer;
        public StudentCodingProgress StudentProgress { get; }
        private string errorMsg = "";
        protected Dictionary<int, string> standardError;
        private int? errorLine = null;

        //code all around services
        protected Process process;
        protected bool compiledSuccess = false;
        protected string commandLine = string.Empty;
        protected string latestoutput = string.Empty;
        protected string testerFile = string.Empty;
        public CodeEditorBase(string filePath, TaskModel task)
        {
            InitializeComponent();
            toolTip = new ToolTip();
            standardError = new Dictionary<int, string>();
            srcCode.ToolTipNeeded += (s, e) =>
            {
                if (errorLine != null && e.Place.iLine == errorLine)
                {
                    e.ToolTipText = errorMsg;
                }
                if(standardError.ContainsKey(e.Place.iLine))
                {
                    e.ToolTipText = standardError.GetValueOrDefault(e.Place.iLine,"No Error Found");
                }
            };

            _task = task;
            StudentProgress = new StudentCodingProgress();
            this.filePath = filePath;
            srcCode.Text = File.ReadAllText(filePath);
            RunLinting();// i check agad ang syntax ng code
            srcCode.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.S && e.Control)
                    SaveCode();
                else if (e.KeyCode == Keys.F5)
                    RunCode();
                //else if (e.KeyCode == Keys.OemSemicolon || e.KeyCode == Keys.Enter)
                //{
                //    _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                //    // Start a new timer
                //    _debounceTimer = new System.Threading.Timer(_ =>
                //    {
                //        RunLinting();
                //    }, null, 0, Timeout.Infinite);
                //}
                else
                {
                    _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                    // Start a new timer
                    _debounceTimer = new System.Threading.Timer(_ =>
                    {
                        RunLinting();
                    }, null, 300, Timeout.Infinite);
                }
            };
            output.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && process != null && !process.HasExited)
                {
                    e.SuppressKeyPress = true; // prevent new line in textbox
                    Debug.WriteLine(latestoutput);
                    string inputLine = output.Text.Replace(latestoutput," ");
                    SendInput(inputLine);
                    output.AppendText(Environment.NewLine); // mimic Enter
                }
            };
        }

        protected Process CommandRunner(string command)
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


        private bool IsFileLocked(Exception exception)
        {
            int hr = Marshal.GetHRForException(exception) & ((1 << 16) - 1);
            return exception is IOException &&
                   (hr == 32 || hr == 33); // ERROR_SHARING_VIOLATION or ERROR_LOCK_VIOLATION
        }

        public StudentCodingProgress GetProgress()
        {
            return new StudentCodingProgress(srcCode.Text);
        }

        private void srcCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                File.WriteAllText(filePath, srcCode.Text);
                MessageBox.Show("File saved");
            }
            else
            {
                StudentProgress.sourceCode = srcCode.Text;
                StudentProgress.CodeProgress.Add(srcCode.Text);
            }
        }

        public void SaveCode(int maxRetries = 5, int retryDelayMs = 100)
        {
            int attempts = 0;

            while (attempts < maxRetries)
            {
                try
                {
                    File.WriteAllText(filePath, srcCode.Text);
                    return; // Success - exit method
                }
                catch (IOException ex) when (IsFileLocked(ex))
                {
                    attempts++;
                    if (attempts >= maxRetries)
                    {
                        throw new IOException($"Failed to save file after {maxRetries} attempts. File is still in use.", ex);
                    }

                    Thread.Sleep(retryDelayMs);
                    retryDelayMs *= 2; // Exponential backoff
                }
                catch (Exception ex)
                {
                    throw new IOException($"Error saving file: {ex.Message}", ex);
                }
            }
        }
        public virtual void CompileCode() { }

        public async virtual void RunCode()
        {
            latestoutput = " ";
            this.Invoke((Action)(() => {
                output.ReadOnly = false;
            }));
            SaveCode();

            process = CommandRunner(commandLine);

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

        public async virtual void RunTest()
        {
            SaveCode();
            this.Invoke((Action)(() =>
            {
                output.Text = "Process Started" + Environment.NewLine;
                output.ReadOnly = true;
            }));
            int score = 0;
            int i = 1;
            foreach (var item in _task._testCases)
            {

                // read + replace + write
                string testSrcCode = File.ReadAllText(testerFile);
                File.WriteAllText(testerFile, testSrcCode.Replace("userInput", item.Key));
                process = CommandRunner(commandLine);
                string outputResult = "";
                string errorResult = "";
                await StartprocessAsyncExit(
                    process,
                    outputMsg => outputResult += outputMsg,
                    errorMsg => outputResult += errorMsg,
                    null
                    );

                string result = "";
                string textOutput = string.IsNullOrEmpty(outputResult) ? errorResult : outputResult;
                score = (item.Value.Equals(outputResult)) ? score + 1 : score;
                result = $"""
                    Test Case {i++}
                    Input:{item.Key + Environment.NewLine}
                    Expected Output : {item.Value}
                    Actual Output   : {textOutput}
                    Result          : {(item.Value.Equals(textOutput) ? "Correct" : "Wrong")}
                    """ + Environment.NewLine;

                this.Invoke((Action)(() => {
                    output.AppendText(result + Environment.NewLine);
                }));
                File.WriteAllText(testerFile, testSrcCode.Replace(item.Key, "userInput"));
            }
            this.Invoke((Action)(() => {
                output.AppendText($"Score : {score}/{_task._testCases.Count}");
            }));
        }

        public virtual void RunLinting() { }
        public virtual void CheckCodingStandards() { }

        protected void HighlightError(int errorLine, string errorMsg)
        {
            var lineRange = srcCode.GetLine(errorLine);
            lineRange.SetStyle(redWavy);
            this.errorLine = errorLine;

            this.errorMsg = errorMsg.Split(new string[] { "    " }, StringSplitOptions.None)[0];
        }

        protected void HighLightStandardError(int errorLine, string msg)
        {
            try
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(yellowWavy);
                standardError.Add(errorLine, msg);
            }
            catch (ArgumentException) { }
        }

        protected void NoError()
        {
            errorLine = null;
            errorMsg = "";
            srcCode.Range.ClearStyle(StyleIndex.All);
        }
        protected async Task StartprocessAsync(Process process, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            this.Invoke((Action)(() => output.Text = "Process Started" + Environment.NewLine));
            latestoutput = output.Text;
            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onOutput?.Invoke(e.Data);
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };

            process.Exited += (s, e) =>
            {
                compiledSuccess = process.ExitCode == 0;
                onExit?.Invoke();
            };

            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        protected async Task StartprocessAsyncExit(Process process, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onOutput?.Invoke(e.Data);
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };

            process.Exited += (s, e) =>
            {
                compiledSuccess = process.ExitCode == 0;
                onExit?.Invoke();
            };

            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            await process.WaitForExitAsync();
        }

        protected void SendInput(string input)
        {
            if (process != null && !process.HasExited)
            {
                process.StandardInput.WriteLine(input);
                process.StandardInput.Flush();
            }
        }
    }
}
