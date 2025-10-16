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
            label4 = new Label();
            serverName = new CustomTextBox();
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
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label9 = new Label();
            label17 = new Label();
            label18 = new Label();
            customCard6 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel2 = new Panel();
            panel1 = new Panel();
            label16 = new Label();
            panel3 = new Panel();
            codeQualityChoices = new SmartCodeLab.CustomComponents.GeneralComponents.CodeQualityChoices();
            customCard2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            customCard3.SuspendLayout();
            customCard4.SuspendLayout();
            tbllayoutpanel_realtime_activity.SuspendLayout();
            customCard7.SuspendLayout();
            customCard6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(111, 59);
            label5.Name = "label5";
            label5.Size = new Size(322, 20);
            label5.TabIndex = 14;
            label5.Text = "Control and monitor programming lab sessions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(110, 26);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
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
            customCard2.Location = new Point(110, 122);
            customCard2.Margin = new Padding(3, 2, 3, 2);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(9, 15, 9, 8);
            customCard2.Size = new Size(716, 244);
            customCard2.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6481476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.62963F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.72222F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(serverName, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(customComboBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(label15, 1, 2);
            tableLayoutPanel1.Controls.Add(serverPW, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(language, 1, 1);
            tableLayoutPanel1.Controls.Add(customCard3, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(9, 52);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(9, 15, 18, 0);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.85366F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2660542F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.3669739F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(698, 184);
            tableLayoutPanel1.TabIndex = 30;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
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
            serverName.Location = new Point(12, 40);
            serverName.Margin = new Padding(3, 2, 3, 2);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(9, 5, 9, 5);
            serverName.PlaceHolderColor = Color.DarkGray;
            serverName.PlaceholderText = "";
            serverName.ScrollBars = ScrollBars.None;
            serverName.Size = new Size(199, 32);
            serverName.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(12, 83);
            label6.Name = "label6";
            label6.Size = new Size(199, 20);
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
            customComboBox2.Location = new Point(217, 105);
            customComboBox2.Margin = new Padding(3, 2, 3, 2);
            customComboBox2.MinimumSize = new Size(175, 22);
            customComboBox2.Name = "customComboBox2";
            customComboBox2.Padding = new Padding(1);
            customComboBox2.Size = new Size(192, 31);
            customComboBox2.TabIndex = 26;
            customComboBox2.Texts = "";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Bottom;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(217, 83);
            label15.Name = "label15";
            label15.Size = new Size(192, 20);
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
            serverPW.Location = new Point(12, 105);
            serverPW.Margin = new Padding(3, 2, 3, 2);
            serverPW.Name = "serverPW";
            serverPW.Padding = new Padding(9, 5, 9, 5);
            serverPW.PlaceHolderColor = Color.DarkGray;
            serverPW.PlaceholderText = "";
            serverPW.ScrollBars = ScrollBars.None;
            serverPW.Size = new Size(199, 32);
            serverPW.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(217, 18);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
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
            language.Location = new Point(217, 40);
            language.Margin = new Padding(3, 2, 3, 2);
            language.MinimumSize = new Size(175, 22);
            language.Name = "language";
            language.Padding = new Padding(1);
            language.Size = new Size(192, 30);
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
            customCard3.Location = new Point(415, 40);
            customCard3.Margin = new Padding(3, 2, 3, 2);
            customCard3.MaximumSize = new Size(384, 156);
            customCard3.Name = "customCard3";
            customCard3.Padding = new Padding(9, 8, 9, 0);
            tableLayoutPanel1.SetRowSpan(customCard3, 3);
            customCard3.Size = new Size(262, 108);
            customCard3.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(9, 37);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 1);
            panel6.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(9, 29);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 8);
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
            smartButton1.Location = new Point(9, 44);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(244, 42);
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
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Padding = new Padding(9, 0, 0, 0);
            label8.Size = new Size(127, 21);
            label8.TabIndex = 25;
            label8.Text = "Session Actions";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGray;
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(9, 51);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(698, 1);
            panel7.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(9, 40);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(698, 11);
            panel4.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(13, 13, 13);
            label14.Location = new Point(9, 15);
            label14.Name = "label14";
            label14.Padding = new Padding(9, 0, 0, 0);
            label14.Size = new Size(160, 25);
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
            customCard4.Controls.Add(smartButton3);
            customCard4.Controls.Add(panel2);
            customCard4.Controls.Add(panel1);
            customCard4.Controls.Add(label16);
            customCard4.Location = new Point(110, 386);
            customCard4.Margin = new Padding(3, 2, 3, 2);
            customCard4.Name = "customCard4";
            customCard4.Padding = new Padding(9, 15, 9, 8);
            customCard4.Size = new Size(716, 253);
            customCard4.TabIndex = 25;
            // 
            // tbllayoutpanel_realtime_activity
            // 
            tbllayoutpanel_realtime_activity.AutoScroll = true;
            tbllayoutpanel_realtime_activity.ColumnCount = 1;
            tbllayoutpanel_realtime_activity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbllayoutpanel_realtime_activity.Controls.Add(customCard7, 0, 1);
            tbllayoutpanel_realtime_activity.Controls.Add(customCard6, 0, 0);
            tbllayoutpanel_realtime_activity.Dock = DockStyle.Fill;
            tbllayoutpanel_realtime_activity.Location = new Point(9, 52);
            tbllayoutpanel_realtime_activity.Margin = new Padding(3, 2, 3, 2);
            tbllayoutpanel_realtime_activity.Name = "tbllayoutpanel_realtime_activity";
            tbllayoutpanel_realtime_activity.Padding = new Padding(9, 15, 18, 15);
            tbllayoutpanel_realtime_activity.RowCount = 2;
            tbllayoutpanel_realtime_activity.RowStyles.Add(new RowStyle());
            tbllayoutpanel_realtime_activity.RowStyles.Add(new RowStyle());
            tbllayoutpanel_realtime_activity.Size = new Size(698, 193);
            tbllayoutpanel_realtime_activity.TabIndex = 27;
            // 
            // customCard7
            // 
            customCard7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard7.BackColor = Color.FromArgb(240, 247, 255);
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 10;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(label9);
            customCard7.Controls.Add(label17);
            customCard7.Controls.Add(label18);
            customCard7.Location = new Point(12, 98);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(665, 64);
            customCard7.TabIndex = 26;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(548, 21);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 19;
            label9.Text = "24 Students";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(32, 31);
            label17.Name = "label17";
            label17.Size = new Size(263, 20);
            label17.TabIndex = 18;
            label17.Text = "September 6, 2025 | 2:00 PM - 4:00 PM";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(13, 13, 13);
            label18.Location = new Point(32, 10);
            label18.Name = "label18";
            label18.Size = new Size(213, 20);
            label18.TabIndex = 13;
            label18.Text = "Data Structures Lab - Week 5";
            // 
            // customCard6
            // 
            customCard6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard6.BackColor = Color.FromArgb(240, 247, 255);
            customCard6.BorderColor = Color.Gray;
            customCard6.BorderRadius = 10;
            customCard6.BorderSize = 0;
            customCard6.Controls.Add(label10);
            customCard6.Controls.Add(label11);
            customCard6.Controls.Add(label13);
            customCard6.Location = new Point(12, 17);
            customCard6.Margin = new Padding(3, 2, 3, 2);
            customCard6.Name = "customCard6";
            customCard6.Size = new Size(665, 64);
            customCard6.TabIndex = 27;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(548, 21);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 19;
            label10.Text = "26 Students";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(32, 31);
            label11.Name = "label11";
            label11.Size = new Size(222, 20);
            label11.TabIndex = 18;
            label11.Text = "July 30, 2025 | 1:00 PM - 3:00 PM";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(13, 13, 13);
            label13.Location = new Point(32, 10);
            label13.Name = "label13";
            label13.Size = new Size(254, 20);
            label13.TabIndex = 13;
            label13.Text = "Object-Oriented Programming Lab ";
            // 
            // smartButton3
            // 
            smartButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton3.BackColor = Color.Silver;
            smartButton3.BackgroundColor = Color.Silver;
            smartButton3.BorderRadius = 5;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.DimGray;
            smartButton3.Location = new Point(572, 10);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(91, 28);
            smartButton3.TabIndex = 28;
            smartButton3.Text = "Export Logs";
            smartButton3.TextAlign = ContentAlignment.MiddleRight;
            smartButton3.TextColor = Color.DimGray;
            smartButton3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(9, 51);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 1);
            panel2.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(9, 40);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 11);
            panel1.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(13, 13, 13);
            label16.Location = new Point(9, 15);
            label16.Name = "label16";
            label16.Padding = new Padding(9, 0, 0, 0);
            label16.Size = new Size(134, 25);
            label16.TabIndex = 28;
            label16.Text = "Session Logs";
            // 
            // panel3
            // 
            panel3.Controls.Add(codeQualityChoices);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 117);
            panel3.TabIndex = 26;
            // 
            // codeQualityChoices
            // 
            codeQualityChoices.Location = new Point(496, 9);
            codeQualityChoices.Margin = new Padding(3, 2, 3, 2);
            codeQualityChoices.Name = "codeQualityChoices";
            codeQualityChoices.Size = new Size(201, 98);
            codeQualityChoices.TabIndex = 30;
            // 
            // TempSessionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel3);
            Controls.Add(customCard4);
            Controls.Add(customCard2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TempSessionManagement";
            Size = new Size(937, 535);
            Load += TempSessionManagement_Load;
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            tbllayoutpanel_realtime_activity.ResumeLayout(false);
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            customCard6.ResumeLayout(false);
            customCard6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Label label3;
        private GeneralComponents.CustomCard customCard2;
        private GeneralComponents.CustomCard customCard4;
        private GeneralComponents.CustomCard customCard6;
        private Label label10;
        private Label label11;
        private Label label13;
        private GeneralComponents.SmartButton smartButton3;
        private Label label16;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label14;
        private Panel panel4;
        private Panel panel7;
        private TableLayoutPanel tbllayoutpanel_realtime_activity;
        private GeneralComponents.CustomCard customCard7;
        private Label label9;
        private Label label17;
        private Label label18;
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
    }
}
