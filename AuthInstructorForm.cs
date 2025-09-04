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
    public partial class AuthInstructorForm : Form
    {
        public AuthInstructorForm()
        {
            InitializeComponent();
        }

        private void btn_InstuctorLogin_Click(object sender, EventArgs e)
        {
            MonitoringForm openForm = new MonitoringForm();
            openForm.Show();

            if (Application.OpenForms["StudentIDEform"] != null)
            {

                Application.OpenForms["StudentIDEform"].Hide();
            }

            this.Close();
        }
    }
}
