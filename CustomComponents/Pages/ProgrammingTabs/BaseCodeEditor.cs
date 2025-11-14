using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Shapes;
using Path = System.IO.Path;
namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class BaseCodeEditor : UserControl
    {
        protected string filePath;
        protected TaskModel task;

        //different highlight styles
        protected readonly WavyLineStyle syntaxErrorHighlight = new WavyLineStyle(255, Color.Red);
        protected readonly WavyLineStyle readabilityHighlight = new WavyLineStyle(255, Color.Orange);
        protected readonly WavyLineStyle robustnessHighlight = new WavyLineStyle(255, Color.Green);
        protected readonly WavyLineStyle maintainabilityHighlight = new WavyLineStyle(255, Color.Blue);

        //stores the different errors and warnings, the error line is the key, message is the value
        protected Dictionary<int, string> standardError;
        protected Dictionary<int, string> readabilityWarning;
        protected Dictionary<int, string> maintainabilityWarning;
        protected Dictionary<int, string> robustnessWarning;
        private List<KeyValuePair<int,string>> lineErrorAndMessage;

        //detected violated rules
        protected HashSet<string> readabilityRules;
        protected HashSet<string> maintainabilityRules;
        protected HashSet<string> robustnessRules;

        protected string maintainabilityCheck = string.Empty;

        protected List<KeyValuePair<string, string>> mgaGinawangTama;

        private Func<Task> sendProgress;
        private string acceptedCode;
        private string errorMsg = "";
        private System.Threading.Timer? _debounceTimer;
        private System.Threading.Timer? inputTimer;
        protected Action<int, int, string> updateStats;

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

            srcCode.MouseWheel += (s, e) =>
            {
                if ((Control.ModifierKeys & Keys.Control) == 0)
                {
                    return;
                }

                const int MAX_ZOOM = 300;
                const int MIN_ZOOM = 30;
                const int ZOOM_STEP = 10;

                int currentZoom = srcCode.Zoom;
                int newZoom = currentZoom;


                if (e.Delta > 0)
                {
                    newZoom += ZOOM_STEP;
                }

                if (e.Delta < 0)
                {
                    newZoom -= ZOOM_STEP;
                }
                newZoom = Math.Clamp(newZoom, MIN_ZOOM, MAX_ZOOM);

                if (newZoom == currentZoom)
                {
                    return;
                }

                srcCode.Zoom = newZoom;

                if (e is HandledMouseEventArgs handleMouseEventArgs)
                {
                    handleMouseEventArgs.Handled = true;
                }

            };
        }

        protected BaseCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress)
        {
            InitializeComponent();
            this.updateStats = updateStats;
            standardError = new Dictionary<int, string>();
            readabilityWarning = new Dictionary<int, string>();
            maintainabilityWarning = new Dictionary<int, string>();
            robustnessWarning = new Dictionary<int, string>();
            lineErrorAndMessage = new List<KeyValuePair<int, string>>();

            readabilityRules = new HashSet<string>();
            maintainabilityRules = new HashSet<string>();
            robustnessRules = new HashSet<string>();

            acceptedCode = "";
            this.task = task;
            this.filePath = filePath;
            srcCode.Text = File.ReadAllText(filePath);
            codeHistory[0] = srcCode.Text;

            //will initialize first, incase it is new
            StudentProgress = progress;
            this.sendProgress = sendProgress;
            new Action(async () => await RunLinting()).Invoke();
            srcCode.ToolTipNeeded += (s, e) =>
            {
                string msg = "";

                List<KeyValuePair<int, string>> errorLines = lineErrorAndMessage;
                List<string> messages = errorLines.Where(kv => kv.Key == e.Place.iLine).Select(kv => kv.Value).ToList();
                foreach (var item in messages)
                {
                    msg += (item + Environment.NewLine);
                }
                e.ToolTipText = msg;
            };
            int i = 0;
            srcCode.TextChanged += (s, e) =>
            {
                StudentProgress.CodeProgress.Add(srcCode.Text);
                _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                // Start a new timer
                _debounceTimer = new System.Threading.Timer(async _ =>
                {
                    await RunLinting();
                    //await CountComplexity1();
                    await this.sendProgress.Invoke();
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
        }

        private void GetPastedCode(string codeSnippet, string wholeCode, string[] history)
        {
            if (StudentProgress.pastedCode == null)
                StudentProgress.pastedCode = new List<CopyPastedCode>();

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
                if(pastedCodeLines.Length == 1)
                {
                    if (wholeCodeLines[i].Trim().Contains(pastedCodeLines[0].Trim()))
                    {
                        StudentProgress.pastedCode.Add(new CopyPastedCode(wholeCode, i, i));
                        notifAction?.Invoke(NotificationType.CopyPasted, "");
                        break;
                    }
                }
                else
                {
                    try
                    {
                        if (wholeCodeLines[i].Trim().Contains(pastedCodeLines[0].Trim()) && wholeCodeLines[i + (pastedCodeLines.Length - 1)].Trim() == pastedCodeLines[pastedCodeLines.Length - 1].Trim())
                        {
                            StudentProgress.pastedCode.Add(new CopyPastedCode(wholeCode, i, i + (pastedCodeLines.Length - 1)));
                            notifAction?.Invoke(NotificationType.CopyPasted, "");
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException) { }
                }

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

        public StudentCodingProgress GetProgress(CodeRating codeRating)
        {
            StudentProgress.sourceCode = srcCode.Text;
            StudentProgress.codeRating = codeRating;
            return StudentProgress;
        }

        protected Process CommandRunner(string command, bool didRunCode = false)
        {
            if (process != null)
            {
                try
                {
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

        public async virtual Task RunCode()
        {
            if (errorMsg != "")
            {
                MessageBox.Show("Code contains syntax errors");
                return;
            }
            process.Start();
            output.AttachProcess(process);
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

        public virtual async void RunTest()
        {
            if (errorMsg != "")
            {
                MessageBox.Show("Code contains syntax errors");
                return;
            }
            SaveCode();
            if (task._testCases.Count == 0)
            {
                MessageBox.Show("No available test cases");
            }
            else
            {
                TestCodeForm testCodeForm = new TestCodeForm(commandLine, task);
                testCodeForm.ShowDialog();
                mgaGinawangTama = testCodeForm.corrects;
                updateStats?.Invoke(1, testCodeForm.score, null);
                if (task._testCases.Count == testCodeForm.score)
                {
                    acceptedCode = srcCode.Text;
                }
                await RunLinting();
                await sendProgress.Invoke();
            }
        }

        protected int computeEfficiency(int studentGrowth, int bestGrowth)
        {
            if (studentGrowth < Math.Pow(bestGrowth, 2))
                return 100;
            else if (studentGrowth < Math.Pow(bestGrowth, 3))
                return 67;
            else
                return 33;
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
            catch (InvalidOperationException)
            {
                Invoker(() => Debug.WriteLine(""));
            }
            process.BeginErrorReadLine();
            return Task.CompletedTask;
        }

        public static string ExecuteCommandCaptureOutput(string command, string input)
        {
            if (string.IsNullOrWhiteSpace(command))
                return string.Empty;

            // Build ProcessStartInfo
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                // Use /C to run the command then exit. If the command contains special characters or is complex,
                // consider wrapping in quotes: Arguments = "/C \"" + command + "\"";
                Arguments = command,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8
            };

            try
            {
                using var proc = new Process { StartInfo = psi };

                proc.Start();

                // Write input (if any) and close stdin so the process knows there's no more data.
                if (!string.IsNullOrEmpty(input))
                {
                    proc.StandardInput.Write(input);
                }
                proc.StandardInput.Close();

                // Read both streams. ReadToEnd is fine here because we've closed stdin and will call WaitForExit().
                string stdout = proc.StandardOutput.ReadToEnd();
                string stderr = proc.StandardError.ReadToEnd();

                proc.WaitForExit();

                // Combine outputs (stdout first, then stderr). Adjust formatting as you prefer.
                if (string.IsNullOrEmpty(stderr))
                    return stdout.Substring(stdout.LastIndexOf(':')+1);
                if (string.IsNullOrEmpty(stdout))
                    return stderr;

                return stdout + Environment.NewLine + "=== STDERR ===" + Environment.NewLine + stderr;
            }
            catch (Exception ex)
            {
                // Decide how you want to handle exceptions. Here we return the exception message as output.
                // In a production system you'd likely log the error or rethrow.
                return $"[CmdRunner Exception] {ex.GetType().Name}: {ex.Message}";
            }
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
        public virtual async Task RunLinting() { }

        protected void HighlightError(int errorLine, string errorMsg)
        {
            try
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(syntaxErrorHighlight);
                lineErrorAndMessage.Add(new KeyValuePair<int, string>(errorLine, errorMsg));

                this.errorMsg += errorMsg + Environment.NewLine;
            }
            catch (ArgumentOutOfRangeException) { }
        }

        //protected virtual void HighLightStandardError(int errorLine, string msg)
        //{
        //    try
        //    {
        //        var lineRange = srcCode.GetLine(errorLine);
        //        lineRange.SetStyle(readabilityHighlight);
        //        lineErrorAndMessage.Add(new KeyValuePair<int, string>(errorLine, msg));
        //    }
        //    catch (ArgumentException) { }
        //}

        protected virtual void HighlightMaintainabilityIssue(int errorLine, string msg)
        {
            try
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(maintainabilityHighlight);
                lineErrorAndMessage.Add(new KeyValuePair<int, string>(errorLine, msg));
            }
            catch (ArgumentException) { }
        }

        protected virtual void HighlightRobustnessIssue(int errorLine, string msg)
        {
            try
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(robustnessHighlight);
                lineErrorAndMessage.Add(new KeyValuePair<int, string>(errorLine, msg));
            }
            catch (ArgumentException) { }
        }

        protected void NoError()
        {
            errorMsg = "";
            srcCode.Range.ClearStyle(syntaxErrorHighlight);
            srcCode.Range.ClearStyle(readabilityHighlight);
            srcCode.Range.ClearStyle(maintainabilityHighlight);
            srcCode.Range.ClearStyle(robustnessHighlight);
            lineErrorAndMessage?.Clear();
        }

        public static BaseCodeEditor BaseCodeEditorFactory(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress)
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

        public bool isCurrentCodeAccepted()
        {
            if (acceptedCode == "")
                return false;

            return srcCode.Text == acceptedCode;
        }

        protected void Invoker(Action action) 
        {
            this.Invoke(action);
        }

        public List<HashSet<string>> GetViolatedRules()
        {
            return new List<HashSet<string>>()
            {
                readabilityRules,
                maintainabilityRules,
                robustnessRules
            };
        }
    }
}
