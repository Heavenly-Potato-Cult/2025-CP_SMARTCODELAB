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
            button2 = new Button();
            button1 = new Button();
            panel_Title = new Panel();
            btnSideMenu_Student = new Button();
            btnSideMenu_FileManagement = new Button();
            btnSideMenu_TaskManagement = new Button();
            btnSideMenu_Settings = new Button();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            smoothTabControl1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideMenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            smoothTabControl1.SuspendLayout();
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
            pictureBox1.Click += pictureBox1_Click;
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
            sideMenuPanel.Controls.Add(button2);
            sideMenuPanel.Controls.Add(button1);
            sideMenuPanel.Controls.Add(panel_Title);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Controls.Add(btnSideMenu_FileManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_TaskManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Margin = new Padding(3, 4, 3, 4);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(256, 1018);
            sideMenuPanel.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(13, 13, 13);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(8, 422);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(241, 60);
            button2.TabIndex = 13;
            button2.Tag = "Settings";
            button2.Text = "   Settings";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(13, 13, 13);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 369);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(241, 60);
            button1.TabIndex = 12;
            button1.Tag = "Settings";
            button1.Text = "   Code Evaluation";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel_Title
            // 
            panel_Title.Dock = DockStyle.Top;
            panel_Title.Location = new Point(0, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(256, 125);
            panel_Title.TabIndex = 0;
            // 
            // btnSideMenu_Student
            // 
            btnSideMenu_Student.BackColor = Color.FromArgb(26, 26, 26);
            btnSideMenu_Student.Cursor = Cursors.Hand;
            btnSideMenu_Student.FlatAppearance.BorderSize = 0;
            btnSideMenu_Student.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Student.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_Student.ForeColor = Color.White;
            btnSideMenu_Student.Image = (Image)resources.GetObject("btnSideMenu_Student.Image");
            btnSideMenu_Student.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Student.Location = new Point(8, 132);
            btnSideMenu_Student.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Student.Name = "btnSideMenu_Student";
            btnSideMenu_Student.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Student.Size = new Size(241, 60);
            btnSideMenu_Student.TabIndex = 1;
            btnSideMenu_Student.Tag = "Connection";
            btnSideMenu_Student.Text = "   Dashboard";
            btnSideMenu_Student.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Student.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_FileManagement
            // 
            btnSideMenu_FileManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_FileManagement.Cursor = Cursors.Hand;
            btnSideMenu_FileManagement.FlatAppearance.BorderSize = 0;
            btnSideMenu_FileManagement.FlatStyle = FlatStyle.Flat;
            btnSideMenu_FileManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_FileManagement.ForeColor = Color.White;
            btnSideMenu_FileManagement.Image = (Image)resources.GetObject("btnSideMenu_FileManagement.Image");
            btnSideMenu_FileManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_FileManagement.Location = new Point(8, 252);
            btnSideMenu_FileManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_FileManagement.Name = "btnSideMenu_FileManagement";
            btnSideMenu_FileManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_FileManagement.Size = new Size(241, 60);
            btnSideMenu_FileManagement.TabIndex = 3;
            btnSideMenu_FileManagement.Tag = "Exercise Manager";
            btnSideMenu_FileManagement.Text = "   Exercise Manager";
            btnSideMenu_FileManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_FileManagement.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_TaskManagement
            // 
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_TaskManagement.Cursor = Cursors.Hand;
            btnSideMenu_TaskManagement.FlatAppearance.BorderSize = 0;
            btnSideMenu_TaskManagement.FlatStyle = FlatStyle.Flat;
            btnSideMenu_TaskManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_TaskManagement.ForeColor = Color.White;
            btnSideMenu_TaskManagement.Image = (Image)resources.GetObject("btnSideMenu_TaskManagement.Image");
            btnSideMenu_TaskManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_TaskManagement.Location = new Point(8, 192);
            btnSideMenu_TaskManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_TaskManagement.Name = "btnSideMenu_TaskManagement";
            btnSideMenu_TaskManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_TaskManagement.Size = new Size(241, 60);
            btnSideMenu_TaskManagement.TabIndex = 2;
            btnSideMenu_TaskManagement.Tag = "Task Management";
            btnSideMenu_TaskManagement.Text = "   Session Management";
            btnSideMenu_TaskManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_TaskManagement.UseVisualStyleBackColor = false;
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
            btnSideMenu_Settings.Location = new Point(8, 312);
            btnSideMenu_Settings.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Settings.Size = new Size(241, 60);
            btnSideMenu_Settings.TabIndex = 4;
            btnSideMenu_Settings.Tag = "Settings";
            btnSideMenu_Settings.Text = "   Student Monitoring";
            btnSideMenu_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1362, 881);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 881);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // smoothTabControl1
            // 
            smoothTabControl1.Controls.Add(tabPage1);
            smoothTabControl1.Controls.Add(tabPage2);
            smoothTabControl1.Depth = 0;
            smoothTabControl1.Dock = DockStyle.Fill;
            smoothTabControl1.Location = new Point(256, 104);
            smoothTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            smoothTabControl1.Multiline = true;
            smoothTabControl1.Name = "smoothTabControl1";
            smoothTabControl1.SelectedIndex = 0;
            smoothTabControl1.Size = new Size(1370, 914);
            smoothTabControl1.TabIndex = 7;
            // 
            // InstructorSide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 1018);
            Controls.Add(smoothTabControl1);
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
            smoothTabControl1.ResumeLayout(false);
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
        private Button btnSideMenu_Settings;
        private Button btnSideMenu_FileManagement;
        private Button btnSideMenu_TaskManagement;
        private Button btnSideMenu_Student;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private CustomComponents.GeneralComponents.SmoothTabControl smoothTabControl1;
    }
}