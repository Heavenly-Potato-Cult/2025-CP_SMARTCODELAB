using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class TaskTabPage : UserControl
    {
        private string? _filePath;
        public TaskTabPage(string _filePath)
        {
            InitializeComponent();
            initialize_Save_Shortcut(this);
            this._filePath = _filePath;
            TaskModel taskModel = JsonFileService.LoadFromFile<TaskModel>(_filePath);

            if (taskModel != null)
            {
                actName.Texts = taskModel._taskName;
                txtbox_instruction.Text = taskModel._instructions;
                languageUsed.SelectedItem = taskModel.language;
                KeyValuePair<string, string>? referenceFile = taskModel._referenceFile;
                if (referenceFile.HasValue)
                    associateContainer.addFile(referenceFile.Value.Key, referenceFile.Value.Value);

                if (taskModel._externalResources != null && taskModel._externalResources.Count > 0)
                {
                    foreach (var resource in taskModel._externalResources)
                    {
                        externalResourceCon.addFile(resource.Key, resource.Value);
                    }
                }

                if (taskModel._testCases != null && taskModel._testCases.Count > 0)
                {
                    foreach (var testCase in taskModel._testCases)
                    {
                        var test = new TestCase(testCase.Key, testCase.Value);
                        initialize_Save_Shortcut(test);
                        testContainer.Controls.Add(test);
                    }
                }
            }
        }

        private void initialize_Save_Shortcut(UserControl container)
        {
            foreach (Control control in container.Controls)
            {
                control.KeyUp += (sender, k) =>
                {
                    if (k.KeyCode == Keys.S && k.Control)
                    {
                        save_File();
                    }
                };
            }
        }

        private Dictionary<string, string> getTestCases()
        {
            Dictionary<string, string> testCases = new Dictionary<string, string>();
            foreach (TestCase testCase in testContainer.Controls)
            {
                KeyValuePair<string, string>? test = testCase.getTestCase();
                if (test != null)
                {
                    try
                    {
                        testCases.Add(test.Value.Key, test.Value.Value);
                    }
                    catch (ArgumentException)
                    {
                        // Key already exists.. then do nothing
                    }
                }
            }
            return testCases;
        }

        private void save_File()
        {
            var taskModel = new TaskModel();
            taskModel._taskName = actName.Texts;
            taskModel._instructions = txtbox_instruction.Text;
            taskModel.language = languageUsed.SelectedItem?.ToString() ?? null;
            taskModel._referenceFile = associateContainer.getFile();
            taskModel._externalResources = externalResourceCon.getFiles();
            taskModel._testCases = getTestCases();

            //if (_newFile)
            //{
            //    _filePath = SystemSingleton.Instance.currentTaskPath + "\\" + (taskModel._taskName).Replace(' ', '_') + ".task";
            //    JsonFileService.SaveToFile(taskModel,_filePath);
            //    _newFile = false;
            //    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            JsonFileService.SaveToFile(taskModel, _filePath);
            MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void Btn_AddTestCase_Click(object sender, EventArgs e)
        {
            var testCaseContainer = new TestCase();
            initialize_Save_Shortcut(testCaseContainer);
            testContainer.Controls.Add(testCaseContainer);
        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                associateContainer.addFile(filePath);
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = fileDialog.FileNames;
                foreach (string filePath in filePaths)
                {
                    externalResourceCon.addFile(filePath);
                }
            }
            //externalResourceCon.addFile("example");
        }

        private void languageUsed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
