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
                PopulateLogBox(this.notifications);
            };
        }
        private void PopulateLogBox(List<Notification> itemsToShow)
        {
            logBox.BeginUpdate();
            logBox.Items.Clear();
            // We assume the list might be chronological, so we reverse it or OrderByDescending
            var sorted = itemsToShow.OrderByDescending(n => n.timeOccurred).ToList();

            foreach (var notif in sorted)
            {
                logBox.Items.Add(notif);
            }

            logBox.EndUpdate();
        }


        private Task SearchStudent()
        {
            long currentSearchVersion = ++searchVersion;
            string searchedName = studentName.Text.Trim();
            this.Invoke((Action)(() =>
            {
                logBox.BeginUpdate();
                logBox.Items.Clear();
                string notifFilterString = notifFilter.SelectedItem?.ToString() ?? "All";
                bool isForAll = notifFilterString.Equals("All", StringComparison.OrdinalIgnoreCase);

               
                var filtered = notifications
                    .Where(notif =>
                        notif.UserName.Contains(searchedName, StringComparison.OrdinalIgnoreCase) &&
                        (isForAll || NotificationTypeExtensions.ToFriendlyString(notif.Type).Equals(notifFilterString, StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                
                for (int i = filtered.Count - 1; i >= 0; i--)
                {
                    if (currentSearchVersion != searchVersion) break; 

                    logBox.Items.Add(filtered[i]);
                }

                
                logBox.EndUpdate();
                logBox.Invalidate();
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
