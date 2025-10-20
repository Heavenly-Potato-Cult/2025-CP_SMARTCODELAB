using SmartCodeLab.CustomComponents.CustomDialogs;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class CodeQualityChoices : UserControl
    {
        private int complexity_sandard;
        private decimal unallocated;

        public CodeQualityChoices()
        {
            InitializeComponent();
            unallocated = 0;

            foreach (var item in new List<CustomNumericUpDown>(){
                accuracyW,
                readabilityW,
                efficiencyW,
                complexityW
            })
            {
                item.remainingUnallocated = IsUnallocatedZero;
                item.updateUnallocatedValue =
                    new Action<decimal>((value) =>
                    {
                        unallocated += value;
                    });
            }
        }

        public decimal IsUnallocatedZero()
        {
            return unallocated;
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
            complexityW.Enabled = complexity.Checked;
            if (!complexity.Checked)
            {
                complexityW.Value = 0;
                unallocatedToAccuracy();
            }
        }

        public Dictionary<int, decimal[]> GetRatingFactors()
        {
            var ratingFactors = new Dictionary<int, decimal[]>()
            {
                {1, [accuracyW.Value] }
            };

            if (readability.Checked)
                ratingFactors.Add(2, [readabilityW.Value]);
            if (efficiency.Checked)
                ratingFactors.Add(3, [efficiencyW.Value]);
            if (complexity.Checked)
                ratingFactors.Add(4, [complexityW.Value, complexity_sandard]);

            return ratingFactors;
        }

        private void readability_CheckedChanged(object sender, EventArgs e)
        {
            readabilityW.Enabled = readability.Checked;
            if (!readability.Checked)
            {
                readabilityW.Value = 0;
                unallocatedToAccuracy();
            }
        }

        private void efficiency_CheckedChanged(object sender, EventArgs e)
        {
            efficiencyW.Enabled = efficiency.Checked;
            if (!efficiency.Checked)
            {
                efficiencyW.Value = 0;
                unallocatedToAccuracy();
            }
        }

        public void unallocatedToAccuracy()
        {
            accuracyW.InheritValues(unallocated);
        }
    }
}
