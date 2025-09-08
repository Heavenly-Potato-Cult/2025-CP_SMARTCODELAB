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
            if (btnStatus == "Edit")
            {
                exerciseName.Enabled = true;
                subject.Enabled = true;
                instruction.Enabled = true;
                btn_EditExerciseDetails.Text = "Save";
                btnStatus = "Save";

                return;
            }

            if (btnStatus == "Save")
            {
                exerciseName.Enabled = false;
                subject.Enabled = false;
                instruction.Enabled = false;
                btn_EditExerciseDetails.Text = "Edit";
                btnStatus = "Edit";

                return;
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
                        var icon = new ExerciseIcon(task, changeSelected, FillFields);
                        taskContainer.Controls.Add(icon);
                        if(file == addedFile)
                            icon.ClickMe();
                    }
                }
            }
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
                reference.Text = task._referenceFile?.Value ?? "";
            }));
        }
    }
}
