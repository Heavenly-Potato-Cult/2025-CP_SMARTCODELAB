namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
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
            codeEditor1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            codeEditor2 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)codeEditor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).BeginInit();
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
            codeEditor1.AutoScrollMinSize = new Size(2, 18);
            codeEditor1.BackBrush = null;
            codeEditor1.CharHeight = 18;
            codeEditor1.CharWidth = 10;
            codeEditor1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor1.ForeColor = Color.Black;
            codeEditor1.Hotkeys = resources.GetString("codeEditor1.Hotkeys");
            codeEditor1.IsReplaceMode = false;
            codeEditor1.Location = new Point(3, 58);
            codeEditor1.Name = "codeEditor1";
            codeEditor1.Paddings = new Padding(0);
            codeEditor1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor1.ServiceColors");
            codeEditor1.Size = new Size(231, 172);
            codeEditor1.TabIndex = 0;
            codeEditor1.Zoom = 100;
            // 
            // codeEditor2
            // 
            codeEditor2.AutoCompleteBracketsList = new char[]
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
            codeEditor2.AutoScrollMinSize = new Size(2, 18);
            codeEditor2.BackBrush = null;
            codeEditor2.CharHeight = 18;
            codeEditor2.CharWidth = 10;
            codeEditor2.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor2.Font = new Font("Courier New", 9.75F);
            codeEditor2.ForeColor = Color.Black;
            codeEditor2.Hotkeys = resources.GetString("codeEditor2.Hotkeys");
            codeEditor2.IsReplaceMode = false;
            codeEditor2.Location = new Point(232, 58);
            codeEditor2.Name = "codeEditor2";
            codeEditor2.Paddings = new Padding(0);
            codeEditor2.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor2.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor2.ServiceColors");
            codeEditor2.Size = new Size(231, 172);
            codeEditor2.TabIndex = 1;
            codeEditor2.Zoom = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 32);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 47;
            label5.Text = "Input";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(232, 32);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 48;
            label1.Text = "Expected Output";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(369, 1);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 49;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TestCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(codeEditor2);
            Controls.Add(codeEditor1);
            Name = "TestCase";
            Size = new Size(463, 30);
            Click += TestCase_Click;
            ((System.ComponentModel.ISupportInitialize)codeEditor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Pages.ProgrammingTabs.CodeEditor codeEditor1;
        private Pages.ProgrammingTabs.CodeEditor codeEditor2;
        private Label label5;
        private Label label1;
        private Button button1;
    }
}
