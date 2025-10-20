using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class AddNewExercise : Form
    {
        public AddNewExercise()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_CancelAddExercise_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConfirmAddExercise_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewExercise_Load(object sender, EventArgs e)
        {
            panel_temp_spacer.BackColor = Color.Transparent;
        }
    }
}
