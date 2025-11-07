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
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public Dictionary<string, StudentSubmittedIcon> codeSubmission { get; private set; }
        private int submittedCount;
        private List<UserProfile> submittedStudents;
        public Dictionary<string, SubmittedCode> codeSubmissions { get; private set; }
        private System.Threading.Timer displayIcons;
        private readonly List<string> ratingFactors = new List<string>()
        {
            "",
            "Accuracy",
            "Readability",
            "Robustness",
            "Maintainability",
            "Total Score"
        };
        public ProgressSubmissionPage(Dictionary<string, SubmittedCode> codeSubmissions)
        {
            InitializeComponent();
            submittedStudents = codeSubmissions.Select(cs => cs.Value.user).ToList();
            submitCount.Text = codeSubmissions.Count.ToString();
            this.codeSubmissions = codeSubmissions;
            this.codeSubmissions = this.codeSubmissions.OrderBy(cs => cs.Value.placement).ToDictionary();
            if (this.codeSubmissions != null)
                submitCount.Text = this.codeSubmissions.Count.ToString();
            Load += (sender, e) =>
            {
                foreach(var submissionIcon in this.codeSubmissions.Values)
                {
                    StudentSubmitted(submissionIcon);
                }

                displayIcons?.Change(Timeout.Infinite, Timeout.Infinite);

                displayIcons = new System.Threading.Timer((e) =>
                {
                    DisplayIcons();
                }, null, 500, Timeout.Infinite);
            };
        }

        public ProgressSubmissionPage()
        {
            InitializeComponent();
            submittedStudents = new List<UserProfile>();
            submittedCount = 0;
            codeSubmissions = new Dictionary<string, SubmittedCode>();
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
                    codeSubmissions[submitted.user._studentId].placement = codeSubmissions.Count;
                    codeSubmissions =  codeSubmissions.OrderBy(cs => cs.Value.placement)
                                                          .ToDictionary(cs => cs.Key, cs => cs.Value);
                }
                else
                {
                    submittedCount++;
                    submitted.placement = submittedCount;
                    codeSubmissions.Add(submitted.user._studentId, submitted);
                    submittedStudents.Add(submitted.user);
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
            var filteredSubmitted = codeSubmissions.Keys.
                Where(studentId => studLists.Any(stud => stud._studentId == studentId)).
                Select(studentId => codeSubmissions[studentId]).
                ToList();
            this.Invoke((Action)(() =>
            {
                submittedContainer.Controls.Clear();
                filteredSubmitted.ForEach(studentSubmission => 
                {
                    submittedContainer.Controls.Add(new StudentSubmittedIcon(studentSubmission, UpdateDisplaySync));
                });
            }));
        }
        private void UpdateDisplaySync(SubmittedCode submittedCode)
        {
            studentName.Text = submittedCode.user._studentName;
            score.Text = submittedCode.progress.codeRating.totalRating.ToString();
            studentCode.Text = submittedCode.progress.sourceCode;

            materialListView1.Items.Clear();
            submittedCode.progress.codeRating.statsGrade.ToList().ForEach(kv =>
            {
                materialListView1.Items.Add(new ListViewItem(new string[] { ratingFactors[kv.Key], kv.Value.ToString("0.00") }));
            });
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
