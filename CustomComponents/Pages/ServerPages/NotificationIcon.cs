using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
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
        public NotificationIcon()
        {
            InitializeComponent();
        }

        public NotificationIcon(Notification notification)
        {
            InitializeComponent();
            userName.Text = notification.UserName;
            message.Text = notification.Message;
        }
    }
}
