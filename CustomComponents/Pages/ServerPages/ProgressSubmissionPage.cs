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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ProgressSubmissionPage : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, StudentSubmittedIcon> codeSubmission { get; private set; }
        private int submittedCount;
        private List<UserProfile> submittedStudents;
        private System.Threading.Timer displayIcons;
        private readonly List<string> ratingFactors = new List<string>()
        {
            "",
            "Accuracy",
            "Readability",
            "Efficiency",
            "Complexity",
            "Total Score"
        };
        public ProgressSubmissionPage(List<SubmittedCode> codeSubmissions)
        {
            InitializeComponent();
            submittedStudents = new List<UserProfile>();
            codeSubmission = new Dictionary<string, StudentSubmittedIcon>();
            submitCount.Text = codeSubmissions.Count.ToString();
            Load += (sender, e) =>
            {
                codeSubmissions.ForEach(submissionIcon =>
                {
                    StudentSubmitted(submissionIcon);
                });
            };
        }

        public ProgressSubmissionPage()
        {
            InitializeComponent();
            submittedStudents = new List<UserProfile>();
            submittedCount = 0;
            codeSubmission = new Dictionary<string, StudentSubmittedIcon>();
        }

        public void StudentSubmitted(SubmittedCode submitted)
        {
            Task.Run(() =>
            {
                //if student already submitted before
                if (codeSubmission.ContainsKey(submitted.user._studentId))
                {
                    var submissionIcon = codeSubmission[submitted.user._studentId];
                    int currentPlacement = submissionIcon.currentPlacement;//get the current placement, placement belows will be updated(+1 placement)
                    codeSubmission.Values.
                        Where(subIcon => subIcon.currentPlacement > currentPlacement).//filter out the submitted codes later than the newly updated
                        ToList().
                        ForEach(sub => sub.IncreasePlacement()); //iterate each, will just update the placement(+1 rank)

                    this.Invoke((Action)(() =>
                    {
                        submissionIcon.UpdatePlacement(codeSubmission.Count, submitted.sourceCode);
                        //submittedContainer.Controls.Remove(submissionIcon);
                        //submittedContainer.Controls.Add(submissionIcon);
                    }));
                }
                else
                {
                    submittedCount++;
                    var updateDisplayAction = new Action(() => UpdateDisplay(submitted.progress, submitted.user));
                    codeSubmission.Add(submitted.user._studentId,
                        new StudentSubmittedIcon(submitted, submittedCount, updateDisplayAction));
                    submittedStudents.Add(submitted.user);
                    this.Invoke((Action)(() =>
                    {
                        //submittedContainer.Controls.Add(codeSubmission[submitted.user._studentId]);
                        submitCount.Text = (int.Parse(submitCount.Text) + 1).ToString();
                    }
                    ));
                }
                displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);

                displayIcons = new System.Threading.Timer((e) =>
                {
                    DisplayIcons();
                }, null, 500, Timeout.Infinite);
            });
        }

        private void DisplayIcons()
        {
            string search = searchBox.Texts.ToLower();
            var studLists = submittedStudents.
                Where(student => student._studentName.ToLower().Contains(search) ||
                student._studentId.ToLower().Contains(search)).
                ToList();
            var filteredIcons = codeSubmission.Keys.
                Where(studentId => studLists.Any(stud => stud._studentId == studentId)).
                Select(studentId => codeSubmission[studentId]).
                ToList();
            this.Invoke((Action)(() =>
            {
                submittedContainer.Controls.Clear();
                filteredIcons.ForEach(icon =>
                {
                    submittedContainer.Controls.Add(icon);
                });
            }));
        }

        public List<SubmittedCode> GetAllSubmitted()
        {
            return codeSubmission.Values.Select(item => item.submittedCode).ToList();
        }

        private Task UpdateDisplay(StudentCodingProgress progress, UserProfile student)
        {
            this.Invoke((Action)(() =>
            {
                studentName.Text = student._studentName;
                score.Text = progress.codeRating.totalRating.ToString();
                studentCode.Text = progress.sourceCode;
                materialListView1.Items.Clear();
                progress.codeRating.statsGrade.ToList().ForEach(kv =>
                {
                    materialListView1.Items.Add(new ListViewItem(new string[] { ratingFactors[kv.Key], kv.Value.ToString("0.00") }));
                });
            }));

            return Task.CompletedTask;
        }

        private void btn_viewmore_Click(object sender, EventArgs e)
        {
            var ViewMoreForm = new ViewMoreSubmissionsForm();
            ViewMoreForm.ShowDialog();
        }

        private void searchBox__TextChanged(object sender, EventArgs e)
        {
            displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);

            displayIcons = new System.Threading.Timer((e) =>
            {
                DisplayIcons();
            }, null, 500, Timeout.Infinite);
        }
    }
}
