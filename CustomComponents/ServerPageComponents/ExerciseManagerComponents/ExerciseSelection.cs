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

            EventHandler clickAction = (s, e) => selected?.Invoke(task);

            this.Cursor = Cursors.Hand;

            
            this.Click += clickAction;

            WireAllControls(this, clickAction);
        }

        /// <summary>
        /// Loops through every control inside the component and gives them the click event
        /// </summary>
        private void WireAllControls(Control parent, EventHandler action)
        {
            foreach (Control child in parent.Controls)
            {
                
                child.Click += action;
                child.Cursor = Cursors.Hand; 

                if (child.HasChildren)
                {
                    WireAllControls(child, action);
                }
            }
        }
    }
}
