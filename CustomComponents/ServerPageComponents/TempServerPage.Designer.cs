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
            memberContainer = new ServerMemberContainer();
            codeTrack = new TrackBar();
            smartButton4 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            customCard13 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard15 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            customCard14 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            customCard16 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            customCard17 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label33 = new Label();
            customCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCode).BeginInit();
            customCard6.SuspendLayout();
            customCard7.SuspendLayout();
            customCard1.SuspendLayout();
            customCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)codeTrack).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            customCard13.SuspendLayout();
            customCard15.SuspendLayout();
            customCard14.SuspendLayout();
            customCard16.SuspendLayout();
            customCard17.SuspendLayout();
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
            customCard8.Location = new Point(3, 169);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(909, 601);
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
            studentCode.AutoScrollMinSize = new Size(31, 18);
            studentCode.BackBrush = null;
            studentCode.CharHeight = 18;
            studentCode.CharWidth = 10;
            studentCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            studentCode.Hotkeys = resources.GetString("studentCode.Hotkeys");
            studentCode.IsReplaceMode = false;
            studentCode.Location = new Point(28, 53);
            studentCode.Name = "studentCode";
            studentCode.Paddings = new Padding(0);
            studentCode.ReadOnly = true;
            studentCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            studentCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("studentCode.ServiceColors");
            studentCode.Size = new Size(857, 530);
            studentCode.TabIndex = 15;
            studentCode.Zoom = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 13, 13);
            label15.Location = new Point(28, 13);
            label15.Name = "label15";
            label15.Size = new Size(193, 28);
            label15.TabIndex = 14;
            label15.Text = "Live Coding Viewer";
            label15.Click += label15_Click;
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
            customCard6.Location = new Point(3, 3);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(911, 98);
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
            smartButton3.Location = new Point(763, 24);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(122, 39);
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
            smartButton2.Location = new Point(654, 24);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(103, 39);
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
            customCard7.Location = new Point(497, 28);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(151, 32);
            customCard7.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(7, 5);
            label14.Name = "label14";
            label14.Size = new Size(139, 23);
            label14.TabIndex = 13;
            label14.Text = "Activite - Coding";
            // 
            // ipaddress
            // 
            ipaddress.AutoSize = true;
            ipaddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipaddress.ForeColor = Color.Gray;
            ipaddress.Location = new Point(28, 48);
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
            studentName.Location = new Point(28, 14);
            studentName.Name = "studentName";
            studentName.Size = new Size(201, 28);
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
            smartButton1.Location = new Point(222, 41);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(109, 56);
            smartButton1.TabIndex = 12;
            smartButton1.Text = "Broadcast Message";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(18, 38);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 10;
            label5.Text = " Real-time monitoring";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(18, 0);
            label3.Name = "label3";
            label3.Size = new Size(278, 38);
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
            customCard1.Location = new Point(3, 3);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(431, 335);
            customCard1.TabIndex = 13;
            // 
            // copypastedCodes
            // 
            copypastedCodes.AutoScroll = true;
            copypastedCodes.FlowDirection = FlowDirection.TopDown;
            copypastedCodes.Location = new Point(19, 89);
            copypastedCodes.Name = "copypastedCodes";
            copypastedCodes.Size = new Size(409, 199);
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
            customCard12.Location = new Point(3, 3);
            customCard12.Name = "customCard12";
            customCard12.Size = new Size(425, 68);
            customCard12.TabIndex = 14;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(13, 13, 13);
            label20.Location = new Point(11, 19);
            label20.Name = "label20";
            label20.Size = new Size(198, 28);
            label20.TabIndex = 6;
            label20.Text = "Copy-Paste Activity";
            // 
            // memberContainer
            // 
            memberContainer.BackColor = Color.White;
            memberContainer.BorderColor = Color.Gray;
            memberContainer.BorderRadius = 20;
            memberContainer.BorderSize = 0;
            memberContainer.Location = new Point(28, 103);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(315, 670);
            memberContainer.TabIndex = 16;
            // 
            // codeTrack
            // 
            codeTrack.Location = new Point(3, 107);
            codeTrack.Maximum = 0;
            codeTrack.Name = "codeTrack";
            codeTrack.Size = new Size(909, 56);
            codeTrack.TabIndex = 100;
            codeTrack.Scroll += codeTrack_Scroll;
            // 
            // smartButton4
            // 
            smartButton4.BackColor = Color.MediumSlateBlue;
            smartButton4.BorderRadius = 20;
            smartButton4.FlatAppearance.BorderSize = 0;
            smartButton4.FlatStyle = FlatStyle.Flat;
            smartButton4.ForeColor = Color.White;
            smartButton4.Location = new Point(28, 66);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(188, 31);
            smartButton4.TabIndex = 101;
            smartButton4.Text = "View Students";
            smartButton4.UseVisualStyleBackColor = false;
            smartButton4.Click += smartButton4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(customCard6);
            flowLayoutPanel1.Controls.Add(codeTrack);
            flowLayoutPanel1.Controls.Add(customCard8);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(354, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(976, 817);
            flowLayoutPanel1.TabIndex = 102;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(customCard1);
            panel1.Controls.Add(customCard13);
            panel1.Location = new Point(3, 776);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 365);
            panel1.TabIndex = 101;
            // 
            // customCard13
            // 
            customCard13.BackColor = Color.White;
            customCard13.BorderColor = Color.Gray;
            customCard13.BorderRadius = 10;
            customCard13.BorderSize = 1;
            customCard13.Controls.Add(customCard15);
            customCard13.Controls.Add(customCard14);
            customCard13.Controls.Add(customCard16);
            customCard13.Controls.Add(customCard17);
            customCard13.Location = new Point(475, 3);
            customCard13.Name = "customCard13";
            customCard13.Size = new Size(431, 335);
            customCard13.TabIndex = 14;
            // 
            // customCard15
            // 
            customCard15.BackColor = Color.White;
            customCard15.BorderColor = Color.Gray;
            customCard15.BorderRadius = 10;
            customCard15.BorderSize = 1;
            customCard15.Controls.Add(label27);
            customCard15.Controls.Add(label28);
            customCard15.Controls.Add(label29);
            customCard15.Location = new Point(19, 218);
            customCard15.Name = "customCard15";
            customCard15.Size = new Size(392, 61);
            customCard15.TabIndex = 12;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Gray;
            label27.Location = new Point(89, 33);
            label27.Name = "label27";
            label27.Size = new Size(52, 17);
            label27.TabIndex = 11;
            label27.Text = "13 lines";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Gray;
            label28.Location = new Point(28, 33);
            label28.Name = "label28";
            label28.Size = new Size(36, 17);
            label28.TabIndex = 10;
            label28.Text = "7min";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(13, 13, 13);
            label29.Location = new Point(28, 9);
            label29.Name = "label29";
            label29.Size = new Size(83, 23);
            label29.TabIndex = 9;
            label29.Text = "setUsers()";
            // 
            // customCard14
            // 
            customCard14.BackColor = Color.White;
            customCard14.BorderColor = Color.Gray;
            customCard14.BorderRadius = 10;
            customCard14.BorderSize = 1;
            customCard14.Controls.Add(label24);
            customCard14.Controls.Add(label25);
            customCard14.Controls.Add(label26);
            customCard14.Location = new Point(19, 151);
            customCard14.Name = "customCard14";
            customCard14.Size = new Size(392, 61);
            customCard14.TabIndex = 12;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Gray;
            label24.Location = new Point(89, 33);
            label24.Name = "label24";
            label24.Size = new Size(52, 17);
            label24.TabIndex = 11;
            label24.Text = "10 lines";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Gray;
            label25.Location = new Point(28, 33);
            label25.Name = "label25";
            label25.Size = new Size(43, 17);
            label25.TabIndex = 10;
            label25.Text = "14min";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(13, 13, 13);
            label26.Location = new Point(28, 9);
            label26.Name = "label26";
            label26.Size = new Size(141, 23);
            label26.TabIndex = 9;
            label26.Text = "getmesomemilk()";
            // 
            // customCard16
            // 
            customCard16.BackColor = Color.White;
            customCard16.BorderColor = Color.Gray;
            customCard16.BorderRadius = 10;
            customCard16.BorderSize = 1;
            customCard16.Controls.Add(label30);
            customCard16.Controls.Add(label31);
            customCard16.Controls.Add(label32);
            customCard16.Location = new Point(19, 84);
            customCard16.Name = "customCard16";
            customCard16.Size = new Size(392, 61);
            customCard16.TabIndex = 8;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Gray;
            label30.Location = new Point(89, 33);
            label30.Name = "label30";
            label30.Size = new Size(52, 17);
            label30.TabIndex = 11;
            label30.Text = "23 lines";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.Gray;
            label31.Location = new Point(28, 33);
            label31.Name = "label31";
            label31.Size = new Size(43, 17);
            label31.TabIndex = 10;
            label31.Text = "10min";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.FromArgb(13, 13, 13);
            label32.Location = new Point(28, 9);
            label32.Name = "label32";
            label32.Size = new Size(57, 23);
            label32.TabIndex = 9;
            label32.Text = "hello()";
            // 
            // customCard17
            // 
            customCard17.BackColor = Color.White;
            customCard17.BorderColor = Color.Gray;
            customCard17.BorderRadius = 10;
            customCard17.BorderSize = 1;
            customCard17.Controls.Add(label33);
            customCard17.Location = new Point(0, 10);
            customCard17.Name = "customCard17";
            customCard17.Size = new Size(431, 68);
            customCard17.TabIndex = 15;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.FromArgb(13, 13, 13);
            label33.Location = new Point(11, 19);
            label33.Name = "label33";
            label33.Size = new Size(252, 28);
            label33.TabIndex = 6;
            label33.Text = "Code Functions Overview";
            // 
            // TempServerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(smartButton4);
            Controls.Add(memberContainer);
            Controls.Add(smartButton1);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "TempServerPage";
            Size = new Size(1331, 820);
            Load += TempServerPage_Load;
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
            customCard13.ResumeLayout(false);
            customCard15.ResumeLayout(false);
            customCard15.PerformLayout();
            customCard14.ResumeLayout(false);
            customCard14.PerformLayout();
            customCard16.ResumeLayout(false);
            customCard16.PerformLayout();
            customCard17.ResumeLayout(false);
            customCard17.PerformLayout();
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
        private ServerMemberContainer memberContainer;
        private Pages.ProgrammingTabs.CodeEditor studentCode;
        private TrackBar codeTrack;
        private GeneralComponents.SmartButton smartButton4;
        private FlowLayoutPanel copypastedCodes;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GeneralComponents.CustomCard customCard13;
        private GeneralComponents.CustomCard customCard15;
        private Label label27;
        private Label label28;
        private Label label29;
        private GeneralComponents.CustomCard customCard14;
        private Label label24;
        private Label label25;
        private Label label26;
        private GeneralComponents.CustomCard customCard16;
        private Label label30;
        private Label label31;
        private Label label32;
        private GeneralComponents.CustomCard customCard17;
        private Label label33;
    }
}
