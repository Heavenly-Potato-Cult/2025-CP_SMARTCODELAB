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
        private async void TempExerciseManage_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var exerciseFiles = Directory.GetFiles(SystemConfigurations.TASK_FOLDER, "*.task");
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
