using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents
{
    public partial class DialogOptions : UserControl
    {
        public DialogOptions(string optionName, Action action)
        {
            InitializeComponent();
            this.optionName.Text = optionName;
            this.optionName.MouseHover += (s, e) => HoverOver();
            MouseHover += (s, e) => HoverOver();

            this.optionName.MouseLeave += (s, e) => LeaveHoverOver();
            MouseLeave += (s, e) => LeaveHoverOver();

            this.optionName.Click += (s, e) => action?.Invoke();
            Click += (s, e) => {
                Focus();
                action?.Invoke(); };
        }

        private void HoverOver()
        {
            BackColor = Color.Blue;
        }

        private void LeaveHoverOver()
        {
            BackColor = Color.White;
        }
    }
}
