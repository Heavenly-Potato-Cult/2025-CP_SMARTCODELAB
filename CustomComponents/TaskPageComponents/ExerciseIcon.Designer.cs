namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class ExerciseIcon
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
            SuspendLayout();
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject.ForeColor = Color.Gray;
            subject.Location = new Point(32, 46);
            subject.Name = "subject";
            subject.Size = new Size(252, 25);
            subject.TabIndex = 20;
            subject.Text = "Data Structures and Algorithm";
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskName.ForeColor = Color.FromArgb(13, 13, 13);
            taskName.Location = new Point(32, 15);
            taskName.Name = "taskName";
            taskName.Size = new Size(155, 31);
            taskName.TabIndex = 19;
            taskName.Text = "Array Sorting";
            // 
            // ExerciseIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(subject);
            Controls.Add(taskName);
            Name = "ExerciseIcon";
            Size = new Size(432, 86);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subject;
        private Label taskName;
    }
}
