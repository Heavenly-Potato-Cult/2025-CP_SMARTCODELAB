using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
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
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class LoadingDialog : Form
    {
        readonly UdpClient udpClient;
        private bool isCancelled { get; set; }
        private List<IPEndPoint> senders = new List<IPEndPoint>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TcpClient client { get; set; }
        public LoadingDialog(TcpClient client)
        {
            InitializeComponent();
            udpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            isCancelled = false;
            this.client = client;
            this.Load += (s, e) => LookForServers();
        }

        private void LookForServers()
        {
            {
                udpClient.EnableBroadcast = true;

                IPEndPoint broadcastEP = new IPEndPoint(IPAddress.Parse(NetworkServices.GetBroadCastAddress()), 1902);

                //sender
                Task.Run(async () =>
                {
                    try
                    {
                        while (!isCancelled)
                        {
                            byte[] message = Encoding.UTF8.GetBytes("Discover servers!");
                            await udpClient.SendAsync(message, message.Length, broadcastEP);
                        }
                        Thread.Sleep(499);
                    }
                    catch (InvalidOperationException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                });

                //receiver
                Task.Run(async () =>
                {
                    try
                    {
                        while (!isCancelled)
                        {
                            UdpReceiveResult result = await udpClient.ReceiveAsync();
                            string reply = Encoding.UTF8.GetString(result.Buffer);
                            TaskModel task = JsonFileService.GetObjectFromText<TaskModel>(reply);

                            if (!senders.Contains(result.RemoteEndPoint))
                            {
                                senders.Add(result.RemoteEndPoint);
                                this.Invoke((Action)(() => serverContainer.Controls.Add(new ServerPageIcon(task,result.RemoteEndPoint, ConnectClient))));
                            }
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                isCancelled = true;
                senders.Clear();
            }
            base.Dispose(disposing);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            CloseMe();
        }
        public void ConnectClient(IPEndPoint point)
        {
            try
            {
                client.Connect(point.Address, 1901);
                this.Invoke(new Action(() =>
                {
                    if (Visible) Hide(); // hide immediately
                    Close();
                }));
            }
            catch (SocketException e)
            {
                Debug.WriteLine(e.Message);
            }catch (InvalidOperationException) { }
        }

        public void CloseMe()
        {
            isCancelled = true;
            senders.Clear();
            Close();
        }
    }
}
