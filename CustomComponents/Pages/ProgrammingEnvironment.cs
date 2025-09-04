using ProtoBuf;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.Net.Sockets;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ProgrammingEnvironment : UserControl
    {
        private NetworkStream _stream;
        private TaskModel _task;
        private CancellationTokenSource token;
        private ISet<string> openedFiles = new HashSet<string>();
        private CodeEditorBase _editor;
        private System.Threading.Timer _debounceTimer;
        private readonly int _debounceDelay = 300;
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

            //create the activity file then open it by default,and also making it unclosable
            SourceCodeInitializer.InitializeSourceCode(task._language, folderPath, task._taskName);
            taskDescription.SetDescription(task);
            string filePath = Path.Combine(folderPath, SourceCodeInitializer.ValidName(task._taskName)+".java");
            openedFiles.Add(filePath);
            _editor = getCodeBaseEditor(filePath);
            _editor.srcCode.TextChanged += (s, e) =>
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

            customTabControl1.addTab(new TabPageModel(filePath, customTabControl1.getTabControl(), _editor, openedFiles, false));

            _ = StreamListener();
            _task = task;
        }

        private async Task ProgressSender()
        {
            var message = new ServerMessage.Builder(MessageType.StudentProgress)
                .StudentProgress(_editor.StudentProgress)
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
                customTabControl1.addTab(new TabPageModel(selectedPath, customTabControl1.getTabControl(), getCodeBaseEditor(selectedPath), openedFiles, true));
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
