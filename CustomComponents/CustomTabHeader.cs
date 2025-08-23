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
        public CustomTabHeader(string headerText,TabControl tabControl, TabPage tabPage)
        {
            InitializeComponent();
            label1.Click += (sender, e) =>
            {
                Focus();
                tabControl.SelectedTab = tabPage;
            };

            LostFocus += (sender, e) =>
            {
                Debug.WriteLine("I lost focus");
            };

            button1.Click += (sender, e) =>
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
            };
        }
    }
}
