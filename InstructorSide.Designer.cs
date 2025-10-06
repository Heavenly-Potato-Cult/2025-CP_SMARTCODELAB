namespace SmartCodeLab
{
    partial class InstructorSide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorSide));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            smartButton11 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton12 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton13 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            sideMenuPanel = new Panel();
            btnSideMenu_Settings = new Button();
            btnSideMenu_Report = new Button();
            btnSideMenu_CodeEvaluation = new Button();
            panel_Title = new Panel();
            btnSideMenu_Dashboard = new Button();
            btnSideMenu_ExerciseManagement = new Button();
            btnSideMenu_SessionManagement = new Button();
            btnSideMenu_StudentMonitoring = new Button();
            panel1 = new Panel();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label1 = new Label();
            tabPage2 = new TabPage();
            tempSessionManagement1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempSessionManagement();
            tabPage1 = new TabPage();
            tempDashboard1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempDashboard();
            smthTabControl_Main = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage3 = new TabPage();
            tempExerciseManage1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempExerciseManage();
            tabPage4 = new TabPage();
            tempServerPage1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempServerPage();
            tabPage5 = new TabPage();
            tempCodeEvaluation1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempCodeEvaluation();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideMenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            customCard1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            smthTabControl_Main.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(79, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "SmartCodeLab";
            // 
            // smartButton11
            // 
            smartButton11.BackColor = Color.White;
            smartButton11.BackgroundColor = Color.White;
            smartButton11.BorderRadius = 2;
            smartButton11.Dock = DockStyle.Right;
            smartButton11.FlatAppearance.BorderSize = 0;
            smartButton11.FlatStyle = FlatStyle.Flat;
            smartButton11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            smartButton11.ForeColor = SystemColors.Control;
            smartButton11.Image = (Image)resources.GetObject("smartButton11.Image");
            smartButton11.Location = new Point(1235, 0);
            smartButton11.Name = "smartButton11";
            smartButton11.Size = new Size(45, 104);
            smartButton11.TabIndex = 3;
            smartButton11.TextColor = SystemColors.Control;
            smartButton11.UseVisualStyleBackColor = false;
            smartButton11.Click += smartButton11_Click;
            // 
            // smartButton12
            // 
            smartButton12.BackColor = Color.White;
            smartButton12.BackgroundColor = Color.White;
            smartButton12.BorderRadius = 2;
            smartButton12.Dock = DockStyle.Right;
            smartButton12.FlatAppearance.BorderSize = 0;
            smartButton12.FlatStyle = FlatStyle.Flat;
            smartButton12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            smartButton12.ForeColor = SystemColors.Control;
            smartButton12.Image = (Image)resources.GetObject("smartButton12.Image");
            smartButton12.Location = new Point(1280, 0);
            smartButton12.Name = "smartButton12";
            smartButton12.Size = new Size(45, 104);
            smartButton12.TabIndex = 2;
            smartButton12.TextColor = SystemColors.Control;
            smartButton12.UseVisualStyleBackColor = false;
            smartButton12.Click += smartButton12_Click;
            // 
            // smartButton13
            // 
            smartButton13.BackColor = Color.White;
            smartButton13.BackgroundColor = Color.White;
            smartButton13.BorderRadius = 2;
            smartButton13.Dock = DockStyle.Right;
            smartButton13.FlatAppearance.BorderSize = 0;
            smartButton13.FlatStyle = FlatStyle.Flat;
            smartButton13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            smartButton13.ForeColor = SystemColors.Control;
            smartButton13.Image = (Image)resources.GetObject("smartButton13.Image");
            smartButton13.Location = new Point(1325, 0);
            smartButton13.Margin = new Padding(3, 3, 20, 3);
            smartButton13.Name = "smartButton13";
            smartButton13.Size = new Size(45, 104);
            smartButton13.TabIndex = 1;
            smartButton13.TextColor = SystemColors.Control;
            smartButton13.UseVisualStyleBackColor = false;
            smartButton13.Click += smartButton13_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(13, 13, 13);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_Report);
            sideMenuPanel.Controls.Add(btnSideMenu_CodeEvaluation);
            sideMenuPanel.Controls.Add(panel_Title);
            sideMenuPanel.Controls.Add(btnSideMenu_Dashboard);
            sideMenuPanel.Controls.Add(btnSideMenu_ExerciseManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_SessionManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_StudentMonitoring);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Margin = new Padding(3, 4, 3, 4);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(256, 1018);
            sideMenuPanel.TabIndex = 5;
            // 
            // btnSideMenu_Settings
            // 
            btnSideMenu_Settings.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Settings.Cursor = Cursors.Hand;
            btnSideMenu_Settings.FlatAppearance.BorderSize = 0;
            btnSideMenu_Settings.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Settings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_Settings.ForeColor = Color.White;
            btnSideMenu_Settings.Image = (Image)resources.GetObject("btnSideMenu_Settings.Image");
            btnSideMenu_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Settings.Location = new Point(8, 479);
            btnSideMenu_Settings.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Settings.Size = new Size(241, 60);
            btnSideMenu_Settings.TabIndex = 14;
            btnSideMenu_Settings.Tag = "Settings";
            btnSideMenu_Settings.Text = "   Settings";
            btnSideMenu_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_Report
            // 
            btnSideMenu_Report.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Report.Cursor = Cursors.Hand;
            btnSideMenu_Report.FlatAppearance.BorderSize = 0;
            btnSideMenu_Report.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Report.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_Report.ForeColor = Color.White;
            btnSideMenu_Report.Image = (Image)resources.GetObject("btnSideMenu_Report.Image");
            btnSideMenu_Report.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Report.Location = new Point(8, 422);
            btnSideMenu_Report.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Report.Name = "btnSideMenu_Report";
            btnSideMenu_Report.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Report.Size = new Size(241, 60);
            btnSideMenu_Report.TabIndex = 13;
            btnSideMenu_Report.Tag = "Settings";
            btnSideMenu_Report.Text = "   Statistics / Report";
            btnSideMenu_Report.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Report.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_CodeEvaluation
            // 
            btnSideMenu_CodeEvaluation.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_CodeEvaluation.Cursor = Cursors.Hand;
            btnSideMenu_CodeEvaluation.FlatAppearance.BorderSize = 0;
            btnSideMenu_CodeEvaluation.FlatStyle = FlatStyle.Flat;
            btnSideMenu_CodeEvaluation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_CodeEvaluation.ForeColor = Color.White;
            btnSideMenu_CodeEvaluation.Image = (Image)resources.GetObject("btnSideMenu_CodeEvaluation.Image");
            btnSideMenu_CodeEvaluation.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_CodeEvaluation.Location = new Point(8, 369);
            btnSideMenu_CodeEvaluation.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_CodeEvaluation.Name = "btnSideMenu_CodeEvaluation";
            btnSideMenu_CodeEvaluation.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_CodeEvaluation.Size = new Size(241, 60);
            btnSideMenu_CodeEvaluation.TabIndex = 12;
            btnSideMenu_CodeEvaluation.Tag = "Settings";
            btnSideMenu_CodeEvaluation.Text = "   Code Evaluation";
            btnSideMenu_CodeEvaluation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_CodeEvaluation.UseVisualStyleBackColor = false;
            btnSideMenu_CodeEvaluation.Click += btnSideMenu_CodeEvaluation_Click;
            // 
            // panel_Title
            // 
            panel_Title.Dock = DockStyle.Top;
            panel_Title.Location = new Point(0, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(256, 125);
            panel_Title.TabIndex = 0;
            // 
            // btnSideMenu_Dashboard
            // 
            btnSideMenu_Dashboard.BackColor = Color.FromArgb(26, 26, 26);
            btnSideMenu_Dashboard.Cursor = Cursors.Hand;
            btnSideMenu_Dashboard.FlatAppearance.BorderSize = 0;
            btnSideMenu_Dashboard.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Dashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_Dashboard.ForeColor = Color.White;
            btnSideMenu_Dashboard.Image = (Image)resources.GetObject("btnSideMenu_Dashboard.Image");
            btnSideMenu_Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Dashboard.Location = new Point(8, 132);
            btnSideMenu_Dashboard.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Dashboard.Name = "btnSideMenu_Dashboard";
            btnSideMenu_Dashboard.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Dashboard.Size = new Size(241, 60);
            btnSideMenu_Dashboard.TabIndex = 1;
            btnSideMenu_Dashboard.Tag = "Connection";
            btnSideMenu_Dashboard.Text = "   Dashboard";
            btnSideMenu_Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Dashboard.UseVisualStyleBackColor = false;
            btnSideMenu_Dashboard.Click += btnSideMenu_Dashboard_Click;
            // 
            // btnSideMenu_ExerciseManagement
            // 
            btnSideMenu_ExerciseManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_ExerciseManagement.Cursor = Cursors.Hand;
            btnSideMenu_ExerciseManagement.FlatAppearance.BorderSize = 0;
            btnSideMenu_ExerciseManagement.FlatStyle = FlatStyle.Flat;
            btnSideMenu_ExerciseManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_ExerciseManagement.ForeColor = Color.White;
            btnSideMenu_ExerciseManagement.Image = (Image)resources.GetObject("btnSideMenu_ExerciseManagement.Image");
            btnSideMenu_ExerciseManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_ExerciseManagement.Location = new Point(8, 252);
            btnSideMenu_ExerciseManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_ExerciseManagement.Name = "btnSideMenu_ExerciseManagement";
            btnSideMenu_ExerciseManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_ExerciseManagement.Size = new Size(241, 60);
            btnSideMenu_ExerciseManagement.TabIndex = 3;
            btnSideMenu_ExerciseManagement.Tag = "Exercise Manager";
            btnSideMenu_ExerciseManagement.Text = "   Exercise Manager";
            btnSideMenu_ExerciseManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_ExerciseManagement.UseVisualStyleBackColor = false;
            btnSideMenu_ExerciseManagement.Click += btnSideMenu_ExerciseManagement_Click;
            // 
            // btnSideMenu_SessionManagement
            // 
            btnSideMenu_SessionManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_SessionManagement.Cursor = Cursors.Hand;
            btnSideMenu_SessionManagement.FlatAppearance.BorderSize = 0;
            btnSideMenu_SessionManagement.FlatStyle = FlatStyle.Flat;
            btnSideMenu_SessionManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_SessionManagement.ForeColor = Color.White;
            btnSideMenu_SessionManagement.Image = (Image)resources.GetObject("btnSideMenu_SessionManagement.Image");
            btnSideMenu_SessionManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_SessionManagement.Location = new Point(8, 192);
            btnSideMenu_SessionManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_SessionManagement.Name = "btnSideMenu_SessionManagement";
            btnSideMenu_SessionManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_SessionManagement.Size = new Size(241, 60);
            btnSideMenu_SessionManagement.TabIndex = 2;
            btnSideMenu_SessionManagement.Tag = "Task Management";
            btnSideMenu_SessionManagement.Text = "   Session Management";
            btnSideMenu_SessionManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_SessionManagement.UseVisualStyleBackColor = false;
            btnSideMenu_SessionManagement.Click += btnSideMenu_SessionManagement_Click;
            // 
            // btnSideMenu_StudentMonitoring
            // 
            btnSideMenu_StudentMonitoring.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_StudentMonitoring.Cursor = Cursors.Hand;
            btnSideMenu_StudentMonitoring.FlatAppearance.BorderSize = 0;
            btnSideMenu_StudentMonitoring.FlatStyle = FlatStyle.Flat;
            btnSideMenu_StudentMonitoring.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_StudentMonitoring.ForeColor = Color.White;
            btnSideMenu_StudentMonitoring.Image = (Image)resources.GetObject("btnSideMenu_StudentMonitoring.Image");
            btnSideMenu_StudentMonitoring.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_StudentMonitoring.Location = new Point(8, 312);
            btnSideMenu_StudentMonitoring.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_StudentMonitoring.Name = "btnSideMenu_StudentMonitoring";
            btnSideMenu_StudentMonitoring.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_StudentMonitoring.Size = new Size(241, 60);
            btnSideMenu_StudentMonitoring.TabIndex = 4;
            btnSideMenu_StudentMonitoring.Tag = "Settings";
            btnSideMenu_StudentMonitoring.Text = "   Student Monitoring";
            btnSideMenu_StudentMonitoring.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_StudentMonitoring.UseVisualStyleBackColor = false;
            btnSideMenu_StudentMonitoring.Click += btnSideMenu_StudentMonitoring_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(customCard1);
            panel1.Controls.Add(smartButton11);
            panel1.Controls.Add(smartButton12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(smartButton13);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(256, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 104);
            panel1.TabIndex = 6;
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Left;
            customCard1.BackColor = Color.FromArgb(192, 255, 192);
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(331, 28);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(161, 49);
            customCard1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 16;
            label1.Text = "Session Active";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tempSessionManagement1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1362, 880);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tempSessionManagement1
            // 
            tempSessionManagement1.Dock = DockStyle.Fill;
            tempSessionManagement1.Location = new Point(3, 3);
            tempSessionManagement1.Name = "tempSessionManagement1";
            tempSessionManagement1.Size = new Size(1356, 874);
            tempSessionManagement1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tempDashboard1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 880);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tempDashboard1
            // 
            tempDashboard1.Dock = DockStyle.Fill;
            tempDashboard1.Location = new Point(3, 3);
            tempDashboard1.Name = "tempDashboard1";
            tempDashboard1.Size = new Size(1356, 874);
            tempDashboard1.TabIndex = 0;
            // 
            // smthTabControl_Main
            // 
            smthTabControl_Main.Controls.Add(tabPage1);
            smthTabControl_Main.Controls.Add(tabPage2);
            smthTabControl_Main.Controls.Add(tabPage3);
            smthTabControl_Main.Controls.Add(tabPage4);
            smthTabControl_Main.Controls.Add(tabPage5);
            smthTabControl_Main.Controls.Add(tabPage6);
            smthTabControl_Main.Controls.Add(tabPage7);
            smthTabControl_Main.Depth = 0;
            smthTabControl_Main.Dock = DockStyle.Fill;
            smthTabControl_Main.Location = new Point(256, 105);
            smthTabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            smthTabControl_Main.Multiline = true;
            smthTabControl_Main.Name = "smthTabControl_Main";
            smthTabControl_Main.SelectedIndex = 0;
            smthTabControl_Main.Size = new Size(1370, 913);
            smthTabControl_Main.TabIndex = 7;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tempExerciseManage1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1362, 880);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tempExerciseManage1
            // 
            tempExerciseManage1.AutoScroll = true;
            tempExerciseManage1.Dock = DockStyle.Fill;
            tempExerciseManage1.Location = new Point(0, 0);
            tempExerciseManage1.Name = "tempExerciseManage1";
            tempExerciseManage1.Size = new Size(1362, 880);
            tempExerciseManage1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tempServerPage1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1362, 880);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tempServerPage1
            // 
            tempServerPage1.AutoScroll = true;
            tempServerPage1.BackColor = Color.WhiteSmoke;
            tempServerPage1.Dock = DockStyle.Fill;
            tempServerPage1.Location = new Point(0, 0);
            tempServerPage1.Name = "tempServerPage1";
            tempServerPage1.Size = new Size(1362, 880);
            tempServerPage1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tempCodeEvaluation1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1362, 880);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tempCodeEvaluation1
            // 
            tempCodeEvaluation1.AutoScroll = true;
            tempCodeEvaluation1.Dock = DockStyle.Fill;
            tempCodeEvaluation1.Location = new Point(0, 0);
            tempCodeEvaluation1.Name = "tempCodeEvaluation1";
            tempCodeEvaluation1.Size = new Size(1362, 880);
            tempCodeEvaluation1.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1362, 880);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1362, 880);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(256, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 1);
            panel2.TabIndex = 8;
            // 
            // InstructorSide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 1018);
            Controls.Add(smthTabControl_Main);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sideMenuPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1626, 976);
            Name = "InstructorSide";
            Text = "InstructorSide";
            Load += InstructorSide_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideMenuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            smthTabControl_Main.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Title;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private CustomComponents.GeneralComponents.SmartButton smartButton11;
        private CustomComponents.GeneralComponents.SmartButton smartButton12;
        private CustomComponents.GeneralComponents.SmartButton smartButton13;
        private Panel sideMenuPanel;
        private Button btnSideMenu_StudentMonitoring;
        private Button btnSideMenu_ExerciseManagement;
        private Button btnSideMenu_SessionManagement;
        private Button btnSideMenu_Dashboard;
        private Panel panel1;
        private Button btnSideMenu_CodeEvaluation;
        private Button btnSideMenu_Report;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private CustomComponents.GeneralComponents.SmoothTabControl smthTabControl_Main;
        private CustomComponents.ServerPageComponents.TempDashboard tempDashboard1;
        private Panel panel2;
        private TabPage tabPage3;
        private CustomComponents.ServerPageComponents.TempExerciseManage tempExerciseManage1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button btnSideMenu_Settings;
        private CustomComponents.ServerPageComponents.TempServerPage tempServerPage1;
        private CustomComponents.ServerPageComponents.TempCodeEvaluation tempCodeEvaluation1;
        private TabPage tabPage7;
        private CustomComponents.ServerPageComponents.TempSessionManagement tempSessionManagement1;
        private CustomComponents.GeneralComponents.CustomCard customCard1;
        private Label label1;
    }
}