using ProtoBuf;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SmartCodeLab
{
    public partial class MsgForm : Form
    {
        TcpListener tcpListener;
        List<NetworkStream> networkStreams = new List<NetworkStream>();
        const int port = 1901;

        //as a server
        public MsgForm(IPAddress iPAddress)
        {
            InitializeComponent();
            tcpListener = new TcpListener(iPAddress, port);

            //client receiver
            new Thread(() =>
            {
                tcpListener.Start();
                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    _ = MessageReceiverAsync(tcpClient.GetStream());
                    networkStreams.Add(tcpClient.GetStream());
                }
            }).Start();
        }

        //as a client
        public MsgForm(string serverIP)
        {
            InitializeComponent();
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse(serverIP), port);
            NetworkStream networkStream = tcpClient.GetStream();
            networkStreams.Add(networkStream);
            _ = MessageReceiverAsync(networkStream);
            tosend.TextChanged += async (s, e) =>
            {
                if (!tcpClient.Connected) return;

                var obj = new StudentCodingProgress(tosend.Text);

                // Serialize and send asynchronously
                await Task.Run(() =>
                    Serializer.SerializeWithLengthPrefix(networkStream, obj, PrefixStyle.Base128)
                );

                await networkStream.FlushAsync();
            };
        }

        private async Task MessageReceiverAsync(NetworkStream networkStream)
        {
            try
            {
                while (true)
                {
                    // Deserialize (protobuf is sync, so offload to a background thread)
                    StudentCodingProgress obj = await Task.Run(() =>
                        Serializer.DeserializeWithLengthPrefix<StudentCodingProgress>(networkStream, PrefixStyle.Base128)
                    );

                    // Update UI safely
                    if (obj != null)
                    {
                        this.Invoke(new Action(() =>
                        {
                            msgs.Text = obj.msg;
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle disconnect or stream errors
                Console.WriteLine($"Receiver stopped: {ex.Message}");
            }
        }
    }
}
