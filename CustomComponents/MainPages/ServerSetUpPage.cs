using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.MainPages
{
    public partial class ServerSetUpPage : UserControl
    {
        public ServerSetUpPage()
        {
            InitializeComponent();
        }
        async private void smartButton1_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string>? taskValue = taskContainer.getFile();
            if(taskValue == null)
            {
                MessageBox.Show("No Task File Selected");
                return;
            }
            TaskModel taskModel = JsonFileService.LoadFromText<TaskModel>(taskValue.Value.Value);
            if (taskModel == null)
            {
                MessageBox.Show("Invalid File Content");
                return;
            }

           string  filePath = userCredentials.FilePath();
            if (filePath == null || filePath == "")
            {
                MessageBox.Show("No User Credentials File Selected");
                return;
            }
            Dictionary<string, UserProfile> users = await ReadCsvAsync(filePath);

            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.AutoScroll = true;
            SystemSingleton.Instance.page1.Controls.Add(new TempServerPage(taskModel));
        }

        //lets assume that the csv file contains studentId, studentName, and password (for now)
        public async Task<Dictionary<string, UserProfile>> ReadCsvAsync(string filePath)
        {
            Dictionary<string, UserProfile> users = new Dictionary<string, UserProfile>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                bool notFirstLine = false;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    if (notFirstLine) {
                        string[] fields = line.Split(',');
                        string userId = fields[0];
                        string userName = fields[1];
                        string passwo = fields[2];
                        users.Add(userId, new UserProfile());
                    }
                    notFirstLine = true;
                }
            }

            return users;
        }
    }
}
