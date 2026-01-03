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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ranking
            // 
            ranking.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ranking.AutoSize = true;
            ranking.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ranking.ForeColor = Color.Black;
            ranking.Location = new Point(3, 5);
            ranking.Name = "ranking";
            ranking.Size = new Size(57, 20);
            ranking.TabIndex = 15;
            ranking.Text = "1";
            ranking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            name.ForeColor = Color.Black;
            name.Location = new Point(66, 5);
            name.Name = "name";
            name.Size = new Size(301, 20);
            name.TabIndex = 16;
            name.Text = "Clifford Magno";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studscore
            // 
            studscore.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            studscore.AutoSize = true;
            studscore.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            studscore.ForeColor = Color.Black;
            studscore.Location = new Point(373, 5);
            studscore.Name = "studscore";
            studscore.Size = new Size(81, 20);
            studscore.TabIndex = 17;
            studscore.Text = "100";
            studscore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.93352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.1835861F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.8828964F));
            tableLayoutPanel1.Controls.Add(ranking, 0, 0);
            tableLayoutPanel1.Controls.Add(studscore, 2, 0);
            tableLayoutPanel1.Controls.Add(name, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(457, 31);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // leaderboardIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BorderRadius = 2;
            BorderSize = 1;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 3, 3, 10);
            Name = "leaderboardIcon";
            Padding = new Padding(2);
            Size = new Size(461, 35);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ranking;
        private Label name;
        public Label studscore;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
