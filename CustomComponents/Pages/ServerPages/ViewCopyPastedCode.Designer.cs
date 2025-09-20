namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class ViewCopyPastedCode
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCopyPastedCode));
            codeEditor1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            ((System.ComponentModel.ISupportInitialize)codeEditor1).BeginInit();
            SuspendLayout();
            // 
            // codeEditor1
            // 
            codeEditor1.AutoCompleteBracketsList = new char[]
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
            codeEditor1.AutoScrollMinSize = new Size(31, 18);
            codeEditor1.BackBrush = null;
            codeEditor1.CharHeight = 18;
            codeEditor1.CharWidth = 10;
            codeEditor1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor1.Hotkeys = resources.GetString("codeEditor1.Hotkeys");
            codeEditor1.IsReplaceMode = false;
            codeEditor1.Location = new Point(12, 12);
            codeEditor1.Name = "codeEditor1";
            codeEditor1.Paddings = new Padding(0);
            codeEditor1.ReadOnly = true;
            codeEditor1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor1.ServiceColors");
            codeEditor1.Size = new Size(776, 426);
            codeEditor1.TabIndex = 0;
            codeEditor1.Zoom = 100;
            // 
            // ViewCopyPastedCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(codeEditor1);
            Name = "ViewCopyPastedCode";
            Text = "ViewCopyPastedCode";
            ((System.ComponentModel.ISupportInitialize)codeEditor1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgrammingTabs.CodeEditor codeEditor1;
    }
}