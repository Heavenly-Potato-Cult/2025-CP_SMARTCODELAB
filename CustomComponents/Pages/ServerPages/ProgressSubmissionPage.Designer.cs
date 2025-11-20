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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Accurary", "50" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Readbility", "20" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Efficiency", "30" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Complexity", "20" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Total", "100" }, -1);
            label11 = new Label();
            customComboBox2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            searchBox = new CustomTextBox();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label1 = new Label();
            label6 = new Label();
            label14 = new Label();
            label12 = new Label();
            label3 = new Label();
            submittedContainer = new FlowLayoutPanel();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            score = new Label();
            label20 = new Label();
            label18 = new Label();
            label13 = new Label();
            studentName = new Label();
            submitCount = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            expansionPanel1 = new ExpansionPanel();
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            expansionPanel2 = new ExpansionPanel();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            customCard7.SuspendLayout();
            customCard2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            expansionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            expansionPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(294, 187);
            label11.Name = "label11";
            label11.Size = new Size(161, 25);
            label11.TabIndex = 67;
            label11.Text = "Total submissions :";
            // 
            // customComboBox2
            // 
            customComboBox2.BackColor = Color.White;
            customComboBox2.BorderColor = Color.LightGray;
            customComboBox2.BorderSize = 1;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox2.Font = new Font("Segoe UI", 10F);
            customComboBox2.ForeColor = Color.DimGray;
            customComboBox2.IconColor = Color.Gray;
            customComboBox2.Items.AddRange(new object[] { "Earliest Pass", "Points" });
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(624, 303);
            customComboBox2.MinimumSize = new Size(200, 29);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(200, 41);
            customComboBox2.TabIndex = 66;
            customComboBox2.Texts = "";
            customComboBox2.OnSelectedIndexChanged += customComboBox2_OnSelectedIndexChanged;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.White;
            searchBox.BorderColor = Color.LightGray;
            searchBox.BorderFocusColor = Color.FromArgb(64, 64, 64);
            searchBox.BorderRadius = 2;
            searchBox.BorderSize = 1;
            searchBox.ForeColor = SystemColors.ControlText;
            searchBox.Location = new Point(291, 303);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 7, 10, 7);
            searchBox.PlaceHolderColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search Student";
            searchBox.ScrollBars = ScrollBars.None;
            searchBox.Size = new Size(311, 41);
            searchBox.TabIndex = 65;
            searchBox._TextChanged += searchBox__TextChanged;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.Gainsboro;
            customCard7.BorderColor = Color.Silver;
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(label1);
            customCard7.Controls.Add(label6);
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(291, 367);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(533, 35);
            customCard7.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 21;
            label1.Text = "No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(423, 5);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 20;
            label6.Text = "Rating";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(91, 5);
            label14.Name = "label14";
            label14.Size = new Size(125, 25);
            label14.TabIndex = 18;
            label14.Text = "Student Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(293, 153);
            label12.Name = "label12";
            label12.Size = new Size(238, 31);
            label12.TabIndex = 63;
            label12.Text = "Student Submissions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(291, 43);
            label3.Name = "label3";
            label3.Size = new Size(229, 38);
            label3.TabIndex = 61;
            label3.Text = "Code Evaluation";
            // 
            // submittedContainer
            // 
            submittedContainer.AutoScroll = true;
            submittedContainer.FlowDirection = FlowDirection.TopDown;
            submittedContainer.Location = new Point(291, 401);
            submittedContainer.Name = "submittedContainer";
            submittedContainer.Size = new Size(533, 547);
            submittedContainer.TabIndex = 68;
            submittedContainer.WrapContents = false;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 0;
            customCard2.Controls.Add(score);
            customCard2.Controls.Add(label20);
            customCard2.Controls.Add(label18);
            customCard2.Controls.Add(label13);
            customCard2.Controls.Add(studentName);
            customCard2.Location = new Point(933, 141);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(694, 104);
            customCard2.TabIndex = 69;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score.ForeColor = Color.Gray;
            score.Location = new Point(353, 52);
            score.Name = "score";
            score.Size = new Size(22, 25);
            score.TabIndex = 65;
            score.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Gray;
            label20.Location = new Point(464, 52);
            label20.Name = "label20";
            label20.Size = new Size(203, 25);
            label20.TabIndex = 64;
            label20.Text = "Submitted : 2025-07-09";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(282, 52);
            label18.Name = "label18";
            label18.Size = new Size(65, 25);
            label18.TabIndex = 63;
            label18.Text = "Score :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(13, 13, 13);
            label13.Location = new Point(18, 12);
            label13.Name = "label13";
            label13.Size = new Size(218, 31);
            label13.TabIndex = 61;
            label13.Text = "Submission Details";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.Gray;
            studentName.Location = new Point(18, 52);
            studentName.Name = "studentName";
            studentName.Size = new Size(170, 25);
            studentName.TabIndex = 62;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // submitCount
            // 
            submitCount.AutoSize = true;
            submitCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitCount.ForeColor = Color.Black;
            submitCount.Location = new Point(451, 187);
            submitCount.Name = "submitCount";
            submitCount.Size = new Size(22, 25);
            submitCount.TabIndex = 71;
            submitCount.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(expansionPanel1);
            flowLayoutPanel2.Controls.Add(expansionPanel2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(933, 280);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(694, 732);
            flowLayoutPanel2.TabIndex = 92;
            flowLayoutPanel2.WrapContents = false;
            // 
            // expansionPanel1
            // 
            expansionPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            expansionPanel1.BackColor = Color.Gainsboro;
            expansionPanel1.Controls.Add(studentCode);
            expansionPanel1.HeaderColor = Color.White;
            expansionPanel1.IconText = "v";
            expansionPanel1.Location = new Point(3, 3);
            expansionPanel1.Name = "expansionPanel1";
            expansionPanel1.Size = new Size(682, 261);
            expansionPanel1.TabIndex = 93;
            expansionPanel1.Title1 = "Student Code";
            expansionPanel1.Title2 = "";
            // 
            // studentCode
            // 
            studentCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            studentCode.AutoScrollMinSize = new Size(141, 18);
            studentCode.BackBrush = null;
            studentCode.BorderStyle = BorderStyle.FixedSingle;
            studentCode.CharHeight = 18;
            studentCode.CharWidth = 10;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(15, 63);
            studentCode.Margin = new Padding(3, 4, 3, 4);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(655, 182);
            studentCode.TabIndex = 2;
            studentCode.Text = "codeEditor1";
            studentCode.Zoom = 100;
            // 
            // expansionPanel2
            // 
            expansionPanel2.BackColor = Color.Gainsboro;
            expansionPanel2.Controls.Add(materialListView1);
            expansionPanel2.HeaderColor = Color.White;
            expansionPanel2.IconText = "v";
            expansionPanel2.Location = new Point(3, 270);
            expansionPanel2.Name = "expansionPanel2";
            expansionPanel2.Size = new Size(682, 284);
            expansionPanel2.TabIndex = 93;
            expansionPanel2.Title1 = "Scores";
            expansionPanel2.Title2 = "";
            // 
            // materialListView1
            // 
            materialListView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            materialListView1.Depth = 0;
            materialListView1.Font = new Font("Microsoft Sans Serif", 14.25F);
            materialListView1.FullRowSelect = true;
            materialListView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            materialListView1.Location = new Point(104, 64);
            materialListView1.Margin = new Padding(3, 4, 3, 4);
            materialListView1.MinimumSize = new Size(229, 133);
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
            // ProgressSubmissionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(submitCount);
            Controls.Add(customCard2);
            Controls.Add(submittedContainer);
            Controls.Add(label11);
            Controls.Add(customComboBox2);
            Controls.Add(searchBox);
            Controls.Add(customCard7);
            Controls.Add(label12);
            Controls.Add(label3);
            Name = "ProgressSubmissionPage";
            Size = new Size(1801, 1049);
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            expansionPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            expansionPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private GeneralComponents.CustomComboBox customComboBox2;
        private CustomTextBox searchBox;
        private GeneralComponents.CustomCard customCard7;
        private Label label6;
        private Label label14;
        private Label label12;
        private Label label3;
        private FlowLayoutPanel submittedContainer;
        private GeneralComponents.CustomCard customCard2;
        private Label label20;
        private Label label18;
        private Label label13;
        private Label studentName;
        private Label submitCount;
        private Label label1;
        private Label score;
        private FlowLayoutPanel flowLayoutPanel2;
        private ProgrammingTabs.CodeEditor studentCode;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ExpansionPanel expansionPanel1;
        private ExpansionPanel expansionPanel2;
    }
}
