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
            customCard8 = new CustomCard();
            textBox1 = new TextBox();
            label15 = new Label();
            customCard6 = new CustomCard();
            smartButton3 = new SmartButton();
            smartButton2 = new SmartButton();
            customCard7 = new CustomCard();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            smartButton1 = new SmartButton();
            customCard2 = new CustomCard();
            customCard5 = new CustomCard();
            label10 = new Label();
            label11 = new Label();
            customCard4 = new CustomCard();
            label8 = new Label();
            label9 = new Label();
            customCard3 = new CustomCard();
            label7 = new Label();
            label6 = new Label();
            customTextBox1 = new SmartCodeLab.CustomComponents.CustomTextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            customCard1.SuspendLayout();
            tabPage5.SuspendLayout();
            customCard8.SuspendLayout();
            customCard6.SuspendLayout();
            customCard7.SuspendLayout();
            customCard2.SuspendLayout();
            customCard5.SuspendLayout();
            customCard4.SuspendLayout();
            customCard3.SuspendLayout();
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
            headerPanel.Paint += headerPanel_Paint;
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
            sideMenuPanel.Controls.Add(button3);
            sideMenuPanel.Controls.Add(btnSideMenu_Shutdown);
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
            button3.Location = new Point(18, 431);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(221, 60);
            button3.TabIndex = 6;
            button3.Text = "   Monitoring";
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(256, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1370, 923);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(serverSetUpPage1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 890);
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
            serverSetUpPage1.Size = new Size(1356, 884);
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
            tabPage2.Size = new Size(1362, 890);
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
            tabPage3.Size = new Size(1362, 890);
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
            tabPage4.Size = new Size(1362, 890);
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
            tabPage5.Controls.Add(customCard8);
            tabPage5.Controls.Add(customCard6);
            tabPage5.Controls.Add(smartButton1);
            tabPage5.Controls.Add(customCard2);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(label3);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1362, 890);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // customCard8
            // 
            customCard8.BackColor = Color.White;
            customCard8.BorderColor = Color.Gray;
            customCard8.BorderRadius = 10;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(textBox1);
            customCard8.Controls.Add(label15);
            customCard8.Location = new Point(366, 262);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(914, 584);
            customCard8.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(853, 457);
            textBox1.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 13, 13);
            label15.Location = new Point(28, 22);
            label15.Name = "label15";
            label15.Size = new Size(193, 28);
            label15.TabIndex = 14;
            label15.Text = "Live Coding Viewer";
            // 
            // customCard6
            // 
            customCard6.BackColor = Color.White;
            customCard6.BorderColor = Color.Gray;
            customCard6.BorderRadius = 10;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(smartButton3);
            customCard6.Controls.Add(smartButton2);
            customCard6.Controls.Add(customCard7);
            customCard6.Controls.Add(label13);
            customCard6.Controls.Add(label12);
            customCard6.Location = new Point(366, 120);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(914, 98);
            customCard6.TabIndex = 7;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.FromArgb(0, 0, 192);
            smartButton3.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton3.BorderRadius = 10;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(763, 24);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(122, 39);
            smartButton3.TabIndex = 13;
            smartButton3.Text = "Send Hint";
            smartButton3.UseVisualStyleBackColor = false;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.FromArgb(255, 128, 0);
            smartButton2.BackgroundColor = Color.FromArgb(255, 128, 0);
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(654, 24);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(103, 39);
            smartButton2.TabIndex = 8;
            smartButton2.Text = "Flag";
            smartButton2.UseVisualStyleBackColor = false;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.FromArgb(192, 255, 192);
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 15;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(497, 28);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(151, 32);
            customCard7.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(7, 5);
            label14.Name = "label14";
            label14.Size = new Size(139, 23);
            label14.TabIndex = 13;
            label14.Text = "Activite - Coding";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(28, 48);
            label13.Name = "label13";
            label13.Size = new Size(317, 25);
            label13.TabIndex = 8;
            label13.Text = "IT2024001 | LAB-PC-1 | 192.168.1.101 ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(28, 14);
            label12.Name = "label12";
            label12.Size = new Size(201, 28);
            label12.TabIndex = 11;
            label12.Text = "Jimmuel Sanggayan";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.ForestGreen;
            smartButton1.BackgroundColor = Color.ForestGreen;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(1092, 41);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(188, 39);
            smartButton1.TabIndex = 6;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(customCard5);
            customCard2.Controls.Add(customCard4);
            customCard2.Controls.Add(customCard3);
            customCard2.Controls.Add(customTextBox1);
            customCard2.Controls.Add(label4);
            customCard2.Location = new Point(35, 120);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(278, 393);
            customCard2.TabIndex = 5;
            // 
            // customCard5
            // 
            customCard5.BackColor = Color.White;
            customCard5.BorderColor = Color.Gray;
            customCard5.BorderRadius = 10;
            customCard5.BorderSize = 0;
            customCard5.Controls.Add(label10);
            customCard5.Controls.Add(label11);
            customCard5.Location = new Point(19, 267);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(240, 61);
            customCard5.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 128);
            label10.Location = new Point(28, 33);
            label10.Name = "label10";
            label10.Size = new Size(29, 17);
            label10.TabIndex = 10;
            label10.Text = "Idle";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(13, 13, 13);
            label11.Location = new Point(28, 9);
            label11.Name = "label11";
            label11.Size = new Size(106, 23);
            label11.TabIndex = 9;
            label11.Text = "Angelo Bello";
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 10;
            customCard4.BorderSize = 0;
            customCard4.Controls.Add(label8);
            customCard4.Controls.Add(label9);
            customCard4.Location = new Point(19, 200);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(240, 61);
            customCard4.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.Location = new Point(28, 33);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 10;
            label8.Text = "Active";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(13, 13, 13);
            label9.Location = new Point(28, 9);
            label9.Name = "label9";
            label9.Size = new Size(124, 23);
            label9.TabIndex = 9;
            label9.Text = "Clifford Magno";
            // 
            // customCard3
            // 
            customCard3.BackColor = SystemColors.GradientActiveCaption;
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 10;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(label7);
            customCard3.Controls.Add(label6);
            customCard3.Location = new Point(19, 133);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(240, 61);
            customCard3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(28, 33);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 10;
            label7.Text = "Active";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(13, 13, 13);
            label6.Location = new Point(28, 9);
            label6.Name = "label6";
            label6.Size = new Size(162, 23);
            label6.TabIndex = 9;
            label6.Text = "Jimmuel Sanggayan";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.WhiteSmoke;
            customTextBox1.BorderColor = Color.White;
            customTextBox1.BorderFocusColor = Color.Transparent;
            customTextBox1.BorderRadius = 10;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(26, 57);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(228, 41);
            customTextBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 13, 13);
            label4.Location = new Point(26, 14);
            label4.Name = "label4";
            label4.Size = new Size(201, 28);
            label4.TabIndex = 6;
            label4.Text = "Connected Students";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(31, 55);
            label5.Name = "label5";
            label5.Size = new Size(404, 25);
            label5.TabIndex = 4;
            label5.Text = " Real-time monitoring of student coding activities";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(35, 11);
            label3.Name = "label3";
            label3.Size = new Size(278, 38);
            label3.TabIndex = 2;
            label3.Text = "Student Monitoring";
            label3.Click += label3_Click;
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
            sideMenuPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            customCard5.ResumeLayout(false);
            customCard5.PerformLayout();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
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
        private Label label3;
        private Label label5;
        private CustomCard customCard2;
        private CustomComponents.CustomTextBox customTextBox1;
        private Label label4;
        private CustomCard customCard3;
        private Label label6;
        private CustomCard customCard5;
        private Label label10;
        private Label label11;
        private CustomCard customCard4;
        private Label label8;
        private Label label9;
        private Label label7;
        private CustomCard customCard6;
        private Label label13;
        private Label label12;
        private SmartButton smartButton1;
        private SmartButton smartButton2;
        private CustomCard customCard7;
        private Label label14;
        private CustomCard customCard8;
        private TextBox textBox1;
        private Label label15;
        private SmartButton smartButton3;
    }
}