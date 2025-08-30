using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class UserLogInDIalog : Form
    {
        public string _userName { get { return userName.Texts; } }
        public string _folderLocation { get { return folderLoc.Texts; } }
        public UserLogInDIalog()
        {
            InitializeComponent();
        }

        private void userName__TextChanged(object sender, EventArgs e)
        {

        }

        public string UserName()
        {
            return userName.Texts;
        }

        public string folderPath()
        {
            return folderLoc.Texts;
        }
        private void smartButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderLoc.Texts = folderBrowserDialog.SelectedPath;
            }
        }

        private void smartButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
