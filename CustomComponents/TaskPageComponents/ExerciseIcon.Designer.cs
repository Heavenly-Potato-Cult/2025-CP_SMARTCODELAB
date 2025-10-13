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
            taskName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskName.ForeColor = Color.FromArgb(13, 13, 13);
            taskName.Location = new Point(3, 10);
            taskName.Name = "taskName";
            taskName.Size = new Size(155, 31);
            taskName.TabIndex = 19;
            taskName.Text = "Array Sorting";
            // 
            // button1
            // 
            button1.Location = new Point(335, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExerciseIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(taskName);
            Name = "ExerciseIcon";
            Size = new Size(432, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label taskName;
        private Button button1;
    }
}
