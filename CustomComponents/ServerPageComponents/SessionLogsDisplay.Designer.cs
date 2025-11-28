namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class SessionLogsDisplay
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
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            sessionName = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            label1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            SuspendLayout();
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.FromArgb(42, 71, 94);
            smartButton1.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton1.BorderRadius = 1;
            smartButton1.Dock = DockStyle.Right;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton1.Location = new Point(665, 0);
            smartButton1.Margin = new Padding(2, 4, 2, 4);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(89, 85);
            smartButton1.TabIndex = 34;
            smartButton1.Text = "VIEW";
            smartButton1.TextColor = Color.FromArgb(199, 213, 224);
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // sessionName
            // 
            sessionName.AutoSize = true;
            sessionName.BackColor = Color.Transparent;
            sessionName.Font = new Font("Geist", 12F);
            sessionName.ForeColor = Color.FromArgb(199, 213, 224);
            sessionName.Location = new Point(24, 12);
            sessionName.Name = "sessionName";
            sessionName.Size = new Size(319, 23);
            sessionName.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            sessionName.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            sessionName.TabIndex = 35;
            sessionName.Text = "Object-Oriented Programming Lab ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Geist", 12F);
            label1.ForeColor = Color.FromArgb(139, 149, 166);
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            label1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            label1.TabIndex = 36;
            label1.Text = "July 30, 2025 |";
            // 
            // SessionLogsDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 28, 38);
            BorderColor = Color.FromArgb(42, 71, 94);
            BorderRadius = 2;
            BorderSize = 1;
            Controls.Add(label1);
            Controls.Add(sessionName);
            Controls.Add(smartButton1);
            Name = "SessionLogsDisplay";
            Size = new Size(754, 85);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton5;
        private SteamThings.SteamLabel sessionName;
        private SteamThings.SteamLabel label1;
    }
}
