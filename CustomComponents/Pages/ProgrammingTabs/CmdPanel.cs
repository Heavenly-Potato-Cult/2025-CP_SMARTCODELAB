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

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class CmdPanel : UserControl
    {
        private Process process;
        private System.Windows.Forms.Timer inputTimer;
        private bool waitingForInput = false;
        private DateTime lastOutputTime;

        public CmdPanel()
        {
            InitializeComponent();

            richTextBox1.Font = new Font("Consolas", 10);
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.KeyDown += richTextBox1_KeyDown; 
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.WordWrap = false;

            inputTimer = new System.Windows.Forms.Timer();
            inputTimer.Interval = 500; // blink every half second
            inputTimer.Tick += InputTimer_Tick;
            inputTimer.Start();
        }

        public void AttachProcess(Process externalProcess)
        {
            richTextBox1.Clear();
            richTextBox1.ReadOnly = false;
            process = externalProcess ?? throw new ArgumentNullException(nameof(externalProcess));

            process.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    AppendText(e.Data + Environment.NewLine);
                    lastOutputTime = DateTime.Now;
                    waitingForInput = false;
                }
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    AppendText("[ERR] " + e.Data + Environment.NewLine);
                    lastOutputTime = DateTime.Now;
                    waitingForInput = false;
                }
            };

            process.Exited += (s, e) =>
            {
                AppendText(Environment.NewLine + "[Process exited]");
                waitingForInput = false;
                richTextBox1.ReadOnly = true;
            };

            lastOutputTime = DateTime.Now;
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // Monitor for idle state (waiting for input)
            _ = MonitorForInputAsync();
        }

        private async Task MonitorForInputAsync()
        {
            while (process != null && !process.HasExited)
            {
                await Task.Delay(500);
                if ((DateTime.Now - lastOutputTime).TotalSeconds > 1.0 && !waitingForInput)
                {
                    waitingForInput = true;
                }
            }
        }

        private void InputTimer_Tick(object sender, EventArgs e)
        {
                if (waitingForInput && process != null && !process.HasExited)
                {
                    if (!richTextBox1.Text.EndsWith("_"))
                        AppendText("_"); // show cursor
                    else
                        RemoveLastChar(); // blink effect
                }
        }
        private void StopBlinkingCursor()
        {
            waitingForInput = false;
            RemoveLastChar(); // remove the '_' if visible
        }
        private void RemoveLastChar()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RemoveLastChar));
                return;
            }

            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd('_');
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendText), text);
                return;
            }
            richTextBox1.AppendText(text);
            richTextBox1.ScrollToCaret();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (waitingForInput)
                StopBlinkingCursor();
            if (e.KeyCode == Keys.Enter && process != null && !process.HasExited)
            {
                string lastLine = GetLastLine();
                AppendText(Environment.NewLine);
                process.StandardInput.WriteLine(lastLine);
                e.SuppressKeyPress = true;
                waitingForInput = false;
            }
        }

        private string GetLastLine()
        {
            string[] lines = richTextBox1.Text.Split('\n');
            return lines[^1].Trim('_', ' ', '\r', '\n');
        }
    }
}
