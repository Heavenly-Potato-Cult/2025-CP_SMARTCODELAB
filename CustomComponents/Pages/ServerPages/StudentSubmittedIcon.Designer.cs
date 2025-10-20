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
            placing = new Label();
            name = new Label();
            score = new Label();
            SuspendLayout();
            // 
            // placing
            // 
            placing.AutoSize = true;
            placing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placing.Location = new Point(15, 10);
            placing.Name = "placing";
            placing.Size = new Size(24, 28);
            placing.TabIndex = 0;
            placing.Text = "0";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(92, 11);
            name.Name = "name";
            name.Size = new Size(68, 28);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.Location = new Point(402, 11);
            score.Name = "score";
            score.Size = new Size(62, 28);
            score.TabIndex = 2;
            score.Text = "score";
            score.TextAlign = ContentAlignment.TopCenter;
            // 
            // StudentSubmittedIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(score);
            Controls.Add(name);
            Controls.Add(placing);
            Name = "StudentSubmittedIcon";
            Size = new Size(520, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label placing;
        private Label name;
        private Label score;
    }
}
