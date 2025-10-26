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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "1", "2" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "1", "1" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "5", "5", "5" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "\"Hello World\"", "\"Hello World\"", "\"Hillo\"" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Readability", "15" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Efficiency", "20" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Complexity", "30" }, -1);
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
            studentCode = new TextBox();
            submitCount = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialExpansionPanel3 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            materialExpansionPanel4 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialListView2 = new MaterialSkin.Controls.MaterialListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            customCard7.SuspendLayout();
            customCard2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            materialExpansionPanel3.SuspendLayout();
            materialExpansionPanel4.SuspendLayout();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(42, 162);
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
            customComboBox2.Location = new Point(333, 199);
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
            customTextBox2.Location = new Point(42, 199);
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
            label12.Location = new Point(42, 138);
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
            submittedContainer.Location = new Point(42, 285);
            submittedContainer.Margin = new Padding(3, 2, 3, 2);
            submittedContainer.Name = "submittedContainer";
            submittedContainer.Size = new Size(466, 420);
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
            customCard2.Location = new Point(559, 138);
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
            // studentCode
            // 
            studentCode.Location = new Point(20, 66);
            studentCode.Margin = new Padding(3, 2, 3, 2);
            studentCode.Multiline = true;
            studentCode.Name = "studentCode";
            studentCode.ReadOnly = true;
            studentCode.Size = new Size(548, 243);
            studentCode.TabIndex = 67;
            // 
            // submitCount
            // 
            submitCount.AutoSize = true;
            submitCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitCount.ForeColor = Color.Black;
            submitCount.Location = new Point(188, 162);
            submitCount.Name = "submitCount";
            submitCount.Size = new Size(18, 20);
            submitCount.TabIndex = 71;
            submitCount.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(materialExpansionPanel1);
            flowLayoutPanel2.Controls.Add(materialExpansionPanel3);
            flowLayoutPanel2.Controls.Add(materialExpansionPanel4);
            flowLayoutPanel2.Controls.Add(customCard1);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(546, 244);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(620, 873);
            flowLayoutPanel2.TabIndex = 92;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "Close";
            materialExpansionPanel1.Collapse = true;
            materialExpansionPanel1.Controls.Add(studentCode);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "";
            materialExpansionPanel1.ExpandHeight = 387;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(16, 1);
            materialExpansionPanel1.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel1.Size = new Size(584, 48);
            materialExpansionPanel1.TabIndex = 66;
            materialExpansionPanel1.Title = "Student Code";
            materialExpansionPanel1.ValidationButtonText = "";
            // 
            // materialExpansionPanel3
            // 
            materialExpansionPanel3.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel3.CancelButtonText = "Close";
            materialExpansionPanel3.Collapse = true;
            materialExpansionPanel3.Controls.Add(materialListView1);
            materialExpansionPanel3.Depth = 0;
            materialExpansionPanel3.Description = "";
            materialExpansionPanel3.ExpandHeight = 292;
            materialExpansionPanel3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel3.Location = new Point(16, 50);
            materialExpansionPanel3.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel3.Name = "materialExpansionPanel3";
            materialExpansionPanel3.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel3.Size = new Size(584, 48);
            materialExpansionPanel3.TabIndex = 92;
            materialExpansionPanel3.Title = "Test Case Results";
            materialExpansionPanel3.ValidationButtonText = "";
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            materialListView1.Location = new Point(7, 66);
            materialListView1.Margin = new Padding(3, 2, 3, 2);
            materialListView1.MinimumSize = new Size(175, 75);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(550, 108);
            materialListView1.TabIndex = 3;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Input";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Expected Ouput";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Actual Output";
            columnHeader3.Width = 150;
            // 
            // materialExpansionPanel4
            // 
            materialExpansionPanel4.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel4.CancelButtonText = "Close";
            materialExpansionPanel4.Collapse = true;
            materialExpansionPanel4.Controls.Add(materialListView2);
            materialExpansionPanel4.Depth = 0;
            materialExpansionPanel4.Description = "";
            materialExpansionPanel4.ExpandHeight = 292;
            materialExpansionPanel4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel4.Location = new Point(16, 99);
            materialExpansionPanel4.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel4.Name = "materialExpansionPanel4";
            materialExpansionPanel4.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel4.Size = new Size(584, 48);
            materialExpansionPanel4.TabIndex = 93;
            materialExpansionPanel4.Title = "Score Results";
            materialExpansionPanel4.ValidationButtonText = "";
            // 
            // materialListView2
            // 
            materialListView2.AutoSizeTable = true;
            materialListView2.BackColor = Color.FromArgb(255, 255, 255);
            materialListView2.BorderStyle = BorderStyle.None;
            materialListView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            materialListView2.Depth = 0;
            materialListView2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialListView2.FullRowSelect = true;
            materialListView2.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7 });
            materialListView2.Location = new Point(13, 81);
            materialListView2.Margin = new Padding(3, 2, 3, 2);
            materialListView2.MinimumSize = new Size(175, 75);
            materialListView2.MouseLocation = new Point(-1, -1);
            materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            materialListView2.Name = "materialListView2";
            materialListView2.OwnerDraw = true;
            materialListView2.Scrollable = false;
            materialListView2.Size = new Size(500, 112);
            materialListView2.TabIndex = 19;
            materialListView2.UseCompatibleStateImageBehavior = false;
            materialListView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Criteria";
            columnHeader4.Width = 400;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Scores";
            columnHeader5.Width = 100;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 5;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(label2);
            customCard1.Controls.Add(label4);
            customCard1.Controls.Add(label7);
            customCard1.Location = new Point(16, 163);
            customCard1.Margin = new Padding(16);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(584, 73);
            customCard1.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 13, 13);
            label2.Location = new Point(444, 25);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 66;
            label2.Text = "100/100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(16, 38);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 18;
            label4.Text = "Based on test case execution";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(13, 13, 13);
            label7.Location = new Point(16, 16);
            label7.Name = "label7";
            label7.Size = new Size(175, 21);
            label7.TabIndex = 65;
            label7.Text = "Auto-Generated Score";
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
            Size = new Size(1192, 1416);
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            materialExpansionPanel3.ResumeLayout(false);
            materialExpansionPanel3.PerformLayout();
            materialExpansionPanel4.ResumeLayout(false);
            materialExpansionPanel4.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
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
        private TextBox studentCode;
        private Label submitCount;
        private Label label1;
        private Label score;
        private FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel4;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GeneralComponents.CustomCard customCard1;
        private Label label2;
        private Label label4;
        private Label label7;
    }
}
