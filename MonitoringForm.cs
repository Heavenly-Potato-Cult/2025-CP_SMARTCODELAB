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
    public partial class MonitoringForm : Form
    {
        public MonitoringForm()
        {
            InitializeComponent();
        }

        private void MonitoringForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            student_Panel.Visible = true;

            instructions_Panel.Visible = false;
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            student_Panel.Visible = false;

            instructions_Panel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            instructions_Panel.Visible = true;
            student_Panel.Visible = false;

        }

        private void customCard1_Load(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
