using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class CodeQualityChoices2 : RoundedUserControl
    {
        public CodeQualityChoices2()
        {
            InitializeComponent();

            SetupTrackBar(accuracyTrackBar, 100);
            SetupTrackBar(readabilityTrackBar, 0);
            SetupTrackBar(efficiencyTrackBar, 0);
            SetupTrackBar(logicalComplexityTrackBar, 0);

            InitializeGradingControls();

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
            LinkTrackBarToLabel(accuracyTrackBar, accuracyLabel);
            LinkTrackBarToLabel(readabilityTrackBar, readabilityLabel);
            LinkTrackBarToLabel(efficiencyTrackBar, efficiencyLabel);
            LinkTrackBarToLabel(logicalComplexityTrackBar, logicalComplexityLabel);
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
    }
}
