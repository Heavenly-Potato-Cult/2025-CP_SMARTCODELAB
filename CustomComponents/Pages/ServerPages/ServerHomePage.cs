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
                    notifContainer.Controls.Add(new NotificationIcon(notification));
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
