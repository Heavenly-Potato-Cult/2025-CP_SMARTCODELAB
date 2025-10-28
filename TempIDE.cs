using ProtoBuf;
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
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using EH = System.Windows.Forms.Integration.ElementHost;
using WpfBrushes = System.Windows.Media.Brushes;
using WpfColor = System.Windows.Media.Color;
using WpfSolidColorBrush = System.Windows.Media.SolidColorBrush;
using WpfSystemColors = System.Windows.SystemColors;
//For WPF ;>
using WpfTreeView = System.Windows.Controls.TreeView;
using WpfTreeViewItem = System.Windows.Controls.TreeViewItem;

namespace SmartCodeLab
{
    public partial class TempIDE : Form
    {

        private NetworkStream stream;
        private CancellationTokenSource _cancellationTokenSource;
        //private ISet<string> openedFiles = new HashSet<string>();
        private BaseCodeEditor mainEditor;
        private System.Threading.Timer? debounceTimer;
        private readonly int debounceDelay = 700;
        //private bool isFocused = false;
        private string userName;
        //private StudentCodingProgress progress;

        private bool isResizingTabs = false;
        private System.Windows.Controls.TreeView wpfTree;
        public TempIDE()
        {
            InitializeComponent();
            InitializeWPFTree();

        }

        public TempIDE(string userName, TaskModel task, StudentCodingProgress progress, NetworkStream client)
        {
            InitializeComponent();
            InitializeWPFTree();

            if (task.isTabLocked)
            {
                FormBorderStyle = FormBorderStyle.None;
                TopMost = true;
                WindowState = FormWindowState.Maximized;
                this.Controls.Remove(button1);
            }

            stream = client;
            this.userName = userName;
            new Thread(() =>
            {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();

            //create the activity directory then return the file path of the main file
            string mainFile = SourceCodeInitializer.InitializeActivityDirectory(task._language, userName, task._taskName, progress.sourceCode ?? "");

            //deciding which BaseCodeEditor to use base on the file that the user will provide, pili lang sa tatlong child class ng BaseCodeEditor
            //the code editor will also be resposible in initializing the StudentCodingProgress, since it will already have the filepath, task and student name
            mainEditor = BaseCodeEditor.BaseCodeEditorFactory(mainFile, task, progress, studentCodeRating.UpdateStats, ProgressSender);
            mainEditor.notifAction = NotifyHost;
            customTabControl1.AddTab(Path.GetFileName(mainFile), mainEditor);

            if (wpfTree == null) return;

            wpfTree.Items.Clear();

            var rootNode = CreateFolderNode(Path.GetDirectoryName(mainFile));
            if (rootNode == null) return;

            wpfTree.Items.Add(rootNode);

            _ = StreamListener();

            this.Load += (s, e) =>
            {
                UpdateTaskDisplay(task);
                studentCodeRating.SetStats(task.ratingFactors);
                studentCodeRating.maxTestScore = task._testCases != null ? task._testCases.Count : 0;
            };
        }

        public void UpdateTaskDisplay(TaskModel task)
        {
            mainEditor.UpdateTask(task);
            Task.Run(() =>
                this.Invoke((Action)(() =>
                {
                    //set task description display
                    activity_expansion_panel.Title = task._taskName;
                    description.Text = task._instructions;
                    int i = 1;
                    testCaseContainer.Controls.Clear();
                    studentCodeRating.maxTestScore = task._testCases != null ? task._testCases.Count : 0;
                    if (task._testCases != null && task._testCases.Count > 0)
                        foreach (var item in task._testCases)
                        {
                            testCaseContainer.Controls.Add(new TestCaseView(i++, item.Key, item.Value));
                        }
                }))
            );
        }

        private async Task ProgressSender()
        {
            try
            {
                var message = new ServerMessage.Builder(MessageType.STUDENT_PROGRESS)
                    .StudentProgress(mainEditor.GetProgress(studentCodeRating.GetCodeRating()))
                    .Build();
                Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
                await stream.FlushAsync();
            }catch(ArgumentException) { }
        }

        private async Task StreamListener()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;
            try
            {
                while (!token.IsCancellationRequested)
                {
                    var task = Task.Run(() =>
                    {
                        try
                        {
                            return Serializer.DeserializeWithLengthPrefix<ServerMessage>(stream, PrefixStyle.Base128);
                        }
                        catch (IOException)
                        {
                            return null;
                        }
                    });
                    var serverMsg = await task;

                    if (serverMsg == null) break; // End of stream or error
                    switch (serverMsg._messageType)
                    {
                        case MessageType.TASK_UPDATE:
                            UpdateTaskDisplay(serverMsg._task);
                            MessageBox.Show("Task updated boiiii");
                            break;
                        case MessageType.USER_MESSAGE:
                            this.Invoke((Action)(() => msgBox.AppendText($"Teacher : {serverMsg.userMessage.message}\n") ));
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

        private void ResizeTabs()
        {
            if (isResizingTabs) { return; } // Prevent recursion

            if (tabControl_RightSide.TabPages.Count == 0) { return; }

            int totalWidth = tabControl_RightSide.ClientSize.Width;
            if (totalWidth <= 0) { return; }

            isResizingTabs = true;

            try
            {
                int tabCount = tabControl_RightSide.TabPages.Count;
                int tabWidth = (totalWidth / tabCount) - 2;

                tabControl_RightSide.Font = new Font("Segoe UI", 12F);
                tabControl_RightSide.SizeMode = TabSizeMode.Fixed;
                tabControl_RightSide.ItemSize = new Size(tabWidth, 50); // 50 = tab height
            }
            finally
            {
                isResizingTabs = false;
            }
        }

        private void tabControl_RightSide_Resize(object sender, EventArgs e)
        {
            ResizeTabs();
        }

        private void TempIDE_Shown(object sender, EventArgs e)
        {
            ResizeTabs();
            tabControl_RightSide.Invalidate();
        }

        private void InitializeWPFTree()
        {
            if (panel_LeftSide_Directory == null) return;

            wpfTree = new WpfTreeView
            {
                Background = WpfBrushes.White,
                Foreground = WpfBrushes.Black,
                FontSize = 14
            };

            wpfTree.Resources[WpfSystemColors.HighlightBrushKey] = new WpfSolidColorBrush(WpfColor.FromRgb(200, 230, 255));
            wpfTree.Resources[WpfSystemColors.ControlBrushKey] = new WpfSolidColorBrush(WpfColor.FromRgb(220, 240, 255));


            var host = new EH
            {
                Dock = DockStyle.Fill,
                Child = wpfTree
            };

            panel_LeftSide_Directory.Controls.Add(host);
        }

        private void LoadFolder(string path, WpfTreeViewItem parent)
        {
            try
            {
                // Add subfolders
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var folderNode = new WpfTreeViewItem { Header = Path.GetFileName(dir) };
                    parent.Items.Add(folderNode);
                    LoadFolder(dir, folderNode);
                }

                // Add files
                foreach (var file in Directory.GetFiles(path))
                {
                    parent.Items.Add(new WpfTreeViewItem { Header = Path.GetFileName(file) });
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Skip folders we can't access
            }
        }

        private WpfTreeViewItem CreateFolderNode(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            if (!Directory.Exists(path)) return null;

            var folderNode = new WpfTreeViewItem { Header = Path.GetFileName(path), Tag = path };
            folderNode.Expanded += FolderNode_Expanded;

            var hasChildren = Directory.GetDirectories(path).Length > 0 || Directory.GetFiles(path).Length > 0;
            if (hasChildren)
                folderNode.Items.Add(null);

            return folderNode;
        }

        private async void FolderNode_Expanded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!(sender is WpfTreeViewItem node)) return;
            if (node.Items.Count != 1) return;
            if (node.Items[0] != null) return;

            node.Items.Clear();

            if (!(node.Tag is string path)) return;
            if (!Directory.Exists(path)) return;

            string[] dirs;
            string[] files;

            try
            {
                dirs = await Task.Run(() => Directory.GetDirectories(path));
                files = await Task.Run(() => Directory.GetFiles(path));
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }

            foreach (var dir in dirs)
            {
                var dirNode = CreateFolderNode(dir);
                if (dirNode != null)
                    node.Items.Add(dirNode);
            }

            foreach (var file in files)
            {
                if (string.IsNullOrWhiteSpace(file)) continue;
                var fileNode = new WpfTreeViewItem { Header = Path.GetFileName(file), Tag = file };
                node.Items.Add(fileNode);
            }
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            if (wpfTree == null) return;

            wpfTree.Items.Clear();

            var rootNode = CreateFolderNode(dialog.SelectedPath);
            if (rootNode == null) return;

            wpfTree.Items.Add(rootNode);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            mainEditor.RunCode();
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                    new ServerMessage.Builder(MessageType.CODE_SUBMISSION).
                        SubmittedCode(new SubmittedCode(mainEditor.srcCode.Text, mainEditor.GetProgress(studentCodeRating.GetCodeRating()))).Build(),
                    PrefixStyle.Base128);
                await stream.FlushAsync();
            });
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            mainEditor.RunTest();
        }

        private void TempIDE_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            stream?.Close();
            SystemSingleton.Instance._loggedIn = false;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string msg = richTextBox2.Text.Trim() + Environment.NewLine;

                Task.Run(async () =>
                {
                    try
                    {
                        var message = new ServerMessage.Builder(MessageType.USER_MESSAGE)
                            .UserMessage(new UserMessage(msg))
                            .Build();
                        Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
                        await stream.FlushAsync();
                        Debug.WriteLine($"Sent message: {msg}");
                        this.Invoke((Action)(() => msgBox.AppendText($"Me : {msg}")));
                    }
                    catch (ProtoException) { }
                });
                richTextBox2.Clear();
            }
        }
    }
}
