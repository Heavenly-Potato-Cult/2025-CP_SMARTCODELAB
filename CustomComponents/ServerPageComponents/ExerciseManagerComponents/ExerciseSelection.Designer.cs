namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class ExerciseSelection
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
            subject = new Label();
            taskName = new Label();
            testCounts = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject.ForeColor = Color.DimGray;
            subject.Location = new Point(3, 41);
            subject.Name = "subject";
            subject.Size = new Size(70, 25);
            subject.TabIndex = 65;
            subject.Text = "Subject";
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskName.ForeColor = Color.FromArgb(13, 13, 13);
            taskName.Location = new Point(3, 10);
            taskName.Name = "taskName";
            taskName.Size = new Size(144, 31);
            taskName.TabIndex = 64;
            taskName.Text = "Hello World";
            // 
            // testCounts
            // 
            testCounts.AutoSize = true;
            testCounts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testCounts.ForeColor = Color.FromArgb(13, 13, 13);
            testCounts.Location = new Point(169, 36);
            testCounts.Name = "testCounts";
            testCounts.Size = new Size(27, 31);
            testCounts.TabIndex = 68;
            testCounts.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(169, 16);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 67;
            label1.Text = "Total Test Cases";
            // 
            // ExerciseSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(testCounts);
            Controls.Add(label1);
            Controls.Add(subject);
            Controls.Add(taskName);
            Name = "ExerciseSelection";
            Size = new Size(415, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subject;
        private Label taskName;
        private Label testCounts;
        private Label label1;
    }
}
