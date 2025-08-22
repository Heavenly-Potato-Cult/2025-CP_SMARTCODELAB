using SmartCodeLab.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SmartCodeLab.CustomComponents.MainPages
{
    public partial class TaskMainPage : UserControl
    {
        public TaskMainPage()
        {
            InitializeComponent();
        }

        private void openFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTree.Nodes.Clear();

                var rootItem = new FileItem(folderBrowserDialog.SelectedPath)
                {
                    Name = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name
                };
                fileTree.Nodes.Add(rootItem.ToTreeNode());
            }
        }

        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            smoothTabControl2.TabPages.Add(new TabPage("New Tab"));
        }
    }
}
