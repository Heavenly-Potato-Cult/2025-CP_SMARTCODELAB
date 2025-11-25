using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartCodeLab.CustomComponents
{
    public partial class UserIcons : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserProfile profile {  get; set; }

        public bool isActive { get; private set; }
        public UserIcons(UserProfile profile, Action<UserProfile, UserIcons> setSelectedUserId)
        {
            InitializeComponent();
            this.profile = profile;
            username.Text = profile._studentName;
            customCard3.BackColor = Color.White;
            status.Text = "Inactive";
            status.ForeColor = Color.Gray;
            isActive = false;
            customCard3.Click += (s, e) => {
                if (customCard3.BackColor == Color.White)
                {
                    //_ = FocusStatus(true);
                    setSelectedUserId?.Invoke(this.profile, this);
                    customCard3.BackColor = Color.Bisque;
                }
            };
        }

        public void LostFocusDisplay()
        {
            this.Invoke((Action)(() => customCard3.BackColor = Color.White));
        }

        public void setNameText(string newName)
        {
            this.Invoke((Action)(() => username.Text = newName));
        }
        public void setStatus(bool isActive)
        {
            this.isActive = isActive;
            this.Invoke((Action)(() =>
            {
                if (isActive)
                {
                    status.ForeColor = Color.LimeGreen;
                    status.Text = "Active";
                }
                else
                {
                    status.ForeColor = Color.Gray;
                    status.Text = "Inactive";
                }
            }));
        }
    }
}
