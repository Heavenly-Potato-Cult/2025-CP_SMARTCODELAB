using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.WPFComponents;
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
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class MainServerPage2 : UserControl
    {
        public MainServerPage2()
        {
            InitializeComponent();
            SessionNavigationMenu();
        }
        private Server server;
        //controls handling and pages
        private TempServerPage serverPage;  
        private StudTable userTable;
        private ServerHomePage homePage;
        private ProgressSubmissionPage progressSubmissionPage;

        //network and user connectivity related
        //private readonly MessageType[] ForMainServer = { MessageType.UserProfile };//messages that are meant for this page, or class
        private TaskModel currentTask;
        private TcpListener serverListener;

        //users related
        private Dictionary<string, NetworkStream> connectedUsers;
        private List<string> currentStudents = new List<string>();
        //will use userId as a KEY
        private Dictionary<string, StudentCodingProgress> userProgress;

        private System.Threading.Timer saveSessionFile;

        public MainServerPage2(ProgrammingSession session)//this is for viewing the selected past session
        {
            InitializeComponent();
            SessionNavigationMenu();
            serverPage = new TempServerPage(session.users, session.userProgress);
            homePage = new ServerHomePage(session.notifications);
            progressSubmissionPage = new ProgressSubmissionPage(session.codeSubmission);

            tabPage1.Controls.Add(homePage);
            tabPage2.Controls.Add(serverPage);
            tabPage4.Controls.Add(progressSubmissionPage);
        }

        public MainServerPage2(Server server)
        {
            InitializeComponent();
            SessionNavigationMenu();
            this.server = server;
            serverListener = new TcpListener(IPAddress.Any, 1901);
            currentTask = server.ServerTask;
            Task.Run(async () => await StartServerAsync());
            connectedUsers = new Dictionary<string, NetworkStream>();
            userProgress = [];

            userTable = new StudTable(server.Users);
            serverPage = new TempServerPage(server.ServerTask, server.Users, IdStudentProgress, isConnected, sendStudentMessage);
            homePage = new ServerHomePage(server.Users.Count);
            homePage._totalStudents = server.Users.Count;
            progressSubmissionPage = new ProgressSubmissionPage();

            tabPage1.Controls.Add(homePage);
            tabPage2.Controls.Add(serverPage);
            tabPage3.Controls.Add(new ServerTaskUpdate(currentTask, UpdateServerTask));
            tabPage4.Controls.Add(progressSubmissionPage);
        }

        public bool sendStudentMessage(string studentId, UserMessage message)
        {
            if (connectedUsers.ContainsKey(studentId))
            {
                NetworkStream stream = connectedUsers[studentId];
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream,
                    new ServerMessage.Builder(MessageType.USER_MESSAGE).UserMessage(message).Build(), PrefixStyle.Base128);
                stream.Flush();
                return true;
            }
            else
                MessageBox.Show("Student is not connected.");

            return false;
        }

        private bool isConnected(string studentId)
        {
            return connectedUsers.ContainsKey(studentId);
        }

        private void SessionNavigationMenu()
        {
            // 1. Guard clause at the top
            if (panelNavHost2 == null)
            {
                return;
            }

            // 2. Calculate and set the panel's new, scaled height
            float dpiScale;
            using (Graphics g = this.CreateGraphics())
            {
                // Gets the system scale (e.g., 1.25 for 125%)
                dpiScale = g.DpiX / 96f;
            }

            // Gets your designer height (e.g., 46) and sets the new runtime height (e.g., 58)
            panelNavHost2.Height = (int)(panelNavHost2.Height * dpiScale);

            var navMenu = new SessionNavbar();

            navMenu.OnNavigationClicked = (tabIndex) =>
            {
                if (container != null) // Guard clause
                {
                    container.SelectedIndex = tabIndex;
                }
            };

            var host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = navMenu
            };


            if (panelNavHost2 != null)
            {
                panelNavHost2.Controls.Add(host);
            }

        }
        //network related stuffs
        private async Task UdpServerInfoSender()
        {
            UdpClient udpServer = new UdpClient(new IPEndPoint(IPAddress.Any, 1902));

            while (true)
            {
                var result = await udpServer.ReceiveAsync();
                byte[] taskData = Encoding.UTF8.GetBytes(JsonFileService.GetObjectJsonText(server));
                udpServer.Send(taskData, taskData.Length, result.RemoteEndPoint);
            }
        }

        private async Task StartServerAsync()
        {
            try
            {
                serverListener.Start(); // Only start once!
                _ = UdpServerInfoSender();
                while (true)
                {
                    TcpClient client = await AcceptTcpClientAsync(serverListener);
                    NetworkStream stream = client.GetStream();

                    // Handle each client in a separate task
                    _ = Task.Run(() => MessageReceiverAsync(stream));
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Server error: {ex.Message}");
                });
            }
        }

        private Task<TcpClient> AcceptTcpClientAsync(TcpListener listener)
        {
            return Task.Run(() => listener.AcceptTcpClient());
        }

        private async Task MessageReceiverAsync(NetworkStream networkStream)
        {
            UserProfile userProfile = new UserProfile();
            bool didLoggedIn = false;
            //send the task to the new client
            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream, new ServerMessage.Builder(MessageType.SERVER_TASK).Task(currentTask).Build(), PrefixStyle.Base128);
            await networkStream.FlushAsync();
            while (true)
            {
                try
                {
                    ServerMessage obj;
                    try
                    {
                        obj = Serializer.DeserializeWithLengthPrefix<ServerMessage>(networkStream, PrefixStyle.Base128);
                    }
                    catch (IOException)
                    {
                        break;
                    }
                    if (obj == null)
                        break;

                    switch (obj._messageType)
                    {
                        case MessageType.SERVER_TASK_REQUEST:
                            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                new ServerMessage.Builder(MessageType.SERVER_TASK).Task(currentTask).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.USER_PROFILE:
                            if (obj._userProfile == null)
                                break;
                            //the obj._userProfile only contains userId/studentId
                            userProfile = obj._userProfile;
                            didLoggedIn = false;
                            string errorMsg = "We can't find an account with that Student ID";
                            if (userTable.ContainsUser(userProfile._studentId))
                            {
                                //will retrieve the full student profile from the table using studentId
                                userProfile = userTable.GetUserProfile(userProfile._studentId);
                                if (currentStudents.Contains(userProfile._studentName))
                                {
                                    errorMsg = "This student is already logged in";
                                }
                                else if (obj._userProfile._password != server.Password)
                                {
                                    errorMsg = "Incorrect Password";
                                }
                                else
                                {
                                    if (!userProgress.ContainsKey(userProfile._studentId))
                                    {
                                        userProgress.Add(userProfile._studentId, new StudentCodingProgress());
                                    }

                                    currentStudents.Add(userProfile._studentName);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LOG_IN_SUCCESSFUL).
                                        Task(currentTask).
                                        UserProfile(userProfile).
                                        StudentProgress(userProgress[userProfile._studentId]).
                                        Build(), PrefixStyle.Base128);
                                    didLoggedIn = true;
                                    serverPage.StudentLoggedIn(userProfile);
                                    HandleUserStream(networkStream, userProfile, true, didLoggedIn);
                                    homePage.NewNotification(new Notification(NotificationType.LoggedIn, userProfile._studentName));
                                }
                            }
                            if (!didLoggedIn)
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LOG_IN_FAILED).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.STUDENT_PROGRESS:
                            UpdateUserProgress(userProfile._studentId, obj._progress);
                            serverPage.UpdateStudentProgressDisplay(userProfile, obj._progress);
                            break;
                        case MessageType.CODE_SUBMISSION:
                            obj.submittedCode.user = userProfile;
                            progressSubmissionPage.StudentSubmitted(obj.submittedCode);
                            homePage.NewNotification(new Notification(NotificationType.Submitted, userProfile._studentName, ""), userProfile);
                            break;
                        case MessageType.NOTIFICATION:
                            homePage.NewNotification(obj.notification);
                            break;
                        case MessageType.USER_MESSAGE:
                            serverPage.ReceivedStudentMessage(obj.userMessage, userProfile._studentId);
                            break;
                        default:
                            break;
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("all too well gar");
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The error : " + ex.StackTrace);
                }
            }
            HandleUserStream(networkStream, userProfile, false, didLoggedIn);
        }

        private void UpdateUserProgress(string studentId, StudentCodingProgress progress)
        {
            if (!userProgress.ContainsKey(studentId))
                userProgress.Add(studentId, progress);
            userProgress[studentId] = progress;

        }

        public StudentCodingProgress IdStudentProgress(string studentId)
        {
            return userProgress[studentId];
        }

        private async void HandleUserStream(NetworkStream networkStream, UserProfile profile, bool isAdd, bool didLoggedIn)
        {
            if (isAdd)
                connectedUsers.Add(profile._studentId, networkStream);
            else
            {
                connectedUsers.Remove(profile._studentId);
                currentStudents.Remove(profile._studentName);
                if (didLoggedIn)
                {
                    homePage.NewNotification(new Notification(NotificationType.LoggedOut, profile._studentName));
                }
            }
        }

        private void UpdateServerTask(TaskModel task)
        {
            serverPage.UpdateTask(task);
            Task.Run(async () =>
            {
                foreach (var item in connectedUsers)
                {
                    Serializer.SerializeWithLengthPrefix<ServerMessage>(item.Value, new ServerMessage.Builder(MessageType.TASK_UPDATE).Task(task).Build(), PrefixStyle.Base128);
                    await item.Value.FlushAsync();
                }
            });
        }

        private async void saveSessionFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(SystemConfigurations.SESSIONS_FOLDER, server.ServerName + ".session");
                using (var fileStream = new FileStream(
                                            filePath,
                                            FileMode.Create,            // always create or overwrite file
                                            FileAccess.Write,           // write-only access
                                            FileShare.None              // don't allow other processes to open it simultaneously
                                        ))
                {
                    Serializer.SerializeWithLengthPrefix(fileStream,
                        new ProgrammingSession(server, userProgress, homePage.notifications, progressSubmissionPage.GetAllSubmitted(), userTable.expectedUsers),
                        PrefixStyle.Base128);
                    await fileStream.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                // Log the error instead of crashing the timer
                Console.WriteLine($"Failed to save session: {ex.Message}");
                // Or use your logging framework
            }
        }
    }
}
