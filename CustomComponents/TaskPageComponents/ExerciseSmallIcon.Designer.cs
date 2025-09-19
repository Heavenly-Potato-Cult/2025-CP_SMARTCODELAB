namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class ExerciseSmallIcon
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
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Location = new Point(3, 9);
            taskName.Name = "taskName";
            taskName.Size = new Size(50, 20);
            taskName.TabIndex = 0;
            taskName.Text = "label1";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(201, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(81, 34);
            smartButton1.TabIndex = 1;
            smartButton1.Text = "View";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // ExerciseSmallIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(smartButton1);
            Controls.Add(taskName);
            Name = "ExerciseSmallIcon";
            Size = new Size(283, 38);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskName;
        private GeneralComponents.SmartButton smartButton1;
    }
}
