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

        public string Title { get; private set; }
        public string ProgrammingLanguage { get; private set; }
        public string Course { get; private set; }
        public string YearAndSection { get; private set; }

        public AddNewExercise()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewExercise_Load(object sender, EventArgs e)
        {
            panel_temp_spacer.BackColor = Color.Transparent;
        }

        private void btn_CreateExercise_Click(object sender, EventArgs e)
        {
            if (InputsAreInvalid())
            {
                return;
            }

            
            AssignDataToPublicProperties();
            ConfirmAndCloseForm();
        }

        private bool InputsAreInvalid()
        {
            bool titleIsEmpty = string.IsNullOrWhiteSpace(txtbox_ExerciseTitle.Texts);
            bool languageIsUnselected = (cbox_ExerciseProgrammingLanguage.SelectedItem == null);
            bool courseIsUnselected = (cbox_ExerciseCourse.SelectedItem == null);
            bool yearandsectionIsUnselected = (cbox_ExerciseYearAndSection.SelectedItem == null);
            
            if (titleIsEmpty)
            {
                MessageBox.Show("Title cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; 
            }

            
            if (languageIsUnselected)
            {
                MessageBox.Show("Please select a programming language.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; 
            }

            
            if (courseIsUnselected)
            {
                MessageBox.Show("Please select a course.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            
            if (yearandsectionIsUnselected)
            {
                MessageBox.Show("Please select year and section.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; 
            }

            // --- All checks passed ---
            return false; 
        }

        private void AssignDataToPublicProperties()
        {
            
            this.Title = txtbox_ExerciseTitle.Texts;
            this.ProgrammingLanguage = cbox_ExerciseProgrammingLanguage.SelectedItem.ToString();
            this.Course = cbox_ExerciseCourse.SelectedItem.ToString();
            this.YearAndSection = cbox_ExerciseYearAndSection.SelectedItem.ToString();

        }

        private void ConfirmAndCloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
