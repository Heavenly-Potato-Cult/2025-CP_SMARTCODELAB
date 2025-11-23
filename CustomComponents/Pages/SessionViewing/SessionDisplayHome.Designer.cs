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
            label1 = new Label();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            panel8 = new Panel();
            notifContainer = new FlowLayoutPanel();
            notifFilter = new ComboBox();
            studentName = new CustomTextBox();
            panel_line2 = new Panel();
            panel_line = new Panel();
            label45 = new Label();
            label44 = new Label();
            serverName = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            submissionCount = new Label();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            timeLength = new Label();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pastedCount = new Label();
            duration = new Label();
            customCard7.SuspendLayout();
            panel8.SuspendLayout();
            customCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            customCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            customCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 13, 13);
            label1.Location = new Point(309, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 38);
            label1.TabIndex = 12;
            label1.Text = "Dashboard Overview";
            // 
            // customCard7
            // 
            customCard7.AutoSize = true;
            customCard7.BackColor = Color.White;
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 10;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(panel8);
            customCard7.Controls.Add(panel_line2);
            customCard7.Controls.Add(panel_line);
            customCard7.Controls.Add(label45);
            customCard7.Controls.Add(label44);
            customCard7.Location = new Point(309, 139);
            customCard7.Margin = new Padding(3, 3, 50, 3);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(5, 11, 5, 20);
            customCard7.Size = new Size(742, 787);
            customCard7.TabIndex = 19;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(notifContainer);
            panel8.Controls.Add(notifFilter);
            panel8.Controls.Add(studentName);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 53);
            panel8.Margin = new Padding(3, 20, 3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(732, 713);
            panel8.TabIndex = 24;
            // 
            // notifContainer
            // 
            notifContainer.AutoScroll = true;
            notifContainer.FlowDirection = FlowDirection.TopDown;
            notifContainer.Location = new Point(3, 88);
            notifContainer.Margin = new Padding(3, 4, 3, 4);
            notifContainer.Name = "notifContainer";
            notifContainer.Size = new Size(726, 621);
            notifContainer.TabIndex = 3;
            notifContainer.WrapContents = false;
            // 
            // notifFilter
            // 
            notifFilter.FormattingEnabled = true;
            notifFilter.Items.AddRange(new object[] { "All", "Copy Paste", "Logged In", "Logged Out", "Submission", "Exceptions Encounter" });
            notifFilter.Location = new Point(331, 20);
            notifFilter.Name = "notifFilter";
            notifFilter.Size = new Size(151, 28);
            notifFilter.TabIndex = 2;
            notifFilter.SelectedIndexChanged += notifFilter_SelectedIndexChanged;
            // 
            // studentName
            // 
            studentName.BackColor = SystemColors.Window;
            studentName.BorderColor = Color.Gainsboro;
            studentName.BorderFocusColor = Color.LightGray;
            studentName.ForeColor = Color.DimGray;
            studentName.Location = new Point(14, 13);
            studentName.Name = "studentName";
            studentName.Padding = new Padding(10, 7, 10, 7);
            studentName.PlaceHolderColor = Color.DarkGray;
            studentName.PlaceholderText = "Search Student";
            studentName.ScrollBars = ScrollBars.None;
            studentName.Size = new Size(312, 41);
            studentName.TabIndex = 1;
            studentName._TextChanged += studentName__TextChanged;
            // 
            // panel_line2
            // 
            panel_line2.BackColor = Color.DarkGray;
            panel_line2.Dock = DockStyle.Top;
            panel_line2.Location = new Point(5, 52);
            panel_line2.Margin = new Padding(3, 20, 3, 3);
            panel_line2.Name = "panel_line2";
            panel_line2.Size = new Size(732, 1);
            panel_line2.TabIndex = 24;
            // 
            // panel_line
            // 
            panel_line.BackColor = Color.White;
            panel_line.Dock = DockStyle.Top;
            panel_line.Location = new Point(5, 39);
            panel_line.Margin = new Padding(3, 20, 3, 3);
            panel_line.Name = "panel_line";
            panel_line.Size = new Size(732, 13);
            panel_line.TabIndex = 23;
            // 
            // label45
            // 
            label45.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(0, 192, 0);
            label45.Location = new Point(1153, 17);
            label45.Name = "label45";
            label45.Size = new Size(42, 25);
            label45.TabIndex = 22;
            label45.Text = "Live";
            label45.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Dock = DockStyle.Top;
            label44.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.ForeColor = Color.FromArgb(13, 13, 13);
            label44.Location = new Point(5, 11);
            label44.Margin = new Padding(0);
            label44.Name = "label44";
            label44.Padding = new Padding(10, 0, 0, 0);
            label44.Size = new Size(226, 28);
            label44.TabIndex = 12;
            label44.Text = "Activity Notifications";
            // 
            // serverName
            // 
            serverName.AutoSize = true;
            serverName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serverName.ForeColor = Color.FromArgb(13, 13, 13);
            serverName.Location = new Point(309, 53);
            serverName.Name = "serverName";
            serverName.Size = new Size(187, 38);
            serverName.TabIndex = 20;
            serverName.Text = "Server Name";
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(pictureBox2);
            customCard2.Controls.Add(label4);
            customCard2.Controls.Add(submissionCount);
            customCard2.Location = new Point(1090, 139);
            customCard2.Margin = new Padding(3, 3, 57, 3);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(272, 128);
            customCard2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 81);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(101, 67);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 14;
            label4.Text = "Student Submitted";
            // 
            // submissionCount
            // 
            submissionCount.AutoSize = true;
            submissionCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            submissionCount.ForeColor = Color.FromArgb(13, 13, 13);
            submissionCount.Location = new Point(101, 28);
            submissionCount.Name = "submissionCount";
            submissionCount.Size = new Size(33, 38);
            submissionCount.TabIndex = 12;
            submissionCount.Text = "0";
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 10;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(pictureBox4);
            customCard4.Controls.Add(label9);
            customCard4.Controls.Add(timeLength);
            customCard4.Location = new Point(1090, 551);
            customCard4.Margin = new Padding(3, 3, 57, 3);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(272, 128);
            customCard4.TabIndex = 24;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 61);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(106, 67);
            label9.Name = "label9";
            label9.Size = new Size(157, 25);
            label9.TabIndex = 14;
            label9.Text = "Total Session Time";
            // 
            // timeLength
            // 
            timeLength.AutoSize = true;
            timeLength.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            timeLength.ForeColor = Color.FromArgb(13, 13, 13);
            timeLength.Location = new Point(106, 28);
            timeLength.Name = "timeLength";
            timeLength.Size = new Size(74, 38);
            timeLength.TabIndex = 12;
            timeLength.Text = "4.2h";
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.White;
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 10;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(pictureBox3);
            customCard3.Controls.Add(label7);
            customCard3.Controls.Add(pastedCount);
            customCard3.Location = new Point(1090, 345);
            customCard3.Margin = new Padding(3, 3, 57, 3);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(272, 128);
            customCard3.TabIndex = 25;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 79);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(83, 65);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 14;
            label7.Text = "Copy Paste Detected";
            // 
            // pastedCount
            // 
            pastedCount.AutoSize = true;
            pastedCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            pastedCount.ForeColor = Color.FromArgb(13, 13, 13);
            pastedCount.Location = new Point(87, 28);
            pastedCount.Name = "pastedCount";
            pastedCount.Size = new Size(33, 38);
            pastedCount.TabIndex = 12;
            pastedCount.Text = "0";
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration.ForeColor = Color.Gray;
            duration.Location = new Point(310, 93);
            duration.Name = "duration";
            duration.Size = new Size(81, 25);
            duration.TabIndex = 26;
            duration.Text = "Duration";
            // 
            // SessionDisplayHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(duration);
            Controls.Add(customCard3);
            Controls.Add(customCard4);
            Controls.Add(customCard2);
            Controls.Add(serverName);
            Controls.Add(customCard7);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SessionDisplayHome";
            Size = new Size(1784, 941);
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            panel8.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GeneralComponents.CustomCard customCard7;
        private Panel panel8;
        private ComboBox notifFilter;
        private CustomTextBox studentName;
        private Panel panel_line2;
        private Panel panel_line;
        private Label label45;
        private Label label44;
        private Label serverName;
        private GeneralComponents.CustomCard customCard2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label submissionCount;
        private GeneralComponents.CustomCard customCard4;
        private PictureBox pictureBox4;
        private Label label9;
        private Label timeLength;
        private GeneralComponents.CustomCard customCard3;
        private PictureBox pictureBox3;
        private Label label7;
        private Label pastedCount;
        private Label duration;
        private FlowLayoutPanel notifContainer;
    }
}
