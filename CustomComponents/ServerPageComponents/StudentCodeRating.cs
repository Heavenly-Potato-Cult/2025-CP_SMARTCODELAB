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
        private int testScore;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int maxTestScore { get; set; }
        public Dictionary<int, decimal> statsWeight;
        public Dictionary<int, float> statsGrade;

        private List<string> standardViolations;
        public StudentCodeRating()
        {
            InitializeComponent();
            standardViolations = new List<string>();
            maxTestScore = 0;
            testScore = 0;
            statsGrade = new Dictionary<int, float>()
            {
                {1, 0 },
                {2, 0 },
                {3, 0 },
                {4, 0 }
            };
            statsTotal = new Dictionary<int, Panel>()
            {
                {1, accuracyPanel },
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
                        statsTotal[item]?.Visible = false;
                    }
                    else
                        statsWeight.Add(item, stats[item][0]);
                }

                if (stats.ContainsKey(4))
                {
                    standardCycComplexity = Convert.ToInt32(stats[4][1]);
                    expectedCycComplexity.Text = standardCycComplexity.ToString();
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
                }
                catch (KeyNotFoundException) { }
            }
            //5 will be the total score
            currentCodeStats.Add(5, Convert.ToInt32(GetScore()));
            return currentCodeStats;
        }



        public async void UpdateStats(int i, int value, List<string>? reasons)
        {
            if (!recordedStats.Contains(i))
                return;
            if (i == 1)
            {
                testScore = value;
                int score = (value / maxTestScore) * 100;
                this.Invoke(new Action(() => result.Text = $"{value.ToString()}/{maxTestScore}"));
                accuracy.ChangeValue(score);
            }
            else if (i == 2)
            {
                readability.ChangeValue(100 - value);
                string violations = "Standard Violations:\n";
                reasons?.ForEach(reason => violations += "- " + reason + "\n");
                standardErrors.Text = violations;
                standardViolations = reasons ?? new List<string>();
            }
            else if (i == 4)
            {
                int difference = value - standardCycComplexity;
                int scoreComp = difference <= (standardCycComplexity * .1) ? 100 :
                                difference <= (standardCycComplexity * .4) ? 75 : 50;

                this.Invoke(new Action(() => actualCycComplexity.Text = value.ToString()));
                complexity.ChangeValue(scoreComp);
            }
            statsGrade[i] = (statsBar[i].theValue / 100) * Convert.ToSingle(statsWeight[i]);
            await Task.Run(() => this.Invoke(new Action(() => score.Text = GetScore().ToString())));
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

        public void UpdateStatsDisplay(CodeRating codeRating)
        {
            this.Invoke(new Action(() =>
            {
                SetStudentStats(codeRating.statsGrade);
                testScore = codeRating.testScore;
                maxTestScore = codeRating.maxTestScore;
                result.Text = $"{testScore}/{maxTestScore}";
                actualCycComplexity.Text = codeRating.actualCycComplexity.ToString();
                standardViolations = codeRating.readabilityViolations;
                string violations = "Standard Violations:\n";
                standardViolations.ForEach(reason => violations += "- " + reason + "\n");
                standardErrors.Text = violations;
                score.Text = codeRating.totalRating.ToString();
            }));
        }

        public CodeRating GetCodeRating()
        {
            return new CodeRating.Builder()
                .WithTotalRating(Convert.ToInt32(score.Text))
                .WithTestScore(testScore)
                .WithMaxTestScore(maxTestScore)
                .WithReadabilityViolations(standardViolations)
                .WithRecommendedCycComplexity(standardCycComplexity)
                .WithActualCycComplexity(Convert.ToInt32(actualCycComplexity.Text))
                .WithStatsGrade(GetStats())
                .Build();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Size.Height < 96)
            {
                panel1.Size = new Size(385, 96);
            }
            else
            {
                panel1.Size = new Size(385, 39);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accuracyPanel.Size.Height < 70)
            {
                accuracyPanel.Size = new Size(385, 70);
            }
            else
            {
                accuracyPanel.Size = new Size(385, 39);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (readabilityContainer.Size.Height < 385)
            {
                readabilityContainer.Size = new Size(385, 406);
            }
            else
            {
                readabilityContainer.Size = new Size(385, 39);
            }
        }
    }
}
