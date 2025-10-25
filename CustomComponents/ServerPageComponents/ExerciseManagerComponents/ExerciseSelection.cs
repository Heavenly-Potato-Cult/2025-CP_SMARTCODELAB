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
    public partial class ExerciseSelection : UserControl
    {
        public ExerciseSelection()
        {
            InitializeComponent();
        }

        public ExerciseSelection(TaskModel task, Action<TaskModel> selected)
        {
            InitializeComponent();
            taskName.Text = task._taskName;
            subject.Text = task.subject;
            testCounts.Text = task._testCases?.Count.ToString() ?? "0";
            Click += (s, e) => selected?.Invoke(task);
        }
    }
}
