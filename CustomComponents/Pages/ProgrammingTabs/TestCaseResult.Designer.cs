namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class TestCaseResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCaseResult));
            label17 = new Label();
            num = new Label();
            result = new Label();
            label2 = new Label();
            button1 = new Button();
            inputs = new CodeEditor();
            expectedOutput = new CodeEditor();
            actualOutput = new CodeEditor();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)inputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actualOutput).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(-3, -3);
            label17.Name = "label17";
            label17.Size = new Size(110, 31);
            label17.TabIndex = 78;
            label17.Text = "Test Case";
            // 
            // num
            // 
            num.AutoSize = true;
            num.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num.ForeColor = Color.Black;
            num.Location = new Point(113, -3);
            num.Name = "num";
            num.Size = new Size(27, 31);
            num.TabIndex = 79;
            num.Text = "0";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.ForeColor = Color.Black;
            result.Location = new Point(620, -1);
            result.Name = "result";
            result.Size = new Size(92, 31);
            result.TabIndex = 81;
            result.Text = "Correct";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(534, -1);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 80;
            label2.Text = "Result";
            // 
            // button1
            // 
            button1.Location = new Point(930, -1);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 82;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            inputs.AutoScrollMinSize = new Size(112, 18);
            inputs.BackBrush = null;
            inputs.CharHeight = 18;
            inputs.CharWidth = 10;
            inputs.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            inputs.Hotkeys = resources.GetString("inputs.Hotkeys");
            inputs.IsReplaceMode = false;
            inputs.Location = new Point(3, 34);
            inputs.Name = "inputs";
            inputs.Paddings = new Padding(0);
            inputs.ReadOnly = true;
            inputs.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            inputs.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("inputs.ServiceColors");
            inputs.Size = new Size(470, 207);
            inputs.TabIndex = 83;
            inputs.Text = "codeEditor1";
            inputs.Zoom = 100;
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
            expectedOutput.AutoScrollMinSize = new Size(112, 18);
            expectedOutput.BackBrush = null;
            expectedOutput.CharHeight = 18;
            expectedOutput.CharWidth = 10;
            expectedOutput.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            expectedOutput.Font = new Font("Courier New", 9.75F);
            expectedOutput.Hotkeys = resources.GetString("expectedOutput.Hotkeys");
            expectedOutput.IsReplaceMode = false;
            expectedOutput.Location = new Point(479, 34);
            expectedOutput.Name = "expectedOutput";
            expectedOutput.Paddings = new Padding(0);
            expectedOutput.ReadOnly = true;
            expectedOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            expectedOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("expectedOutput.ServiceColors");
            expectedOutput.Size = new Size(270, 204);
            expectedOutput.TabIndex = 84;
            expectedOutput.Text = "codeEditor2";
            expectedOutput.Zoom = 100;
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
            actualOutput.AutoScrollMinSize = new Size(112, 18);
            actualOutput.BackBrush = null;
            actualOutput.CharHeight = 18;
            actualOutput.CharWidth = 10;
            actualOutput.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            actualOutput.Hotkeys = resources.GetString("actualOutput.Hotkeys");
            actualOutput.IsReplaceMode = false;
            actualOutput.Location = new Point(757, 34);
            actualOutput.Name = "actualOutput";
            actualOutput.Paddings = new Padding(0);
            actualOutput.ReadOnly = true;
            actualOutput.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            actualOutput.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("actualOutput.ServiceColors");
            actualOutput.Size = new Size(270, 204);
            actualOutput.TabIndex = 85;
            actualOutput.Text = "codeEditor3";
            actualOutput.Zoom = 100;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(num);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(result);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 28);
            panel1.TabIndex = 86;
            // 
            // TestCaseResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(actualOutput);
            Controls.Add(expectedOutput);
            Controls.Add(inputs);
            Name = "TestCaseResult";
            Size = new Size(1030, 31);
            ((System.ComponentModel.ISupportInitialize)inputs).EndInit();
            ((System.ComponentModel.ISupportInitialize)expectedOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)actualOutput).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label17;
        private Label num;
        private Label result;
        private Label label2;
        private Button button1;
        private CodeEditor inputs;
        private CodeEditor expectedOutput;
        private CodeEditor actualOutput;
        private Panel panel1;
    }
}
