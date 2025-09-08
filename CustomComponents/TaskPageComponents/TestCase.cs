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

        public TestCase(KeyValuePair<string,string> test)
        {
            InitializeComponent();
            input.Text = test.Key;
            output.Text = test.Value;
        }

        public KeyValuePair<string, string> Value()
        {
            return new KeyValuePair<string, string>(input.Text, output.Text);
        }
    }
}
