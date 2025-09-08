using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.TaskPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private readonly Dictionary<string, string> languageExtension = new Dictionary<string, string>()
        {
            {"Cpp","Cpp file(.cpp)|*.cpp" },
            {"Java",".Java file(.java)|*.java" },
            {"Python","Python file(.py)|*.py" }
        };
        private Action<ExerciseIcon> changeSelected;
        private ExerciseIcon selectedIcon;
        public TempExerciseManage()
        {
            InitializeComponent();
            changeSelected = (exercise) =>
            {
                selectedIcon?.LostFocus();
                selectedIcon = exercise;
            };
        }

        private void TempExerciseManage_Load(object sender, EventArgs e)
        {

        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save New Task File";
                saveFileDialog.Filter = "Task Files (*.task)|*.task|All Files (*.*)|*.*";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "task";
                saveFileDialog.FileName = "new_task";
                saveFileDialog.InitialDirectory = @folderPath;
                saveFileDialog.FileName = ""; // suggest default name
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // The user selected a folder and file name
                    string path = saveFileDialog.FileName;
                    JsonFileService.SaveToFile(new TaskModel(Path.GetFileNameWithoutExtension(path)), path);
                    folderPath = Path.GetDirectoryName(path);
                    SaveEditBtn(true);
                    OpenTasksFolder(path);
                }
            }
        }

        private void smartButton5_Click(object sender, EventArgs e)
        {
            //AddNewTestCase addNewTestCase = new AddNewTestCase();
            //addNewTestCase.ShowDialog();
        }

        private void btn_UploadFileReference_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
        }

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            SaveEditBtn(btnStatus == "Edit");
            //if (btnStatus == "Edit")
            //{
            //    exerciseName.Enabled = true;
            //    subject.Enabled = true;
            //    instruction.Enabled = true;
            //    btn_EditExerciseDetails.Text = "Save";
            //    btnStatus = "Save";

            //}
            //else if(btnStatus == "Save")
            //{
            //    exerciseName.Enabled = false;
            //    subject.Enabled = false;
            //    instruction.Enabled = false;
            //    btn_EditExerciseDetails.Text = "Edit";
            //    btnStatus = "Edit";
            //    SaveTask();
            //}
        }

        private void SaveEditBtn(bool isEditing)
        {
            exerciseName.Enabled = isEditing;
            subject.Enabled = isEditing;
            instruction.Enabled = isEditing;
            language.Enabled = isEditing;
            btn_EditExerciseDetails.Text = isEditing ? "Save" : "Edit";
            reference.ReadOnly = !isEditing;
            btnStatus = isEditing ? "Save" : "Edit";
            if (!isEditing)
            {
                SaveTask();
            }
        }

        private void OpenTasksFolder(string addedFile = "")
        {
            taskContainer.Controls.Clear();
            foreach (string file in Directory.GetFiles(folderPath))
            {
                if (file.EndsWith(".task"))
                {
                    TaskModel task = JsonFileService.LoadFromFile<TaskModel>(file);
                    if (task != null)
                    {
                        task.filePath = file;
                        var icon = new ExerciseIcon(task, changeSelected, FillFields);
                        taskContainer.Controls.Add(icon);
                        if (file == addedFile)
                            icon.ClickMe();
                    }
                }
            }
        }

        private void SaveTask()
        {
            TaskModel task = selectedIcon.task;
            task._taskName = exerciseName.Texts;
            task.subject = subject.Texts;
            task.language = language.SelectedItem?.ToString() ?? null;
            task._instructions = instruction.Texts;
            task._referenceFile = reference.Text;

            JsonFileService.SaveToFile<TaskModel>(task, task.filePath);
            MessageBox.Show("Task Saved Successfully");
            selectedIcon.UpdateDisplay();
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
                OpenTasksFolder();
            }
        }

        private void FillFields(TaskModel task)
        {
            this.Invoke((Action)(() =>
            {
                exerciseName.Texts = task._taskName;
                subject.Texts = task.subject;
                language.SelectedItem = task.language;
                instruction.Texts = task._instructions;
                reference.Text = task._referenceFile;
            }));
        }

        private void smartButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = languageExtension[language.SelectedItem.ToString()];
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
                reference.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}
