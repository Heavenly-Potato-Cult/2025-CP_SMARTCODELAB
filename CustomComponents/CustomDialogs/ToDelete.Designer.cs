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
            codeRatingui1 = new SmartCodeLab.CustomComponents.ServerPageComponents.CodeRatingUI();
            SuspendLayout();
            // 
            // codeRatingui1
            // 
            codeRatingui1.BackColor = Color.White;
            codeRatingui1.Location = new Point(84, 97);
            codeRatingui1.Name = "codeRatingui1";
            codeRatingui1.Size = new Size(439, 209);
            codeRatingui1.TabIndex = 0;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(codeRatingui1);
            Name = "ToDelete";
            Text = "ToDelete";
            ResumeLayout(false);
        }

        #endregion

        private ServerPageComponents.CodeRatingUI codeRatingui1;
    }
}