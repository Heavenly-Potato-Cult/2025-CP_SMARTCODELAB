using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempServerPage : UserControl
    {
        public TempServerPage()
        {
            InitializeComponent();
        }

        private TaskModel currentTask { get; set; }
        //private TcpListener _server;
        //student ID as the key
        private Dictionary<string, UserIcons> userIcons = new Dictionary<string, UserIcons>();
        private StudentCodingProgress studentProgress;

        private System.Threading.Timer updateStudentList;
        private string selectedStudentId = string.Empty;
        private Func<string, StudentCodingProgress> progressRetriever;
        private Dictionary<string, List<UserMessage>> userMessages;
        private Func<string, UserMessage, bool> sendMessage;
        private Func<string, bool> isStudentActive;
        private ChatBox chatBox;
        private List<UserProfile> displayedUsers = new List<UserProfile>();
        public TempServerPage(TaskModel task, Dictionary<string, UserProfile> users, Func<string,
            StudentCodingProgress> progressRetriever, Func<string, bool> isStudentActive, Func<string, UserMessage, bool> sendMessage)
        {
            InitializeComponent();
            userMessages = new Dictionary<string, List<UserMessage>>();
            chatBox = null;
            currentTask = task;
            this.progressRetriever = progressRetriever;
            this.sendMessage = sendMessage;
            this.isStudentActive = isStudentActive;
            displayedUsers = new List<UserProfile>(users.Values);

            //will ensure that the handle is created before accessing the UI thread
            var obj = this.Handle;
            Task.Run(() =>
            {
                foreach (var user in users.Values)
                {
                    userMessages.Add(user._studentId, new List<UserMessage>());
                    userIcons.Add(user._studentId, new UserIcons(user, NewUserSelected));
                }
                displayStudents();
            });
            studentCodeRating1.SetStats(task.ratingFactors);
        }

        private void displayStudents()
        {
            string search = searchStudent.Texts.ToLower();
            var searchedUserIds = displayedUsers.Where(user => user._studentName.ToLower().Contains(search)).Select(user => user._studentId).ToList();
            var searchedIcons = userIcons.Keys.Where(id => searchedUserIds.Contains(id)).ToList();

            this.Invoke((Action)(() =>
            {
                iconsContainer.Controls.Clear();
                foreach (var ids in searchedIcons)
                {
                iconsContainer.Controls.Add(userIcons[ids]);
                }
            }));
        }

        public TempServerPage(Dictionary<string, UserProfile> expectedUsers, Dictionary<string, StudentCodingProgress> userProgress)
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                Task.Run(() =>
                {
                    foreach (var item in userProgress.Keys)
                    {
                        this.Invoke((Action)(() =>
                        {
                            Action<UserProfile> NewUserSelected = new Action<UserProfile>(userProfile =>
                            {
                                selectedStudentId = userProfile._studentId;
                                try
                                {
                                    UpdateStudentProgressDisplay(userProfile, userProgress[userProfile._studentId]);
                                }
                                catch (KeyNotFoundException) { }
                                studentName.Text = userProfile._studentName;
                            });
                            //user profile will be retrieved
                            iconsContainer.Controls.Add(new UserIcons(expectedUsers[item], NewUserSelected));
                        }));
                    }
                });
            };
        }

        public void AddStudent(UserProfile profile)
        {
            this.Invoke((Action)(() =>
            {
                //this will be used to view who are the students who are yet to log in or inactive(left the lobby), already logged in, and submitted
                profile._computerAddress = "";
                userIcons.Add(profile._studentId, new UserIcons(profile, NewUserSelected));
                iconsContainer.Controls.Add(userIcons[profile._studentId]);
            }));
        }

        public void StudentLoggedIn(UserProfile profile)
        {
            userIcons[profile._studentId].profile._computerAddress = profile._computerAddress;
        }

        public void ReceivedStudentMessage(UserMessage message, string studentId)
        {
            if (!userMessages.ContainsKey(studentId))
            {
                userMessages[studentId] = new List<UserMessage>();
            }
            message.isFromMe = false;
            userMessages[studentId].Add(message);

            if (chatBox != null && chatBox.studentId == studentId)
            {
                chatBox.receivedMessage(message.message);
            }
        }

        private bool SendMessageToStudent(string studentId, string message)
        {
            if (isStudentActive(studentId))
            {
                var messageObj = new UserMessage(message);
                if (sendMessage(studentId, messageObj))
                {
                    if (!userMessages.ContainsKey(studentId))
                        userMessages[studentId] = new List<UserMessage>();

                    userMessages[studentId].Add(messageObj);

                    return true;
                }
            }
            return false;
        }

        public async void UpdateStudentProgressDisplay(UserProfile user, StudentCodingProgress progress)
        {
            if (user._studentId == selectedStudentId)
            {
                await Task.Run(() =>
                {
                    this.Invoke((Delegate)(() =>
                    {
                        studentProgress = progress;
                        int studentProgLength = studentProgress.CodeProgress.Count - 1;
                        bool atMax = codeTrack.Maximum == codeTrack.Value;
                        codeTrack.Maximum = studentProgLength;
                        codeTrack.Minimum = 0;
                        if (atMax)
                        {
                            studentCode.Text = studentProgress.sourceCode;
                            codeTrack.Value = studentProgLength < 0 ? 0 : studentProgLength;
                        }

                        copypastedCodes.Controls.Clear();
                        if (studentProgress.pastedCode != null)
                        {
                            foreach (var item in studentProgress.pastedCode)
                            {
                                copypastedCodes.Controls.Add(new PastedCodeIcon(item));
                            }
                        }
                        this.studentCodeRating1.UpdateStatsDisplay(progress.codeRating);
                    }));
                });
            }
        }

        public void UpdateTask(TaskModel task)
        {
            currentTask = task;
        }

        private void NewUserSelected(UserProfile profile)
        {
            selectedStudentId = profile._studentId;
            try
            {
                UpdateStudentProgressDisplay(profile, progressRetriever?.Invoke(profile._studentId));
            }
            catch (KeyNotFoundException) { }

            studentName.Text = profile._studentName;
            ipaddress.Text = profile._computerAddress;
        }
        private void codeTrack_Scroll(object sender, EventArgs e)
        {
            if (studentProgress == null)
                return;

            studentCode.Text = studentProgress.CodeProgress[codeTrack.Value];
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
                return;
            chatBox = new ChatBox(SendMessageToStudent, userMessages[selectedStudentId] ?? null, isStudentActive(selectedStudentId), studentName.Text, selectedStudentId);
            chatBox.ShowDialog();
            chatBox = null;
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            updateStudentList?.Change(Timeout.Infinite, Timeout.Infinite);

            updateStudentList = new System.Threading.Timer(async _ => displayStudents(), null, 500, Timeout.Infinite);
        }
    }
}
