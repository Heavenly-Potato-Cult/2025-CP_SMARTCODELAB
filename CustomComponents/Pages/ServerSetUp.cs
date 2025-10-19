using Microsoft.VisualBasic.ApplicationServices;
using SmartCodeLab.CustomComponents.ServerPageComponents;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ServerSetUp : UserControl
    {
        private TaskModel selectedTask;
        public ServerSetUp()
        {
            InitializeComponent();
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            var fileChooser = new OpenFileDialog();
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                selectedTask = JsonFileService.LoadFromFile<TaskModel>(fileChooser.FileName);
                if (selectedTask == null)
                {
                    ShowError("Invalid File Content");
                    return;
                }
                taskContainer.Controls.Clear();
                taskContainer.Controls.Add(new ExerciseSmallIcon(selectedTask));
            }
        }

        private void smartButton4_Click(object sender, EventArgs e)
        {
            if (serverName.Texts.IsWhiteSpace())
            {
                ShowError("Invalid Server Name");
                return;
            }
            else if (language.SelectedItem == null || language.SelectedItem.ToString() == "")
            {
                ShowError("No language Selected");
                return;
            }
            else if(selectedTask == null)
            {
                selectedTask = new TaskModel();
            }
            //selectedTask.ratingFactors = codeQualityChoices.GetRatingFactors();
            Server server = new Server(serverName.Texts.Trim(),"",selectedTask,language.SelectedItem.ToString(), new Dictionary<string, UserProfile>() { {"2",new UserProfile("Clifford","2","Slimparroot")} });

            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.AutoScroll = true;
            SystemSingleton.Instance.page1.Controls.Add(new MainServerPage(server));
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
