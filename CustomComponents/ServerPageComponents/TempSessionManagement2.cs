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
        private readonly Regex InvalidCharsRegex = new Regex(
            @"[<>:""/\\|?*\x00-\x1F]",
            RegexOptions.Compiled
        );
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
        private bool ValidateCode(string code, LanguageSupported language, TaskModel task)
        {
            string tempFilePath = string.Empty;
            string command = string.Empty;
            string rootDirectory = SystemConfigurations.TASK_FOLDER;
            string compilationError = string.Empty;
            if (language == LanguageSupported.Cpp)
            {
                tempFilePath = Path.Combine(rootDirectory, "bestCode.cpp");
                File.WriteAllText(tempFilePath, code);
                string exeFile = Path.Combine(rootDirectory, "bestCode.exe");
                compilationError = compileCode($"/c \"\"{ProgrammingConfiguration.gccExe}\" -std=c++11 \"{tempFilePath}\" -o \"{exeFile}\" && del \"{tempFilePath}\"\"");
                command = $"/c \"\"{exeFile}\"\"";
            }
            else if (language == LanguageSupported.Python)
            {
                tempFilePath = Path.Combine(rootDirectory, "bestCode.py");
                command = $"/c \"\"{ProgrammingConfiguration.pythonExe}\" \"{tempFilePath}\"\"";
            }
            else
            {
                tempFilePath = Path.Combine(rootDirectory, "Main.java");
                command = $"/c \"cd \"{rootDirectory}\" && \"{ProgrammingConfiguration.javaExe}\" Main\"";
                File.WriteAllText(tempFilePath, code);
                compilationError = compileCode($"/c \"\"{ProgrammingConfiguration.javac}\" \"{Path.Combine(SystemConfigurations.TASK_FOLDER, "Main.java")}\"\"");
            }

            if (compilationError != string.Empty)
            {
                MessageBox.Show("Compilation error " + compilationError);
                return false;
            }
            File.WriteAllText(tempFilePath, code);
            var validateCode = new TestCodeForm(command, task);
            validateCode.ShowDialog();
            bool isPerfect = validateCode.score == task._testCases.Count;
            validateCode.Dispose();
            return isPerfect;
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

            foreach (var file in Directory.EnumerateFiles(SystemConfigurations.SESSIONS_FOLDER))
            {
                if (Path.GetFileNameWithoutExtension(file).Trim().ToLower() == serverName.Text.Trim().ToLower())
                {
                    MessageBox.Show("Session Name is Already Used");
                    return;
                }
            }
            //check the coding stats to see if some rating have 0 weight
            List<int> haveZeroRating = new List<int>();
            foreach (var item in codeQualityChoices21.GetRatingFactors())
                if (item.Value[0] == 0)
                    haveZeroRating.Add(item.Key);

            if (serverName.Text.IsWhiteSpace())
            {
                MessageBox.Show("Invalid Server Name");
                return;
            }
            else if (InvalidCharsRegex.IsMatch(serverName.Text))
            {
                MessageBox.Show("The server name contains invalid characters. Please avoid using the following characters: < > : \" / \\ | ? *", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (language.SelectedItem == null || language.SelectedItem.ToString() == "")
            {
                MessageBox.Show("No language Selected");
                return;
            }
            else if (serverPW.Text.IsWhiteSpace())
            {
                MessageBox.Show("Server Password is Required");
                return;
            }
            else if (haveZeroRating.Count > 0)
            {
                string[] statsName = { "", "", "Efficiency", "Robustness", "Maintainability" };
                string withZero = string.Join('\n',
                    haveZeroRating.Select(num => statsName[num]).ToArray());
                MessageBox.Show("The following have 0 stats weight, better remove or update weight: \n" + withZero);
                return;
            }

            selectedTask = selectedTask ?? new TaskModel();

            selectedTask.ratingFactors = codeQualityChoices21.GetRatingFactors();
            selectedTask.isTabLocked = tabNavigationLocked.Checked;
            selectedTask._referenceFile = codeQualityChoices21.bestSourceCode;
            Server server = new Server(serverName.Text.Trim(), serverPW.Text, selectedTask, language.SelectedItem.ToString(), userProfiles);

            if (codeQualityChoices21.GetRatingFactors().ContainsKey(2) && selectedTask._testCases.Count > 0)
            {
                if (!ValidateCode(codeQualityChoices21.bestSourceCode, server.ProgrammingLanguage, selectedTask))
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

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeQualityChoices21.setLanguage(language.SelectedItem.ToString() ?? "None");
        }
    }
}
