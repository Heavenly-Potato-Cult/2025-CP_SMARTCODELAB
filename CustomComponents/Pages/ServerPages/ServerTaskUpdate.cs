using SmartCodeLab.CustomComponents.TaskPageComponents;
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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ServerTaskUpdate : UserControl
    {
        public ServerTaskUpdate()
        {
            InitializeComponent();
        }

        private TaskModel task;
        private Action<TaskModel> action;
        public ServerTaskUpdate(TaskModel task, Action<TaskModel> action)
        {
            InitializeComponent();
            this.task = task;
            this.action = action;
            SetUpTask();
        }

        private void SetUpTask()
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    exerciseName.Texts = task._taskName;
                    subject.Texts = task.subject;
                    langauge.Texts = task.language;
                    instruction.Texts = task._instructions;

                    testContainer.Controls.Clear();
                    if (task._testCases != null && task._testCases.Count > 0)
                    {
                        foreach (var item in task._testCases)
                        {
                            testContainer.Controls.Add(new TestCase(item));
                        }
                    }
                }));
            });
        }

        private void btn_AddTestCase_Click(object sender, EventArgs e)
        {
            testContainer.Controls.Add(new TestCase());
        }

        private void btn_EditExerciseDetails_Click(object sender, EventArgs e)
        {
            task._instructions = instruction.Texts;
            task._testCases.Clear();
            foreach (var item in testContainer.Controls.OfType<TestCase>())
            {
                task._testCases.Add(item.Value().Key, item.Value().Value);
            }

            action?.Invoke(task);
        }
    }
}
