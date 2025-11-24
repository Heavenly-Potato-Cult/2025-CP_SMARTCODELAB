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
using System.IO;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using ProtoBuf;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempExerciseManage : UserControl
    {
        private System.Threading.Timer searchTimer;
        private List<TaskModel> loadedExercises;
        private ISet<string> taskSubjects;
        private long searchVersion;
        public TempExerciseManage()
        {
            InitializeComponent();

            //get the subjects
            taskSubjects = new HashSet<string>();
            searchVersion = 0;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // WS_EX_COMPOSITED: Paints all descendants of a window in bottom-to-top 
                // painting order using double-buffering.
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private async void TempExerciseManage_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                loadedExercises = new List<TaskModel>();

                var exerciseFiles = Directory.GetFiles(SystemConfigurations.TASK_FOLDER, "*.task");

                foreach (var file in exerciseFiles)
                {
                    try
                    {
                        using (var fileOpened = File.OpenRead(file))
                        {
                            var exercise = Serializer.DeserializeWithLengthPrefix<TaskModel>(fileOpened, PrefixStyle.Base128);
                            if (exercise != null)
                            {
                                exercise.filePath = file;
                                loadedExercises.Add(exercise);
                            }
                        }
                    }
                    catch { /* Handle individual file errors here */ }
                }
                //ilagay ang mga subjects sa lists, i uppercase pra sure no duplicate
                if (this.IsHandleCreated)
                {
                    this.Invoke((Action) (() =>
                    {
                        foreach (var item in loadedExercises)
                        {
                            taskSubjects.Add(item.subject.Trim().ToUpper());
                        }
                        this.subjects.Items.AddRange(taskSubjects.ToArray());
                    }));
                    _ = displayTasks();
                }
            });
        }

        private List<string> getSubjects()
        {
            return taskSubjects.ToList();
        }

        private void btn_AddNewExercise_Click(object sender, EventArgs e)
        {
            using (var exerciseForm = new AddNewExercise(taskSubjects.ToList()))
            {
                var dialogResult = exerciseForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    loadedExercises.Add(exerciseForm.NewExercise);
                    flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(exerciseForm.NewExercise, removeExervice, getSubjects));
                }
            }
        }

        private async Task displayTasks()
        {
            this.Invoke((Action)(() =>
            {
                long currentVersion = ++searchVersion;
                string search = customTextBox1.Texts;
                string subjectFilter = subjects.SelectedItem?.ToString() ?? "All";
                bool searchForAll = subjectFilter == "All";
                var filteredSearch = loadedExercises.Where(ex =>
                    ex._taskName.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                    (searchForAll || ex.subject.Equals(subjectFilter, StringComparison.OrdinalIgnoreCase))
                ).ToList();
                Task.Delay(200);
                flowLayoutPanel_Exercises.Controls.Clear();
                foreach (var exercise in filteredSearch)
                {
                    if (currentVersion != searchVersion)
                        break;
                    flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(exercise, removeExervice, getSubjects));
                }
            }));
        }

        private void removeExervice(TaskModel task)
        {
            loadedExercises.Remove(task);
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer(_ =>
            {
                _ = displayTasks();
            }, null, 400, Timeout.Infinite);
        }

        private void subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer(_ =>
            {
                _ = displayTasks();
            }, null, 400, Timeout.Infinite);
        }
    }
}
