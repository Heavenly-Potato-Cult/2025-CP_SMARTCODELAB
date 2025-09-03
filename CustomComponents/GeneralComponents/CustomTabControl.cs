using SmartCodeLab.Models;
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
    public partial class CustomTabControl : UserControl
    {
        public CustomTabControl()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
        }

        public void addTab(TabPageModel tabPageModel)
        {
            var newTab = tabPageModel;
            tabControl1.TabPages.Add(newTab);

            flowLayoutPanel1.Controls.Add(tabPageModel._customTabHeader);
        }

        public TabControl getTabControl()
        {
            return tabControl1;
        }

        public Size TabControlSize()
        {
            return tabControl1.Size;
        }
    }
}
