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
            label12 = new Label();
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
            btnClose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            customComboBox1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label3 = new Label();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(21, 10);
            label12.Margin = new Padding(3, 10, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(191, 38);
            label12.TabIndex = 24;
            label12.Text = "Add Exercise ";
            // 
            // txtbox_AddExerciseName
            // 
            txtbox_AddExerciseName.BackColor = Color.White;
            txtbox_AddExerciseName.BorderColor = Color.DarkGray;
            txtbox_AddExerciseName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddExerciseName.BorderRadius = 10;
            txtbox_AddExerciseName.BorderSize = 1;
            txtbox_AddExerciseName.ForeColor = SystemColors.ControlText;
            txtbox_AddExerciseName.Location = new Point(34, 118);
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
            label4.Location = new Point(34, 92);
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
            label1.Location = new Point(34, 178);
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
            cbox_AddExerciseProgrammingLanguage.Location = new Point(34, 204);
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
            label2.Location = new Point(34, 270);
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
            cbox_AddExerciseSubject.Location = new Point(34, 296);
            cbox_AddExerciseSubject.MinimumSize = new Size(200, 30);
            cbox_AddExerciseSubject.Name = "cbox_AddExerciseSubject";
            cbox_AddExerciseSubject.Padding = new Padding(1);
            cbox_AddExerciseSubject.Size = new Size(225, 38);
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
            txtbox_AddExerciseInstruction.Location = new Point(34, 389);
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
            label5.Location = new Point(34, 363);
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
            btn_CancelAddExercise.Location = new Point(272, 546);
            btn_CancelAddExercise.Name = "btn_CancelAddExercise";
            btn_CancelAddExercise.Size = new Size(123, 50);
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
            btn_ConfirmAddExercise.Location = new Point(412, 546);
            btn_ConfirmAddExercise.Name = "btn_ConfirmAddExercise";
            btn_ConfirmAddExercise.Size = new Size(84, 50);
            btn_ConfirmAddExercise.TabIndex = 48;
            btn_ConfirmAddExercise.Text = "OK";
            btn_ConfirmAddExercise.UseVisualStyleBackColor = false;
            btn_ConfirmAddExercise.Click += btn_ConfirmAddExercise_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 50, 50);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(659, 6);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 42);
            btnClose.TabIndex = 25;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 1);
            panel2.TabIndex = 52;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 622);
            panel3.TabIndex = 53;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(744, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 622);
            panel4.TabIndex = 54;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(1, 622);
            panel5.Name = "panel5";
            panel5.Size = new Size(743, 1);
            panel5.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 1);
            panel1.TabIndex = 53;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(label12);
            panel6.Controls.Add(btnClose);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(1, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(743, 58);
            panel6.TabIndex = 54;
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
            customComboBox1.Location = new Point(272, 296);
            customComboBox1.MinimumSize = new Size(200, 30);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Padding = new Padding(1);
            customComboBox1.Size = new Size(225, 38);
            customComboBox1.TabIndex = 56;
            customComboBox1.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(272, 270);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 55;
            label3.Text = "Section";
            // 
            // AddNewExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(745, 623);
            Controls.Add(customComboBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_CancelAddExercise);
            Controls.Add(btn_ConfirmAddExercise);
            Controls.Add(txtbox_AddExerciseInstruction);
            Controls.Add(label5);
            Controls.Add(cbox_AddExerciseSubject);
            Controls.Add(label2);
            Controls.Add(cbox_AddExerciseProgrammingLanguage);
            Controls.Add(label1);
            Controls.Add(txtbox_AddExerciseName);
            Controls.Add(label4);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewExercise";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
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
        private Button btnClose;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel1;
        private Panel panel6;
        private GeneralComponents.CustomComboBox customComboBox1;
        private Label label3;
    }
}