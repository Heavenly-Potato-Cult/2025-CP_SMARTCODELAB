using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using System.Data;

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
        private UserIcons recentSelectedIcon;
        private StudentCodingProgress studentProgress;

        private System.Threading.Timer updateStudentList;
        private string selectedStudentId = string.Empty;
        private Func<string, StudentCodingProgress> progressRetriever;
        private Dictionary<string, List<UserMessage>> userMessages;
        private Func<string, UserMessage, bool> sendMessage;
        private Func<string, bool> isStudentActive;
        private ChatBox chatBox;
        private List<UserProfile> displayedUsers = new List<UserProfile>();

        private long searchVersion;
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
            displayedUsers = new List<UserProfile>();
            searchVersion = 0;

            //will ensure that the handle is created before accessing the UI thread
            var obj = this.Handle;
            displayUsers(users.Values.ToList());
            studentCodeRating1.SetStats(task.ratingFactors);
        }

        //for the display of session logs
        public TempServerPage(Dictionary<string, StudentCodingProgress> userProgress, Dictionary<string, UserProfile> users, Dictionary<int, decimal[]> ratingFactors)
        {
            InitializeComponent();
            displayedUsers = users.Select(users => users.Value).ToList();
            userMessages = new Dictionary<string, List<UserMessage>>();
            progressRetriever = (student_id) => userProgress[student_id];
            studentCodeRating1.SetStats(ratingFactors);
            smartButton1.Visible = false;
            status.Visible = false;

            searchVersion = 0;
            Load += (s, e) =>
            {
                Task.Run(() =>
                {
                    foreach (var user in users.Values)
                    {
                        userMessages.Add(user._studentId, new List<UserMessage>());
                        userIcons.Add(user._studentId, new UserIcons(user, NewUserSelected));
                    }
                    displayStudents();
                });
            };
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public async Task removeUserIcon(string userId)
        {
            this.Invoke((Action)(() =>
            {
                userIcons[userId].Dispose();
                userIcons.Remove(userId);
            }));
        }

        public void updateUserProfile(UserProfile profile)
        {
            this.Invoke((Action)(() =>
            {
                userIcons[profile._studentId].setNameText(profile._studentName);
            }));
        }

        public async void displayUsers(List<UserProfile> users)
        {
            await Task.Run(() =>
            {
                foreach (var user in users)
                {
                    userMessages[user._studentId] = new List<UserMessage>();
                    userIcons[user._studentId] = new UserIcons(user, NewUserSelected) { Dock = DockStyle.Top};
                    displayedUsers.Add(user);
                }
                displayStudents();
            });
        }

        private void displayStudents()
        {
            long currentSearchVersion = ++searchVersion;
            string search = searchStudent.Text.ToLower();
            var searchedUserIds = displayedUsers.
                Where(user => user._studentName.ToLower().Contains(search)).
                Select(user => user._studentId).ToList();
            var searchedIcons = userIcons.Keys.Where(id => searchedUserIds.Contains(id)).ToList();
            this.Invoke((Action)(() =>
            {
                string activeStatus = status.SelectedItem?.ToString() ?? "All";
                bool isActiveFilter = activeStatus.Equals("Active", StringComparison.OrdinalIgnoreCase);
                iconsContainer.Controls.Clear();
                foreach (var ids in searchedIcons)
                {
                    if (currentSearchVersion != searchVersion)
                        break;

                    UserIcons icon = userIcons[ids];
                    if (activeStatus.Equals("All") || isActiveFilter == icon.isActive)
                    iconsContainer.Controls.Add(userIcons[ids]);
                }
            }));
        }

        public void StudentLoggedIn(UserProfile profile)
        {
            this.Invoke((Action)(() =>
            {
                userIcons[profile._studentId].profile._computerAddress = profile._computerAddress;
                userIcons[profile._studentId].setStatus(true);

                string activeStatus = status.SelectedItem?.ToString() ?? "All";
                bool isActiveFilter = activeStatus.Equals("Active", StringComparison.OrdinalIgnoreCase);
                if (!activeStatus.Equals("All") && isActiveFilter)
                {
                    shouldAddIcon(profile, true);
                }
                else if (!activeStatus.Equals("All"))
                    shouldAddIcon(profile, false);
            }));
        }

        public void StudentLoggedOut(UserProfile profile)
        {
            this.Invoke((Action)(() =>
            {
                userIcons[profile._studentId].setStatus(false);
                string activeStatus = status.SelectedItem?.ToString() ?? "All";
                bool isInactiveFilter = activeStatus.Equals("Inactive", StringComparison.OrdinalIgnoreCase);
                if (!activeStatus.Equals("All") && isInactiveFilter)
                {
                    shouldAddIcon(profile, true);
                }
                else if (!activeStatus.Equals("All"))
                    shouldAddIcon(profile, false);
            }));
        }

        private void shouldAddIcon(UserProfile profile, bool willAdd) //true will add, else remove
        {
            this.Invoke((Action)(() =>
            {
                if (willAdd)
                {
                    iconsContainer.Controls.Add(userIcons[profile._studentId]);
                }
                else
                {
                    iconsContainer.Controls.Remove(userIcons[profile._studentId]);
                }
            }));
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

        private void SentBroadCaseMessage(string message)
        {
            Task.Run(() =>
            {
                foreach (var item in displayedUsers)
                {
                    SendMessageToStudent(item._studentId, message);
                }
            });
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

        public async void UpdateStudentProgressDisplay(UserProfile user, StudentCodingProgress progress, bool fromClick = false)
        {
            if (user._studentId == selectedStudentId)
            {
                await Task.Run(() =>
                {
                    this.Invoke((Delegate)(() =>
                    {
                        studentProgress = progress;
                        int studentProgLength = studentProgress.CodeProgress.Count - 1;
                        if (fromClick)
                            codeTrack.Value = studentProgLength;
                        bool atMax = codeTrack.Maximum == codeTrack.Value;
                        codeTrack.Maximum = studentProgLength;
                        if (atMax)
                        {
                            studentCode.Text = studentProgress.sourceCode;
                            codeTrack.Value = studentProgLength < 0 ? 0 : studentProgLength;
                        }

                        copypastedCodes.Controls.Clear();
                        if (studentProgress.pastedCode != null)
                        {

                            try
                            {
                                copypastedCodes.SuspendLayout();

                                foreach (var item in studentProgress.pastedCode)
                                {
                                    var icon = new PastedCodeIcon(item)
                                    {
                                        Dock = DockStyle.Top
                                    };

                                    copypastedCodes.Controls.Add(icon);
                                }
                            }
                            finally
                            {
                                copypastedCodes.ResumeLayout();
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

        private void NewUserSelected(UserProfile profile, UserIcons newSelected)
        {
            //set the icon color
            recentSelectedIcon?.LostFocusDisplay();
            recentSelectedIcon = newSelected;

            selectedStudentId = profile._studentId;
            try
            {
                UpdateStudentProgressDisplay(profile, progressRetriever?.Invoke(profile._studentId) ?? new StudentCodingProgress(), true);
            }
            catch (KeyNotFoundException)
            {
                this.Invoke((Delegate)(() =>
                {
                    codeTrack.Maximum = 0;
                    studentCode.Text = "No Progress";
                    copypastedCodes.Controls.Clear();
                    //this.studentCodeRating1.UpdateStatsDisplay(progress.codeRating);
                }));
            }

            studentName.Text = profile._studentName.ToUpper() + " | " + profile._computerAddress;
            //ipaddress.Text = profile._computerAddress;
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
            updateStudentList = new System.Threading.Timer(_ => displayStudents(), null, 500, Timeout.Infinite);
        }

            private void smartButton1_Click(object sender, EventArgs e)
            {
                var messageForm = new TextForm();
                if (messageForm.ShowDialog() == DialogResult.OK)
                {
                    SentBroadCaseMessage(messageForm.Message + '\n');
                }
            }

            private void codeTrack_ValueChanged(object sender, EventArgs e)
            {
                if (studentProgress == null)
                    return;

                studentCode.Text = studentProgress.CodeProgress[codeTrack.Value];
            }

        private void status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            updateStudentList?.Change(Timeout.Infinite, Timeout.Infinite);
            updateStudentList = new System.Threading.Timer(_ => displayStudents(), null, 500, Timeout.Infinite);
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(selectedStudentId))
                return;
            chatBox = new ChatBox(SendMessageToStudent, userMessages[selectedStudentId] ?? null, isStudentActive(selectedStudentId), studentName.Text, selectedStudentId);
            chatBox.ShowDialog();
            chatBox = null;
        }

        private void steamGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
