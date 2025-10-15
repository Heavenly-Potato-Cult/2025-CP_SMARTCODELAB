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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerHomePage : UserControl
    {
        private readonly SemaphoreSlim _semaphore = new(1, 1);
        public ServerHomePage()
        {
            InitializeComponent();
            Object h = this.Handle;
        }

        public void NewNotification(Notification notification)
        {
            Task.Run(() => 
            {
                this.Invoke(new Action(() =>
                {

                    var notifCard = new NotificationIcon(notification);


                    switch (notification.Type)
                    {
                        case NotificationType.CopyPasted:
                            notifCard.BackColor = Color.FromArgb(230, 250, 250); // soft cyan
                            break;
                        case NotificationType.Submitted:
                            notifCard.BackColor = Color.FromArgb(235, 255, 235); // light mint green
                            break;
                        case NotificationType.TestResult:
                            notifCard.BackColor = Color.FromArgb(255, 250, 225); // pale yellow
                            break;
                        case NotificationType.LoggedIn:
                            notifCard.BackColor = Color.FromArgb(230, 245, 255); // sky blue
                            break;
                        case NotificationType.LoggedOut:
                            notifCard.BackColor = Color.FromArgb(250, 235, 235); // soft pink
                            break;
                        case NotificationType.ExceptionThrown:
                            notifCard.BackColor = Color.FromArgb(255, 235, 230); // light coral
                            break;
                        default:
                            notifCard.BackColor = SystemColors.ControlLightLight;
                            break;
                    }

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
    }
}
