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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ProgressSubmissionPage : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, StudentSubmittedIcon> codeSubmission { get; private set; }
        private int submittedCount;

        public ProgressSubmissionPage(List<SubmittedCode> codeSubmissions)
        {
            InitializeComponent();
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
                        submittedContainer.Controls.Remove(submissionIcon);
                        submittedContainer.Controls.Add(submissionIcon);
                    }));
                }
                else
                {
                    submittedCount++;
                    var updateDisplayAction = new Action(() => UpdateDisplay(submitted.progress, submitted.user));
                    codeSubmission.Add(submitted.user._studentId,
                        new StudentSubmittedIcon(submitted, submittedCount, updateDisplayAction));
                    this.Invoke((Action)(() =>
                    {
                        submittedContainer.Controls.Add(codeSubmission[submitted.user._studentId]);
                        submitCount.Text = (int.Parse(submitCount.Text) + 1).ToString();
                    }
                    ));
                }
            });
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
            }));

            return Task.CompletedTask;
        }

        private void btn_viewmore_Click(object sender, EventArgs e)
        {
            var ViewMoreForm = new ViewMoreSubmissionsForm();
            ViewMoreForm.ShowDialog();
        }
    }
}
