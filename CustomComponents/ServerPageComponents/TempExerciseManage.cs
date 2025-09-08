using SmartCodeLab.CustomComponents.CustomDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempExerciseManage : UserControl
    {
        private string btnStatus = "Edit";
        public TempExerciseManage()
        {
            InitializeComponent();
        }

        private void TempExerciseManage_Load(object sender, EventArgs e)
        {

        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            AddNewExercise addNewExercise = new AddNewExercise();
            addNewExercise.ShowDialog();
        }

        private void smartButton5_Click(object sender, EventArgs e)
        {
            AddNewTestCase addNewTestCase = new AddNewTestCase();
            addNewTestCase.ShowDialog();
        }

        private void btn_UploadFileReference_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
        }

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            if(btnStatus == "Edit")
            {
                txtbox_ExerciseName.Enabled = true;
                txtbox_ExerciseSubject.Enabled = true;
                txtbox_ExercisePoints.Enabled = true;
                txtbox_ExerciseInstruction.Enabled = true;
                btn_EditExerciseDetails.Text = "Save";
                btnStatus = "Save";

                return;
            }

            if (btnStatus == "Save")
            {
                txtbox_ExerciseName.Enabled = false;
                txtbox_ExerciseSubject.Enabled = false;
                txtbox_ExercisePoints.Enabled = false;
                txtbox_ExerciseInstruction.Enabled = false;
                btn_EditExerciseDetails.Text = "Edit";
                btnStatus = "Edit";

                return;
            }
        }
    }
}
