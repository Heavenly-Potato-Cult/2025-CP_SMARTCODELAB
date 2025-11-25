namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class ExerciseCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseCard));
            smartButton9 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamCard21 = new SmartCodeLab.CustomComponents.SteamThings.SteamCard2();
            tableLayoutPanel1 = new TableLayoutPanel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            dateModified = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            testCounts = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            subject = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            btn_editcard = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            lbl_ExerciseTitle = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamCard21.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // smartButton9
            // 
            smartButton9.Anchor = AnchorStyles.None;
            smartButton9.BackColor = Color.FromArgb(239, 67, 67);
            smartButton9.BackgroundColor = Color.FromArgb(239, 67, 67);
            smartButton9.BorderRadius = 2;
            smartButton9.FlatAppearance.BorderSize = 0;
            smartButton9.FlatStyle = FlatStyle.Flat;
            smartButton9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton9.ForeColor = Color.DimGray;
            smartButton9.Image = (Image)resources.GetObject("smartButton9.Image");
            smartButton9.Location = new Point(312, 203);
            smartButton9.Margin = new Padding(3, 4, 3, 4);
            smartButton9.Name = "smartButton9";
            smartButton9.Size = new Size(53, 43);
            smartButton9.TabIndex = 62;
            smartButton9.TextColor = Color.DimGray;
            smartButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton9.UseVisualStyleBackColor = false;
            // 
            // steamCard21
            // 
            steamCard21.BackColor = Color.Transparent;
            steamCard21.Controls.Add(tableLayoutPanel1);
            steamCard21.Controls.Add(btn_editcard);
            steamCard21.Controls.Add(lbl_ExerciseTitle);
            steamCard21.Controls.Add(smartButton9);
            steamCard21.Dock = DockStyle.Fill;
            steamCard21.Location = new Point(0, 0);
            steamCard21.Margin = new Padding(3, 3, 10, 3);
            steamCard21.Name = "steamCard21";
            steamCard21.Padding = new Padding(15);
            steamCard21.Size = new Size(397, 271);
            steamCard21.TabIndex = 67;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(steamLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(steamLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dateModified, 1, 2);
            tableLayoutPanel1.Controls.Add(steamLabel3, 0, 2);
            tableLayoutPanel1.Controls.Add(testCounts, 1, 1);
            tableLayoutPanel1.Controls.Add(subject, 1, 0);
            tableLayoutPanel1.Location = new Point(32, 96);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(333, 79);
            tableLayoutPanel1.TabIndex = 75;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 10F);
            steamLabel1.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel1.Location = new Point(3, 0);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(73, 19);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel1.TabIndex = 68;
            steamLabel1.Text = "Subject :";
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 10F);
            steamLabel2.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel2.Location = new Point(3, 26);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(102, 19);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel2.TabIndex = 69;
            steamLabel2.Text = "Total Cases :";
            // 
            // dateModified
            // 
            dateModified.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateModified.AutoSize = true;
            dateModified.BackColor = Color.Transparent;
            dateModified.Font = new Font("Geist", 10F);
            dateModified.ForeColor = Color.FromArgb(199, 213, 224);
            dateModified.Location = new Point(312, 52);
            dateModified.Name = "dateModified";
            dateModified.Size = new Size(18, 19);
            dateModified.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            dateModified.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            dateModified.TabIndex = 73;
            dateModified.Text = "2";
            dateModified.TextAlign = ContentAlignment.MiddleRight;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 10F);
            steamLabel3.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel3.Location = new Point(3, 52);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(81, 19);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel3.TabIndex = 70;
            steamLabel3.Text = "Modified :";
            // 
            // testCounts
            // 
            testCounts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            testCounts.AutoSize = true;
            testCounts.BackColor = Color.Transparent;
            testCounts.Font = new Font("Geist", 10F);
            testCounts.ForeColor = Color.FromArgb(199, 213, 224);
            testCounts.Location = new Point(312, 26);
            testCounts.Name = "testCounts";
            testCounts.Size = new Size(18, 19);
            testCounts.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            testCounts.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            testCounts.TabIndex = 72;
            testCounts.Text = "5";
            testCounts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subject
            // 
            subject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subject.AutoSize = true;
            subject.BackColor = Color.Transparent;
            subject.Font = new Font("Geist", 10F);
            subject.ForeColor = Color.FromArgb(199, 213, 224);
            subject.Location = new Point(286, 0);
            subject.Name = "subject";
            subject.Size = new Size(44, 19);
            subject.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            subject.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            subject.TabIndex = 71;
            subject.Text = "OOP";
            subject.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_editcard
            // 
            btn_editcard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editcard.BackColor = Color.FromArgb(42, 71, 94);
            btn_editcard.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_editcard.BorderRadius = 1;
            btn_editcard.FlatAppearance.BorderSize = 0;
            btn_editcard.FlatStyle = FlatStyle.Flat;
            btn_editcard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editcard.ForeColor = Color.FromArgb(199, 213, 224);
            btn_editcard.Location = new Point(32, 204);
            btn_editcard.Margin = new Padding(2, 4, 2, 4);
            btn_editcard.Name = "btn_editcard";
            btn_editcard.Size = new Size(237, 43);
            btn_editcard.TabIndex = 74;
            btn_editcard.Text = "Edit";
            btn_editcard.TextColor = Color.FromArgb(199, 213, 224);
            btn_editcard.UseVisualStyleBackColor = false;
            btn_editcard.Click += btn_editcard_Click;
            // 
            // lbl_ExerciseTitle
            // 
            lbl_ExerciseTitle.AutoSize = true;
            lbl_ExerciseTitle.BackColor = Color.Transparent;
            lbl_ExerciseTitle.Font = new Font("Geist", 16F, FontStyle.Bold);
            lbl_ExerciseTitle.ForeColor = Color.FromArgb(199, 213, 224);
            lbl_ExerciseTitle.Location = new Point(32, 30);
            lbl_ExerciseTitle.Name = "lbl_ExerciseTitle";
            lbl_ExerciseTitle.Size = new Size(168, 32);
            lbl_ExerciseTitle.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            lbl_ExerciseTitle.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            lbl_ExerciseTitle.TabIndex = 67;
            lbl_ExerciseTitle.Text = "Hello World";
            // 
            // ExerciseCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(steamCard21);
            Name = "ExerciseCard";
            Size = new Size(397, 271);
            steamCard21.ResumeLayout(false);
            steamCard21.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GeneralComponents.SmartButton smartButton9;
        private SteamThings.SteamCard2 steamCard21;
        private SteamThings.SteamLabel lbl_ExerciseTitle;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamLabel dateModified;
        private SteamThings.SteamLabel testCounts;
        private SteamThings.SteamLabel subject;
        private GeneralComponents.SmartButton btn_editcard;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
