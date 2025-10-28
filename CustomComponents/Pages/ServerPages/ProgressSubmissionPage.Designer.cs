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
            customTextBox2 = new CustomTextBox();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label1 = new Label();
            label6 = new Label();
            label14 = new Label();
            label12 = new Label();
            label5 = new Label();
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
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            materialExpansionPanel3 = new MaterialSkin.Controls.MaterialExpansionPanel();
            btn_viewmore = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            customCard7.SuspendLayout();
            customCard2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            materialExpansionPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(43, 106);
            label11.Name = "label11";
            label11.Size = new Size(132, 20);
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
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(333, 147);
            customComboBox2.Margin = new Padding(3, 2, 3, 2);
            customComboBox2.MinimumSize = new Size(175, 22);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(175, 31);
            customComboBox2.TabIndex = 66;
            customComboBox2.Texts = "";
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.White;
            customTextBox2.BorderColor = Color.LightGray;
            customTextBox2.BorderFocusColor = Color.FromArgb(64, 64, 64);
            customTextBox2.BorderRadius = 2;
            customTextBox2.BorderSize = 1;
            customTextBox2.ForeColor = SystemColors.ControlText;
            customTextBox2.Location = new Point(42, 147);
            customTextBox2.Margin = new Padding(3, 2, 3, 2);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(9, 5, 9, 5);
            customTextBox2.PlaceHolderColor = Color.DarkGray;
            customTextBox2.PlaceholderText = "Search Student";
            customTextBox2.ScrollBars = ScrollBars.None;
            customTextBox2.Size = new Size(272, 32);
            customTextBox2.TabIndex = 65;
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
            customCard7.Location = new Point(42, 260);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(466, 26);
            customCard7.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 21;
            label1.Text = "No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(370, 4);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 20;
            label6.Text = "Rating";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(80, 4);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 18;
            label14.Text = "Student Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(42, 81);
            label12.Name = "label12";
            label12.Size = new Size(198, 25);
            label12.TabIndex = 63;
            label12.Text = "Student Submissions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(43, 61);
            label5.Name = "label5";
            label5.Size = new Size(479, 20);
            label5.TabIndex = 62;
            label5.Text = "Evaluate and analyze student code submissions with automated testing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(42, 28);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 61;
            label3.Text = "Code Evaluation";
            // 
            // submittedContainer
            // 
            submittedContainer.AutoScroll = true;
            submittedContainer.FlowDirection = FlowDirection.TopDown;
            submittedContainer.Location = new Point(42, 196);
            submittedContainer.Margin = new Padding(3, 2, 3, 2);
            submittedContainer.Name = "submittedContainer";
            submittedContainer.Size = new Size(466, 485);
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
            customCard2.Location = new Point(572, 28);
            customCard2.Margin = new Padding(3, 2, 3, 2);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(607, 78);
            customCard2.TabIndex = 69;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score.ForeColor = Color.Gray;
            score.Location = new Point(309, 39);
            score.Name = "score";
            score.Size = new Size(17, 20);
            score.TabIndex = 65;
            score.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Gray;
            label20.Location = new Point(406, 39);
            label20.Name = "label20";
            label20.Size = new Size(165, 20);
            label20.TabIndex = 64;
            label20.Text = "Submitted : 2025-07-09";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(247, 39);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 63;
            label18.Text = "Score :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(13, 13, 13);
            label13.Location = new Point(16, 9);
            label13.Name = "label13";
            label13.Size = new Size(178, 25);
            label13.TabIndex = 61;
            label13.Text = "Submission Details";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.Gray;
            studentName.Location = new Point(16, 39);
            studentName.Name = "studentName";
            studentName.Size = new Size(141, 20);
            studentName.TabIndex = 62;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // submitCount
            // 
            submitCount.AutoSize = true;
            submitCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitCount.ForeColor = Color.Black;
            submitCount.Location = new Point(181, 106);
            submitCount.Name = "submitCount";
            submitCount.Size = new Size(18, 20);
            submitCount.TabIndex = 71;
            submitCount.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(materialExpansionPanel1);
            flowLayoutPanel2.Controls.Add(materialExpansionPanel3);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(572, 132);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(892, 549);
            flowLayoutPanel2.TabIndex = 92;
            flowLayoutPanel2.WrapContents = false;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "";
            materialExpansionPanel1.Controls.Add(studentCode);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "";
            materialExpansionPanel1.ExpandHeight = 501;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(16, 16);
            materialExpansionPanel1.Margin = new Padding(16);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel1.Size = new Size(836, 501);
            materialExpansionPanel1.TabIndex = 93;
            materialExpansionPanel1.Title = "Student Code";
            materialExpansionPanel1.ValidationButtonText = "";
            // 
            // studentCode
            // 
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
            studentCode.AutoScrollMinSize = new Size(115, 14);
            studentCode.BackBrush = null;
            studentCode.BorderStyle = BorderStyle.FixedSingle;
            studentCode.CharHeight = 14;
            studentCode.CharWidth = 8;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Font = new Font("Courier New", 9.75F);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(27, 67);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(806, 415);
            studentCode.TabIndex = 2;
            studentCode.Text = "codeEditor1";
            studentCode.Zoom = 100;
            // 
            // materialExpansionPanel3
            // 
            materialExpansionPanel3.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel3.CancelButtonText = "";
            materialExpansionPanel3.Collapse = true;
            materialExpansionPanel3.Controls.Add(btn_viewmore);
            materialExpansionPanel3.Controls.Add(materialListView1);
            materialExpansionPanel3.Depth = 0;
            materialExpansionPanel3.Description = "";
            materialExpansionPanel3.ExpandHeight = 294;
            materialExpansionPanel3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel3.Location = new Point(16, 534);
            materialExpansionPanel3.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel3.Name = "materialExpansionPanel3";
            materialExpansionPanel3.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel3.Size = new Size(601, 48);
            materialExpansionPanel3.TabIndex = 95;
            materialExpansionPanel3.Title = "Scores";
            materialExpansionPanel3.ValidationButtonText = "";
            // 
            // btn_viewmore
            // 
            btn_viewmore.BackColor = Color.MediumSlateBlue;
            btn_viewmore.BorderRadius = 5;
            btn_viewmore.FlatAppearance.BorderSize = 0;
            btn_viewmore.FlatStyle = FlatStyle.Flat;
            btn_viewmore.ForeColor = Color.White;
            btn_viewmore.Location = new Point(50, 235);
            btn_viewmore.Name = "btn_viewmore";
            btn_viewmore.Size = new Size(283, 40);
            btn_viewmore.TabIndex = 3;
            btn_viewmore.Text = "View More";
            btn_viewmore.UseVisualStyleBackColor = false;
            btn_viewmore.Click += btn_viewmore_Click;
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
            materialListView1.Location = new Point(50, 51);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(500, 168);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(submitCount);
            Controls.Add(customCard2);
            Controls.Add(submittedContainer);
            Controls.Add(label11);
            Controls.Add(customComboBox2);
            Controls.Add(customTextBox2);
            Controls.Add(customCard7);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProgressSubmissionPage";
            Size = new Size(1476, 698);
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            materialExpansionPanel3.ResumeLayout(false);
            materialExpansionPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private GeneralComponents.CustomComboBox customComboBox2;
        private CustomTextBox customTextBox2;
        private GeneralComponents.CustomCard customCard7;
        private Label label6;
        private Label label14;
        private Label label12;
        private Label label5;
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
        private GeneralComponents.ExpansionPanel expansionPanel1;
        private GeneralComponents.ExpansionPanel expansionPanel2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private ProgrammingTabs.CodeEditor studentCode;
        private GeneralComponents.SmartButton btn_viewmore;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
    }
}
