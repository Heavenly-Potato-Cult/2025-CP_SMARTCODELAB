using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    public partial class TestCaseView : UserControl
    {
        public TestCaseView()
        {
            InitializeComponent();
        }

        public TestCaseView(int num,string userInput, string expectedOutput)
        {
            InitializeComponent();
            number.Text = num.ToString();
            input.Text = userInput;
            output.Text = expectedOutput;
        }
    }
}
