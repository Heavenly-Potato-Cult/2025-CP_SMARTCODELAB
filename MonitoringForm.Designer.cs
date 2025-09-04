using SmartCodeLab.CustomComponents.GeneralComponents;

namespace SmartCodeLab
{
    partial class MonitoringForm
    {
        private System.ComponentModel.IContainer components = null;

        // === Declare controls here (fields) ===
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnSideMenu_Student;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringForm));
            headerPanel = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            sideMenuPanel = new Panel();
            btnSideMenu_Settings = new Button();
            btnSideMenu_FileManagement = new Button();
            btnSideMenu_TaskManagement = new Button();
            btnSideMenu_Student = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            serverSetUpPage1 = new SmartCodeLab.CustomComponents.MainPages.ServerSetUpPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            taskMainPage2 = new SmartCodeLab.CustomComponents.MainPages.TaskMainPage();
            tabPage4 = new TabPage();
            customCard1 = new CustomCard();
            customToggleButton1 = new CustomToggleButton();
            label2 = new Label();
            label1 = new Label();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1626, 53);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(11, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart Code Lab";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 50, 50);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1580, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 53);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(13, 13, 13);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_FileManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_TaskManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 53);
            sideMenuPanel.Margin = new Padding(3, 4, 3, 4);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(256, 923);
            sideMenuPanel.TabIndex = 0;
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
            btnSideMenu_Settings.Location = new Point(18, 209);
            btnSideMenu_Settings.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Settings.Size = new Size(221, 60);
            btnSideMenu_Settings.TabIndex = 4;
            btnSideMenu_Settings.Text = "   Settings";
            btnSideMenu_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            btnSideMenu_Settings.Click += btnSideMenu_Settings_Click;
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
            btnSideMenu_FileManagement.Location = new Point(18, 149);
            btnSideMenu_FileManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_FileManagement.Name = "btnSideMenu_FileManagement";
            btnSideMenu_FileManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_FileManagement.Size = new Size(221, 60);
            btnSideMenu_FileManagement.TabIndex = 3;
            btnSideMenu_FileManagement.Text = "   File Management";
            btnSideMenu_FileManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_FileManagement.UseVisualStyleBackColor = false;
            btnSideMenu_FileManagement.Click += button2_Click;
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
            btnSideMenu_TaskManagement.Location = new Point(18, 89);
            btnSideMenu_TaskManagement.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_TaskManagement.Name = "btnSideMenu_TaskManagement";
            btnSideMenu_TaskManagement.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_TaskManagement.Size = new Size(221, 60);
            btnSideMenu_TaskManagement.TabIndex = 2;
            btnSideMenu_TaskManagement.Text = "   Task Management";
            btnSideMenu_TaskManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_TaskManagement.UseVisualStyleBackColor = false;
            btnSideMenu_TaskManagement.Click += button1_Click;
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
            btnSideMenu_Student.Location = new Point(18, 29);
            btnSideMenu_Student.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Student.Name = "btnSideMenu_Student";
            btnSideMenu_Student.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Student.Size = new Size(221, 60);
            btnSideMenu_Student.TabIndex = 1;
            btnSideMenu_Student.Text = "   Connection";
            btnSideMenu_Student.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Student.UseVisualStyleBackColor = false;
            btnSideMenu_Student.Click += btnMenu2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(262, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1310, 904);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(serverSetUpPage1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1302, 871);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // serverSetUpPage1
            // 
            serverSetUpPage1.BackColor = Color.FromArgb(10, 10, 10);
            serverSetUpPage1.Dock = DockStyle.Fill;
            serverSetUpPage1.Location = new Point(3, 3);
            serverSetUpPage1.Name = "serverSetUpPage1";
            serverSetUpPage1.Size = new Size(1296, 865);
            serverSetUpPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(10, 10, 10);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1302, 871);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // button2
            // 
            button2.Location = new Point(79, 256);
            button2.Name = "button2";
            button2.Size = new Size(151, 41);
            button2.TabIndex = 1;
            button2.Text = "Client";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(79, 189);
            button1.Name = "button1";
            button1.Size = new Size(151, 41);
            button1.TabIndex = 0;
            button1.Text = "Server";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(10, 10, 10);
            tabPage3.Controls.Add(taskMainPage2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1302, 871);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // taskMainPage2
            // 
            taskMainPage2.BackColor = Color.FromArgb(10, 10, 10);
            taskMainPage2.Location = new Point(0, 0);
            taskMainPage2.Name = "taskMainPage2";
            taskMainPage2.Size = new Size(1320, 945);
            taskMainPage2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(10, 10, 10);
            tabPage4.Controls.Add(customCard1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1302, 871);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(13, 13, 13);
            customCard1.BorderColor = SystemColors.GrayText;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 0;
            customCard1.Controls.Add(customToggleButton1);
            customCard1.Controls.Add(label2);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(80, 77);
            customCard1.Margin = new Padding(3, 4, 3, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(221, 117);
            customCard1.TabIndex = 0;
            // 
            // customToggleButton1
            // 
            customToggleButton1.AutoSize = true;
            customToggleButton1.Cursor = Cursors.Hand;
            customToggleButton1.Location = new Point(149, 61);
            customToggleButton1.Margin = new Padding(3, 4, 3, 4);
            customToggleButton1.MinimumSize = new Size(51, 29);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColor = Color.Gray;
            customToggleButton1.OffToggleColor = Color.Gainsboro;
            customToggleButton1.OnBackColor = Color.MediumSlateBlue;
            customToggleButton1.OnToggleColor = Color.WhiteSmoke;
            customToggleButton1.Size = new Size(51, 29);
            customToggleButton1.TabIndex = 8;
            customToggleButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 6;
            label2.Text = "Dark Mode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 5;
            label1.Text = "Theme";
            // 
            // MonitoringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1626, 976);
            Controls.Add(tabControl1);
            Controls.Add(sideMenuPanel);
            Controls.Add(headerPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MonitoringForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonitoringForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            sideMenuPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSideMenu_FileManagement;
        private Button btnSideMenu_TaskManagement;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
        private Button btnSideMenu_Settings;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CustomComponents.MainPages.TaskMainPage taskMainPage2;
        private CustomComponents.MainPages.ServerSetUpPage serverSetUpPage1;
        private Button button2;
        private Button button1;
        private TabPage tabPage4;
        private CustomCard customCard1;
        private CustomToggleButton customToggleButton1;
        private Label label2;
        private Label label1;
    }
}