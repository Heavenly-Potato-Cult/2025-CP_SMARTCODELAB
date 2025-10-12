using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ToDelete : Form
    {
        private int submittedCount;
        public Dictionary<string, StudentSubmittedIcon> codeSubmission;

        public ToDelete()
        {
            InitializeComponent();
            codeSubmission = new Dictionary<string, StudentSubmittedIcon>();
            submittedCount = 1;
            foreach (var item in submittedCodesSample())
            {
                var submissionIcon = new StudentSubmittedIcon(item, submittedCount);
                codeSubmission.Add(item.user._studentId, submissionIcon);
                submittedContainer.Controls.Add(submissionIcon);
                submittedCount++;

            }
        }

        public void StudentSubmitted(string userId)
        {
            Task.Run(() =>
            {
                //if student already submitted before
                if (codeSubmission.ContainsKey(userId))
                {
                    var submissionIcon = codeSubmission[userId];
                    int currentPlacement = submissionIcon.currentPlacement;//get the current placement, placement belows will be updated(+1 placement)
                    codeSubmission.Values.
                        Where(subIcon => subIcon.currentPlacement > currentPlacement).//filter out the submitted codes later than the newly updated
                        ToList().
                        ForEach(sub => sub.IncreasePlacement()); //iterate each, will just update the placement(+1 rank)

                    this.Invoke((Action)(() =>
                    {
                        submissionIcon.UpdatePlacement(codeSubmission.Count, "");
                        submittedContainer.Controls.Remove(submissionIcon);
                        submittedContainer.Controls.Add(submissionIcon);
                    }));
                }
            });
        }

        public List<SubmittedCode> submittedCodesSample()
        {
            return new List<SubmittedCode>()
            {
                {new SubmittedCode("",new UserProfile("s1","1",""))},
                {new SubmittedCode("",new UserProfile("s2","2",""))},
                {new SubmittedCode("",new UserProfile("s3","3",""))},
                {new SubmittedCode("",new UserProfile("s4","4",""))},
                {new SubmittedCode("",new UserProfile("s5","5",""))},
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentSubmitted(textBox1.Text);
        }
    }
}
