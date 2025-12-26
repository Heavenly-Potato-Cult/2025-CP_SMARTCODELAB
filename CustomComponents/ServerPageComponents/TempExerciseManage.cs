using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System.Data;
using System.IO;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using ProtoBuf;
using System.Diagnostics;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempExerciseManage : UserControl
    {
        private System.Threading.Timer searchTimer;
        private Dictionary<int, TaskModel> loadedExercises;
        private ISet<string> taskSubjects;
        private long searchVersion;
        private int totalLoadedCount;
        private List<string> existingTasks;
        public TempExerciseManage()
        {
            InitializeComponent();

            //get the subjects
            taskSubjects = new HashSet<string>();
            searchVersion = 0;
            totalLoadedCount = 0;
            customTextBox1.innerTextBox.TextChanged += (s, e) =>
            {
                searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
                searchTimer = new System.Threading.Timer(_ =>
                {
                    _ = displayTasks();
                }, null, 400, Timeout.Infinite);
            };
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

                loadedExercises = new Dictionary<int, TaskModel>();
                if(!Directory.Exists(SystemConfigurations.TASK_FOLDER))
                {
                    Directory.CreateDirectory(SystemConfigurations.TASK_FOLDER);
                }
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
                                loadedExercises.Add(totalLoadedCount++, exercise);
                            }
                        }
                    }
                    catch {}
                }
                existingTasks = loadedExercises.Values.Select(ex => ex.filePath).ToList();
                if (this.IsHandleCreated)
                {
                    this.Invoke((Action)(() =>
                    {
                        foreach (var item in loadedExercises.Values)
                        {
                            taskSubjects.Add(item.subject.Trim().ToUpper());
                        }
                        this.subjects.Items.AddRange(taskSubjects.ToArray());
                    }));
                    _ = displayTasks();
                }
            });
        }


        private async Task displayTasks()
        {
            this.Invoke((Action)(() =>
            {
                long currentVersion = ++searchVersion;
                string search = customTextBox1.innerTextBox.Text;
                search = search.Contains("Search exercise", StringComparison.OrdinalIgnoreCase) ? "" : search;
                string subjectFilter = subjects.SelectedItem?.ToString() ?? "All";
                bool searchForAll = subjectFilter == "All";
                var filteredSearch = loadedExercises.Where(ex =>
                    ex.Value._taskName.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                    (searchForAll || ex.Value.subject.Equals(subjectFilter, StringComparison.OrdinalIgnoreCase))
                ).ToList();

                Task.Delay(200);
                flowLayoutPanel_Exercises.Controls.Clear();
                foreach (var exercise in filteredSearch)
                {
                    if (currentVersion != searchVersion)
                        break;
                    flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(exercise, removeExervice, getSubjects, updateSubjectsLists, getExistingTasks));
                }
            }));
        }

        private List<string> getExistingTasks()
        {
            return existingTasks;
        }

        private List<string> getSubjects()
        {
            return taskSubjects.ToList();
        }

        private void updateSubjectsLists(int index, TaskModel updatedTask)
        {
            string oldFilePath =  loadedExercises[index].filePath;
            existingTasks.Remove(oldFilePath);

            loadedExercises[index] = updatedTask;
            existingTasks.Add(updatedTask.filePath);

            string potentialNewSubject = updatedTask.subject.Trim().ToUpper();
            if (!taskSubjects.Contains(potentialNewSubject))
            {
                taskSubjects.Add(potentialNewSubject);
                subjects.Items.Add(potentialNewSubject);
            }
        }

        private void removeExervice(int index)
        {
            loadedExercises.Remove(index);
            existingTasks.Remove(loadedExercises[index].filePath);
        }

        private void btn_AddNewExercise_Click_1(object sender, EventArgs e)
        {
            using (var exerciseForm = new AddNewExercise(getSubjects(), existingTasks))
            {
                var dialogResult = exerciseForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var newExerciser = exerciseForm.NewExercise;
                    int index = totalLoadedCount++;
                    loadedExercises.Add(index, newExerciser);
                    existingTasks.Add(newExerciser.filePath);
                    flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(new KeyValuePair<int,TaskModel>(index, newExerciser), removeExervice, getSubjects, updateSubjectsLists, getExistingTasks));
                    updateSubjectsLists(index, newExerciser);
                }
            }
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
