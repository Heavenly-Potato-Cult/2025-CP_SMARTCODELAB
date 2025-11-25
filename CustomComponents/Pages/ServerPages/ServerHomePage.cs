using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerHomePage : UserControl
    {
        private readonly SemaphoreSlim _semaphore = new(1, 1);
        private System.Threading.Timer searchTimer;
        private List<string> studentsSubmitted;
        public List<Notification> notifications { get; }

        //i will use this to locate the index of a users in the notificats lists, to smoothly update their names when needed
        private Dictionary<string, List<int>> personWithNotification;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int _totalStudents
        {
            get => totalStudents;
            set
            {
                totalStudents = value;
                setActiveStudentDisplay();
            }
        }

        private int totalStudents;
        private int totalActiveStudents = 0;
        public int submittedCount { get; private set; }
        public int copyPasteDetectedCount { get; private set; }
        private long searchVersion;

        public ServerHomePage(Server session, Action displayStudentTable, Action saveSession, Action closing)
        {
            InitializeComponent();
            personWithNotification = new Dictionary<string, List<int>>();
            searchVersion = 0;
            this.totalStudents = session.Users.Count;
            submittedCount = 0;
            copyPasteDetectedCount = 0;
            studentsSubmitted = new List<string>();
            notifications = new List<Notification>();

            Object h = this.Handle;
            activeCount.Text = totalActiveStudents.ToString() + $"/{totalStudents}";
            submissionCount.Text = submittedCount.ToString() + $"/{totalStudents}";
            lbl_sessionname.Text = session.ServerName;
            lbl_sessionpassword.Text = session.Password;

            viewStud.Click += (sender, e) =>
            {
                displayStudentTable?.Invoke();
            };

            saveSes.Click += (sender, e) =>
            {
                saveSession?.Invoke();
            };

            exit.Click += (sender, e) =>
            {
                saveSession?.Invoke();
                SystemSingleton.Instance.page1.Controls.Clear();
                SystemSingleton.Instance.page1.Controls.Add(new TempSessionManagement2() { Dock = DockStyle.Fill });
                SystemSingleton.Instance.saveSession = null;
                closing?.Invoke();
            };
            _stopwatch = new Stopwatch();
            InitializeTimer();
        }

        public ServerHomePage()
        {
            InitializeComponent();

            // Initialize collections to avoid NullReferenceException in the designer
            notifications = new List<Notification>();
            studentsSubmitted = new List<string>();

            // Set default values for display in the designer
            activeCount.Text = "0/0";
            submissionCount.Text = "0/0";

            searchVersion = 0;

        }
        public void updateCountDisplay(int studentCounts)
        {
            this.Invoke((Action)(() =>
            {
                totalStudents = studentCounts;
                activeCount.Text = totalActiveStudents + $"/{totalStudents}";
                submissionCount.Text = submittedCount + $"/{totalStudents}";
            }));
        }

        private void InitializeTimer()
        {
            _stopwatch.Start();
            _ = StartTimerAsync();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // WS_EX_COMPOSITED: Paints all descendants of a window in bottom-to-top 
                // painting order using double-buffering.
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public async void NewNotification(Notification notification, UserProfile notifFrom = null)
        {
            await Task.Run(() =>
            {

                this.Invoke(new Action(async () =>
                {

                    if (notification.Type == NotificationType.Submitted && notifFrom != null && !studentsSubmitted.Contains(notifFrom._studentId))
                    {
                        studentsSubmitted.Add(notifFrom._studentId);
                        submittedCount++;
                        setStudentSubmittedDisplay();
                    }
                    else if (notification.Type == NotificationType.CopyPasted)
                    {
                        copyPasteDetectedCount++;
                        this.Invoke((Action)(() => pastedCount.Text = copyPasteDetectedCount.ToString()));
                    }
                    else if (notification.Type == NotificationType.LoggedIn || notification.Type == NotificationType.LoggedOut)
                    {
                        await UpdateActiveStudentsCount(notification.Type);
                    }
                    if(!personWithNotification.ContainsKey(notifFrom?._studentId ?? ""))
                        personWithNotification[notifFrom?._studentId ?? ""] = new List<int>();
                    personWithNotification[notifFrom?._studentId ?? ""].Add(notifications.Count);

                    notifications.Add(notification);

                    string senderName = notifFrom != null ? notifFrom._studentName : string.Empty;
                    string notifFilterString = notifFilter.SelectedItem?.ToString() ?? "All";
                    bool isForAll = notifFilterString.Equals("All", StringComparison.OrdinalIgnoreCase);
                    bool isTypeMatched = NotificationTypeExtensions.ToFriendlyString(notification.Type).Equals(notifFilterString, StringComparison.OrdinalIgnoreCase);

                    if (senderName.Contains(studentName.Texts, StringComparison.OrdinalIgnoreCase) && (isForAll || isTypeMatched))
                        notifContainer.Controls.Add(new NotificationIcon(notification));
                }));
            });
        }

        public async Task updateNotifCardName(UserProfile user)
        {
            this.Invoke((Action)(() => 
            {
                foreach (var item in personWithNotification[user._studentId])
                {
                    notifications[item].UserName = user._studentName;
                }
            }));
        }

        public async Task UpdateActiveStudentsCount(NotificationType notificationType)
        {
            await _semaphore.WaitAsync();
            try
            {
                if (notificationType == NotificationType.LoggedIn)
                    totalActiveStudents++;
                else
                    totalActiveStudents--;
                setActiveStudentDisplay();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private void setActiveStudentDisplay()
        {
            this.Invoke((Action)(() => activeCount.Text = totalActiveStudents.ToString() + $"/{totalStudents}"));
        }

        private void setStudentSubmittedDisplay()
        {
            this.Invoke((Action)(() => submissionCount.Text = submittedCount.ToString() + $"/{totalStudents}"));
        }

        private async Task SearchStudent()
        {
            long currentSearchVersion = ++searchVersion;
            string searchedName = studentName.Texts.Trim();
            this.Invoke((Action)(() =>
            {
                Task.Delay(200);
                notifContainer.Controls.Clear();
                string notifFilterString = notifFilter.SelectedItem?.ToString() ?? "All";
                bool isForAll = notifFilterString.Equals("All", StringComparison.OrdinalIgnoreCase);
                List<Notification> filtered = notifications.
                    Where(notif => notif.UserName.Contains(searchedName, StringComparison.OrdinalIgnoreCase) && (isForAll || NotificationTypeExtensions.ToFriendlyString(notif.Type).Equals(notifFilterString, StringComparison.OrdinalIgnoreCase))).
                    ToList();
                foreach (var item in filtered)
                {
                    if (currentSearchVersion != searchVersion)
                        break;
                    notifContainer.Controls.Add(new NotificationIcon(item));
                }
            }));
        }

        //for the timer
        private Stopwatch _stopwatch;
        private CancellationTokenSource _cancellationTokenSource;

        private async Task StartTimerAsync()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _stopwatch.Start();

            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    if (this.IsHandleCreated && !this.IsDisposed)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke((Action)(() =>
                            {
                                currentTime.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
                            }));
                        }
                        else
                        {
                            currentTime.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
                        }
                    }

                    await Task.Delay(1000, _cancellationTokenSource.Token);
                }
            }
            catch (TaskCanceledException)
            {
                // Expected when cancellation is requested
            }
        }

        private void studentName__TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer(async _ => SearchStudent(), null, 500, Timeout.Infinite);
        }

        private void notifFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer(async _ => SearchStudent(), null, 500, Timeout.Infinite);
        }
    }
}
