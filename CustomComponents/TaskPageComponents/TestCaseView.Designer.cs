namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class TestCaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCaseView));
            label1 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            input = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            output = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 29);
            label1.TabIndex = 81;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(260, 29);
            label2.TabIndex = 83;
            label2.Text = "Output";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(input);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(output);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(520, 148);
            splitContainer1.SplitterDistance = 237;
            splitContainer1.SplitterWidth = 23;
            splitContainer1.TabIndex = 84;
            // 
            // input
            // 
            input.AutoCompleteBracketsList = new char[]
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
            input.AutoScrollMinSize = new Size(31, 28);
            input.AutoSize = true;
            input.BackBrush = null;
            input.BackColor = Color.FromArgb(24, 24, 27);
            input.CaretColor = Color.Silver;
            input.CharHeight = 18;
            input.CharWidth = 10;
            input.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            input.Dock = DockStyle.Fill;
            input.Font = new Font("Courier New", 9.75F);
            input.ForeColor = Color.Silver;
            input.Hotkeys = resources.GetString("input.Hotkeys");
            input.IndentBackColor = Color.FromArgb(25, 28, 45);
            input.IsReplaceMode = false;
            input.LineNumberColor = Color.Silver;
            input.Location = new Point(0, 29);
            input.Name = "input";
            input.Paddings = new Padding(0, 0, 0, 10);
            input.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            input.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("input.ServiceColors");
            input.ServiceLinesColor = Color.FromArgb(42, 71, 94);
            input.Size = new Size(237, 119);
            input.TabIndex = 82;
            input.Zoom = 100;
            // 
            // output
            // 
            output.AutoCompleteBracketsList = new char[]
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
            output.AutoScrollMinSize = new Size(31, 28);
            output.AutoSize = true;
            output.BackBrush = null;
            output.BackColor = Color.FromArgb(24, 24, 27);
            output.CaretColor = Color.Silver;
            output.CharHeight = 18;
            output.CharWidth = 10;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Dock = DockStyle.Fill;
            output.Font = new Font("Courier New", 9.75F);
            output.ForeColor = Color.Silver;
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IndentBackColor = Color.FromArgb(25, 28, 45);
            output.IsReplaceMode = false;
            output.LineNumberColor = Color.Silver;
            output.Location = new Point(0, 29);
            output.Name = "output";
            output.Paddings = new Padding(0, 0, 0, 10);
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.ServiceLinesColor = Color.FromArgb(42, 71, 94);
            output.Size = new Size(260, 119);
            output.TabIndex = 84;
            output.Zoom = 100;
            // 
            // TestCaseView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(splitContainer1);
            Name = "TestCaseView";
            Padding = new Padding(5, 0, 5, 0);
            Size = new Size(530, 148);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private SplitContainer splitContainer1;
        public Pages.ProgrammingTabs.CodeEditor input;
        public Pages.ProgrammingTabs.CodeEditor output;
    }
}
