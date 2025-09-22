using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class ServerMemberContainer : CustomComponents.GeneralComponents.RoundedUserControl
    {
        public UserIcons selected;
        public ServerMemberContainer()
        {
            InitializeComponent();
            var handle = this.Handle;
        }

        public UserIcons AddUser(UserProfile user, NetworkStream stream, Action<string,string> action)
        {
            UserIcons userIcons = new UserIcons(user, this, stream, action);
            this.Invoke((Action)(() => flowLayoutPanel1.Controls.Add(userIcons)));
            return userIcons;
        }

        public void ChangeSelected(UserIcons userIcons)
        {
            if(selected != null)
                selected.LostFocusDisplay();
            selected = userIcons;
        }
    }
}
