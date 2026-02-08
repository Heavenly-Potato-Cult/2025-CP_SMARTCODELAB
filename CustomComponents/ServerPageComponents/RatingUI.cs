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
    public partial class RatingUI : UserControl
    {
        private int maxValue;
        private int id;
        public Action updateScoreCall;
        public RatingUI()
        {
            InitializeComponent();
            steamTrackBar1.ValueChanged += (s, e) => { 
                updateScoreCall?.Invoke();
                score.Text = steamTrackBar1.Value + "/" + maxValue;
            } ;
        }

        public void setName(string name)
        {
            this.name.Text = name;
        }

        public void setMaxValue(int maxValue) 
        {
            steamTrackBar1.Maximum = maxValue;
            this.maxValue = maxValue;
            score.Text = steamTrackBar1.Value + "/" + maxValue;
        }

        public void setValue(int newValue)
        {
            steamTrackBar1.Value = newValue;
            score.Text = newValue + "/" + maxValue;
        }

        public int getValue()
        {
            return steamTrackBar1.Value;
        }

        public void setID(int id)
        {
            this.id = id;
        }
    }
}
