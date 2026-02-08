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
    public partial class CodeRatingUI : UserControl
    {
        private List<RatingUI> controls;
        private List<int> recordedStats;
        private bool isUploadingGrades;
        public Action gradeEdited;
        private System.Threading.Timer debounce;
        public CodeRatingUI()
        {
            InitializeComponent();
            recordedStats = new List<int>();
            controls = new List<RatingUI>()
            {
                null,
                accuracy,
                efficiency,
                robustness,
                maintainability
            };

            List<string> names = new List<string>() { "","Accuracy", "Efficiency", "Robustness", "Maintainability" };
            for (int i = 1; i < 5; i++)
                controls[i].setName(names[i]);  
            
        }

        public void SetStats(Dictionary<int, decimal[]> stats)
        {
            List<int> ids = new List<int>() { 1, 2, 3, 4 };
            foreach (int id in ids) 
            {
                RatingUI rating = controls[id];
                if (stats.ContainsKey(id))
                {
                    recordedStats.Add(id);
                    rating.setMaxValue((int)stats[id][0]);
                    rating.setID(id);
                    rating.updateScoreCall = theUrgeToUpdateIfEdit;
                }
                else
                    rating.Visible = false;
            }
        }

        public Dictionary<int, float> GetStats()
        {
            Dictionary<int, float> stats = new Dictionary<int, float>();
            foreach (int statNum in recordedStats)
            {
                RatingUI rating = controls[statNum];
                stats.Add(statNum, controls[statNum].getValue());
            }
            return stats;
        }

        public int totalScore()
        {
            Dictionary<int, float> stats = new Dictionary<int, float>();
            int totalScore = 0;
            foreach (int statNum in recordedStats)
            {
                RatingUI rating = controls[statNum];
                totalScore += controls[statNum].getValue();
            }
            return totalScore;
            ;
        }

        public void setSubmissionScores(Dictionary<int, float> studentCodeStats)
        {
            isUploadingGrades = true;
            foreach (var item in studentCodeStats)
            {
                int statNum = item.Key;
                RatingUI rating = controls[statNum];
                rating.setValue((int)item.Value);
            }
            Thread.Sleep(99);
            isUploadingGrades = false;
        }

        public void theUrgeToUpdateIfEdit() 
        {
            if (isUploadingGrades) return;
            debounce?.Change(Timeout.Infinite, Timeout.Infinite);

            debounce = new System.Threading.Timer((e) => { gradeEdited?.Invoke(); },null, 300, Timeout.Infinite);
        }
    }
}
