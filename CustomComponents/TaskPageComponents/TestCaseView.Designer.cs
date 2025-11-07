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
            input = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label1 = new Label();
            output = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
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
            input.AutoScrollMinSize = new Size(27, 14);
            input.AutoSize = true;
            input.BackBrush = null;
            input.CharHeight = 14;
            input.CharWidth = 8;
            input.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            input.Dock = DockStyle.Fill;
            input.Hotkeys = resources.GetString("input.Hotkeys");
            input.IsReplaceMode = false;
            input.Location = new Point(0, 20);
            input.Margin = new Padding(3, 2, 3, 2);
            input.Name = "input";
            input.Paddings = new Padding(0);
            input.ReadOnly = true;
            input.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            input.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("input.ServiceColors");
            input.Size = new Size(212, 91);
            input.TabIndex = 80;
            input.Zoom = 100;
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
            label1.TabIndex = 81;
            label1.Text = "Input";
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
            output.AutoScrollMinSize = new Size(27, 14);
            output.AutoSize = true;
            output.BackBrush = null;
            output.CharHeight = 14;
            output.CharWidth = 8;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Dock = DockStyle.Fill;
            output.Font = new Font("Courier New", 9.75F);
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IsReplaceMode = false;
            output.Location = new Point(0, 20);
            output.Margin = new Padding(3, 2, 3, 2);
            output.Name = "output";
            output.Paddings = new Padding(0);
            output.ReadOnly = true;
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.Size = new Size(232, 91);
            output.TabIndex = 82;
            output.Zoom = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 83;
            label2.Text = "Output";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
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
            splitContainer1.Size = new Size(464, 111);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 84;
            // 
            // TestCaseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TestCaseView";
            Size = new Size(464, 111);
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Pages.ProgrammingTabs.CodeEditor input;
        private Label label1;
        private Pages.ProgrammingTabs.CodeEditor output;
        private Label label2;
        private SplitContainer splitContainer1;
    }
}
