using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class CodeEditorBase : UserControl
    {
        protected string filePath;
        protected TaskModel _task;
        private readonly WavyLineStyle redWavy = new WavyLineStyle(255, Color.Red);
        private System.Threading.Timer _debounceTimer;
        public StudentCodingProgress StudentProgress {get;}
        public CodeEditorBase(string filePath, TaskModel task)
        {
            InitializeComponent();
            _task = task;
            StudentProgress = new StudentCodingProgress();
            this.filePath = filePath;
            srcCode.Text = File.ReadAllText(filePath);
            srcCode.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.S && e.Control)
                    SaveCode(srcCode.Text);
                else if(e.KeyCode == Keys.F5)
                    RunCode();
                else if(e.KeyCode == Keys.OemSemicolon || e.KeyCode == Keys.Enter)
                {
                    _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                    // Start a new timer
                    _debounceTimer = new System.Threading.Timer(_ =>
                    {
                        RunLinting();
                    }, null, 0, Timeout.Infinite);
                }
                else
                {
                    _debounceTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                    // Start a new timer
                    _debounceTimer = new System.Threading.Timer(_ =>
                    {
                        RunLinting();
                    }, null, 300, Timeout.Infinite);
                }
            };
        }

        public void SaveCode(string sourceCode, int maxRetries = 5, int retryDelayMs = 100)
        {
            int attempts = 0;

            while (attempts < maxRetries)
            {
                try
                {
                    File.WriteAllText(filePath, sourceCode);
                    return; // Success - exit method
                }
                catch (IOException ex) when (IsFileLocked(ex))
                {
                    attempts++;
                    if (attempts >= maxRetries)
                    {
                        throw new IOException($"Failed to save file after {maxRetries} attempts. File is still in use.", ex);
                    }

                    Thread.Sleep(retryDelayMs);
                    retryDelayMs *= 2; // Exponential backoff
                }
                catch (Exception ex)
                {
                    throw new IOException($"Error saving file: {ex.Message}", ex);
                }
            }
        }

        private bool IsFileLocked(Exception exception)
        {
            int hr = Marshal.GetHRForException(exception) & ((1 << 16) - 1);
            return exception is IOException &&
                   (hr == 32 || hr == 33); // ERROR_SHARING_VIOLATION or ERROR_LOCK_VIOLATION
        }
        public virtual void CompileCode() { }

        public virtual void RunCode() {
            MessageBox.Show("Run code");
        }

        public virtual void RunTest()
        {}

        public virtual void RunLinting() { }

        protected void HighlightError(int errorLine)
        {
            this.Invoke((Action)(() =>
            {
                var lineRange = srcCode.GetLine(errorLine);
                lineRange.SetStyle(redWavy);
            }));
        }

        protected void NoError()
        {
            srcCode.Range.ClearStyle(StyleIndex.All);
        }

        public StudentCodingProgress GetProgress()
        {
            return new StudentCodingProgress(srcCode.Text);
        }

        private void srcCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control) 
            {
                File.WriteAllText(filePath, srcCode.Text);
                MessageBox.Show("File saved");
            }
            else
            {
                StudentProgress.sourceCode = srcCode.Text;
                StudentProgress.CodeProgress.Add(srcCode.Text);
            }
        }
    }
}
