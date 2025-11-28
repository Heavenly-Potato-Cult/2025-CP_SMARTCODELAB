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
            rowRobustness = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            rowMaintainability = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            rowEfficiency = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            rowAccuracy = new SmartCodeLab.CustomComponents.SteamThings.SteamStatRow();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Dock = DockStyle.Right;
            scoreLabel.Font = new Font("Geist", 12F);
            scoreLabel.ForeColor = Color.FromArgb(199, 213, 224);
            scoreLabel.Location = new Point(411, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(21, 23);
            scoreLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            scoreLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            scoreLabel.TabIndex = 92;
            scoreLabel.Text = "0";
            scoreLabel.Visible = false;
            scoreLabel.Click += scoreLabel_Click;
            // 
            // rowRobustness
            // 
            rowRobustness.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowRobustness.BackColor = Color.Transparent;
            rowRobustness.GapSize = 2;
            rowRobustness.highestScore = 0;
            rowRobustness.InactiveColor = Color.FromArgb(45, 50, 60);
            rowRobustness.LabelText = "ROBUSTNESS";
            rowRobustness.Location = new Point(3, 117);
            rowRobustness.Name = "rowRobustness";
            rowRobustness.SegmentCount = 20;
            rowRobustness.Size = new Size(426, 36);
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
            rowMaintainability.highestScore = 0;
            rowMaintainability.InactiveColor = Color.FromArgb(45, 50, 60);
            rowMaintainability.LabelText = "MAINTAINABILITY";
            rowMaintainability.Location = new Point(3, 171);
            rowMaintainability.Name = "rowMaintainability";
            rowMaintainability.SegmentCount = 20;
            rowMaintainability.Size = new Size(426, 36);
            rowMaintainability.TabIndex = 93;
            rowMaintainability.Text = "steamStatRow4";
            rowMaintainability.ThemeColor = Color.FromArgb(26, 191, 32);
            rowMaintainability.Value = 85;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Dock = DockStyle.Right;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(331, 0);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(80, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 93;
            steamLabel1.Text = "Score : ";
            steamLabel1.Visible = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(161, 3);
            label1.Name = "label1";
            label1.Size = new Size(141, 116);
            label1.TabIndex = 95;
            label1.Text = "Ill hide this score for now. set its visibility to true in property window if needed";
            label1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(rowEfficiency, 0, 1);
            tableLayoutPanel1.Controls.Add(rowMaintainability, 0, 3);
            tableLayoutPanel1.Controls.Add(rowAccuracy, 0, 0);
            tableLayoutPanel1.Controls.Add(rowRobustness, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(432, 216);
            tableLayoutPanel1.TabIndex = 96;
            // 
            // rowEfficiency
            // 
            rowEfficiency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowEfficiency.BackColor = Color.Transparent;
            rowEfficiency.GapSize = 2;
            rowEfficiency.highestScore = 0;
            rowEfficiency.InactiveColor = Color.FromArgb(45, 50, 60);
            rowEfficiency.LabelText = "EFFICIENCY";
            rowEfficiency.Location = new Point(3, 63);
            rowEfficiency.Name = "rowEfficiency";
            rowEfficiency.SegmentCount = 20;
            rowEfficiency.Size = new Size(426, 36);
            rowEfficiency.TabIndex = 98;
            rowEfficiency.Text = "steamStatRow3";
            rowEfficiency.ThemeColor = Color.FromArgb(26, 191, 32);
            rowEfficiency.Value = 85;
            // 
            // rowAccuracy
            // 
            rowAccuracy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowAccuracy.BackColor = Color.Transparent;
            rowAccuracy.GapSize = 2;
            rowAccuracy.highestScore = 0;
            rowAccuracy.InactiveColor = Color.FromArgb(45, 50, 60);
            rowAccuracy.LabelText = "ACCURACY";
            rowAccuracy.Location = new Point(3, 9);
            rowAccuracy.Name = "rowAccuracy";
            rowAccuracy.SegmentCount = 20;
            rowAccuracy.Size = new Size(426, 36);
            rowAccuracy.TabIndex = 97;
            rowAccuracy.Text = "ACCURACY";
            rowAccuracy.ThemeColor = Color.FromArgb(26, 191, 32);
            rowAccuracy.Value = 85;
            // 
            // panel1
            // 
            panel1.Controls.Add(steamLabel1);
            panel1.Controls.Add(scoreLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 32);
            panel1.TabIndex = 97;
            // 
            // StudentCodeRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "StudentCodeRating";
            Size = new Size(432, 248);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamStatRow rowRobustness;
        private SteamThings.SteamStatRow rowMaintainability;
        private SteamThings.SteamLabel scoreLabel;
        private SteamThings.SteamLabel steamLabel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private SteamThings.SteamStatRow rowAccuracy;
        private SteamThings.SteamStatRow rowEfficiency;
        private Panel panel1;
    }
}
