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
            consoleTextBox1.IsReadLineMode = true;
            consoleTextBox1.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string waiting = consoleTextBox1.ReadLine();
                    Debug.WriteLine(waiting);
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consoleTextBox1.Clear();
        }
    }
}
