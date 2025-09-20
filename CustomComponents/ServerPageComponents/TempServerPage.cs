using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
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

        //student ID as the key
        private List<string> currentStudents = new List<string>();
        private StudentCodingProgress studentProgress;
        StudTable userTable;
        public TempServerPage(TaskModel task, Dictionary<string, UserProfile> users)
        {
            InitializeComponent();
            userTable = new StudTable(users);
            currentTask = task;
        }

        public void RemoveUser(NetworkStream networkStream)
        {
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

        public async Task MessageHandler(ServerMessage message, NetworkStream networkStream, Action<NetworkStream,string,bool> action)
        {
            try
            {
                switch (message._messageType)
                {
                    case MessageType.ServerTaskRequest:
                        Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                            new ServerMessage.Builder(MessageType.ServerTask).Task(currentTask).Build(), PrefixStyle.Base128);
                        await networkStream.FlushAsync();
                        break;
                    case MessageType.UserProfile:
                        if (message._userProfile == null)
                            break;
                        UserProfile profile = message._userProfile;
                        bool didLogIn = false;
                        string errorMsg = "We can't find an account with that Student ID";
                        if (userTable.ContainsUser(profile._studentId))
                        {
                            UserProfile actualProfile = userTable.GetUserProfile(profile._studentId);
                            if (currentStudents.Contains(profile._studentName))
                                errorMsg = "This student is already logged in";
                            else
                            {
                                _ = Task.Run(() => userIcons.Add(networkStream, memberContainer.AddUser(actualProfile, networkStream, NewUserSelected)));

                                currentStudents.Add(profile._studentName);
                                Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                    new ServerMessage.Builder(MessageType.LogInSuccessful).Task(currentTask).Build(), PrefixStyle.Base128);
                                didLogIn = true;
                                action?.Invoke(networkStream, profile._studentId, true);
                            }
                        }
                        if (!didLogIn)
                            Serializer.SerializeWithLengthPrefix<ServerMessage>(networkStream,
                                new ServerMessage.Builder(MessageType.LogInFailed).ErrorMessage(errorMsg).Build(), PrefixStyle.Base128);
                        await networkStream.FlushAsync();
                        break;
                    case MessageType.StudentProgress:
                        studentProgress = message._progress;
                        this.Invoke((Delegate)(() =>
                        {
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
                action?.Invoke(networkStream,"", false);
            }//if the connection is disconnected
            catch (Exception)
            {
                MessageBox.Show("TempServerPage under Message Handler");
            }
        }

        public void UpdateTask(TaskModel task)
        {
            currentTask = task;
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

        private void smartButton4_Click(object sender, EventArgs e)
        {
            userTable.ShowDialog();
        }
    }
}
