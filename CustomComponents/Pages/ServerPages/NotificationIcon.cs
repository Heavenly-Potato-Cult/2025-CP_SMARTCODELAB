using SmartCodeLab.CustomComponents.GeneralComponents;
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
    public partial class NotificationIcon : RoundedUserControl
    {
        public NotificationIcon(Notification notification)
        {
            InitializeComponent();
            userName.Text = notification.UserName;
            message.Text = notification.Message;
            time.Text = notification.timeOccurred.ToString("h:mm tt");

            switch (notification.Type)
            {
                case NotificationType.CopyPasted:
                    BackColor = Color.FromArgb(230, 250, 250); // soft cyan
                    break;
                case NotificationType.Submitted:
                    BackColor = Color.FromArgb(235, 255, 235); // light mint green
                    break;
                case NotificationType.TestResult:
                    BackColor = Color.FromArgb(255, 250, 225); // pale yellow
                    break;
                case NotificationType.LoggedIn:
                    BackColor = Color.FromArgb(230, 245, 255); // sky blue
                    break;
                case NotificationType.LoggedOut:
                    BackColor = Color.FromArgb(250, 235, 235); // soft pink
                    break;
                case NotificationType.ExceptionThrown:
                    BackColor = Color.FromArgb(255, 235, 230); // light coral
                    break;
                default:
                    BackColor = SystemColors.ControlLightLight;
                    break;
            }
        }
    }
}
