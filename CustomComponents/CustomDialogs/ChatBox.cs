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

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ChatBox : Form
    {
        public string studentId { get; private set; }
        public ChatBox(Func<string, string, Task<bool>> sendMessage,List<UserMessage>? messages, bool isActive, string studentName, string studentId)
        {
            InitializeComponent();
            richTextBox1.Enabled = isActive;
            this.studentId = studentId;
            this.studentName.Text = studentName;

            richTextBox2.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && sendMessage != null)
                {
                    string msg = richTextBox2.Text;
                    Task.Run(async () => 
                    { 
                         var result = await sendMessage(studentId, msg);
                        if(result)
                            this.Invoke((Action)(() => richTextBox1.AppendText($"Me : {msg}")));
                    });
                    richTextBox2.Clear();
                    e.Handled = true;
                }
            };

            if(messages != null && messages.Count != 0)
            {
                foreach (var message in messages)
                {
                    string from = message.isFromMe ? "Me" : studentName;
                    richTextBox1.AppendText($"{from} : {message.message}");
                }
            }
        }

        public void receivedMessage(string message)
        {
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText($"{studentName.Text} : {message}");
            }));
        }
    }
}
