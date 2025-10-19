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
            codeQualityChoices1 = new SmartCodeLab.CustomComponents.GeneralComponents.CodeQualityChoices();
            SuspendLayout();
            // 
            // codeQualityChoices1
            // 
            codeQualityChoices1.Location = new Point(58, 143);
            codeQualityChoices1.Margin = new Padding(3, 2, 3, 2);
            codeQualityChoices1.Name = "codeQualityChoices1";
            codeQualityChoices1.Size = new Size(212, 111);
            codeQualityChoices1.TabIndex = 0;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 512);
            Controls.Add(codeQualityChoices1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDelete";
            Text = "ToDelete";
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CodeQualityChoices codeQualityChoices1;
    }
}