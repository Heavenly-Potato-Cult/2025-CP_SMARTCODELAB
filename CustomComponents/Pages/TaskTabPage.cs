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

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class TaskTabPage : UserControl
    {
        public TaskTabPage()
        {
            InitializeComponent();
            foreach(Control control in Controls)
            {
                control.KeyUp += (sender, k) => 
                {
                    if (k.KeyCode == Keys.S && k.Control)
                    {
                        var taskModel = new TaskModel();
                        taskModel._taskName = actName.Text;
                        taskModel._instructions = instruction.Text;
                        taskModel.language = languageUsed.SelectedItem?.ToString() ?? null;
                        taskModel._referenceFile = associateContainer.getFile();
                        taskModel._externalResources = externalResourceCon.getFiles();
                        MessageBox.Show(taskModel.ToString());
                        MessageBox.Show(SystemSingleton.Instance.currentTaskPath ?? "no path set");
                    }
                };
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            testContainer.Controls.Add(new TestCase());
        }

        private void openFile1_Click(object sender, EventArgs e)
        {
            associateContainer.addFile("testing");
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            externalResourceCon.addFile("example");
        }
    }
}
