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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)actualOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            actualOutput.Dock = DockStyle.Fill;
            actualOutput.Font = new Font("Courier New", 9.75F);
            actualOutput.Hotkeys = resources.GetString("actualOutput.Hotkeys");
            actualOutput.IsReplaceMode = false;
            actualOutput.Location = new Point(0, 20);
            actualOutput.Margin = new Padding(3, 2, 3, 2);
            actualOutput.Name = "actualOutput";
            actualOutput.Paddings = new Padding(0);
            actualOutput.ReadOnly = true;
            actualOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            actualOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("actualOutput.ServiceColors");
            actualOutput.Size = new Size(224, 141);
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
            expectedOutput.Dock = DockStyle.Fill;
            expectedOutput.Font = new Font("Courier New", 9.75F);
            expectedOutput.Hotkeys = resources.GetString("expectedOutput.Hotkeys");
            expectedOutput.IsReplaceMode = false;
            expectedOutput.Location = new Point(0, 20);
            expectedOutput.Margin = new Padding(3, 2, 3, 2);
            expectedOutput.Name = "expectedOutput";
            expectedOutput.Paddings = new Padding(0);
            expectedOutput.ReadOnly = true;
            expectedOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            expectedOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("expectedOutput.ServiceColors");
            expectedOutput.Size = new Size(195, 141);
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
            inputs.Dock = DockStyle.Fill;
            inputs.Font = new Font("Courier New", 9.75F);
            inputs.Hotkeys = resources.GetString("inputs.Hotkeys");
            inputs.IsReplaceMode = false;
            inputs.Location = new Point(0, 20);
            inputs.Margin = new Padding(3, 2, 3, 2);
            inputs.Name = "inputs";
            inputs.Paddings = new Padding(0);
            inputs.ReadOnly = true;
            inputs.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            inputs.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("inputs.ServiceColors");
            inputs.Size = new Size(231, 141);
            inputs.TabIndex = 86;
            inputs.Text = "codeEditor1";
            inputs.Zoom = 100;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputs);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(658, 161);
            splitContainer1.SplitterDistance = 231;
            splitContainer1.TabIndex = 89;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(expectedOutput);
            splitContainer2.Panel1.Controls.Add(label2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(actualOutput);
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Size = new Size(423, 161);
            splitContainer2.SplitterDistance = 195;
            splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 82;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 82;
            label2.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 82;
            label3.Text = "Correct";
            // 
            // TestCaseResult2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "TestCaseResult2";
            Size = new Size(658, 161);
            ((System.ComponentModel.ISupportInitialize)actualOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputs).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CodeEditor actualOutput;
        private CodeEditor expectedOutput;
        private CodeEditor inputs;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
