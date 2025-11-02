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
            label3.Location = new Point(305, 32);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 13;
            label3.Text = "Session Management";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1576, 95);
            panel3.TabIndex = 26;
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
            smartButton1.Location = new Point(852, 664);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(395, 42);
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
            customCard5.Location = new Point(311, 510);
            customCard5.Margin = new Padding(3, 2, 3, 2);
            customCard5.Name = "customCard5";
            customCard5.Padding = new Padding(9, 15, 9, 8);
            customCard5.Size = new Size(471, 124);
            customCard5.TabIndex = 45;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(15, 79);
            label10.Name = "label10";
            label10.Size = new Size(318, 37);
            label10.TabIndex = 21;
            label10.Text = "Prevent students from navigating away from the session";
            // 
            // tabNavigationLocked
            // 
            tabNavigationLocked.AutoSize = true;
            tabNavigationLocked.Location = new Point(378, 47);
            tabNavigationLocked.MinimumSize = new Size(45, 22);
            tabNavigationLocked.Name = "tabNavigationLocked";
            tabNavigationLocked.OffBackColor = Color.Gray;
            tabNavigationLocked.OffToggleColor = Color.Gainsboro;
            tabNavigationLocked.OnBackColor = Color.MediumSlateBlue;
            tabNavigationLocked.OnToggleColor = Color.WhiteSmoke;
            tabNavigationLocked.Size = new Size(45, 22);
            tabNavigationLocked.TabIndex = 34;
            tabNavigationLocked.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(12, 55);
            label9.Name = "label9";
            label9.Size = new Size(166, 20);
            label9.TabIndex = 20;
            label9.Text = "Restrict Tab  Navigation";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(9, 15);
            label12.Name = "label12";
            label12.Size = new Size(173, 30);
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
            customCard2.Location = new Point(305, 102);
            customCard2.Margin = new Padding(3, 2, 3, 2);
            customCard2.Name = "customCard2";
            customCard2.Padding = new Padding(9, 15, 9, 8);
            customCard2.Size = new Size(477, 383);
            customCard2.TabIndex = 40;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.MediumSlateBlue;
            smartButton3.BorderRadius = 5;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(239, 341);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(78, 32);
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
            label4.Location = new Point(29, 38);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
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
            smartButton4.Location = new Point(355, 145);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(78, 32);
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
            serverName.Location = new Point(29, 60);
            serverName.Margin = new Padding(3, 2, 3, 2);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(9, 5, 9, 5);
            serverName.PlaceHolderColor = Color.DarkGray;
            serverName.PlaceholderText = "";
            serverName.ScrollBars = ScrollBars.None;
            serverName.Size = new Size(404, 32);
            serverName.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(29, 216);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
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
            language.Location = new Point(29, 238);
            language.Margin = new Padding(3, 2, 3, 2);
            language.MinimumSize = new Size(175, 22);
            language.Name = "language";
            language.Padding = new Padding(1);
            language.Size = new Size(398, 30);
            language.TabIndex = 28;
            language.Texts = "";
            // 
            // taskView
            // 
            taskView.BorderStyle = BorderStyle.FixedSingle;
            taskView.Location = new Point(29, 341);
            taskView.Margin = new Padding(3, 2, 3, 2);
            taskView.Name = "taskView";
            taskView.Size = new Size(204, 32);
            taskView.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(29, 312);
            label15.Name = "label15";
            label15.Size = new Size(62, 20);
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
            serverPW.Location = new Point(29, 145);
            serverPW.Margin = new Padding(3, 2, 3, 2);
            serverPW.Name = "serverPW";
            serverPW.Padding = new Padding(9, 5, 9, 5);
            serverPW.PlaceHolderColor = Color.DarkGray;
            serverPW.PlaceholderText = "";
            serverPW.ScrollBars = ScrollBars.None;
            serverPW.Size = new Size(307, 32);
            serverPW.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(29, 122);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
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
            customCard1.Location = new Point(12, 55);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(272, 35);
            customCard1.TabIndex = 43;
            // 
            // studentsCount
            // 
            studentsCount.AutoSize = true;
            studentsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentsCount.Location = new Point(75, 10);
            studentsCount.Name = "studentsCount";
            studentsCount.Size = new Size(14, 15);
            studentsCount.TabIndex = 32;
            studentsCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
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
            smartButton2.Location = new Point(290, 59);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(91, 26);
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
            customCard7.Location = new Point(852, 510);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Padding = new Padding(9, 15, 9, 8);
            customCard7.Size = new Size(395, 124);
            customCard7.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(9, 15);
            label19.Name = "label19";
            label19.Size = new Size(109, 30);
            label19.TabIndex = 19;
            label19.Text = "Other Info";
            // 
            // codeQualityChoices21
            // 
            codeQualityChoices21.BackColor = Color.White;
            codeQualityChoices21.BorderColor = Color.Gray;
            codeQualityChoices21.BorderRadius = 10;
            codeQualityChoices21.BorderSize = 0;
            codeQualityChoices21.Location = new Point(852, 102);
            codeQualityChoices21.Name = "codeQualityChoices21";
            codeQualityChoices21.Size = new Size(395, 383);
            codeQualityChoices21.TabIndex = 48;
            // 
            // TempSessionManagement2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(smartButton1);
            Controls.Add(codeQualityChoices21);
            Controls.Add(customCard7);
            Controls.Add(customCard5);
            Controls.Add(customCard2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TempSessionManagement2";
            Size = new Size(1576, 787);
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
