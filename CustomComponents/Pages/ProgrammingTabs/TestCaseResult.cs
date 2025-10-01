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
    public partial class TestCaseResult : UserControl
    {
        public TestCaseResult()
        {
            InitializeComponent();
            this.Size = new Size(1030, 31);
        }

        public TestCaseResult(string input, string expOutput, string actOutput)
        {
            InitializeComponent();
            this.Size = new Size(1030, 31);
            this.inputs.Text = input;
            this.expectedOutput.Text = expOutput;
            this.actualOutput.Text = actOutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Size.Height > 31) 
            {
                this.Size = new Size(1030, 31);
                button1.Text = "Open";
            }
            else
            {
                this.Size = new Size(1030, 241);
                button1.Text = "Close";
            }
        }
    }
}
