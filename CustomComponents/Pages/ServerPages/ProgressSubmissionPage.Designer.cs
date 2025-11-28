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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Accurary", "50" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Readbility", "20" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Efficiency", "30" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Complexity", "20" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Total", "100" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressSubmissionPage));
            expansionPanel2 = new ExpansionPanel();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1 = new Panel();
            customComboBox2 = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            customCard6 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            submittedContainer = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard9 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            searchBox = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            customCard8 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            submitCount = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            splitContainer1 = new SplitContainer();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel6 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard10 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel5 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel4 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard11 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCodeRating1 = new SmartCodeLab.CustomComponents.ServerPageComponents.StudentCodeRating();
            expansionPanel2.SuspendLayout();
            panel1.SuspendLayout();
            customCard6.SuspendLayout();
            customCard9.SuspendLayout();
            customCard8.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            customCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            customCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard4.SuspendLayout();
            customCard5.SuspendLayout();
            customCard10.SuspendLayout();
            customCard11.SuspendLayout();
            SuspendLayout();
            // 
            // expansionPanel2
            // 
            expansionPanel2.BackColor = Color.Gainsboro;
            expansionPanel2.Controls.Add(materialListView1);
            expansionPanel2.Dock = DockStyle.Top;
            expansionPanel2.HeaderColor = Color.White;
            expansionPanel2.IconText = "v";
            expansionPanel2.Location = new Point(0, 0);
            expansionPanel2.Name = "expansionPanel2";
            expansionPanel2.Size = new Size(584, 270);
            expansionPanel2.TabIndex = 93;
            expansionPanel2.Title1 = "Scores";
            expansionPanel2.Title2 = "";
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            materialListView1.Depth = 0;
            materialListView1.Font = new Font("Microsoft Sans Serif", 14.25F);
            materialListView1.FullRowSelect = true;
            materialListView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            materialListView1.Location = new Point(3, 55);
            materialListView1.Margin = new Padding(3, 4, 3, 4);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(500, 200);
            materialListView1.TabIndex = 2;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Criteria";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Scores";
            columnHeader2.Width = 100;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(expansionPanel2);
            panel1.Location = new Point(1135, 833);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 271);
            panel1.TabIndex = 94;
            // 
            // customComboBox2
            // 
            customComboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customComboBox2.BackColor = Color.FromArgb(26, 30, 36);
            customComboBox2.Items.AddRange(new object[] { "Earliest Pass", "Points" });
            customComboBox2.Location = new Point(337, 23);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(139, 44);
            customComboBox2.TabIndex = 95;
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
            customCard6.Dock = DockStyle.Left;
            customCard6.Location = new Point(0, 0);
            customCard6.Margin = new Padding(0);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(486, 1049);
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
            submittedContainer.Size = new Size(486, 893);
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
            customCard9.Size = new Size(486, 78);
            customCard9.TabIndex = 111;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.BackColor = Color.FromArgb(26, 30, 36);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(15, 23);
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 8, 10, 8);
            searchBox.PlaceholderText = "Search Student";
            searchBox.ScrollBars = ScrollBars.None;
            searchBox.Size = new Size(304, 44);
            searchBox.TabIndex = 110;
            searchBox.WordWrap = true;
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
            customCard8.Size = new Size(486, 78);
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
            steamGradientPanel1.Controls.Add(customCard1);
            steamGradientPanel1.Controls.Add(panel1);
            steamGradientPanel1.Controls.Add(customCard6);
            steamGradientPanel1.Controls.Add(splitContainer1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1801, 1049);
            steamGradientPanel1.TabIndex = 111;
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.FromArgb(21, 28, 38);
            customCard1.BorderColor = Color.FromArgb(42, 71, 94);
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(steamLabel2);
            customCard1.Controls.Add(steamLabel3);
            customCard1.Location = new Point(510, 0);
            customCard1.Margin = new Padding(0);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(1291, 78);
            customCard1.TabIndex = 112;
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel2.Location = new Point(136, 28);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(119, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel2.TabIndex = 72;
            steamLabel2.Text = "Angelo Bello";
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 12F);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(13, 28);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(117, 23);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 0;
            steamLabel3.Text = "Reviewing : ";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(510, 101);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(customCard2);
            splitContainer1.Panel1.Margin = new Padding(0, 0, 10, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(customCard5);
            splitContainer1.Size = new Size(1269, 726);
            splitContainer1.SplitterDistance = 889;
            splitContainer1.TabIndex = 0;
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
            customCard2.Location = new Point(0, 0);
            customCard2.Margin = new Padding(0);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(889, 726);
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
            studentCode.Font = new Font("Courier New", 9.75F);
            studentCode.ForeColor = Color.LightGray;
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IndentBackColor = Color.Transparent;
            studentCode.IsReplaceMode = false;
            studentCode.LineNumberColor = Color.LightGray;
            studentCode.Location = new Point(8, 70);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.ServiceLinesColor = Color.DimGray;
            studentCode.Size = new Size(868, 641);
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
            customCard4.Controls.Add(steamLabel6);
            customCard4.Dock = DockStyle.Top;
            customCard4.Location = new Point(0, 0);
            customCard4.Margin = new Padding(20, 3, 3, 3);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(5);
            customCard4.Size = new Size(889, 64);
            customCard4.TabIndex = 108;
            // 
            // steamLabel6
            // 
            steamLabel6.AutoSize = true;
            steamLabel6.BackColor = Color.Transparent;
            steamLabel6.Font = new Font("Geist", 8F);
            steamLabel6.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel6.Location = new Point(25, 27);
            steamLabel6.Name = "steamLabel6";
            steamLabel6.Size = new Size(129, 16);
            steamLabel6.SteamSize = SteamThings.SteamLabel.SizeOption.Tiny;
            steamLabel6.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel6.TabIndex = 1;
            steamLabel6.Text = "SUBMITTED CODE";
            // 
            // customCard5
            // 
            customCard5.BackColor = Color.FromArgb(21, 28, 38);
            customCard5.BorderColor = Color.FromArgb(42, 71, 94);
            customCard5.BorderRadius = 2;
            customCard5.BorderSize = 1;
            customCard5.Controls.Add(customCard10);
            customCard5.Controls.Add(customCard11);
            customCard5.Dock = DockStyle.Top;
            customCard5.Location = new Point(0, 0);
            customCard5.Margin = new Padding(0);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(376, 336);
            customCard5.TabIndex = 114;
            // 
            // customCard10
            // 
            customCard10.BackColor = Color.FromArgb(21, 28, 38);
            customCard10.BorderColor = Color.FromArgb(42, 71, 94);
            customCard10.BorderRadius = 2;
            customCard10.BorderSize = 1;
            customCard10.Controls.Add(steamLabel5);
            customCard10.Controls.Add(steamLabel4);
            customCard10.Dock = DockStyle.Top;
            customCard10.Location = new Point(0, 0);
            customCard10.Margin = new Padding(20, 3, 3, 3);
            customCard10.Name = "customCard10";
            customCard10.Padding = new Padding(5);
            customCard10.Size = new Size(376, 64);
            customCard10.TabIndex = 109;
            // 
            // steamLabel5
            // 
            steamLabel5.AutoSize = true;
            steamLabel5.BackColor = Color.Transparent;
            steamLabel5.Font = new Font("Geist", 12F);
            steamLabel5.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel5.Location = new Point(96, 22);
            steamLabel5.Name = "steamLabel5";
            steamLabel5.Size = new Size(32, 23);
            steamLabel5.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel5.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel5.TabIndex = 74;
            steamLabel5.Text = "85";
            // 
            // steamLabel4
            // 
            steamLabel4.AutoSize = true;
            steamLabel4.BackColor = Color.Transparent;
            steamLabel4.Font = new Font("Geist", 12F);
            steamLabel4.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel4.Location = new Point(10, 22);
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
            customCard11.Size = new Size(366, 250);
            customCard11.TabIndex = 106;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentCodeRating1.BackColor = Color.Transparent;
            studentCodeRating1.Location = new Point(10, 10);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(343, 217);
            studentCodeRating1.TabIndex = 110;
            // 
            // ProgressSubmissionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            Name = "ProgressSubmissionPage";
            Size = new Size(1801, 1049);
            expansionPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            customCard6.ResumeLayout(false);
            customCard9.ResumeLayout(false);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            steamGradientPanel1.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Label label1;
        private Label studentName;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ExpansionPanel expansionPanel2;
        private Panel panel1;
        private SteamThings.SteamComboBox customComboBox2;
        private GeneralComponents.CustomCard customCard6;
        private GeneralComponents.CustomCard submittedContainer;
        private GeneralComponents.CustomCard customCard9;
        private SteamThings.SteamTextBox searchBox;
        private GeneralComponents.CustomCard customCard8;
        private SteamThings.SteamLabel submitCount;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private GeneralComponents.CustomCard customCard1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamLabel steamLabel4;
        private SteamThings.SteamLabel steamLabel5;
        private GeneralComponents.CustomCard customCard2;
        private ProgrammingTabs.CodeEditor studentCode;
        private GeneralComponents.CustomCard customCard4;
        private SteamThings.SteamLabel steamLabel6;
        private GeneralComponents.CustomCard customCard5;
        private GeneralComponents.CustomCard customCard11;
        private ServerPageComponents.StudentCodeRating studentCodeRating1;
        private GeneralComponents.CustomCard customCard10;
        private SplitContainer splitContainer1;
    }
}
