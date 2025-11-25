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
            customCard8 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            label15 = new Label();
            customCard6 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            ipaddress = new Label();
            studentName = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            copypastedCodes = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label34 = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            status = new ComboBox();
            searchStudent = new CustomTextBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel2 = new Panel();
            iconsContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            codeTrack = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            studentCodeRating1 = new StudentCodeRating();
            panel5 = new Panel();
            customCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard6.SuspendLayout();
            customCard1.SuspendLayout();
            customCard2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // customCard8
            // 
            customCard8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard8.BackColor = Color.White;
            customCard8.BorderColor = Color.Silver;
            customCard8.BorderRadius = 10;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(studentCode);
            customCard8.Controls.Add(label15);
            customCard8.Location = new Point(3, 148);
            customCard8.MaximumSize = new Size(1031, 700);
            customCard8.MinimumSize = new Size(1031, 500);
            customCard8.Name = "customCard8";
            customCard8.Padding = new Padding(0, 0, 0, 20);
            customCard8.Size = new Size(1031, 637);
            customCard8.TabIndex = 14;
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
            studentCode.AutoScrollMinSize = new Size(2, 18);
            studentCode.BackBrush = null;
            studentCode.CharHeight = 18;
            studentCode.CharWidth = 10;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(16, 53);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(999, 573);
            studentCode.TabIndex = 15;
            studentCode.Zoom = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 13, 13);
            label15.Location = new Point(16, 23);
            label15.Name = "label15";
            label15.Size = new Size(193, 28);
            label15.TabIndex = 14;
            label15.Text = "Live Coding Viewer";
            // 
            // customCard6
            // 
            customCard6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard6.BackColor = Color.White;
            customCard6.BorderColor = Color.Silver;
            customCard6.BorderRadius = 10;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(smartButton3);
            customCard6.Controls.Add(ipaddress);
            customCard6.Controls.Add(studentName);
            customCard6.Location = new Point(3, 3);
            customCard6.MaximumSize = new Size(1034, 93);
            customCard6.MinimumSize = new Size(1034, 93);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(1034, 93);
            customCard6.TabIndex = 13;
            // 
            // smartButton3
            // 
            smartButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton3.BackColor = Color.FromArgb(0, 0, 192);
            smartButton3.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton3.BorderRadius = 10;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(799, 24);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(221, 47);
            smartButton3.TabIndex = 13;
            smartButton3.Text = "Send Message";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // ipaddress
            // 
            ipaddress.AutoSize = true;
            ipaddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipaddress.ForeColor = Color.Gray;
            ipaddress.Location = new Point(21, 49);
            ipaddress.Name = "ipaddress";
            ipaddress.Size = new Size(317, 25);
            ipaddress.TabIndex = 8;
            ipaddress.Text = "IT2024001 | LAB-PC-1 | 192.168.1.101 ";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.FromArgb(13, 13, 13);
            studentName.Location = new Point(21, 21);
            studentName.Name = "studentName";
            studentName.Size = new Size(201, 28);
            studentName.TabIndex = 11;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Silver;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(copypastedCodes);
            customCard1.Controls.Add(panel4);
            customCard1.Controls.Add(panel1);
            customCard1.Controls.Add(label34);
            customCard1.Location = new Point(1475, 60);
            customCard1.MaximumSize = new Size(376, 484);
            customCard1.MinimumSize = new Size(376, 484);
            customCard1.Name = "customCard1";
            customCard1.Padding = new Padding(5, 8, 5, 8);
            customCard1.Size = new Size(376, 484);
            customCard1.TabIndex = 13;
            // 
            // copypastedCodes
            // 
            copypastedCodes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            copypastedCodes.AutoScroll = true;
            copypastedCodes.BackColor = Color.White;
            copypastedCodes.Location = new Point(5, 48);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Padding = new Padding(5, 0, 5, 0);
            copypastedCodes.Size = new Size(366, 428);
            copypastedCodes.TabIndex = 105;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 47);
            panel4.Margin = new Padding(3, 15, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 1);
            panel4.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 36);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 11);
            panel1.TabIndex = 30;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Dock = DockStyle.Top;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.FromArgb(13, 13, 13);
            label34.Location = new Point(5, 8);
            label34.Name = "label34";
            label34.Padding = new Padding(9, 0, 0, 0);
            label34.Size = new Size(207, 28);
            label34.TabIndex = 29;
            label34.Text = "Copy-Paste Activity";
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Silver;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(status);
            customCard2.Controls.Add(searchStudent);
            customCard2.Controls.Add(smartButton1);
            customCard2.Controls.Add(panel2);
            customCard2.Controls.Add(iconsContainer);
            customCard2.Location = new Point(32, 63);
            customCard2.Margin = new Padding(3, 4, 3, 4);
            customCard2.MaximumSize = new Size(293, 800);
            customCard2.MinimumSize = new Size(293, 800);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(21, 0, 21, 29);
            customCard2.Size = new Size(293, 800);
            customCard2.TabIndex = 103;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            status.Location = new Point(188, 127);
            status.Name = "status";
            status.Size = new Size(84, 28);
            status.TabIndex = 17;
            status.SelectedIndexChanged += status_SelectedIndexChanged;
            // 
            // searchStudent
            // 
            searchStudent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchStudent.BackColor = SystemColors.Window;
            searchStudent.BorderColor = Color.Silver;
            searchStudent.BorderFocusColor = Color.Black;
            searchStudent.ForeColor = Color.DimGray;
            searchStudent.Location = new Point(21, 110);
            searchStudent.Margin = new Padding(3, 4, 3, 4);
            searchStudent.Name = "searchStudent";
            searchStudent.Padding = new Padding(11, 9, 11, 9);
            searchStudent.PlaceHolderColor = Color.DarkGray;
            searchStudent.PlaceholderText = "Search Student";
            searchStudent.ScrollBars = ScrollBars.None;
            searchStudent.Size = new Size(162, 45);
            searchStudent.TabIndex = 16;
            searchStudent._TextChanged += customTextBox1__TextChanged;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            smartButton1.BackColor = Color.FromArgb(0, 0, 192);
            smartButton1.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(21, 21);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(248, 65);
            smartButton1.TabIndex = 14;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(21, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 1);
            panel2.TabIndex = 15;
            // 
            // iconsContainer
            // 
            iconsContainer.AutoScroll = true;
            iconsContainer.Dock = DockStyle.Bottom;
            iconsContainer.FlowDirection = FlowDirection.TopDown;
            iconsContainer.Location = new Point(21, 163);
            iconsContainer.Margin = new Padding(3, 4, 3, 4);
            iconsContainer.Name = "iconsContainer";
            iconsContainer.Size = new Size(251, 608);
            iconsContainer.TabIndex = 12;
            iconsContainer.TabStop = true;
            iconsContainer.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(codeTrack);
            panel3.Controls.Add(customCard6);
            panel3.Controls.Add(customCard8);
            panel3.Location = new Point(377, 60);
            panel3.MaximumSize = new Size(1041, 800);
            panel3.MinimumSize = new Size(1041, 800);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 800);
            panel3.TabIndex = 101;
            // 
            // codeTrack
            // 
            codeTrack.BackColor = Color.Transparent;
            codeTrack.Location = new Point(3, 113);
            codeTrack.Maximum = 100;
            codeTrack.Name = "codeTrack";
            codeTrack.Size = new Size(1020, 29);
            codeTrack.TabIndex = 105;
            codeTrack.Text = "steamTrackBar1";
            codeTrack.Value = 0;
            codeTrack.ValueChanged += codeTrack_ValueChanged;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.BackColor = Color.White;
            studentCodeRating1.Location = new Point(1475, 590);
            studentCodeRating1.MaximumSize = new Size(376, 237);
            studentCodeRating1.MinimumSize = new Size(376, 237);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(376, 237);
            studentCodeRating1.TabIndex = 104;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(customCard2);
            panel5.Controls.Add(studentCodeRating1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(customCard1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1916, 964);
            panel5.TabIndex = 105;
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TempServerPage";
            Size = new Size(1916, 964);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            customCard2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CustomCard customCard8;
        private Label label15;
        private GeneralComponents.CustomCard customCard6;
        private GeneralComponents.SmartButton smartButton3;
        private Label ipaddress;
        private Label studentName;
        private GeneralComponents.CustomCard customCard1;
        private Pages.ProgrammingTabs.CodeEditor studentCode;
        private GeneralComponents.CustomCard customCard2;
        private FlowLayoutPanel iconsContainer;
        private GeneralComponents.StatsBar accuracy;
        private Label label1;
        private GeneralComponents.StatsBar statsBar2;
        private Label label6;
        private Label label2;
        private GeneralComponents.SmartButton smartButton1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label label34;
        private Panel panel4;
        private StudentCodeRating studentCodeRating1;
        private Panel panel5;
        private CustomTextBox searchStudent;
        private Panel copypastedCodes;
        private System.Windows.Forms.ComboBox status;
        private SteamThings.SteamTrackBar codeTrack;
    }
}
