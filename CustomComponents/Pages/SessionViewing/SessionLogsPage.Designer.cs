namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    partial class SessionLogsPage
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
            panel1 = new Panel();
            sessionsContainer = new SmartCodeLab.CustomComponents.SteamThings.SteamFlowPanel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            searchSess = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            panel1.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(sessionsContainer);
            panel1.Location = new Point(458, 111);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 799);
            panel1.TabIndex = 20;
            // 
            // sessionsContainer
            // 
            sessionsContainer.AutoScroll = true;
            sessionsContainer.BackColor = Color.Transparent;
            sessionsContainer.Dock = DockStyle.Fill;
            sessionsContainer.FlowDirection = FlowDirection.TopDown;
            sessionsContainer.Location = new Point(0, 0);
            sessionsContainer.Name = "sessionsContainer";
            sessionsContainer.Size = new Size(885, 799);
            sessionsContainer.TabIndex = 22;
            sessionsContainer.WrapContents = false;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(searchSess);
            steamGradientPanel1.Controls.Add(steamLabel1);
            steamGradientPanel1.Controls.Add(panel1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1801, 1049);
            steamGradientPanel1.TabIndex = 21;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(458, 14);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(193, 32);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 21;
            steamLabel1.Text = "Session Logs";
            // 
            // searchSess
            // 
            searchSess.BackColor = Color.FromArgb(26, 30, 36);
            searchSess.Location = new Point(458, 60);
            searchSess.Name = "searchSess";
            searchSess.Padding = new Padding(10, 8, 10, 8);
            searchSess.PlaceholderText = "Search Session";
            searchSess.Size = new Size(312, 44);
            searchSess.TabIndex = 22;
            // 
            // SessionLogsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            Name = "SessionLogsPage";
            Size = new Size(1801, 1049);
            Load += SessionLogsPage_Load;
            panel1.ResumeLayout(false);
            steamGradientPanel1.ResumeLayout(false);
            steamGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamFlowPanel sessionsContainer;
        private SteamThings.SteamTextBox searchSess;
    }
}
