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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            srcCode = new CodeEditor();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            output = new CodeEditor();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)srcCode).BeginInit();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 560);
            tabControl1.TabIndex = 15;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(srcCode);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(882, 527);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "MainCode";
            tabPage3.UseVisualStyleBackColor = true;
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
            srcCode.AutoScrollMinSize = new Size(31, 18);
            srcCode.AutoSize = true;
            srcCode.BackBrush = null;
            srcCode.CharHeight = 18;
            srcCode.CharWidth = 10;
            srcCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            srcCode.Hotkeys = resources.GetString("srcCode.Hotkeys");
            srcCode.IsReplaceMode = false;
            srcCode.Location = new Point(6, 6);
            srcCode.Name = "srcCode";
            srcCode.Paddings = new Padding(0);
            srcCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            srcCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("srcCode.ServiceColors");
            srcCode.Size = new Size(870, 518);
            srcCode.TabIndex = 0;
            srcCode.Zoom = 100;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Location = new Point(0, 559);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(899, 227);
            tabControl2.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(output);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(891, 194);
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
            output.AutoScrollMinSize = new Size(31, 18);
            output.BackBrush = null;
            output.CharHeight = 18;
            output.CharWidth = 10;
            output.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            output.Font = new Font("Courier New", 9.75F);
            output.Hotkeys = resources.GetString("output.Hotkeys");
            output.IsReplaceMode = false;
            output.Location = new Point(9, 6);
            output.Name = "output";
            output.Paddings = new Padding(0);
            output.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            output.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("output.ServiceColors");
            output.Size = new Size(883, 188);
            output.TabIndex = 0;
            output.Zoom = 100;
            // 
            // BaseCodeEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Name = "BaseCodeEditor";
            Size = new Size(896, 786);
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)srcCode).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage3;
        public CodeEditor srcCode;
        private TabControl tabControl2;
        private TabPage tabPage1;
        protected CodeEditor output;
    }
}
