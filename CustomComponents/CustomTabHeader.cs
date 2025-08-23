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

namespace SmartCodeLab.CustomComponents
{
    public partial class CustomTabHeader : UserControl
    {
        public CustomTabHeader()
        {
            InitializeComponent();
            label1.Click += (sender, e) =>
            {
                Focus();
            };

            LostFocus += (sender, e) =>
            {
                Debug.WriteLine("I lost focus");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
