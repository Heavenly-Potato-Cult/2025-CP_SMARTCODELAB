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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public SelectExercise(Action<TaskModel> onExerciseSelected)
        {
            InitializeComponent();
            this.onExerciseSelected = onExerciseSelected;
            Load += (sender, e) => PopulateExerciseList();

        }

        private void PopulateExerciseList()
        {
            refreshTimer?.Change(Timeout.Infinite, Timeout.Infinite);

            refreshTimer = new System.Threading.Timer(_ =>
            {
                Task.Run(() =>
                {
                    string searched = "";

                    // Safe access to UI control from background thread
                    if (IsHandleCreated)
                    {
                        this.Invoke(new Action(() => searched = searchBox.Texts.ToLower()));
                    }

                    // 1. Gather Data (Background)
                    var exerciseFiles = Directory.GetFiles(exercisesFolder, "*.task")
                        .Where(file => Path.GetFileName(file).ToLower().Contains(searched))
                        .ToList();

                    var controlsToAdd = new List<Control>();

                    foreach (var file in exerciseFiles)
                    {
                        try
                        {
                            using (var fileOpened = File.OpenRead(file))
                            {
                                var exercise = ProtoBuf.Serializer.DeserializeWithLengthPrefix<TaskModel>(fileOpened, ProtoBuf.PrefixStyle.Base128);
                                exercise.filePath = file;
                                
                                controlsToAdd.Add(new ExerciseSelection(exercise, exerciseSelected) { Dock = DockStyle.Top});
                            }
                        }
                        catch {  }
                    }

                    //  Update UI (Main Thread - Batch Update)
                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            holder.SuspendLayout(); // Freeze List
                            holder.Controls.Clear();
                            holder.Controls.AddRange(controlsToAdd.ToArray()); // Add All
                            holder.ResumeLayout(true); // Unfreeze List
                        }));
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        };
    }
}
