using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class ConsoleTextBox : FastColoredTextBox
    {
        private volatile bool isReadLineMode;
        private volatile bool isUpdating;
        private string inputBuffer = "";
        private readonly object lockObject = new object();

        public ConsoleTextBox()
        {
            // Console-like styling
            BackColor = Color.Black;
            ForeColor = Color.White;
            Font = new Font("Consolas", 10);
            ShowLineNumbers = false;
            WordWrap = true;
            CaretColor = Color.White;
            CaretVisible = true;

            // Handle key events for better console behavior
            KeyDown += ConsoleTextBox_KeyDown;
            KeyPress += ConsoleTextBox_KeyPress;
        }

        private Place StartReadPlace { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsReadLineMode
        {
            get { return isReadLineMode; }
            private set { isReadLineMode = value; }
        }

        /// <summary>
        /// Write text to console without newline
        /// </summary>
        public void Write(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            if (InvokeRequired)
            {
                Invoke(new Action(() => Write(text)));
                return;
            }

            lock (lockObject)
            {
                bool wasInReadMode = IsReadLineMode;
                Place savedStartReadPlace = StartReadPlace;

                // Temporarily disable read mode to write
                IsReadLineMode = false;
                isUpdating = true;

                try
                {
                    AppendText(text);
                    GoEnd();
                    Refresh();
                }
                finally
                {
                    isUpdating = false;

                    // Restore read mode if it was active
                    if (wasInReadMode)
                    {
                        // CRITICAL: Update StartReadPlace to AFTER the text we just wrote
                        // This ensures ReadLine only captures user input, not the output we just wrote
                        StartReadPlace = Range.End;
                        IsReadLineMode = true;
                    }
                }
            }
        }

        /// <summary>
        /// Write line to console (appends newline)
        /// </summary>
        public void WriteLine(string text = "")
        {
            Write(text + Environment.NewLine);
        }

        /// <summary>
        /// Write colored text to console
        /// </summary>
        public void WriteColor(string text, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => WriteColor(text, color)));
                return;
            }

            lock (lockObject)
            {
                IsReadLineMode = false;
                isUpdating = true;
                try
                {
                    var start = Range.End;
                    AppendText(text);
                    var end = Range.End;
                    var range = GetRange(start, end);
                    range.SetStyle(new TextStyle(new SolidBrush(color), null, FontStyle.Regular));
                    GoEnd();
                    Refresh();
                }
                finally
                {
                    isUpdating = false;
                }
            }
        }

        /// <summary>
        /// Read a line from console (blocking)
        /// </summary>
        public string ReadLine()
        {
            if (InvokeRequired)
            {
                return (string)Invoke(new Func<string>(ReadLine));
            }

            lock (lockObject)
            {
                // CRITICAL: Set StartReadPlace to the END of current text
                // This ensures we only capture what the user types, not previous output
                GoEnd();
                StartReadPlace = Range.End;
                inputBuffer = "";
                IsReadLineMode = true;
            }

            try
            {
                // Wait for user to press Enter
                while (IsReadLineMode)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);

                    // Safety check - if control is disposed or not visible, exit
                    if (IsDisposed || !IsHandleCreated)
                    {
                        IsReadLineMode = false;
                        break;
                    }
                }
            }
            finally
            {
                lock (lockObject)
                {
                    IsReadLineMode = false;
                }
                ClearUndo();
            }

            return inputBuffer;
        }

        /// <summary>
        /// Read a line asynchronously (non-blocking)
        /// </summary>
        public async Task<string> ReadLineAsync()
        {
            return await Task.Run(() => ReadLine());
        }

        /// <summary>
        /// Read a single key press
        /// </summary>
        public ConsoleKeyInfo ReadKey(bool intercept = false)
        {
            ConsoleKeyInfo keyInfo = default;
            bool keyPressed = false;

            KeyEventHandler handler = (sender, e) =>
            {
                keyInfo = new ConsoleKeyInfo(
                    (char)e.KeyCode,
                    (ConsoleKey)e.KeyCode,
                    e.Shift,
                    e.Alt,
                    e.Control);
                keyPressed = true;

                if (intercept)
                    e.Handled = true;
            };

            KeyDown += handler;

            try
            {
                while (!keyPressed)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);
                }
            }
            finally
            {
                KeyDown -= handler;
            }

            return keyInfo;
        }

        public override void OnTextChanging(ref string text)
        {
            // Don't allow changes when not in read mode and not updating
            if (!IsReadLineMode && !isUpdating)
            {
                text = ""; // Cancel changing
                return;
            }

            if (IsReadLineMode)
            {
                // Ensure cursor is in the editable area
                if (Selection.Start < StartReadPlace || Selection.End < StartReadPlace)
                {
                    GoEnd(); // Move caret to entering position
                    text = ""; // Cancel this change
                    return;
                }

                // Prevent backspace at the start of input
                if ((Selection.Start == StartReadPlace || Selection.End == StartReadPlace) && text == "\b")
                {
                    text = ""; // Cancel deleting
                    return;
                }

                // Handle Enter key - this is what triggers the end of ReadLine
                if (text != null && text.Contains('\n'))
                {
                    // Extract just up to the newline
                    int newlineIndex = text.IndexOf('\n');

                    // Get the complete input text including what was just typed
                    var inputRange = new FastColoredTextBoxNS.Range(this, StartReadPlace, Range.End);
                    string currentInput = inputRange.Text;

                    // Add the text before newline to current input
                    if (newlineIndex > 0)
                    {
                        currentInput += text.Substring(0, newlineIndex);
                    }

                    // Store the complete input
                    lock (lockObject)
                    {
                        inputBuffer = currentInput.TrimEnd('\r', '\n');
                        IsReadLineMode = false;  // Signal ReadLine to return
                    }

                    // Allow the newline to be added
                    text = text.Substring(0, newlineIndex + 1);
                }
            }

            base.OnTextChanging(ref text);
        }

        private void ConsoleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsReadLineMode) return;

            // Prevent navigation keys from going before StartReadPlace
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Back)
            {
                if (Selection.Start <= StartReadPlace)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }

            // Handle Home key to go to start of input line
            if (e.KeyCode == Keys.Home)
            {
                Selection.Start = StartReadPlace;
                e.Handled = true;
            }
        }

        private void ConsoleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsReadLineMode && !isUpdating)
            {
                e.Handled = true; // Block all input when not in read mode
            }
        }

        public override void Clear()
        {
            lock (lockObject)
            {
                var oldIsReadMode = isReadLineMode;
                isReadLineMode = false;
                isUpdating = true;

                base.Clear();

                isUpdating = false;
                isReadLineMode = oldIsReadMode;
                StartReadPlace = Place.Empty;
                inputBuffer = "";
            }
        }

        /// <summary>
        /// Clear the console
        /// </summary>
        public void ClearConsole()
        {
            Clear();
        }

        /// <summary>
        /// Set console text color
        /// </summary>
        public void SetForeColor(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetForeColor(color)));
                return;
            }

            ForeColor = color;
        }

        /// <summary>
        /// Set console background color
        /// </summary>
        public void SetBackColor(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetBackColor(color)));
                return;
            }

            BackColor = color;
        }

        /// <summary>
        /// Simulate Console.ReadLine with prompt
        /// </summary>
        public string Prompt(string promptText)
        {
            Write(promptText);
            return ReadLine();
        }

        /// <summary>
        /// Write error message in red
        /// </summary>
        public void WriteError(string message)
        {
            WriteColor(message + Environment.NewLine, Color.Red);
        }

        /// <summary>
        /// Write success message in green
        /// </summary>
        public void WriteSuccess(string message)
        {
            WriteColor(message + Environment.NewLine, Color.LimeGreen);
        }

        /// <summary>
        /// Write warning message in yellow
        /// </summary>
        public void WriteWarning(string message)
        {
            WriteColor(message + Environment.NewLine, Color.Yellow);
        }

        /// <summary>
        /// Write info message in cyan
        /// </summary>
        public void WriteInfo(string message)
        {
            WriteColor(message + Environment.NewLine, Color.Cyan);
        }
    }
}