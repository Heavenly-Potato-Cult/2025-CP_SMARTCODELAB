using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class AddNewExercise : Form
    {
        public TaskModel NewExercise { get; private set; }
        private bool isEditMode;
        private string folderPath;
        private string duplicateMsg = "An exercise with the same title already exists. Please choose a different title.";
        private readonly Regex InvalidCharsRegex = new Regex(
            @"[<>:""/\\|?*\x00-\x1F]",
            RegexOptions.Compiled
        );
        public AddNewExercise()
        {
            InitializeComponent();
            folderPath = SystemConfigurations.TASK_FOLDER;
            isEditMode = false;
            Dictionary<string, string> testCases = new Dictionary<string, string>();
        }

        public AddNewExercise(TaskModel task)
        {
            InitializeComponent();
            isEditMode = true;
            NewExercise = task;
            folderPath = SystemConfigurations.TASK_FOLDER;
            txtbox_ExerciseTitle.Texts = task._taskName;
            txtbox_ExerciseInstruction.Texts = task._instructions;
            subject.Texts = task.subject;
            btn_CancelExercise.Text = "Discard Changes";
            btn_CreateExercise.Text = "Save Changes";

            Load += (sender, e) => SetTestCases(task._testCases ?? new Dictionary<string, string>());
        }

        private void AddNewExercise_Load(object sender, EventArgs e)
        {
            panel_temp_spacer.BackColor = Color.Transparent;
        }

        private void btn_CreateExercise_Click(object sender, EventArgs e)
        {
            if (InputsAreInvalid())
                return;

            if (InvalidCharsRegex.IsMatch(txtbox_ExerciseTitle.Texts))
            {
                MessageBox.Show("The exercise title contains invalid characters. Please avoid using the following characters: < > : \" / \\ | ? *", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(SystemConfigurations.TASK_FOLDER, txtbox_ExerciseTitle.Texts.Trim() + ".task");
            if (isEditMode)
            {
                if (Directory.GetFiles(folderPath).Contains(filePath) && NewExercise.filePath != filePath)
                {
                    MessageBox.Show(duplicateMsg, "Duplicate Exercise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    File.Delete(NewExercise.filePath);
                }
            }

            NewExercise = new TaskModel(txtbox_ExerciseTitle.Texts, subject.Texts, txtbox_ExerciseInstruction.Texts, GetTestCases());
            if (Directory.GetFiles(folderPath).Contains(filePath))
            {
                MessageBox.Show(duplicateMsg, "Duplicate Exercise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var createdFile = File.Create(filePath))
            {
                NewExercise.filePath = filePath;
                Serializer.SerializeWithLengthPrefix<TaskModel>(createdFile, NewExercise, PrefixStyle.Base128);
                createdFile.Close();
            }
            ConfirmAndCloseForm();
        }

        private bool InputsAreInvalid()
        {
            if (string.IsNullOrWhiteSpace(txtbox_ExerciseTitle.Texts))
            {
                MessageBox.Show("Title cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }


            if (string.IsNullOrWhiteSpace(subject.Texts))
            {
                MessageBox.Show("Please provide the exercise subject.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void ConfirmAndCloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_CancelExercise_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddTestCase_Click(object sender, EventArgs e)
        {
            testCasesContainer.Controls.Add(new TestCase());
        }

        private Dictionary<string, string> GetTestCases()
        {
            var testCases = new Dictionary<string, string>();
            foreach (TestCase testCaseControl in testCasesContainer.Controls.OfType<TestCase>())
            {
                try
                {
                    var testCase = testCaseControl.GetTestCase();
                    testCases.Add(testCase.Key, testCase.Value);
                }
                catch (ArgumentException) { }
            }
            return testCases;
        }

        private void SetTestCases(Dictionary<string, string> testCases)
        {
            Task.Run(() =>
            {
                foreach (var testCase in testCases)
                {
                    this.Invoke(new Action(() =>
                    {
                        testCasesContainer.Controls.Add(new TestCase(testCase));
                    }));
                }
            });
        }
    }
}
