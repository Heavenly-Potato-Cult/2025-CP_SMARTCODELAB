using ProtoBuf;
using SmartCodeLab.CustomComponents.MainPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ServerPage(TaskModel task)
        {
            InitializeComponent();
            currentTask = task;
            TcpListener _server = new TcpListener(IPAddress.Parse("127.0.0.1"), 1901);
            _server.Start();
            Task.Run(() =>
            {
                _server.Start();
                while (true)
                {
                    _ = MessageReceiverAsync(_server.AcceptTcpClient());
                }
            });
        }

        private async Task MessageReceiverAsync(TcpClient client)
        {
            MessageBox.Show("Someone connected");
            NetworkStream networkStream = client.GetStream();

            //send the task to the new client
            await Task.Run(() =>Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream, new ServerMessage.Builder().MessageType(MessageType.ServerTask).Task(currentTask).Build(), PrefixStyle.Base128));
            await networkStream.FlushAsync();
            while (true)
            {
                try
                {
                    var obj = await Task.Run(() =>
                        Serializer.DeserializeWithLengthPrefix<ServerMessage>(networkStream, PrefixStyle.Base128)
                    );

                    if (obj == null)
                        break;

                    switch (obj._messageType)
                    {
                        case MessageType.ServerTaskRequest:
                            MessageBox.Show("Requesting");
                            await Task.Run(() => Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                new ServerMessage.Builder().MessageType(MessageType.ServerTask).Task(currentTask).Build(), PrefixStyle.Base128));
                            await networkStream.FlushAsync();
                            break;
                        default:
                            Invoke(new Action(() =>
                            {
                                //richTextBox1.AppendText($"Unknown Message Type: {obj.Content}\n");
                            }));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Naay error");
                    //Debug.WriteLine($"Receiver stopped: {ex.Message}");
                    //error handling will happen if further development shows some possible issues
                }
            }
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.Controls.Add(new ServerSetUpPage());
        }
    }
}
