namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class StudentCodeRating
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
            scoreLabel = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            rowAccuracy = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            rowEfficiency = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            rowRobustness = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            rowMaintainability = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Geist", 12F);
            scoreLabel.ForeColor = Color.FromArgb(199, 213, 224);
            scoreLabel.Location = new Point(400, 11);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(21, 23);
            scoreLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            scoreLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            scoreLabel.TabIndex = 92;
            scoreLabel.Text = "0";
            scoreLabel.Visible = false;
            scoreLabel.Click += scoreLabel_Click;
            // 
            // rowAccuracy
            // 
            rowAccuracy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowAccuracy.BackColor = Color.Transparent;
            rowAccuracy.GapSize = 2;
            rowAccuracy.InactiveColor = Color.FromArgb(45, 50, 60);
            rowAccuracy.LabelText = "ACCURACY";
            rowAccuracy.Location = new Point(0, 0);
            rowAccuracy.Margin = new Padding(3, 3, 3, 20);
            rowAccuracy.Name = "rowAccuracy";
            rowAccuracy.SegmentCount = 20;
            rowAccuracy.Size = new Size(410, 36);
            rowAccuracy.TabIndex = 90;
            rowAccuracy.Text = "steamStatRow1";
            rowAccuracy.ThemeColor = Color.FromArgb(26, 191, 32);
            rowAccuracy.Value = 85;
            // 
            // rowEfficiency
            // 
            rowEfficiency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowEfficiency.BackColor = Color.Transparent;
            rowEfficiency.GapSize = 2;
            rowEfficiency.InactiveColor = Color.FromArgb(45, 50, 60);
            rowEfficiency.LabelText = "EFFCIENCY";
            rowEfficiency.Location = new Point(0, 36);
            rowEfficiency.Margin = new Padding(3, 3, 3, 20);
            rowEfficiency.Name = "rowEfficiency";
            rowEfficiency.SegmentCount = 20;
            rowEfficiency.Size = new Size(410, 36);
            rowEfficiency.TabIndex = 91;
            rowEfficiency.Text = "steamStatRow2";
            rowEfficiency.ThemeColor = Color.FromArgb(26, 191, 32);
            rowEfficiency.Value = 85;
            // 
            // rowRobustness
            // 
            rowRobustness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowRobustness.BackColor = Color.Transparent;
            rowRobustness.GapSize = 2;
            rowRobustness.InactiveColor = Color.FromArgb(45, 50, 60);
            rowRobustness.LabelText = "ROBUSTNESS";
            rowRobustness.Location = new Point(0, 72);
            rowRobustness.Name = "rowRobustness";
            rowRobustness.SegmentCount = 20;
            rowRobustness.Size = new Size(410, 36);
            rowRobustness.TabIndex = 92;
            rowRobustness.Text = "steamStatRow3";
            rowRobustness.ThemeColor = Color.FromArgb(26, 191, 32);
            rowRobustness.Value = 85;
            // 
            // rowMaintainability
            // 
            rowMaintainability.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowMaintainability.BackColor = Color.Transparent;
            rowMaintainability.GapSize = 2;
            rowMaintainability.InactiveColor = Color.FromArgb(45, 50, 60);
            rowMaintainability.LabelText = "MAINTAINABILITY";
            rowMaintainability.Location = new Point(0, 108);
            rowMaintainability.Name = "rowMaintainability";
            rowMaintainability.SegmentCount = 20;
            rowMaintainability.Size = new Size(410, 36);
            rowMaintainability.TabIndex = 93;
            rowMaintainability.Text = "steamStatRow4";
            rowMaintainability.ThemeColor = Color.FromArgb(26, 191, 32);
            rowMaintainability.Value = 85;
            // 
            // steamLabel1
            // 
            steamLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(314, 11);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(80, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 93;
            steamLabel1.Text = "Score : ";
            steamLabel1.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(rowMaintainability);
            panel1.Controls.Add(rowRobustness);
            panel1.Controls.Add(rowEfficiency);
            panel1.Controls.Add(rowAccuracy);
            panel1.Location = new Point(11, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 179);
            panel1.TabIndex = 94;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(167, 2);
            label1.Name = "label1";
            label1.Size = new Size(141, 116);
            label1.TabIndex = 95;
            label1.Text = "Ill hide this score for now. set its visibility to true in property window if needed";
            label1.Visible = false;
            // 
            // StudentCodeRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(steamLabel1);
            Controls.Add(scoreLabel);
            Name = "StudentCodeRating";
            Size = new Size(432, 248);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SteamThings.SteamStatRow rowAccuracy;
        private SteamThings.SteamStatRow rowEfficiency;
        private SteamThings.SteamStatRow rowRobustness;
        private SteamThings.SteamStatRow rowMaintainability;
        private SteamThings.SteamLabel scoreLabel;
        private SteamThings.SteamLabel steamLabel1;
        private Panel panel1;
        private Label label1;
    }
}
