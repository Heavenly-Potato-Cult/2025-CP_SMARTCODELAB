namespace SmartCodeLab.CustomComponents
{
    partial class DialogOptions
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
            optionName = new Label();
            SuspendLayout();
            // 
            // optionName
            // 
            optionName.AutoSize = true;
            optionName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optionName.Location = new Point(3, 7);
            optionName.Name = "optionName";
            optionName.Size = new Size(51, 20);
            optionName.TabIndex = 0;
            optionName.Text = "label1";
            // 
            // DialogOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(optionName);
            Name = "DialogOptions";
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label optionName;
    }
}
