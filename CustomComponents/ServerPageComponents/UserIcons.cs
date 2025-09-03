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
        public UserIcons(string studentName, ServerMemberContainer container, NetworkStream stream)
        {
            InitializeComponent();
            label1.Text = studentName;
            this.Size = new System.Drawing.Size(250, 50);
            this.BackColor = Color.Red; // Temporary - to see if it exists
            this.BorderStyle = BorderStyle.FixedSingle; // Add border
            this.Visible = true;
            _stream = stream;
            this.Click += async (s,e) => {
                this.Invoke((Action)(() => this.BackColor = Color.PowderBlue));
                container.ChangeSelected(this);
                _ = FocusStatus(true);
            };
        }

        public void LostFocusDisplay()
        {
            this.Invoke((Action)(() => this.BackColor = Color.Red));
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
