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
    public partial class StringInputDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string InputText
        {
            get { return customTextBox1.Texts; }
        }
        public StringInputDialog(string title,string placeHolder)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = title;
            customTextBox1.PlaceholderText = placeHolder;
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
