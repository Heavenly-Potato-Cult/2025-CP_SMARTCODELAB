using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class TempIDE : Form
    {
        public TempIDE()
        {
            InitializeComponent();

        }

        private void TempIDE_Load_1(object sender, EventArgs e)
        {
           
        }

        private void codeEditor1_Load(object sender, EventArgs e)
        {

        }

        private void ResizeTabs()
        {
            if (tabControl_RightSide.TabPages.Count == 0) return;

            int tabCount = tabControl_RightSide.TabPages.Count;
            int totalWidth = tabControl_RightSide.ClientSize.Width;
            int tabWidth = totalWidth / tabCount;

            tabControl_RightSide.SizeMode = TabSizeMode.Fixed;
            tabControl_RightSide.ItemSize = new Size(tabWidth, 30); // 30 = tab height
        }

        private void tabControl_RightSide_Resize(object sender, EventArgs e)
        {
            ResizeTabs();
        }

        private void TempIDE_Shown(object sender, EventArgs e)
        {
            ResizeTabs();
        }
    }
}
