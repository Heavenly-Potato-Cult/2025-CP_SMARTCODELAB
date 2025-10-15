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
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label14 = new Label();
            ipaddress = new Label();
            studentName = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label5 = new Label();
            label3 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            copypastedCodes = new FlowLayoutPanel();
            customCard12 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label20 = new Label();
            codeTrack = new TrackBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            iconsContainer = new FlowLayoutPanel();
            label4 = new Label();
            customTextBox1 = new CustomTextBox();
            studentCodeRating = new StudentCodeRating();
            customCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard6.SuspendLayout();
            customCard7.SuspendLayout();
            customCard1.SuspendLayout();
            customCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            customCard2.SuspendLayout();
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
            customCard8.Location = new Point(3, 129);
            customCard8.Margin = new Padding(3, 2, 3, 2);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(795, 451);
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
            studentCode.Font = new Font("Courier New", 9.75F);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(24, 40);
            studentCode.Margin = new Padding(3, 2, 3, 2);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(750, 398);
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
            customCard6.Controls.Add(smartButton2);
            customCard6.Controls.Add(customCard7);
            customCard6.Controls.Add(ipaddress);
            customCard6.Controls.Add(studentName);
            customCard6.Location = new Point(3, 2);
            customCard6.Margin = new Padding(3, 2, 3, 2);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(797, 74);
            customCard6.TabIndex = 13;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.FromArgb(0, 0, 192);
            smartButton3.BackgroundColor = Color.FromArgb(0, 0, 192);
            smartButton3.BorderRadius = 10;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(668, 18);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(107, 29);
            smartButton3.TabIndex = 13;
            smartButton3.Text = "Send Hint";
            smartButton3.UseVisualStyleBackColor = false;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.FromArgb(255, 128, 0);
            smartButton2.BackgroundColor = Color.FromArgb(255, 128, 0);
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(572, 18);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(90, 29);
            smartButton2.TabIndex = 8;
            smartButton2.Text = "Flag";
            smartButton2.UseVisualStyleBackColor = false;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.FromArgb(192, 255, 192);
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 15;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(435, 21);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(132, 24);
            customCard7.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(6, 4);
            label14.Name = "label14";
            label14.Size = new Size(116, 19);
            label14.TabIndex = 13;
            label14.Text = "Activite - Coding";
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
            // smartButton1
            // 
            smartButton1.BackColor = Color.ForestGreen;
            smartButton1.BackgroundColor = Color.ForestGreen;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(194, 31);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(95, 42);
            smartButton1.TabIndex = 12;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(16, 28);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 10;
            label5.Text = " Real-time monitoring";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(16, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 30);
            label3.TabIndex = 9;
            label3.Text = "Student Monitoring";
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
            codeTrack.Location = new Point(3, 80);
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
            flowLayoutPanel1.Location = new Point(310, 2);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(854, 613);
            flowLayoutPanel1.TabIndex = 102;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(studentCodeRating);
            panel1.Controls.Add(customCard1);
            panel1.Location = new Point(3, 584);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 274);
            panel1.TabIndex = 101;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 20;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(iconsContainer);
            customCard2.Controls.Add(label4);
            customCard2.Controls.Add(customTextBox1);
            customCard2.Location = new Point(16, 82);
            customCard2.Margin = new Padding(3, 2, 3, 2);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(276, 530);
            customCard2.TabIndex = 103;
            // 
            // iconsContainer
            // 
            iconsContainer.AutoScroll = true;
            iconsContainer.FlowDirection = FlowDirection.TopDown;
            iconsContainer.Location = new Point(9, 66);
            iconsContainer.Margin = new Padding(3, 2, 3, 2);
            iconsContainer.Name = "iconsContainer";
            iconsContainer.Size = new Size(257, 462);
            iconsContainer.TabIndex = 12;
            iconsContainer.TabStop = true;
            iconsContainer.WrapContents = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 13, 13);
            label4.Location = new Point(16, 8);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 10;
            label4.Text = "Students";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.WhiteSmoke;
            customTextBox1.BorderColor = Color.White;
            customTextBox1.BorderFocusColor = Color.Transparent;
            customTextBox1.BorderRadius = 10;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(9, 31);
            customTextBox1.Margin = new Padding(3, 2, 3, 2);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(9, 5, 9, 5);
            customTextBox1.PlaceHolderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.ScrollBars = ScrollBars.None;
            customTextBox1.Size = new Size(249, 32);
            customTextBox1.TabIndex = 11;
            // 
            // studentCodeRating
            // 
            studentCodeRating.Location = new Point(386, 4);
            studentCodeRating.Margin = new Padding(3, 2, 3, 2);
            studentCodeRating.Name = "studentCodeRating";
            studentCodeRating.Size = new Size(398, 249);
            studentCodeRating.TabIndex = 14;
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(customCard2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(smartButton1);
            Controls.Add(label5);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TempServerPage";
            Size = new Size(1165, 615);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).EndInit();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard12.ResumeLayout(false);
            customCard12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GeneralComponents.CustomCard customCard8;
        private Label label15;
        private GeneralComponents.CustomCard customCard6;
        private GeneralComponents.SmartButton smartButton3;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.CustomCard customCard7;
        private Label label14;
        private Label ipaddress;
        private Label studentName;
        private GeneralComponents.SmartButton smartButton1;
        private Label label5;
        private Label label3;
        private GeneralComponents.CustomCard customCard1;
        private Label label20;
        private GeneralComponents.CustomCard customCard12;
        private Pages.ProgrammingTabs.CodeEditor studentCode;
        private TrackBar codeTrack;
        private FlowLayoutPanel copypastedCodes;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GeneralComponents.CustomCard customCard2;
        private Label label4;
        private CustomTextBox customTextBox1;
        private FlowLayoutPanel iconsContainer;
        private StudentCodeRating studentCodeRating;
    }
}
