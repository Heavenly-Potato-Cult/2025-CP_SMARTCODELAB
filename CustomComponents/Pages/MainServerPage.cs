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
        public MainServerPage(Server server)
        {
            InitializeComponent();
            this.server = server;
            serverListener = new TcpListener(IPAddress.Parse(NetworkServices.GetIpv4()), 1901);
            currentTask = server.ServerTask;
            Task.Run(async () => await StartServerAsync());
            connectedUsers = new Dictionary<NetworkStream, string>();

            userTable = new StudTable(server.Users);
            serverPage = new TempServerPage(server.ServerTask, server.Users);
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
                                    serverPage.AddNewUser(networkStream, actualProfile);
                                    currentStudents.Add(profile._studentName);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LogInSuccessful).Task(currentTask).UserProfile(actualProfile).Build(), PrefixStyle.Base128);
                                    didLogIn = true;
                                    HandleUserStream(networkStream, profile._studentId, true);
                                    homePage.NewNotification(new Notification(NotificationType.LoggedIn, actualProfile._studentName));
                                }
                            }
                            if (!didLogIn)
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.Notification:
                            homePage.NewNotification(obj.notification);
                            break;
                        default:
                             await serverPage.MessageHandler(obj, networkStream, HandleUserStream);
                            break;
                    }
                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            serverPage.RemoveUser(networkStream);
        }

        private void HandleUserStream(NetworkStream networkStream, string userId, bool isAdd)
        {
            if (isAdd)
                connectedUsers.Add(networkStream, userId);
            else
                connectedUsers.Remove(networkStream);
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
