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
    public partial class FileContainer : UserControl
    {
        private bool _acceptMultipleFiles;
        public FileContainer()
        {
            InitializeComponent();
            _acceptMultipleFiles = false;
        }

        public void addFile(string filePath)
        {
            if(!AcceptMultipleFiles)
                flowLayoutPanel1.Controls.Clear();

            flowLayoutPanel1.Controls.Add(new FIleVisualDisplay(filePath));

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AcceptMultipleFiles
        {
            get { return _acceptMultipleFiles; }
            set { 
                _acceptMultipleFiles = value;
                flowLayoutPanel1.AutoScroll = value;
            }
        }
    }
}
