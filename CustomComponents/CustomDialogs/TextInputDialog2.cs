using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class TextInputDialog2 : Form
    {
        public string inputText { get; private set; }
        public TextInputDialog2()
        {
            InitializeComponent();
            inputText = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            inputText = textBox1.Text;
            this.Close();
        }
    }
}
