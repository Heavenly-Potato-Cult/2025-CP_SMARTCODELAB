namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempServerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempServerPage));
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            status = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            codeTrack = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard11 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCodeRating1 = new StudentCodeRating();
            customCard10 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard6 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            iconsContainer = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard9 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            searchStudent = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            customCard8 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentName = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            btn_sendmessage = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            copypastedCodes = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            steamGradientPanel1.SuspendLayout();
            customCard5.SuspendLayout();
            customCard11.SuspendLayout();
            customCard10.SuspendLayout();
            customCard6.SuspendLayout();
            customCard9.SuspendLayout();
            customCard8.SuspendLayout();
            customCard1.SuspendLayout();
            customCard7.SuspendLayout();
            customCard4.SuspendLayout();
            customCard3.SuspendLayout();
            customCard2.SuspendLayout();
            SuspendLayout();
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
            studentCode.Size = new Size(1111, 534);
            studentCode.TabIndex = 15;
            studentCode.WordWrap = true;
            studentCode.Zoom = 100;
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            status.BackColor = Color.FromArgb(26, 30, 36);
            status.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            status.Location = new Point(256, 12);
            status.Name = "status";
            status.Padding = new Padding(1);
            status.Size = new Size(102, 44);
            status.TabIndex = 105;
            status.SelectedIndexChanged += status_SelectedIndexChanged_1;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            smartButton1.BackColor = Color.DeepSkyBlue;
            smartButton1.BackgroundColor = Color.DeepSkyBlue;
            smartButton1.BorderRadius = 5;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(19, 17);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(339, 44);
            smartButton1.TabIndex = 14;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // codeTrack
            // 
            codeTrack.BackColor = Color.Transparent;
            codeTrack.Dock = DockStyle.Fill;
            codeTrack.Location = new Point(20, 5);
            codeTrack.Maximum = 100;
            codeTrack.Name = "codeTrack";
            codeTrack.Size = new Size(1099, 54);
            codeTrack.TabIndex = 105;
            codeTrack.Text = "steamTrackBar1";
            codeTrack.Value = 0;
            codeTrack.ValueChanged += codeTrack_ValueChanged;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(customCard5);
            steamGradientPanel1.Controls.Add(customCard6);
            steamGradientPanel1.Controls.Add(customCard1);
            steamGradientPanel1.Controls.Add(customCard3);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1916, 964);
            steamGradientPanel1.TabIndex = 105;
            steamGradientPanel1.Paint += steamGradientPanel1_Paint;
            // 
            // customCard5
            // 
            customCard5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard5.BackColor = Color.FromArgb(21, 28, 38);
            customCard5.BorderColor = Color.FromArgb(42, 71, 94);
            customCard5.BorderRadius = 2;
            customCard5.BorderSize = 1;
            customCard5.Controls.Add(customCard11);
            customCard5.Controls.Add(customCard10);
            customCard5.Location = new Point(1569, 364);
            customCard5.Margin = new Padding(20, 3, 3, 3);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(334, 328);
            customCard5.TabIndex = 113;
            // 
            // customCard11
            // 
            customCard11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customCard11.AutoScroll = true;
            customCard11.BackColor = Color.FromArgb(18, 23, 29);
            customCard11.BorderColor = Color.FromArgb(42, 71, 94);
            customCard11.BorderRadius = 2;
            customCard11.BorderSize = 0;
            customCard11.Controls.Add(studentCodeRating1);
            customCard11.Location = new Point(5, 67);
            customCard11.Margin = new Padding(0);
            customCard11.Name = "customCard11";
            customCard11.Padding = new Padding(10, 10, 10, 5);
            customCard11.Size = new Size(324, 254);
            customCard11.TabIndex = 106;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentCodeRating1.BackColor = Color.Transparent;
            studentCodeRating1.Location = new Point(10, 10);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(304, 239);
            studentCodeRating1.TabIndex = 110;
            // 
            // customCard10
            // 
            customCard10.BackColor = Color.FromArgb(21, 28, 38);
            customCard10.BorderColor = Color.FromArgb(42, 71, 94);
            customCard10.BorderRadius = 2;
            customCard10.BorderSize = 1;
            customCard10.Controls.Add(steamLabel3);
            customCard10.Dock = DockStyle.Top;
            customCard10.Location = new Point(0, 0);
            customCard10.Margin = new Padding(20, 3, 3, 3);
            customCard10.Name = "customCard10";
            customCard10.Padding = new Padding(5);
            customCard10.Size = new Size(334, 64);
            customCard10.TabIndex = 109;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 10F);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(25, 27);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(107, 19);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 0;
            steamLabel3.Text = "LIVE SCORE";
            // 
            // customCard6
            // 
            customCard6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard6.BackColor = Color.FromArgb(21, 28, 38);
            customCard6.BorderColor = Color.FromArgb(42, 71, 94);
            customCard6.BorderRadius = 2;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(iconsContainer);
            customCard6.Controls.Add(customCard9);
            customCard6.Controls.Add(customCard8);
            customCard6.Location = new Point(35, 29);
            customCard6.Margin = new Padding(0);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(370, 668);
            customCard6.TabIndex = 109;
            // 
            // iconsContainer
            // 
            iconsContainer.AutoScroll = true;
            iconsContainer.BackColor = Color.FromArgb(21, 28, 38);
            iconsContainer.BorderColor = Color.FromArgb(42, 71, 94);
            iconsContainer.BorderRadius = 2;
            iconsContainer.BorderSize = 1;
            iconsContainer.Dock = DockStyle.Fill;
            iconsContainer.Location = new Point(0, 156);
            iconsContainer.Margin = new Padding(0);
            iconsContainer.Name = "iconsContainer";
            iconsContainer.Padding = new Padding(10, 10, 10, 2);
            iconsContainer.Size = new Size(370, 512);
            iconsContainer.TabIndex = 112;
            // 
            // customCard9
            // 
            customCard9.BackColor = Color.FromArgb(21, 28, 38);
            customCard9.BorderColor = Color.FromArgb(42, 71, 94);
            customCard9.BorderRadius = 2;
            customCard9.BorderSize = 1;
            customCard9.Controls.Add(status);
            customCard9.Controls.Add(searchStudent);
            customCard9.Dock = DockStyle.Top;
            customCard9.Location = new Point(0, 78);
            customCard9.Margin = new Padding(0);
            customCard9.Name = "customCard9";
            customCard9.Size = new Size(370, 78);
            customCard9.TabIndex = 111;
            // 
            // searchStudent
            // 
            searchStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchStudent.BackColor = Color.FromArgb(26, 30, 36);
            searchStudent.ForeColor = Color.White;
            searchStudent.Location = new Point(26, 12);
            searchStudent.Multiline = false;
            searchStudent.Name = "searchStudent";
            searchStudent.Padding = new Padding(10, 8, 10, 8);
            searchStudent.PlaceholderText = "Search Student";
            searchStudent.ScrollBars = ScrollBars.None;
            searchStudent.Size = new Size(224, 44);
            searchStudent.TabIndex = 110;
            searchStudent.WordWrap = true;
            // 
            // customCard8
            // 
            customCard8.BackColor = Color.FromArgb(21, 28, 38);
            customCard8.BorderColor = Color.FromArgb(42, 71, 94);
            customCard8.BorderRadius = 2;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(smartButton1);
            customCard8.Dock = DockStyle.Top;
            customCard8.Location = new Point(0, 0);
            customCard8.Margin = new Padding(0);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(370, 78);
            customCard8.TabIndex = 110;
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.FromArgb(23, 29, 37);
            customCard1.BorderColor = Color.FromArgb(42, 71, 94);
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(studentCode);
            customCard1.Controls.Add(customCard7);
            customCard1.Controls.Add(customCard4);
            customCard1.Location = new Point(425, 29);
            customCard1.Margin = new Padding(0);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(1124, 668);
            customCard1.TabIndex = 107;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.FromArgb(21, 28, 38);
            customCard7.BorderColor = Color.FromArgb(42, 71, 94);
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(codeTrack);
            customCard7.Dock = DockStyle.Bottom;
            customCard7.Location = new Point(0, 604);
            customCard7.Margin = new Padding(20, 3, 20, 3);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(20, 5, 5, 5);
            customCard7.Size = new Size(1124, 64);
            customCard7.TabIndex = 109;
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.FromArgb(21, 28, 38);
            customCard4.BorderColor = Color.FromArgb(42, 71, 94);
            customCard4.BorderRadius = 2;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(studentName);
            customCard4.Controls.Add(btn_sendmessage);
            customCard4.Controls.Add(steamLabel2);
            customCard4.Dock = DockStyle.Top;
            customCard4.Location = new Point(0, 0);
            customCard4.Margin = new Padding(20, 3, 3, 3);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(5);
            customCard4.Size = new Size(1124, 64);
            customCard4.TabIndex = 108;
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.BackColor = Color.Transparent;
            studentName.Font = new Font("Geist", 10F);
            studentName.ForeColor = Color.FromArgb(199, 213, 224);
            studentName.Location = new Point(150, 22);
            studentName.Name = "studentName";
            studentName.Size = new Size(54, 19);
            studentName.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            studentName.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            studentName.TabIndex = 2;
            studentName.Text = "NONE";
            studentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_sendmessage
            // 
            btn_sendmessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_sendmessage.BackColor = Color.FromArgb(17, 42, 30);
            btn_sendmessage.BackgroundColor = Color.FromArgb(17, 42, 30);
            btn_sendmessage.BorderRadius = 1;
            btn_sendmessage.FlatAppearance.BorderSize = 0;
            btn_sendmessage.FlatStyle = FlatStyle.Flat;
            btn_sendmessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sendmessage.ForeColor = Color.FromArgb(34, 197, 94);
            btn_sendmessage.Location = new Point(920, 13);
            btn_sendmessage.Margin = new Padding(2, 4, 2, 4);
            btn_sendmessage.Name = "btn_sendmessage";
            btn_sendmessage.Size = new Size(187, 37);
            btn_sendmessage.TabIndex = 67;
            btn_sendmessage.Text = "Send Message";
            btn_sendmessage.TextColor = Color.FromArgb(34, 197, 94);
            btn_sendmessage.UseVisualStyleBackColor = false;
            btn_sendmessage.Click += btn_sendmessage_Click;
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 10F);
            steamLabel2.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel2.Location = new Point(20, 22);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(124, 19);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel2.TabIndex = 1;
            steamLabel2.Text = "SPECTATING : ";
            // 
            // customCard3
            // 
            customCard3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard3.BackColor = Color.FromArgb(21, 28, 38);
            customCard3.BorderColor = Color.FromArgb(42, 71, 94);
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(customCard2);
            customCard3.Controls.Add(copypastedCodes);
            customCard3.Location = new Point(1569, 29);
            customCard3.Margin = new Padding(20, 3, 3, 3);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(334, 309);
            customCard3.TabIndex = 105;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.FromArgb(21, 28, 38);
            customCard2.BorderColor = Color.FromArgb(42, 71, 94);
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(steamLabel1);
            customCard2.Dock = DockStyle.Top;
            customCard2.Location = new Point(0, 0);
            customCard2.Margin = new Padding(20, 3, 3, 3);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(5);
            customCard2.Size = new Size(334, 64);
            customCard2.TabIndex = 109;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 10F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(20, 22);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(186, 19);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 0;
            steamLabel1.Text = "COPY-PASTE HISTORY";
            // 
            // copypastedCodes
            // 
            copypastedCodes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            copypastedCodes.AutoScroll = true;
            copypastedCodes.BackColor = Color.FromArgb(18, 23, 29);
            copypastedCodes.BorderColor = Color.FromArgb(42, 71, 94);
            copypastedCodes.BorderRadius = 2;
            copypastedCodes.BorderSize = 0;
            copypastedCodes.Location = new Point(5, 70);
            copypastedCodes.Margin = new Padding(0);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Padding = new Padding(10, 10, 10, 5);
            copypastedCodes.Size = new Size(324, 228);
            copypastedCodes.TabIndex = 106;
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(steamGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TempServerPage";
            Size = new Size(1916, 964);
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            steamGradientPanel1.ResumeLayout(false);
            customCard5.ResumeLayout(false);
            customCard11.ResumeLayout(false);
            customCard10.ResumeLayout(false);
            customCard10.PerformLayout();
            customCard6.ResumeLayout(false);
            customCard9.ResumeLayout(false);
            customCard8.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard7.ResumeLayout(false);
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Pages.ProgrammingTabs.CodeEditor studentCode;
        private GeneralComponents.StatsBar accuracy;
        private GeneralComponents.StatsBar statsBar2;
        private Label label6;
        private Label label2;
        private GeneralComponents.SmartButton smartButton1;
        private Label label7;
        private SteamThings.SteamTrackBar codeTrack;
        private SteamThings.SteamComboBox status;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private GeneralComponents.CustomCard customCard3;
        private GeneralComponents.CustomCard copypastedCodes;
        private GeneralComponents.CustomCard customCard1;
        private GeneralComponents.CustomCard customCard4;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel studentName;
        private GeneralComponents.SmartButton btn_sendmessage;
        private GeneralComponents.CustomCard customCard7;
        private GeneralComponents.CustomCard customCard6;
        private GeneralComponents.CustomCard customCard8;
        private GeneralComponents.CustomCard customCard9;
        private SteamThings.SteamTextBox searchStudent;
        private GeneralComponents.CustomCard iconsContainer;
        private SteamThings.SteamLabel steamLabel1;
        private GeneralComponents.CustomCard customCard2;
        private StudentCodeRating studentCodeRating1;
        private GeneralComponents.CustomCard customCard5;
        private GeneralComponents.CustomCard customCard10;
        private SteamThings.SteamLabel steamLabel3;
        private GeneralComponents.CustomCard customCard11;
    }
}
