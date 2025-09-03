using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ProgrammingEnvironment : UserControl
    {
        private NetworkStream _stream;
        private TaskModel _task;
        private CancellationTokenSource token;
        private ISet<string> openedFiles = new HashSet<string>();
        private bool isFocused = false;
        public ProgrammingEnvironment(string folderPath, string userName, TaskModel task, NetworkStream client)
        {
            InitializeComponent();
            _stream = client;
            new Thread(() =>
            {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();
            token = new CancellationTokenSource();
            //create the activity file
            SourceCodeInitializer.InitializeSourceCode(task._language, folderPath, task._taskName);
            string filePath = Path.Combine(folderPath, SourceCodeInitializer.ValidName(task._taskName)+".java");
            selectFolder(folderPath);
            _ = ProgressSender(_stream, filePath, token.Token);
            _ = StreamListener(_stream);
            _task = task;
        }

        private async Task ProgressSender(NetworkStream stream, string filePath, CancellationToken token)
        {
            while (true)
            {
                if (isFocused) {
                    string content = await File.ReadAllTextAsync(filePath);
                    var message = new ServerMessage.Builder(MessageType.StudentProgress)
                        .StudentProgress(new StudentCodingProgress(content))
                        .Build();

                    Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
                    await stream.FlushAsync(token);
                }
                await Task.Delay(500, token); // Send every 1 second
            }
        }

        private async Task StreamListener(NetworkStream stream)
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
                        case MessageType.IsEyesOnMe:
                            isFocused = serverMsg.isFocused.GetValueOrDefault(false);
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

        private void selectFolder(string path)
        {
            fileTree.Nodes.Clear();
            var rootItem = new FileItem(path, false);
            {
                Name = new DirectoryInfo(path).Name;
            }
            fileTree.Nodes.Add(rootItem.ToTreeNode());
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run action triggered");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test action triggered");
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_task._instructions);
        }

        private void fileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selectedPath = (e.Node.Tag as FileItem).FullPath;
            // will check if the selected path is not null, is a file that exists, and is not already opened
            if (selectedPath != null && File.Exists(selectedPath) && !openedFiles.Contains(selectedPath))
            {
                openedFiles.Add(selectedPath);
                customTabControl1.addTab(new TabPageModel(selectedPath, customTabControl1.getTabControl(), getCodeBaseEditor(selectedPath), openedFiles));
            }
        }

        private CodeEditorBase getCodeBaseEditor(string filePath)
        {
            if(filePath.EndsWith(".java"))
            {
                return new JavaCodeEditor(filePath);
            }
            else if(filePath.EndsWith(".py"))
            {
                return new PythonCodeEditor(filePath);
            }
            else
            {
                return new CppCodeEditor(filePath);
            }
        }
    }
}
