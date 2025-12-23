using SmartCodeLab.CustomComponents.SteamThings;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class TestCodeForm : Form
    {
        public int score;
        private int totalCases;
        public List<KeyValuePair<string, string>> corrects;
        private string command;
        private TaskModel task;
        private Process process;
        private bool isFromHost;
        private CancellationTokenSource processCts;
        public Dictionary<string, int> inputOperatorsCount;
        bool isOpen;
        public TestCodeForm()
        {
            InitializeComponent();
        }
        public TestCodeForm(string command, TaskModel task, bool isFromHost = false)
        {
            InitializeComponent();
            isOpen = true;
            this.isFromHost = isFromHost;
            inputOperatorsCount = new Dictionary<string, int>();
            corrects = new List<KeyValuePair<string, string>>();
            score = 0;
            this.command = command;
            this.task = task;
            totalCases = task?._testCases?.Count ?? 0;
            this.Load += (s, e) => RunTest();
            this.FormClosing += TestCodeForm_FormClosing;
            this.isFromHost = isFromHost;
        }

        private void TestCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isOpen = false;
            processCts?.Cancel();
            try
            {
                if (process != null && !process.HasExited)
                {
                    try
                    {
                        KillProcessTree(process.Id);
                        process.WaitForExit(3000);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error killing process: {ex.Message}");
                    }
                }
            }
            catch (InvalidOperationException) { }
        }

        private void KillProcessTree(int processId)
        {
            try
            {
                using var pKiller = new Process();
                pKiller.StartInfo.FileName = "taskkill";
                pKiller.StartInfo.Arguments = $"/pid {processId} /t /f";
                pKiller.StartInfo.UseShellExecute = false;
                pKiller.StartInfo.CreateNoWindow = true;
                pKiller.Start();
                pKiller.WaitForExit(5000);
            }
            catch (Exception)
            {
                try
                {
                    Process.GetProcessById(processId)?.Kill();
                }
                catch { }
            }
        }

        private async void RunTest()
        {
            score = 0;
            int sequence = 1;

            foreach (var item in task._testCases)
            {
                if (!isOpen)
                    break;
                if (task._language == Models.Enums.LanguageSupported.Cpp)
                {
                    // Give Windows time to release the file lock
                    await Task.Delay(100); // 100ms delay for C++
                }
                string input = item.Key;
                string testOutput = "";

                // CRITICAL FIX: Add delay between test cases to allow file release
                if (sequence > 1)
                {
                    await Task.Delay(200); // Wait 200ms between test cases
                }

                // IMPORTANT: Create new process for each test case

                processCts = new CancellationTokenSource();
                using (process = CommandRunner(command))
                {
                    try
                    {
                        await StartprocessAsyncExit(
                            process,
                            output => {
                                if(!output.Contains("Total Operators Counted By This Code", StringComparison.OrdinalIgnoreCase))
                                    testOutput += (output + '\n');
                                else if(isFromHost)
                                {
                                    // Extract operator count
                                    var parts = output.Split(':');
                                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int count))
                                    {
                                        inputOperatorsCount[input] = count;
                                    }
                                }
                            },
                            error => testOutput += (error),
                            input,
                            null,
                            processCts.Token
                        );
                    }
                    catch (TimeoutException)
                    {
                        testOutput = """
                            Error: Test case timed out
                            Common causes:
                            - Excessive input operations
                            - Input statements inside loops
                            - Delays or pauses in code execution
                            """;
                    }
                    catch (Exception ex)
                    {
                        testOutput = $"Error: {ex.Message}";
                    }
                } // Process is disposed here
                if(isFromHost)
                    Debug.WriteLine($"Input: {input}, Operators Count: {inputOperatorsCount.GetValueOrDefault(input, -1)}");
                testOutput = Normalize(testOutput.Trim());
                string expectedOutput = Normalize(item.Value.Trim());
                bool isCorrect = testOutput == expectedOutput;
                // Create test case UI
                var testcase = new ExpansionPanel();
                var testcaseview = new TestCaseResult2(sequence, isCorrect, item.Key, expectedOutput, testOutput);
                testcase.Title1 = "Test Case " + sequence.ToString();
                

                if (isCorrect)
                {
                    testcase.HeaderColor = Color.FromArgb(40, 0, 255, 100);
                    testcase.Title2 = "Correct";
                    testcase.Title1Theme = SteamLabel.ThemeOption.Accent;
                    testcase.Title2Theme = SteamLabel.ThemeOption.Accent;
                }
                else
                {
                    testcase.HeaderColor = Color.FromArgb(40, 255, 50, 50);
                    testcase.Title2 = "Incorrect";
                    testcase.Title1Theme = SteamLabel.ThemeOption.Error;
                    testcase.Title2Theme = SteamLabel.ThemeOption.Error;
                }

                testcase.BackColor = Color.White;
                testcaseview.AutoSize = false;
                testcaseview.Padding = new Padding(3, 60, 0, 0);
                testcase.Controls.Add(testcaseview);
                testcaseview.Dock = DockStyle.Fill;
                testcase.Dock = DockStyle.Top;
                panel_results.Controls.Add(testcase);

                sequence++;

                if (isCorrect)
                {
                    score++;
                    corrects.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }
                else
                {
                    break;
                }

                currentScore.Text = $"{score}/{totalCases}";
            }
        }

        string Normalize(string s)
        {
            return string.Join("\n",
                s.Replace("\r\n", "\n")
                 .Replace("\r", "\n")
                 .Split('\n')
                 .Select(line => string.Join(" ",
                     line.Split(' ', StringSplitOptions.RemoveEmptyEntries)))
            ).Trim();
        }

        // Improved process runner with better cleanup
        protected async Task<bool> StartprocessAsyncExit(
            Process process,
            Action<string> onOutput,
            Action<string> onError,
            string input,
            Action onExit = null,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<bool>();

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
                onExit?.Invoke();
                tcs.TrySetResult(true);
            };

            process.EnableRaisingEvents = true;

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                if (!string.IsNullOrEmpty(input))
                {                                                     //to ensure that all input stream will be filled
                    await process.StandardInput.WriteLineAsync(input);
                    await process.StandardInput.FlushAsync(); // Ensure input is sent
                    process.StandardInput.Close();
                }

                // Wait for exit with timeout
                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(10));
                var completedTask = await Task.WhenAny(tcs.Task, timeoutTask);

                if (completedTask == timeoutTask)
                {
                    // Timeout occurred
                    try
                    {
                        KillProcessTree(process.Id);
                        process.Kill();
                        process.WaitForExit(1000); // Wait for kill to complete
                    }
                    catch { }
                    throw new TimeoutException("Process execution timed out");
                }
                if (cancellationToken.IsCancellationRequested)
                    throw new OperationCanceledException();

                await tcs.Task;

                // IMPORTANT: Wait for process to fully exit
                process.WaitForExit();

                // Additional wait to ensure all handles are released
                await Task.Delay(50);

                return true;
            }
            catch (Exception ex)
            {
                // Ensure process is killed on any error
                if (!process.HasExited)
                {
                    try
                    {
                        process.Kill();
                        process.WaitForExit(1000);
                    }
                    catch { }
                }
                throw;
            }
        }

        protected Process CommandRunner(string command, bool didRunCode = false)
        {
            // Don't dispose here - let using block handle it
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = "cmd.exe";
            newProcess.StartInfo.Arguments = command;
            newProcess.StartInfo.UseShellExecute = didRunCode;
            newProcess.StartInfo.RedirectStandardInput = !didRunCode;
            newProcess.StartInfo.RedirectStandardOutput = !didRunCode;
            newProcess.StartInfo.RedirectStandardError = !didRunCode;
            newProcess.StartInfo.CreateNoWindow = !didRunCode;

            return newProcess;
        }

        
    }
}
