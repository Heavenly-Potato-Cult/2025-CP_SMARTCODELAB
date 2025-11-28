using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
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
        private long searchVersion = 0;
        public SessionDisplayHome(Server server, List<Notification> notifications, DateTime endTime, int copyPasteCount)
        {
            InitializeComponent();
            searchVersion = 0;
            this.notifications = notifications;
            serverName.Text = server.ServerName;
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
            long currentSearchVersion = ++searchVersion;
            string searchedName = studentName.Text.Trim();
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

            return Task.CompletedTask;
        }

        private void studentName__TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer( _ =>  SearchStudent(), null, 500, Timeout.Infinite);
        }

        private void notifFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer( _ => SearchStudent(), null, 500, Timeout.Infinite);
        }
    }
}
