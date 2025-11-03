using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    public partial class SessionDisplayHome : UserControl
    {

        private System.Threading.Timer searchTimer;
        private List<Notification> notifications;
        public SessionDisplayHome(Server server,List<Notification> notifications, DateTime endTime, int copyPasteCount)
        {
            InitializeComponent();
            this.notifications = notifications;
            
            submissionCount.Text = $"{server.submittedCount}/{server.Users.Count}";
            duration.Text = $"{server.createdAt.ToString("g")} - {endTime.ToString("h:mm tt")}";
            pastedCount.Text = copyPasteCount.ToString();
            timeLength.Text = (endTime - server.createdAt).ToString(@"hh\:mm\:ss");
            this.Load += (sender, e) =>
            {
                notifContainer.Controls.Clear();

                Task.Run(() =>
                {
                    this.Invoke((Action)(() =>
                    {
                        notifications.ForEach(notif => notifContainer.Controls.Add(new NotificationIcon(notif)));
                    }));
                });
            };
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

        private void studentName__TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);

            searchTimer = new System.Threading.Timer(async _ => await SearchStudent(), null, 500, Timeout.Infinite);
        }
    }
}
