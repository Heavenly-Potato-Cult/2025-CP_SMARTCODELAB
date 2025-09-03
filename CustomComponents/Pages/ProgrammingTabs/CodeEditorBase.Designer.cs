namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class CodeEditorBase
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
            output = new TextBox();
            SuspendLayout();
            // 
            // srcCode
            // 
            srcCode.Location = new Point(0, 0);
            srcCode.Multiline = true;
            srcCode.Name = "srcCode";
            srcCode.Size = new Size(1094, 636);
            srcCode.TabIndex = 0;
            srcCode.KeyUp += srcCode_KeyUp;
            // 
            // output
            // 
            output.Location = new Point(3, 642);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(1091, 163);
            output.TabIndex = 1;
            // 
            // CodeEditorBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(output);
            Controls.Add(srcCode);
            Name = "CodeEditorBase";
            Size = new Size(1097, 808);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox srcCode;
        protected TextBox output;
    }
}
