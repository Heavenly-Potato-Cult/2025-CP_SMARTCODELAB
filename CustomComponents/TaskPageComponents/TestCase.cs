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
    public partial class TestCase : UserControl
    {
        public TestCase()
        {
            InitializeComponent();
        }

        public TestCase(string userInput, string expectedOutput)
        {
            InitializeComponent();
            inputs.Text = userInput;
            output.Text = expectedOutput;
        }

        public KeyValuePair<string, string>? getTestCase()
        {
            if(string.IsNullOrWhiteSpace(inputs.Text) || string.IsNullOrWhiteSpace(output.Text))
                return null;
            return new KeyValuePair<string, string>(inputs.Text, output.Text);
        }
    }
}
