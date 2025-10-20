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
        private int submittedCount;
        public ServerHomePage()
        {
            InitializeComponent();
            submittedCount = 0;
            studentsSubmitted = new List<string>();
            notifications = new List<Notification>();
            studentName._TextChanged += (sender, e) =>
            {
                searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                searchTimer = new System.Threading.Timer(async _ => await SearchStudent(), null, 500, Timeout.Infinite);
            };

            Object h = this.Handle;
        }

        public async void NewNotification(Notification notification, UserProfile notifFrom = null)
        {
            await Task.Run(() => 
            {

                this.Invoke(new Action(() =>
                {

                    if (notification.Type == NotificationType.Submitted && notifFrom != null && !studentsSubmitted.Contains(notifFrom._studentId))
                    {
                        studentsSubmitted.Add(notifFrom._studentId);
                        submissionCount.Text = (submittedCount + 1).ToString();
                        submittedCount++;
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
                int currentActiveCount = int.Parse(activeCount.Text);
                if (notificationType == NotificationType.LoggedIn)
                    currentActiveCount++;
                else
                    currentActiveCount--;
                this.Invoke((Action)(() => activeCount.Text = currentActiveCount.ToString()));
            }
            finally
            {
                _semaphore.Release();
            }
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
