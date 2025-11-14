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
            label3 = new Label();
            panel3 = new Panel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label10 = new Label();
            tabNavigationLocked = new SmartCodeLab.CustomComponents.GeneralComponents.CustomToggleButton();
            label9 = new Label();
            label12 = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label4 = new Label();
            smartButton4 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            serverName = new CustomTextBox();
            label7 = new Label();
            language = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            taskView = new Panel();
            label15 = new Label();
            serverPW = new CustomTextBox();
            label6 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            studentsCount = new Label();
            label1 = new Label();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label19 = new Label();
            codeQualityChoices21 = new SmartCodeLab.CustomComponents.GeneralComponents.CodeQualityChoices2();
            panel3.SuspendLayout();
            customCard5.SuspendLayout();
            customCard2.SuspendLayout();
            customCard1.SuspendLayout();
            customCard7.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(349, 43);
            label3.Name = "label3";
            label3.Size = new Size(297, 38);
            label3.TabIndex = 13;
            label3.Text = "Session Management";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1801, 127);
            panel3.TabIndex = 26;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            smartButton1.BackColor = Color.DarkGreen;
            smartButton1.BackgroundColor = Color.DarkGreen;
            smartButton1.BorderRadius = 5;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(974, 885);
            smartButton1.MinimumSize = new Size(451, 56);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(451, 56);
            smartButton1.TabIndex = 26;
            smartButton1.Text = "Start Session";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click_1;
            // 
            // customCard5
            // 
            customCard5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard5.BackColor = Color.White;
            customCard5.BorderColor = Color.Gray;
            customCard5.BorderRadius = 10;
            customCard5.BorderSize = 0;
            customCard5.Controls.Add(label10);
            customCard5.Controls.Add(tabNavigationLocked);
            customCard5.Controls.Add(label9);
            customCard5.Controls.Add(label12);
            customCard5.Location = new Point(355, 680);
            customCard5.MinimumSize = new Size(538, 165);
            customCard5.Name = "customCard5";
            customCard5.Padding = new Padding(10, 20, 10, 11);
            customCard5.Size = new Size(538, 165);
            customCard5.TabIndex = 45;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(17, 105);
            label10.Name = "label10";
            label10.Size = new Size(363, 49);
            label10.TabIndex = 21;
            label10.Text = "Prevent students from navigating away from the session";
            // 
            // tabNavigationLocked
            // 
            tabNavigationLocked.AutoSize = true;
            tabNavigationLocked.Location = new Point(432, 63);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(14, 73);
            label9.Name = "label9";
            label9.Size = new Size(197, 25);
            label9.TabIndex = 20;
            label9.Text = "Restrict Tab  Navigation";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(10, 20);
            label12.Name = "label12";
            label12.Size = new Size(220, 37);
            label12.TabIndex = 19;
            label12.Text = "Advance Settings";
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 0;
            customCard2.Controls.Add(smartButton3);
            customCard2.Controls.Add(label4);
            customCard2.Controls.Add(smartButton4);
            customCard2.Controls.Add(serverName);
            customCard2.Controls.Add(label7);
            customCard2.Controls.Add(language);
            customCard2.Controls.Add(taskView);
            customCard2.Controls.Add(label15);
            customCard2.Controls.Add(serverPW);
            customCard2.Controls.Add(label6);
            customCard2.Location = new Point(349, 136);
            customCard2.MinimumSize = new Size(545, 511);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(10, 20, 10, 11);
            customCard2.Size = new Size(545, 511);
            customCard2.TabIndex = 40;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.MediumSlateBlue;
            smartButton3.BorderRadius = 5;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(273, 455);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(89, 43);
            smartButton3.TabIndex = 0;
            smartButton3.Text = "Select";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(33, 51);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 17;
            label4.Text = "Session Name";
            // 
            // smartButton4
            // 
            smartButton4.BackColor = Color.MediumSlateBlue;
            smartButton4.BorderRadius = 5;
            smartButton4.FlatAppearance.BorderSize = 0;
            smartButton4.FlatStyle = FlatStyle.Flat;
            smartButton4.ForeColor = Color.White;
            smartButton4.Location = new Point(406, 193);
            smartButton4.Margin = new Padding(3, 4, 3, 4);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(89, 43);
            smartButton4.TabIndex = 33;
            smartButton4.Text = "Generate";
            smartButton4.UseVisualStyleBackColor = false;
            smartButton4.Click += smartButton4_Click_1;
            // 
            // serverName
            // 
            serverName.BackColor = Color.White;
            serverName.BorderColor = Color.LightGray;
            serverName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            serverName.BorderRadius = 5;
            serverName.BorderSize = 1;
            serverName.ForeColor = SystemColors.ControlText;
            serverName.Location = new Point(33, 80);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(10, 7, 10, 7);
            serverName.PlaceHolderColor = Color.DarkGray;
            serverName.PlaceholderText = "";
            serverName.ScrollBars = ScrollBars.None;
            serverName.Size = new Size(462, 41);
            serverName.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(33, 288);
            label7.Name = "label7";
            label7.Size = new Size(204, 25);
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
            language.Location = new Point(33, 317);
            language.MinimumSize = new Size(200, 29);
            language.Name = "language";
            language.Padding = new Padding(1);
            language.Size = new Size(455, 40);
            language.TabIndex = 28;
            language.Texts = "";
            language.OnSelectedIndexChanged += language_OnSelectedIndexChanged;
            // 
            // taskView
            // 
            taskView.BorderStyle = BorderStyle.FixedSingle;
            taskView.Location = new Point(33, 455);
            taskView.Name = "taskView";
            taskView.Size = new Size(233, 42);
            taskView.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(33, 416);
            label15.Name = "label15";
            label15.Size = new Size(73, 25);
            label15.TabIndex = 25;
            label15.Text = "Exercise";
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
            serverPW.Location = new Point(33, 193);
            serverPW.Name = "serverPW";
            serverPW.Padding = new Padding(10, 7, 10, 7);
            serverPW.PlaceHolderColor = Color.DarkGray;
            serverPW.PlaceholderText = "";
            serverPW.ScrollBars = ScrollBars.None;
            serverPW.Size = new Size(351, 41);
            serverPW.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(33, 163);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 19;
            label6.Text = "Session Code";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 5;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(studentsCount);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(14, 73);
            customCard1.Margin = new Padding(3, 4, 3, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(311, 47);
            customCard1.TabIndex = 43;
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
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 12;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(331, 79);
            smartButton2.Margin = new Padding(3, 4, 3, 4);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(104, 35);
            smartButton2.TabIndex = 33;
            smartButton2.Text = "View";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // customCard7
            // 
            customCard7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customCard7.BackColor = Color.White;
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 10;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(smartButton2);
            customCard7.Controls.Add(label19);
            customCard7.Controls.Add(customCard1);
            customCard7.Location = new Point(974, 680);
            customCard7.MinimumSize = new Size(451, 165);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(10, 20, 10, 11);
            customCard7.Size = new Size(451, 165);
            customCard7.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(10, 20);
            label19.Name = "label19";
            label19.Size = new Size(137, 37);
            label19.TabIndex = 19;
            label19.Text = "Other Info";
            // 
            // codeQualityChoices21
            // 
            codeQualityChoices21.BackColor = Color.White;
            codeQualityChoices21.BorderColor = Color.Gray;
            codeQualityChoices21.BorderRadius = 10;
            codeQualityChoices21.BorderSize = 0;
            codeQualityChoices21.Location = new Point(974, 136);
            codeQualityChoices21.Margin = new Padding(3, 5, 3, 5);
            codeQualityChoices21.MinimumSize = new Size(451, 511);
            codeQualityChoices21.Name = "codeQualityChoices21";
            codeQualityChoices21.Size = new Size(451, 511);
            codeQualityChoices21.TabIndex = 48;
            // 
            // TempSessionManagement2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(smartButton1);
            Controls.Add(codeQualityChoices21);
            Controls.Add(customCard7);
            Controls.Add(customCard5);
            Controls.Add(customCard2);
            Controls.Add(panel3);
            Name = "TempSessionManagement2";
            Size = new Size(1801, 1049);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            customCard5.ResumeLayout(false);
            customCard5.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
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
        private CustomTextBox serverName;
        private Label label7;
        private GeneralComponents.CustomComboBox language;
        private Panel taskView;
        private Label label15;
        private CustomTextBox serverPW;
        private Label label6;
        private GeneralComponents.CustomCard customCard1;
        private GeneralComponents.SmartButton smartButton2;
        private Label studentsCount;
        private Label label1;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.CustomCard customCard7;
        private Label label19;
        private GeneralComponents.CodeQualityChoices2 codeQualityChoices21;
    }
}
