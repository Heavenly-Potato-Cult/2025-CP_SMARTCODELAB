using FastColoredTextBoxNS;
using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class TempSessionManagement2 : UserControl
    {
        private TaskModel selectedTask;
        private Dictionary<string, UserProfile> userProfiles;
        private SelectedExercise selectedExercise;
        public TempSessionManagement2()
        {
            InitializeComponent();
            userProfiles = new Dictionary<string, UserProfile>()
            {
                {"2", new UserProfile("Jimmuel", "2", "Belloq") },
                {"3", new UserProfile("Angelo", "3", "Jimmuel")  }
            };
        }
        private void smartButton1_Click_1(object sender, EventArgs e)
        {
            foreach (var file in Directory.EnumerateFiles(SystemConfigurations.SESSIONS_FOLDER))
            {
                if (Path.GetFileNameWithoutExtension(file).Trim() == serverName.Texts.Trim())
                {
                    MessageBox.Show("Session Name is Already Used");
                    return;
                }
            }
            if (serverName.Texts.IsWhiteSpace())
            {
                MessageBox.Show("Invalid Server Name");
                return;
            }
            else if (language.SelectedItem == null || language.SelectedItem.ToString() == "")
            {
                MessageBox.Show("No language Selected");
                return;
            }
            else if (serverPW.Texts.IsWhiteSpace())
            {
                MessageBox.Show("Server Password is Required");
                return;
            }
            else if (selectedTask == null)
            {
                selectedTask = new TaskModel();
            }

            selectedTask.ratingFactors = codeQualityChoices21.GetRatingFactors();
            selectedTask.isTabLocked = tabNavigationLocked.Checked;
            selectedTask._referenceFile = codeQualityChoices21.bestSourceCode;
            Server server = new Server(serverName.Texts.Trim(), serverPW.Texts, selectedTask, language.SelectedItem.ToString(), userProfiles);
            
            if(codeQualityChoices21.GetRatingFactors().ContainsKey(2) && selectedTask._testCases.Count > 0)
            {
                if(!ValidateCode(codeQualityChoices21.bestSourceCode, server.ProgrammingLanguage, selectedTask))
                {
                    MessageBox.Show("The code you provided as a reference for efficiency is not accurate.");
                    return;
                }
            }
            //to fit the mainserverpage to the page1
            var page1 = SystemSingleton.Instance.page1;
            page1.Controls.Clear();
            page1.AutoScroll = true;

            MainServerPage2 serverPage = new MainServerPage2(server);

            serverPage.Dock = DockStyle.Fill;

            page1.Controls.Add(serverPage);
        }

        private void smartButton4_Click_1(object sender, EventArgs e)
        {
            serverPW.Texts = new Random().Next(10000, 100000).ToString();
        }

        private void smartButton3_Click_1(object sender, EventArgs e)
        {
            using (var selectExercise = new SelectExercise(exerciseSelectedCallback))
            {
                selectExercise.ShowDialog();
            }
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            var studentTable = new StudTable(userProfiles);
            studentTable.ShowDialog();
            userProfiles = studentTable.expectedUsers;
            studentsCount.Text = userProfiles.Count.ToString();
        }

        private void language_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            codeQualityChoices21.setLanguage(language.SelectedItem.ToString());
        }

        private Action<TaskModel> exerciseSelectedCallback => (task) =>
        {
            selectedTask = task;
            if (selectedExercise != null)
                taskView.Controls.Remove(selectedExercise);
            selectedExercise = new SelectedExercise(task, removeSelectedTask);
            taskView.Controls.Add(selectedExercise);
        };

        private Action removeSelectedTask => () =>
        {
            selectedTask = null;
            taskView.Controls.Remove(selectedExercise);
            selectedExercise = null;
        };

        //validate the accuracy of the reference code, which will be used for the efficiency
        private bool ValidateCode(string code, LanguageSupported language, TaskModel task)
        {
            string tempFilePath = string.Empty;
            string command = string.Empty;
            string rootDirectory = SystemConfigurations.TASK_FOLDER;
            if (language == LanguageSupported.Cpp) 
            {
                tempFilePath = Path.Combine(rootDirectory, "bestCode.cpp");
                string exeFile = Path.Combine(rootDirectory, "bestCode.exe");
                command = $"/c \"\"{ProgrammingConfiguration.gccExe}\" \"{tempFilePath}\" -o \"{exeFile}\" && \"{exeFile}\"\"";
            }
            else if(language == LanguageSupported.Python)
            {
                tempFilePath = Path.Combine(rootDirectory, "bestCode.py");
                command = $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{tempFilePath}\"\"";
            }
            else
            {
                tempFilePath = Path.Combine(rootDirectory, "Main.java");
                command = $"/c \"cd \"{rootDirectory}\" && \"{ProgrammingConfiguration.javaExe}\" Main\"";
                File.WriteAllText(tempFilePath, code);
                compileJavaCode();
            }
            File.WriteAllText(tempFilePath, code);
            var validateCode = new TestCodeForm(command, task);
            validateCode.ShowDialog();
            return validateCode.score == task._testCases.Count;
        }

        public void compileJavaCode()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c \"\"{ProgrammingConfiguration.javac}\" \"{Path.Combine(SystemConfigurations.TASK_FOLDER,"Main.java")}\"\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();
            process.WaitForExit();
        }
    }
}
