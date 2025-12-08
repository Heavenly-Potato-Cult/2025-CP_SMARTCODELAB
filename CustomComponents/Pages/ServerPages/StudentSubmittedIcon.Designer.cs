namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class StudentSubmittedIcon
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
            tableLayoutPanel1 = new TableLayoutPanel();
            placing = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            name = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            indicator = new Panel();
            score = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.FromArgb(11, 14, 17);
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 0;
            customCard3.Controls.Add(tableLayoutPanel1);
            customCard3.Dock = DockStyle.Top;
            customCard3.Location = new Point(0, 0);
            customCard3.Margin = new Padding(0);
            customCard3.Name = "customCard3";
            customCard3.Padding = new Padding(2, 2, 2, 0);
            customCard3.Size = new Size(350, 58);
            customCard3.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.72247F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2775249F));
            tableLayoutPanel1.Controls.Add(placing, 1, 0);
            tableLayoutPanel1.Controls.Add(name, 2, 0);
            tableLayoutPanel1.Controls.Add(indicator, 0, 0);
            tableLayoutPanel1.Controls.Add(score, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(346, 56);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // placing
            // 
            placing.AutoSize = true;
            placing.BackColor = Color.Transparent;
            placing.Dock = DockStyle.Fill;
            placing.Font = new Font("Geist", 12F);
            placing.ForeColor = Color.FromArgb(199, 213, 224);
            placing.Location = new Point(5, 0);
            placing.Margin = new Padding(0);
            placing.Name = "placing";
            placing.Size = new Size(50, 56);
            placing.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            placing.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            placing.TabIndex = 14;
            placing.Text = "30";
            placing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Dock = DockStyle.Fill;
            name.Font = new Font("Geist", 12F);
            name.ForeColor = Color.FromArgb(199, 213, 224);
            name.Location = new Point(55, 0);
            name.Margin = new Padding(0);
            name.Name = "name";
            name.Size = new Size(234, 56);
            name.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            name.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            name.TabIndex = 11;
            name.Text = "John Doe";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // indicator
            // 
            indicator.Dock = DockStyle.Fill;
            indicator.Location = new Point(3, 3);
            indicator.Name = "indicator";
            indicator.Size = new Size(1, 50);
            indicator.TabIndex = 12;
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.FromArgb(17, 42, 30);
            score.Dock = DockStyle.Fill;
            score.Font = new Font("Geist", 12F);
            score.ForeColor = Color.FromArgb(26, 191, 32);
            score.Location = new Point(292, 0);
            score.Name = "score";
            score.Size = new Size(51, 56);
            score.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            score.SteamTheme = SteamThings.SteamLabel.ThemeOption.Accent;
            score.TabIndex = 14;
            score.Text = "100";
            score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentSubmittedIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderRadius = 2;
            Controls.Add(customCard3);
            Name = "StudentSubmittedIcon";
            Size = new Size(350, 63);
            customCard3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SteamThings.SteamLabel score;
        private GeneralComponents.CustomCard customCard3;
        private SteamThings.SteamLabel placing;
        private SteamThings.SteamLabel initialsLetter;
        private Panel indicator;
        private SteamThings.SteamLabel name;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
