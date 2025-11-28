namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class TestCase3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCase3));
            codeEditor1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            codeEditor2 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            button1 = new Button();
            customCard12 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            ((System.ComponentModel.ISupportInitialize)codeEditor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).BeginInit();
            customCard12.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            codeEditor1.AutoScrollMinSize = new Size(31, 18);
            codeEditor1.BackBrush = null;
            codeEditor1.BackColor = Color.FromArgb(11, 14, 17);
            codeEditor1.CaretColor = Color.Silver;
            codeEditor1.CharHeight = 18;
            codeEditor1.CharWidth = 10;
            codeEditor1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor1.Dock = DockStyle.Fill;
            codeEditor1.ForeColor = Color.Silver;
            codeEditor1.Hotkeys = resources.GetString("codeEditor1.Hotkeys");
            codeEditor1.IndentBackColor = Color.FromArgb(11, 14, 17);
            codeEditor1.IsReplaceMode = false;
            codeEditor1.Location = new Point(3, 26);
            codeEditor1.Name = "codeEditor1";
            codeEditor1.Paddings = new Padding(0);
            codeEditor1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor1.ServiceColors");
            codeEditor1.Size = new Size(202, 91);
            codeEditor1.TabIndex = 82;
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
            codeEditor2.AutoScrollMinSize = new Size(31, 18);
            codeEditor2.BackBrush = null;
            codeEditor2.BackColor = Color.FromArgb(11, 14, 17);
            codeEditor2.CaretColor = Color.Silver;
            codeEditor2.CharHeight = 18;
            codeEditor2.CharWidth = 10;
            codeEditor2.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            codeEditor2.Dock = DockStyle.Fill;
            codeEditor2.Font = new Font("Courier New", 9.75F);
            codeEditor2.ForeColor = Color.Silver;
            codeEditor2.Hotkeys = resources.GetString("codeEditor2.Hotkeys");
            codeEditor2.IndentBackColor = Color.FromArgb(11, 14, 17);
            codeEditor2.IsReplaceMode = false;
            codeEditor2.Location = new Point(211, 26);
            codeEditor2.Name = "codeEditor2";
            codeEditor2.Paddings = new Padding(0);
            codeEditor2.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            codeEditor2.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("codeEditor2.ServiceColors");
            codeEditor2.Size = new Size(202, 91);
            codeEditor2.TabIndex = 84;
            codeEditor2.Zoom = 100;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 71, 94);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(419, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 42);
            button1.TabIndex = 86;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // customCard12
            // 
            customCard12.BackColor = Color.FromArgb(23, 29, 37);
            customCard12.BorderColor = Color.FromArgb(42, 71, 94);
            customCard12.BorderRadius = 2;
            customCard12.BorderSize = 1;
            customCard12.Controls.Add(tableLayoutPanel1);
            customCard12.Dock = DockStyle.Fill;
            customCard12.Location = new Point(0, 0);
            customCard12.Margin = new Padding(0);
            customCard12.Name = "customCard12";
            customCard12.Padding = new Padding(2);
            customCard12.Size = new Size(471, 124);
            customCard12.TabIndex = 115;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(19, 27, 36);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.08696F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.913044F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(codeEditor2, 1, 1);
            tableLayoutPanel1.Controls.Add(codeEditor1, 0, 1);
            tableLayoutPanel1.Controls.Add(steamLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(steamLabel2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2048988F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.795105F));
            tableLayoutPanel1.Size = new Size(467, 120);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(3, 0);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(67, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 0;
            steamLabel1.Text = "INPUT";
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel2.Location = new Point(211, 0);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(89, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel2.TabIndex = 1;
            steamLabel2.Text = "OUTPUT";
            // 
            // TestCase3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(customCard12);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TestCase3";
            Size = new Size(471, 124);
            ((System.ComponentModel.ISupportInitialize)codeEditor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)codeEditor2).EndInit();
            customCard12.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Pages.ProgrammingTabs.CodeEditor codeEditor1;
        private Button button1;
        private Pages.ProgrammingTabs.CodeEditor codeEditor2;
        private GeneralComponents.CustomCard customCard12;
        private SteamThings.SteamLabel steamLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private SteamThings.SteamLabel steamLabel2;
    }
}
