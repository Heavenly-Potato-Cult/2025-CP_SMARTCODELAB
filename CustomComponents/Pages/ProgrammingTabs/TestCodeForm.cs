﻿using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class TestCodeForm : Form
    {
        public int score;
        private string command;
        private string testFile;
        private TaskModel task;
        private Process process;
        public TestCodeForm()
        {
            InitializeComponent();
        }

        public TestCodeForm(string command, string testFile, TaskModel task)
        {
            InitializeComponent();
            score = 0;
            this.command = command;
            this.testFile = testFile;
            this.task = task;
            total.Text = task._testCases.Count.ToString();
            this.Load += (s, e) => RunTest();
        }

        private async void RunTest()
        {
            score = 0;
            foreach (var item in task._testCases)
            {
                string input = item.Key;
                //to check if the language is cpp or python, then will modify how the input will look like to satisfy how 
                //it is need to be formatted in each language, java won't have any changes
                if (task._language == Models.Enums.LanguageSupported.Cpp)
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
                else if (task._language == Models.Enums.LanguageSupported.Python)
                {
                    string[] lines = input.Split(Environment.NewLine);
                    string newInput = "";
                    foreach (var item1 in lines)
                    {
                        newInput += item1 + "\\n";
                    }
                    input = newInput.Remove(newInput.Length - 2);
                }

                //modify the tester file content first before running it
                string testSrcCode = File.ReadAllText(testFile);
                File.WriteAllText(testFile, testSrcCode.Replace("userInput", input));

                string testOutput = "";

                process = CommandRunner(command);
                await StartprocessAsyncExit(
                    process,
                    output => testOutput += (output),
                    error => testOutput += (error),
                    null
                );

                if (testOutput == item.Value)
                    score++;

                currentScore.Text = score.ToString();
                flowLayoutPanel1.Controls.Add(new TestCaseResult(item.Key, item.Value, testOutput));

                //return the tester file content to its original content
                File.WriteAllText(testFile, testSrcCode.Replace(input, "userInput"));
            }
        }

        //a process runner
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
                onExit?.Invoke();
            };

            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            await process.WaitForExitAsync();
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
    }
}
