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
            txtbox_AddExerciseName = new CustomTextBox();
            label4 = new Label();
            label1 = new Label();
            cbox_AddExerciseProgrammingLanguage = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label2 = new Label();
            cbox_AddExerciseSubject = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            txtbox_AddExerciseInstruction = new CustomTextBox();
            label5 = new Label();
            btn_CancelAddExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_ConfirmAddExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customComboBox1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label3 = new Label();
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            panel7 = new Panel();
            panel_temp_spacer = new Panel();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txtbox_AddExerciseName
            // 
            txtbox_AddExerciseName.BackColor = Color.White;
            txtbox_AddExerciseName.BorderColor = Color.DarkGray;
            txtbox_AddExerciseName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddExerciseName.BorderRadius = 10;
            txtbox_AddExerciseName.BorderSize = 1;
            txtbox_AddExerciseName.ForeColor = SystemColors.ControlText;
            txtbox_AddExerciseName.Location = new Point(32, 38);
            txtbox_AddExerciseName.Name = "txtbox_AddExerciseName";
            txtbox_AddExerciseName.Padding = new Padding(10, 7, 10, 7);
            txtbox_AddExerciseName.PlaceHolderColor = Color.DarkGray;
            txtbox_AddExerciseName.PlaceholderText = "";
            txtbox_AddExerciseName.ScrollBars = ScrollBars.None;
            txtbox_AddExerciseName.Size = new Size(463, 41);
            txtbox_AddExerciseName.TabIndex = 40;
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
            // cbox_AddExerciseProgrammingLanguage
            // 
            cbox_AddExerciseProgrammingLanguage.BackColor = Color.WhiteSmoke;
            cbox_AddExerciseProgrammingLanguage.BorderColor = Color.FromArgb(224, 224, 224);
            cbox_AddExerciseProgrammingLanguage.BorderSize = 1;
            cbox_AddExerciseProgrammingLanguage.DropDownStyle = ComboBoxStyle.DropDown;
            cbox_AddExerciseProgrammingLanguage.Font = new Font("Segoe UI", 10F);
            cbox_AddExerciseProgrammingLanguage.ForeColor = Color.DimGray;
            cbox_AddExerciseProgrammingLanguage.IconColor = Color.Gray;
            cbox_AddExerciseProgrammingLanguage.ListBackColor = Color.FromArgb(230, 228, 245);
            cbox_AddExerciseProgrammingLanguage.ListTextColor = Color.DimGray;
            cbox_AddExerciseProgrammingLanguage.Location = new Point(32, 121);
            cbox_AddExerciseProgrammingLanguage.MinimumSize = new Size(200, 30);
            cbox_AddExerciseProgrammingLanguage.Name = "cbox_AddExerciseProgrammingLanguage";
            cbox_AddExerciseProgrammingLanguage.Padding = new Padding(1);
            cbox_AddExerciseProgrammingLanguage.Size = new Size(463, 38);
            cbox_AddExerciseProgrammingLanguage.TabIndex = 43;
            cbox_AddExerciseProgrammingLanguage.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 188);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 44;
            label2.Text = "Class Year";
            // 
            // cbox_AddExerciseSubject
            // 
            cbox_AddExerciseSubject.BackColor = Color.WhiteSmoke;
            cbox_AddExerciseSubject.BorderColor = Color.FromArgb(224, 224, 224);
            cbox_AddExerciseSubject.BorderSize = 1;
            cbox_AddExerciseSubject.DropDownStyle = ComboBoxStyle.DropDown;
            cbox_AddExerciseSubject.Font = new Font("Segoe UI", 10F);
            cbox_AddExerciseSubject.ForeColor = Color.DimGray;
            cbox_AddExerciseSubject.IconColor = Color.Gray;
            cbox_AddExerciseSubject.ListBackColor = Color.FromArgb(230, 228, 245);
            cbox_AddExerciseSubject.ListTextColor = Color.DimGray;
            cbox_AddExerciseSubject.Location = new Point(32, 214);
            cbox_AddExerciseSubject.MinimumSize = new Size(200, 30);
            cbox_AddExerciseSubject.Name = "cbox_AddExerciseSubject";
            cbox_AddExerciseSubject.Padding = new Padding(1);
            cbox_AddExerciseSubject.Size = new Size(245, 38);
            cbox_AddExerciseSubject.TabIndex = 45;
            cbox_AddExerciseSubject.Texts = "";
            // 
            // txtbox_AddExerciseInstruction
            // 
            txtbox_AddExerciseInstruction.BackColor = Color.White;
            txtbox_AddExerciseInstruction.BorderColor = Color.DarkGray;
            txtbox_AddExerciseInstruction.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddExerciseInstruction.BorderRadius = 10;
            txtbox_AddExerciseInstruction.BorderSize = 1;
            txtbox_AddExerciseInstruction.ForeColor = SystemColors.ControlText;
            txtbox_AddExerciseInstruction.Location = new Point(32, 299);
            txtbox_AddExerciseInstruction.Multiline = true;
            txtbox_AddExerciseInstruction.Name = "txtbox_AddExerciseInstruction";
            txtbox_AddExerciseInstruction.Padding = new Padding(10, 7, 10, 7);
            txtbox_AddExerciseInstruction.PlaceHolderColor = Color.DarkGray;
            txtbox_AddExerciseInstruction.PlaceholderText = "";
            txtbox_AddExerciseInstruction.ScrollBars = ScrollBars.None;
            txtbox_AddExerciseInstruction.Size = new Size(463, 129);
            txtbox_AddExerciseInstruction.TabIndex = 47;
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
            label5.Click += label5_Click;
            // 
            // btn_CancelAddExercise
            // 
            btn_CancelAddExercise.BackColor = Color.Transparent;
            btn_CancelAddExercise.BackgroundColor = Color.Transparent;
            btn_CancelAddExercise.BorderColor = Color.Silver;
            btn_CancelAddExercise.BorderRadius = 10;
            btn_CancelAddExercise.BorderSize = 1;
            btn_CancelAddExercise.FlatAppearance.BorderSize = 0;
            btn_CancelAddExercise.FlatStyle = FlatStyle.Flat;
            btn_CancelAddExercise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelAddExercise.ForeColor = Color.Black;
            btn_CancelAddExercise.Location = new Point(37, 635);
            btn_CancelAddExercise.Name = "btn_CancelAddExercise";
            btn_CancelAddExercise.Size = new Size(227, 50);
            btn_CancelAddExercise.TabIndex = 49;
            btn_CancelAddExercise.Text = "Cancel";
            btn_CancelAddExercise.TextColor = Color.Black;
            btn_CancelAddExercise.UseVisualStyleBackColor = false;
            btn_CancelAddExercise.Click += btn_CancelAddExercise_Click;
            // 
            // btn_ConfirmAddExercise
            // 
            btn_ConfirmAddExercise.BackColor = Color.DodgerBlue;
            btn_ConfirmAddExercise.BackgroundColor = Color.DodgerBlue;
            btn_ConfirmAddExercise.BorderRadius = 10;
            btn_ConfirmAddExercise.FlatAppearance.BorderSize = 0;
            btn_ConfirmAddExercise.FlatStyle = FlatStyle.Flat;
            btn_ConfirmAddExercise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ConfirmAddExercise.ForeColor = Color.White;
            btn_ConfirmAddExercise.Location = new Point(281, 635);
            btn_ConfirmAddExercise.Name = "btn_ConfirmAddExercise";
            btn_ConfirmAddExercise.Size = new Size(219, 50);
            btn_ConfirmAddExercise.TabIndex = 48;
            btn_ConfirmAddExercise.Text = "Create Exercise";
            btn_ConfirmAddExercise.UseVisualStyleBackColor = false;
            btn_ConfirmAddExercise.Click += btn_ConfirmAddExercise_Click;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = Color.WhiteSmoke;
            customComboBox1.BorderColor = Color.FromArgb(224, 224, 224);
            customComboBox1.BorderSize = 1;
            customComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBox1.Font = new Font("Segoe UI", 10F);
            customComboBox1.ForeColor = Color.DimGray;
            customComboBox1.IconColor = Color.Gray;
            customComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            customComboBox1.ListTextColor = Color.DimGray;
            customComboBox1.Location = new Point(295, 214);
            customComboBox1.MinimumSize = new Size(200, 30);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(1);
            customComboBox1.Size = new Size(200, 38);
            customComboBox1.TabIndex = 56;
            customComboBox1.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(295, 188);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 55;
            label3.Text = "Section";
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
            panel7.Controls.Add(txtbox_AddExerciseName);
            panel7.Controls.Add(btn_AddTestCase);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(cbox_AddExerciseProgrammingLanguage);
            panel7.Controls.Add(customComboBox1);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cbox_AddExerciseSubject);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(btn_CancelAddExercise);
            panel7.Controls.Add(txtbox_AddExerciseInstruction);
            panel7.Controls.Add(btn_ConfirmAddExercise);
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
        private CustomTextBox txtbox_AddExerciseName;
        private Label label4;
        private Label label1;
        private GeneralComponents.CustomComboBox cbox_AddExerciseProgrammingLanguage;
        private Label label2;
        private GeneralComponents.CustomComboBox cbox_AddExerciseSubject;
        private CustomTextBox txtbox_AddExerciseInstruction;
        private Label label5;
        private GeneralComponents.SmartButton btn_CancelAddExercise;
        private GeneralComponents.SmartButton btn_ConfirmAddExercise;
        private GeneralComponents.CustomComboBox customComboBox1;
        private Label label3;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private Panel panel7;
        private Panel panel_temp_spacer;
    }
}