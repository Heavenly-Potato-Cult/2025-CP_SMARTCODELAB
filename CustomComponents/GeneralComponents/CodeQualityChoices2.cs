using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.SteamThings;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class CodeQualityChoices2 : UserControl
    {

        private int complexity_standard;
        private int total_standard_operators;
        private int unallocated;
        public string bestSourceCode { get; private set; }

        private string language { get; set; }

        private Dictionary<SteamTrackBar, int> recentValue;
        public CodeQualityChoices2()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                  ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            InitializeComponent();
            language = string.Empty;
            complexity_standard = 0;
            bestSourceCode = "";
            total_standard_operators = 0;
            recentValue = new Dictionary<SteamTrackBar, int>()
            {
                {accuracyT, 100 },
                {efficiencyT, 0 },
                {robustnessT, 0 },
                {maintainabilityT, 0 }
            };

            unallocated = 0;
            SetupTrackBar(accuracyT, 100);
            SetupTrackBar(efficiencyT, 0);
            SetupTrackBar(robustnessT, 0);
            SetupTrackBar(maintainabilityT, 0);

            InitializeGradingControls();
            foreach (var item in Controls.OfType<CheckBox>().Union<Control>(Controls.OfType<SteamTrackBar>()))
            {
                item.LostFocus += (s, e) =>
                {
                    putUnallocatedToAccuracy();
                };
            }

            foreach (var item in new List<SteamTrackBar>(){
                accuracyT,
                efficiencyT,
                robustnessT,
                maintainabilityT
            })
            {
                item.ValueChanged += (sender, e) =>
                {
                    unallocated += recentValue[item] - item.Value;

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

            foreach (var trackBar in new List<SteamTrackBar> { accuracyT, efficiencyT, robustnessT, maintainabilityT })
            {
                // Subscribe to the new "ValueChanging" event
                trackBar.ValueChanging += OnTrackBarValueChanging;

                // Subscribe to the standard ValueChanged just for updating labels
                trackBar.ValueChanged += AnyTrackBar_ValueChanged;
            }

            // Initial Updates
            UpdateLabels();

        }

        public void putUnallocatedToAccuracy()
        {
            if (!IsFocusWithUs())
                accuracyT.Value = 100;
        }
        private void OnTrackBarValueChanging(object sender, ValueChangingEventArgs e)
        {
            if (sender is not SteamTrackBar currentBar) return;

            // 1. Calculate the sum of ALL OTHER bars (excluding the one we are dragging)
            int otherSum = 0;

            if (accuracyT != currentBar) otherSum += accuracyT.Value;
            if (efficiencyT != currentBar && efficiencyCB.Checked) otherSum += efficiencyT.Value;
            if (robustnessT != currentBar && robustnessBox.Checked) otherSum += robustnessT.Value;
            if (maintainabilityT != currentBar && maintainabilityCB.Checked) otherSum += maintainabilityT.Value;

            // 2. Calculate how much budget is left for THIS bar
            int maxAllowed = 100 - otherSum;

            // 3. If the mouse tries to go higher than allowed, CLAMP IT.
            if (e.NewValue > maxAllowed)
            {
                e.NewValue = maxAllowed; // Force the value to stop at the limit
            }
        }

        public void setLanguage(string language)
        {
            if (language == "None")
                return;
            this.language = language;
        }
        private void SetupTrackBar(SteamTrackBar trackBar, int defaultValue = 0)
        {

            if (trackBar == null)
            {
                return;
            }

            trackBar.Maximum = 100;
            trackBar.Value = defaultValue;
        }

        private void AnyTrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (sender is not SteamTrackBar trackBar) return;
            if (trackBar.Tag is not Label targetLabel) return;

            string newText = $"{trackBar.Value}%";
            if (targetLabel.Text != newText) targetLabel.Text = newText;
        }

        private void UpdateLabels()
        {
            // Helper to refresh all labels at start
            accuracyLabel.Text = $"{accuracyT.Value}%";
            readabilityLabel.Text = $"{efficiencyT.Value}%";
            efficiencyLabel.Text = $"{robustnessT.Value}%";
            logicalComplexityLabel.Text = $"{maintainabilityT.Value}%";
        }
        private void InitializeGradingControls()
        {
            LinkTrackBarToLabel(accuracyT, accuracyLabel);
            LinkTrackBarToLabel(efficiencyT, readabilityLabel);
            LinkTrackBarToLabel(robustnessT, efficiencyLabel);
            LinkTrackBarToLabel(maintainabilityT, logicalComplexityLabel);
        }

        private void LinkTrackBarToLabel(SteamTrackBar trackBar, Label label)
        {

            if (trackBar == null || label == null)
            {
                return;
            }

            trackBar.Tag = label;

            trackBar.ValueChanged += AnyTrackBar_ValueChanged;

        }

        private void robustnessBox_CheckedChanged_1(object sender, EventArgs e)
        {
            robustnessT.Enabled = robustnessBox.Checked;
            if (!robustnessBox.Checked)
                IlostMyValueT_T(robustnessT);
        }

        private void efficiencyCB_CheckedChanged(object sender, EventArgs e)
        {
            if(efficiencyCB.Checked && string.IsNullOrEmpty(language))
            {
                System.Windows.Forms.MessageBox.Show("Please set the programming language first before calculating efficiency.", "Language Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                efficiencyCB.Checked = false;
                return;
            }

            efficiencyT.Enabled = efficiencyCB.Checked;
            if (efficiencyCB.Checked && total_standard_operators == 0)
                openComplexityDialog(efficiencyCB);

            if (!efficiencyCB.Checked)
            {
                IlostMyValueT_T(efficiencyT);
            }
        }

        private void maintainabilityCB_CheckedChanged(object sender, EventArgs e)
        {
            if(maintainabilityCB.Checked && string.IsNullOrEmpty(language))
            {
                System.Windows.Forms.MessageBox.Show("Please set the programming language first before calculating maintainability.", "Language Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maintainabilityCB.Checked = false;
                return;
            }


            maintainabilityT.Enabled = maintainabilityCB.Checked;
            if (maintainabilityCB.Checked && complexity_standard == 0)
                openComplexityDialog(maintainabilityCB);

            if (!maintainabilityCB.Checked)
            {
                IlostMyValueT_T(maintainabilityT);
            }
        }

        public Dictionary<int, decimal[]> GetRatingFactors()
        {
            var ratingFactors = new Dictionary<int, decimal[]>()
            {
                {1, [accuracyT.Value] },
            };
            if (efficiencyCB.Checked)
                ratingFactors.Add(2, [efficiencyT.Value, total_standard_operators]);
            if (robustnessBox.Checked)
                ratingFactors.Add(3, [robustnessT.Value]);
            if (maintainabilityCB.Checked)
                ratingFactors.Add(4, [maintainabilityT.Value, complexity_standard]);

            return ratingFactors;
        }

        private void IlostMyValueT_T(SteamTrackBar bar)
        {
            bar.Value = 0;
        }

        private bool IsFocusWithUs()
        {
            return Controls.OfType<CheckBox>().Union<Control>(Controls.OfType<SteamTrackBar>())
                        .Any(control => control.Focused);
        }

        private void openComplexityDialog(CheckBox sender)
        {
            var counterDialog = new CodeComplexityReference(language, bestSourceCode);
            if (counterDialog.ShowDialog() == DialogResult.OK)
            {
                total_standard_operators = counterDialog.total_operator_count;
                complexity_standard = counterDialog.total_cyclomatic_complexity;
                bestSourceCode = counterDialog.sourceCode;
                counterDialog.Close();
            }
            else
            {
                sender?.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openComplexityDialog(null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // WS_EX_COMPOSITED: Forces double-buffering on the entire hierarchy
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }
}
