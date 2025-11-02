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
            txtbox_ExerciseInstruction = new CustomTextBox();
            label5 = new Label();
            btn_CancelExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_CreateExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            testCasesContainer = new FlowLayoutPanel();
            label6 = new Label();
            panel7 = new Panel();
            subject = new CustomTextBox();
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
            txtbox_ExerciseTitle.Location = new Point(20, 28);
            txtbox_ExerciseTitle.Margin = new Padding(3, 2, 3, 2);
            txtbox_ExerciseTitle.Name = "txtbox_ExerciseTitle";
            txtbox_ExerciseTitle.Padding = new Padding(9, 5, 9, 5);
            txtbox_ExerciseTitle.PlaceHolderColor = Color.DarkGray;
            txtbox_ExerciseTitle.PlaceholderText = "";
            txtbox_ExerciseTitle.ScrollBars = ScrollBars.None;
            txtbox_ExerciseTitle.Size = new Size(429, 32);
            txtbox_ExerciseTitle.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 9);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 39;
            label4.Text = "Exercise Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 41;
            label1.Text = "Subject";
            // 
            // txtbox_ExerciseInstruction
            // 
            txtbox_ExerciseInstruction.BackColor = Color.White;
            txtbox_ExerciseInstruction.BorderColor = Color.DarkGray;
            txtbox_ExerciseInstruction.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_ExerciseInstruction.BorderRadius = 10;
            txtbox_ExerciseInstruction.BorderSize = 1;
            txtbox_ExerciseInstruction.ForeColor = SystemColors.ControlText;
            txtbox_ExerciseInstruction.Location = new Point(20, 154);
            txtbox_ExerciseInstruction.Margin = new Padding(3, 2, 3, 2);
            txtbox_ExerciseInstruction.Multiline = true;
            txtbox_ExerciseInstruction.Name = "txtbox_ExerciseInstruction";
            txtbox_ExerciseInstruction.Padding = new Padding(9, 5, 9, 5);
            txtbox_ExerciseInstruction.PlaceHolderColor = Color.DarkGray;
            txtbox_ExerciseInstruction.PlaceholderText = "";
            txtbox_ExerciseInstruction.ScrollBars = ScrollBars.None;
            txtbox_ExerciseInstruction.Size = new Size(429, 97);
            txtbox_ExerciseInstruction.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 135);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
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
            btn_CancelExercise.Location = new Point(32, 425);
            btn_CancelExercise.Margin = new Padding(3, 2, 3, 2);
            btn_CancelExercise.Name = "btn_CancelExercise";
            btn_CancelExercise.Size = new Size(199, 38);
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
            btn_CreateExercise.BorderRadius = 10;
            btn_CreateExercise.FlatAppearance.BorderSize = 0;
            btn_CreateExercise.FlatStyle = FlatStyle.Flat;
            btn_CreateExercise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CreateExercise.ForeColor = Color.White;
            btn_CreateExercise.Location = new Point(246, 425);
            btn_CreateExercise.Margin = new Padding(3, 2, 3, 2);
            btn_CreateExercise.Name = "btn_CreateExercise";
            btn_CreateExercise.Size = new Size(192, 38);
            btn_CreateExercise.TabIndex = 48;
            btn_CreateExercise.Text = "Create Exercise";
            btn_CreateExercise.UseVisualStyleBackColor = false;
            btn_CreateExercise.Click += btn_CreateExercise_Click;
            // 
            // btn_AddTestCase
            // 
            btn_AddTestCase.BackColor = Color.MediumSlateBlue;
            btn_AddTestCase.BorderRadius = 10;
            btn_AddTestCase.FlatAppearance.BorderSize = 0;
            btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            btn_AddTestCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_AddTestCase.ForeColor = Color.White;
            btn_AddTestCase.Location = new Point(355, 258);
            btn_AddTestCase.Margin = new Padding(3, 2, 3, 2);
            btn_AddTestCase.Name = "btn_AddTestCase";
            btn_AddTestCase.Size = new Size(94, 30);
            btn_AddTestCase.TabIndex = 57;
            btn_AddTestCase.Text = "Add";
            btn_AddTestCase.UseVisualStyleBackColor = false;
            btn_AddTestCase.Click += btn_AddTestCase_Click;
            // 
            // testCasesContainer
            // 
            testCasesContainer.AutoScroll = true;
            testCasesContainer.BorderStyle = BorderStyle.FixedSingle;
            testCasesContainer.FlowDirection = FlowDirection.TopDown;
            testCasesContainer.Location = new Point(20, 289);
            testCasesContainer.Margin = new Padding(3, 2, 3, 2);
            testCasesContainer.Name = "testCasesContainer";
            testCasesContainer.Size = new Size(429, 121);
            testCasesContainer.TabIndex = 58;
            testCasesContainer.WrapContents = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(24, 269);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 59;
            label6.Text = "Test Cases";
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(subject);
            panel7.Controls.Add(panel_temp_spacer);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(testCasesContainer);
            panel7.Controls.Add(txtbox_ExerciseTitle);
            panel7.Controls.Add(btn_AddTestCase);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(btn_CancelExercise);
            panel7.Controls.Add(txtbox_ExerciseInstruction);
            panel7.Controls.Add(btn_CreateExercise);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(469, 491);
            panel7.TabIndex = 60;
            // 
            // subject
            // 
            subject.BackColor = Color.White;
            subject.BorderColor = Color.DarkGray;
            subject.BorderFocusColor = Color.FromArgb(64, 64, 64);
            subject.BorderRadius = 10;
            subject.BorderSize = 1;
            subject.ForeColor = SystemColors.ControlText;
            subject.Location = new Point(20, 91);
            subject.Margin = new Padding(3, 2, 3, 2);
            subject.Name = "subject";
            subject.Padding = new Padding(9, 5, 9, 5);
            subject.PlaceHolderColor = Color.DarkGray;
            subject.PlaceholderText = "";
            subject.ScrollBars = ScrollBars.None;
            subject.Size = new Size(429, 32);
            subject.TabIndex = 62;
            // 
            // panel_temp_spacer
            // 
            panel_temp_spacer.BackColor = Color.Black;
            panel_temp_spacer.Location = new Point(128, 467);
            panel_temp_spacer.Margin = new Padding(3, 2, 3, 2);
            panel_temp_spacer.Name = "panel_temp_spacer";
            panel_temp_spacer.Size = new Size(219, 16);
            panel_temp_spacer.TabIndex = 61;
            // 
            // AddNewExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(469, 491);
            Controls.Add(panel7);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
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
        private CustomTextBox txtbox_ExerciseInstruction;
        private Label label5;
        private GeneralComponents.SmartButton btn_CancelExercise;
        private GeneralComponents.SmartButton btn_CreateExercise;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private FlowLayoutPanel testCasesContainer;
        private Label label6;
        private Panel panel7;
        private Panel panel_temp_spacer;
        private CustomTextBox subject;
    }
}