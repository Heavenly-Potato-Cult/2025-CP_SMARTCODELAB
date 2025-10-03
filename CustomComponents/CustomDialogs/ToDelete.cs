using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
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

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Size.Height > 60)
            {
                panel1.Size = new Size(panel1.Width, 60);
                button1.Text = "OPEN";
            }
            else
            {
                panel1.Size = new Size(panel1.Width, 120);
                button1.Text = "CLOSE";
            }
        }
    }
}
