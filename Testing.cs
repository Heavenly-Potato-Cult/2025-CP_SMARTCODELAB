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
    public partial class Testing : Form
    {
        private Size InitialSize;
        private int InitialHeight, InitialWidth;

        public Testing()
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
                    ExpansionPanel.Panel2Collapsed = true;
                    ExpansionPanel.Size = new Size(400, 40);
                    label2.Text = "2";
                    ExpansionPanel.SplitterWidth = 1;
                    return;
                }

                if (ExpansionPanel.Panel2Collapsed)
                {
                    ExpansionPanel.Panel2Collapsed = false;
                    ExpansionPanel.Size = new Size(InitialWidth, InitialHeight);
                    label2.Text = "1";
                    return;
                }

                

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExpansionPanel.Panel1MinSize = 40;
            ////ExpansionPanel.Panel2MinSize = 60;
            //ExpansionPanel.SplitterDistance = 40;
            //ExpansionPanel.SplitterWidth = 1;
            ExpansionPanel.Panel2Collapsed = false;
            ExpansionPanel.Size = new Size(InitialWidth, InitialHeight);
            label2.Text = "1";

        }

        private void Expanded()
        {
            ExpansionPanel.Panel1MinSize = 40;
            ExpansionPanel.Panel2MinSize = 60;
            ExpansionPanel.SplitterDistance = 40;

            ExpansionPanel.Size = new Size(400, 100);
        }

        private void Collapse()
        {
            ExpansionPanel.Panel1MinSize = 40;
            ExpansionPanel.Panel2MinSize = 0;
            ExpansionPanel.SplitterDistance = 40;
            ExpansionPanel.Size = new Size(400, 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ExpansionPanel.Panel1MinSize = 40;
            //////ExpansionPanel.Panel2MinSize = 0;
            //ExpansionPanel.SplitterDistance = 40;
            ExpansionPanel.Panel2Collapsed = true;
            ExpansionPanel.Size = new Size(400, 40);
            label2.Text = "2";
            ExpansionPanel.SplitterWidth = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
