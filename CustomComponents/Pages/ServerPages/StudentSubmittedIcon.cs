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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class StudentSubmittedIcon : RoundedUserControl
    {
        public SubmittedCode submittedCode;
        private Color SelectedIndicator = Color.FromArgb(26, 191, 32);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int currentPlacement
        {
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
            customCard3.Click += SelectThisUser;
            name.Click += SelectThisUser;
            placing.Click += SelectThisUser;
            indicator.Click += SelectThisUser;
            score.Click += SelectThisUser;
            panel1.Click += SelectThisUser;

        }

        private void SelectThisUser(object sender, EventArgs e)
        {

            //if (customCard3.BackColor == DefaultColor)
            //{

               
                indicator.BackColor = SelectedIndicator;


                //_onSelectCallback?.Invoke(this.profile, this);
                //setSelectedUserId?.Invoke(this.profile, this);

            //}
        }
    }
}
