using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    public partial class FIleVisualDisplay : UserControl
    {
        string _fileContent { get; set; }
        string _fileName { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string _filepath { get; set; }
        private FileContainer _container;
        public FIleVisualDisplay(string filePath, FileContainer container)
        {
            InitializeComponent();
            _fileName = Path.GetFileName(filePath);
            _filepath = filePath;
            fileName.Text = _fileName;
            _fileContent = File.ReadAllText(filePath);
            _container = container;
        }

        public FIleVisualDisplay(string _fileName, string fileContent, FileContainer container)
        {
            InitializeComponent();
            this._fileName = _fileName;
            fileName.Text = _fileName;
            _fileContent = fileContent;
            _container = container;
        }
        private void FIleVisualDisplay_Load(object sender, EventArgs e)
        {

        }

        //file name as the key, and file content as the value
        public KeyValuePair<string, string> getFile()
        {
            return new KeyValuePair<string, string>(_fileName, _fileContent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _container.removeFile(_fileName);
            Dispose();
        }
    }
}
