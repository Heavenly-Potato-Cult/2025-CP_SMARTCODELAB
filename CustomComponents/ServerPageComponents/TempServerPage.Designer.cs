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
            copypastedCodes = new FlowLayoutPanel();
            panel4 = new Panel();
            panel1 = new Panel();
            label34 = new Label();
            codeTrack = new TrackBar();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel2 = new Panel();
            label7 = new Label();
            iconsContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            studentCodeRating1 = new StudentCodeRating();
            panel5 = new Panel();
            customCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard6.SuspendLayout();
            customCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).BeginInit();
            customCard2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // customCard8
            // 
            customCard8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard8.BackColor = Color.WhiteSmoke;
            customCard8.BorderColor = Color.Gray;
            customCard8.BorderRadius = 10;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(studentCode);
            customCard8.Controls.Add(label15);
            customCard8.Location = new Point(3, 117);
            customCard8.Margin = new Padding(3, 2, 3, 2);
            customCard8.MinimumSize = new Size(514, 281);
            customCard8.Name = "customCard8";
            customCard8.Padding = new Padding(0, 0, 0, 15);
            customCard8.Size = new Size(788, 498);
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
            studentCode.AutoScrollMinSize = new Size(2, 14);
            studentCode.BackBrush = null;
            studentCode.CharHeight = 14;
            studentCode.CharWidth = 8;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Font = new Font("Courier New", 9.75F);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(14, 40);
            studentCode.Margin = new Padding(3, 2, 3, 2);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(771, 441);
            studentCode.TabIndex = 15;
            studentCode.Zoom = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 13, 13);
            label15.Location = new Point(14, 17);
            label15.Name = "label15";
            label15.Size = new Size(157, 21);
            label15.TabIndex = 14;
            label15.Text = "Live Coding Viewer";
            // 
            // customCard6
            // 
            customCard6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard6.BackColor = Color.White;
            customCard6.BorderColor = Color.Gray;
            customCard6.BorderRadius = 10;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(smartButton3);
            customCard6.Controls.Add(ipaddress);
            customCard6.Controls.Add(studentName);
            customCard6.Location = new Point(3, 9);
            customCard6.Margin = new Padding(3, 2, 3, 2);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(791, 55);
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
            smartButton3.Location = new Point(642, 4);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(146, 49);
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
            ipaddress.Location = new Point(18, 29);
            ipaddress.Name = "ipaddress";
            ipaddress.Size = new Size(257, 20);
            ipaddress.TabIndex = 8;
            ipaddress.Text = "IT2024001 | LAB-PC-1 | 192.168.1.101 ";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.FromArgb(13, 13, 13);
            studentName.Location = new Point(24, 5);
            studentName.Name = "studentName";
            studentName.Size = new Size(165, 21);
            studentName.TabIndex = 11;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(copypastedCodes);
            customCard1.Controls.Add(panel4);
            customCard1.Controls.Add(panel1);
            customCard1.Controls.Add(label34);
            customCard1.Location = new Point(1121, 18);
            customCard1.Margin = new Padding(3, 2, 3, 2);
            customCard1.Name = "customCard1";
            customCard1.Padding = new Padding(4, 6, 4, 6);
            customCard1.Size = new Size(329, 332);
            customCard1.TabIndex = 13;
            // 
            // copypastedCodes
            // 
            copypastedCodes.AutoScroll = true;
            copypastedCodes.Dock = DockStyle.Top;
            copypastedCodes.FlowDirection = FlowDirection.TopDown;
            copypastedCodes.Location = new Point(4, 36);
            copypastedCodes.Margin = new Padding(3, 2, 3, 2);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Size = new Size(321, 293);
            copypastedCodes.TabIndex = 13;
            copypastedCodes.WrapContents = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(4, 35);
            panel4.Margin = new Padding(3, 11, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 1);
            panel4.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(4, 27);
            panel1.Margin = new Padding(3, 11, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 8);
            panel1.TabIndex = 30;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Dock = DockStyle.Top;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.FromArgb(13, 13, 13);
            label34.Location = new Point(4, 6);
            label34.Name = "label34";
            label34.Padding = new Padding(8, 0, 0, 0);
            label34.Size = new Size(167, 21);
            label34.TabIndex = 29;
            label34.Text = "Copy-Paste Activity";
            // 
            // codeTrack
            // 
            codeTrack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            codeTrack.Location = new Point(3, 68);
            codeTrack.Margin = new Padding(3, 2, 3, 2);
            codeTrack.Maximum = 0;
            codeTrack.Name = "codeTrack";
            codeTrack.Size = new Size(788, 45);
            codeTrack.TabIndex = 100;
            codeTrack.Scroll += codeTrack_Scroll;
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(smartButton1);
            customCard2.Controls.Add(panel2);
            customCard2.Controls.Add(label7);
            customCard2.Controls.Add(iconsContainer);
            customCard2.Location = new Point(3, 25);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(18, 0, 18, 22);
            customCard2.Size = new Size(309, 609);
            customCard2.TabIndex = 103;
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
            smartButton1.Location = new Point(18, 40);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(274, 29);
            smartButton1.TabIndex = 14;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(18, 79);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 1);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(13, 13, 13);
            label7.Location = new Point(32, 13);
            label7.Name = "label7";
            label7.Size = new Size(104, 30);
            label7.TabIndex = 11;
            label7.Text = "Students";
            // 
            // iconsContainer
            // 
            iconsContainer.AutoScroll = true;
            iconsContainer.Dock = DockStyle.Bottom;
            iconsContainer.FlowDirection = FlowDirection.TopDown;
            iconsContainer.Location = new Point(18, 80);
            iconsContainer.Name = "iconsContainer";
            iconsContainer.Size = new Size(273, 507);
            iconsContainer.TabIndex = 12;
            iconsContainer.TabStop = true;
            iconsContainer.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(customCard6);
            panel3.Controls.Add(customCard8);
            panel3.Controls.Add(codeTrack);
            panel3.Location = new Point(318, 18);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 617);
            panel3.TabIndex = 101;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.Location = new Point(1121, 368);
            studentCodeRating1.Margin = new Padding(3, 2, 3, 2);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(329, 171);
            studentCodeRating1.TabIndex = 104;
            // 
            // panel5
            // 
            panel5.Controls.Add(customCard2);
            panel5.Controls.Add(studentCodeRating1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(customCard1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1462, 637);
            panel5.TabIndex = 105;
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel5);
            Name = "TempServerPage";
            Size = new Size(1468, 643);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).EndInit();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TrackBar codeTrack;
        private FlowLayoutPanel copypastedCodes;
        private GeneralComponents.CustomCard customCard2;
        private FlowLayoutPanel iconsContainer;
        private GeneralComponents.StatsBar accuracy;
        private Label label1;
        private GeneralComponents.StatsBar statsBar2;
        private Label label6;
        private GeneralComponents.StatsBar readability;
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
    }
}
