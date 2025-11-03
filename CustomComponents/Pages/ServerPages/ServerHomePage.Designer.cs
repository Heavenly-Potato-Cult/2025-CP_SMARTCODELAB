namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class ServerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerHomePage));
            panel1 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            activeCount = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            submissionCount = new Label();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pastedCount = new Label();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            customCard24 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            btn_viewstudents = new Label();
            pictureBox13 = new PictureBox();
            pictureBox16 = new PictureBox();
            label60 = new Label();
            label63 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label64 = new Label();
            customCard23 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            tableLayoutPanel4 = new TableLayoutPanel();
            label46 = new Label();
            label47 = new Label();
            lbl_sessionname = new Label();
            lbl_sessionpassword = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            label59 = new Label();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            panel8 = new Panel();
            notifContainer = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            studentName = new CustomTextBox();
            panel_line2 = new Panel();
            panel_line = new Panel();
            label45 = new Label();
            label44 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            customCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            customCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            customCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            customCard24.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            customCard23.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            customCard7.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1576, 95);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 13, 13);
            label1.Location = new Point(247, 32);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 11;
            label1.Text = "Dashboard Overview";
            // 
            // panel6
            // 
            panel6.Controls.Add(customCard1);
            panel6.Controls.Add(customCard2);
            panel6.Controls.Add(customCard3);
            panel6.Controls.Add(customCard4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 95);
            panel6.Name = "panel6";
            panel6.Size = new Size(1576, 136);
            panel6.TabIndex = 32;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(pictureBox1);
            customCard1.Controls.Add(label2);
            customCard1.Controls.Add(activeCount);
            customCard1.Location = new Point(247, 20);
            customCard1.Margin = new Padding(3, 2, 50, 2);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(228, 96);
            customCard1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(88, 50);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 14;
            label2.Text = "Active Students";
            // 
            // activeCount
            // 
            activeCount.AutoSize = true;
            activeCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            activeCount.ForeColor = Color.FromArgb(13, 13, 13);
            activeCount.Location = new Point(88, 21);
            activeCount.Name = "activeCount";
            activeCount.Size = new Size(26, 30);
            activeCount.TabIndex = 12;
            activeCount.Text = "0";
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
            customCard2.Location = new Point(528, 20);
            customCard2.Margin = new Padding(3, 2, 50, 2);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(229, 96);
            customCard2.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 21);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 62);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(88, 50);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 14;
            label4.Text = "Student Submitted";
            // 
            // submissionCount
            // 
            submissionCount.AutoSize = true;
            submissionCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            submissionCount.ForeColor = Color.FromArgb(13, 13, 13);
            submissionCount.Location = new Point(88, 21);
            submissionCount.Name = "submissionCount";
            submissionCount.Size = new Size(26, 30);
            submissionCount.TabIndex = 12;
            submissionCount.Text = "0";
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
            customCard3.Location = new Point(810, 20);
            customCard3.Margin = new Padding(3, 2, 50, 2);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(229, 96);
            customCard3.TabIndex = 22;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 22);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 61);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(73, 49);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 14;
            label7.Text = "Copy Paste Detected";
            // 
            // pastedCount
            // 
            pastedCount.AutoSize = true;
            pastedCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            pastedCount.ForeColor = Color.FromArgb(13, 13, 13);
            pastedCount.Location = new Point(76, 21);
            pastedCount.Name = "pastedCount";
            pastedCount.Size = new Size(26, 30);
            pastedCount.TabIndex = 12;
            pastedCount.Text = "0";
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 10;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(pictureBox4);
            customCard4.Controls.Add(label9);
            customCard4.Controls.Add(label10);
            customCard4.Location = new Point(1092, 20);
            customCard4.Margin = new Padding(3, 2, 50, 2);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(238, 96);
            customCard4.TabIndex = 23;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 21);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 62);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(93, 50);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 14;
            label9.Text = "Avg. Session Time";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(13, 13, 13);
            label10.Location = new Point(93, 21);
            label10.Name = "label10";
            label10.Size = new Size(58, 30);
            label10.TabIndex = 12;
            label10.Text = "4.2h";
            // 
            // customCard24
            // 
            customCard24.Anchor = AnchorStyles.Top;
            customCard24.BackColor = Color.White;
            customCard24.BorderColor = Color.Gray;
            customCard24.BorderRadius = 10;
            customCard24.BorderSize = 1;
            customCard24.Controls.Add(tableLayoutPanel1);
            customCard24.Controls.Add(panel3);
            customCard24.Controls.Add(panel2);
            customCard24.Controls.Add(label64);
            customCard24.Location = new Point(9, 7);
            customCard24.Margin = new Padding(3, 2, 3, 2);
            customCard24.Name = "customCard24";
            customCard24.Padding = new Padding(4, 8, 4, 8);
            customCard24.Size = new Size(358, 264);
            customCard24.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6029005F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.3970947F));
            tableLayoutPanel1.Controls.Add(pictureBox6, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_viewstudents, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox13, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox16, 0, 1);
            tableLayoutPanel1.Controls.Add(label60, 1, 1);
            tableLayoutPanel1.Controls.Add(label63, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 40);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 8, 18, 8);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(350, 216);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(21, 159);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 33);
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(13, 13, 13);
            label5.Location = new Point(66, 157);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 2, 0, 0);
            label5.Size = new Size(44, 23);
            label5.TabIndex = 30;
            label5.Text = "Save";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 110);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // btn_viewstudents
            // 
            btn_viewstudents.AutoSize = true;
            btn_viewstudents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewstudents.ForeColor = Color.FromArgb(13, 13, 13);
            btn_viewstudents.Location = new Point(66, 108);
            btn_viewstudents.Name = "btn_viewstudents";
            btn_viewstudents.Padding = new Padding(0, 2, 0, 0);
            btn_viewstudents.Size = new Size(114, 23);
            btn_viewstudents.TabIndex = 28;
            btn_viewstudents.Text = "View Students";
            btn_viewstudents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(21, 10);
            pictureBox13.Margin = new Padding(3, 2, 3, 2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(32, 33);
            pictureBox13.TabIndex = 21;
            pictureBox13.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(21, 60);
            pictureBox16.Margin = new Padding(3, 2, 3, 2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(32, 32);
            pictureBox16.TabIndex = 27;
            pictureBox16.TabStop = false;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label60.ForeColor = Color.FromArgb(13, 13, 13);
            label60.Location = new Point(66, 58);
            label60.Name = "label60";
            label60.Padding = new Padding(0, 2, 0, 0);
            label60.Size = new Size(152, 23);
            label60.TabIndex = 26;
            label60.Text = "Broadcast Message";
            label60.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label63.ForeColor = Color.FromArgb(13, 13, 13);
            label63.Location = new Point(66, 8);
            label63.Name = "label63";
            label63.Padding = new Padding(0, 2, 0, 0);
            label63.Size = new Size(96, 23);
            label63.TabIndex = 13;
            label63.Text = "End Session";
            label63.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(4, 39);
            panel3.Margin = new Padding(3, 15, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 29);
            panel2.Margin = new Padding(3, 15, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 10);
            panel2.TabIndex = 28;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Dock = DockStyle.Top;
            label64.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label64.ForeColor = Color.FromArgb(13, 13, 13);
            label64.Location = new Point(4, 8);
            label64.Name = "label64";
            label64.Padding = new Padding(9, 0, 0, 0);
            label64.Size = new Size(117, 21);
            label64.TabIndex = 12;
            label64.Text = "Quick Action";
            // 
            // customCard23
            // 
            customCard23.Anchor = AnchorStyles.Top;
            customCard23.BackColor = Color.White;
            customCard23.BorderColor = Color.Gray;
            customCard23.BorderRadius = 10;
            customCard23.BorderSize = 1;
            customCard23.Controls.Add(tableLayoutPanel4);
            customCard23.Controls.Add(panel5);
            customCard23.Controls.Add(panel4);
            customCard23.Controls.Add(label59);
            customCard23.Location = new Point(9, 284);
            customCard23.Margin = new Padding(3, 2, 3, 2);
            customCard23.Name = "customCard23";
            customCard23.Padding = new Padding(4, 8, 4, 8);
            customCard23.Size = new Size(358, 158);
            customCard23.TabIndex = 28;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.2943954F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.7056046F));
            tableLayoutPanel4.Controls.Add(label46, 0, 0);
            tableLayoutPanel4.Controls.Add(label47, 0, 1);
            tableLayoutPanel4.Controls.Add(lbl_sessionname, 1, 0);
            tableLayoutPanel4.Controls.Add(lbl_sessionpassword, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 40);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(9, 8, 9, 0);
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(350, 110);
            tableLayoutPanel4.TabIndex = 31;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label46.ForeColor = Color.Gray;
            label46.Location = new Point(12, 8);
            label46.Name = "label46";
            label46.Size = new Size(102, 20);
            label46.TabIndex = 21;
            label46.Text = "Session Name";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label47.ForeColor = Color.Gray;
            label47.Location = new Point(12, 59);
            label47.Name = "label47";
            label47.Size = new Size(70, 20);
            label47.TabIndex = 22;
            label47.Text = "Password";
            // 
            // lbl_sessionname
            // 
            lbl_sessionname.AutoSize = true;
            lbl_sessionname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sessionname.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_sessionname.Location = new Point(152, 8);
            lbl_sessionname.Name = "lbl_sessionname";
            lbl_sessionname.RightToLeft = RightToLeft.No;
            lbl_sessionname.Size = new Size(46, 20);
            lbl_sessionname.TabIndex = 24;
            lbl_sessionname.Text = "name";
            // 
            // lbl_sessionpassword
            // 
            lbl_sessionpassword.AutoSize = true;
            lbl_sessionpassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sessionpassword.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_sessionpassword.Location = new Point(152, 59);
            lbl_sessionpassword.Name = "lbl_sessionpassword";
            lbl_sessionpassword.Size = new Size(72, 20);
            lbl_sessionpassword.TabIndex = 23;
            lbl_sessionpassword.Text = "password";
            lbl_sessionpassword.TextAlign = ContentAlignment.TopRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGray;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(4, 39);
            panel5.Margin = new Padding(3, 15, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 1);
            panel5.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(4, 29);
            panel4.Margin = new Padding(3, 15, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 10);
            panel4.TabIndex = 32;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Dock = DockStyle.Top;
            label59.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label59.ForeColor = Color.FromArgb(13, 13, 13);
            label59.Location = new Point(4, 8);
            label59.Name = "label59";
            label59.Padding = new Padding(9, 0, 0, 0);
            label59.Size = new Size(111, 21);
            label59.TabIndex = 26;
            label59.Text = "Session Info";
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
            customCard7.Dock = DockStyle.Fill;
            customCard7.Location = new Point(108, 12);
            customCard7.Margin = new Padding(3, 2, 44, 2);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(4, 8, 4, 15);
            customCard7.Size = new Size(606, 477);
            customCard7.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(notifContainer);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(studentName);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(4, 40);
            panel8.Margin = new Padding(3, 15, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(598, 419);
            panel8.TabIndex = 24;
            // 
            // notifContainer
            // 
            notifContainer.AutoScroll = true;
            notifContainer.BackColor = Color.White;
            notifContainer.ColumnCount = 1;
            notifContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            notifContainer.Location = new Point(3, 55);
            notifContainer.Margin = new Padding(3, 2, 3, 2);
            notifContainer.Name = "notifContainer";
            notifContainer.Padding = new Padding(9, 15, 18, 15);
            notifContainer.RowCount = 6;
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.RowStyles.Add(new RowStyle());
            notifContainer.Size = new Size(592, 348);
            notifContainer.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Copy Paste", "Logged In", "Logged Out", "Submission", "Exceptions Encounter" });
            comboBox1.Location = new Point(290, 15);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 2;
            // 
            // studentName
            // 
            studentName.BackColor = SystemColors.Window;
            studentName.BorderColor = Color.Gainsboro;
            studentName.BorderFocusColor = Color.LightGray;
            studentName.ForeColor = Color.DimGray;
            studentName.Location = new Point(12, 10);
            studentName.Margin = new Padding(3, 2, 3, 2);
            studentName.Name = "studentName";
            studentName.Padding = new Padding(9, 5, 9, 5);
            studentName.PlaceHolderColor = Color.DarkGray;
            studentName.PlaceholderText = "Search Student";
            studentName.ScrollBars = ScrollBars.None;
            studentName.Size = new Size(273, 32);
            studentName.TabIndex = 1;
            // 
            // panel_line2
            // 
            panel_line2.BackColor = Color.DarkGray;
            panel_line2.Dock = DockStyle.Top;
            panel_line2.Location = new Point(4, 39);
            panel_line2.Margin = new Padding(3, 15, 3, 2);
            panel_line2.Name = "panel_line2";
            panel_line2.Size = new Size(598, 1);
            panel_line2.TabIndex = 24;
            // 
            // panel_line
            // 
            panel_line.BackColor = Color.White;
            panel_line.Dock = DockStyle.Top;
            panel_line.Location = new Point(4, 29);
            panel_line.Margin = new Padding(3, 15, 3, 2);
            panel_line.Name = "panel_line";
            panel_line.Size = new Size(598, 10);
            panel_line.TabIndex = 23;
            // 
            // label45
            // 
            label45.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(0, 192, 0);
            label45.Location = new Point(564, 5);
            label45.Name = "label45";
            label45.Size = new Size(35, 20);
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
            label44.Location = new Point(4, 8);
            label44.Margin = new Padding(0);
            label44.Name = "label44";
            label44.Padding = new Padding(9, 0, 0, 0);
            label44.Size = new Size(156, 21);
            label44.TabIndex = 12;
            label44.Text = "Real-time Activity";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.47068F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.52932F));
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(customCard7, 0, 0);
            tableLayoutPanel3.Location = new Point(141, 236);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(105, 10, 70, 38);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1204, 529);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // panel7
            // 
            panel7.Controls.Add(customCard24);
            panel7.Controls.Add(customCard23);
            panel7.Location = new Point(761, 13);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 475);
            panel7.TabIndex = 13;
            // 
            // ServerHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 50, 2);
            Name = "ServerHomePage";
            Padding = new Padding(0, 0, 0, 30);
            Size = new Size(1576, 787);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            customCard24.ResumeLayout(false);
            customCard24.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            customCard23.ResumeLayout(false);
            customCard23.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            panel8.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Panel panel6;
        private GeneralComponents.CustomCard customCard24;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox16;
        private Label label60;
        private Label label63;
        private Panel panel3;
        private Panel panel2;
        private Label label64;
        private GeneralComponents.CustomCard customCard23;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label46;
        private Label label47;
        private Label lbl_sessionname;
        private Label lbl_sessionpassword;
        private Panel panel5;
        private Panel panel4;
        private Label label59;
        private GeneralComponents.CustomCard customCard7;
        private TableLayoutPanel notifContainer;
        private Panel panel8;
        private ComboBox comboBox1;
        private CustomTextBox studentName;
        private Panel panel_line2;
        private Panel panel_line;
        private Label label45;
        private Label label44;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel7;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
        private Label btn_viewstudents;
        private GeneralComponents.CustomCard customCard1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label activeCount;
        private GeneralComponents.CustomCard customCard2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label submissionCount;
        private GeneralComponents.CustomCard customCard3;
        private PictureBox pictureBox3;
        private Label label7;
        private Label pastedCount;
        private GeneralComponents.CustomCard customCard4;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label10;
    }
}