using Microsoft.VisualBasic;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempExerciseManage : UserControl
    {
        private string btnStatus = "Edit";
        private string folderPath = "";

        private TaskModel selectedTaskModel;

        private readonly Dictionary<string, string> languageExtension = new Dictionary<string, string>()
        {
            {"Cpp","Cpp file(.cpp)|*.cpp" },
            {"Java",".Java file(.java)|*.java" },
            {"Python","Python file(.py)|*.py" }
        };
        public TempExerciseManage()
        {
            InitializeComponent();
            folderPath = SystemConfigurations.TASK_FOLDER;
            fileView.Nodes.Add(new TreeNodeObj(folderPath, null, FillFields));
        }

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            SaveEditBtn(btnStatus == "Edit");
        }

        private void SaveEditBtn(bool isEditing)
        {
            exerciseName.Enabled = isEditing;
            subject.Enabled = isEditing;
            instruction.Enabled = isEditing;
            btn_EditExerciseDetails.Text = isEditing ? "Save" : "Edit";
            reference.ReadOnly = !isEditing;
            btnStatus = isEditing ? "Save" : "Edit";
            if (!isEditing)
            {
                SaveTask();
            }
        }

        private void SaveTask()
        {
            TaskModel task = selectedTaskModel;
            task._taskName = exerciseName.Texts;
            task.subject = subject.Texts;
            task._instructions = instruction.Texts;
            task._referenceFile = reference.Text;
            task._testCases = TestCases();
            JsonFileService.SaveToFile<TaskModel>(task, task.filePath);
            MessageBox.Show("Task Saved Successfully");
        }

        private void FillFields(TaskModel task)
        {
            selectedTaskModel = task;
            this.Invoke((Action)(() =>
            {
                exerciseName.Texts = task._taskName;
                subject.Texts = task.subject;
                instruction.Texts = task._instructions;
                reference.Text = task._referenceFile?.ToString() ?? "";
                SetTestCases(task._testCases);
            }));
        }

        private void smartButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
                reference.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btn_AddTestCase_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => testContainer.Controls.Add(new TestCase())));
        }

        private Dictionary<string, string> TestCases()
        {
            Dictionary<string, string> ActivityTestCases = new Dictionary<string, string>();

            foreach (TestCase testCase in testContainer.Controls.OfType<TestCase>())
            {
                try
                {
                    KeyValuePair<string, string> value = testCase.Value();
                    ActivityTestCases.Add(value.Key, value.Value);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Similar Input Already Exists");
                }
            }
            return ActivityTestCases;
        }

        private void SetTestCases(Dictionary<string, string> TestCases)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    testContainer.Controls.Clear();

                    if (TestCases == null || TestCases.Count == 0)
                        return;

                    foreach (var kv in TestCases)
                        testContainer.Controls.Add(new TestCase(kv));
                }));
            });
        }

        private void fileView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ((TreeNodeObj)e.Node).SimulateClicked(e);
        }
    }
}
