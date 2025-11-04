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
using System.IO;
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

        private Task logInTask;

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

        private void smartButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Texts) || string.IsNullOrEmpty(password.Texts))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logInTask?.Dispose();

            logInTask = Task.Run(async () =>
            {
                try
                {
                    // Start listening for server messages
                    _ = Task.Run(() =>
                    {
                        try
                        {
                            while (true)
                            {
                                var msg = Serializer.DeserializeWithLengthPrefix<ServerMessage>(_stream, PrefixStyle.Base128);
                                if (msg == null)
                                    break;

                                if (msg._messageType == MessageType.LOG_IN_SUCCESSFUL)
                                {
                                    serverTask = msg._task;
                                    _userName = msg._userProfile._studentName;
                                    progress = msg._progress;
                                    Invoke(() => this.DialogResult = DialogResult.OK);
                                    break;
                                }
                                else if (msg._messageType == MessageType.LOG_IN_FAILED)
                                {
                                    Invoke(() => MessageBox.Show(msg._errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
                                    break;
                                }
                            }
                        }
                        catch (ProtoException ex)
                        {
                            Debug.WriteLine($"ProtoException: {ex.Message}");
                        }
                        catch (IOException io)
                        {
                            Debug.WriteLine($"Stream closed: {io.Message}");
                        }
                    });

                    // Send the login request
                    var loginMessage = new ServerMessage.Builder(MessageType.USER_PROFILE)
                        .UserProfile(new UserProfile(userName.Texts, password.Texts))
                        .Build();

                    Serializer.SerializeWithLengthPrefix(_stream, loginMessage, PrefixStyle.Base128);
                    await _stream.FlushAsync();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error during login: {ex}");
                }
            });
        }
    }
}
