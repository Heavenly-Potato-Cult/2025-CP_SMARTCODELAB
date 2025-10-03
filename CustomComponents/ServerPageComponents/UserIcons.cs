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
        public UserIcons(UserProfile profile, Action<UserProfile> setSelectedUserId)
        {
            InitializeComponent();
            this.profile = profile;
            username.Text = profile._studentName;
            customCard3.BackColor = Color.White;
            customCard3.Click += (s, e) => {
                if (customCard3.BackColor == Color.White)
                {
                    _ = FocusStatus(true);
                    setSelectedUserId?.Invoke(this.profile);
                    customCard3.BackColor = Color.Bisque;
                }
            };
        }

        public UserIcons(UserProfile profile, ServerMemberContainer container, NetworkStream stream, Action<string,string> action)
        {
            InitializeComponent();
            username.Text = profile._studentName;
            customCard3.BackColor = Color.White;
            this.Visible = true;
            this.stream = stream;
            customCard3.Click += (s, e) => {
                if (customCard3.BackColor == Color.White)
                {
                    container.ChangeSelected(this);
                    _ = FocusStatus(true);
                    action?.Invoke(profile._studentName, profile._computerAddress);
                    customCard3.BackColor = Color.Bisque;
                }
            };
        }

        public void LostFocusDisplay()
        {
            this.Invoke((Action)(() => customCard3.BackColor = Color.White));
            _ = FocusStatus(false);
        }

        private async Task FocusStatus(bool isFocused)
        {
            if (stream != null)
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(stream, new ServerMessage.Builder(MessageType.IsEyesOnMe).Focused(isFocused).Build(), PrefixStyle.Base128);
                await stream.FlushAsync();
            }
        }
    }
}
