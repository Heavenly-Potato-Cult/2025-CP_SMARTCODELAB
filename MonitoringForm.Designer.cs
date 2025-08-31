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
            headerPanel = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            sideMenuPanel = new Panel();
            button3 = new Button();
            btnSideMenu_Settings = new Button();
            btnSideMenu_Instruction = new Button();
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
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart Code Lab";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 50, 50);
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
            sideMenuPanel.Controls.Add(button3);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_Instruction);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 40);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(200, 692);
            sideMenuPanel.TabIndex = 0;

            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(13, 13, 13);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 135);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_Settings
            // 
            btnSideMenu_Settings.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Settings.FlatAppearance.BorderSize = 0;
            btnSideMenu_Settings.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Settings.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Settings.ForeColor = Color.White;
            btnSideMenu_Settings.Location = new Point(0, 90);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Size = new Size(200, 45);
            btnSideMenu_Settings.TabIndex = 3;
            btnSideMenu_Settings.Text = "Settings";
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            btnSideMenu_Settings.Click += button2_Click;
            // 
            // btnSideMenu_Instruction
            // 
            btnSideMenu_Instruction.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Instruction.FlatAppearance.BorderSize = 0;
            btnSideMenu_Instruction.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Instruction.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Instruction.ForeColor = Color.White;
            btnSideMenu_Instruction.Location = new Point(0, 45);
            btnSideMenu_Instruction.Name = "btnSideMenu_Instruction";
            btnSideMenu_Instruction.Size = new Size(200, 45);
            btnSideMenu_Instruction.TabIndex = 2;
            btnSideMenu_Instruction.Text = "Task Management";
            btnSideMenu_Instruction.UseVisualStyleBackColor = false;
            btnSideMenu_Instruction.Click += button1_Click;
            // 
            // btnSideMenu_Student
            // 
            btnSideMenu_Student.BackColor = Color.FromArgb(13, 13, 13);
            btnSideMenu_Student.FlatAppearance.BorderSize = 0;
            btnSideMenu_Student.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Student.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Student.ForeColor = Color.White;
            btnSideMenu_Student.Location = new Point(0, 0);
            btnSideMenu_Student.Name = "btnSideMenu_Student";
            btnSideMenu_Student.Size = new Size(200, 45);
            btnSideMenu_Student.TabIndex = 1;
            btnSideMenu_Student.Text = "Server";
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
            tabPage3.BackColor = Color.RosyBrown;
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
            taskMainPage2.Location = new Point(3, 2);
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
        private Button btnSideMenu_Instruction;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
        private Button button3;
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