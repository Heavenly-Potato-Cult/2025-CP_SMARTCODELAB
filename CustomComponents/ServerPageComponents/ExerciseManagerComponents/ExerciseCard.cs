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
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class ExerciseCard : UserControl
    {

        private int index;
        private TaskModel _task;
        Func<List<string>> existingSubjects;
        private Action<int, TaskModel> updateTask;
        public ExerciseCard(int index, TaskModel task, Action<int> taskRemover, Func<List<string>> existingSubjects, Action<int, TaskModel> updateTask)
        {
            InitializeComponent();
            this.index = index;
            this.updateTask = updateTask;
            this.existingSubjects = existingSubjects;
            lbl_ExerciseTitle.Text = task._taskName;
            subject.Text = task.subject;
            testCounts.Text = task._testCases?.Count.ToString() ?? "0";
            _task = task;
            dateModified.Text = GetSteamDate(task.lastModified);

            smartButton9.Click += (s, e) =>
            {
                if (UIServices.SelectYesNo("Are you sure you want to delete this Task?"))
                {
                    File.Delete(_task.filePath);
                    UIServices.OKDialogSucess("Task deleted successfully", "Deleted");
                    taskRemover(this.index);
                    Dispose();
                }
            };
        }

        private void btn_editcard_Click(object sender, EventArgs e)
        {
            using (var exerciseForm = new CustomDialogs.AddNewExercise(_task, existingSubjects.Invoke()))
            {
                var dialogResult = exerciseForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    _task = exerciseForm.NewExercise;
                    lbl_ExerciseTitle.Text = _task._taskName;
                    subject.Text = _task.subject;
                    dateModified.Text = _task.lastModified.ToString("MMM dd, yyyy hh:mm tt");
                    testCounts.Text = _task._testCases?.Count.ToString() ?? "0";
                    updateTask?.Invoke(index, _task);
                }
            }
        }

        private string GetSteamDate(DateTime date)
        {

            var diff = DateTime.Now - date;


            if (date.Date == DateTime.Today)
            {
                return "Today";
            }
            else if (date.Date == DateTime.Today.AddDays(-1))
            {
                return "Yesterday";
            }
            else
            {

                return date.ToString("MMM dd, yyyy");
            }
        }
    }
}
