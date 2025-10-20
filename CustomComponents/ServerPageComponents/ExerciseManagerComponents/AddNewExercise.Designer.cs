namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class AddNewExercise
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
            txtbox_ExerciseTitle = new CustomTextBox();
            label4 = new Label();
            label1 = new Label();
            cbox_ExerciseProgrammingLanguage = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label2 = new Label();
            cbox_ExerciseCourse = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            txtbox_ExerciseInstruction = new CustomTextBox();
            label5 = new Label();
            btn_CancelExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_CreateExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            cbox_ExerciseYearAndSection = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label3 = new Label();
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            panel7 = new Panel();
            panel_temp_spacer = new Panel();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txtbox_ExerciseTitle
            // 
            txtbox_ExerciseTitle.BackColor = Color.White;
            txtbox_ExerciseTitle.BorderColor = Color.DarkGray;
            txtbox_ExerciseTitle.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_ExerciseTitle.BorderRadius = 10;
            txtbox_ExerciseTitle.BorderSize = 1;
            txtbox_ExerciseTitle.ForeColor = SystemColors.ControlText;
            txtbox_ExerciseTitle.Location = new Point(32, 38);
            txtbox_ExerciseTitle.Name = "txtbox_ExerciseTitle";
            txtbox_ExerciseTitle.Padding = new Padding(10, 7, 10, 7);
            txtbox_ExerciseTitle.PlaceHolderColor = Color.DarkGray;
            txtbox_ExerciseTitle.PlaceholderText = "";
            txtbox_ExerciseTitle.ScrollBars = ScrollBars.None;
            txtbox_ExerciseTitle.Size = new Size(463, 41);
            txtbox_ExerciseTitle.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(32, 12);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 39;
            label4.Text = "Exercise Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 95);
            label1.Name = "label1";
            label1.Size = new Size(195, 23);
            label1.TabIndex = 41;
            label1.Text = "Programming Language";
            // 
            // cbox_ExerciseProgrammingLanguage
            // 
            cbox_ExerciseProgrammingLanguage.BackColor = Color.WhiteSmoke;
            cbox_ExerciseProgrammingLanguage.BorderColor = Color.FromArgb(224, 224, 224);
            cbox_ExerciseProgrammingLanguage.BorderSize = 1;
            cbox_ExerciseProgrammingLanguage.DropDownStyle = ComboBoxStyle.DropDown;
            cbox_ExerciseProgrammingLanguage.Font = new Font("Segoe UI", 10F);
            cbox_ExerciseProgrammingLanguage.ForeColor = Color.DimGray;
            cbox_ExerciseProgrammingLanguage.IconColor = Color.Gray;
            cbox_ExerciseProgrammingLanguage.Items.AddRange(new object[] { "Java", "C++", "Python", "None" });
            cbox_ExerciseProgrammingLanguage.ListBackColor = Color.FromArgb(230, 228, 245);
            cbox_ExerciseProgrammingLanguage.ListTextColor = Color.DimGray;
            cbox_ExerciseProgrammingLanguage.Location = new Point(32, 121);
            cbox_ExerciseProgrammingLanguage.MinimumSize = new Size(200, 30);
            cbox_ExerciseProgrammingLanguage.Name = "cbox_ExerciseProgrammingLanguage";
            cbox_ExerciseProgrammingLanguage.Padding = new Padding(1);
            cbox_ExerciseProgrammingLanguage.Size = new Size(463, 38);
            cbox_ExerciseProgrammingLanguage.TabIndex = 43;
            cbox_ExerciseProgrammingLanguage.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 188);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 44;
            label2.Text = "Class Course";
            // 
            // cbox_ExerciseCourse
            // 
            cbox_ExerciseCourse.BackColor = Color.WhiteSmoke;
            cbox_ExerciseCourse.BorderColor = Color.FromArgb(224, 224, 224);
            cbox_ExerciseCourse.BorderSize = 1;
            cbox_ExerciseCourse.DropDownStyle = ComboBoxStyle.DropDown;
            cbox_ExerciseCourse.Font = new Font("Segoe UI", 10F);
            cbox_ExerciseCourse.ForeColor = Color.DimGray;
            cbox_ExerciseCourse.IconColor = Color.Gray;
            cbox_ExerciseCourse.Items.AddRange(new object[] { "None", "BSIT", "BSCS" });
            cbox_ExerciseCourse.ListBackColor = Color.FromArgb(230, 228, 245);
            cbox_ExerciseCourse.ListTextColor = Color.DimGray;
            cbox_ExerciseCourse.Location = new Point(32, 214);
            cbox_ExerciseCourse.MinimumSize = new Size(200, 30);
            cbox_ExerciseCourse.Name = "cbox_ExerciseCourse";
            cbox_ExerciseCourse.Padding = new Padding(1);
            cbox_ExerciseCourse.Size = new Size(245, 38);
            cbox_ExerciseCourse.TabIndex = 45;
            cbox_ExerciseCourse.Texts = "";
            // 
            // txtbox_ExerciseInstruction
            // 
            txtbox_ExerciseInstruction.BackColor = Color.White;
            txtbox_ExerciseInstruction.BorderColor = Color.DarkGray;
            txtbox_ExerciseInstruction.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_ExerciseInstruction.BorderRadius = 10;
            txtbox_ExerciseInstruction.BorderSize = 1;
            txtbox_ExerciseInstruction.ForeColor = SystemColors.ControlText;
            txtbox_ExerciseInstruction.Location = new Point(32, 299);
            txtbox_ExerciseInstruction.Multiline = true;
            txtbox_ExerciseInstruction.Name = "txtbox_ExerciseInstruction";
            txtbox_ExerciseInstruction.Padding = new Padding(10, 7, 10, 7);
            txtbox_ExerciseInstruction.PlaceHolderColor = Color.DarkGray;
            txtbox_ExerciseInstruction.PlaceholderText = "";
            txtbox_ExerciseInstruction.ScrollBars = ScrollBars.None;
            txtbox_ExerciseInstruction.Size = new Size(463, 129);
            txtbox_ExerciseInstruction.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 273);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 46;
            label5.Text = "Instruction";
            // 
            // btn_CancelExercise
            // 
            btn_CancelExercise.BackColor = Color.Transparent;
            btn_CancelExercise.BackgroundColor = Color.Transparent;
            btn_CancelExercise.BorderColor = Color.Silver;
            btn_CancelExercise.BorderRadius = 10;
            btn_CancelExercise.BorderSize = 1;
            btn_CancelExercise.FlatAppearance.BorderSize = 0;
            btn_CancelExercise.FlatStyle = FlatStyle.Flat;
            btn_CancelExercise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelExercise.ForeColor = Color.Black;
            btn_CancelExercise.Location = new Point(37, 635);
            btn_CancelExercise.Name = "btn_CancelExercise";
            btn_CancelExercise.Size = new Size(227, 50);
            btn_CancelExercise.TabIndex = 49;
            btn_CancelExercise.Text = "Cancel";
            btn_CancelExercise.TextColor = Color.Black;
            btn_CancelExercise.UseVisualStyleBackColor = false;
            // 
            // btn_CreateExercise
            // 
            btn_CreateExercise.BackColor = Color.DodgerBlue;
            btn_CreateExercise.BackgroundColor = Color.DodgerBlue;
            btn_CreateExercise.BorderRadius = 10;
            btn_CreateExercise.FlatAppearance.BorderSize = 0;
            btn_CreateExercise.FlatStyle = FlatStyle.Flat;
            btn_CreateExercise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CreateExercise.ForeColor = Color.White;
            btn_CreateExercise.Location = new Point(281, 635);
            btn_CreateExercise.Name = "btn_CreateExercise";
            btn_CreateExercise.Size = new Size(219, 50);
            btn_CreateExercise.TabIndex = 48;
            btn_CreateExercise.Text = "Create Exercise";
            btn_CreateExercise.UseVisualStyleBackColor = false;
            btn_CreateExercise.Click += btn_CreateExercise_Click;
            // 
            // cbox_ExerciseYearAndSection
            // 
            cbox_ExerciseYearAndSection.BackColor = Color.WhiteSmoke;
            cbox_ExerciseYearAndSection.BorderColor = Color.FromArgb(224, 224, 224);
            cbox_ExerciseYearAndSection.BorderSize = 1;
            cbox_ExerciseYearAndSection.DropDownStyle = ComboBoxStyle.DropDown;
            cbox_ExerciseYearAndSection.Font = new Font("Segoe UI", 10F);
            cbox_ExerciseYearAndSection.ForeColor = Color.DimGray;
            cbox_ExerciseYearAndSection.IconColor = Color.Gray;
            cbox_ExerciseYearAndSection.Items.AddRange(new object[] { "None", "1A", "1B", "1C", "2A", "2B", "2C" });
            cbox_ExerciseYearAndSection.ListBackColor = Color.FromArgb(230, 228, 245);
            cbox_ExerciseYearAndSection.ListTextColor = Color.DimGray;
            cbox_ExerciseYearAndSection.Location = new Point(295, 214);
            cbox_ExerciseYearAndSection.MinimumSize = new Size(200, 30);
            cbox_ExerciseYearAndSection.Name = "cbox_ExerciseYearAndSection";
            cbox_ExerciseYearAndSection.Padding = new Padding(1);
            cbox_ExerciseYearAndSection.Size = new Size(200, 38);
            cbox_ExerciseYearAndSection.TabIndex = 56;
            cbox_ExerciseYearAndSection.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(295, 188);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 55;
            label3.Text = "Year and Section";
            // 
            // btn_AddTestCase
            // 
            btn_AddTestCase.BackColor = Color.MediumSlateBlue;
            btn_AddTestCase.BorderRadius = 10;
            btn_AddTestCase.FlatAppearance.BorderSize = 0;
            btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            btn_AddTestCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_AddTestCase.ForeColor = Color.White;
            btn_AddTestCase.Location = new Point(392, 451);
            btn_AddTestCase.Name = "btn_AddTestCase";
            btn_AddTestCase.Size = new Size(108, 32);
            btn_AddTestCase.TabIndex = 57;
            btn_AddTestCase.Text = "Add";
            btn_AddTestCase.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(37, 486);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(463, 125);
            flowLayoutPanel1.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(37, 460);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 59;
            label6.Text = "Test Cases";
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel_temp_spacer);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(flowLayoutPanel1);
            panel7.Controls.Add(txtbox_ExerciseTitle);
            panel7.Controls.Add(btn_AddTestCase);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(cbox_ExerciseProgrammingLanguage);
            panel7.Controls.Add(cbox_ExerciseYearAndSection);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cbox_ExerciseCourse);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(btn_CancelExercise);
            panel7.Controls.Add(txtbox_ExerciseInstruction);
            panel7.Controls.Add(btn_CreateExercise);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(559, 519);
            panel7.TabIndex = 60;
            // 
            // panel_temp_spacer
            // 
            panel_temp_spacer.BackColor = Color.Black;
            panel_temp_spacer.Location = new Point(146, 691);
            panel_temp_spacer.Name = "panel_temp_spacer";
            panel_temp_spacer.Size = new Size(250, 21);
            panel_temp_spacer.TabIndex = 61;
            // 
            // AddNewExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(559, 519);
            Controls.Add(panel7);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddNewExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Exercise";
            Load += AddNewExercise_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomTextBox txtbox_ExerciseTitle;
        private Label label4;
        private Label label1;
        private GeneralComponents.CustomComboBox cbox_ExerciseProgrammingLanguage;
        private Label label2;
        private GeneralComponents.CustomComboBox cbox_ExerciseCourse;
        private CustomTextBox txtbox_ExerciseInstruction;
        private Label label5;
        private GeneralComponents.SmartButton btn_CancelExercise;
        private GeneralComponents.SmartButton btn_CreateExercise;
        private GeneralComponents.CustomComboBox cbox_ExerciseYearAndSection;
        private Label label3;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private Panel panel7;
        private Panel panel_temp_spacer;
    }
}