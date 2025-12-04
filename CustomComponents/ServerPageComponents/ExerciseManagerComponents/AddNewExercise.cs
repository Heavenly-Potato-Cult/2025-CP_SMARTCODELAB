using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.CustomComponents.TaskPageComponents;
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
using System.Windows.Controls;
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
        private List<string> autoCompleteList;
        public AddNewExercise(List<string> existingSubjects)
        {
            InitializeComponent();
            folderPath = SystemConfigurations.TASK_FOLDER;
            isEditMode = false;
            Dictionary<string, string> testCases = new Dictionary<string, string>();
            autoCompleteList = existingSubjects;
            setExistingSubjects();
        }

        public AddNewExercise(TaskModel task, List<string> existingSubjects)
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
            autoCompleteList = existingSubjects;
            setExistingSubjects();
            Load += (sender, e) => SetTestCases(task._testCases ?? new Dictionary<string, string>());
        }

        private void setExistingSubjects()
        {
            // Set up TextBox autocomplete
            subject.textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            subject.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Create AutoCompleteStringCollection and add your list
            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(autoCompleteList.ToArray());
            subject.textBox1.AutoCompleteCustomSource = autoCompleteSource;
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
            //add the subject if it do not exist
            bool doNotHave = true;
            foreach (var item in autoCompleteList)
            {
                if (item.Equals(subject.Texts, StringComparison.OrdinalIgnoreCase))
                {
                    doNotHave = false;
                    break;
                }
            }
            if (doNotHave)
            {
                File.AppendAllLines(SystemConfigurations.SUBJECTS_FILE, new[] { subject.Texts });
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


        private Dictionary<string, string> GetTestCases()
        {
            var testCases = new Dictionary<string, string>();
            var panels = testCasesContainer.Controls.OfType<ExpansionPanel>();
            foreach (var panel in panels)
            {
                var testCaseControl = panel.Controls.OfType<TestCase2>().FirstOrDefault();
                if (testCaseControl == null)
                {
                    continue;
                }

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
            // Convert to a list so we can loop backward
            var testCaseList = testCases.ToList();


            for (int i = testCaseList.Count - 1; i >= 0; i--)
            {
                var testCase = testCaseList[i];
                var testCaseNumber = i + 1;

                var testcaseholder = new ExpansionPanel();


                var testcasecontent = new TestCase2(testCase);

                testcasecontent.RemoveRequested += (s, ev) =>
                {
                    testcaseholder.Dispose();
                };

                testcaseholder.Title1 = "test case";
                testcaseholder.Title2 = testCaseNumber.ToString();
                testcaseholder.HeaderColor = Color.FromArgb(230, 240, 255);
                testcaseholder.HeaderHeight = 20;

                testcasecontent.AutoSize = false;
                testcasecontent.Dock = DockStyle.Fill;
                testcasecontent.Padding = new Padding(20, 25, 20, 0);
                testcaseholder.Controls.Add(testcasecontent);

                testcaseholder.Dock = DockStyle.Top;
                testCasesContainer.Controls.Add(testcaseholder);
            }
        }

        private void btn_AddTestCase_Click_1(object sender, EventArgs e)
        {
            var testcaseholder = new ExpansionPanel();
            var testcasecontent = new TestCase2();
            testcasecontent.RemoveRequested += (s, ev) =>
            {
                testcaseholder.Dispose();
            };

            testcaseholder.Title1 = "test case";
            testcaseholder.Title2 = "";
            testcaseholder.HeaderColor = Color.FromArgb(230, 240, 255);
            //testcaseholder.BackColor = Color.Gray;
            testcaseholder.HeaderHeight = 40;
            testcasecontent.AutoSize = false;

            testcasecontent.Dock = DockStyle.Fill;
            testcasecontent.Padding = new Padding(20, 45, 20, 0);
            testcaseholder.Controls.Add(testcasecontent);

            testcaseholder.Dock = DockStyle.Top;
            testCasesContainer.Controls.Add(testcaseholder);
        }
    }
}
