namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class BaseCodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseCodeEditor));
            srcCode = new CodeEditor();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            output = new ConsoleTextBox();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)srcCode).BeginInit();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // srcCode
            // 
            srcCode.AutoCompleteBracketsList = new char[]
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
            srcCode.AutoScrollMinSize = new Size(27, 14);
            srcCode.AutoSize = true;
            srcCode.BackBrush = null;
            srcCode.CharHeight = 14;
            srcCode.CharWidth = 8;
            srcCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            srcCode.Dock = DockStyle.Fill;
            srcCode.Hotkeys = resources.GetString("srcCode.Hotkeys");
            srcCode.IsReplaceMode = false;
            srcCode.Location = new Point(0, 0);
            srcCode.Margin = new Padding(3, 2, 3, 2);
            srcCode.Name = "srcCode";
            srcCode.Paddings = new Padding(0, 20, 0, 10);
            srcCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            srcCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("srcCode.ServiceColors");
            srcCode.Size = new Size(722, 357);
            srcCode.TabIndex = 0;
            srcCode.Zoom = 100;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Margin = new Padding(3, 2, 3, 2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(722, 153);
            tabControl2.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(output);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(714, 125);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Output";
            tabPage1.UseVisualStyleBackColor = true;
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
            output.BackBrush = null;
            output.CharHeight = 14;
            output.CharWidth = 8;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Dock = DockStyle.Fill;
            output.Font = new Font("Courier New", 9.75F);
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IsReplaceMode = false;
            output.Location = new Point(3, 2);
            output.Margin = new Padding(3, 2, 3, 2);
            output.Name = "output";
            output.Paddings = new Padding(0);
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.Size = new Size(708, 121);
            output.TabIndex = 0;
            output.Zoom = 100;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(srcCode);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl2);
            splitContainer1.Size = new Size(722, 514);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.TabIndex = 17;
            // 
            // BaseCodeEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BaseCodeEditor";
            Size = new Size(722, 514);
            ((System.ComponentModel.ISupportInitialize)srcCode).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public CodeEditor srcCode;
        private TabControl tabControl2;
        private TabPage tabPage1;
        protected ConsoleTextBox output;
        private SplitContainer splitContainer1;
    }
}
