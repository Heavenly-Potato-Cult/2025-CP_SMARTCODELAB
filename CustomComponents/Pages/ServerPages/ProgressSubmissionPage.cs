using Microsoft.VisualBasic.ApplicationServices;
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
using SmartCodeLab.CustomComponents.CustomDialogs;
using System.Diagnostics;
using System.Windows.Navigation;
using System.Windows.Documents;
using SmartCodeLab.Models.Enums;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ProgressSubmissionPage : UserControl
    {
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, StudentSubmittedIcon> codeSubmissionIcon { get; private set; }
        private Int32 leaderboardsVersion;
        private int submittedCount;
        private List<UserProfile> submittedStudents;
        public Dictionary<string, SubmittedCode> codeSubmissions { get; private set; }
        private System.Threading.Timer displayIcons;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<string,StudentCodingProgress> progressGetter { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<int, decimal[]> ratingFactorsWeight { get; set; }
        private string selectedStudentId;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        string language;
        public ProgressSubmissionPage(Dictionary<string, SubmittedCode> codeSubmissions,
            Dictionary<int, decimal[]> ratingFactorsWeight, 
            LanguageSupported languageSupported,
            Dictionary<string, StudentCodingProgress> userProgress)
        {
            InitializeComponent();
            codeSubmissionIcon = new Dictionary<string, StudentSubmittedIcon>();
            progressGetter = (string id) =>
            {
                // return something based on id
                try
                {
                    return userProgress[id];
                }
                catch (KeyNotFoundException) { return new StudentCodingProgress(); }
            };

            language = languageSupported.ToString().ToLower();
            this.ratingFactorsWeight = ratingFactorsWeight;
            setTheStats();
            leaderboardsVersion = 0;
            submittedStudents = codeSubmissions.Select(cs => cs.Value.user).ToList();
            submitCount.Text = codeSubmissions.Count.ToString();
            this.codeSubmissions = codeSubmissions;
            this.codeSubmissions = this.codeSubmissions.OrderBy(cs => cs.Value.placement).ToDictionary();
            if (this.codeSubmissions != null)
                submitCount.Text = this.codeSubmissions.Count.ToString();


            Load += (sender, e) =>
            {
                DisplayIcons();
            };

            searchBox.innerTextBox.TextChanged += (sender, e) =>
            {
                displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);

                displayIcons = new System.Threading.Timer((e) =>
                {
                    DisplayIcons();
                }, null, 500, Timeout.Infinite);
            };
        }
        public Action<TaskModel, List<SubmittedCode>, string> leaderboardsUpdate;
        public ProgressSubmissionPage()
        {
            InitializeComponent();
            selectedStudentId = string.Empty;
            leaderboardsVersion = 0;
            submittedStudents = new List<UserProfile>();
            submittedCount = 0;
            codeSubmissions = new Dictionary<string, SubmittedCode>();
            codeSubmissionIcon = new Dictionary<string, StudentSubmittedIcon>();
            studentCodeRating1.gradeEdited = updateScores;
            searchBox.innerTextBox.TextChanged += (sender, e) =>
            {
                displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);

                displayIcons = new System.Threading.Timer((e) =>
                {
                    DisplayIcons();
                }, null, 500, Timeout.Infinite);
            };
        }

        private Task nonBlockingotif(string msg)
        {
            string message = msg;
            return Task.Run(() =>
            {
                this.BeginInvoke((Action)(() => MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)));
            });
        }

        public async void StudentSubmitted(SubmittedCode submitted)
        {
            await Task.Run(() =>
            {
                if (codeSubmissions.ContainsKey(submitted.user._studentId))
                {
                    var toUpdate = codeSubmissions.Where(cs => cs.Value.placement > codeSubmissions[submitted.user._studentId].placement);
                    foreach (var kvp in toUpdate)
                    {
                        codeSubmissions[kvp.Key].placement--;
                    }
                    codeSubmissions[submitted.user._studentId] = submitted;
                    codeSubmissions[submitted.user._studentId].placement = submittedCount;
                }
                else
                {
                    submitted.placement = ++submittedCount;
                    codeSubmissions.Add(submitted.user._studentId, submitted);
                    submittedStudents.Add(submitted.user);
                    this.Invoke((Action)(() => submitCount.Text = submittedCount.ToString()));
                }

                if(selectedStudentId == submitted.user._studentId)
                    this.Invoke((Action)(() =>
                    {
                        UpdateDisplaySync(submitted);
                    }));

                displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);
                displayIcons = new System.Threading.Timer((e) =>
                {
                    leaderboardsUpdate?.Invoke(null, codeSubmissions.Select(sub => sub.Value.getPlacement()).ToList(), null);
                    DisplayIcons();
                }, null, 500, Timeout.Infinite);
            });
        }

        private void DisplayIcons()
        {
            _ = Task.Run(() => {
                this.Invoke((Action)(() =>
                {
                    string search = searchBox.Text.ToLower();

                    var studLists = submittedStudents.
                        Where(student => student._studentName.ToLower().Contains(search) ||
                        student._studentId.ToLower().Contains(search)).
                        ToList();
                    var filteredSubmitted = codeSubmissions.Keys.
                        Where(studentId => studLists.Any(stud => stud._studentId == studentId)).
                        Select(studentId => codeSubmissions[studentId]).
                        ToList();
                    int currentVersion = ++leaderboardsVersion;
                    bool isSortByPoints = customComboBox2.SelectedItem?.ToString() == "Points";
                    //do the sorting thing
                    filteredSubmitted = isSortByPoints ? filteredSubmitted.OrderBy(sub => sub.score).ToList() :
                                                            filteredSubmitted.OrderByDescending(sub => sub.placement).ToList();

                    submittedContainer.Controls.Clear();
                    foreach (var studentSubmission in filteredSubmitted)
                    {
                        if (currentVersion != leaderboardsVersion)
                            break;
                        var studentSubmittedIcon = new StudentSubmittedIcon(studentSubmission, UpdateDisplaySync) { Dock = DockStyle.Top };
                        codeSubmissionIcon[studentSubmission.user._studentId] = studentSubmittedIcon;
                        submittedContainer.Controls.Add(studentSubmittedIcon);
                    }
                }));
            });
        }

        public void setTheStats()
        {
            studentCodeRating1.SetStats(ratingFactorsWeight);
        }

        private void UpdateDisplaySync(SubmittedCode submittedCode)
        {
            selectedStudentId = submittedCode.user._studentId;
            steamLabel2.Text = submittedCode.user._studentName;
            score.Text = submittedCode.score.ToString();
            studentCode.Text = submittedCode.sourceCode;
            studentCodeRating1.setSubmissionScores(submittedCode.statsGrade);

            var studentProgress = progressGetter.Invoke(submittedCode.user._studentId);
            copypastedCodes.Controls.Clear();
            if (studentProgress.pastedCode != null)
            {
                try
                {
                    copypastedCodes.SuspendLayout();
                    foreach (var item in studentProgress.pastedCode)
                    {
                        var icon = new PastedCodeIcon(item)
                        {
                            Dock = DockStyle.Top
                        };
                        copypastedCodes.Controls.Add(icon);
                    }
                }
                finally
                {
                    copypastedCodes.ResumeLayout();
                }
            }
        }

        private void updateScores()
        {
            if (selectedStudentId == null || selectedStudentId == "") return;
            codeSubmissions[selectedStudentId].isEdited = true;
            codeSubmissions[selectedStudentId].statsGrade = studentCodeRating1.GetStats();
            codeSubmissions[selectedStudentId].score = studentCodeRating1.totalScore();
            this.Invoke(new Action(() => 
            { 
                score.Text = codeSubmissions[selectedStudentId].score.ToString();
                codeSubmissionIcon[selectedStudentId].updateScore(codeSubmissions[selectedStudentId].score);
            }));
        }

        private void customComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);
            displayIcons = new System.Threading.Timer((e) =>
            {
                DisplayIcons();
            }, null, 500, Timeout.Infinite);
        }
    }
}
