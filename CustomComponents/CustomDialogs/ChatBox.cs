using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCodeLab.CustomComponents.SteamThings;
using System.Diagnostics;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ChatBox : Form
    {
        public string studentId { get; private set; }

        public ChatBox(Func<string, string, Task<bool>> sendMessage, List<UserMessage>? messages, bool isActive, string studentName, string studentId)
        {
            InitializeComponent();

            this.studentId = studentId;
            this.studentName.Text = studentName;

            if (messages != null)
            {
                foreach (var msg in messages)
                {
                    // Do not override senderName; alignment is driven by isFromMe/IsBroadcast
                    msg.isFromMe = msg.senderName.Equals("Me", StringComparison.OrdinalIgnoreCase);
                    steamChatBox1.Items.Add(msg);
                }
                if (steamChatBox1.Items.Count > 0)
                    steamChatBox1.TopIndex = steamChatBox1.Items.Count - 1;
            }
            richTextBox2.Enabled = isActive;
            if(!isActive)
            {
                richTextBox2.Text = "Chat disabled for inactive students.";
            }
            richTextBox2.KeyUp += async (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && sendMessage != null)
                {
                    string msg = richTextBox2.Text;
                    if (string.IsNullOrWhiteSpace(msg)) return;

                    // Outgoing (me) -> right
                    var userMsg = new UserMessage(msg)
                    {
                        isFromMe = true,
                        senderName = "Me",
                        IsBroadcast = false
                    };

                    bool success = await sendMessage(studentId, msg);

                    if (success)
                    {
                        this.Invoke((Action)(() =>
                        {
                            steamChatBox1.Items.Add(userMsg);
                            steamChatBox1.TopIndex = steamChatBox1.Items.Count - 1;
                        }));
                    }

                    richTextBox2.Clear();
                    e.Handled = true;
                }
            };
        }

        public void receivedMessage(string message)
        {
            this.Invoke(new Action(() =>
            {
                // Incoming (student) -> left
                var incomingMsg = new UserMessage(message)
                {
                    isFromMe = false,
                    senderName = studentName.Text,
                    IsBroadcast = false
                };

                steamChatBox1.Items.Add(incomingMsg);
                steamChatBox1.TopIndex = steamChatBox1.Items.Count - 1;
            }));
        }
    }
}
