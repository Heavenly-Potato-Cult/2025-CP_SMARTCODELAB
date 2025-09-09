namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class TestCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCase));
            input = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            output = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label1 = new Label();
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
            input.BackBrush = null;
            input.CharHeight = 18;
            input.CharWidth = 10;
            input.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            input.Hotkeys = resources.GetString("input.Hotkeys");
            input.IsReplaceMode = false;
            input.Location = new Point(0, 0);
            input.Name = "input";
            input.Paddings = new Padding(0);
            input.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            input.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("input.ServiceColors");
            input.Size = new Size(350, 123);
            input.TabIndex = 0;
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
            output.AutoScrollMinSize = new Size(31, 18);
            output.BackBrush = null;
            output.CharHeight = 18;
            output.CharWidth = 10;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Font = new Font("Courier New", 9.75F);
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IsReplaceMode = false;
            output.Location = new Point(352, 0);
            output.Name = "output";
            output.Paddings = new Padding(0);
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.Size = new Size(334, 123);
            output.TabIndex = 1;
            output.Zoom = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(689, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 23);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // TestCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(input);
            Name = "TestCase";
            Size = new Size(710, 123);
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Pages.ProgrammingTabs.CodeEditor input;
        private Pages.ProgrammingTabs.CodeEditor output;
        private Label label1;
    }
}
