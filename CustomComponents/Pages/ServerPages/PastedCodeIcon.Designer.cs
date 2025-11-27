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
            panelIcon = new SmartCodeLab.CustomComponents.GeneralComponents.RoundedUserControl();
            codeLine = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            time = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            SuspendLayout();
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.RosyBrown;
            panelIcon.BorderColor = Color.Gray;
            panelIcon.BorderRadius = 2;
            panelIcon.BorderSize = 0;
            panelIcon.Dock = DockStyle.Fill;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(165, 52);
            panelIcon.TabIndex = 19;
            // 
            // codeLine
            // 
            codeLine.AutoSize = true;
            codeLine.BackColor = Color.RosyBrown;
            codeLine.Font = new Font("Geist", 10F);
            codeLine.ForeColor = Color.FromArgb(255, 77, 77);
            codeLine.Location = new Point(12, 4);
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
            time.BackColor = Color.RosyBrown;
            time.Font = new Font("Geist", 8F);
            time.ForeColor = Color.FromArgb(199, 213, 224);
            time.Location = new Point(12, 27);
            time.Name = "time";
            time.Size = new Size(43, 16);
            time.SteamSize = SteamThings.SteamLabel.SizeOption.Tiny;
            time.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            time.TabIndex = 21;
            time.Text = "12:00";
            // 
            // PastedCodeIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderRadius = 2;
            Controls.Add(time);
            Controls.Add(codeLine);
            Controls.Add(panelIcon);
            Margin = new Padding(3, 3, 3, 10);
            Name = "PastedCodeIcon";
            Padding = new Padding(0, 0, 0, 5);
            Size = new Size(165, 57);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GeneralComponents.RoundedUserControl panelIcon;
        private SteamThings.SteamLabel codeLine;
        private SteamThings.SteamLabel time;
    }
}
