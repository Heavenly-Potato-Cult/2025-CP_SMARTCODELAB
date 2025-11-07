using ProtoBuf;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class StudentSubmittedIcon : RoundedUserControl
    {
        public SubmittedCode submittedCode;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int currentPlacement {
            get => submittedCode.placement;
            set
            {
                submittedCode.placement = value;
            }
        }

        public StudentSubmittedIcon(SubmittedCode submittedCode, Action<SubmittedCode> updateDisplayClick = null)
        {
            InitializeComponent();
            this.submittedCode = submittedCode;
            currentPlacement = submittedCode.placement;
            placing.Text = submittedCode.placement.ToString();
            name.Text = submittedCode.user._studentName;
            score.Text = submittedCode.progress.codeRating.totalRating.ToString(); //the codeStats[5] contains the student score

            this.Click += (sender, e) => updateDisplayClick?.Invoke(submittedCode);
        }

        public void UpdatePlacement(int newPlacement, string newSourceCode)
        {
            currentPlacement = newPlacement;
            placing.Text = newPlacement.ToString();
            submittedCode.sourceCode = newSourceCode;
        }

        public void IncreasePlacement() 
        {
            this.Invoke((Action)(() => { 
                currentPlacement--;
                placing.Text = currentPlacement.ToString();
            } ));
        }
    }
}
