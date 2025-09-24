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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerHomePage : UserControl
    {
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
    }
}
