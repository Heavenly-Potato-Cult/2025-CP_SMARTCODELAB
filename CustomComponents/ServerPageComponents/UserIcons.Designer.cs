namespace SmartCodeLab.CustomComponents
{
    partial class UserIcons
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
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            status = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            initialsPanel = new Panel();
            initialsLetter = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            indicator = new Panel();
            username = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard3.SuspendLayout();
            initialsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.FromArgb(11, 14, 17);
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 0;
            customCard3.Controls.Add(status);
            customCard3.Controls.Add(initialsPanel);
            customCard3.Controls.Add(indicator);
            customCard3.Controls.Add(username);
            customCard3.Dock = DockStyle.Top;
            customCard3.Location = new Point(0, 0);
            customCard3.Margin = new Padding(0);
            customCard3.Name = "customCard3";
            customCard3.Padding = new Padding(2, 2, 2, 0);
            customCard3.Size = new Size(246, 58);
            customCard3.TabIndex = 9;
            customCard3.Paint += customCard3_Paint;
            // 
            // status
            // 
            status.AutoSize = true;
            status.BackColor = Color.Transparent;
            status.Font = new Font("Geist", 8F);
            status.ForeColor = Color.FromArgb(26, 191, 32);
            status.Location = new Point(59, 32);
            status.Name = "status";
            status.Size = new Size(45, 16);
            status.SteamSize = SteamThings.SteamLabel.SizeOption.Tiny;
            status.SteamTheme = SteamThings.SteamLabel.ThemeOption.Accent;
            status.TabIndex = 14;
            status.Text = "Active";
            status.Click += status_Click;
            // 
            // initialsPanel
            // 
            initialsPanel.Controls.Add(initialsLetter);
            initialsPanel.Location = new Point(12, 8);
            initialsPanel.Name = "initialsPanel";
            initialsPanel.Size = new Size(40, 40);
            initialsPanel.TabIndex = 13;
            // 
            // initialsLetter
            // 
            initialsLetter.AutoSize = true;
            initialsLetter.BackColor = Color.Transparent;
            initialsLetter.Font = new Font("Geist", 12F);
            initialsLetter.ForeColor = Color.FromArgb(199, 213, 224);
            initialsLetter.Location = new Point(10, 9);
            initialsLetter.Name = "initialsLetter";
            initialsLetter.Size = new Size(20, 23);
            initialsLetter.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            initialsLetter.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            initialsLetter.TabIndex = 14;
            initialsLetter.Text = "J";
            // 
            // indicator
            // 
            indicator.Dock = DockStyle.Left;
            indicator.Location = new Point(2, 2);
            indicator.Name = "indicator";
            indicator.Size = new Size(4, 56);
            indicator.TabIndex = 12;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Font = new Font("Geist", 10F);
            username.ForeColor = Color.FromArgb(199, 213, 224);
            username.Location = new Point(55, 6);
            username.Name = "username";
            username.Size = new Size(80, 19);
            username.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            username.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            username.TabIndex = 11;
            username.Text = "John Doe";
            // 
            // UserIcons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(customCard3);
            Margin = new Padding(0);
            Name = "UserIcons";
            Size = new Size(246, 63);
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            initialsPanel.ResumeLayout(false);
            initialsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CustomCard customCard3;
        private SteamThings.SteamLabel username;
        private Panel indicator;
        private Panel initialsPanel;
        private SteamThings.SteamLabel initialsLetter;
        private SteamThings.SteamLabel status;
    }
}
