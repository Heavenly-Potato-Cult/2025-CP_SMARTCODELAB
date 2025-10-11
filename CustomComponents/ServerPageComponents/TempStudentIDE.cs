using ProtoBuf;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempStudentIDE : UserControl
    {
        private NetworkStream stream;
        private CancellationTokenSource token;
        //private ISet<string> openedFiles = new HashSet<string>();
        private BaseCodeEditor editor;
        private System.Threading.Timer? debounceTimer;
        private readonly int debounceDelay = 700;
        //private bool isFocused = false;
        private string userName;
        //private StudentCodingProgress progress;
        public TempStudentIDE()
        {
            InitializeComponent();
        }
        public TempStudentIDE(string userName, TaskModel task, StudentCodingProgress progress, NetworkStream client)
        {
            InitializeComponent();
            stream = client;
            this.userName = userName;
            new Thread(() =>
            {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();
            token = new CancellationTokenSource();

            //create the activity directory then return the file path of the main file
            string mainFile = SourceCodeInitializer.InitializeActivityDirectory(task._language, userName, task._taskName, progress.sourceCode ?? "");

            //deciding which BaseCodeEditor to use base on the file that the user will provide, pili lang sa tatlong child class ng BaseCodeEditor
            //the code editor will also be resposible in initializing the StudentCodingProgress, since it will already have the filepath, task and student name
            editor = BaseCodeEditor.BaseCodeEditorFactory(mainFile, task, userName, progress, UpdateStats);
            editor.notifAction = NotifyHost;
            editor.srcCode.KeyUp += (s, e) =>
            {
                //if (isFocused)
                //{
                debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                // Start a new timer
                debounceTimer = new System.Threading.Timer(async _ =>
                {
                    await ProgressSender();
                }, null, debounceDelay, Timeout.Infinite);
                //}
            };
            codeEditorContainer.Controls.Add(editor);
            _ = StreamListener();

            this.Load += (s, e) =>
            {
                UpdateTaskDisplay(task);
            };
        }

        public void UpdateTaskDisplay(TaskModel task)
        {
            editor.UpdateTask(task);
            Task.Run(() =>
                this.Invoke((Action)(() =>
                {
                    //set task description display
                    actName.Text = task._taskName;
                    description.Text = task._instructions;
                    int i = 1;
                    testCaseContainer.Controls.Clear();
                    if (task._testCases != null && task._testCases.Count > 0)
                        foreach (var item in task._testCases)
                        {
                            testCaseContainer.Controls.Add(new TestCaseView(i++, item.Key, item.Value));
                        }
                }))
            );
        }

        private void UpdateStats(int i, int value)
        {
            if (i == 1)//Accuracy
            {
                accuracy.ChangeValue(value);
            }
            else if (i == 2)
            {
                readability.ChangeValue(100 - value);
            }
        }

        private async Task ProgressSender()
        {
            var message = new ServerMessage.Builder(MessageType.STUDENT_PROGRESS)
                .StudentProgress(editor.GetProgress())
                .Build();
            Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
            await stream.FlushAsync();
        }

        private async Task StreamListener()
        {
            try
            {
                while (true)
                {
                    var serverMsg = await Task.Run(() =>
                        Serializer.DeserializeWithLengthPrefix<ServerMessage>(stream, PrefixStyle.Base128));

                    if (serverMsg == null) break; // End of stream or error

                    switch (serverMsg._messageType)
                    {
                        case MessageType.TASK_UPDATE:
                            UpdateTaskDisplay(serverMsg._task);
                            MessageBox.Show("Task updated boiiii");
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (IOException)
            {
                // Stream closed
            }
            catch (Exception ex)
            {
                // Log unexpected errors
                Console.WriteLine(ex);
            }
        }

        private void NotifyHost(NotificationType type, string result)
        {
            Task.Run(async () =>
            {
                try
                {
                    var message = new ServerMessage.Builder(MessageType.NOTIFICATION)
                        .Notification(new Notification(type, userName, result))
                        .Build();
                    Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
                    await stream.FlushAsync();
                }
                catch (ProtoException) { }
            });
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            editor.RunCode();
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            editor.RunTest();
        }

        private async void smartButton5_Click(object sender, EventArgs e)
        {
            Serializer.SerializeWithLengthPrefix<ServerMessage>(stream, new ServerMessage.Builder(MessageType.PROGRESS_REQUEST).Build(), PrefixStyle.Base128);
            await stream.FlushAsync();
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            Task.Run(async () => 
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                    new ServerMessage.Builder(MessageType.CODE_SUBMISSION).SubmittedCode(new SubmittedCode(editor.srcCode.Text)).Build(),
                    PrefixStyle.Base128);
                await stream.FlushAsync();
            });
        }
    }
}
