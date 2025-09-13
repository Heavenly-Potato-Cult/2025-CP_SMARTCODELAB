namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class ServerPageIcon
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
            subject.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject.ForeColor = Color.Gray;
            subject.Location = new Point(19, 33);
            subject.Name = "subject";
            subject.Size = new Size(184, 17);
            subject.TabIndex = 22;
            subject.Text = "Data Structures and Algorithm";
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskName.ForeColor = Color.FromArgb(13, 13, 13);
            taskName.Location = new Point(19, 2);
            taskName.Name = "taskName";
            taskName.Size = new Size(155, 31);
            taskName.TabIndex = 21;
            taskName.Text = "Array Sorting";
            // 
            // ServerPageIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(subject);
            Controls.Add(taskName);
            Name = "ServerPageIcon";
            Size = new Size(290, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subject;
        private Label taskName;
    }
}
