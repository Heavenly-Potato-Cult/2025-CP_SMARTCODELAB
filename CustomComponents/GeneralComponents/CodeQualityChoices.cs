using SmartCodeLab.CustomComponents.CustomDialogs;
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

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class CodeQualityChoices : UserControl
    {
        private int complexity_sandard;
        public CodeQualityChoices()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (complexity.Checked) 
            {
                var ccr = new CodeComplexityReference();
                ccr.ShowDialog();
                complexity_sandard = ccr.total_cyclomatic_complexity;
                complexity.Checked = ccr.DialogResult == DialogResult.OK;
            }
        }

        public Dictionary<int,int> GetRatingFactors()
        {
            var ratingFactors = new Dictionary<int, int>() 
            {
                { 0, 0 },
            };

            if (accuracy.Checked)
                ratingFactors.Add(1, 0);
            if(readability.Checked)
                ratingFactors.Add(2, 0);
            if(efficiency.Checked)
                ratingFactors.Add(3, 0);
            if(complexity.Checked)
                ratingFactors.Add(4, complexity_sandard);

            return ratingFactors;
        }
    }
}
