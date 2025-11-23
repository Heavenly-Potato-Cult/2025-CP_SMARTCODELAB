namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempSessionManagement2
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
            panel3 = new Panel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            panel2 = new Panel();
            tabNavigationLocked = new SmartCodeLab.CustomComponents.GeneralComponents.CustomToggleButton();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            taskView = new Panel();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            studentsCount = new Label();
            label1 = new Label();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label19 = new Label();
            codeQualityChoices21 = new SmartCodeLab.CustomComponents.GeneralComponents.CodeQualityChoices2();
            tableLayoutPanel1 = new TableLayoutPanel();
            steamCard1 = new SmartCodeLab.CustomComponents.SteamThings.SteamCard();
            serverName = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            language = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            steamLabel5 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel4 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panel4 = new Panel();
            serverPW = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            smartButton5 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            panel3.SuspendLayout();
            customCard5.SuspendLayout();
            panel2.SuspendLayout();
            customCard1.SuspendLayout();
            customCard7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            steamCard1.SuspendLayout();
            panel4.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(steamLabel3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1801, 82);
            panel3.TabIndex = 26;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(302, 25);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(338, 32);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 41;
            steamLabel3.Text = "SESSION MANAGEMENT";
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            smartButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            smartButton1.BackColor = Color.DarkGreen;
            smartButton1.BackgroundColor = Color.DarkGreen;
            smartButton1.BorderRadius = 5;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(640, 744);
            smartButton1.Margin = new Padding(20, 2, 2, 2);
            smartButton1.MinimumSize = new Size(451, 56);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(578, 56);
            smartButton1.TabIndex = 26;
            smartButton1.Text = "Start Session";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click_1;
            // 
            // customCard5
            // 
            customCard5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customCard5.BackColor = Color.White;
            customCard5.BorderColor = Color.Gray;
            customCard5.BorderRadius = 10;
            customCard5.BorderSize = 0;
            customCard5.Controls.Add(panel2);
            customCard5.Controls.Add(label12);
            customCard5.Location = new Point(22, 557);
            customCard5.Margin = new Padding(2, 2, 20, 20);
            customCard5.MinimumSize = new Size(416, 165);
            customCard5.Name = "customCard5";
            customCard5.Padding = new Padding(10, 20, 10, 11);
            customCard5.Size = new Size(578, 165);
            customCard5.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tabNavigationLocked);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(14, 61);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 12, 12, 12);
            panel2.Size = new Size(550, 89);
            panel2.TabIndex = 35;
            // 
            // tabNavigationLocked
            // 
            tabNavigationLocked.Anchor = AnchorStyles.Right;
            tabNavigationLocked.AutoSize = true;
            tabNavigationLocked.Location = new Point(484, 26);
            tabNavigationLocked.Margin = new Padding(2, 25, 2, 4);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 13.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(0, 12);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(255, 31);
            label9.TabIndex = 20;
            label9.Text = "Restrict Tab  Navigation";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(2, 36);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(422, 49);
            label10.TabIndex = 21;
            label10.Text = "Prevent students from navigating away from the session";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 19.6875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(10, 20);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(270, 45);
            label12.TabIndex = 19;
            label12.Text = "Advance Settings";
            // 
            // smartButton3
            // 
            smartButton3.Anchor = AnchorStyles.Right;
            smartButton3.BackColor = Color.MediumSlateBlue;
            smartButton3.BorderRadius = 5;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(368, 404);
            smartButton3.Margin = new Padding(2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(90, 42);
            smartButton3.TabIndex = 0;
            smartButton3.Text = "Select";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click_1;
            // 
            // taskView
            // 
            taskView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            taskView.BorderStyle = BorderStyle.FixedSingle;
            taskView.Location = new Point(53, 404);
            taskView.Margin = new Padding(2);
            taskView.Name = "taskView";
            taskView.Size = new Size(308, 42);
            taskView.TabIndex = 37;
            // 
            // customCard1
            // 
            customCard1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 5;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(smartButton2);
            customCard1.Controls.Add(studentsCount);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(14, 72);
            customCard1.Margin = new Padding(2, 4, 2, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(552, 48);
            customCard1.TabIndex = 43;
            // 
            // smartButton2
            // 
            smartButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 12;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(439, 8);
            smartButton2.Margin = new Padding(2, 4, 2, 4);
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
            studentsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentsCount.Location = new Point(86, 12);
            studentsCount.Margin = new Padding(2, 0, 2, 0);
            studentsCount.Name = "studentsCount";
            studentsCount.Size = new Size(23, 25);
            studentsCount.TabIndex = 32;
            studentsCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 31;
            label1.Text = "Students";
            // 
            // customCard7
            // 
            customCard7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customCard7.BackColor = Color.White;
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 10;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(label19);
            customCard7.Controls.Add(customCard1);
            customCard7.Location = new Point(640, 557);
            customCard7.Margin = new Padding(20, 2, 2, 2);
            customCard7.MinimumSize = new Size(451, 165);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(10, 20, 10, 11);
            customCard7.Size = new Size(578, 165);
            customCard7.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 19.6875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(10, 20);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(169, 45);
            label19.TabIndex = 19;
            label19.Text = "Other Info";
            // 
            // codeQualityChoices21
            // 
            codeQualityChoices21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            codeQualityChoices21.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeQualityChoices21.BackColor = Color.White;
            codeQualityChoices21.BorderColor = Color.Gray;
            codeQualityChoices21.BorderRadius = 10;
            codeQualityChoices21.BorderSize = 0;
            codeQualityChoices21.Location = new Point(639, 5);
            codeQualityChoices21.Margin = new Padding(19, 5, 2, 5);
            codeQualityChoices21.Name = "codeQualityChoices21";
            codeQualityChoices21.Size = new Size(579, 545);
            codeQualityChoices21.TabIndex = 48;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(codeQualityChoices21, 1, 0);
            tableLayoutPanel1.Controls.Add(steamCard1, 0, 0);
            tableLayoutPanel1.Controls.Add(smartButton1, 1, 2);
            tableLayoutPanel1.Controls.Add(customCard7, 1, 1);
            tableLayoutPanel1.Controls.Add(customCard5, 0, 1);
            tableLayoutPanel1.Location = new Point(280, 132);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 0, 20, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1240, 811);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // steamCard1
            // 
            steamCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            steamCard1.BackColor = Color.Transparent;
            steamCard1.Controls.Add(serverName);
            steamCard1.Controls.Add(language);
            steamCard1.Controls.Add(steamLabel5);
            steamCard1.Controls.Add(steamLabel4);
            steamCard1.Controls.Add(smartButton3);
            steamCard1.Controls.Add(steamLabel2);
            steamCard1.Controls.Add(panel4);
            steamCard1.Controls.Add(steamLabel1);
            steamCard1.Controls.Add(taskView);
            steamCard1.Location = new Point(23, 3);
            steamCard1.Margin = new Padding(3, 3, 20, 3);
            steamCard1.MinimumSize = new Size(416, 511);
            steamCard1.Name = "steamCard1";
            steamCard1.Padding = new Padding(20);
            steamCard1.Size = new Size(577, 511);
            steamCard1.TabIndex = 50;
            // 
            // serverName
            // 
            serverName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            serverName.BackColor = Color.FromArgb(26, 30, 36);
            serverName.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serverName.ForeColor = Color.Red;
            serverName.Location = new Point(56, 71);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(10, 10, 10, 8);
            serverName.PlaceholderText = "";
            serverName.Size = new Size(467, 44);
            serverName.TabIndex = 45;
            // 
            // language
            // 
            language.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            language.BackColor = Color.FromArgb(26, 30, 36);
            language.Items.AddRange(new object[] { "C++", "Java", "Python" });
            language.Location = new Point(56, 297);
            language.Name = "language";
            language.Padding = new Padding(10, 0, 10, 0);
            language.SelectedIndex = -1;
            language.SelectedItem = null;
            language.Size = new Size(467, 44);
            language.TabIndex = 44;
            // 
            // steamLabel5
            // 
            steamLabel5.AutoSize = true;
            steamLabel5.BackColor = Color.Transparent;
            steamLabel5.Font = new Font("Geist", 12F);
            steamLabel5.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel5.Location = new Point(53, 374);
            steamLabel5.Margin = new Padding(3, 0, 3, 5);
            steamLabel5.Name = "steamLabel5";
            steamLabel5.Size = new Size(85, 23);
            steamLabel5.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel5.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel5.TabIndex = 43;
            steamLabel5.Text = "Exercise";
            // 
            // steamLabel4
            // 
            steamLabel4.AutoSize = true;
            steamLabel4.BackColor = Color.Transparent;
            steamLabel4.Font = new Font("Geist", 12F);
            steamLabel4.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel4.Location = new Point(53, 266);
            steamLabel4.Margin = new Padding(3, 0, 3, 5);
            steamLabel4.Name = "steamLabel4";
            steamLabel4.Size = new Size(219, 23);
            steamLabel4.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel4.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel4.TabIndex = 42;
            steamLabel4.Text = "Programming Language";
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel2.Location = new Point(53, 150);
            steamLabel2.Margin = new Padding(3, 0, 3, 5);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(132, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel2.TabIndex = 40;
            steamLabel2.Text = "Session Code";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(serverPW);
            panel4.Controls.Add(smartButton5);
            panel4.Location = new Point(56, 180);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(467, 44);
            panel4.TabIndex = 39;
            // 
            // serverPW
            // 
            serverPW.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            serverPW.BackColor = Color.FromArgb(26, 30, 36);
            serverPW.Location = new Point(0, 0);
            serverPW.Name = "serverPW";
            serverPW.Padding = new Padding(10, 8, 10, 8);
            serverPW.PlaceholderText = "";
            serverPW.Size = new Size(369, 44);
            serverPW.TabIndex = 46;
            // 
            // smartButton5
            // 
            smartButton5.BackColor = Color.FromArgb(42, 71, 94);
            smartButton5.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton5.BorderRadius = 1;
            smartButton5.Dock = DockStyle.Right;
            smartButton5.FlatAppearance.BorderSize = 0;
            smartButton5.FlatStyle = FlatStyle.Flat;
            smartButton5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton5.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton5.Location = new Point(378, 0);
            smartButton5.Margin = new Padding(2, 4, 2, 4);
            smartButton5.Name = "smartButton5";
            smartButton5.Size = new Size(89, 44);
            smartButton5.TabIndex = 33;
            smartButton5.Text = "GENERATE";
            smartButton5.TextColor = Color.FromArgb(199, 213, 224);
            smartButton5.UseVisualStyleBackColor = false;
            smartButton5.Click += smartButton5_Click;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 12F);
            steamLabel1.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel1.Location = new Point(53, 43);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(136, 23);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel1.TabIndex = 2;
            steamLabel1.Text = "Session Name";
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(tableLayoutPanel1);
            steamGradientPanel1.Controls.Add(panel3);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Margin = new Padding(2);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1801, 1049);
            steamGradientPanel1.TabIndex = 50;
            // 
            // TempSessionManagement2
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            Controls.Add(steamGradientPanel1);
            Margin = new Padding(2);
            Name = "TempSessionManagement2";
            Size = new Size(1801, 1049);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            customCard5.ResumeLayout(false);
            customCard5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            steamCard1.ResumeLayout(false);
            steamCard1.PerformLayout();
            panel4.ResumeLayout(false);
            steamGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private GeneralComponents.CustomCard customCard5;
        private Label label10;
        private Label label9;
        private Label label12;
        private GeneralComponents.CustomToggleButton tabNavigationLocked;
        private GeneralComponents.CustomCard customCard2;
        private GeneralComponents.SmartButton smartButton3;
        private Label label4;
        private GeneralComponents.SmartButton smartButton4;
        private Label label7;
        private Panel taskView;
        private Label label15;
        private Label label6;
        private GeneralComponents.CustomCard customCard1;
        private GeneralComponents.SmartButton smartButton2;
        private Label studentsCount;
        private Label label1;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.CustomCard customCard7;
        private Label label19;
        private GeneralComponents.CodeQualityChoices2 codeQualityChoices21;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private SteamThings.SteamCard steamCard1;
        private SteamThings.SteamTextBox serverName;
        private SteamThings.SteamTextBox serverPW;
        private Panel panel4;
        private GeneralComponents.SmartButton smartButton5;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamLabel steamLabel4;
        private SteamThings.SteamLabel steamLabel5;
        private SteamThings.SteamComboBox language;
    }
}
