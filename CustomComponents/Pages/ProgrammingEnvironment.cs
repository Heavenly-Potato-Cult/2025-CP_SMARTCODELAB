using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
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
        public ProgrammingEnvironment(string folderPath, string userName, TaskModel task)
        {
            InitializeComponent();
            new Thread(() => {
                System.Threading.Thread.Sleep(1000);
                SystemSingleton.Instance._loggedIn = true;
            }).Start();
            selectFolder(folderPath);
            MessageBox.Show(task.ToString());
        }

        private void selectFolder(string path)
        {
            fileTree.Nodes.Clear();
            var rootItem = new FileItem(path);
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
    }
}
