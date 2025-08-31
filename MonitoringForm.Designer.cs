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
            btnSideMenu_Shutdown = new Button();
            btnSideMenu_Settings = new Button();
            btnSideMenu_TaskManagement = new Button();
            btnSideMenu_Student = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            serverSetUpPage1 = new CustomComponents.MainPages.ServerSetUpPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            taskMainPage2 = new CustomComponents.MainPages.TaskMainPage();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(13, 13, 13);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1386, 40);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(154, 25);
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
            btnClose.Location = new Point(1346, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(13, 13, 13);
            sideMenuPanel.Controls.Add(btnSideMenu_Shutdown);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_TaskManagement);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 40);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(200, 692);
            sideMenuPanel.TabIndex = 0;
            // 
            // btnSideMenu_Shutdown
            // 
            btnSideMenu_Shutdown.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Shutdown.Cursor = Cursors.Hand;
            btnSideMenu_Shutdown.FlatAppearance.BorderSize = 0;
            btnSideMenu_Shutdown.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Shutdown.Font = new Font("Segoe UI", 11.25F);
            btnSideMenu_Shutdown.ForeColor = Color.White;
            btnSideMenu_Shutdown.Image = (Image)resources.GetObject("btnSideMenu_Shutdown.Image");
            btnSideMenu_Shutdown.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Shutdown.Location = new Point(10, 157);
            btnSideMenu_Shutdown.Name = "btnSideMenu_Shutdown";
            btnSideMenu_Shutdown.Size = new Size(176, 45);
            btnSideMenu_Shutdown.TabIndex = 4;
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
            btnSideMenu_Settings.Font = new Font("Segoe UI", 11.25F);
            btnSideMenu_Settings.ForeColor = Color.White;
            btnSideMenu_Settings.Image = (Image)resources.GetObject("btnSideMenu_Settings.Image");
            btnSideMenu_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Settings.Location = new Point(10, 112);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Size = new Size(176, 45);
            btnSideMenu_Settings.TabIndex = 3;
            btnSideMenu_Settings.Text = "  Settings";
            btnSideMenu_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            btnSideMenu_Settings.Click += button2_Click;
            // 
            // btnSideMenu_TaskManagement
            // 
            btnSideMenu_TaskManagement.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_TaskManagement.Cursor = Cursors.Hand;
            btnSideMenu_TaskManagement.FlatAppearance.BorderSize = 0;
            btnSideMenu_TaskManagement.FlatStyle = FlatStyle.Flat;
            btnSideMenu_TaskManagement.Font = new Font("Segoe UI", 11.25F);
            btnSideMenu_TaskManagement.ForeColor = Color.White;
            btnSideMenu_TaskManagement.Image = (Image)resources.GetObject("btnSideMenu_TaskManagement.Image");
            btnSideMenu_TaskManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_TaskManagement.Location = new Point(10, 67);
            btnSideMenu_TaskManagement.Name = "btnSideMenu_TaskManagement";
            btnSideMenu_TaskManagement.Size = new Size(176, 45);
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
            btnSideMenu_Student.Font = new Font("Segoe UI", 11.25F);
            btnSideMenu_Student.ForeColor = Color.White;
            btnSideMenu_Student.Image = (Image)resources.GetObject("btnSideMenu_Student.Image");
            btnSideMenu_Student.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMenu_Student.Location = new Point(10, 22);
            btnSideMenu_Student.Name = "btnSideMenu_Student";
            btnSideMenu_Student.Size = new Size(176, 45);
            btnSideMenu_Student.TabIndex = 1;
            btnSideMenu_Student.Text = "   Server";
            btnSideMenu_Student.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMenu_Student.UseVisualStyleBackColor = false;
            btnSideMenu_Student.Click += btnMenu2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(206, 45);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1170, 678);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(serverSetUpPage1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1162, 650);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // serverSetUpPage1
            // 
            serverSetUpPage1.BackColor = Color.FromArgb(10, 10, 10);
            serverSetUpPage1.Location = new Point(3, 2);
            serverSetUpPage1.Margin = new Padding(3, 2, 3, 2);
            serverSetUpPage1.Name = "serverSetUpPage1";
            serverSetUpPage1.Size = new Size(1155, 651);
            serverSetUpPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1162, 650);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // button2
            // 
            button2.Location = new Point(69, 192);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 1;
            button2.Text = "Client";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(69, 142);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 0;
            button1.Text = "Server";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(10, 10, 10);
            tabPage3.Controls.Add(taskMainPage2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1162, 650);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // taskMainPage2
            // 
            taskMainPage2.BackColor = Color.FromArgb(10, 10, 10);
            taskMainPage2.Location = new Point(0, 0);
            taskMainPage2.Margin = new Padding(3, 2, 3, 2);
            taskMainPage2.Name = "taskMainPage2";
            taskMainPage2.Size = new Size(1155, 709);
            taskMainPage2.TabIndex = 0;
            // 
            // MonitoringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1386, 732);
            Controls.Add(tabControl1);
            Controls.Add(sideMenuPanel);
            Controls.Add(headerPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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
            ResumeLayout(false);
        }

        #endregion
        private Button btnSideMenu_Settings;
        private Button btnSideMenu_TaskManagement;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
        private Button btnSideMenu_Shutdown;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CustomComponents.MainPages.TaskMainPage taskMainPage2;
        private CustomComponents.MainPages.ServerSetUpPage serverSetUpPage1;
        private Button button2;
        private Button button1;
    }
}