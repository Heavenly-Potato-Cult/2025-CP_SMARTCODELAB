using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class TestCase3 : UserControl
    {
        public TestCase3()
        {
            InitializeComponent();
        }

        public event EventHandler RemoveRequested;

        public TestCase3(KeyValuePair<string, string> testCase)
        {
            InitializeComponent();
            codeEditor1.Text = testCase.Key;
            codeEditor2.Text = testCase.Value;
        }

        public KeyValuePair<string, string> GetTestCase()
        {
            return new KeyValuePair<string, string>(codeEditor1.Text, codeEditor2.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RemoveRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
