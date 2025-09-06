using ProtoBuf;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class UserLogInDIalog : Form
    {
        public string _userName { get { return userName.Texts; } }
        public string _folderLocation { get { return folderLoc.Texts; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TcpClient _client { get; set; }

        public NetworkStream _stream;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TaskModel serverTask { get; set; }
        public UserLogInDIalog(TcpClient client)
        {
            InitializeComponent();
            _client = client;
            _stream = _client.GetStream();
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderLoc.Texts = folderBrowserDialog.SelectedPath;
            }
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            _stream.Close();
            _client.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        async private void smartButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Texts) || string.IsNullOrEmpty(folderLoc.Texts))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _ = Task.Run(() =>
            {
                while (true)
                {
                    var msg = Serializer.DeserializeWithLengthPrefix<ServerMessage>(_stream, PrefixStyle.Base128);
                    if (msg._messageType == MessageType.LogInSuccessful)
                    {
                        serverTask = msg._task;
                        this.DialogResult = DialogResult.OK;
                        break;
                    }
                    else if (msg._messageType == MessageType.LogInFailed)
                    {
                        Invoke((Action)(() => MessageBox.Show(msg._errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                        break;
                    }
                }
            });

            await Task.Run(() =>
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(_stream,
                    new ServerMessage.Builder(MessageType.UserProfile).UserProfile(new UserProfile(userName.Texts)).Build(),
                    PrefixStyle.Base128);
            });

            await _stream.FlushAsync();
        }
    }
}
