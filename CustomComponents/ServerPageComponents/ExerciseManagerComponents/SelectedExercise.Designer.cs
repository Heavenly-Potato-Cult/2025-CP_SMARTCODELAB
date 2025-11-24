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
            taskName.Anchor = AnchorStyles.Left;
            taskName.AutoSize = true;
            taskName.BackColor = Color.Transparent;
            taskName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskName.ForeColor = Color.FromArgb(224, 224, 224);
            taskName.Location = new Point(30, 11);
            taskName.Name = "taskName";
            taskName.Size = new Size(50, 20);
            taskName.TabIndex = 0;
            taskName.Text = "Name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(164, 7);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SelectedExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(taskName);
            Name = "SelectedExercise";
            Size = new Size(201, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskName;
        private Button button1;
    }
}
