using SmartCodeLab.CustomComponents.CustomDialogs;
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
    public partial class CodeQualityChoices2 : RoundedUserControl
    {

        private int complexity_standard;
        private int total_standard_operators;
        private int unallocated;
        public string bestSourceCode { get; private set; }

        private string language { get; set; }

        private Dictionary<TrackBar, int> recentValue;
        public CodeQualityChoices2()
        {
            InitializeComponent();
            complexity_standard = 0;
            bestSourceCode = "";
            total_standard_operators = 0;
            recentValue = new Dictionary<TrackBar, int>()
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
            foreach (var item in Controls.OfType<CheckBox>().Union<Control>(Controls.OfType<TrackBar>()))
            {
                item.LostFocus += (s, e) =>
                {
                    if (!IsFocusWithUs())
                        accuracyT.Value = 100;
                };
            }

            foreach (var item in new List<TrackBar>(){
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

        }

        public void setLanguage(string language)
        {
            efficiencyCB.Enabled = true;
            maintainabilityCB.Enabled = true;
            this.language = language;
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
            LinkTrackBarToLabel(efficiencyT, readabilityLabel);
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

        private void robustnessBox_CheckedChanged_1(object sender, EventArgs e)
        {
            robustnessT.Enabled = robustnessBox.Checked;
            if (!robustnessBox.Checked)
                IlostMyValueT_T(robustnessT);
        }

        private void efficiencyCB_CheckedChanged(object sender, EventArgs e)
        {
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

        private void IlostMyValueT_T(TrackBar bar)
        {
            bar.Value = 0;
        }

        private bool IsFocusWithUs()
        {
            return Controls.OfType<CheckBox>().Union<Control>(Controls.OfType<TrackBar>())
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

        public string GetLocalIPv4()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "No IPv4 address found";
        }

        public static IPAddress GetSubnetMaskForIP(IPAddress ipAddress)
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus != OperationalStatus.Up)
                    continue;

                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation unicastAddress in ipProperties.UnicastAddresses)
                {
                    if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork &&
                        unicastAddress.Address.Equals(ipAddress))
                    {
                        return unicastAddress.IPv4Mask;
                    }
                }
            }

            return null; // IP address not found
        }

        public static string GetBroadcastAddress(string ipAddressString, string subnetMaskString)
        {
            try
            {
                // Parse IP address and subnet mask
                IPAddress ipAddress = IPAddress.Parse(ipAddressString);
                IPAddress subnetMask = IPAddress.Parse(subnetMaskString);

                // Convert to byte arrays
                byte[] ipBytes = ipAddress.GetAddressBytes();
                byte[] maskBytes = subnetMask.GetAddressBytes();

                // Calculate broadcast address: IP OR (NOT Mask)
                byte[] broadcastBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);
                }

                return new IPAddress(broadcastBytes).ToString();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Invalid input: {ex.Message}");
            }
        }
    }
}
