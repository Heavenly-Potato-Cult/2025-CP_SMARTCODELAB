namespace SmartCodeLab.CustomComponents.Pages
{
    partial class SessionsLogsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogViewContainer = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            DashboardPage = new TabPage();
            MonitoringPage = new TabPage();
            SubmissionPage = new TabPage();
            btn_dashboard = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_monitoring = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_submissions = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            LogViewContainer.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogViewContainer
            // 
            LogViewContainer.Controls.Add(DashboardPage);
            LogViewContainer.Controls.Add(MonitoringPage);
            LogViewContainer.Controls.Add(SubmissionPage);
            LogViewContainer.Depth = 0;
            LogViewContainer.Dock = DockStyle.Fill;
            LogViewContainer.Location = new Point(0, 193);
            LogViewContainer.MouseState = MaterialSkin.MouseState.HOVER;
            LogViewContainer.Multiline = true;
            LogViewContainer.Name = "LogViewContainer";
            LogViewContainer.Padding = new Point(0, 0);
            LogViewContainer.SelectedIndex = 0;
            LogViewContainer.Size = new Size(1916, 771);
            LogViewContainer.TabIndex = 1;
            // 
            // DashboardPage
            // 
            DashboardPage.Location = new Point(4, 29);
            DashboardPage.Margin = new Padding(0);
            DashboardPage.Name = "DashboardPage";
            DashboardPage.Size = new Size(1908, 738);
            DashboardPage.TabIndex = 1;
            DashboardPage.Text = "Dashboard";
            DashboardPage.UseVisualStyleBackColor = true;
            // 
            // MonitoringPage
            // 
            MonitoringPage.Location = new Point(4, 29);
            MonitoringPage.Margin = new Padding(0);
            MonitoringPage.Name = "MonitoringPage";
            MonitoringPage.Size = new Size(1908, 738);
            MonitoringPage.TabIndex = 0;
            MonitoringPage.Text = "Monitoring";
            MonitoringPage.UseVisualStyleBackColor = true;
            // 
            // SubmissionPage
            // 
            SubmissionPage.Location = new Point(4, 29);
            SubmissionPage.Margin = new Padding(0);
            SubmissionPage.Name = "SubmissionPage";
            SubmissionPage.Size = new Size(1908, 738);
            SubmissionPage.TabIndex = 2;
            SubmissionPage.Text = "Submissions";
            SubmissionPage.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_dashboard.BackColor = Color.FromArgb(42, 71, 94);
            btn_dashboard.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_dashboard.BorderRadius = 1;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.FromArgb(199, 213, 224);
            btn_dashboard.Location = new Point(152, 16);
            btn_dashboard.Margin = new Padding(2, 4, 2, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(157, 39);
            btn_dashboard.TabIndex = 67;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.TextColor = Color.FromArgb(199, 213, 224);
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // btn_monitoring
            // 
            btn_monitoring.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_monitoring.BackColor = Color.FromArgb(42, 71, 94);
            btn_monitoring.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_monitoring.BorderRadius = 1;
            btn_monitoring.FlatAppearance.BorderSize = 0;
            btn_monitoring.FlatStyle = FlatStyle.Flat;
            btn_monitoring.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_monitoring.ForeColor = Color.FromArgb(199, 213, 224);
            btn_monitoring.Location = new Point(331, 16);
            btn_monitoring.Margin = new Padding(2, 4, 2, 4);
            btn_monitoring.Name = "btn_monitoring";
            btn_monitoring.Size = new Size(157, 39);
            btn_monitoring.TabIndex = 68;
            btn_monitoring.Text = "Monitoring";
            btn_monitoring.TextColor = Color.FromArgb(199, 213, 224);
            btn_monitoring.UseVisualStyleBackColor = false;
            btn_monitoring.Click += btn_monitoring_Click;
            // 
            // btn_submissions
            // 
            btn_submissions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_submissions.BackColor = Color.FromArgb(42, 71, 94);
            btn_submissions.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_submissions.BorderRadius = 1;
            btn_submissions.FlatAppearance.BorderSize = 0;
            btn_submissions.FlatStyle = FlatStyle.Flat;
            btn_submissions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submissions.ForeColor = Color.FromArgb(199, 213, 224);
            btn_submissions.Location = new Point(510, 16);
            btn_submissions.Margin = new Padding(2, 4, 2, 4);
            btn_submissions.Name = "btn_submissions";
            btn_submissions.Size = new Size(157, 39);
            btn_submissions.TabIndex = 69;
            btn_submissions.Text = "Submissions";
            btn_submissions.TextColor = Color.FromArgb(199, 213, 224);
            btn_submissions.UseVisualStyleBackColor = false;
            btn_submissions.Click += btn_submissions_Click;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton1.BackColor = Color.FromArgb(42, 71, 94);
            smartButton1.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton1.BorderRadius = 1;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton1.Location = new Point(689, 16);
            smartButton1.Margin = new Padding(2, 4, 2, 4);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(157, 39);
            smartButton1.TabIndex = 70;
            smartButton1.Text = "Back";
            smartButton1.TextColor = Color.FromArgb(199, 213, 224);
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(LogViewContainer);
            steamGradientPanel1.Controls.Add(panel2);
            steamGradientPanel1.Controls.Add(panel1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1916, 964);
            steamGradientPanel1.TabIndex = 71;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_dashboard);
            panel2.Controls.Add(btn_monitoring);
            panel2.Controls.Add(smartButton1);
            panel2.Controls.Add(btn_submissions);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1916, 78);
            panel2.TabIndex = 73;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(steamLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1916, 115);
            panel1.TabIndex = 72;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(152, 46);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(203, 32);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 71;
            steamLabel1.Text = "Session Name";
            // 
            // SessionsLogsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SessionsLogsView";
            Size = new Size(1916, 964);
            LogViewContainer.ResumeLayout(false);
            steamGradientPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamTabControl steamTabControl1;
        private TabPage SubmissionPage;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private SteamThings.SteamLabel steamLabel1;
        private GeneralComponents.SmoothTabControl LogViewContainer;
        private TabPage MonitoringPage;
        private TabPage DashboardPage;
        private GeneralComponents.SmartButton btn_dashboard;
        private GeneralComponents.SmartButton btn_monitoring;
        private GeneralComponents.SmartButton btn_submissions;
        private GeneralComponents.SmartButton smartButton1;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}
