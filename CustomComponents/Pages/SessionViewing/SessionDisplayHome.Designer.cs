namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    partial class SessionDisplayHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionDisplayHome));
            studentName = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            notifFilter = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            label4 = new Label();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            duration = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            serverName = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox3 = new PictureBox();
            timeLength = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            label3 = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox2 = new PictureBox();
            pastedCount = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            label2 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox1 = new PictureBox();
            submissionCount = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            logBox = new SmartCodeLab.CustomComponents.SteamThings.SteamLogBox();
            panel1 = new Panel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamGradientPanel1.SuspendLayout();
            customCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            customCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            customCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customCard4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentName
            // 
            studentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentName.BackColor = Color.FromArgb(26, 30, 36);
            studentName.Location = new Point(286, 12);
            studentName.Multiline = false;
            studentName.Name = "studentName";
            studentName.Padding = new Padding(10, 8, 10, 8);
            studentName.PlaceholderText = "";
            studentName.ScrollBars = ScrollBars.None;
            studentName.Size = new Size(203, 44);
            studentName.TabIndex = 32;
            studentName.WordWrap = true;
            // 
            // notifFilter
            // 
            notifFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            notifFilter.BackColor = Color.FromArgb(26, 30, 36);
            notifFilter.Items.AddRange(new object[] { "All", "Copy Paste", "Logged In", "Logged Out", "Submission", "Exceptions Encounter" });
            notifFilter.Location = new Point(528, 12);
            notifFilter.Name = "notifFilter";
            notifFilter.Padding = new Padding(1);
            notifFilter.Size = new Size(185, 44);
            notifFilter.TabIndex = 4;
            notifFilter.SelectedIndexChanged += notifFilter_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(87, 69);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 14;
            label4.Text = "Student Submitted";
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(customCard4);
            steamGradientPanel1.Controls.Add(duration);
            steamGradientPanel1.Controls.Add(serverName);
            steamGradientPanel1.Controls.Add(customCard3);
            steamGradientPanel1.Controls.Add(customCard2);
            steamGradientPanel1.Controls.Add(customCard1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1784, 941);
            steamGradientPanel1.TabIndex = 27;
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.BackColor = Color.Transparent;
            duration.Font = new Font("Geist", 16F, FontStyle.Bold);
            duration.ForeColor = Color.FromArgb(139, 149, 166);
            duration.Location = new Point(309, 66);
            duration.Name = "duration";
            duration.Size = new Size(128, 32);
            duration.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            duration.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            duration.TabIndex = 31;
            duration.Text = "Duration";
            // 
            // serverName
            // 
            serverName.AutoSize = true;
            serverName.BackColor = Color.Transparent;
            serverName.Font = new Font("Geist", 16F, FontStyle.Bold);
            serverName.ForeColor = Color.FromArgb(199, 213, 224);
            serverName.Location = new Point(309, 22);
            serverName.Name = "serverName";
            serverName.Size = new Size(183, 32);
            serverName.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            serverName.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            serverName.TabIndex = 30;
            serverName.Text = "Server Name";
            // 
            // customCard3
            // 
            customCard3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard3.BackColor = Color.FromArgb(21, 28, 38);
            customCard3.BorderColor = Color.FromArgb(42, 71, 94);
            customCard3.BorderRadius = 5;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(pictureBox3);
            customCard3.Controls.Add(timeLength);
            customCard3.Controls.Add(label3);
            customCard3.Location = new Point(1090, 453);
            customCard3.Name = "customCard3";
            customCard3.Padding = new Padding(5);
            customCard3.Size = new Size(272, 123);
            customCard3.TabIndex = 29;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 58);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // timeLength
            // 
            timeLength.AutoSize = true;
            timeLength.BackColor = Color.Transparent;
            timeLength.Font = new Font("Geist", 16F, FontStyle.Bold);
            timeLength.ForeColor = Color.FromArgb(139, 149, 166);
            timeLength.Location = new Point(105, 39);
            timeLength.Name = "timeLength";
            timeLength.Size = new Size(29, 32);
            timeLength.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            timeLength.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            timeLength.TabIndex = 0;
            timeLength.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(97, 79);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 14;
            label3.Text = "Total Session Time";
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard2.BackColor = Color.FromArgb(21, 28, 38);
            customCard2.BorderColor = Color.FromArgb(42, 71, 94);
            customCard2.BorderRadius = 5;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(pictureBox2);
            customCard2.Controls.Add(pastedCount);
            customCard2.Controls.Add(label2);
            customCard2.Location = new Point(1090, 291);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(5);
            customCard2.Size = new Size(272, 123);
            customCard2.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 58);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pastedCount
            // 
            pastedCount.AutoSize = true;
            pastedCount.BackColor = Color.Transparent;
            pastedCount.Font = new Font("Geist", 16F, FontStyle.Bold);
            pastedCount.ForeColor = Color.FromArgb(139, 149, 166);
            pastedCount.Location = new Point(100, 34);
            pastedCount.Name = "pastedCount";
            pastedCount.Size = new Size(29, 32);
            pastedCount.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            pastedCount.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            pastedCount.TabIndex = 0;
            pastedCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(92, 74);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 14;
            label2.Text = "Copy Paste Detected";
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.FromArgb(21, 28, 38);
            customCard1.BorderColor = Color.FromArgb(42, 71, 94);
            customCard1.BorderRadius = 5;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(pictureBox1);
            customCard1.Controls.Add(submissionCount);
            customCard1.Controls.Add(label4);
            customCard1.Location = new Point(1090, 123);
            customCard1.Name = "customCard1";
            customCard1.Padding = new Padding(5);
            customCard1.Size = new Size(272, 123);
            customCard1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 58);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // submissionCount
            // 
            submissionCount.AutoSize = true;
            submissionCount.BackColor = Color.Transparent;
            submissionCount.Font = new Font("Geist", 16F, FontStyle.Bold);
            submissionCount.ForeColor = Color.FromArgb(139, 149, 166);
            submissionCount.Location = new Point(95, 29);
            submissionCount.Name = "submissionCount";
            submissionCount.Size = new Size(29, 32);
            submissionCount.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            submissionCount.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            submissionCount.TabIndex = 0;
            submissionCount.Text = "0";
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.FromArgb(21, 28, 38);
            customCard4.BorderColor = Color.FromArgb(42, 71, 94);
            customCard4.BorderRadius = 5;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(panel1);
            customCard4.Controls.Add(logBox);
            customCard4.Location = new Point(309, 123);
            customCard4.Margin = new Padding(3, 3, 10, 3);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(2, 5, 2, 2);
            customCard4.Size = new Size(731, 597);
            customCard4.TabIndex = 32;
            // 
            // logBox
            // 
            logBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logBox.BackColor = Color.FromArgb(23, 26, 33);
            logBox.BorderStyle = BorderStyle.None;
            logBox.DrawMode = DrawMode.OwnerDrawVariable;
            logBox.ExternalScrollBar = null;
            logBox.ForeColor = Color.White;
            logBox.FormattingEnabled = true;
            logBox.IntegralHeight = false;
            logBox.ItemHeight = 35;
            logBox.Location = new Point(5, 85);
            logBox.Name = "logBox";
            logBox.Size = new Size(721, 507);
            logBox.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 28, 38);
            panel1.Controls.Add(notifFilter);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(steamLabel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 69);
            panel1.TabIndex = 25;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 12F);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(38, 23);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(217, 23);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 2;
            steamLabel3.Text = "EVENT LOG HISTORY";
            // 
            // SessionDisplayHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SessionDisplayHome";
            Size = new Size(1784, 941);
            steamGradientPanel1.ResumeLayout(false);
            steamGradientPanel1.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customCard4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private GeneralComponents.CustomCard customCard4;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label7;
        private SteamThings.SteamComboBox notifFilter;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private GeneralComponents.CustomCard customCard2;
        private PictureBox pictureBox2;
        private SteamThings.SteamLabel pastedCount;
        private Label label2;
        private GeneralComponents.CustomCard customCard1;
        private PictureBox pictureBox1;
        private SteamThings.SteamLabel submissionCount;
        private GeneralComponents.CustomCard customCard3;
        private PictureBox pictureBox3;
        private SteamThings.SteamLabel timeLength;
        private Label label3;
        private SteamThings.SteamLabel serverName;
        private SteamThings.SteamLabel duration;
        private SteamThings.SteamTextBox studentName;
        private SteamThings.SteamLogBox logBox;
        private Panel panel1;
        private SteamThings.SteamLabel steamLabel3;
    }
}
