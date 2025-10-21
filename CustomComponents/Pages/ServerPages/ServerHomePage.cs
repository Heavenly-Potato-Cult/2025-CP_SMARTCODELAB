using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerHomePage : UserControl
    {
        private readonly SemaphoreSlim _semaphore = new(1, 1);
        private System.Threading.Timer searchTimer;
        private List<string> studentsSubmitted;
        public List<Notification> notifications { get; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int _totalStudents { 
            get => totalStudents; 
            set
            {
                totalStudents = value;
                setActiveStudentDisplay();
            } }

        private int totalStudents;
        private int totalActiveStudents = 0;
        private int totalLoggedInStudents = 0;
        public int submittedCount { get; private set; }
        public int copyPasteDetectedCount { get; private set; }
        public ServerHomePage(int totalStudents)
        {
            InitializeComponent();
            this.totalStudents = totalStudents;
            submittedCount = 0;
            copyPasteDetectedCount = 0;
            studentsSubmitted = new List<string>();
            notifications = new List<Notification>();
            studentName._TextChanged += (sender, e) =>
            {
                searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                searchTimer = new System.Threading.Timer(async _ => await SearchStudent(), null, 500, Timeout.Infinite);
            };

            Object h = this.Handle;
            activeCount.Text = totalActiveStudents.ToString() + $"/{totalStudents}";
            submissionCount.Text = submittedCount.ToString() + $"/{totalStudents}";
        }

        public ServerHomePage(List<Notification> existingNotifications)
        {
            InitializeComponent();
            notifications = new List<Notification>();
            Load += (sender, e) =>
            {
                if (existingNotifications != null && existingNotifications.Count > 0)
                {
                    foreach (var notif in existingNotifications)
                    {
                        NewNotification(notif);
                    }
                }
            };
        }

        public async void NewNotification(Notification notification, UserProfile notifFrom = null)
        {
            await Task.Run(() =>
            {

                this.Invoke(new Action(async() =>
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
                    }
                    else if (notification.Type == NotificationType.LoggedIn || notification.Type == NotificationType.LoggedOut)
                    {
                        await UpdateActiveStudentsCount(notification.Type);
                    }
                        var notifCard = new NotificationIcon(notification);
                    notifications.Add(notification);

                    notifContainer.Controls.Add(notifCard);
                }));
            });
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

        private Task SearchStudent()
        {
            string searchedName = studentName.Texts.Trim();
            this.Invoke((Action)(() =>
            {
                notifContainer.Controls.Clear();

                notifications.
                    Where(notif => notif.UserName.Contains(searchedName, StringComparison.OrdinalIgnoreCase)).
                    ToList().
                    ForEach(studNotif => notifContainer.Controls.Add(new NotificationIcon(studNotif)));
            }));


            return Task.CompletedTask;
        }
    }
}
