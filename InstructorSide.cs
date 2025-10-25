using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab
{
    public partial class InstructorSide : Form
    {
        public InstructorSide()
        {
            InitializeComponent();
            panel_SubMenu_ActiveSession.Visible = false;
            panel_SubMenu_Management.Visible = false;
            btn_SideMenu_ActiveSession.Visible = false;
        }


        private void ToggleSubMenu(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void smartButton13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void smartButton12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void smartButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }




        private void btn_SideMenu_ActiveSession_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panel_SubMenu_ActiveSession);
        }

        private void btn_SideMenu_Management_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panel_SubMenu_Management);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_SideMenu_ActiveSession.Visible = !btn_SideMenu_ActiveSession.Visible;

        }

        private void btn_SideMenu_SessionSetup_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 0;
        }

        private void btn_SubMenu_Dashboard_Click(object sender, EventArgs e)
        {

            smthTabControl_Main.SelectedIndex = 1;
        }

        private void btn_SubMenu_StudentMonitoring_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 2;

        }

        private void btn_SubMenu_ExerciseManagement_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 4;

        }

        private void btn_SideMenu_SubmissionReview_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 5;

        }

        private void btn_SideMenu_Settings_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 6;
        }

        private void btn_SubMenu_ClassManagement_Click(object sender, EventArgs e)
        {
            smthTabControl_Main.SelectedIndex = 3;
        }
    }
}
