using ProtoBuf;
using SmartCodeLab.CustomComponents;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.SteamThings;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.CustomComponents.WPFComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class TempIDE : Form
    {
        //for the WINDOWS + TAB
        private const int WH_KEYBOARD_LL = 13;
        private IntPtr _hookPtr = IntPtr.Zero;
        private HookProc _hookProc;
        private int KeyboardHookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                // Block Windows keys
                if (vkCode == 91 || vkCode == 92) // LWin or RWin
                {
                    return 1; // Block
                }
            }

            return CallNextHookEx(_hookPtr, code, wParam, lParam);
        }

        private void ToolTipInit()
        {
            ToolTip infoTip = new ToolTip();

            infoTip.AutoPopDelay = 5000; 
            infoTip.InitialDelay = 500; 
            infoTip.ReshowDelay = 500;   
            infoTip.ShowAlways = true;

            infoTip.SetToolTip(this.ActivityIcon, "Activiy Instruction");
            infoTip.SetToolTip(this.MessagesIcon, "Messages");
            infoTip.SetToolTip(this.TestcaseIcon, "Test Cases");
            infoTip.SetToolTip(this.LeaderboardsIcon, "Leaderboards");
            infoTip.SetToolTip(this.ScoreIcon, "Scores");
        }

        private delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn,
            IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);
        //=================================================================================================


        private NetworkStream stream;
        private CancellationTokenSource _cancellationTokenSource;
        //private ISet<string> openedFiles = new HashSet<string>();
        private BaseCodeEditor mainEditor;
        //private bool isFocused = false;
        private string userName;
        //private StudentCodingProgress progress;

        private bool isResizingTabs = false;
        private System.Windows.Controls.TreeView wpfTree;
        private int leaderboardUpdateVersion = 0;

        //public static void SetDoubleBuffered(System.Windows.Forms.Control control)
        //{
        //    // set instance non-public property with name "DoubleBuffered" to true
        //    typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
        //        System.Reflection.BindingFlags.SetProperty |
        //        System.Reflection.BindingFlags.Instance |
        //        System.Reflection.BindingFlags.NonPublic,
        //        null, control, new object[] { true });
        //}

        private void AddLeaderboardIcon(int ranking, string studentName, int score)
        {

            var newIcon = new leaderboardIcon();

            newIcon.Dock = DockStyle.Top;
            newIcon.Margin = new Padding(0, 0, 0, 5);

            newIcon.Ranking = ranking;
            newIcon.Name = studentName;
            newIcon.Score = score;

            if (ranking >= 1 && ranking <= 5)
            {
                newIcon.BackColor = System.Drawing.Color.Gold;
            }
            else
            {
                newIcon.BackColor = System.Drawing.Color.Silver;
            }
            panel_leaderboards.Controls.Add(newIcon);


            newIcon.BringToFront();
        }

        private Image _originalImage;
        private bool isPlaying;
        public TempIDE(string userName, TaskModel task, StudentCodingProgress progress, NetworkStream client)
        {
            this.Opacity = 0;
            InitializeComponent();
            this.SuspendLayout();
            this.DoubleBuffered = true;
            //SetDoubleBuffered(tabControl_RightSide);
            //InitializeWPFTree();
            isPlaying = false;
            studentIdentity.Text = userName;
            monitoredStatus.Visible = false;
            if (task.isTabLocked)
            {
                FormBorderStyle = FormBorderStyle.None;
                TopMost = true;
                WindowState = FormWindowState.Maximized;

                _hookProc = new HookProc(KeyboardHookProc);
                _hookPtr = SetWindowsHookEx(WH_KEYBOARD_LL, _hookProc,
                    Marshal.GetHINSTANCE(GetType().Module), 0);

                if (_hookPtr == IntPtr.Zero)
                {
                    NonBlockingNotification("Failed to install keyboard hook!");
                }

                this.FormClosed += (s, e) =>
                {
                    if (_hookPtr != IntPtr.Zero)
                        UnhookWindowsHookEx(_hookPtr);
                };
            }
            else
                exitbtn.Visible = false;

            stream = client;
            this.userName = userName;
            new Thread(() =>
            {
                Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();
            foreach (var item in task.efficiencyMetrics)
            {
                Debug.WriteLine($"{item.Key} : {item.Value}");
            }
            //create the activity directory then return the file path of the main file
            string mainFile = SourceCodeInitializer.InitializeActivityDirectory(task._language, userName, task._taskName, progress.sourceCode ?? "");

            //initialize the best code operator count(if efficiency is included
            if (task.ratingFactors.ContainsKey(2))
                SourceCodeInitializer.InitializeEfficiencyCode(task._language, task._referenceFile, Path.GetDirectoryName(mainFile));

            //deciding which BaseCodeEditor to use base on the file that the user will provide, pili lang sa tatlong child class ng BaseCodeEditor
            //the code editor will also be resposible in initializing the StudentCodingProgress, since it will already have the filepath, task and student name
            mainEditor = BaseCodeEditor.BaseCodeEditorFactory(mainFile, task, progress, studentCodeRating.UpdateStats, ProgressSender);
            mainEditor.notifAction = NotifyHost;
            mainEditor.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(mainEditor);

            _ = StreamListener();

            UpdateTaskDisplay(task);
            studentCodeRating.SetStats(task.ratingFactors);
            studentCodeRating.maxTestScore = task._testCases != null ? task._testCases.Count : 0;

            if (!MainTabControl.IsHandleCreated) { var _ = MainTabControl.Handle; }
            foreach (TabPage page in MainTabControl.TabPages) { var __ = page.Handle; }
            
           

            this.ResumeLayout(true);
            if (!this.IsHandleCreated)
            {
                IntPtr forceHandle = this.Handle;
            }

            this.Shown += (sender, e) =>
            {
               
                this.Refresh();
                this.Opacity = 1;
            };

            _originalImage = ActivityIcon.Image;

            ToolTipInit();
        }
        
        private void ReleaseAnything()
        {
            stream.Close();
            stream.Dispose();
            SystemSingleton.Instance._loggedIn = false;
        }

        public void UpdateTaskDisplay(TaskModel task)
        {
            mainEditor.UpdateTask(task);
            session_name.Text = task._taskName;
            description.Text = task._instructions;
            TestCasesPanel.Controls.Clear();
            studentCodeRating.maxTestScore = task._testCases != null ? task._testCases.Count : 0;

            TestCasesPanel.SuspendLayout();
            try
            {
                if (task._testCases != null && task._testCases.Count > 0)
                {
                    // para ma maintain ang order sa test cases
                    int count = 0;
                    var testCaseList = task._testCases.ToList();
                    for (int i = testCaseList.Count - 1; i >= 0; i--)
                    {
                        count++;
                        var item = testCaseList[i];
                        var testCaseNumber = count;

                        ExpansionPanel testcase = new ExpansionPanel();
                        var testcaseview = new TestCaseView(testCaseNumber, item.Key, item.Value);

                        testcase.Title1 = "Test Case";
                        testcase.Title2 = testCaseNumber.ToString();
                        testcase.HeaderColor = System.Drawing.Color.FromArgb(30, 41, 57);
                        testcase.IsExpanded= false;

                        testcaseview.AutoSize = false;

                        testcaseview.Padding = new Padding(0, 60, 0, 0);
                        testcase.Controls.Add(testcaseview);
                        testcaseview.Dock = DockStyle.Fill;

                        testcase.Dock = DockStyle.Top;
                        TestCasesPanel.Controls.Add(testcase);
                        if (count > 4)
                            break;
                    }

                }
            }
            finally
            {
                TestCasesPanel.ResumeLayout(true);
            }
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
            }
            catch (ArgumentException) { }
            catch (IOException)
            {
                BlockingNotification("Connection Closed");
                this.Close();
            }
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

                    if (serverMsg == null) break;
                    switch (serverMsg._messageType)
                    {
                        case MessageType.TASK_UPDATE:
                            UpdateTaskDisplay(serverMsg._task);
                            NonBlockingNotification("Task Updated");
                            break;
                        case MessageType.USER_MESSAGE:
                            this.Invoke((Action)(() =>{
                                var incomingMsg = serverMsg.userMessage;

                                incomingMsg.isFromMe = false; 
                                incomingMsg.senderName = "Instructor"; 
                                
                                steamChatbox1.Items.Add(incomingMsg);
                                steamChatbox1.TopIndex = steamChatbox1.Items.Count - 1; 

                                
                                MainTabControl.SelectedTab = MessagesTab;
                            }));
                            MainTabControl.SelectedTab = MessagesTab;
                            playMessagedSound();
                            break;
                        case MessageType.LEADERBOARDS_UPDATE:
                            _ = Task.Run(() =>
                            {
                                int myVersion = ++leaderboardUpdateVersion;

                                this.BeginInvoke(new Action(() =>
                                {
                                  
                                    panel_leaderboards.SuspendLayout();

                                    try
                                    {
                                        panel_leaderboards.Controls.Clear();
                                        List<SubmittedCode> leaderBoards = serverMsg.leaderboards.OrderBy(s => s.placement).ToList();
                                        //  Add all items
                                        foreach (var sub in leaderBoards)
                                        {

                                            if (myVersion != leaderboardUpdateVersion) break;

                                            AddLeaderboardIcon(sub.placement, sub.username, sub.score);
                                        }
                                    }
                                    finally
                                    {
                                        panel_leaderboards.ResumeLayout(true);
                                    }
                                }));
                            });
                            break;
                        case MessageType.MONITORED:
                            this.Invoke((Action)(() => monitoredStatus.Visible = true));
                            playBeingWatchedSound();
                            break;
                        case MessageType.LEFT_ALONE:
                            this.Invoke((Action)(() => monitoredStatus.Visible = false));
                            MainTabControl.SelectedTab = MessagesTab;
                            isPlaying = false; // stop the sound
                            break;
                        case MessageType.KICKED:
                            BlockingNotification("You have been kicked from the session.");
                            this.Close();
                            break;
                        case MessageType.SERVER_SHUTDOWN:
                            BlockingNotification("Server is shutting down. The application will close now.");
                            this.Close();
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
            BlockingNotification("Connection to server lost.");
            this.Close();
        }

        private void playBeingWatchedSound()
        {
            isPlaying = false;
            Task.Delay(100);
            isPlaying = true;

            Thread playDreadfullSound = new Thread(() =>
            {
                SoundPlayer player = new SoundPlayer(SystemConfigurations.MONITORED_MUSIC);
                player.PlayLooping();   // 🔊 plays until you stop it

                // Your loop
                while (isPlaying)
                {
                    Thread.Sleep(50);
                }

                // When condition becomes false:
                player.Stop();
            });
            playDreadfullSound.Start();
        }

        private void playMessagedSound()
        {
            new Thread(() =>
            {
                SoundPlayer player = new SoundPlayer(SystemConfigurations.MSG_NOTIFICATION);
                player.PlaySync();
                playBeingWatchedSound();
            }).Start();
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
            mainEditor.RunCode();
        }

        private async void smartButton2_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                        new ServerMessage.Builder(MessageType.CODE_SUBMISSION).
                            SubmittedCode(new SubmittedCode(mainEditor.srcCode.Text, studentCodeRating.GetStats(), (int)studentCodeRating.GetScore())).Build(),
                        PrefixStyle.Base128);
                    await stream.FlushAsync();
                    NonBlockingNotification("Code submitted successfully");
                }
                catch (FormatException e) { Debug.WriteLine(e.Message); }
            });
        }

        private void TempIDE_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseAnything();
            isPlaying = false;
            _cancellationTokenSource?.Cancel();
            stream?.Close();
            SystemSingleton.Instance._loggedIn = false;
        }

        private void richTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string msg = richTextBox2.Text.Trim();

                if (string.IsNullOrEmpty(msg)) return;
                var userMsg = new UserMessage(msg, true, "Me");
                this.Invoke((Action)(() =>
                {
                    userMsg.isFromMe = true;
                    steamChatbox1.Items.Add(userMsg);
                    steamChatbox1.TopIndex = steamChatbox1.Items.Count - 1; // Scroll to bottom
                }));
                Task.Run(async () =>
                {
                    try
                    {
                        var message = new ServerMessage.Builder(MessageType.USER_MESSAGE)
                            .UserMessage(userMsg)
                            .Build();
                        Serializer.SerializeWithLengthPrefix(stream, message, PrefixStyle.Base128);
                        await stream.FlushAsync();
                        //this.Invoke((Action)(() => msgBox.AppendText($"Me : {msg}")));
                    }
                    catch (ProtoException) { }
                });
                richTextBox2.Clear();
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            mainEditor.RunCode();
        }

        private void NonBlockingNotification(string message)
        {
            this.BeginInvoke((Action)(() => MessageBox.Show(
                                message,
                                "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly | MessageBoxOptions.ServiceNotification
                            )));
        }

        private void BlockingNotification(string message)
        {
            MessageBox.Show(message,
                            "Notice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly | MessageBoxOptions.ServiceNotification
                            );
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                        new ServerMessage.Builder(MessageType.CODE_SUBMISSION).
                            SubmittedCode(new SubmittedCode(mainEditor.srcCode.Text, studentCodeRating.GetStats(), (int)studentCodeRating.GetScore())).Build(),
                        PrefixStyle.Base128);
                    await stream.FlushAsync();
                    NonBlockingNotification("Code submitted successfully");
                }
                catch (FormatException e) { Debug.WriteLine(e.Message); }
            });
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            mainEditor.RunTest();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
            //if (sender is not PictureBox pb) return;
            //if (_originalImage == null) _originalImage = pb.Image;
            //if (_originalImage == null) return;
            //if (pb.BackColor == Color.Firebrick)
            //{
            //    pb.BackColor = Color.FromArgb(30, 41, 57); 
            //}
            //else
            //{
            //    pb.BackColor = Color.Firebrick; 
            //}

            //if (pb.Tag?.ToString() == "bw")
            //{
                
            //    pb.Image = _originalImage;
            //    pb.Tag = "color";
            //}
            //else
            //{
            //    // Turn to Dark Gray (Dimmed)
            //    pb.Image = ToPureBlack(_originalImage);
            //    pb.Tag = "bw";
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            MainTabControl.SelectedIndex = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 3;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 4;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;

        }

        private Bitmap ToPureBlack(Image original)
        {
            if (original == null) return null;

            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                // MATRIX EXPLANATION:
                // The diagonals are set to 0 to "turn off" the original Red, Green, and Blue.
                // The 4th row is set to 1 to "keep" the original Transparency (Alpha).
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {0, 0, 0, 0, 0}, // Red = 0
            new float[] {0, 0, 0, 0, 0}, // Green = 0
            new float[] {0, 0, 0, 0, 0}, // Blue = 0
            new float[] {0, 0, 0, 1, 0}, // Alpha (Transparency) = 100% of original
            new float[] {0, 0, 0, 0, 1}  // No extra color offset
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(original,
                        new Rectangle(0, 0, original.Width, original.Height),
                        0, 0, original.Width, original.Height,
                        GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            ReleaseAnything();
            Close();
        }
    }
}
