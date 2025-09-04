using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class StudentIDEform : Form
    {
        public StudentIDEform()
        {
            InitializeComponent();
        }

        private void loginAsInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MonitoringForm();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
