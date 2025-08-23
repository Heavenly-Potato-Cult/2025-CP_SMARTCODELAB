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
        private bool _newFile;
        private string? _filePath;

        //this is for opening a new file
        public TaskTabPage()
        {
            InitializeComponent();
            initialize_Save_Shortcut();
            _newFile = true;
        }

        public TaskTabPage(string _filePath)
        {
            InitializeComponent();
            initialize_Save_Shortcut();
            _newFile = false;
            this._filePath = _filePath;
            TaskModel taskModel = JsonFileService.LoadFromFile<TaskModel>(_filePath);

            if (taskModel != null)
            {
                actName.Text = taskModel._taskName;
                instruction.Text = taskModel._instructions;
                languageUsed.SelectedItem = taskModel.language;
                KeyValuePair<string, string>? referenceFile = taskModel._referenceFile;
                if (referenceFile.HasValue)
                    associateContainer.addFile(referenceFile.Value.Key, referenceFile.Value.Value);
            }
        }

        private void initialize_Save_Shortcut()
        {
            foreach (Control control in Controls)
            {
                control.KeyUp += (sender, k) =>
                {
                    if (k.KeyCode == Keys.S && k.Control)
                    {
                        var taskModel = new TaskModel();
                        taskModel._taskName = actName.Text;
                        taskModel._instructions = instruction.Text;
                        taskModel.language = languageUsed.SelectedItem?.ToString() ?? null;
                        taskModel._referenceFile = associateContainer.getFile();
                        taskModel._externalResources = externalResourceCon.getFiles();
                        //taskModel._testCases = testContainer.getFiles();
                        MessageBox.Show(taskModel.ToString());
                        save_File(taskModel);
                    }
                };
            }
        }

        private void save_File(TaskModel taskModel)
        {
            if (_newFile)
            {
                _filePath = SystemSingleton.Instance.currentTaskPath + "\\" + (taskModel._taskName).Replace(' ', '_') + ".task";
                JsonFileService.SaveToFile(taskModel,_filePath);
                _newFile = false;
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                JsonFileService.SaveToFile(taskModel, _filePath);
                MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            testContainer.Controls.Add(new TestCase());
        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if(result == DialogResult.OK)
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
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = fileDialog.FileNames;
                foreach (string filePath in filePaths)
                {
                    MessageBox.Show(filePath);
                }
            }
            //externalResourceCon.addFile("example");
        }
    }
}
