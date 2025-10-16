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
            studentCodeRating1.Location = new Point(4, 9);
            studentCodeRating1.Margin = new Padding(3, 2, 3, 2);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(395, 494);
            studentCodeRating1.TabIndex = 0;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 512);
            Controls.Add(studentCodeRating1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDelete";
            Text = "ToDelete";
            Deactivate += ToDelete_Deactivate;
            VisibleChanged += ToDelete_VisibleChanged;
            Leave += ToDelete_Leave;
            ResumeLayout(false);
        }

        #endregion

        private ServerPageComponents.StudentCodeRating studentCodeRating1;
    }
}