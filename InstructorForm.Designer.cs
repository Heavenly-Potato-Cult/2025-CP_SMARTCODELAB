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
            panelNavHost2 = new Panel();
            tabcontrol_session = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage1 = new TabPage();
            serverHomePage1 = new SmartCodeLab.CustomComponents.Pages.ServerPages.ServerHomePage();
            tabPage2 = new TabPage();
            tempServerPage1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempServerPage();
            tabPage3 = new TabPage();
            serverTaskUpdate1 = new SmartCodeLab.CustomComponents.Pages.ServerPages.ServerTaskUpdate();
            tabPage5 = new TabPage();
            progressSubmissionPage1 = new SmartCodeLab.CustomComponents.Pages.ServerPages.ProgressSubmissionPage();
            tabPage4 = new TabPage();
            studentTable21 = new SmartCodeLab.CustomComponents.Pages.ServerPages.StudentTable2();
            tabPage9 = new TabPage();
            label5 = new Label();
            tabcontrol_MainNav = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage10 = new TabPage();
            tempSessionManagement21 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempSessionManagement2();
            tabPage7 = new TabPage();
            tempExerciseManage1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempExerciseManage();
            tabPage8 = new TabPage();
            tabPage6 = new TabPage();
            tabcontrol_session.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage9.SuspendLayout();
            tabcontrol_MainNav.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavHost
            // 
            panelNavHost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavHost.BackColor = SystemColors.ActiveCaptionText;
            panelNavHost.Dock = DockStyle.Top;
            panelNavHost.Location = new Point(0, 0);
            panelNavHost.Margin = new Padding(0, 0, 0, 5);
            panelNavHost.Name = "panelNavHost";
            panelNavHost.Size = new Size(1484, 46);
            panelNavHost.TabIndex = 0;
            // 
            // panelNavHost2
            // 
            panelNavHost2.BackColor = Color.FromArgb(42, 46, 53);
            panelNavHost2.Dock = DockStyle.Top;
            panelNavHost2.Location = new Point(2, 2);
            panelNavHost2.Margin = new Padding(0, 0, 0, 5);
            panelNavHost2.Name = "panelNavHost2";
            panelNavHost2.Size = new Size(188, 46);
            panelNavHost2.TabIndex = 1;
            // 
            // tabcontrol_session
            // 
            tabcontrol_session.Controls.Add(tabPage1);
            tabcontrol_session.Controls.Add(tabPage2);
            tabcontrol_session.Controls.Add(tabPage3);
            tabcontrol_session.Controls.Add(tabPage5);
            tabcontrol_session.Controls.Add(tabPage4);
            tabcontrol_session.Controls.Add(tabPage9);
            tabcontrol_session.Depth = 0;
            tabcontrol_session.Dock = DockStyle.Fill;
            tabcontrol_session.Location = new Point(2, 48);
            tabcontrol_session.Margin = new Padding(2);
            tabcontrol_session.MouseState = MaterialSkin.MouseState.HOVER;
            tabcontrol_session.Multiline = true;
            tabcontrol_session.Name = "tabcontrol_session";
            tabcontrol_session.SelectedIndex = 0;
            tabcontrol_session.Size = new Size(188, 2);
            tabcontrol_session.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(serverHomePage1);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(180, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // serverHomePage1
            // 
            serverHomePage1.Dock = DockStyle.Fill;
            serverHomePage1.Location = new Point(2, 2);
            serverHomePage1.Margin = new Padding(3, 2, 50, 2);
            serverHomePage1.Name = "serverHomePage1";
            serverHomePage1.Size = new Size(176, 0);
            serverHomePage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(tempServerPage1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1464, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // tempServerPage1
            // 
            tempServerPage1.AutoScroll = true;
            tempServerPage1.BackColor = Color.WhiteSmoke;
            tempServerPage1.Dock = DockStyle.Fill;
            tempServerPage1.Location = new Point(2, 2);
            tempServerPage1.Margin = new Padding(2, 3, 2, 3);
            tempServerPage1.Name = "tempServerPage1";
            tempServerPage1.Size = new Size(1460, 616);
            tempServerPage1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(serverTaskUpdate1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1464, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // serverTaskUpdate1
            // 
            serverTaskUpdate1.Anchor = AnchorStyles.Top;
            serverTaskUpdate1.Location = new Point(115, 50);
            serverTaskUpdate1.Margin = new Padding(3, 2, 3, 2);
            serverTaskUpdate1.Name = "serverTaskUpdate1";
            serverTaskUpdate1.Size = new Size(1186, 629);
            serverTaskUpdate1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.AutoScroll = true;
            tabPage5.Controls.Add(progressSubmissionPage1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1464, 620);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // progressSubmissionPage1
            // 
            progressSubmissionPage1.BackColor = Color.Gray;
            progressSubmissionPage1.Location = new Point(127, 35);
            progressSubmissionPage1.Margin = new Padding(3, 2, 3, 2);
            progressSubmissionPage1.Name = "progressSubmissionPage1";
            progressSubmissionPage1.Size = new Size(1192, 1416);
            progressSubmissionPage1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(studentTable21);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1464, 620);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // studentTable21
            // 
            studentTable21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentTable21.Location = new Point(244, 35);
            studentTable21.Margin = new Padding(3, 4, 3, 4);
            studentTable21.Name = "studentTable21";
            studentTable21.Size = new Size(1284, 874);
            studentTable21.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(label5);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Margin = new Padding(2);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1464, 620);
            tabPage9.TabIndex = 5;
            tabPage9.Text = "tabPage9";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 135);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // tabcontrol_MainNav
            // 
            tabcontrol_MainNav.Controls.Add(tabPage10);
            tabcontrol_MainNav.Controls.Add(tabPage7);
            tabcontrol_MainNav.Controls.Add(tabPage8);
            tabcontrol_MainNav.Controls.Add(tabPage6);
            tabcontrol_MainNav.Depth = 0;
            tabcontrol_MainNav.Dock = DockStyle.Fill;
            tabcontrol_MainNav.Location = new Point(0, 46);
            tabcontrol_MainNav.Margin = new Padding(2);
            tabcontrol_MainNav.MouseState = MaterialSkin.MouseState.HOVER;
            tabcontrol_MainNav.Multiline = true;
            tabcontrol_MainNav.Name = "tabcontrol_MainNav";
            tabcontrol_MainNav.SelectedIndex = 0;
            tabcontrol_MainNav.Size = new Size(1484, 726);
            tabcontrol_MainNav.TabIndex = 3;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(tempSessionManagement21);
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1476, 698);
            tabPage10.TabIndex = 3;
            tabPage10.Text = "tabPage10";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tempSessionManagement21
            // 
            tempSessionManagement21.Location = new Point(104, 2);
            tempSessionManagement21.Margin = new Padding(3, 2, 3, 2);
            tempSessionManagement21.Name = "tempSessionManagement21";
            tempSessionManagement21.Size = new Size(1093, 947);
            tempSessionManagement21.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = SystemColors.Control;
            tabPage7.Controls.Add(tempExerciseManage1);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Margin = new Padding(2);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(2);
            tabPage7.Size = new Size(1476, 698);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "tabPage7";
            // 
            // tempExerciseManage1
            // 
            tempExerciseManage1.AllowDrop = true;
            tempExerciseManage1.Dock = DockStyle.Fill;
            tempExerciseManage1.Location = new Point(2, 2);
            tempExerciseManage1.Margin = new Padding(2);
            tempExerciseManage1.Name = "tempExerciseManage1";
            tempExerciseManage1.Size = new Size(1472, 694);
            tempExerciseManage1.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.Tomato;
            tabPage8.Location = new Point(4, 44);
            tabPage8.Margin = new Padding(2);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(192, 52);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "tabPage8";
            tabPage8.Enter += tabPage8_Enter;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = SystemColors.Control;
            tabPage6.Controls.Add(tabcontrol_session);
            tabPage6.Controls.Add(panelNavHost2);
            tabPage6.Location = new Point(4, 44);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(2);
            tabPage6.Size = new Size(192, 52);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "tabPage6";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1484, 772);
            Controls.Add(tabcontrol_MainNav);
            Controls.Add(panelNavHost);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartCodeLab";
            tabcontrol_session.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            tabcontrol_MainNav.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavHost;
        private Panel panelNavHost2;
        private CustomComponents.GeneralComponents.SmoothTabControl tabcontrol_session;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private CustomComponents.GeneralComponents.SmoothTabControl tabcontrol_MainNav;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private CustomComponents.ServerPageComponents.TempExerciseManage tempExerciseManage1;
        private TabPage tabPage9;
        private Label label5;
        private CustomComponents.ServerPageComponents.TempServerPage tempServerPage1;
        private CustomComponents.Pages.ServerPages.ServerTaskUpdate serverTaskUpdate1;
        private CustomComponents.Pages.ServerPages.ServerHomePage serverHomePage1;
        private CustomComponents.Pages.ServerPages.StudentTable2 studenTable21;
        private CustomComponents.Pages.ServerPages.StudentTable2 studentTable21;
        private CustomComponents.Pages.ServerPages.ProgressSubmissionPage progressSubmissionPage1;
        private TabPage tabPage10;
        private CustomComponents.ServerPageComponents.TempSessionManagement2 tempSessionManagement21;
    }
}