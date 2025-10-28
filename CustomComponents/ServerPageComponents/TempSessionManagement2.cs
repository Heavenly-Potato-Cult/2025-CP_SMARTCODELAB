using FastColoredTextBoxNS;
using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs.StudentTable;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents;
using SmartCodeLab.Models;
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
                { "2", new UserProfile("Clifford", "2", "Slimparroot") },
            };

            Load += async (sender, e) =>
            {
                foreach (var sessionFile in Directory.GetFiles(SystemConfigurations.SESSIONS_FOLDER).Where(file => file.EndsWith(".session")))
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            var programmingSession = Serializer.DeserializeWithLengthPrefix<ProgrammingSession>(File.OpenRead(sessionFile), PrefixStyle.Base128);
                            this.Invoke((Action)(() =>
                            {
                                logsContaier.Controls.Add(new SessionLogsDisplay(programmingSession));
                            }));
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Failed to load session file {Path.GetFileName(sessionFile)}: {ex.Message}");
                        }
                    });
                }
            };
        }
        private void smartButton1_Click_1(object sender, EventArgs e)
        {
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
            selectedTask.ratingFactors = codeQualityChoices.GetRatingFactors();
            selectedTask.isTabLocked = tabNavigationLocked.Checked;
            Server server = new Server(serverName.Texts.Trim(), serverPW.Texts, selectedTask, language.SelectedItem.ToString(), userProfiles);

            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.AutoScroll = true;
            SystemSingleton.Instance.page1.Controls.Add(new MainServerPage2(server));
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



    }
}
