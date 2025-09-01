using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ProgrammingEnvironment : UserControl
    {
        private TcpClient _client;
        private TaskModel _task;
        private ISet<string> openedFiles = new HashSet<string>();
        public ProgrammingEnvironment(string folderPath, string userName, TaskModel task)
        {
            InitializeComponent();
            new Thread(() =>
            {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();

            //create the activity file
            SourceCodeInitializer.InitializeSourceCode(task._language, folderPath, task._taskName);

            selectFolder(folderPath);
            _task = task;
        }

        private void selectFolder(string path)
        {
            fileTree.Nodes.Clear();
            var rootItem = new FileItem(path, false);
            {
                Name = new DirectoryInfo(path).Name;
            }
            ;
            fileTree.Nodes.Add(rootItem.ToTreeNode());
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run action triggered");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test action triggered");
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_task._instructions);
        }

        private void fileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selectedPath = (e.Node.Tag as FileItem).FullPath;
            // will check if the selected path is not null, is a file that exists, and is not already opened
            if (selectedPath != null && File.Exists(selectedPath) && !openedFiles.Contains(selectedPath))
            {
                openedFiles.Add(selectedPath);
                customTabControl1.addTab(new TabPageModel(selectedPath, customTabControl1.getTabControl(), new CodingEnvironment(selectedPath), openedFiles));
            }
        }
    }
}
