using ProtoBuf;
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

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempServerPage : UserControl
    {
        public TempServerPage()
        {
            InitializeComponent();
        }

        private TaskModel currentTask { get; set; }
        private TcpListener _server;
        private Dictionary<NetworkStream, UserIcons> userIcons = new Dictionary<NetworkStream, UserIcons>();
        private

        //student ID as the key
        Dictionary<string, UserProfile> expectedUsers;
        private List<string> currentStudents = new List<string>();
        private StudentCodingProgress studentProgress;
        public TempServerPage(TaskModel task, Dictionary<string, UserProfile> users)
        {
            InitializeComponent();
            currentTask = task;
            expectedUsers = users;
            _server = new TcpListener(IPAddress.Parse(NetworkServices.GetIpv4()), 1901);

            Task.Run(UdpServerInfoSender);
            // Start the server in the background task
            Task.Run(async () => await StartServerAsync());
        }

        private async Task StartServerAsync()
        {
            try
            {
                _server.Start(); // Only start once!

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

        // Helper method to make AcceptTcpClient async
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
                            if (expectedUsers.ContainsKey(profile._studentId))
                            {
                                UserProfile actualProfile = expectedUsers[profile._studentId];
                                if (currentStudents.Contains(profile._studentName))
                                    errorMsg = "This student is already logged in";
                                else
                                {
                                    _ = Task.Run(() => userIcons.Add(networkStream, memberContainer.AddUser(actualProfile, networkStream, NewUserSelected)));

                                    currentStudents.Add(obj._userProfile._studentName);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LogInSuccessful).Task(currentTask).Build(), PrefixStyle.Base128);
                                    didLogIn = true;
                                }
                            }
                            if (!didLogIn)
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.StudentProgress:
                            studentProgress = obj._progress;
                            this.Invoke((Delegate)(() => { 
                                int studentProgLength = studentProgress.CodeProgress.Count - 1;
                                bool atMax = codeTrack.Maximum == codeTrack.Value;
                                codeTrack.Maximum = studentProgLength;
                                if (atMax)
                                {
                                    studentCode.Text = studentProgress.sourceCode;
                                    codeTrack.Value = studentProgLength;
                                }
                            }));
                            break;
                        default:
                            //Invoke(new Action(() =>
                            //{
                            //    richTextBox1.AppendText($"Unknown Message Type: {obj.Content}\n");
                            //}));
                            break;
                    }

                }
                catch (IOException)
                {
                    //Debug.WriteLine("Receiver stopped: Client disconnected");
                    break; // Exit the loop if the client disconnects
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Naay error");
                    //Debug.WriteLine($"Receiver stopped: {ex.Message}");
                    //error handling will happen if further development shows some possible issues
                }
            }
            Invoke(new Action(() =>
            {
                try
                {
                    userIcons[networkStream].Dispose();
                }
                catch (KeyNotFoundException ex) { }
            }));
            userIcons.Remove(networkStream);
        }

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

        private void NewUserSelected(string username, string address)
        {
            studentProgress = null;
            codeTrack.Maximum = 0;
            codeTrack.Value = 0;
            studentCode.Text = string.Empty;
            studentName.Text = username;
            ipaddress.Text = address;

            studentProgress = null;
            codeTrack.Maximum = 0;
            codeTrack.Value = 0;
            studentCode.Text = string.Empty;
        }
        private void codeTrack_Scroll(object sender, EventArgs e)
        {
            if (studentProgress == null)
                return;
            this.Invoke((Action)(() => 
            {
                studentCode.Text = studentProgress.CodeProgress[codeTrack.Value];
            }));
        }
    }
}
