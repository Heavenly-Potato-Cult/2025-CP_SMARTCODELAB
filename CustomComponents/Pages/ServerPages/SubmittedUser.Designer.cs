namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class SubmittedUser
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
            status = new Label();
            score = new Label();
            studentName = new Label();
            SuspendLayout();
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.ForeColor = Color.DimGray;
            status.Location = new Point(420, 15);
            status.Name = "status";
            status.Size = new Size(66, 25);
            status.TabIndex = 23;
            status.Text = "Passed";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score.ForeColor = Color.DimGray;
            score.Location = new Point(283, 15);
            score.Name = "score";
            score.Size = new Size(42, 25);
            score.TabIndex = 22;
            score.Text = "100";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.DimGray;
            studentName.Location = new Point(30, 15);
            studentName.Name = "studentName";
            studentName.Size = new Size(170, 25);
            studentName.TabIndex = 21;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // SubmittedUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(status);
            Controls.Add(score);
            Controls.Add(studentName);
            Name = "SubmittedUser";
            Size = new Size(517, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label status;
        private Label score;
        private Label studentName;
    }
}
