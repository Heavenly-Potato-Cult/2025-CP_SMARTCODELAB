namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempSessionManagement
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
            label5 = new Label();
            label3 = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            label2 = new Label();
            tabNavigationLocked = new SmartCodeLab.CustomComponents.GeneralComponents.CustomToggleButton();
            smartButton4 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            studentsCount = new Label();
            label1 = new Label();
            label4 = new Label();
            serverName = new CustomTextBox();
            codeQualityChoices = new SmartCodeLab.CustomComponents.GeneralComponents.CodeQualityChoices();
            label6 = new Label();
            customComboBox2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label15 = new Label();
            serverPW = new CustomTextBox();
            label7 = new Label();
            language = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            panel6 = new Panel();
            panel5 = new Panel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label8 = new Label();
            panel7 = new Panel();
            panel4 = new Panel();
            label14 = new Label();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            tbllayoutpanel_realtime_activity = new TableLayoutPanel();
            logsContaier = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            label16 = new Label();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            customCard2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            customCard1.SuspendLayout();
            customCard3.SuspendLayout();
            customCard4.SuspendLayout();
            tbllayoutpanel_realtime_activity.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(127, 79);
            label5.Name = "label5";
            label5.Size = new Size(391, 25);
            label5.TabIndex = 14;
            label5.Text = "Control and monitor programming lab sessions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(126, 35);
            label3.Name = "label3";
            label3.Size = new Size(297, 38);
            label3.TabIndex = 13;
            label3.Text = "Session Management";
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(tableLayoutPanel1);
            customCard2.Controls.Add(panel7);
            customCard2.Controls.Add(panel4);
            customCard2.Controls.Add(label14);
            customCard2.Location = new Point(3, 3);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(10, 20, 10, 11);
            customCard2.Size = new Size(1039, 478);
            customCard2.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.64815F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.62963F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.72222F));
            tableLayoutPanel1.Controls.Add(panel8, 2, 4);
            tableLayoutPanel1.Controls.Add(smartButton4, 1, 4);
            tableLayoutPanel1.Controls.Add(customCard1, 2, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(serverName, 0, 1);
            tableLayoutPanel1.Controls.Add(codeQualityChoices, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(customComboBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(label15, 1, 2);
            tableLayoutPanel1.Controls.Add(serverPW, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(language, 1, 1);
            tableLayoutPanel1.Controls.Add(customCard3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 20, 21, 0);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.136198F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.137846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.74843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5155592F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46197F));
            tableLayoutPanel1.Size = new Size(1019, 400);
            tableLayoutPanel1.TabIndex = 30;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Controls.Add(tabNavigationLocked);
            panel8.Location = new Point(607, 255);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 50);
            panel8.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 13);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 35;
            label2.Text = "Restrict Tab Navigation";
            // 
            // tabNavigationLocked
            // 
            tabNavigationLocked.AutoSize = true;
            tabNavigationLocked.Location = new Point(196, 13);
            tabNavigationLocked.Margin = new Padding(3, 4, 3, 4);
            tabNavigationLocked.MinimumSize = new Size(51, 29);
            tabNavigationLocked.Name = "tabNavigationLocked";
            tabNavigationLocked.OffBackColor = Color.Gray;
            tabNavigationLocked.OffToggleColor = Color.Gainsboro;
            tabNavigationLocked.OnBackColor = Color.MediumSlateBlue;
            tabNavigationLocked.OnToggleColor = Color.WhiteSmoke;
            tabNavigationLocked.Size = new Size(51, 29);
            tabNavigationLocked.TabIndex = 34;
            tabNavigationLocked.UseVisualStyleBackColor = true;
            // 
            // smartButton4
            // 
            smartButton4.BackColor = Color.MediumSlateBlue;
            smartButton4.BorderRadius = 20;
            smartButton4.FlatAppearance.BorderSize = 0;
            smartButton4.FlatStyle = FlatStyle.Flat;
            smartButton4.ForeColor = Color.White;
            smartButton4.Location = new Point(315, 256);
            smartButton4.Margin = new Padding(3, 4, 3, 4);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(113, 43);
            smartButton4.TabIndex = 33;
            smartButton4.Text = "Generate";
            smartButton4.UseVisualStyleBackColor = false;
            smartButton4.Click += smartButton4_Click;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 20;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(smartButton2);
            customCard1.Controls.Add(studentsCount);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(607, 198);
            customCard1.Margin = new Padding(3, 4, 3, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(229, 47);
            customCard1.TabIndex = 32;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 12;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(113, 5);
            smartButton2.Margin = new Padding(3, 4, 3, 4);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(104, 35);
            smartButton2.TabIndex = 33;
            smartButton2.Text = "View";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // studentsCount
            // 
            studentsCount.AutoSize = true;
            studentsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentsCount.Location = new Point(86, 13);
            studentsCount.Name = "studentsCount";
            studentsCount.Size = new Size(18, 20);
            studentsCount.TabIndex = 32;
            studentsCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 31;
            label1.Text = "Students";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(13, 41);
            label4.Name = "label4";
            label4.Size = new Size(296, 25);
            label4.TabIndex = 17;
            label4.Text = "Session Name";
            // 
            // serverName
            // 
            serverName.BackColor = Color.White;
            serverName.BorderColor = Color.LightGray;
            serverName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            serverName.BorderRadius = 10;
            serverName.BorderSize = 1;
            serverName.ForeColor = SystemColors.ControlText;
            serverName.Location = new Point(13, 69);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(10, 7, 10, 7);
            serverName.PlaceHolderColor = Color.DarkGray;
            serverName.PlaceholderText = "";
            serverName.ScrollBars = ScrollBars.None;
            serverName.Size = new Size(223, 41);
            serverName.TabIndex = 18;
            // 
            // codeQualityChoices
            // 
            codeQualityChoices.Location = new Point(13, 255);
            codeQualityChoices.Name = "codeQualityChoices";
            codeQualityChoices.Size = new Size(245, 142);
            codeQualityChoices.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(13, 169);
            label6.Name = "label6";
            label6.Size = new Size(296, 25);
            label6.TabIndex = 19;
            label6.Text = "Session Code";
            // 
            // customComboBox2
            // 
            customComboBox2.BackColor = Color.White;
            customComboBox2.BorderColor = Color.LightGray;
            customComboBox2.BorderSize = 1;
            customComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox2.Font = new Font("Segoe UI", 10F);
            customComboBox2.ForeColor = Color.DimGray;
            customComboBox2.IconColor = Color.Gray;
            customComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox2.ListTextColor = Color.DimGray;
            customComboBox2.Location = new Point(315, 197);
            customComboBox2.MinimumSize = new Size(200, 29);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(200, 41);
            customComboBox2.TabIndex = 26;
            customComboBox2.Texts = "";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Bottom;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(315, 169);
            label15.Name = "label15";
            label15.Size = new Size(286, 25);
            label15.TabIndex = 25;
            label15.Text = "Select Exercise";
            label15.TextAlign = ContentAlignment.BottomLeft;
            // 
            // serverPW
            // 
            serverPW.BackColor = Color.White;
            serverPW.BorderColor = Color.LightGray;
            serverPW.BorderFocusColor = Color.FromArgb(64, 64, 64);
            serverPW.BorderRadius = 10;
            serverPW.BorderSize = 1;
            serverPW.ForeColor = SystemColors.ControlText;
            serverPW.Location = new Point(13, 197);
            serverPW.Name = "serverPW";
            serverPW.Padding = new Padding(10, 7, 10, 7);
            serverPW.PlaceHolderColor = Color.DarkGray;
            serverPW.PlaceholderText = "";
            serverPW.ScrollBars = ScrollBars.None;
            serverPW.Size = new Size(223, 41);
            serverPW.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(315, 41);
            label7.Name = "label7";
            label7.Size = new Size(286, 25);
            label7.TabIndex = 27;
            label7.Text = "Programming Language";
            // 
            // language
            // 
            language.BackColor = Color.White;
            language.BorderColor = Color.LightGray;
            language.BorderSize = 1;
            language.DropDownStyle = ComboBoxStyle.DropDown;
            language.Font = new Font("Segoe UI", 10F);
            language.ForeColor = Color.DimGray;
            language.IconColor = Color.Gray;
            language.Items.AddRange(new object[] { "C++", "Java", "Python" });
            language.ListBackColor = Color.FromArgb(230, 228, 245);
            language.ListTextColor = Color.DimGray;
            language.Location = new Point(315, 69);
            language.MinimumSize = new Size(200, 29);
            language.Name = "language";
            language.Padding = new Padding(1);
            language.Size = new Size(200, 40);
            language.TabIndex = 28;
            language.Texts = "";
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.White;
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 15;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(panel6);
            customCard3.Controls.Add(panel5);
            customCard3.Controls.Add(smartButton1);
            customCard3.Controls.Add(label8);
            customCard3.Location = new Point(607, 23);
            customCard3.MaximumSize = new Size(439, 208);
            customCard3.Name = "customCard3";
            customCard3.Padding = new Padding(10, 11, 10, 0);
            tableLayoutPanel1.SetRowSpan(customCard3, 3);
            customCard3.Size = new Size(354, 144);
            customCard3.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 1);
            panel6.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 11);
            panel5.TabIndex = 30;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            smartButton1.BackColor = Color.DarkGreen;
            smartButton1.BackgroundColor = Color.DarkGreen;
            smartButton1.BorderRadius = 5;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(10, 59);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(333, 56);
            smartButton1.TabIndex = 26;
            smartButton1.Text = "Start Session";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(13, 13, 13);
            label8.Location = new Point(10, 11);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 0, 0, 0);
            label8.Size = new Size(157, 28);
            label8.TabIndex = 25;
            label8.Text = "Session Actions";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGray;
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 66);
            panel7.Name = "panel7";
            panel7.Size = new Size(1019, 1);
            panel7.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 15);
            panel4.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(13, 13, 13);
            label14.Location = new Point(10, 20);
            label14.Name = "label14";
            label14.Padding = new Padding(10, 0, 0, 0);
            label14.Size = new Size(191, 31);
            label14.TabIndex = 29;
            label14.Text = "Session Control";
            // 
            // customCard4
            // 
            customCard4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 10;
            customCard4.BorderSize = 1;
            customCard4.Controls.Add(tbllayoutpanel_realtime_activity);
            customCard4.Controls.Add(panel2);
            customCard4.Controls.Add(panel1);
            customCard4.Controls.Add(label16);
            customCard4.Location = new Point(3, 487);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(10, 20, 10, 11);
            customCard4.Size = new Size(811, 337);
            customCard4.TabIndex = 25;
            // 
            // tbllayoutpanel_realtime_activity
            // 
            tbllayoutpanel_realtime_activity.AutoScroll = true;
            tbllayoutpanel_realtime_activity.ColumnCount = 1;
            tbllayoutpanel_realtime_activity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbllayoutpanel_realtime_activity.Controls.Add(logsContaier, 0, 1);
            tbllayoutpanel_realtime_activity.Dock = DockStyle.Fill;
            tbllayoutpanel_realtime_activity.Location = new Point(10, 67);
            tbllayoutpanel_realtime_activity.Name = "tbllayoutpanel_realtime_activity";
            tbllayoutpanel_realtime_activity.Padding = new Padding(10, 20, 21, 20);
            tbllayoutpanel_realtime_activity.RowCount = 2;
            tbllayoutpanel_realtime_activity.RowStyles.Add(new RowStyle());
            tbllayoutpanel_realtime_activity.RowStyles.Add(new RowStyle());
            tbllayoutpanel_realtime_activity.Size = new Size(791, 259);
            tbllayoutpanel_realtime_activity.TabIndex = 27;
            // 
            // logsContaier
            // 
            logsContaier.AutoScroll = true;
            logsContaier.FlowDirection = FlowDirection.TopDown;
            logsContaier.Location = new Point(13, 23);
            logsContaier.Name = "logsContaier";
            logsContaier.Size = new Size(754, 233);
            logsContaier.TabIndex = 0;
            logsContaier.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 1);
            panel2.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 15);
            panel1.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(13, 13, 13);
            label16.Location = new Point(10, 20);
            label16.Name = "label16";
            label16.Padding = new Padding(10, 0, 0, 0);
            label16.Size = new Size(160, 31);
            label16.TabIndex = 28;
            label16.Text = "Session Logs";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1083, 156);
            panel3.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(customCard2);
            flowLayoutPanel1.Controls.Add(customCard4);
            flowLayoutPanel1.Location = new Point(8, 162);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 548);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // TempSessionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Name = "TempSessionManagement";
            Size = new Size(1083, 713);
            Load += TempSessionManagement_Load;
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            tbllayoutpanel_realtime_activity.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Label label3;
        private GeneralComponents.CustomCard customCard2;
        private GeneralComponents.CustomCard customCard4;
        private Label label16;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label14;
        private Panel panel4;
        private Panel panel7;
        private TableLayoutPanel tbllayoutpanel_realtime_activity;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private CustomTextBox serverName;
        private Label label6;
        private GeneralComponents.CustomComboBox customComboBox2;
        private Label label15;
        private CustomTextBox serverPW;
        private Label label7;
        private GeneralComponents.CustomComboBox language;
        private GeneralComponents.CustomCard customCard3;
        private Panel panel6;
        private Panel panel5;
        private GeneralComponents.SmartButton smartButton1;
        private Label label8;
        private GeneralComponents.CodeQualityChoices codeQualityChoices;
        private Label label1;
        private GeneralComponents.CustomCard customCard1;
        private Label studentsCount;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton4;
        private GeneralComponents.CustomToggleButton tabNavigationLocked;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel logsContaier;
        private Panel panel8;
    }
}
