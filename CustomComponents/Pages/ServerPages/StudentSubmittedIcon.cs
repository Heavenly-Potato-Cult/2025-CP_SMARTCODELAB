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
        private Action<SubmittedCode> updateDisplayClick;
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
            this.updateDisplayClick = updateDisplayClick;
            this.submittedCode = submittedCode;
            currentPlacement = submittedCode.placement;
            placing.Text = submittedCode.placement.ToString();
            name.Text = submittedCode.user._studentName;
            score.Text = submittedCode.score.ToString();

            customCard3.Click += SelectThisUser;
            name.Click += SelectThisUser;
            placing.Click += SelectThisUser;
            indicator.Click += SelectThisUser;
            score.Click += SelectThisUser;


        }

        private void SelectThisUser(object sender, EventArgs e)
        {
            updateDisplayClick?.Invoke(this.submittedCode);
            indicator.BackColor = SelectedIndicator;
        }
    }
}
