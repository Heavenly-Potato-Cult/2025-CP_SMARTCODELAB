using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
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
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class MainServerPage : UserControl
    {
        public MainServerPage()
        {
            InitializeComponent();
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
        private Dictionary<NetworkStream, string> connectedUsers;
        private List<string> currentStudents = new List<string>();

        //will use userId as a KEY
        private Dictionary<string, StudentCodingProgress> userProgress;
        public MainServerPage(Server server)
        {
            InitializeComponent();
            this.server = server;
            serverListener = new TcpListener(IPAddress.Parse(NetworkServices.GetIpv4()), 1901);
            currentTask = server.ServerTask;
            Task.Run(async () => await StartServerAsync());
            connectedUsers = new Dictionary<NetworkStream, string>();
            userProgress = [];

            userTable = new StudTable(server.Users);
            serverPage = new TempServerPage(server.ServerTask, server.Users, IdStudentProgress);
            homePage = new ServerHomePage();
            progressSubmissionPage = new ProgressSubmissionPage();

            tabPage1.Controls.Add(homePage);
            tabPage2.Controls.Add(serverPage);
            tabPage3.Controls.Add(new ServerTaskUpdate(currentTask, UpdateServerTask));
            tabPage4.Controls.Add(progressSubmissionPage);
        }

        private void codeMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 0;
        }

        private void submissionStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 1;
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 2;
        }
        private void submissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 3;
        }

        private void viewUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userTable.ShowDialog();
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
                                else if(obj._userProfile._password != server.Password)
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
                                    await homePage.UpdateActiveStudentsCount(NotificationType.LoggedIn);
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
                            homePage.NewNotification(new Notification(NotificationType.Submitted, userProfile._studentName,""));
                            break;
                        case MessageType.NOTIFICATION:
                            homePage.NewNotification(obj.notification);
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
                connectedUsers.Add(networkStream, profile._studentId);
            else
            {
                connectedUsers.Remove(networkStream);
                currentStudents.Remove(profile._studentName);
                if (didLoggedIn)
                {
                    homePage.NewNotification(new Notification(NotificationType.LoggedOut, profile._studentName));
                    await homePage.UpdateActiveStudentsCount(NotificationType.LoggedOut);
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
                    Serializer.SerializeWithLengthPrefix<ServerMessage>(item.Key, new ServerMessage.Builder(MessageType.TASK_UPDATE).Task(task).Build(), PrefixStyle.Base128);
                    await item.Key.FlushAsync();
                }
            });
        }
    }
}
