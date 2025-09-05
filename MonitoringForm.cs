using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.MainPages;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            SystemSingleton.Instance.page2 = tabPage2;
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            //change backcolor
            btnSideMenu_Student.BackColor = Color.FromArgb(26, 26, 26);
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_FileManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Settings.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change backcolor
            btnSideMenu_Student.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(26, 26, 26);
            btnSideMenu_FileManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Settings.BackColor = Color.FromArgb(13, 13, 13);

            if (!SystemSingleton.Instance._loggedIn)
            {
                var searchServer = new LoadingDialog();
                searchServer.ShowDialog();
                TcpClient client = searchServer.client;
                searchServer.Dispose();
                if (client.Connected)
                {
                    searchServer.Dispose();
                    var userLogIn = new UserLogInDIalog(client);
                    if (userLogIn.ShowDialog() == DialogResult.OK)
                    {
                        var studentProgramming = new ProgrammingEnvironment(userLogIn._folderLocation, userLogIn._userName, userLogIn.serverTask, userLogIn._stream);
                        SystemSingleton.Instance.page2.Controls.Clear();
                        SystemSingleton.Instance.page2.Controls.Add(studentProgramming);
                        SystemSingleton.Instance._loggedIn = true;
                    }
                    else
                    {
                        SystemSingleton.Instance._loggedIn = false;
                        userLogIn.Dispose();
                        return;
                    }
                    userLogIn.Dispose();
                }
                else
                    return;
            }
            tabControl1.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;


            //change backcolor
            btnSideMenu_Student.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_FileManagement.BackColor = Color.FromArgb(26, 26, 26);
            btnSideMenu_Settings.BackColor = Color.FromArgb(13, 13, 13);
        }

        private void btnSideMenu_Settings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            //change backcolor
            btnSideMenu_Student.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_FileManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Settings.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonitoringForm_Load(object sender, EventArgs e)
        {


        }

        private void btnSideMenu_Shutdown_Click(object sender, EventArgs e)
        {
            Application.OpenForms["StudentIDEform"].Show();
            this.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
    }
}
