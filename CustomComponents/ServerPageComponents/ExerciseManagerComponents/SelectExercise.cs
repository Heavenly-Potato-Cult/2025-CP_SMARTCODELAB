using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class SelectExercise : Form
    {
        private string exercisesFolder = SystemConfigurations.TASK_FOLDER;
        private System.Threading.Timer refreshTimer;
        private Action<TaskModel> onExerciseSelected;
        public SelectExercise()
        {
            InitializeComponent();
            var handle = this.Handle;
            Load += (sender, e) => PopulateExerciseList();
        }

        public SelectExercise(Action<TaskModel> onExerciseSelected)
        {
            InitializeComponent();
            this.onExerciseSelected = onExerciseSelected;
        }

        private void PopulateExerciseList()
        {
            refreshTimer?.Change(Timeout.Infinite, Timeout.Infinite);

            refreshTimer = new System.Threading.Timer(_ =>
            {
                Task.Run(() =>
                {
                    string searched = searchBox.Texts.ToLower();
                    var exerciseFiles = Directory.GetFiles(exercisesFolder, "*.task").
                        Where(file => Path.GetFileName(file).ToLower().Contains(searched)).
                        ToList();
                    try
                    {
                        this.Invoke(new Action(() => flowLayoutPanel1.Controls.Clear()));

                        foreach (var file in exerciseFiles)
                        {
                            using (var fileOpened = File.OpenRead(file))
                            {
                                var exercise = ProtoBuf.Serializer.DeserializeWithLengthPrefix<TaskModel>(fileOpened, ProtoBuf.PrefixStyle.Base128);
                                exercise.filePath = file;
                                this.Invoke(new Action(() =>
                                {
                                    flowLayoutPanel1.Controls.Add(new ExerciseSelection(exercise, exerciseSelected));
                                }));
                            }
                        }
                    }
                    catch (InvalidOperationException) { }
                });
            }, null, 300, Timeout.Infinite);
        }

        private void searchBox__TextChanged(object sender, EventArgs e)
        {
            PopulateExerciseList();
        }

        private Action<TaskModel> exerciseSelected => (task) =>
        {
            onExerciseSelected?.Invoke(task);
            Dispose();
        };
    }
}
