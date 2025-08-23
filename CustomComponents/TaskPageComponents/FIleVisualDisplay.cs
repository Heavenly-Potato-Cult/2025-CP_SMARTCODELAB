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
        string _filePath { get; set; }
        string _fileName { get; set; }
        public FIleVisualDisplay(string filePath)
        {
            InitializeComponent();
            fileName.Text = Path.GetFileName(filePath);
            _filePath = filePath;
            _fileName = Path.GetFileName(filePath);
        }

        private void FIleVisualDisplay_Load(object sender, EventArgs e)
        {

        }

        public KeyValuePair<string, string> getFile()
        {
            return new KeyValuePair<string, string>(_fileName, _filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
