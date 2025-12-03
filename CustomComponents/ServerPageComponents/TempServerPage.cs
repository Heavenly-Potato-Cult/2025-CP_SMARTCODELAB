using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempServerPage : UserControl
    {
        public TempServerPage()
        {
            InitializeComponent();
        }

        private TaskModel currentTask { get; set; }
        private Dictionary<string, UserIcons> userIcons = new Dictionary<string, UserIcons>();
        private UserIcons recentSelectedIcon;
        private StudentCodingProgress studentProgress;

        private System.Threading.Timer updateStudentList;
        private string selectedStudentId;
        private Func<string, StudentCodingProgress> progressRetriever;
        // CHANGE: use ConcurrentQueue to preserve message order (FIFO)
        private ConcurrentDictionary<string, ConcurrentQueue<UserMessage>> userMessages;
        private Func<string, UserMessage, Task<bool>> sendMessage;
        private Action<string, bool> informUserMonitor;
        private Func<string, bool> isStudentActive;
        private ChatBox chatBox;
        private List<UserProfile> displayedUsers = new List<UserProfile>();
        private bool isForLogs;
        private long searchVersion;
        public TempServerPage(TaskModel task, 
            Dictionary<string, UserProfile> users, 
            Func<string,StudentCodingProgress> progressRetriever, 
            Func<string, bool> isStudentActive, 
            Func<string, UserMessage, Task<bool>> sendMessage, 
            Action<string, bool> informUserMonitor)
        {
            InitializeComponent();
            selectedStudentId = string.Empty;
            this.informUserMonitor = informUserMonitor;
            isForLogs = false;
            userMessages = new ConcurrentDictionary<string, ConcurrentQueue<UserMessage>>();
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
            searchStudent.innerTextBox.TextChanged += (s, e) =>
            {
                updateStudentList?.Change(Timeout.Infinite, Timeout.Infinite);
                updateStudentList = new System.Threading.Timer(_ => displayStudents(), null, 500, Timeout.Infinite);
            };
        }

        //for the display of session logs
        public TempServerPage(Dictionary<string, StudentCodingProgress> userProgress, Dictionary<string, UserProfile> users, Dictionary<int, decimal[]> ratingFactors)
        {
            InitializeComponent();
            isForLogs = true;
            displayedUsers = new List<UserProfile>();
            userMessages = new ConcurrentDictionary<string, ConcurrentQueue<UserMessage>>();
            progressRetriever = (student_id) => userProgress[student_id];
            studentCodeRating1.SetStats(ratingFactors);
            smartButton1.Visible = false;
            status.Visible = false;

            var obj = this.Handle;
            searchVersion = 0;
            displayUsers(users.Values.ToList());
            searchStudent.innerTextBox.TextChanged += (s, e) =>
            {
                updateStudentList?.Change(Timeout.Infinite, Timeout.Infinite);
                updateStudentList = new System.Threading.Timer(_ => displayStudents(), null, 500, Timeout.Infinite);
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
                if (selectedStudentId == userId)
                    recentSelectedIcon = null;
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
                    try
                    {
                        // INIT QUEUE instead of BAG
                        userMessages.TryAdd(user._studentId, new ConcurrentQueue<UserMessage>());
                        userIcons[user._studentId] = new UserIcons(user, NewUserSelected) { Dock = DockStyle.Top };
                        displayedUsers.Add(user);
                    }
                    catch (ArgumentException) { }
                }
                displayStudents();
            });
        }

        private void displayStudents()
        {
            this.Invoke((Action)(() =>
            {
                long currentSearchVersion = ++searchVersion;
                string search = searchStudent.innerTextBox.Text.ToLower();
                var searchedUserIds = displayedUsers.
                    Where(user => user._studentName.ToLower().Contains(search)).
                    Select(user => user._studentId).ToList();
                var searchedIcons = userIcons.Keys.Where(id => searchedUserIds.Contains(id)).ToList();
                string activeStatus = status.SelectedItem?.ToString() ?? "All";
                bool isActiveFilter = activeStatus.Equals("Active", StringComparison.OrdinalIgnoreCase);
                iconsContainer.Controls.Clear();

                foreach (var ids in searchedIcons)
                {
                    UserIcons icon = userIcons[ids];
                    if (isForLogs || activeStatus.Equals("All") || isActiveFilter == icon.isActive)
                    {
                        iconsContainer.Controls.Add(userIcons[ids]);
                    }
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
            // Ensure dictionary entry exists
            var queue = userMessages.GetOrAdd(studentId, _ => new ConcurrentQueue<UserMessage>());

            // Normalize fields for professor view
            message.isFromMe = false;                // Student -> Prof
            message.IsBroadcast = false;
            // Critical: don’t keep "Me" from the student payload
            if (userIcons.TryGetValue(studentId, out var icon) && icon?.profile != null)
                message.senderName = icon.profile._studentName;
            else
                message.senderName = "Student";

            queue.Enqueue(message);

            if (chatBox != null && chatBox.studentId == studentId)
            {
                chatBox.receivedMessage(message.message);
            }
        }

        // Broadcast: forward with isBroadcast = true
        private void SentBroadCaseMessage(string message)
        {
            Task.Run(async () =>
            {
                foreach (var item in displayedUsers)
                {
                    await SendMessageToStudent(item._studentId, message, isBroadcast: true);
                }
            });
        }

        // Direct send: ensure isFromMe = true and (optionally) IsBroadcast
        private async Task<bool> SendMessageToStudent(string studentId, string message, bool isBroadcast = false)
        {
            if (isStudentActive(studentId))
            {
                var messageObj = new UserMessage(message)
                {
                    isFromMe = true,
                    senderName = "Instructor",   // store a clear sender for the student
                    IsBroadcast = isBroadcast
                };

                var result = await sendMessage(studentId, messageObj);
                if (result)
                {
                    var queue = userMessages.GetOrAdd(studentId, _ => new ConcurrentQueue<UserMessage>());
                    // Locally, mark mine as "Me" for display on professor side
                    var localCopy = new UserMessage(messageObj.message, true, "Me", isBroadcast);
                    queue.Enqueue(localCopy);
                    return true;
                }
                return false;
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
                        studentProgLength = studentProgLength < 0 ? 0 : studentProgLength;
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

        private async void NewUserSelected(UserProfile profile, UserIcons newSelected)
        {
            recentSelectedIcon?.LostFocusDisplay();
            recentSelectedIcon = newSelected;

            if(selectedStudentId != string.Empty && selectedStudentId != profile._studentId && !isForLogs)
                informUserMonitor?.Invoke(selectedStudentId, false);

            selectedStudentId = profile._studentId;

            if(!isForLogs)
                informUserMonitor?.Invoke(selectedStudentId, true);

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
                }));
            }

            studentName.Text = profile._studentName.ToUpper() + " | " + profile._computerAddress;
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

            userMessages.TryGetValue(selectedStudentId, out var messagesForStudent);
            // Snapshot in FIFO order
            var snapshot = messagesForStudent != null ? messagesForStudent.ToArray().ToList() : new List<UserMessage>();

            Func<string, string, Task<bool>> sendMsgDelegate = (sid, msg) => SendMessageToStudent(sid, msg, isBroadcast: false);

            chatBox = new ChatBox(sendMsgDelegate, snapshot, isStudentActive(selectedStudentId), studentName.Text, selectedStudentId);
            chatBox.ShowDialog();
            chatBox = null;
        }

        private void steamGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
