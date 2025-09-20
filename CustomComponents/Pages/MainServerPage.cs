using ProtoBuf;
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

        //controls handling
        private TempServerPage serverPage;

        //network and user connectivity related
        private TaskModel currentTask;
        private TcpListener _server;
        private Dictionary<NetworkStream, string> connectedUsers;
        public MainServerPage(TaskModel task, Dictionary<string, UserProfile> users)
        {
            InitializeComponent();
            _server = new TcpListener(IPAddress.Parse(NetworkServices.GetIpv4()), 1901);
            currentTask = task;
            Task.Run(async () => await StartServerAsync());
            connectedUsers = new Dictionary<NetworkStream, string>();

            serverPage = new TempServerPage(task, users);
            tabPage1.Controls.Add(serverPage);
            tabPage2.Controls.Add(new ServerTaskUpdate(currentTask,UpdateServerTask));
        }

        private void codeMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 0;
        }

        private void submissionStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.SelectedIndex = 1;
        }

        //network related stuffs
        private async Task UdpServerInfoSender()
        {
            UdpClient udpServer = new UdpClient(new IPEndPoint(IPAddress.Parse(NetworkServices.GetIpv4()), 1902));

            while (true)
            {
                UdpReceiveResult result = await udpServer.ReceiveAsync();
                byte[] taskData = Encoding.UTF8.GetBytes(JsonFileService.GetObjectJsonText(currentTask));
                udpServer.Send(taskData, taskData.Length, result.RemoteEndPoint);
            }
        }

        private async Task StartServerAsync()
        {
            try
            {
                _server.Start(); // Only start once!
                _ = UdpServerInfoSender();
                while (true)
                {
                    TcpClient client = await AcceptTcpClientAsync(_server);
                    NetworkStream stream = client.GetStream();

                    // Handle each client in a separate task
                    _ = Task.Run(() => MessageReceiverAsync(stream));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Server error: {ex.Message}");
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
                    await serverPage.MessageHandler(obj,networkStream, HandleUserStream);

                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MainServerPage: MessageReceiverAsync");
                }
            }
            serverPage.RemoveUser(networkStream);
        }

        private void HandleUserStream(NetworkStream networkStream, string userId, bool isAdd) 
        {
            if (isAdd)
                connectedUsers.Add(networkStream,userId);
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
