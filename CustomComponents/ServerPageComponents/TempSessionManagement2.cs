using FastColoredTextBoxNS;
using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using SmartCodeLab.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            userProfiles = new Dictionary<string, UserProfile>();
            SetupDynamicLayout();

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // WS_EX_COMPOSITED: Paints all descendants of a window in bottom-to-top 
                // painting order using double-buffering.
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private Action<TaskModel> exerciseSelectedCallback => (task) =>
        {
            selectedTask = task;

            if (selectedExercise != null)
            {
                taskView.Controls.Remove(selectedExercise);
                selectedExercise.Dispose();
            }

            selectedExercise = new SelectedExercise(task, removeSelectedTask)
            {

                Dock = DockStyle.None,
                Location = new Point(0, 0),


                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            taskView.Controls.Add(selectedExercise);


            taskView.PerformLayout();
            panel5.PerformLayout();
        };

        private void SetupDynamicLayout()
        {
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            taskView.AutoSize = true;
            taskView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            taskView.Dock = DockStyle.Left;
            taskView.Padding = new Padding(0, 0, 10, 0);

            smartButton4.Dock = DockStyle.Left;

            taskView.SendToBack();
            smartButton4.BringToFront();
        }

        private Action removeSelectedTask => () =>
        {
            selectedTask = null;
            taskView.Controls.Remove(selectedExercise);
            selectedExercise = null;
        };

        //validate the accuracy of the reference code, which will be used for the efficiency
        public static (bool, Dictionary<string, int>?) ValidateCode(string code, LanguageSupported language, TaskModel task)
        {
            string tempFilePath = string.Empty;
            string command = string.Empty;
            string rootDirectory = SystemConfigurations.TASK_FOLDER;
            string compilationError = string.Empty;
            if (language == LanguageSupported.Cpp)
            {
                tempFilePath = Path.Combine(rootDirectory, "BestOperatorsCounter.cpp");
                File.WriteAllText(tempFilePath, code);
                string exeFile = Path.Combine(rootDirectory, "BestOperatorsCounter.exe");
                compilationError = compileCode($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{tempFilePath}\" -o \"{exeFile}\" && del \"{tempFilePath}\"\"");
                command = $"/c \"\"{exeFile}\"\"";
            }
            else if (language == LanguageSupported.Python)
            {
                tempFilePath = Path.Combine(rootDirectory, "BestOperatorsCounter.py");
                File.WriteAllText(tempFilePath, code);
                command = $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{tempFilePath}\"\"";
            }
            else
            {
                tempFilePath = Path.Combine(rootDirectory, "Main.java");
                command = $"/c \"cd \"{rootDirectory}\" && java BestOperatorsCounter\"";
                File.WriteAllText(tempFilePath, code);
                compilationError = compileCode($"/c \"javac \"{Path.Combine(SystemConfigurations.TASK_FOLDER, "Main.java")}\"\"");
            }
            if (compilationError != string.Empty)
            {
                MessageBox.Show("Compilation error " + compilationError);
                return (false, null);
            }
            SourceCodeInitializer.InitializeEfficiencyCode(language, code, rootDirectory);
            var validateCode = new TestCodeForm(command, task, true);
            validateCode.ShowDialog();
            bool isPerfect = validateCode.score == task._testCases.Count;
            validateCode.Dispose();
            return (isPerfect, validateCode.inputOperatorsCount);
        }

        public static string compileCode(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;


            process.Start();
            string errorOutput = process.StandardError.ReadToEnd();
            process.WaitForExit();
            return errorOutput;
        }

        private void smartButton5_Click(object sender, EventArgs e)
        {
            serverPW.Text = new Random().Next(10000, 100000).ToString();
        }

        private void smartButton4_Click(object sender, EventArgs e)
        {
            using (var selectExercise = new SelectExercise(exerciseSelectedCallback))
            {
                this.SuspendLayout();
                try
                {
                    selectExercise.ShowDialog();
                }
                finally
                {
                    this.ResumeLayout();
                }
            }
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            var studentTable = new StudTable(userProfiles);
            studentTable.ShowDialog();
            userProfiles = studentTable.expectedUsers;
            studentsCount.Text = userProfiles.Count.ToString();
        }

        private void steamPrimaryButton1_Click(object sender, EventArgs e)
        {
            codeQualityChoices21.putUnallocatedToAccuracy();
            (Server? server, string msg) = ServerServices.getServer(serverName.Text.Trim(),
                serverPW.Text,
                language.SelectedItem,
                codeQualityChoices21,
                selectedTask,
                userProfiles);

            if(server == null)
            {
                MessageBox.Show(msg);
                return;
            }
            server.ServerTask.isTabLocked = tabNavigationLocked.Checked;

            //to fit the mainserverpage to the page1
            var page1 = SystemSingleton.Instance.page1;
            page1.Controls.Clear();
            page1.AutoScroll = true;
            MainServerPage2 serverPage = new MainServerPage2(server);
            serverPage.Dock = DockStyle.Fill;
            page1.Controls.Add(serverPage);
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeQualityChoices21.setLanguage(language.SelectedItem.ToString() ?? "None");
        }
    }
}
