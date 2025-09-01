namespace SmartCodeLab.CustomComponents.Pages
{
    partial class CodingEnvironment
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
            srcCode = new TextBox();
            SuspendLayout();
            // 
            // srcCode
            // 
            srcCode.Location = new Point(3, 3);
            srcCode.Multiline = true;
            srcCode.Name = "srcCode";
            srcCode.Size = new Size(917, 668);
            srcCode.TabIndex = 0;
            // 
            // CodingEnvironment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(srcCode);
            Name = "CodingEnvironment";
            Size = new Size(923, 671);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox srcCode;
    }
}
