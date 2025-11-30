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
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            panelNavHost2 = new Panel();
            LogViewContainer.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogViewContainer
            // 
            LogViewContainer.Controls.Add(DashboardPage);
            LogViewContainer.Controls.Add(MonitoringPage);
            LogViewContainer.Controls.Add(SubmissionPage);
            LogViewContainer.Depth = 0;
            LogViewContainer.Dock = DockStyle.Fill;
            LogViewContainer.Location = new Point(0, 48);
            LogViewContainer.Margin = new Padding(0);
            LogViewContainer.MouseState = MaterialSkin.MouseState.HOVER;
            LogViewContainer.Multiline = true;
            LogViewContainer.Name = "LogViewContainer";
            LogViewContainer.Padding = new Point(0, 0);
            LogViewContainer.SelectedIndex = 0;
            LogViewContainer.Size = new Size(1916, 916);
            LogViewContainer.TabIndex = 1;
            // 
            // DashboardPage
            // 
            DashboardPage.Location = new Point(4, 29);
            DashboardPage.Margin = new Padding(0);
            DashboardPage.Name = "DashboardPage";
            DashboardPage.Size = new Size(1908, 883);
            DashboardPage.TabIndex = 1;
            DashboardPage.Text = "Dashboard";
            DashboardPage.UseVisualStyleBackColor = true;
            // 
            // MonitoringPage
            // 
            MonitoringPage.Location = new Point(4, 29);
            MonitoringPage.Margin = new Padding(0);
            MonitoringPage.Name = "MonitoringPage";
            MonitoringPage.Size = new Size(1908, 853);
            MonitoringPage.TabIndex = 0;
            MonitoringPage.Text = "Monitoring";
            MonitoringPage.UseVisualStyleBackColor = true;
            // 
            // SubmissionPage
            // 
            SubmissionPage.Location = new Point(4, 29);
            SubmissionPage.Margin = new Padding(0);
            SubmissionPage.Name = "SubmissionPage";
            SubmissionPage.Size = new Size(1908, 853);
            SubmissionPage.TabIndex = 2;
            SubmissionPage.Text = "Submissions";
            SubmissionPage.UseVisualStyleBackColor = true;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(LogViewContainer);
            steamGradientPanel1.Controls.Add(panelNavHost2);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1916, 964);
            steamGradientPanel1.TabIndex = 71;
            // 
            // panelNavHost2
            // 
            panelNavHost2.BackColor = Color.FromArgb(42, 46, 53);
            panelNavHost2.Dock = DockStyle.Top;
            panelNavHost2.Location = new Point(0, 0);
            panelNavHost2.Margin = new Padding(0);
            panelNavHost2.Name = "panelNavHost2";
            panelNavHost2.Size = new Size(1916, 48);
            panelNavHost2.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion
        private TabPage SubmissionPage;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private GeneralComponents.SmoothTabControl LogViewContainer;
        private TabPage MonitoringPage;
        private TabPage DashboardPage;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private Panel panelNavHost2;
    }
}
