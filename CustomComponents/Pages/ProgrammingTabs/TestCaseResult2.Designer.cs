namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class TestCaseResult2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCaseResult2));
            actualOutput = new CodeEditor();
            expectedOutput = new CodeEditor();
            inputs = new CodeEditor();
            ((System.ComponentModel.ISupportInitialize)actualOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputs).BeginInit();
            SuspendLayout();
            // 
            // actualOutput
            // 
            actualOutput.AutoCompleteBracketsList = new char[]
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
            actualOutput.AutoScrollMinSize = new Size(115, 14);
            actualOutput.BackBrush = null;
            actualOutput.CharHeight = 14;
            actualOutput.CharWidth = 8;
            actualOutput.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            actualOutput.Hotkeys = resources.GetString("actualOutput.Hotkeys");
            actualOutput.IsReplaceMode = false;
            actualOutput.Location = new Point(662, 32);
            actualOutput.Margin = new Padding(3, 2, 3, 2);
            actualOutput.Name = "actualOutput";
            actualOutput.Paddings = new Padding(0);
            actualOutput.ReadOnly = true;
            actualOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            actualOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("actualOutput.ServiceColors");
            actualOutput.Size = new Size(157, 103);
            actualOutput.TabIndex = 88;
            actualOutput.Text = "codeEditor3";
            actualOutput.Zoom = 100;
            // 
            // expectedOutput
            // 
            expectedOutput.AutoCompleteBracketsList = new char[]
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
            expectedOutput.AutoScrollMinSize = new Size(115, 14);
            expectedOutput.BackBrush = null;
            expectedOutput.CharHeight = 14;
            expectedOutput.CharWidth = 8;
            expectedOutput.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            expectedOutput.Hotkeys = resources.GetString("expectedOutput.Hotkeys");
            expectedOutput.IsReplaceMode = false;
            expectedOutput.Location = new Point(419, 32);
            expectedOutput.Margin = new Padding(3, 2, 3, 2);
            expectedOutput.Name = "expectedOutput";
            expectedOutput.Paddings = new Padding(0);
            expectedOutput.ReadOnly = true;
            expectedOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            expectedOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("expectedOutput.ServiceColors");
            expectedOutput.Size = new Size(157, 103);
            expectedOutput.TabIndex = 87;
            expectedOutput.Text = "codeEditor2";
            expectedOutput.Zoom = 100;
            // 
            // inputs
            // 
            inputs.AutoCompleteBracketsList = new char[]
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
            inputs.AutoScrollMinSize = new Size(115, 14);
            inputs.BackBrush = null;
            inputs.CharHeight = 14;
            inputs.CharWidth = 8;
            inputs.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            inputs.Hotkeys = resources.GetString("inputs.Hotkeys");
            inputs.IsReplaceMode = false;
            inputs.Location = new Point(3, 32);
            inputs.Margin = new Padding(3, 2, 3, 2);
            inputs.Name = "inputs";
            inputs.Paddings = new Padding(0);
            inputs.ReadOnly = true;
            inputs.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            inputs.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("inputs.ServiceColors");
            inputs.Size = new Size(332, 105);
            inputs.TabIndex = 86;
            inputs.Text = "codeEditor1";
            inputs.Zoom = 100;
            // 
            // TestCaseResult2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(actualOutput);
            Controls.Add(expectedOutput);
            Controls.Add(inputs);
            Name = "TestCaseResult2";
            Size = new Size(548, 139);
            ((System.ComponentModel.ISupportInitialize)actualOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CodeEditor actualOutput;
        private CodeEditor expectedOutput;
        private CodeEditor inputs;
    }
}
