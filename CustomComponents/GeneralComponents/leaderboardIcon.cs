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
    public partial class leaderboardIcon : RoundedUserControl
    {
        public leaderboardIcon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The rank (1, 2, 3...) to display.
        /// </summary>
        [Category("Data")]
        [Description("The rank (1, 2, 3...) to display.")]
        [DefaultValue(0)]
        public int Ranking
        {
            get
            {
                // 'get' reads the value from the label
                int.TryParse(ranking.Text, out int rank);
                return rank;
            }
            set
            {
                // 'set' updates the label's text
                ranking.Text = value.ToString();
            }
        }

        /// <summary>
        /// The player's name to display.
        /// </summary>
        [Category("Data")]
        [Description("The students's name to display.")]
        [DefaultValue("")]
        public string Name
        {
            get
            {
                // 'get' reads the value from the label
                return name.Text;
            }
            set
            {
                // 'set' updates the label's text
                name.Text = value;
            }
        }

        /// <summary>
        /// The score to display.
        /// </summary>
        [Category("Data")]
        [Description("The score to display.")]
        [DefaultValue(0)]
        public int Score
        {
            get
            {
                // 'get' reads the value from the label
                int.TryParse(studscore.Text, out int score);
                return score;
            }
            set
            {
                // 'set' updates the label's text
                studscore.Text = value.ToString();
            }
        }


    }

}
