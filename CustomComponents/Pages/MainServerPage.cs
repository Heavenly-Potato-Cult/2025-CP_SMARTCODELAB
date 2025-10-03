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

            tabPage1.Controls.Add(homePage);
            tabPage2.Controls.Add(serverPage);
            tabPage3.Controls.Add(new ServerTaskUpdate(currentTask, UpdateServerTask));
            tabPage4.Controls.Add(new ProgressSubmissionPage());
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

        private void viewUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userTable.ShowDialog();
        }

        //network related stuffs
        private async Task UdpServerInfoSender()
        {
            UdpClient udpServer = new UdpClient(new IPEndPoint(IPAddress.Parse(NetworkServices.GetIpv4()), 1902));

            while (true)
            {
                UdpReceiveResult result = await udpServer.ReceiveAsync();
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
            //send the task to the new client
            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream, new ServerMessage.Builder(MessageType.ServerTask).Task(currentTask).Build(), PrefixStyle.Base128);
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
                        case MessageType.ServerTaskRequest:
                            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                new ServerMessage.Builder(MessageType.ServerTask).Task(currentTask).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.UserProfile:
                            if (obj._userProfile == null)
                                break;
                            UserProfile profile = obj._userProfile;
                            bool didLogIn = false;
                            string errorMsg = "We can't find an account with that Student ID";
                            if (userTable.ContainsUser(profile._studentId))
                            {
                                UserProfile actualProfile = userTable.GetUserProfile(profile._studentId);
                                if (currentStudents.Contains(profile._studentName))
                                    errorMsg = "This student is already logged in";
                                else
                                {
                                    if (!userProgress.ContainsKey(profile._studentId))
                                        userProgress.Add(profile._studentId, new StudentCodingProgress());

                                    //serverPage.AddNewUser(networkStream, actualProfile);
                                    currentStudents.Add(profile._studentName);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LogInSuccessful).
                                        Task(currentTask).
                                        UserProfile(actualProfile).
                                        StudentProgress(userProgress[actualProfile._studentId]).
                                        Build(), PrefixStyle.Base128);
                                    didLogIn = true;
                                    userProfile = profile;
                                    serverPage.StudentLoggedIn(userProfile);
                                    HandleUserStream(networkStream, profile, true);
                                    homePage.NewNotification(new Notification(NotificationType.LoggedIn, actualProfile._studentName));

                                }
                            }
                            if (!didLogIn)
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.StudentProgress:
                            UpdateUserProgress(userProfile._studentId, obj._progress);
                            serverPage.UpdateStudentProgressDisplay(userProfile,obj._progress);
                            break;
                        case MessageType.Notification:
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
                    MessageBox.Show(ex.Message);
                }
            }
            HandleUserStream(networkStream, userProfile, false);
        }

        private void UpdateUserProgress(string studentId, StudentCodingProgress progress)
        {
            if(!userProgress.ContainsKey(studentId))
                userProgress.Add(studentId, progress);
            userProgress[studentId] = progress;

        }

        public StudentCodingProgress IdStudentProgress(string studentId)
        {
            return userProgress[studentId];
        }

        private void HandleUserStream(NetworkStream networkStream, UserProfile profile, bool isAdd)
        {
            if (isAdd)
                connectedUsers.Add(networkStream, profile._studentId);
            else
            {
                connectedUsers.Remove(networkStream);
                currentStudents.Remove(profile._studentName);
            }
        }

        private void UpdateServerTask(TaskModel task)
        {
            serverPage.UpdateTask(task);
            Task.Run(async () =>
            {
                foreach (var item in connectedUsers)
                {
                    Serializer.SerializeWithLengthPrefix<ServerMessage>(item.Key, new ServerMessage.Builder(MessageType.TaskUpdate).Task(task).Build(), PrefixStyle.Base128);
                    await item.Key.FlushAsync();
                }
            });
        }
    }
}
