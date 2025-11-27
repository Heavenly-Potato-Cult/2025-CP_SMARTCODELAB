namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class PastedCodeIcon
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
            codeLine = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            time = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panelIcon = new Panel();
            panelIcon.SuspendLayout();
            SuspendLayout();
            // 
            // codeLine
            // 
            codeLine.AutoSize = true;
            codeLine.BackColor = Color.Transparent;
            codeLine.Font = new Font("Geist", 10F);
            codeLine.ForeColor = Color.FromArgb(255, 77, 77);
            codeLine.Location = new Point(3, 6);
            codeLine.Name = "codeLine";
            codeLine.Size = new Size(126, 19);
            codeLine.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            codeLine.SteamTheme = SteamThings.SteamLabel.ThemeOption.Error;
            codeLine.TabIndex = 20;
            codeLine.Text = "Pasted 72 Lines";
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Geist", 8F);
            time.ForeColor = Color.FromArgb(139, 149, 166);
            time.Location = new Point(3, 27);
            time.Name = "time";
            time.Size = new Size(43, 16);
            time.SteamSize = SteamThings.SteamLabel.SizeOption.Tiny;
            time.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            time.TabIndex = 21;
            time.Text = "12:00";
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.FromArgb(42, 32, 40);
            panelIcon.Controls.Add(codeLine);
            panelIcon.Controls.Add(time);
            panelIcon.Dock = DockStyle.Fill;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(165, 52);
            panelIcon.TabIndex = 22;
            // 
            // PastedCodeIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderRadius = 2;
            Controls.Add(panelIcon);
            Margin = new Padding(3, 3, 3, 10);
            Name = "PastedCodeIcon";
            Padding = new Padding(0, 0, 0, 5);
            Size = new Size(165, 57);
            panelIcon.ResumeLayout(false);
            panelIcon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamLabel codeLine;
        private SteamThings.SteamLabel time;
        private Panel panelIcon;
    }
}
