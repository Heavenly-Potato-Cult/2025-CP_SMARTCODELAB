using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.ServerPageComponents;

namespace SmartCodeLab
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavHost = new Panel();
            tabcontrol_MainNav = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage10 = new TabPage();
            tempSessionManagement21 = new TempSessionManagement2();
            tabPage7 = new TabPage();
            tempExerciseManage1 = new TempExerciseManage();
            tabPage8 = new TabPage();
            tabPage1 = new TabPage();
            tabcontrol_MainNav.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavHost
            // 
            panelNavHost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavHost.BackColor = SystemColors.ActiveCaptionText;
            panelNavHost.Dock = DockStyle.Top;
            panelNavHost.Location = new Point(0, 0);
            panelNavHost.Margin = new Padding(0, 0, 0, 6);
            panelNavHost.Name = "panelNavHost";
            panelNavHost.Size = new Size(1924, 58);
            panelNavHost.TabIndex = 0;
            // 
            // tabcontrol_MainNav
            // 
            tabcontrol_MainNav.Controls.Add(tabPage10);
            tabcontrol_MainNav.Controls.Add(tabPage7);
            tabcontrol_MainNav.Controls.Add(tabPage8);
            tabcontrol_MainNav.Controls.Add(tabPage1);
            tabcontrol_MainNav.Depth = 0;
            tabcontrol_MainNav.Dock = DockStyle.Fill;
            tabcontrol_MainNav.Location = new Point(0, 58);
            tabcontrol_MainNav.Margin = new Padding(2);
            tabcontrol_MainNav.MouseState = MaterialSkin.MouseState.HOVER;
            tabcontrol_MainNav.Multiline = true;
            tabcontrol_MainNav.Name = "tabcontrol_MainNav";
            tabcontrol_MainNav.SelectedIndex = 0;
            tabcontrol_MainNav.Size = new Size(1924, 997);
            tabcontrol_MainNav.TabIndex = 3;
            // 
            // tabPage10
            // 
            tabPage10.BackColor = Color.WhiteSmoke;
            tabPage10.Controls.Add(tempSessionManagement21);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Margin = new Padding(4);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1916, 964);
            tabPage10.TabIndex = 3;
            tabPage10.Text = "tabPage10";
            // 
            // tempSessionManagement21
            // 
            tempSessionManagement21.BackColor = SystemColors.Control;
            tempSessionManagement21.Dock = DockStyle.Fill;
            tempSessionManagement21.Location = new Point(0, 0);
            tempSessionManagement21.Margin = new Padding(4, 2, 4, 2);
            tempSessionManagement21.Name = "tempSessionManagement21";
            tempSessionManagement21.Size = new Size(1916, 964);
            tempSessionManagement21.TabIndex = 0;
            tempSessionManagement21.Load += tempSessionManagement21_Load;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = SystemColors.Control;
            tabPage7.Controls.Add(tempExerciseManage1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1916, 964);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "tabPage7";
            // 
            // tempExerciseManage1
            // 
            tempExerciseManage1.AllowDrop = true;
            tempExerciseManage1.Dock = DockStyle.Fill;
            tempExerciseManage1.Location = new Point(0, 0);
            tempExerciseManage1.Margin = new Padding(2);
            tempExerciseManage1.Name = "tempExerciseManage1";
            tempExerciseManage1.Size = new Size(1916, 964);
            tempExerciseManage1.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.White;
            tabPage8.Location = new Point(4, 29);
            tabPage8.Margin = new Padding(0);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1916, 964);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "tabPage8";
            tabPage8.Enter += tabPage8_Enter;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1916, 964);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tabcontrol_MainNav);
            Controls.Add(panelNavHost);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartCodeLab";
            WindowState = FormWindowState.Maximized;
            FormClosing += InstructorForm_FormClosing;
            tabcontrol_MainNav.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavHost;
        private CustomComponents.GeneralComponents.SmoothTabControl tabcontrol_MainNav;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private CustomComponents.ServerPageComponents.TempExerciseManage tempExerciseManage1;
        private CustomComponents.Pages.ServerPages.StudentTable2 studenTable21;
        private TabPage tabPage10;
        private CustomComponents.ServerPageComponents.TempSessionManagement2 tempSessionManagement21;
        private TabPage tabPage1;
    }
}