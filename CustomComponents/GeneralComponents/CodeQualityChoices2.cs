using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class CodeQualityChoices2 : RoundedUserControl
    {

        private int complexity_sandard;
        private int unallocated;
        private Dictionary<TrackBar, int> recentValue;
        public CodeQualityChoices2()
        {
            InitializeComponent();

            recentValue = new Dictionary<TrackBar, int>()
            {
                {accuracyT, 100 },
                {readabilityT, 0 },
                {robustnessT, 0 },
                {maintainabilityT, 0 }
            };

            unallocated = 0;
            SetupTrackBar(accuracyT, 100);
            SetupTrackBar(readabilityT, 0);
            SetupTrackBar(robustnessT, 0);
            SetupTrackBar(maintainabilityT, 0);

            InitializeGradingControls();

            foreach (var item in new List<TrackBar>(){
                accuracyT,
                readabilityT,
                robustnessT,
                maintainabilityT
            })
            {
                item.ValueChanged += (sender, e) =>
                {
                    unallocated +=  recentValue[item] - item.Value;

                    if (unallocated < 0)
                    {
                        int val = item.Value + unallocated;
                        recentValue[item] = val;
                        unallocated = 0;
                        item.Value = recentValue[item];
                    }
                    recentValue[item] = item.Value;
                };
            }

        }
        private void SetupTrackBar(TrackBar trackBar, int defaultValue = 0)
        {

            if (trackBar == null)
            {
                return;
            }

            trackBar.Minimum = 0;
            trackBar.Maximum = 100;
            trackBar.Value = defaultValue;
        }

        private void AnyTrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (sender is not TrackBar trackBar)
            {
                return;
            }


            if (trackBar.Tag is not Label targetLabel)
            {
                return;
            }

            // 3. Update the label's text with the new value.
            targetLabel.Text = $"{trackBar.Value}%";
        }
        private void InitializeGradingControls()
        {
            LinkTrackBarToLabel(accuracyT, accuracyLabel);
            LinkTrackBarToLabel(readabilityT, readabilityLabel);
            LinkTrackBarToLabel(robustnessT, efficiencyLabel);
            LinkTrackBarToLabel(maintainabilityT, logicalComplexityLabel);
        }

        private void LinkTrackBarToLabel(TrackBar trackBar, Label label)
        {

            if (trackBar == null || label == null)
            {
                return;
            }


            trackBar.Tag = label;


            trackBar.ValueChanged += AnyTrackBar_ValueChanged;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            maintainabilityT.Enabled = maintainabilityBox.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            readabilityT.Enabled = readabilityBox.Checked;
        }

        public Dictionary<int, decimal[]> GetRatingFactors()
        {
            var ratingFactors = new Dictionary<int, decimal[]>()
            {
                {1, [accuracyT.Value] },
            };

            if (readabilityBox.Checked)
                ratingFactors.Add(2, [readabilityT.Value]);
            if (robustnessBox.Checked)
                ratingFactors.Add(3, [robustnessT.Value]);
            if (maintainabilityBox.Checked)
                ratingFactors.Add(4, [maintainabilityT.Value, complexity_sandard]);

            return ratingFactors;
        }

        private void CodeQualityChoices2_Load(object sender, EventArgs e)
        {

        }
    }
}
