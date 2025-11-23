namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class TestCase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCase2));
            splitContainer1 = new SplitContainer();
            codeEditor1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label1 = new Label();
            codeEditor2 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)codeEditor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 33, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(codeEditor1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(codeEditor2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(649, 190);
            splitContainer1.SplitterDistance = 315;
            splitContainer1.SplitterWidth = 11;
            splitContainer1.TabIndex = 85;
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
            codeEditor1.Dock = DockStyle.Fill;
            codeEditor1.Font = new Font("Courier New", 9.75F);
            codeEditor1.ForeColor = Color.Black;
            codeEditor1.Hotkeys = resources.GetString("codeEditor1.Hotkeys");
            codeEditor1.IsReplaceMode = false;
            codeEditor1.Location = new Point(0, 25);
            codeEditor1.Name = "codeEditor1";
            codeEditor1.Paddings = new Padding(0);
            codeEditor1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor1.ServiceColors");
            codeEditor1.Size = new Size(315, 165);
            codeEditor1.TabIndex = 82;
            codeEditor1.Zoom = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 81;
            label1.Text = "Input";
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
            codeEditor2.AutoScrollMinSize = new Size(31, 18);
            codeEditor2.BackBrush = null;
            codeEditor2.CharHeight = 18;
            codeEditor2.CharWidth = 10;
            codeEditor2.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor2.Dock = DockStyle.Fill;
            codeEditor2.ForeColor = Color.Black;
            codeEditor2.Hotkeys = resources.GetString("codeEditor2.Hotkeys");
            codeEditor2.IsReplaceMode = false;
            codeEditor2.Location = new Point(0, 25);
            codeEditor2.Name = "codeEditor2";
            codeEditor2.Paddings = new Padding(0);
            codeEditor2.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor2.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor2.ServiceColors");
            codeEditor2.Size = new Size(323, 165);
            codeEditor2.TabIndex = 84;
            codeEditor2.Zoom = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 83;
            label2.Text = "Expected Output";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.RosyBrown;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(515, 1);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 33);
            button1.TabIndex = 86;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 190);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 35);
            panel1.TabIndex = 87;
            // 
            // TestCase2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TestCase2";
            Size = new Size(649, 225);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)codeEditor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Pages.ProgrammingTabs.CodeEditor codeEditor1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Pages.ProgrammingTabs.CodeEditor codeEditor2;
    }
}
