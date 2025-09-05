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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            sideMenuPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            btnSideMenu_Shutdown = new Button();
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
            tabPage5 = new TabPage();
            tempServerPage1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempServerPage();
            tabPage6 = new TabPage();
            tempDashboard1 = new SmartCodeLab.CustomComponents.ServerPageComponents.TempDashboard();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideMenuPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            customCard1.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Controls.Add(label5);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1626, 70);
            headerPanel.TabIndex = 1;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(89, 39);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 11;
            label5.Text = "Instructor Dashboard";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(13, 13, 13);
            lblTitle.Location = new Point(88, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SmartCodeLab";
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
            btnClose.Size = new Size(46, 70);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(13, 13, 13);
            sideMenuPanel.Controls.Add(button4);
            sideMenuPanel.Controls.Add(button3);
            sideMenuPanel.Controls.Add(btnSideMenu_Shutdown);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_FileManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_TaskManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 70);
            sideMenuPanel.Margin = new Padding(3, 4, 3, 4);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(256, 906);
            sideMenuPanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(13, 13, 13);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(18, 562);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(221, 60);
            button4.TabIndex = 7;
            button4.Text = "   Dashboard";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(13, 13, 13);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(18, 494);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(221, 60);
            button3.TabIndex = 6;
            button3.Text = "   Student Monitoring";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSideMenu_Shutdown
            // 
            btnSideMenu_Shutdown.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Shutdown.Cursor = Cursors.Hand;
            btnSideMenu_Shutdown.FlatAppearance.BorderSize = 0;
            btnSideMenu_Shutdown.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Shutdown.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSideMenu_Shutdown.ForeColor = Color.White;
            btnSideMenu_Shutdown.Image = (Image)resources.GetObject("btnSideMenu_Shutdown.Image");
            btnSideMenu_Shutdown.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Shutdown.Location = new Point(18, 272);
            btnSideMenu_Shutdown.Margin = new Padding(3, 4, 3, 4);
            btnSideMenu_Shutdown.Name = "btnSideMenu_Shutdown";
            btnSideMenu_Shutdown.Padding = new Padding(10, 0, 0, 0);
            btnSideMenu_Shutdown.Size = new Size(221, 60);
            btnSideMenu_Shutdown.TabIndex = 5;
            btnSideMenu_Shutdown.Text = "   Shutdown";
            btnSideMenu_Shutdown.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Shutdown.UseVisualStyleBackColor = false;
            btnSideMenu_Shutdown.Click += btnSideMenu_Shutdown_Click;
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
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(256, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1370, 906);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(serverSetUpPage1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 873);
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
            serverSetUpPage1.Size = new Size(1356, 867);
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
            tabPage2.Size = new Size(1362, 873);
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
            tabPage3.Size = new Size(1362, 873);
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
            tabPage4.Size = new Size(1362, 873);
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
            // tabPage5
            // 
            tabPage5.AutoScroll = true;
            tabPage5.BackColor = Color.WhiteSmoke;
            tabPage5.Controls.Add(tempServerPage1);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1362, 873);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // tempServerPage1
            // 
            tempServerPage1.AutoScroll = true;
            tempServerPage1.BackColor = Color.WhiteSmoke;
            tempServerPage1.Dock = DockStyle.Fill;
            tempServerPage1.Location = new Point(0, 0);
            tempServerPage1.Name = "tempServerPage1";
            tempServerPage1.Size = new Size(1362, 873);
            tempServerPage1.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(tempDashboard1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1362, 873);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tempDashboard1
            // 
            tempDashboard1.Dock = DockStyle.Fill;
            tempDashboard1.Location = new Point(0, 0);
            tempDashboard1.Name = "tempDashboard1";
            tempDashboard1.Size = new Size(1362, 873);
            tempDashboard1.TabIndex = 0;
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
            Load += MonitoringForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideMenuPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
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
        private Button btnSideMenu_Shutdown;
        private Button button3;
        private TabPage tabPage5;
        private CustomComponents.ServerPageComponents.TempServerPage tempServerPage1;
        private TabPage tabPage6;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button4;
        private CustomComponents.ServerPageComponents.TempDashboard tempDashboard1;
    }
}