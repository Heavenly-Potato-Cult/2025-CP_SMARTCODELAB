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
using System.IO;


namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class FileOptions : Form
    {
        public FileOptions(Point location, Action<int, string> action, bool isDirectory, string directoryPath = "")
        {
            InitializeComponent();
            KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Escape)
                {
                    Debug.WriteLine("Escaped clicked");
                    CloseDialog();
                }
            };


            optionContainer.Controls.Add(new DialogOptions("Delete",
                new Action(() =>
                {
                    action?.Invoke(1, directoryPath);
                    CloseDialog();
                })));

            optionContainer.Controls.Add(new DialogOptions("Rename",
                new Action(() =>
                {
                    MessageBox.Show("Rename selected node");
                    CloseDialog();
                })));

            if (isDirectory)
            {
                optionContainer.Controls.Add(new DialogOptions("Create New File",
                new Action(() =>
                {
                    var inputDialog = new TextInputDialog("New Task", "New File Name");
                    if(inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newFileFullpath = Path.Combine(directoryPath, inputDialog.InputtedText()+".task");
                        action?.Invoke(2, newFileFullpath);
                    }
                    CloseDialog();
                })));

                optionContainer.Controls.Add(new DialogOptions("Create New Folder",
                new Action(() =>
                {
                    var inputDialog = new TextInputDialog("New Folder", "New Folder Name");
                    if (inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newFileFullpath = Path.Combine(directoryPath, inputDialog.InputtedText());
                        action?.Invoke(3, newFileFullpath);
                    }
                    CloseDialog();
                })));
            }
            var handle = this.Handle;
            BeginInvoke(new Action(() =>
            {
                Location = location;
            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void CloseDialog()
        {
            Close();
        }
    }
}
