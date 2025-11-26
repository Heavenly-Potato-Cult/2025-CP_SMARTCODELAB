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
    public partial class TestCaseResult2 : UserControl
    {
        public TestCaseResult2(int number, bool isCorrect, string input, string expOutput, string actOutput)
        {
            this.Size = new Size(1030, 30);
            InitializeComponent();
            this.inputs.Text = input;
            this.expectedOutput.Text = expOutput;
            this.actualOutput.Text = actOutput;
        }
    }
}
