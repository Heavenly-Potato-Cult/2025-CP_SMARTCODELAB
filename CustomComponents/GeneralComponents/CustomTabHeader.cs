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
        private TabControl tabControl;
        private TabPage tabPage;
        public CustomTabHeader(string headerText,TabControl tabControl, TabPage tabPage)
        {
            InitializeComponent();

            label1.Text = headerText;
            this.tabControl = tabControl;
            this.tabPage = tabPage;
            label1.Click += TabControlSelected;
            this.Click += TabControlSelected;
        }

        private void TabControlSelected(object sender, EventArgs m) 
        {
            tabControl.SelectedTab = tabPage;
            this.Invoke((Action)(() =>
            {
                label1.Font = new Font(label1.Font, FontStyle.Bold);
            }));
        }

        public void FocusLost() 
        {
            this.Invoke((Action)(() =>
            {
                label1.Font = new Font(label1.Font, FontStyle.Regular);
            }));
        }

        public Button CloseButton { get { return button1; } }
    }
}
