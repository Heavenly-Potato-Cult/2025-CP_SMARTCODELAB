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
    public partial class ExpansionPanel2 : UserControl
    {
        private Size InitialSize;
        private int InitialHeight, InitialWidth;
        public ExpansionPanel2()
        {
            InitializeComponent();
            ExpansionPanel.Panel1MinSize = 40;
            ExpansionPanel.Panel2MinSize = 0;
            ExpansionPanel.SplitterDistance = 40;
            ExpansionPanel.SplitterDistance = 1;
            ExpansionPanel.Panel2Collapsed = false;
            InitialSize = ExpansionPanel.Size;
            InitialHeight = InitialSize.Height;
            InitialWidth = InitialSize.Width;
            



            button3.Click += (s, e) =>
            {
                if (!ExpansionPanel.Panel2Collapsed)
                {
                    this.AutoSize = true;
                    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    ExpansionPanel.Panel2Collapsed = true;
                    ExpansionPanel.Size = new Size(InitialWidth, 40);
                    ExpansionPanel.SplitterWidth = 1;
                    label2.Text = InitialWidth.ToString();
                    return;
                }

                if (ExpansionPanel.Panel2Collapsed)
                {
                    this.AutoSize = false;
                    this.AutoSizeMode = AutoSizeMode.GrowOnly;
                    ExpansionPanel.Panel2Collapsed = false;
                    ExpansionPanel.Size = new Size(InitialWidth, InitialHeight);

                    label2.Text = InitialWidth.ToString();
                    return;
                }



            };

            
        }
    }
}
