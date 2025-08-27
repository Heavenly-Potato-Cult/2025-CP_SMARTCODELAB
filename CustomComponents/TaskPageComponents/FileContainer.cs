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
        private List<string> fileNames = new List<string>();
        public FileContainer()
        {
            InitializeComponent();
            _acceptMultipleFiles = false;
        }

        public KeyValuePair<string, string>? getFile()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return null;

            KeyValuePair<string, string> file = default;

            foreach (FIleVisualDisplay control in flowLayoutPanel1.Controls)
            {
                file = control.getFile();
            }

            return file;
        }

        public Dictionary<string, string>? getFiles()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return null;

            Dictionary<string, string> file = new Dictionary<string, string>();

            foreach (FIleVisualDisplay control in flowLayoutPanel1.Controls)
            {
                try
                {
                    file.Add(control.getFile().Key, control.getFile().Value);
                }
                catch (ArgumentException)
                {
                    //do not add the same key
                }
            }

            return file;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ContainerHeight
        {
            get { return flowLayoutPanel1.Height; }
            set { flowLayoutPanel1.Height = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public void removeFile(string fileName)
        {
            fileNames.Remove(fileName);
        }

        public void addFile(string filePath)
        {
            if(fileNames.Contains(filePath))
                return;

            if (!AcceptMultipleFiles)
                flowLayoutPanel1.Controls.Clear();

            fileNames.Add(Path.GetFileName(filePath));
            flowLayoutPanel1.Controls.Add(new FIleVisualDisplay(filePath, this));
        }

        // planning to merge this with the addFile method by utilizing boolean flags
        public void addFile(string fileName, string fileContent)
        {
            if (fileNames.Contains(fileName))
                return;

            if (!AcceptMultipleFiles)
                flowLayoutPanel1.Controls.Clear();

            fileNames.Add(Path.GetFileName(fileName));
            flowLayoutPanel1.Controls.Add(new FIleVisualDisplay(fileName, fileContent, this));
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = AcceptMultipleFiles;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (AcceptMultipleFiles)
                {
                    foreach (var file in fileDialog.FileNames)
                    {
                        addFile(file);
                    }
                }
                else
                {
                    addFile(fileDialog.FileName);
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AcceptMultipleFiles
        {
            get { return _acceptMultipleFiles; }
            set
            {
                _acceptMultipleFiles = value;
                flowLayoutPanel1.AutoScroll = value;
            }
        }
    }
}
