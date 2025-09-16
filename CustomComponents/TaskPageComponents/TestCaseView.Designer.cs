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
            number = new Label();
            ((System.ComponentModel.ISupportInitialize)input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
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
            input.AutoScrollMinSize = new Size(31, 18);
            input.AutoSize = true;
            input.BackBrush = null;
            input.CharHeight = 18;
            input.CharWidth = 10;
            input.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            input.Font = new Font("Courier New", 9.75F);
            input.Hotkeys = resources.GetString("input.Hotkeys");
            input.IsReplaceMode = false;
            input.Location = new Point(3, 56);
            input.Name = "input";
            input.Paddings = new Padding(0);
            input.ReadOnly = true;
            input.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            input.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("input.ServiceColors");
            input.Size = new Size(211, 104);
            input.TabIndex = 80;
            input.Zoom = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
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
            output.AutoScrollMinSize = new Size(31, 18);
            output.AutoSize = true;
            output.BackBrush = null;
            output.CharHeight = 18;
            output.CharWidth = 10;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IsReplaceMode = false;
            output.Location = new Point(220, 56);
            output.Name = "output";
            output.Paddings = new Padding(0);
            output.ReadOnly = true;
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.Size = new Size(227, 104);
            output.TabIndex = 82;
            output.Zoom = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(220, 28);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 83;
            label2.Text = "Output";
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.ForeColor = Color.DimGray;
            number.Location = new Point(0, 0);
            number.Name = "number";
            number.Size = new Size(50, 25);
            number.TabIndex = 84;
            number.Text = "num";
            // 
            // TestCaseView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(number);
            Controls.Add(label2);
            Controls.Add(output);
            Controls.Add(label1);
            Controls.Add(input);
            Name = "TestCaseView";
            Size = new Size(450, 163);
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Pages.ProgrammingTabs.CodeEditor input;
        private Label label1;
        private Pages.ProgrammingTabs.CodeEditor output;
        private Label label2;
        private Label number;
    }
}
