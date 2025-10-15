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
            customCard12 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label20 = new Label();
            codeTrack = new TrackBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            studentCodeRating1 = new StudentCodeRating();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            panel2 = new Panel();
            label7 = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            iconsContainer = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            customCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard6.SuspendLayout();
            customCard1.SuspendLayout();
            customCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            customCard2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customCard8
            // 
            customCard8.BackColor = Color.WhiteSmoke;
            customCard8.BorderColor = Color.Gray;
            customCard8.BorderRadius = 10;
            customCard8.BorderSize = 1;
            customCard8.Controls.Add(studentCode);
            customCard8.Controls.Add(label15);
            customCard8.Location = new Point(3, 153);
            customCard8.Margin = new Padding(3, 2, 3, 2);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(792, 375);
            customCard8.TabIndex = 14;
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
            studentCode.AutoScrollMinSize = new Size(27, 14);
            studentCode.BackBrush = null;
            studentCode.CharHeight = 14;
            studentCode.CharWidth = 8;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(24, 40);
            studentCode.Margin = new Padding(3, 2, 3, 2);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(750, 333);
            studentCode.TabIndex = 15;
            studentCode.Zoom = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 13, 13);
            label15.Location = new Point(24, 10);
            label15.Name = "label15";
            label15.Size = new Size(157, 21);
            label15.TabIndex = 14;
            label15.Text = "Live Coding Viewer";
            // 
            // customCard6
            // 
            customCard6.BackColor = Color.White;
            customCard6.BorderColor = Color.Gray;
            customCard6.BorderRadius = 10;
            customCard6.BorderSize = 1;
            customCard6.Controls.Add(smartButton3);
            customCard6.Controls.Add(ipaddress);
            customCard6.Controls.Add(studentName);
            customCard6.Location = new Point(3, 2);
            customCard6.Margin = new Padding(3, 2, 3, 2);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(792, 98);
            customCard6.TabIndex = 13;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.FromArgb(0, 0, 192);
            smartButton3.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton3.BorderRadius = 10;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(628, 25);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(146, 49);
            smartButton3.TabIndex = 13;
            smartButton3.Text = "Send Message";
            smartButton3.UseVisualStyleBackColor = false;
            // 
            // ipaddress
            // 
            ipaddress.AutoSize = true;
            ipaddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipaddress.ForeColor = Color.Gray;
            ipaddress.Location = new Point(24, 36);
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
            studentName.Location = new Point(24, 10);
            studentName.Name = "studentName";
            studentName.Size = new Size(165, 21);
            studentName.TabIndex = 11;
            studentName.Text = "Jimmuel Sanggayan";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(copypastedCodes);
            customCard1.Controls.Add(customCard12);
            customCard1.Location = new Point(3, 2);
            customCard1.Margin = new Padding(3, 2, 3, 2);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(377, 251);
            customCard1.TabIndex = 13;
            // 
            // copypastedCodes
            // 
            copypastedCodes.AutoScroll = true;
            copypastedCodes.FlowDirection = FlowDirection.TopDown;
            copypastedCodes.Location = new Point(17, 67);
            copypastedCodes.Margin = new Padding(3, 2, 3, 2);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Size = new Size(358, 149);
            copypastedCodes.TabIndex = 13;
            copypastedCodes.WrapContents = false;
            // 
            // customCard12
            // 
            customCard12.BackColor = Color.White;
            customCard12.BorderColor = Color.Gray;
            customCard12.BorderRadius = 10;
            customCard12.BorderSize = 1;
            customCard12.Controls.Add(label20);
            customCard12.Location = new Point(3, 2);
            customCard12.Margin = new Padding(3, 2, 3, 2);
            customCard12.Name = "customCard12";
            customCard12.Size = new Size(372, 51);
            customCard12.TabIndex = 14;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(13, 13, 13);
            label20.Location = new Point(10, 14);
            label20.Name = "label20";
            label20.Size = new Size(159, 21);
            label20.TabIndex = 6;
            label20.Text = "Copy-Paste Activity";
            // 
            // codeTrack
            // 
            codeTrack.Location = new Point(3, 104);
            codeTrack.Margin = new Padding(3, 2, 3, 2);
            codeTrack.Maximum = 0;
            codeTrack.Name = "codeTrack";
            codeTrack.Size = new Size(795, 45);
            codeTrack.TabIndex = 100;
            codeTrack.Scroll += codeTrack_Scroll;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(customCard6);
            flowLayoutPanel1.Controls.Add(codeTrack);
            flowLayoutPanel1.Controls.Add(customCard8);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(381, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(956, 588);
            flowLayoutPanel1.TabIndex = 102;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(studentCodeRating1);
            panel1.Controls.Add(customCard1);
            panel1.Location = new Point(3, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 274);
            panel1.TabIndex = 101;
            // 
            // studentCodeRating1
            // 
            studentCodeRating1.Location = new Point(386, 4);
            studentCodeRating1.Margin = new Padding(3, 2, 3, 2);
            studentCodeRating1.Name = "studentCodeRating1";
            studentCodeRating1.Size = new Size(398, 249);
            studentCodeRating1.TabIndex = 14;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(smartButton1);
            customCard2.Controls.Add(panel2);
            customCard2.Controls.Add(label7);
            customCard2.Controls.Add(iconsContainer);
            customCard2.Location = new Point(23, 53);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(20, 0, 20, 30);
            customCard2.Size = new Size(315, 588);
            customCard2.TabIndex = 103;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(20, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 1);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(13, 13, 13);
            label7.Location = new Point(36, 17);
            label7.Name = "label7";
            label7.Size = new Size(104, 30);
            label7.TabIndex = 11;
            label7.Text = "Students";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.FromArgb(0, 0, 192);
            smartButton1.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(20, 50);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(275, 39);
            smartButton1.TabIndex = 14;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // iconsContainer
            // 
            iconsContainer.AutoScroll = true;
            iconsContainer.Dock = DockStyle.Bottom;
            iconsContainer.FlowDirection = FlowDirection.TopDown;
            iconsContainer.Location = new Point(20, 95);
            iconsContainer.Name = "iconsContainer";
            iconsContainer.Size = new Size(275, 463);
            iconsContainer.TabIndex = 12;
            iconsContainer.TabStop = true;
            iconsContainer.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1311474F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.86885F));
            tableLayoutPanel1.Controls.Add(customCard2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 50, 0, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1340, 874);
            tableLayoutPanel1.TabIndex = 105;
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "TempServerPage";
            Size = new Size(1340, 874);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard12.ResumeLayout(false);
            customCard12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label label20;
        private GeneralComponents.CustomCard customCard12;
        private Pages.ProgrammingTabs.CodeEditor studentCode;
        private TrackBar codeTrack;
        private FlowLayoutPanel copypastedCodes;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GeneralComponents.CustomCard customCard2;
        private FlowLayoutPanel iconsContainer;
        private StudentCodeRating studentCodeRating1;
        private GeneralComponents.StatsBar accuracy;
        private Label label1;
        private GeneralComponents.StatsBar statsBar2;
        private Label label6;
        private GeneralComponents.StatsBar readability;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private GeneralComponents.SmartButton smartButton1;
        private Label label7;
        private Panel panel2;
    }
}
