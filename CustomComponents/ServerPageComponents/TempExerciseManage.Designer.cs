namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempExerciseManage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempExerciseManage));
            label12 = new Label();
            label1 = new Label();
            btn_AddNewExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            btn_EditExerciseDetails = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            instruction = new CustomTextBox();
            label25 = new Label();
            subject = new CustomTextBox();
            label8 = new Label();
            exerciseName = new CustomTextBox();
            label9 = new Label();
            tabPage4 = new TabPage();
            reference = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label11 = new Label();
            tabPage1 = new TabPage();
            testContainer = new FlowLayoutPanel();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label15 = new Label();
            label14 = new Label();
            smartButton7 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton6 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label13 = new Label();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            taskContainer = new FlowLayoutPanel();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reference).BeginInit();
            tabPage1.SuspendLayout();
            customCard7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(62, 175);
            label12.Name = "label12";
            label12.Size = new Size(182, 31);
            label12.TabIndex = 19;
            label12.Text = "Exercise Library";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 13, 13);
            label1.Location = new Point(526, 175);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 20;
            label1.Text = "Exercise Details";
            // 
            // btn_AddNewExercise
            // 
            btn_AddNewExercise.BackColor = Color.MediumSlateBlue;
            btn_AddNewExercise.BorderRadius = 10;
            btn_AddNewExercise.FlatAppearance.BorderSize = 0;
            btn_AddNewExercise.FlatStyle = FlatStyle.Flat;
            btn_AddNewExercise.ForeColor = Color.White;
            btn_AddNewExercise.Location = new Point(1047, 60);
            btn_AddNewExercise.Name = "btn_AddNewExercise";
            btn_AddNewExercise.Size = new Size(243, 44);
            btn_AddNewExercise.TabIndex = 46;
            btn_AddNewExercise.Text = "Add New Exercise";
            btn_AddNewExercise.UseVisualStyleBackColor = false;
            btn_AddNewExercise.Click += smartButton1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(526, 209);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(6, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 466);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 52;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(btn_EditExerciseDetails);
            tabPage3.Controls.Add(instruction);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(subject);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(exerciseName);
            tabPage3.Controls.Add(label9);
            tabPage3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 43);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(10);
            tabPage3.Size = new Size(785, 419);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Details";
            // 
            // btn_EditExerciseDetails
            // 
            btn_EditExerciseDetails.BackColor = Color.MediumTurquoise;
            btn_EditExerciseDetails.BackgroundColor = Color.MediumTurquoise;
            btn_EditExerciseDetails.BorderRadius = 20;
            btn_EditExerciseDetails.FlatAppearance.BorderSize = 0;
            btn_EditExerciseDetails.FlatStyle = FlatStyle.Flat;
            btn_EditExerciseDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditExerciseDetails.ForeColor = Color.White;
            btn_EditExerciseDetails.Location = new Point(222, 356);
            btn_EditExerciseDetails.Name = "btn_EditExerciseDetails";
            btn_EditExerciseDetails.Size = new Size(304, 50);
            btn_EditExerciseDetails.TabIndex = 35;
            btn_EditExerciseDetails.Text = "Edit";
            btn_EditExerciseDetails.UseVisualStyleBackColor = false;
            btn_EditExerciseDetails.Click += btn_EditExerciseDetails_Click;
            // 
            // instruction
            // 
            instruction.AutoScroll = true;
            instruction.AutoSize = true;
            instruction.BackColor = Color.White;
            instruction.BorderColor = Color.LightGray;
            instruction.BorderFocusColor = Color.FromArgb(64, 64, 64);
            instruction.BorderRadius = 10;
            instruction.BorderSize = 1;
            instruction.Enabled = false;
            instruction.ForeColor = SystemColors.ControlText;
            instruction.Location = new Point(20, 126);
            instruction.Multiline = true;
            instruction.Name = "instruction";
            instruction.Padding = new Padding(10, 7, 10, 7);
            instruction.PlaceHolderColor = Color.DarkGray;
            instruction.PlaceholderText = "";
            instruction.ScrollBars = ScrollBars.Vertical;
            instruction.Size = new Size(740, 224);
            instruction.TabIndex = 34;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.DimGray;
            label25.Location = new Point(20, 98);
            label25.Name = "label25";
            label25.Size = new Size(96, 25);
            label25.TabIndex = 33;
            label25.Text = "Instruction";
            // 
            // subject
            // 
            subject.BackColor = Color.White;
            subject.BorderColor = Color.LightGray;
            subject.BorderFocusColor = Color.FromArgb(64, 64, 64);
            subject.BorderRadius = 10;
            subject.BorderSize = 1;
            subject.Enabled = false;
            subject.ForeColor = SystemColors.ControlText;
            subject.Location = new Point(412, 30);
            subject.Name = "subject";
            subject.Padding = new Padding(10, 7, 10, 7);
            subject.PlaceHolderColor = Color.DarkGray;
            subject.PlaceholderText = "";
            subject.ScrollBars = ScrollBars.None;
            subject.Size = new Size(348, 46);
            subject.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(420, 9);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 29;
            label8.Text = "Subject";
            // 
            // exerciseName
            // 
            exerciseName.BackColor = Color.White;
            exerciseName.BorderColor = Color.LightGray;
            exerciseName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            exerciseName.BorderRadius = 10;
            exerciseName.BorderSize = 1;
            exerciseName.Enabled = false;
            exerciseName.ForeColor = SystemColors.ControlText;
            exerciseName.Location = new Point(13, 30);
            exerciseName.Name = "exerciseName";
            exerciseName.Padding = new Padding(10, 7, 10, 7);
            exerciseName.PlaceHolderColor = Color.DarkGray;
            exerciseName.PlaceholderText = "";
            exerciseName.ScrollBars = ScrollBars.None;
            exerciseName.Size = new Size(348, 46);
            exerciseName.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(20, 9);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 27;
            label9.Text = "Exercise Name";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(reference);
            tabPage4.Controls.Add(smartButton2);
            tabPage4.Controls.Add(smartButton1);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 43);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(785, 419);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Reference Code";
            // 
            // reference
            // 
            reference.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            reference.AutoScrollMinSize = new Size(31, 18);
            reference.BackBrush = null;
            reference.CharHeight = 18;
            reference.CharWidth = 10;
            reference.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            reference.Hotkeys = resources.GetString("reference.Hotkeys");
            reference.IsReplaceMode = false;
            reference.Location = new Point(29, 67);
            reference.Name = "reference";
            reference.Paddings = new Padding(0);
            reference.ReadOnly = true;
            reference.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            reference.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("reference.ServiceColors");
            reference.Size = new Size(719, 346);
            reference.TabIndex = 57;
            reference.Zoom = 100;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.SlateGray;
            smartButton2.BackgroundColor = Color.SlateGray;
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(615, 28);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(133, 34);
            smartButton2.TabIndex = 56;
            smartButton2.Text = "Copy";
            smartButton2.UseVisualStyleBackColor = false;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.SlateGray;
            smartButton1.BackgroundColor = Color.SlateGray;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(476, 28);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(133, 34);
            smartButton1.TabIndex = 55;
            smartButton1.Text = "Upload Code";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(13, 13, 13);
            label11.Location = new Point(29, 26);
            label11.Name = "label11";
            label11.Size = new Size(277, 31);
            label11.TabIndex = 23;
            label11.Text = "Reference Solution Code";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(testContainer);
            tabPage1.Controls.Add(customCard7);
            tabPage1.Controls.Add(smartButton7);
            tabPage1.Controls.Add(smartButton6);
            tabPage1.Controls.Add(btn_AddTestCase);
            tabPage1.Controls.Add(label13);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 43);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(785, 419);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "TestCases";
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.FlowDirection = FlowDirection.TopDown;
            testContainer.Location = new Point(26, 118);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(743, 298);
            testContainer.TabIndex = 58;
            testContainer.WrapContents = false;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.FromArgb(224, 224, 224);
            customCard7.BorderColor = Color.Gray;
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(label15);
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(26, 85);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(743, 34);
            customCard7.TabIndex = 57;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(361, 5);
            label15.Name = "label15";
            label15.Size = new Size(69, 25);
            label15.TabIndex = 19;
            label15.Text = "Output";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(16, 5);
            label14.Name = "label14";
            label14.Size = new Size(54, 25);
            label14.TabIndex = 18;
            label14.Text = "Input";
            // 
            // smartButton7
            // 
            smartButton7.BackColor = Color.SlateGray;
            smartButton7.BackgroundColor = Color.SlateGray;
            smartButton7.BorderRadius = 10;
            smartButton7.FlatAppearance.BorderSize = 0;
            smartButton7.FlatStyle = FlatStyle.Flat;
            smartButton7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton7.ForeColor = Color.White;
            smartButton7.Location = new Point(483, 28);
            smartButton7.Name = "smartButton7";
            smartButton7.Size = new Size(133, 34);
            smartButton7.TabIndex = 56;
            smartButton7.Text = "Edit Test Case";
            smartButton7.UseVisualStyleBackColor = false;
            // 
            // smartButton6
            // 
            smartButton6.BackColor = Color.SlateGray;
            smartButton6.BackgroundColor = Color.SlateGray;
            smartButton6.BorderRadius = 10;
            smartButton6.FlatAppearance.BorderSize = 0;
            smartButton6.FlatStyle = FlatStyle.Flat;
            smartButton6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton6.ForeColor = Color.White;
            smartButton6.Location = new Point(622, 28);
            smartButton6.Name = "smartButton6";
            smartButton6.Size = new Size(133, 34);
            smartButton6.TabIndex = 55;
            smartButton6.Text = "Delete Test Case";
            smartButton6.UseVisualStyleBackColor = false;
            // 
            // btn_AddTestCase
            // 
            btn_AddTestCase.BackColor = Color.SlateGray;
            btn_AddTestCase.BackgroundColor = Color.SlateGray;
            btn_AddTestCase.BorderRadius = 10;
            btn_AddTestCase.FlatAppearance.BorderSize = 0;
            btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            btn_AddTestCase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddTestCase.ForeColor = Color.White;
            btn_AddTestCase.Location = new Point(344, 28);
            btn_AddTestCase.Name = "btn_AddTestCase";
            btn_AddTestCase.Size = new Size(133, 34);
            btn_AddTestCase.TabIndex = 54;
            btn_AddTestCase.Text = "Add Test Case";
            btn_AddTestCase.UseVisualStyleBackColor = false;
            btn_AddTestCase.Click += btn_AddTestCase_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(13, 13, 13);
            label13.Location = new Point(36, 31);
            label13.Name = "label13";
            label13.Size = new Size(120, 31);
            label13.TabIndex = 53;
            label13.Text = "Test Cases";
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 20;
            customCard4.BorderSize = 1;
            customCard4.Location = new Point(64, 209);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(448, 691);
            customCard4.TabIndex = 53;
            // 
            // taskContainer
            // 
            taskContainer.AutoScroll = true;
            taskContainer.FlowDirection = FlowDirection.TopDown;
            taskContainer.Location = new Point(67, 215);
            taskContainer.Name = "taskContainer";
            taskContainer.Size = new Size(442, 682);
            taskContainer.TabIndex = 0;
            taskContainer.WrapContents = false;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.MediumSlateBlue;
            smartButton3.BorderRadius = 20;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(324, 168);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(188, 35);
            smartButton3.TabIndex = 54;
            smartButton3.Text = "Open Folder";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_AddNewExercise);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1362, 156);
            panel3.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 13, 13);
            label2.Location = new Point(126, 35);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 13;
            label2.Text = "Exercise Manager";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(127, 79);
            label4.Name = "label4";
            label4.Size = new Size(450, 25);
            label4.TabIndex = 14;
            label4.Text = "Create, edit and manage coding exercise with test cases";
            // 
            // TempExerciseManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel3);
            Controls.Add(smartButton3);
            Controls.Add(taskContainer);
            Controls.Add(customCard4);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(label12);
            DoubleBuffered = true;
            Name = "TempExerciseManage";
            Size = new Size(1362, 943);
            Load += TempExerciseManage_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reference).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label1;
        private GeneralComponents.SmartButton btn_AddNewExercise;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private CustomTextBox subject;
        private Label label8;
        private CustomTextBox exerciseName;
        private Label label9;
        private Label label11;
        private TabPage tabPage1;
        private GeneralComponents.CustomCard customCard7;
        private Label label15;
        private Label label14;
        private GeneralComponents.SmartButton smartButton7;
        private GeneralComponents.SmartButton smartButton6;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private Label label13;
        private CustomTextBox instruction;
        private Label label25;
        private GeneralComponents.SmartButton btn_EditExerciseDetails;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.CustomCard customCard4;
        private FlowLayoutPanel taskContainer;
        private GeneralComponents.SmartButton smartButton3;
        private Pages.ProgrammingTabs.CodeEditor reference;
        private FlowLayoutPanel testContainer;
        private Panel panel3;
        private Label label2;
        private Label label4;
    }
}
