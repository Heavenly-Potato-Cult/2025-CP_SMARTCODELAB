namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ToDelete
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentCodeRating1 = new SmartCodeLab.CustomComponents.ServerPageComponents.StudentCodeRating();
            SuspendLayout();
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.Location = new Point(5, 12);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(451, 658);
            studentCodeRating1.TabIndex = 0;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 682);
            Controls.Add(studentCodeRating1);
            Name = "ToDelete";
            Text = "ToDelete";
            ResumeLayout(false);
        }

        #endregion

        private ServerPageComponents.StudentCodeRating studentCodeRating1;
    }
}