using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    public partial class FIleVisualDisplay : UserControl
    {
        public FIleVisualDisplay(string _fileName)
        {
            InitializeComponent();
            fileName.Text = _fileName;
            MessageBox.Show(fileName.Text);
        }

        private void FIleVisualDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
