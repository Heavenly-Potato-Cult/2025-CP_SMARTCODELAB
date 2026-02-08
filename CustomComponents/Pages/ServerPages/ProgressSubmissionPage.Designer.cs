namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class ProgressSubmissionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressSubmissionPage));
            customComboBox2 = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            customCard6 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            submittedContainer = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard9 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            searchBox = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            customCard8 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            submitCount = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            copypastedCodes = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel6 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard10 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            score = new Label();
            steamLabel4 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard11 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCodeRating1 = new SmartCodeLab.CustomComponents.ServerPageComponents.CodeRatingUI();
            customCard6.SuspendLayout();
            customCard9.SuspendLayout();
            customCard8.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            customCard3.SuspendLayout();
            customCard1.SuspendLayout();
            customCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard4.SuspendLayout();
            customCard5.SuspendLayout();
            customCard10.SuspendLayout();
            customCard11.SuspendLayout();
            SuspendLayout();
            // 
            // customComboBox2
            // 
            customComboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customComboBox2.BackColor = Color.FromArgb(26, 30, 36);
            customComboBox2.Items.AddRange(new object[] { "Earliest Pass", "Points" });
            customComboBox2.Location = new Point(223, 17);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(139, 44);
            customComboBox2.TabIndex = 95;
            customComboBox2.Theme = SteamThings.SteamTheme.Dark;
            customComboBox2.SelectedIndexChanged += customComboBox2_SelectedIndexChanged;
            // 
            // customCard6
            // 
            customCard6.BackColor = Color.FromArgb(21, 28, 38);
            customCard6.BorderColor = Color.FromArgb(42, 71, 94);
            customCard6.BorderRadius = 2;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(submittedContainer);
            customCard6.Controls.Add(customCard9);
            customCard6.Controls.Add(customCard8);
            customCard6.Dock = DockStyle.Fill;
            customCard6.Location = new Point(0, 0);
            customCard6.Margin = new Padding(0, 0, 20, 0);
            customCard6.Name = "customCard6";
            tableLayoutPanel1.SetRowSpan(customCard6, 2);
            customCard6.Size = new Size(372, 750);
            customCard6.TabIndex = 110;
            // 
            // submittedContainer
            // 
            submittedContainer.AutoScroll = true;
            submittedContainer.BackColor = Color.FromArgb(21, 28, 38);
            submittedContainer.BorderColor = Color.FromArgb(42, 71, 94);
            submittedContainer.BorderRadius = 2;
            submittedContainer.BorderSize = 1;
            submittedContainer.Dock = DockStyle.Fill;
            submittedContainer.Location = new Point(0, 156);
            submittedContainer.Margin = new Padding(0);
            submittedContainer.Name = "submittedContainer";
            submittedContainer.Padding = new Padding(10, 10, 10, 2);
            submittedContainer.Size = new Size(372, 594);
            submittedContainer.TabIndex = 112;
            // 
            // customCard9
            // 
            customCard9.BackColor = Color.FromArgb(21, 28, 38);
            customCard9.BorderColor = Color.FromArgb(42, 71, 94);
            customCard9.BorderRadius = 2;
            customCard9.BorderSize = 1;
            customCard9.Controls.Add(searchBox);
            customCard9.Controls.Add(customComboBox2);
            customCard9.Dock = DockStyle.Top;
            customCard9.Location = new Point(0, 78);
            customCard9.Margin = new Padding(0);
            customCard9.Name = "customCard9";
            customCard9.Size = new Size(372, 78);
            customCard9.TabIndex = 111;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.BackColor = Color.FromArgb(26, 30, 36);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(15, 17);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 8, 10, 8);
            searchBox.PlaceholderColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search student...";
            searchBox.Size = new Size(190, 44);
            searchBox.TabIndex = 110;
            searchBox.Theme = SteamThings.SteamTheme.Dark;
            // 
            // customCard8
            // 
            customCard8.BackColor = Color.FromArgb(21, 28, 38);
            customCard8.BorderColor = Color.FromArgb(42, 71, 94);
            customCard8.BorderRadius = 2;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(submitCount);
            customCard8.Controls.Add(steamLabel1);
            customCard8.Dock = DockStyle.Top;
            customCard8.Location = new Point(0, 0);
            customCard8.Margin = new Padding(0);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(372, 78);
            customCard8.TabIndex = 111;
            // 
            // submitCount
            // 
            submitCount.AutoSize = true;
            submitCount.BackColor = Color.Transparent;
            submitCount.Font = new Font("Geist", 12F);
            submitCount.ForeColor = Color.FromArgb(199, 213, 224);
            submitCount.Location = new Point(209, 28);
            submitCount.Name = "submitCount";
            submitCount.Size = new Size(21, 23);
            submitCount.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            submitCount.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            submitCount.TabIndex = 72;
            submitCount.Text = "0";
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(18, 28);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(185, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 0;
            steamLabel1.Text = "Total Submissions : ";
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(tableLayoutPanel1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1801, 848);
            steamGradientPanel1.TabIndex = 111;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.28186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7851639F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9329777F));
            tableLayoutPanel1.Controls.Add(customCard3, 2, 0);
            tableLayoutPanel1.Controls.Add(customCard6, 0, 0);
            tableLayoutPanel1.Controls.Add(customCard2, 1, 0);
            tableLayoutPanel1.Controls.Add(customCard5, 2, 1);
            tableLayoutPanel1.Location = new Point(20, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1761, 750);
            tableLayoutPanel1.TabIndex = 115;
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.FromArgb(21, 28, 38);
            customCard3.BorderColor = Color.FromArgb(42, 71, 94);
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(customCard1);
            customCard3.Controls.Add(copypastedCodes);
            customCard3.Dock = DockStyle.Fill;
            customCard3.Location = new Point(1306, 3);
            customCard3.Margin = new Padding(20, 3, 3, 3);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(452, 369);
            customCard3.TabIndex = 115;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(21, 28, 38);
            customCard1.BorderColor = Color.FromArgb(42, 71, 94);
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(steamLabel3);
            customCard1.Dock = DockStyle.Top;
            customCard1.Location = new Point(0, 0);
            customCard1.Margin = new Padding(20, 3, 3, 3);
            customCard1.Name = "customCard1";
            customCard1.Padding = new Padding(5);
            customCard1.Size = new Size(452, 75);
            customCard1.TabIndex = 109;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 10F);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(15, 29);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(186, 19);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 0;
            steamLabel3.Text = "COPY-PASTE HISTORY";
            // 
            // copypastedCodes
            // 
            copypastedCodes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            copypastedCodes.AutoScroll = true;
            copypastedCodes.BackColor = Color.FromArgb(18, 23, 29);
            copypastedCodes.BorderColor = Color.FromArgb(42, 71, 94);
            copypastedCodes.BorderRadius = 2;
            copypastedCodes.BorderSize = 0;
            copypastedCodes.Location = new Point(5, 87);
            copypastedCodes.Margin = new Padding(0);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Padding = new Padding(10, 10, 10, 5);
            copypastedCodes.Size = new Size(445, 272);
            copypastedCodes.TabIndex = 106;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.FromArgb(23, 29, 37);
            customCard2.BorderColor = Color.FromArgb(42, 71, 94);
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(studentCode);
            customCard2.Controls.Add(customCard4);
            customCard2.Dock = DockStyle.Fill;
            customCard2.Location = new Point(392, 0);
            customCard2.Margin = new Padding(0);
            customCard2.Name = "customCard2";
            tableLayoutPanel1.SetRowSpan(customCard2, 2);
            customCard2.Size = new Size(894, 750);
            customCard2.TabIndex = 109;
            // 
            // studentCode
            // 
            studentCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentCode.AutoCompleteBracketsList = new char[]
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
            studentCode.AutoScrollMinSize = new Size(0, 18);
            studentCode.BackBrush = null;
            studentCode.BackColor = Color.Transparent;
            studentCode.CharHeight = 18;
            studentCode.CharWidth = 10;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.ForeColor = Color.LightGray;
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IndentBackColor = Color.Transparent;
            studentCode.IsReplaceMode = false;
            studentCode.LineNumberColor = Color.LightGray;
            studentCode.Location = new Point(8, 84);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.ServiceLinesColor = Color.DimGray;
            studentCode.Size = new Size(873, 651);
            studentCode.TabIndex = 15;
            studentCode.WordWrap = true;
            studentCode.Zoom = 100;
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.FromArgb(21, 28, 38);
            customCard4.BorderColor = Color.FromArgb(42, 71, 94);
            customCard4.BorderRadius = 2;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(steamLabel2);
            customCard4.Controls.Add(steamLabel6);
            customCard4.Dock = DockStyle.Top;
            customCard4.Location = new Point(0, 0);
            customCard4.Margin = new Padding(20, 3, 3, 3);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(5);
            customCard4.Size = new Size(894, 78);
            customCard4.TabIndex = 108;
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel2.Location = new Point(129, 28);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(55, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel2.TabIndex = 72;
            steamLabel2.Text = "None";
            // 
            // steamLabel6
            // 
            steamLabel6.AutoSize = true;
            steamLabel6.BackColor = Color.Transparent;
            steamLabel6.Font = new Font("Geist", 10F);
            steamLabel6.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel6.Location = new Point(30, 30);
            steamLabel6.Name = "steamLabel6";
            steamLabel6.Size = new Size(93, 19);
            steamLabel6.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel6.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel6.TabIndex = 1;
            steamLabel6.Text = "STUDENT :";
            // 
            // customCard5
            // 
            customCard5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard5.BackColor = Color.FromArgb(21, 28, 38);
            customCard5.BorderColor = Color.FromArgb(42, 71, 94);
            customCard5.BorderRadius = 2;
            customCard5.BorderSize = 1;
            customCard5.Controls.Add(customCard10);
            customCard5.Controls.Add(customCard11);
            customCard5.Location = new Point(1306, 378);
            customCard5.Margin = new Padding(20, 3, 3, 3);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(452, 336);
            customCard5.TabIndex = 114;
            // 
            // customCard10
            // 
            customCard10.BackColor = Color.FromArgb(21, 28, 38);
            customCard10.BorderColor = Color.FromArgb(42, 71, 94);
            customCard10.BorderRadius = 2;
            customCard10.BorderSize = 1;
            customCard10.Controls.Add(score);
            customCard10.Controls.Add(steamLabel4);
            customCard10.Dock = DockStyle.Top;
            customCard10.Location = new Point(0, 0);
            customCard10.Margin = new Padding(20, 3, 3, 3);
            customCard10.Name = "customCard10";
            customCard10.Padding = new Padding(5);
            customCard10.Size = new Size(452, 75);
            customCard10.TabIndex = 109;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = SystemColors.ButtonFace;
            score.Location = new Point(90, 21);
            score.Name = "score";
            score.Size = new Size(24, 28);
            score.TabIndex = 76;
            score.Text = "0";
            // 
            // steamLabel4
            // 
            steamLabel4.AutoSize = true;
            steamLabel4.BackColor = Color.Transparent;
            steamLabel4.Font = new Font("Geist", 12F);
            steamLabel4.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel4.Location = new Point(15, 26);
            steamLabel4.Name = "steamLabel4";
            steamLabel4.Size = new Size(80, 23);
            steamLabel4.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel4.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel4.TabIndex = 73;
            steamLabel4.Text = "Score : ";
            // 
            // customCard11
            // 
            customCard11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customCard11.BackColor = Color.FromArgb(18, 23, 29);
            customCard11.BorderColor = Color.FromArgb(42, 71, 94);
            customCard11.BorderRadius = 2;
            customCard11.BorderSize = 0;
            customCard11.Controls.Add(studentCodeRating1);
            customCard11.Location = new Point(5, 67);
            customCard11.Margin = new Padding(0);
            customCard11.Name = "customCard11";
            customCard11.Padding = new Padding(10, 10, 10, 5);
            customCard11.Size = new Size(442, 259);
            customCard11.TabIndex = 106;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.BackColor = Color.Transparent;
            studentCodeRating1.Location = new Point(3, 13);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(439, 238);
            studentCodeRating1.TabIndex = 0;
            // 
            // ProgressSubmissionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            Name = "ProgressSubmissionPage";
            Size = new Size(1801, 848);
            customCard6.ResumeLayout(false);
            customCard9.ResumeLayout(false);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            steamGradientPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            customCard3.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            customCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            customCard5.ResumeLayout(false);
            customCard10.ResumeLayout(false);
            customCard10.PerformLayout();
            customCard11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GeneralComponents.CustomCard customCard7;
        private Label label6;
        private Label label14;
        private Label score;
        private Label studentName;
        private SteamThings.SteamComboBox customComboBox2;
        private GeneralComponents.CustomCard customCard6;
        private GeneralComponents.CustomCard submittedContainer;
        private GeneralComponents.CustomCard customCard9;
        private SteamThings.SteamTextBox searchBox;
        private GeneralComponents.CustomCard customCard8;
        private SteamThings.SteamLabel submitCount;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel steamLabel4;
        private GeneralComponents.CustomCard customCard2;
        private ProgrammingTabs.CodeEditor studentCode;
        private GeneralComponents.CustomCard customCard4;
        private SteamThings.SteamLabel steamLabel6;
        private GeneralComponents.CustomCard customCard5;
        private GeneralComponents.CustomCard customCard11;
        private GeneralComponents.CustomCard customCard10;
        private TableLayoutPanel tableLayoutPanel1;
        private GeneralComponents.CustomCard customCard3;
        private GeneralComponents.CustomCard customCard1;
        private SteamThings.SteamLabel steamLabel3;
        private GeneralComponents.CustomCard copypastedCodes;
        private ServerPageComponents.CodeRatingUI studentCodeRating1;
    }
}
