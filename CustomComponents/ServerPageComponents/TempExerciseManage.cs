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
        public TempExerciseManage()
        {
            InitializeComponent();
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
                
                var loadedExercises = new List<TaskModel>();

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

                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        // --- SUSPEND LAYOUT ---
                        // This stops the FlowLayoutPanel from calculating positions for every single item added.
                        flowLayoutPanel_Exercises.SuspendLayout();

                        try
                        {
                           
                            var cards = loadedExercises
                                .Select(ex => new ExerciseCard(ex))
                                .ToArray();

                            flowLayoutPanel_Exercises.Controls.AddRange(cards);
                        }
                        finally
                        {
                            // --- RESUME LAYOUT ---
                            // 'true' forces an immediate layout calculation of the final result
                            flowLayoutPanel_Exercises.ResumeLayout(true);
                        }
                    }));
                }
            });
        }

        private void btn_AddNewExercise_Click(object sender, EventArgs e)
        {
            using (var exerciseForm = new AddNewExercise())
            {
                var dialogResult = exerciseForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(exerciseForm.NewExercise));
                }
            }
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            searchTimer = new System.Threading.Timer(_ =>
            {
                string search = customTextBox1.Texts.ToLower();
                var exerciseFiles = Directory.GetFiles(SystemConfigurations.TASK_FOLDER, "*.task").
                    Where(file => Path.GetFileName(file).ToLower().Contains(search)).ToList();
                this.Invoke(new Action(() => flowLayoutPanel_Exercises.Controls.Clear()));
                foreach (var file in exerciseFiles)
                {
                    using (var fileOpened = File.OpenRead(file))
                    {
                        var exercise = Serializer.DeserializeWithLengthPrefix<TaskModel>(fileOpened, PrefixStyle.Base128);
                        exercise.filePath = file;
                        this.Invoke(new Action(() =>
                        {
                            flowLayoutPanel_Exercises.Controls.Add(new ExerciseCard(exercise));
                        }));
                    }
                }
            }, null, 400, Timeout.Infinite);
        }
    }
}
