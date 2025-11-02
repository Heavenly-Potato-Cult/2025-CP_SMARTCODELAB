using SmartCodeLab.CustomComponents.CustomDialogs;
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

        private Func<List<HashSet<string>>> violations { get; set; }

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
                {3, efficiency},//robustness
                {4, complexity},//maintainability
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
                    //expectedCycComplexity.Text = standardCycComplexity.ToString();
                }

                recordedStats = stats.Keys.ToList();
            }
        }

        public void SetStudentStats(Dictionary<int, float> stats)
        {
            if (stats != null)
            {
                foreach (var item in stats.Where(item => item.Key != 5))
                {
                    int k = item.Key;
                    int percentageScore = Convert.ToInt32((Convert.ToDecimal(item.Value) / statsWeight[k]) * 100);
                    statsBar[item.Key]?.ChangeValue(percentageScore);
                }
            }
        }
        public Dictionary<int, float> GetStats()
        {
            var currentCodeStats = new Dictionary<int, float>();

            foreach (var item in recordedStats)
            {
                try
                {
                    currentCodeStats.Add(item, statsGrade[item]);
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
                //this.Invoke(new Action(() => result.Text = $"{value.ToString()}/{maxTestScore}"));
                accuracy.ChangeValue(score);
            }
            else if (i == 2)//readability
            {
                readability.ChangeValue(100 - value);
                string violations = "Standard Violations:\n";
                reasons?.ForEach(reason => violations += "- " + reason + "\n");
                //standardErrors.Text = violations;
                standardViolations = reasons ?? new List<string>();
            }
            else if (i == 3)//robustness
            {
                int scoreRobustness = 100 - value;
                //this.Invoke(new Action(() => actualEfficiency.Text = value.ToString()));
                efficiency.ChangeValue(scoreRobustness);
            }
            else if (i == 4)//maintainability
            {
                int difference = value - standardCycComplexity;
                int scoreComp = difference <= (standardCycComplexity * .1) ? 100 :
                                difference <= (standardCycComplexity * .4) ? 75 : 50;

                //this.Invoke(new Action(() => actualCycComplexity.Text = value.ToString()));
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
                //result.Text = $"{testScore}/{maxTestScore}";
                //actualCycComplexity.Text = codeRating.actualCycComplexity.ToString();
                standardViolations = codeRating.readabilityViolations;
                string violations = "Standard Violations:\n";
                standardViolations.ForEach(reason => violations += "- " + reason + "\n");
                //standardErrors.Text = violations;
                score.Text = codeRating.totalRating.ToString();
            }));
        }

        public CodeRating GetCodeRating()
        {
            return new CodeRating.Builder()
                .WithTotalRating(Convert.ToDecimal(score.Text))
                .WithTestScore(testScore)
                .WithMaxTestScore(maxTestScore)
                .WithReadabilityViolations(standardViolations)
                .WithRecommendedCycComplexity(standardCycComplexity)
                .WithActualCycComplexity(Convert.ToInt32(10))
                .WithStatsGrade(GetStats())
                .Build();
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine((violations != null));
            if(violations != null)
            {
                new ViewCodeViolations(violations.Invoke()).ShowDialog();
            }
        }

        public void SetViolationsRetriever(Func<List<HashSet<string>>> violations)
        {
            Debug.WriteLine(violations);
            this.violations = violations;
        }
    }
}
