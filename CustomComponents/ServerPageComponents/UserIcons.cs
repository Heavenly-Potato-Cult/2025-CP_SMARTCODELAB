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
        private NetworkStream stream;

        public UserIcons()
        {
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserProfile profile {  get; set; }
        public UserIcons(UserProfile profile, Action<UserProfile, UserIcons> setSelectedUserId)
        {
            InitializeComponent();
            this.profile = profile;
            username.Text = profile._studentName;
            customCard3.BackColor = Color.White;
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
    }
}
