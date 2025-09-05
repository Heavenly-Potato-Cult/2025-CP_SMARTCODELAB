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

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class CodeEditorBase : UserControl
    {
        protected string filePath;
        protected TaskModel _task;
        public StudentCodingProgress StudentProgress { get; }
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
                else if(e.KeyCode == Keys.R && e.Control)
                    RunCode();
            };
        }

        public void SaveCode(string sourceCode)
        {
            File.WriteAllText(filePath, sourceCode);
        }
        public virtual void CompileCode() { }

        public virtual void RunCode() {
            MessageBox.Show("Run code");
        }

        public virtual void RunTest()
        {

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
