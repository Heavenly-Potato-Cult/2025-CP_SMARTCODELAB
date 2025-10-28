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
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 11);
            label14.Name = "label14";
            label14.Size = new Size(23, 25);
            label14.TabIndex = 15;
            label14.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 16;
            label1.Text = "Clifford Magno";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(400, 11);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 17;
            label2.Text = "100";
            // 
            // leaderboardIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BorderRadius = 5;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label14);
            Name = "leaderboardIcon";
            Size = new Size(461, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Label label1;
        private Label label2;
    }
}
