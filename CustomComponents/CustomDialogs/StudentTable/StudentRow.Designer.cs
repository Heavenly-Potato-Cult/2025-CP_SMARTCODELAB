namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    partial class StudentRow
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
            studId = new Label();
            studName = new Label();
            SuspendLayout();
            // 
            // studId
            // 
            studId.AutoSize = true;
            studId.Location = new Point(27, 16);
            studId.Name = "studId";
            studId.Size = new Size(77, 20);
            studId.TabIndex = 0;
            studId.Text = "Student Id";
            // 
            // studName
            // 
            studName.AutoSize = true;
            studName.Location = new Point(291, 16);
            studName.Name = "studName";
            studName.Size = new Size(104, 20);
            studName.TabIndex = 1;
            studName.Text = "Student Name";
            // 
            // StudentRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(studName);
            Controls.Add(studId);
            Name = "StudentRow";
            Size = new Size(592, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studId;
        private Label studName;
    }
}
