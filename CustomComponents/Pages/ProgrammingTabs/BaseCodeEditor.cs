using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class BaseCodeEditor : UserControl
    {
        protected string filePath;
        protected TaskModel task;
        private string possibleProgDirectory;

        protected readonly WavyLineStyle redWavy = new WavyLineStyle(255, Color.Red);
        protected readonly WavyLineStyle yellowWavy = new WavyLineStyle(255, Color.Orange);
        private string errorMsg = "";
        protected Dictionary<int, string> standardError;
        private int? errorLine = null;
        private System.Threading.Timer? _debounceTimer;
        private System.Threading.Timer? inputTimer;
        protected Action<int, int> updateStats;

        //will be used to send activity notification to the server/host

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

        protected BaseCodeEditor(string filePath, TaskModel task, string userName, Action<int, int> updateStats)
        {
            InitializeComponent();
            this.updateStats = updateStats;
            standardError = new Dictionary<int, string>();
            this.task = task;
            this.filePath = filePath;
            srcCode.Text = File.ReadAllText(filePath);
            codeHistory[0] = srcCode.Text;

            //will initialize first, incase it is new
            StudentProgress = new StudentCodingProgress();
            StudentProgress.sourceCode = srcCode.Text;
            StudentProgress.CodeProgress.Add(srcCode.Text);

            possibleProgDirectory = Path.Combine(Path.GetDirectoryName(filePath), $"{task._taskName}_{userName}_{Path.GetExtension(filePath)}_prog.bin");
            if (File.Exists(possibleProgDirectory))
                StudentProgress = StudentCodingProgress.Deserialize(possibleProgDirectory);

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
                _debounceTimer = new System.Threading.Timer(_ =>
                {
                    RunLinting();
                    SaveStudentProgressFile();
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
            SaveStudentProgressFile();
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

        private async void SaveStudentProgressFile()
        {
            await StudentProgress.SaveFile(possibleProgDirectory);
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

        public StudentCodingProgress GetProgress()
        {
            StudentProgress.sourceCode = srcCode.Text;
            return StudentProgress;
        }

        protected Process CommandRunner(string command)
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
            newProcess.StartInfo.Arguments = command;
            newProcess.StartInfo.UseShellExecute = false;
            newProcess.StartInfo.RedirectStandardInput = true;
            newProcess.StartInfo.RedirectStandardOutput = true;
            newProcess.StartInfo.RedirectStandardError = true;
            newProcess.StartInfo.CreateNoWindow = true;

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

        private bool isNotDone;
        public async virtual void RunCode()
        {
            isNotDone = true;
            this.Invoke((Action)(() =>
            {
                output.Clear();
                output.WriteLine("Started" + Environment.NewLine);
                output.IsReadLineMode = true;
            }));

            SaveCode(5, 100);
            process = CommandRunner(commandLine);
            await StartprocessAsync(
                process,
                outp => output.WriteLine(outp + Environment.NewLine),
                err => output.WriteLine(err + Environment.NewLine),
                () =>
                {
                    output.WriteLine("Program Finished");
                    isNotDone = false;
                }
            );

            Task.Run(() =>
            {
                do
                {
                    SendInput(output.ReadLine());
                    Thread.Sleep(10);
                } while (isNotDone);
            });
        }

        public async virtual void RunTest()
        {
            SaveCode();
            output.Clear();
            if (task._testCases == null || task._testCases.Count == 0)
            {
                output.WriteLine("No test Case Available");
                return;
            }
            output.WriteLine("Process Started" + Environment.NewLine);
            output.IsReadLineMode = false;
            int score = 0;
            int i = 1;
            foreach (var item in task._testCases)
            {
                // read + replace + write
                string testSrcCode = File.ReadAllText(testerFile);
                string input = item.Key;

                if (filePath.EndsWith(".cpp"))//if the file is cpp, because it needs to be passed using echo per input/line
                {
                    string[] lines = input.Split(Environment.NewLine);
                    string newInput = "echo ";
                    for (int num = 0; num < lines.Length; num++)
                    {
                        newInput += lines[num];
                        newInput += num != lines.Length - 1 ? " & echo " : "";
                    }
                    input = newInput;
                }
                else if (filePath.EndsWith(".py"))
                {
                    string[] lines = input.Split(Environment.NewLine);
                    string newInput = "";
                    foreach (var item1 in lines)
                    {
                        newInput += item1 + "\\n";
                    }
                    input = newInput.Remove(newInput.Length - 2);
                }
                File.WriteAllText(testerFile, testSrcCode.Replace("userInput", input));
                process = CommandRunner(commandLine);
                string outputResult = "";
                string errorResult = "";
                Stopwatch sw = new Stopwatch();
                sw.Start();
                await StartprocessAsyncExit(
                    process,
                    outputMsg => { outputResult += outputMsg; Debug.WriteLine($"Memory Usage: {process.WorkingSet64 / (1024 * 1024)} MB"); },
                    errorMsg => outputResult += errorMsg,
                    () =>
                    {
                        sw.Stop();
                        Debug.WriteLine(sw.Elapsed.ToString());
                    }
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

                output.WriteLine(result + Environment.NewLine);
                File.WriteAllText(testerFile, testSrcCode.Replace(input, "userInput"));
            }
            output.WriteLine($"Score : {score}/{task._testCases.Count}");
            notifAction?.Invoke(NotificationType.TestResult, $"{score}/{task._testCases.Count}");
            int percentage = (score / task._testCases.Count) * 100;
            updateStats?.Invoke(1, percentage);
        }

        public virtual void RunLinting() { }
        public virtual void CheckCodingStandards(string command, Action reRun = null) { }

        protected void HighlightError(int errorLine, string errorMsg)
        {
            standardError.Remove(errorLine);
            var lineRange = srcCode.GetLine(errorLine);
            lineRange.SetStyle(redWavy);
            this.errorLine = errorLine;
            this.errorMsg = errorMsg.Split(new string[] { "    " }, StringSplitOptions.None)[0];
        }

        protected virtual void HighLightStandardError(int errorLine, string msg)
        { }

        protected void NoError()
        {
            errorLine = null;
            errorMsg = "";
            srcCode.Range.ClearStyle(yellowWavy);
            srcCode.Range.ClearStyle(redWavy);
        }
        protected Task StartprocessAsync(Process process, Action<string> onOutput, Action<string> onError, Action onExit = null)
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
                Thread.Sleep(99);
                onExit?.Invoke();
            };

            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
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

        public static BaseCodeEditor BaseCodeEditorFactory(string filePath, TaskModel task, string username, Action<int, int> updateStats)
        {
            if (filePath.EndsWith(".java"))
            {
                return new JavaCodeEditor(filePath, task, username, updateStats);
            }
            else if (filePath.EndsWith(".py"))
            {
                return new PythonCodeEditor(filePath, task, username, updateStats);
            }
            else
            {
                return new CppCodeEditor(filePath, task, username, updateStats);
            }
        }
    }
}
