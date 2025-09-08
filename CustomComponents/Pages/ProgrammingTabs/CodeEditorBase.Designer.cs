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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditorBase));
            output = new TextBox();
            srcCode = new CodeEditor();
            ((System.ComponentModel.ISupportInitialize)srcCode).BeginInit();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(22, 642);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(1072, 163);
            output.TabIndex = 1;
            // 
            // srcCode
            // 
            srcCode.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            srcCode.AutoScrollMinSize = new Size(31, 18);
            srcCode.BackBrush = null;
            srcCode.CharHeight = 18;
            srcCode.CharWidth = 10;
            srcCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            srcCode.Hotkeys = resources.GetString("srcCode.Hotkeys");
            srcCode.IsReplaceMode = false;
            srcCode.Location = new Point(0, 0);
            srcCode.Name = "srcCode";
            srcCode.Paddings = new Padding(0);
            srcCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            srcCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("srcCode.ServiceColors");
            srcCode.Size = new Size(1094, 643);
            srcCode.TabIndex = 2;
            srcCode.Zoom = 100;
            // 
            // CodeEditorBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(srcCode);
            Controls.Add(output);
            Name = "CodeEditorBase";
            Size = new Size(1097, 808);
            ((System.ComponentModel.ISupportInitialize)srcCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected TextBox output;
        public CodeEditor srcCode;
    }
}
