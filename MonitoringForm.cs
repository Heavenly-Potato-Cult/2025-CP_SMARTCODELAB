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
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class MonitoringForm : Form
    {
        public MonitoringForm()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
            SystemSingleton.Instance.page1 = tabPage1;
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void serverSetUpPage1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(IPAddress.Parse("127.0.0.1"));
            msgForm.Show();
        }

        async private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                TaskModel task = null;
                TcpClient client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 1901);
                NetworkStream networkStream = client.GetStream();

                // Start receiving in a separate task
                await Task.Run(() =>
                {
                    try
                    {
                        while (true)
                        {
                            var msg = Serializer.DeserializeWithLengthPrefix<ServerMessage>(networkStream, PrefixStyle.Base128);

                            if (msg == null)
                                break;

                                if (msg._messageType == Models.Enums.MessageType.ServerTask)
                                {
                                    Debug.WriteLine(msg._task.ToString());
                                    task = msg._task;
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }));
                    }
                });
                await Task.Run(() => MessageBox.Show(task.ToString()));
            }
            catch (SocketException)
            {
                MessageBox.Show("No connection");
            }
        }

    }
}
