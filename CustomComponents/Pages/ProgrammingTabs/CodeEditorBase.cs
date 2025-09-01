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
        public CodeEditorBase(string filePath)
        {
            InitializeComponent();
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
        public void CompileCode() { }

        public virtual void RunCode() {
            MessageBox.Show("Run code");
        }

        private void srcCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control) 
            {
                File.WriteAllText(filePath, srcCode.Text);
                MessageBox.Show("File saved");
            }
        }
    }
}
