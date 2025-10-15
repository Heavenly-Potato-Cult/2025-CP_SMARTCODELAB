using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
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

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
            treeView1.Nodes.Add(new TreeNodeObj("C:\\Users\\magno\\OneDrive\\Desktop\\testMe", null));
        }

        static void OnObjectMouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Mouse clicked hihi");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node is TreeNodeObj tno)
            {
                tno.SimulateClicked(e);
            }
        }
    }
}
