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
using System.Windows.Input;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class TextInputDialog : Form
    {
        public TextInputDialog()
        {
            InitializeComponent();
        }

        public TextInputDialog(string formName, string placeholderText)
        {
            InitializeComponent();
            this.Name = formName;
            customTextBox1.PlaceholderText = placeholderText;

            var handle = this.Handle;
        }

        public string InputtedText()
        {
            return customTextBox1.Texts;
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
