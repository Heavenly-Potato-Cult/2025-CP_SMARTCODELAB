using SmartCodeLab.CustomComponents.GeneralComponents;
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

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class StudentCodeRating : UserControl
    {
        /*for the list and dictionary keys, the following digits are the equivalent stats value:
        * 1 - Accuracy
        * 2 - Readability
        * 3 - Efficiency
        * 4 - Complexity
        */

        private List<int> recordedStats = new List<int>();
        private readonly Dictionary<int, Panel> statsTotal;
        private readonly Dictionary<int, StatsBar> statsBar;
        private int standardCycComplexity;

        public Dictionary<int, decimal> statsWeight;
        public Dictionary<int, float> statsGrade;
        public StudentCodeRating()
        {
            InitializeComponent();
            statsGrade = new Dictionary<int, float>()
            {
                {1, 0 },
                {2, 0 },
                {3, 0 },
                {4, 0 }
            };
            statsTotal = new Dictionary<int, Panel>()
            {
                {1, panel3 },
                {2, readabilityContainer },
                {3, efficiencyContainer },
                {4, panel1 },
            };

            statsBar = new Dictionary<int, StatsBar>()
            {
                {1, accuracy},
                {2, readability},
                {3, efficiency},
                {4, complexity},
            };
        }

        public void SetStats(Dictionary<int, decimal[]> stats)
        {
            statsWeight = new Dictionary<int, decimal>();
            if (stats != null)
            {
                foreach (var item in statsTotal.Keys)
                {
                    if (!stats.ContainsKey(item))
                    {
                        statsTotal[item]?.Hide();
                    }
                    else
                        statsWeight.Add(item, stats[item][0]);
                }

                if (stats.ContainsKey(4))
                {
                    standardCycComplexity = Convert.ToInt32(stats[4][1]);
                }

                recordedStats = stats.Keys.ToList();
            }
        }

        public void SetStudentStats(Dictionary<int, int> stats)
        {
            if (stats != null)
            {
                foreach (var item in stats.Where(item => item.Key != 5))
                {
                    statsBar[item.Key]?.ChangeValue(item.Value);
                }
            }
        }
        public Dictionary<int, int> GetStats()
        {
            var currentCodeStats = new Dictionary<int, int>();

            foreach (var item in recordedStats)
            {
                try
                {
                    currentCodeStats.Add(item, statsBar[item].Value);
                }catch (KeyNotFoundException) { }
            }
            //5 will be the total score
            currentCodeStats.Add(5, Convert.ToInt32(GetScore()));
            return currentCodeStats;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (readabilityContainer.Size.Height < 406)
            {
                readabilityContainer.Size = new Size(436, 406);
                readabilityContainer.Invalidate();
            }
            else
            {
                readabilityContainer.Size = new Size(436, 39);
                readabilityContainer.Invalidate();
            }
        }

        public async void UpdateStats(int i, int value, List<string>? reasons)
        {
            if (!recordedStats.Contains(i))
                return;
            if (i == 1)
            {
                accuracy.ChangeValue(value);
            }
            else if (i == 2)
            {
                readability.ChangeValue(100 - value);
                string violations = "Standard Violations:\n";
                reasons?.ForEach(reason =>  violations += "- " + reason + "\n" );
                standardErrors.Text = violations;
            }
            else if (i == 4)
            {
                float remainder = value - standardCycComplexity;
                int scoreComp = remainder <= (standardCycComplexity * .1) ? 100 :
                            remainder <= (standardCycComplexity * .4) ? 75 :
                            50;
                complexity.ChangeValue(scoreComp);
            }
            statsGrade[i] = (statsBar[i].theValue / 100) * Convert.ToSingle(statsWeight[i]);
            await Task.Run(() => this.Invoke(new Action(() => score.Text = GetScore().ToString())));
        }

        private void customToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = customToggleButton1.Checked;
        }

        public float GetScore()
        {
            float totalScore = 0;
            foreach (var score in statsGrade.Values)
            {
                totalScore += score;
            }
            return totalScore;
        }
    }
}
