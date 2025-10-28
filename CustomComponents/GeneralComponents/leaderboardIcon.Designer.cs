namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    partial class leaderboardIcon
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
            ranking = new Label();
            name = new Label();
            studscore = new Label();
            SuspendLayout();
            // 
            // ranking
            // 
            ranking.AutoSize = true;
            ranking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ranking.ForeColor = Color.Black;
            ranking.Location = new Point(14, 11);
            ranking.Name = "ranking";
            ranking.Size = new Size(23, 25);
            ranking.TabIndex = 15;
            ranking.Text = "1";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.Black;
            name.Location = new Point(78, 11);
            name.Name = "name";
            name.Size = new Size(149, 25);
            name.TabIndex = 16;
            name.Text = "Clifford Magno";
            // 
            // studscore
            // 
            studscore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studscore.AutoSize = true;
            studscore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studscore.ForeColor = Color.Black;
            studscore.Location = new Point(402, 11);
            studscore.Name = "studscore";
            studscore.Size = new Size(45, 25);
            studscore.TabIndex = 17;
            studscore.Text = "100";
            // 
            // leaderboardIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BorderRadius = 5;
            Controls.Add(studscore);
            Controls.Add(name);
            Controls.Add(ranking);
            Name = "leaderboardIcon";
            Size = new Size(461, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ranking;
        private Label name;
        private Label studscore;
    }
}
