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
            output = new CmdPanel();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)srcCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            customCard1.SuspendLayout();
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
            srcCode.AutoScrollMinSize = new Size(101, 29);
            srcCode.AutoSize = true;
            srcCode.BackBrush = null;
            srcCode.BackColor = Color.FromArgb(24, 24, 27);
            srcCode.CaretColor = Color.Silver;
            srcCode.CharHeight = 19;
            srcCode.CharWidth = 10;
            srcCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            srcCode.Dock = DockStyle.Fill;
            srcCode.ForeColor = Color.Silver;
            srcCode.Hotkeys = resources.GetString("srcCode.Hotkeys");
            srcCode.IndentBackColor = Color.FromArgb(21, 28, 38);
            srcCode.IsReplaceMode = false;
            srcCode.LineNumberColor = Color.Silver;
            srcCode.Location = new Point(0, 0);
            srcCode.Name = "srcCode";
            srcCode.Paddings = new Padding(0, 0, 0, 10);
            srcCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            srcCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("srcCode.ServiceColors");
            srcCode.ServiceLinesColor = Color.FromArgb(42, 71, 94);
            srcCode.Size = new Size(825, 529);
            srcCode.TabIndex = 0;
            srcCode.Text = "testing";
            srcCode.Zoom = 100;
            // 
            // output
            // 
            output.BackColor = SystemColors.ActiveCaption;
            output.Dock = DockStyle.Fill;
            output.Location = new Point(0, 45);
            output.Margin = new Padding(0);
            output.Name = "output";
            output.Size = new Size(825, 110);
            output.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(srcCode);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(output);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(customCard1);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(825, 685);
            splitContainer1.SplitterDistance = 529;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 71, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 1);
            panel2.TabIndex = 24;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(21, 28, 38);
            customCard1.BorderColor = Color.FromArgb(42, 71, 94);
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 0;
            customCard1.Controls.Add(steamLabel1);
            customCard1.Dock = DockStyle.Top;
            customCard1.Location = new Point(0, 1);
            customCard1.Margin = new Padding(0);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(825, 43);
            customCard1.TabIndex = 22;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel1.Location = new Point(15, 10);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(83, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel1.TabIndex = 0;
            steamLabel1.Text = "Terminal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 71, 94);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 1);
            panel1.TabIndex = 23;
            // 
            // BaseCodeEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(splitContainer1);
            Name = "BaseCodeEditor";
            Size = new Size(825, 685);
            ((System.ComponentModel.ISupportInitialize)srcCode).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public CodeEditor srcCode;
        private SplitContainer splitContainer1;
        protected CmdPanel output;
        private GeneralComponents.CustomCard customCard1;
        private SteamThings.SteamLabel steamLabel1;
        private Panel panel2;
        private Panel panel1;
    }
}
