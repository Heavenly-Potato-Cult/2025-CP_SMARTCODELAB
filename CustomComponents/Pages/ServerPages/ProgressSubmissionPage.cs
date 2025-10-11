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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class ProgressSubmissionPage : UserControl
    {
        public Dictionary<string, StudentSubmittedIcon> codeSubmission;
        private int submittedCount;
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
                    submissionIcon.UpdatePlacement(submittedCount);
                }
                else
                {
                    submittedCount++;
                    codeSubmission.Add(submitted.user._studentId, new StudentSubmittedIcon(submitted, submittedCount));
                    this.Invoke((Action)(() => submittedContainer.Controls.Add(codeSubmission[submitted.user._studentId]) ));
                }
            });
        }
    }
}
