using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
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
        private ISet<string> openedFiles = new HashSet<string>();
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
                var rootItem = new FileItem(folderBrowserDialog.SelectedPath);
                SystemSingleton.Instance.currentTaskPath = rootItem.FullPath;
                {
                    Name = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
                }
                ;
                fileTree.Nodes.Add(rootItem.ToTreeNode());
            }
        }

        private void fileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selectedPath = (e.Node.Tag as FileItem).FullPath;
            // will check if the selected path is not null, is a file that exists, and is not already opened
            if (selectedPath != null && File.Exists(selectedPath) && !openedFiles.Contains(selectedPath))
            {
                TaskModel taskModel = JsonFileService.LoadFromFile<TaskModel>(selectedPath);
                    
                if(taskModel == null)
                {
                    MessageBox.Show("The selected file is not a valid task file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                openedFiles.Add(selectedPath);
                customTabControl1.addTab(new TabPageModel(selectedPath, customTabControl1.getTabControl(), new TaskTabPage(selectedPath), openedFiles));
            }
            else if(!Path.Exists(selectedPath) && !File.Exists(selectedPath)) //checks if the path is a folder
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
