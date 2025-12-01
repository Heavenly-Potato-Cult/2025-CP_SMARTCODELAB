using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.SteamThings;
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
using System.Windows.Input;

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
        private Dictionary<int, SteamStatRow> statsRows;
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
            statsRows = new Dictionary<int, SteamStatRow>()
            {
                {1, rowAccuracy },
                {2, rowEfficiency },
                {3, rowRobustness },
                {4, rowMaintainability },
            };


        }

        public void SetStats(Dictionary<int, decimal[]> stats)
        {
            statsWeight = new Dictionary<int, decimal>();
            if (stats != null)
            {
                foreach (var key in statsRows.Keys)
                {
                    if (stats.ContainsKey(key))
                    {
                        // Show the row, save the weight
                        statsRows[key].Visible = true;
                        statsWeight.Add(key, stats[key][0]);
                        statsRows[key].highestScore = (int)stats[key][0];
                        statsRows[key].Value = 0;
                    }
                    else
                    {
                        // Hide if not tracked
                        statsRows[key].Visible = false;
                    }
                }

                if (stats.ContainsKey(2))
                    standardOperatorsCount = Convert.ToInt32(stats[2][1]);

                if (stats.ContainsKey(4))
                    standardCycComplexity = Convert.ToInt32(stats[4][1]);

                recordedStats = stats.Keys.ToList();
            }
        }

        public void setSubmissionScores(Dictionary<int, float> studentCodeStats, string language)
        {
            foreach (var item in studentCodeStats)
            {
                int statNum = item.Key;
                double maxScore = (double)statsWeight[statNum];
                double percentage = (item.Value / maxScore) * 100.0;
                statsRows[statNum].Value = (int)percentage;
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
            return currentCodeStats;
        }

        public async void UpdateStats(int i, int value, string language)
        {
            await Task.Run(() =>
            {
                if (!recordedStats.Contains(i))
                    return;

                int finalValue = 0;


                if (i == 1)
                {
                    testScore = value;
                    //accuracy.ChangeValue((int)((value / (double)maxTestScore) * 100));
                    finalValue = (int)((value / (double)maxTestScore) * 100);
                }
                else if (i == 2)//efficiency
                {
                    //efficiency.ChangeValue(Math.Min(value, accuracy.Value));
                    finalValue = Math.Min(value, rowAccuracy.Value);
                }
                else if (i == 3)//robustness
                {
                    int scoreRobustness = Math.Max(0, 100 - getTotalDeduction(i, value, language));
                    //robustness.ChangeValue(Math.Min(scoreRobustness, accuracy.Value));
                    finalValue = Math.Min(scoreRobustness, rowAccuracy.Value);
                }
                else if (i == 4)//maintainability
                {
                    int difference = Math.Max(0, 100 - getTotalDeduction(i, value, language));
                    //maintainability.ChangeValue(Math.Min(difference, accuracy.Value));
                    finalValue = Math.Min(difference, rowAccuracy.Value);
                }
                //statsGrade[i] = (statsRows[i].theValue / 100f) * Convert.ToSingle(statsWeight[i]);
                statsGrade[i] = (finalValue / 100f) * Convert.ToSingle(statsWeight[i]);
                this.Invoke(new Action(() =>
                {
                    // 1. Update the Bar
                    statsRows[i].Value = finalValue;

                    // 2. Update Total Score Label (Find your 'score' label)
                    if (this.Controls.Find("scoreLabel", true).FirstOrDefault() is SteamLabel lbl)
                    {
                        lbl.Text = GetScore().ToString("0"); // "85"
                    }
                }));
            });
        }

        //Weighted Violation-Based Scoring System
        private int getTotalDeduction(int factor, int totalViolations, string language)
        {
            decimal factorWeight = statsWeight[factor];
            int totalChecks = LintersServices.totalLanguageChecks[language][factor];
            return Convert.ToInt32(Math.Ceiling((factorWeight / totalChecks) * totalViolations));
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
                // Update Total
                if (this.Controls.Find("scoreLabel", true).FirstOrDefault() is Label lbl)
                    lbl.Text = codeRating.totalRating.ToString();

                // Update Bars
                foreach (var item in codeRating.trackbarValues)
                {
                    if (statsRows.ContainsKey(item.Key))
                    {
                        statsRows[item.Key].Value = item.Value;
                    }
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

        private Dictionary<int, int> getTrackBarValues()
        {
            return new Dictionary<int, int>()
            {
                {1, rowAccuracy.Value },
                {2, rowEfficiency.Value },
                {3, rowRobustness.Value },
                {4, rowMaintainability.Value }
            };
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
