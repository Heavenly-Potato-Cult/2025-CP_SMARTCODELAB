using ProtoBuf;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempStudentIDE : UserControl
    {
        private NetworkStream _stream;
        private TaskModel _task;
        private CancellationTokenSource token;
        private ISet<string> openedFiles = new HashSet<string>();
        private BaseCodeEditor _editor;
        private System.Threading.Timer _debounceTimer;
        private readonly int _debounceDelay = 300;
        private bool isFocused = false;
        public TempStudentIDE()
        {
            InitializeComponent();
        }
        public TempStudentIDE(string folderPath, string userName, TaskModel task, NetworkStream client)
        {
            InitializeComponent();
            _task = task;
            _stream = client;
            new Thread(() =>
            {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();
            token = new CancellationTokenSource();

            //create the activity file then open it by default,and also making it unclosable
            SourceCodeInitializer.InitializeSourceCode(task._language, folderPath, task._taskName);

            //set task description display
            actName.Text = task._taskName;
            description.Text = task._instructions;

            //deciding which BaseCodeEditor to use base on the file that the user will provide, pili lang sa tatlong child class ng BaseCodeEditor
            string filePath = Path.Combine(folderPath, SourceCodeInitializer.ValidName(task._taskName) + SourceCodeInitializer.extension[task._language]);
            openedFiles.Add(filePath);
            _editor = BaseCodeEditor.BaseCodeEditorFactory(filePath, task);
            _editor.srcCode.KeyUp += (s, e) =>
            {
                if (isFocused)
                {
                    _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                    // Start a new timer
                    _debounceTimer = new System.Threading.Timer(async _ =>
                    {
                        await ProgressSender();
                    }, null, _debounceDelay, Timeout.Infinite);
                }
            };
            codeEditorContainer.Controls.Add(_editor);
            _ = StreamListener();
        }

        private async Task ProgressSender()
        {
            var message = new ServerMessage.Builder(MessageType.StudentProgress)
                .StudentProgress(_editor.GetProgress())
                .Build();
            Serializer.SerializeWithLengthPrefix(_stream, message, PrefixStyle.Base128);
            await _stream.FlushAsync();
        }

        private async Task StreamListener()
        {
            try
            {
                while (true)
                {
                    var serverMsg = await Task.Run(() =>
                        Serializer.DeserializeWithLengthPrefix<ServerMessage>(_stream, PrefixStyle.Base128));

                    if (serverMsg == null) break; // End of stream or error

                    switch (serverMsg._messageType)
                    {
                        case MessageType.IsEyesOnMe:
                            isFocused = serverMsg.isFocused.GetValueOrDefault(false);
                            if (isFocused)
                                await ProgressSender();
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

        private void smartButton1_Click(object sender, EventArgs e)
        {
            _editor.RunCode();
        }
    }
}
