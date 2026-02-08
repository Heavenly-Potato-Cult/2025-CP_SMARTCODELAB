namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    partial class AddClass
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            subCode = new CustomTextBox();
            label = new Label();
            label1 = new Label();
            label5 = new Label();
            btn_CancelExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_CreateExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel7 = new Panel();
            numericUpDown = new NumericUpDown();
            studtab = new Panel();
            search = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label6 = new Label();
            label14 = new Label();
            course = new CustomTextBox();
            section = new CustomTextBox();
            label7 = new Label();
            label4 = new Label();
            yearLvl = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            label3 = new Label();
            label2 = new Label();
            semester = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            schoolYear = new CustomTextBox();
            subDesc = new CustomTextBox();
            panel_temp_spacer = new Panel();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            customCard7.SuspendLayout();
            SuspendLayout();
            // 
            // subCode
            // 
            subCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subCode.BackColor = Color.White;
            subCode.BorderColor = Color.DarkGray;
            subCode.BorderFocusColor = Color.FromArgb(64, 64, 64);
            subCode.BorderRadius = 2;
            subCode.BorderSize = 1;
            subCode.ForeColor = SystemColors.ControlText;
            subCode.Location = new Point(23, 37);
            subCode.Name = "subCode";
            subCode.Padding = new Padding(10, 7, 10, 7);
            subCode.PlaceHolderColor = Color.DarkGray;
            subCode.PlaceholderText = "";
            subCode.ScrollBars = ScrollBars.None;
            subCode.Size = new Size(206, 41);
            subCode.TabIndex = 40;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.Location = new Point(23, 12);
            label.Name = "label";
            label.Size = new Size(111, 23);
            label.TabIndex = 39;
            label.Text = "Subject Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 12);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 41;
            label1.Text = "Subject Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 99);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 46;
            label5.Text = "School Year";
            // 
            // btn_CancelExercise
            // 
            btn_CancelExercise.BackColor = Color.Transparent;
            btn_CancelExercise.BackgroundColor = Color.Transparent;
            btn_CancelExercise.BorderColor = Color.Silver;
            btn_CancelExercise.BorderRadius = 2;
            btn_CancelExercise.BorderSize = 1;
            btn_CancelExercise.FlatAppearance.BorderSize = 0;
            btn_CancelExercise.FlatStyle = FlatStyle.Flat;
            btn_CancelExercise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelExercise.ForeColor = Color.Black;
            btn_CancelExercise.Location = new Point(100, 727);
            btn_CancelExercise.Name = "btn_CancelExercise";
            btn_CancelExercise.Size = new Size(227, 51);
            btn_CancelExercise.TabIndex = 49;
            btn_CancelExercise.Text = "Cancel";
            btn_CancelExercise.TextColor = Color.Black;
            btn_CancelExercise.UseVisualStyleBackColor = false;
            btn_CancelExercise.Click += btn_CancelExercise_Click;
            // 
            // btn_CreateExercise
            // 
            btn_CreateExercise.BackColor = Color.DodgerBlue;
            btn_CreateExercise.BackgroundColor = Color.DodgerBlue;
            btn_CreateExercise.BorderRadius = 2;
            btn_CreateExercise.FlatAppearance.BorderSize = 0;
            btn_CreateExercise.FlatStyle = FlatStyle.Flat;
            btn_CreateExercise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CreateExercise.ForeColor = Color.White;
            btn_CreateExercise.Location = new Point(353, 727);
            btn_CreateExercise.Name = "btn_CreateExercise";
            btn_CreateExercise.Size = new Size(219, 51);
            btn_CreateExercise.TabIndex = 48;
            btn_CreateExercise.Text = "Create Class";
            btn_CreateExercise.UseVisualStyleBackColor = false;
            btn_CreateExercise.Click += btn_CreateExercise_Click;
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(numericUpDown);
            panel7.Controls.Add(studtab);
            panel7.Controls.Add(search);
            panel7.Controls.Add(smartButton1);
            panel7.Controls.Add(smartButton2);
            panel7.Controls.Add(customCard7);
            panel7.Controls.Add(course);
            panel7.Controls.Add(section);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(yearLvl);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(semester);
            panel7.Controls.Add(schoolYear);
            panel7.Controls.Add(subDesc);
            panel7.Controls.Add(panel_temp_spacer);
            panel7.Controls.Add(label);
            panel7.Controls.Add(subCode);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(btn_CancelExercise);
            panel7.Controls.Add(btn_CreateExercise);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(673, 827);
            panel7.TabIndex = 60;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(207, 132);
            numericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(22, 27);
            numericUpDown.TabIndex = 84;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // studtab
            // 
            studtab.AutoScroll = true;
            studtab.BorderStyle = BorderStyle.FixedSingle;
            studtab.Location = new Point(25, 422);
            studtab.Name = "studtab";
            studtab.Size = new Size(629, 240);
            studtab.TabIndex = 83;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(242, 242, 242);
            search.Location = new Point(25, 339);
            search.Name = "search";
            search.Padding = new Padding(10, 8, 10, 8);
            search.PlaceholderColor = Color.DarkGray;
            search.PlaceholderText = "Search Name";
            search.Size = new Size(290, 44);
            search.TabIndex = 82;
            search.Theme = SteamThings.SteamTheme.Light;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.SeaGreen;
            smartButton1.BackgroundColor = Color.SeaGreen;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Image = (Image)resources.GetObject("smartButton1.Image");
            smartButton1.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton1.Location = new Point(519, 339);
            smartButton1.Name = "smartButton1";
            smartButton1.Padding = new Padding(10, 0, 0, 0);
            smartButton1.Size = new Size(135, 44);
            smartButton1.TabIndex = 81;
            smartButton1.Text = " Import Files";
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.DodgerBlue;
            smartButton2.BackgroundColor = Color.DodgerBlue;
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Image = (Image)resources.GetObject("smartButton2.Image");
            smartButton2.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton2.Location = new Point(369, 339);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(10, 0, 0, 0);
            smartButton2.Size = new Size(144, 44);
            smartButton2.TabIndex = 80;
            smartButton2.Text = " Add Student";
            smartButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.Gainsboro;
            customCard7.BorderColor = Color.Black;
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(label6);
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(25, 389);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(629, 35);
            customCard7.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(298, 5);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 19;
            label6.Text = "STUDENT NAME";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(16, 5);
            label14.Name = "label14";
            label14.Size = new Size(110, 25);
            label14.TabIndex = 18;
            label14.Text = "STUDENT ID";
            // 
            // course
            // 
            course.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            course.BackColor = Color.White;
            course.BorderColor = Color.DarkGray;
            course.BorderFocusColor = Color.FromArgb(64, 64, 64);
            course.BorderRadius = 2;
            course.BorderSize = 1;
            course.ForeColor = SystemColors.ControlText;
            course.Location = new Point(27, 225);
            course.Name = "course";
            course.Padding = new Padding(10, 7, 10, 7);
            course.PlaceHolderColor = Color.DarkGray;
            course.PlaceholderText = "";
            course.ScrollBars = ScrollBars.None;
            course.Size = new Size(202, 41);
            course.TabIndex = 77;
            // 
            // section
            // 
            section.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            section.BackColor = Color.White;
            section.BorderColor = Color.DarkGray;
            section.BorderFocusColor = Color.FromArgb(64, 64, 64);
            section.BorderRadius = 2;
            section.BorderSize = 1;
            section.ForeColor = SystemColors.ControlText;
            section.Location = new Point(466, 226);
            section.Name = "section";
            section.Padding = new Padding(10, 7, 10, 7);
            section.PlaceHolderColor = Color.DarkGray;
            section.PlaceholderText = "";
            section.ScrollBars = ScrollBars.None;
            section.Size = new Size(152, 41);
            section.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(466, 199);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 75;
            label7.Text = "Section";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(292, 200);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 74;
            label4.Text = "Year Level";
            // 
            // yearLvl
            // 
            yearLvl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearLvl.BackColor = Color.FromArgb(242, 242, 242);
            yearLvl.Items.AddRange(new object[] { "1", "2", "3", "4" });
            yearLvl.Location = new Point(292, 226);
            yearLvl.Name = "yearLvl";
            yearLvl.Padding = new Padding(10, 0, 10, 0);
            yearLvl.Size = new Size(138, 41);
            yearLvl.TabIndex = 73;
            yearLvl.Theme = SteamThings.SteamTheme.Light;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 199);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 72;
            label3.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(292, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 70;
            label2.Text = "Semester";
            // 
            // semester
            // 
            semester.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            semester.BackColor = Color.FromArgb(242, 242, 242);
            semester.Items.AddRange(new object[] { "First", "Second", "Summer" });
            semester.Location = new Point(292, 123);
            semester.Name = "semester";
            semester.Padding = new Padding(10, 0, 10, 0);
            semester.Size = new Size(205, 43);
            semester.TabIndex = 69;
            semester.Theme = SteamThings.SteamTheme.Light;
            // 
            // schoolYear
            // 
            schoolYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            schoolYear.BackColor = Color.White;
            schoolYear.BorderColor = Color.DarkGray;
            schoolYear.BorderFocusColor = Color.FromArgb(64, 64, 64);
            schoolYear.BorderRadius = 2;
            schoolYear.BorderSize = 1;
            schoolYear.ForeColor = SystemColors.ControlText;
            schoolYear.Location = new Point(23, 125);
            schoolYear.Name = "schoolYear";
            schoolYear.Padding = new Padding(10, 7, 10, 7);
            schoolYear.PlaceHolderColor = Color.DarkGray;
            schoolYear.PlaceholderText = "";
            schoolYear.ScrollBars = ScrollBars.None;
            schoolYear.Size = new Size(180, 41);
            schoolYear.TabIndex = 68;
            // 
            // subDesc
            // 
            subDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subDesc.BackColor = Color.White;
            subDesc.BorderColor = Color.DarkGray;
            subDesc.BorderFocusColor = Color.FromArgb(64, 64, 64);
            subDesc.BorderRadius = 2;
            subDesc.BorderSize = 1;
            subDesc.ForeColor = SystemColors.ControlText;
            subDesc.Location = new Point(292, 38);
            subDesc.Name = "subDesc";
            subDesc.Padding = new Padding(10, 7, 10, 7);
            subDesc.PlaceHolderColor = Color.DarkGray;
            subDesc.PlaceholderText = "";
            subDesc.ScrollBars = ScrollBars.None;
            subDesc.Size = new Size(282, 41);
            subDesc.TabIndex = 62;
            // 
            // panel_temp_spacer
            // 
            panel_temp_spacer.BackColor = Color.Black;
            panel_temp_spacer.Location = new Point(215, 783);
            panel_temp_spacer.Name = "panel_temp_spacer";
            panel_temp_spacer.Size = new Size(250, 21);
            panel_temp_spacer.TabIndex = 61;
            // 
            // AddClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(673, 827);
            Controls.Add(panel7);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Exercise";
            Load += AddNewExercise_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomTextBox subCode;
        private Label label;
        private Label label1;
        private Label label5;
        private GeneralComponents.SmartButton btn_CancelExercise;
        private GeneralComponents.SmartButton btn_CreateExercise;
        private Panel panel7;
        private Panel panel_temp_spacer;
        private CustomTextBox subDesc;
        private CustomTextBox schoolYear;
        private Label label2;
        private SteamThings.SteamComboBox semester;
        private CustomTextBox course;
        private CustomTextBox section;
        private Label label7;
        private Label label4;
        private SteamThings.SteamComboBox yearLvl;
        private Label label3;
        private GeneralComponents.CustomCard customCard7;
        private Label label6;
        private Label label14;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton1;
        private SteamThings.SteamTextBox search;
        private Panel studtab;
        private NumericUpDown numericUpDown;
    }
}