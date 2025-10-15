using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class BaseCodeEditor : UserControl
    {
        protected string filePath;
        protected TaskModel task;

        protected readonly WavyLineStyle redWavy = new WavyLineStyle(255, Color.Red);
        protected readonly WavyLineStyle yellowWavy = new WavyLineStyle(255, Color.Orange);
        private string errorMsg = "";
        protected Dictionary<int, string> standardError;
        private int? errorLine = null;
        private System.Threading.Timer? _debounceTimer;
        private System.Threading.Timer? inputTimer;
        protected Action<int, int> updateStats;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<NotificationType, string>? notifAction { get; set; }//will be used to send activity notification to the server/host

        public StudentCodingProgress StudentProgress { get; }
        private string[] codeHistory = new string[20];

        //code all around services
        protected Process? process;
        protected string application;
        protected bool compiledSuccess = false;
        protected string commandLine = string.Empty;
        protected string latestoutput = string.Empty;
        protected string testerFile = string.Empty;

        public BaseCodeEditor()
        {
            InitializeComponent();
        }

        protected BaseCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int> updateStats, Func<Task> sendProgress)
        {
            InitializeComponent();
            this.updateStats = updateStats;
            standardError = new Dictionary<int, string>();
            this.task = task;
            this.filePath = filePath;
            srcCode.Text = File.ReadAllText(filePath);
            codeHistory[0] = srcCode.Text;

            //will initialize first, incase it is new
            StudentProgress = progress;

            RunLinting();// i check agad ang syntax ng code
            srcCode.ToolTipNeeded += (s, e) =>
            {
                if (errorLine != null && e.Place.iLine == errorLine)
                {
                    e.ToolTipText = errorMsg;
                }
                if (standardError.ContainsKey(e.Place.iLine))
                {
                    e.ToolTipText = standardError.GetValueOrDefault(e.Place.iLine, "No Error Found");
                }
            };
            int i = 0;
            srcCode.TextChanged += (s, e) =>
            {
                StudentProgress.CodeProgress.Add(srcCode.Text);
                _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                // Start a new timer
                _debounceTimer = new System.Threading.Timer(async _ =>
                {
                    RunLinting();
                    await CountComplexity1();
                    await sendProgress.Invoke();
                }, null, 700, Timeout.Infinite);

                //add the new source code to the code history
                codeHistory[i++ % 20] = srcCode.Text;
            };
            srcCode.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.S && e.Control)
                    SaveCode();
                else if (e.KeyCode == Keys.V && e.Control)
                {
                    if (Clipboard.ContainsText())
                    {
                        string pasted = Clipboard.GetText();
                        Task.Run(() => GetPastedCode(pasted, srcCode.Text, codeHistory));
                    }
                }
            };

            output.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Invoker(() => SendInput(output.ReadLine()));
                    inputTimerStarter();
                }
            };
        }

        private void GetPastedCode(string codeSnippet, string wholeCode, string[] history)
        {
            foreach (var item in history)
            {
                if (item != null && item != wholeCode && item.Contains(codeSnippet))
                {
                    return;//meaning this code is potentially not pasted from external source
                }
            }
            //if yes, now we will hunt if which line the new code was copy pasted
            string[] wholeCodeLines = wholeCode.Split("\n", StringSplitOptions.None);
            string[] pastedCodeLines = codeSnippet.Split("\n", StringSplitOptions.None);

            for (int i = 0; i < wholeCodeLines.Length; i++)
            {
                try
                {
                    if (wholeCodeLines[i].Trim() == pastedCodeLines[0].Trim() && wholeCodeLines[i + 1].Trim() == pastedCodeLines[1].Trim())
                    {
                        if (StudentProgress.pastedCode == null)
                            StudentProgress.pastedCode = new List<CopyPastedCode>();
                        StudentProgress.pastedCode.Add(new CopyPastedCode(wholeCode, i, i + (pastedCodeLines.Length - 1)));
                        notifAction?.Invoke(NotificationType.CopyPasted, "");
                        break;
                    }
                }
                catch (IndexOutOfRangeException) { }
            }

        }

        protected bool IsFileLocked(Exception exception)
        {
            int hr = Marshal.GetHRForException(exception) & ((1 << 16) - 1);
            return exception is IOException &&
                   (hr == 32 || hr == 33); // ERROR_SHARING_VIOLATION or ERROR_LOCK_VIOLATION
        }

        public void UpdateTask(TaskModel task)
        {
            this.task = task;
        }

        public StudentCodingProgress GetProgress(Dictionary<int, int> currentStats)
        {
            StudentProgress.sourceCode = srcCode.Text;
            StudentProgress.codeStats = currentStats;
            return StudentProgress;
        }

        protected Process CommandRunner(string command, bool didRunCode = false)
        {
            if (process != null)
            {
                try
                {
                    process.Kill();
                    process.Dispose();
                }
                catch (InvalidOperationException) { }
            }
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = "cmd.exe";
            newProcess.StartInfo.Arguments = command + (didRunCode ? " & pause" : "");
            newProcess.StartInfo.UseShellExecute = didRunCode;
            newProcess.StartInfo.RedirectStandardInput = !didRunCode;
            newProcess.StartInfo.RedirectStandardOutput = !didRunCode;
            newProcess.StartInfo.RedirectStandardError = !didRunCode;
            newProcess.StartInfo.CreateNoWindow = !didRunCode;

            return newProcess;
        }

        public void SaveCode(int maxRetries = 5, int retryDelayMs = 100, bool needChange = false)
        {
            int attempts = 0;
            while (attempts < maxRetries)
            {
                try
                {
                    string addedNewCin = needChange ? srcCode.Text.Replace("return", "string toEnsureThatAllIsWell;\ncin>> toEnsureThatAllIsWell;\n return") : srcCode.Text;
                    File.WriteAllText(filePath, addedNewCin);
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
            Invoker(() =>
            {
                output.Clear();
                output.WriteLine("Started" + Environment.NewLine);
                output.IsReadLineMode = true;
            });
            string exeptionThrown = string.Empty;
            SaveCode(5, 100);
            process = CommandRunner(commandLine);
            await StartprocessAsync(
                process,
                outp => {
                    Invoker(() => output.WriteLine(outp));
                    inputTimerStarter();
                },
                err => { 
                    Invoker(() => output.WriteLine(err + Environment.NewLine));
                    exeptionThrown += (err + "\n");
                },
                async () =>
                {
                    Invoker(() => output.WriteLine(Environment.NewLine + "Program Finished"));
                    output.IsReadLineMode = false;
                    inputTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                    if(exeptionThrown != "")
                        ExtractThrownExceptions(exeptionThrown);

                    bool isFilePython = filePath.EndsWith(".py");
                    if (!isFilePython)
                    {
                        string extension = filePath.EndsWith("cpp") ? "exe" : "class";
                        string delCommand = $"/c del {Path.Combine(Path.GetDirectoryName(filePath),"Main."+extension)}";
                        process = CommandRunner(delCommand);
                        await StartprocessAsyncExit(process, null, null, null);
                    }
                }
            );
        }

        private void ExtractThrownExceptions(string allExceptions)
        {
            //for java
            Task.Run(() =>
                {
                    if (filePath.EndsWith(".java"))
                    {
                        allExceptions = allExceptions.Remove(allExceptions.LastIndexOf('\n'));
                        string[] exceptions = allExceptions.Split("Exception in").Where(a => a != "").ToArray();
                        foreach (string exception in exceptions)
                        {
                            string exceptionLine = (exception.Split("\n")[0]);//separated by \t ang exception errors
                            string[] exceptionID = exceptionLine.Split('.');

                            /* then the exeption line can be split by '.', then get the last index since it is likely the exception object
                             * sample output "thread "main" java.util.InputMismatchException"
                             * 
                             * but if a student caught the Exception then created its own throw statement
                             * like this throw new InputMismatchException("mali imong gibutang"); will show
                             * Exception in thread "main" java.util.InputMismatchException: mali imong gibutang
                             *   at Main.main(Main.java:12)
                             * the 2nd statement block will be used
                            */
                            string exceptionMsg = exceptionID[exceptionID.Length - 1];
                            if (exceptionMsg.Contains(':'))
                                exceptionMsg = exceptionID[exceptionID.Length - 1].Split(':')[0]; //usually formatted as {exceptionObj}: {user message}

                            notifAction?.Invoke(NotificationType.ExceptionThrown, exceptionMsg);
                        }
                    }
                    else if(filePath.EndsWith(".py"))
                    {

                        //most likely the exception type is in the last line
                        //as last line contains two messages separated by colon {Exception}: {exceptionMessage}
                        string[] exceptions = allExceptions.Split("\n");
                        string specificException = exceptions[exceptions.Length - 2].Split(':')[0];
                        notifAction?.Invoke(NotificationType.ExceptionThrown, specificException);
                    }
                }
            );
        }

        public async virtual void RunTest()
        {
            SaveCode();
            if (task._testCases.Count == 0)
            {
                MessageBox.Show("No available test cases");
            }
            else {
                TestCodeForm testCodeForm = new TestCodeForm(commandLine, testerFile, task);
                testCodeForm.ShowDialog();
                int percentage = (testCodeForm.score / task._testCases.Count) * 100;
                updateStats?.Invoke(1, percentage);
            }
        }
        protected Task StartprocessAsync(Process process, Action<string> onOutput, Action<string> onError, Action onExit = null)
        {
            Invoker(() => output.Text = "Process Started" + Environment.NewLine);
            latestoutput = output.Text;

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    onError?.Invoke(e.Data);
            };

            process.Exited += (s, e) =>
            {
                compiledSuccess = process.ExitCode == 0;
                Thread.Sleep(99);
                onExit?.Invoke();
            };

            process.EnableRaisingEvents = true;
            process.Start();
            inputTimerStarter();
            try
            {
                Task.Run(async () =>
                {
                    var reader = process.StandardOutput;
                    char[] buffer = new char[256];
                    int read;
                    while ((read = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        string chunk = new string(buffer, 0, read);
                        onOutput?.Invoke(chunk);  // print partial output immediately
                    }
                });
            }
            catch (InvalidOperationException e)
            {
                Invoker(() => Debug.WriteLine(""));
            }
            process.BeginErrorReadLine();
            return Task.CompletedTask;
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

        protected virtual void SendInput(string input)
        {
            try
            {
                if (process != null && !process.HasExited)
                {
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Flush();
                }
            }
            catch (InvalidOperationException) { }
        }

        public virtual void RunLinting() { }

        public virtual void CheckCodingStandards(string command, Action reRun = null) { }

        protected void HighlightError(int errorLine, string errorMsg)
        {
            try
            {
                standardError.Remove(errorLine);
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(redWavy);
                this.errorLine = errorLine;
                this.errorMsg = errorMsg.Split(new string[] { "    " }, StringSplitOptions.None)[0];
            }
            catch (ArgumentOutOfRangeException) { }
        }

        protected virtual void HighLightStandardError(int errorLine, string msg)
        {
            try
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(yellowWavy);
                if (standardError.ContainsKey(errorLine))
                    standardError.Remove(errorLine);
                standardError.Add(errorLine, msg);
            }
            catch (ArgumentException) { }
        }

        protected void NoError()
        {
            errorLine = null;
            errorMsg = "";
            srcCode.Range.ClearStyle(yellowWavy);
            srcCode.Range.ClearStyle(redWavy);
        }

        private void CountComplexity()
        {
            updateStats?.Invoke(4, CodeComplexityReference.CodeComplexityCounter(filePath));
        }

        private Task CountComplexity1()
        {
            updateStats?.Invoke(4, CodeComplexityReference.CodeComplexityCounter(filePath));
            return Task.CompletedTask;
        }

        public static BaseCodeEditor BaseCodeEditorFactory(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int> updateStats, Func<Task> sendProgress)
        {
            if (filePath.EndsWith(".java"))
            {
                return new JavaCodeEditor(filePath, task, progress, updateStats, sendProgress);
            }
            else if (filePath.EndsWith(".py"))
            {
                return new PythonCodeEditor(filePath, task, progress, updateStats, sendProgress);
            }
            else
            {
                return new CppCodeEditor(filePath, task, progress, updateStats, sendProgress);
            }
        }

        private void Invoker(Action action) 
        {
            this.Invoke(action);
        }

        private void inputTimerStarter()
        {
            inputTimer?.Change(Timeout.Infinite, Timeout.Infinite);

            // Start a new timer
            inputTimer = new System.Threading.Timer(_ =>
            {
                output.IsReadLineMode = true;
                Invoker(() => SendInput(output.ReadLine()));
                output.IsReadLineMode = true;
            }, null, 700, Timeout.Infinite);
        }
    }
}
