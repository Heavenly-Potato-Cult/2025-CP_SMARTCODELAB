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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDelete));
            codeEditor1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            button1 = new Button();
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
            codeEditor1.AutoScrollMinSize = new Size(141, 18);
            codeEditor1.BackBrush = null;
            codeEditor1.CharHeight = 18;
            codeEditor1.CharWidth = 10;
            codeEditor1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor1.Font = new Font("Courier New", 9.75F);
            codeEditor1.Hotkeys = resources.GetString("codeEditor1.Hotkeys");
            codeEditor1.IsReplaceMode = false;
            codeEditor1.Location = new Point(12, 12);
            codeEditor1.Name = "codeEditor1";
            codeEditor1.Paddings = new Padding(0);
            codeEditor1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor1.ServiceColors");
            codeEditor1.Size = new Size(1070, 579);
            codeEditor1.TabIndex = 0;
            codeEditor1.Text = "codeEditor1";
            codeEditor1.Zoom = 100;
            // 
            // button1
            // 
            button1.Location = new Point(476, 612);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 682);
            Controls.Add(button1);
            Controls.Add(codeEditor1);
            Name = "ToDelete";
            Text = "ToDelete";
            ((System.ComponentModel.ISupportInitialize)codeEditor1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Pages.ProgrammingTabs.CodeEditor codeEditor1;
        private Button button1;
    }
}