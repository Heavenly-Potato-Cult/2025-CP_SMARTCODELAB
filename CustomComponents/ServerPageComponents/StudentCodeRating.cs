using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
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
        private int standardOperatorsCount;
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
                {3, robustnessContainer },
                {4, maintainabilityContainer },
            };

            statsBar = new Dictionary<int, StatsBar>()
            {
                {1, accuracy},
                {2, efficiency},
                {3, robustness},//robustness
                {4, maintainability},//maintainability
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

                if(stats.ContainsKey(2))
                    standardOperatorsCount = Convert.ToInt32(stats[2][1]);

                if (stats.ContainsKey(4))
                    standardCycComplexity = Convert.ToInt32(stats[4][1]);

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

        public async void UpdateStats(int i, int value, string language)
        {
            await Task.Run(() =>
            {
                if (!recordedStats.Contains(i))
                    return;
                if (i == 1)
                {
                    testScore = value;
                    accuracy.ChangeValue((int)((value / (double)maxTestScore) * 100));
                }
                else if (i == 2)//efficiency
                {
                    efficiency.ChangeValue(Math.Min(value, accuracy.Value));
                }
                else if (i == 3)//robustness
                {
                    int scoreRobustness = Math.Max(0, 100 - getTotalDeduction(i, value, language));
                    robustness.ChangeValue(Math.Min(scoreRobustness, accuracy.Value));
                }
                else if (i == 4)//maintainability
                {
                    int difference = Math.Max(0, 100 - getTotalDeduction(i, value, language));
                    maintainability.ChangeValue(Math.Min(difference, accuracy.Value));
                }
                statsGrade[i] = (statsBar[i].theValue / 100) * Convert.ToSingle(statsWeight[i]);
                this.Invoke(new Action(() => score.Text = GetScore().ToString()));
            });
        }

        //Weighted Violation-Based Scoring System
        private int getTotalDeduction(int factor, int totalViolations, string language)
        {
            decimal factorWeight = statsWeight[factor];
            int totalChecks = LintersServices.totalLanguageChecks[language][factor];
            return Convert.ToInt32(Math.Ceiling((factorWeight / totalChecks) * totalViolations));
        }

        /* qoutient = student_total_operators / standard_operators_count
         * if qoutient <= 1.1 then 100
         * if qoutient <= 1.4 then 85
         * if qoutient <= 1.8 then 70
         * if qoutient <= 2.5 then 50
         * else 30
         */
        private int getEfficiencyGrade(int studTotalOperators) 
        {
            double percentageDiff = Convert.ToDouble(studTotalOperators) / standardOperatorsCount;

            if (percentageDiff <= 1.1)
                return 100;
            else if (percentageDiff <= 1.4)
                return 85;
            else if (percentageDiff <= 1.8)
                return 70;
            else if (percentageDiff <= 2.5)
                return 50;
            else
                return 30;
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
                Debug.WriteLine("Total rating" + codeRating.totalRating.ToString());
                score.Text = codeRating.totalRating.ToString();

                foreach (var item in codeRating.trackbarValues)
                {
                    statsBar[item.Key].ChangeValue(item.Value);
                }
            }));
        }

        public CodeRating GetCodeRating()
        {
            return new CodeRating.Builder()
                .WithTotalRating(GetScore())
                .WithTestScore(testScore)
                .WithMaxTestScore(maxTestScore)
                .WithReadabilityViolations(standardViolations)
                .WithRecommendedCycComplexity(standardCycComplexity)
                .WithActualCycComplexity(Convert.ToInt32(10))
                .WithStatsGrade(GetStats())
                .WithTrackBarValues(getTrackBarValues())
                .Build();
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            if(violations != null)
            {
                new ViewCodeViolations(violations.Invoke()).ShowDialog();
            }
        }

        private Dictionary<int, int> getTrackBarValues()
        {
            return new Dictionary<int, int>()
            {
                {1, accuracy.Value },
                {2, efficiency.Value },
                {3, robustness.Value },
                {4, maintainability.Value }
            };
        }

        public void SetViolationsRetriever(Func<List<HashSet<string>>> violations)
        {
            this.violations = violations;
        }
    }
}
