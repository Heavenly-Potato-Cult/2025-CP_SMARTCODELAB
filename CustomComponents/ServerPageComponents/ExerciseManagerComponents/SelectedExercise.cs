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

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    public partial class SelectedExercise : UserControl
    {
        public TaskModel selectedTask { get; private set; }
        private Action removeMe;
        public SelectedExercise()
        {
            InitializeComponent();
            Location = new Point(0, 0);
            this.removeMe = removeMe;
        }

        public SelectedExercise(TaskModel task, Action removeMe)
        {
            InitializeComponent();
            taskName.Text = task._taskName;
            selectedTask = task;
            this.removeMe = removeMe;
            Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeMe?.Invoke();
            Dispose();
        }
    }
}
