using SmartCodeLab.CustomComponents.TaskPageComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class TaskTabPage : UserControl
    {
        public TaskTabPage()
        {
            InitializeComponent();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            testContainer.Controls.Add(new TestCase());
        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            associateContainer.addFile("testing");
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            externalResourceCon.addFile("example");
        }
    }
}
