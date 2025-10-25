namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class SelectedExercise
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
            taskName.Location = new Point(3, 11);
            taskName.Name = "taskName";
            taskName.Size = new Size(49, 20);
            taskName.TabIndex = 0;
            taskName.Text = "Name";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(176, 9);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SelectedExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(taskName);
            Name = "SelectedExercise";
            Size = new Size(205, 41);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskName;
        private Button button1;
    }
}
