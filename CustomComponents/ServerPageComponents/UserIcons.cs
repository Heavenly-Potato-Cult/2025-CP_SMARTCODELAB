using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
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

namespace SmartCodeLab.CustomComponents
{
    public partial class UserIcons : UserControl
    {
        private NetworkStream _stream;
        public UserIcons(UserProfile profile, ServerMemberContainer container, NetworkStream stream, Label userNameLabel, Label ipaddress)
        {
            InitializeComponent();
            username.Text = profile._studentName;
            customCard3.BackColor = Color.White; // Temporary - to see if it exists
            this.Visible = true;
            _stream = stream;
            customCard3.Click += async (s, e) => {
                this.Invoke((Action)(() => { customCard3.BackColor = SystemColors.GradientInactiveCaption;
                    if (userNameLabel == null)
                        return;
                    userNameLabel.Text = profile._studentName;
                    ipaddress.Text = profile._computerAddress;
                }));
                container.ChangeSelected(this);
                _ = FocusStatus(true);
            };
        }
        public void LostFocusDisplay()
        {
            this.Invoke((Action)(() => customCard3.BackColor = Color.White));
            _ = FocusStatus(false);
        }

        private async Task FocusStatus(bool isFocused)
        {
            if (_stream != null)
            {
                Serializer.SerializeWithLengthPrefix<ServerMessage>(_stream, new ServerMessage.Builder(MessageType.IsEyesOnMe).Focused(isFocused).Build(), PrefixStyle.Base128);
                await _stream.FlushAsync();
            }
        }
    }
}
