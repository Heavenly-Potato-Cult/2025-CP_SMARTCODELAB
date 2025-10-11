using ProtoBuf;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string _userName { set; get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TcpClient _client { get; set; }

        public NetworkStream _stream;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TaskModel serverTask { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StudentCodingProgress progress { get; set; }
        public UserLogInDIalog(TcpClient client)
        {
            InitializeComponent();
            _client = client;
            _stream = _client.GetStream();
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            _stream.Close();
            _client.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        async private void smartButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Texts))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //expects a reply
            _ = Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        var msg = Serializer.DeserializeWithLengthPrefix<ServerMessage>(_stream, PrefixStyle.Base128);
                        if (msg._messageType == MessageType.LOG_IN_SUCCESSFUL)
                        {
                            serverTask = msg._task;
                            _userName = msg._userProfile._studentName;
                            progress = msg._progress;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                        else if (msg._messageType == MessageType.LOG_IN_FAILED)
                        {
                            Invoke((Action)(() => MessageBox.Show(msg._errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                            break;
                        }
                    }
                }catch(ProtoException pe)
                {
                    Debug.WriteLine(pe.Message);
                }
            });

            await Task.Run(() =>
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(_stream,
                    new ServerMessage.Builder(MessageType.USER_PROFILE).UserProfile(new UserProfile(userName.Texts)).Build(),
                    PrefixStyle.Base128);
            });
            await _stream.FlushAsync();
        }
    }
}
