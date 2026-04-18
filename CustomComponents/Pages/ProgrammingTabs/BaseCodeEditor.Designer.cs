namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class BaseCodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseCodeEditor));
            srcCode = new CodeEditor();
            ((System.ComponentModel.ISupportInitialize)srcCode).BeginInit();
            SuspendLayout();
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
            srcCode.AutoScrollMinSize = new Size(141, 18);
            srcCode.BackBrush = null;
            srcCode.CharHeight = 18;
            srcCode.CharWidth = 10;
            srcCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            srcCode.Font = new Font("Courier New", 9.75F);
            srcCode.Hotkeys = resources.GetString("srcCode.Hotkeys");
            srcCode.IsReplaceMode = false;
            srcCode.Location = new Point(3, 3);
            srcCode.Name = "srcCode";
            srcCode.Paddings = new Padding(0);
            srcCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            srcCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("srcCode.ServiceColors");
            srcCode.ServiceLinesColor = Color.FromArgb(42, 71, 94);
            srcCode.Size = new Size(822, 679);
            srcCode.TabIndex = 18;
            srcCode.Text = "codeEditor1";
            srcCode.Zoom = 100;
            // 
            // BaseCodeEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(srcCode);
            Name = "BaseCodeEditor";
            Size = new Size(825, 685);
            ((System.ComponentModel.ISupportInitialize)srcCode).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public CodeEditor srcCode;
    }
}
