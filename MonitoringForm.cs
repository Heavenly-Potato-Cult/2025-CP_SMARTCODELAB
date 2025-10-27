using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class MonitoringForm : Form
    {


        public MonitoringForm()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
            SystemSingleton.Instance.page1 = tabPage1;
        }
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            FocusInAndOut(btnSideMenu_Student);
        }

        private void FocusInAndOut(Button button)
        {
            Button[] buttons = { btnSideMenu_Student, btnSideMenu_TaskManagement, btnSideMenu_FileManagement, btnSideMenu_Settings };

            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(13, 13, 13);
                if (b == button)
                    b.BackColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change backcolor
            FocusInAndOut(btnSideMenu_TaskManagement);
            if (!SystemSingleton.Instance._loggedIn)
            {
                TcpClient client = new TcpClient();
                var searchServer = new LoadingDialog(client);
                searchServer.ShowDialog();
                if (client.Connected)
                {
                    var userLogIn = new UserLogInDIalog(client);
                    if (userLogIn.ShowDialog() == DialogResult.OK)
                    {
                        var studentProgramming = new TempIDE(userLogIn._userName, userLogIn.serverTask, userLogIn.progress, userLogIn._stream);
                        SystemSingleton.Instance._loggedIn = true;
                        studentProgramming.ShowDialog();
                    }
                    else
                    {
                        SystemSingleton.Instance._loggedIn = false;
                        userLogIn.Dispose();
                        return;
                    }
                    searchServer.CloseMe();
                    userLogIn.Dispose();
                }
                else
                    return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;

            FocusInAndOut(btnSideMenu_FileManagement);
        }

        private void btnSideMenu_Settings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            //change backcolor
            FocusInAndOut(btnSideMenu_Settings);
        }

        private void btnSideMenu_Shutdown_Click(object sender, EventArgs e)
        {
            InstructorSide instructorSide = new InstructorSide();
            instructorSide.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var todelete = new ChatBox();
            todelete.ShowDialog();
            todelete.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;

        }

        private void button8_Click(object sender, EventArgs e)
        {
           TempIDE tempIDE = new TempIDE();
            tempIDE.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollaseMenu();
        }

        private void CollaseMenu()
        {
            if (this.sideMenuPanel.Width > 200)
            {
                this.sideMenuPanel.Width = 100;

                foreach (Button button in this.sideMenuPanel.Controls.OfType<Button>())
                {
                    button.Text = "";
                    button.Size = new System.Drawing.Size(64, 60);
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
            else
            {
                this.sideMenuPanel.Width = 256;

                foreach (Button button in this.sideMenuPanel.Controls.OfType<Button>())
                {
                    button.Text = "   " + button.Tag.ToString();
                    button.Size = new System.Drawing.Size(215, 60);
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}
