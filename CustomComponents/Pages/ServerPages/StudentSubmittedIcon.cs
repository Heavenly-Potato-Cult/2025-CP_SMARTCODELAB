using SmartCodeLab.CustomComponents.GeneralComponents;
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
    public partial class StudentSubmittedIcon : RoundedUserControl
    {
        private SubmittedCode submittedCode;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int currentPlacement { get; set; }
        public StudentSubmittedIcon(SubmittedCode submittedCode, int placement)
        {
            InitializeComponent();
            this.submittedCode = submittedCode;
            currentPlacement = placement;
            placing.Text = placement.ToString();
            name.Text = submittedCode.user._studentName;
        }

        public void UpdatePlacement(int newPlacement)
        {
            submittedCode.placement = newPlacement;
            currentPlacement = newPlacement;
        }

        public void IncreasePlacement() 
        {
            this.Invoke((Action)(() => submittedCode.IncreasePlacement() ));
        }
    }
}
