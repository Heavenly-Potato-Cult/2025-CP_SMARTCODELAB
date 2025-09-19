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
    public partial class ExerciseSmallIcon : RoundedUserControl
    {
        public ExerciseSmallIcon()
        {
            InitializeComponent();
        }

        public ExerciseSmallIcon(TaskModel taskModel) 
        {
            InitializeComponent();
            taskName.Text = taskModel._taskName;
            smartButton1.Click += (s, e) =>
            {
                MessageBox.Show(taskModel._taskName);
            };
        }
    }
}
