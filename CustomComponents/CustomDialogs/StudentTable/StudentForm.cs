using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(string studentId, string studentName)
        {
            InitializeComponent();
            studId.Texts = studentId;
            studId.Enabled = false;

            studName.Texts = studentName;
            smartButton2.Text = "Update";
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (string.IsNullOrWhiteSpace(studId.Texts) || string.IsNullOrWhiteSpace(studName.Texts))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            Visible = false;
        }

        public KeyValuePair<string, string> NewUser()
        {
            return new KeyValuePair<string, string>(studId.Texts, studName.Texts);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
