using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    public partial class ExerciseIcon : RoundedUserControl
    {
        private Action<ExerciseIcon> changeFocus;
        private Action<TaskModel> setFields;
        public TaskModel task { get; }
        public ExerciseIcon(TaskModel task, Action<ExerciseIcon> changeFocus, Action<TaskModel> setFields)
        {
            InitializeComponent();

            this.changeFocus = changeFocus;
            this.setFields = setFields;
            this.task = task;


            taskName.Click += GotFocus;
            subject.Click += GotFocus;
            this.Click += GotFocus;

            taskName.Text = task._taskName;
            subject.Text = task.subject;
        }

        private void GotFocus(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => this.BackColor = Color.FromArgb(240, 247, 255)));
            setFields?.Invoke(task);
            changeFocus?.Invoke(this);
        }

        public void ClickMe()
        {
            this.OnClick(EventArgs.Empty);
        }

        public void UpdateDisplay()
        {
            this.Invoke((Action)(() => {
                taskName.Text = task._taskName;
                subject.Text = task.subject;
            }));
        }

        public void LostFocus()
        {
            this.Invoke(new Action(() => this.BackColor = Color.White));
        }
    }
}
