using ProtoBuf;
using SmartCodeLab.CustomComponents.MainPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
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
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ServerPage : UserControl
    {
        private TaskModel currentTask { get; set; }
        private TcpListener _server;
        private Dictionary<NetworkStream,UserIcons> userIcons = new Dictionary<NetworkStream, UserIcons>();

        private readonly List<string> expectedStudentNames = new List<string>() { "slimfordy","stagnant potato"};
        private List<string> currentStudents = new List<string>();
        public ServerPage(TaskModel task)
        {
            InitializeComponent();
            currentTask = task;
            _server = new TcpListener(IPAddress.Parse("127.0.0.1"), 1901);

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
                    }catch(IOException)
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
                            if (obj._userProfile != null && expectedStudentNames.Contains(obj._userProfile._studentName))
                            {
                                if (!currentStudents.Contains(obj._userProfile._studentName)) 
                                {
                                    _ = Task.Run(() => userIcons.Add(networkStream, serverMemberContainer1.AddUser(obj._userProfile._studentName, networkStream)));

                                    currentStudents.Add(obj._userProfile._studentName);
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LogInSuccessful).Task(currentTask).Build(), PrefixStyle.Base128);
                                }
                                else
                                    Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                        new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage("This student is already logged in").Build(), PrefixStyle.Base128);
                            }
                            else
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage("We can't find an account with that username and password").Build(), PrefixStyle.Base128);
                            await networkStream.FlushAsync();
                            break;
                        case MessageType.StudentProgress:
                            this.Invoke(() => studentCode.Text = obj._progress.sourceCode);
                            break;
                        default:
                            Invoke(new Action(() =>
                            {
                                //richTextBox1.AppendText($"Unknown Message Type: {obj.Content}\n");
                            }));
                            break;
                    }

                }catch(IOException)
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
            Invoke(new Action(() => {
                userIcons[networkStream].Dispose();
            }));
            userIcons.Remove(networkStream);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            _server.Stop();
            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.Controls.Add(new ServerSetUpPage());
        }
    }
}
