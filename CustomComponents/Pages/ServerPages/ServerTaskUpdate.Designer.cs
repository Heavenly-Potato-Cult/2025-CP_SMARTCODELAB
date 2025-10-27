namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class ServerTaskUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerTaskUpdate));
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
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
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label13 = new Label();
            btn_EditExerciseDetails = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reference).BeginInit();
            tabPage1.SuspendLayout();
            customCard7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(76, 65);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.MaximumSize = new Size(1019, 452);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(6, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1019, 452);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 53;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(instruction);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(subject);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(exerciseName);
            tabPage3.Controls.Add(label9);
            tabPage3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(9, 8, 9, 8);
            tabPage3.Size = new Size(1011, 410);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Details";
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
            instruction.ForeColor = SystemColors.ControlText;
            instruction.Location = new Point(23, 133);
            instruction.Margin = new Padding(3, 2, 3, 2);
            instruction.Multiline = true;
            instruction.Name = "instruction";
            instruction.Padding = new Padding(9, 5, 9, 5);
            instruction.PlaceHolderColor = Color.DarkGray;
            instruction.PlaceholderText = "";
            instruction.ScrollBars = ScrollBars.Vertical;
            instruction.Size = new Size(967, 265);
            instruction.TabIndex = 34;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.DimGray;
            label25.Location = new Point(23, 112);
            label25.Name = "label25";
            label25.Size = new Size(78, 20);
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
            subject.ForeColor = SystemColors.ControlText;
            subject.Location = new Point(388, 54);
            subject.Margin = new Padding(3, 2, 3, 2);
            subject.Name = "subject";
            subject.Padding = new Padding(9, 5, 9, 5);
            subject.PlaceHolderColor = Color.DarkGray;
            subject.PlaceholderText = "";
            subject.ScrollBars = ScrollBars.None;
            subject.Size = new Size(304, 36);
            subject.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(388, 33);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
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
            exerciseName.Location = new Point(23, 54);
            exerciseName.Margin = new Padding(3, 2, 3, 2);
            exerciseName.Name = "exerciseName";
            exerciseName.Padding = new Padding(9, 5, 9, 5);
            exerciseName.PlaceHolderColor = Color.DarkGray;
            exerciseName.PlaceholderText = "";
            exerciseName.ScrollBars = ScrollBars.None;
            exerciseName.Size = new Size(304, 36);
            exerciseName.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(23, 33);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
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
            tabPage4.Location = new Point(4, 38);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1011, 410);
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
            reference.AutoScrollMinSize = new Size(2, 14);
            reference.BackBrush = null;
            reference.CharHeight = 14;
            reference.CharWidth = 8;
            reference.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            reference.Hotkeys = resources.GetString("reference.Hotkeys");
            reference.IsReplaceMode = false;
            reference.Location = new Point(25, 50);
            reference.Margin = new Padding(3, 2, 3, 2);
            reference.Name = "reference";
            reference.Paddings = new Padding(0);
            reference.ReadOnly = true;
            reference.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            reference.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("reference.ServiceColors");
            reference.Size = new Size(629, 260);
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
            smartButton2.Location = new Point(538, 21);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(116, 26);
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
            smartButton1.Location = new Point(416, 21);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(116, 26);
            smartButton1.TabIndex = 55;
            smartButton1.Text = "Upload Code";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(13, 13, 13);
            label11.Location = new Point(28, 22);
            label11.Name = "label11";
            label11.Size = new Size(232, 25);
            label11.TabIndex = 23;
            label11.Text = "Reference Solution Code";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(testContainer);
            tabPage1.Controls.Add(customCard7);
            tabPage1.Controls.Add(btn_AddTestCase);
            tabPage1.Controls.Add(label13);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 38);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1011, 410);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "TestCases";
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.FlowDirection = FlowDirection.TopDown;
            testContainer.Location = new Point(179, 73);
            testContainer.Margin = new Padding(3, 2, 3, 2);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(650, 342);
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
            customCard7.Location = new Point(179, 48);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(650, 26);
            customCard7.TabIndex = 57;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(316, 4);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 19;
            label15.Text = "Output";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(14, 4);
            label14.Name = "label14";
            label14.Size = new Size(43, 20);
            label14.TabIndex = 18;
            label14.Text = "Input";
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
            btn_AddTestCase.Location = new Point(713, 10);
            btn_AddTestCase.Margin = new Padding(3, 2, 3, 2);
            btn_AddTestCase.Name = "btn_AddTestCase";
            btn_AddTestCase.Size = new Size(116, 26);
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
            label13.Location = new Point(179, 13);
            label13.Name = "label13";
            label13.Size = new Size(99, 25);
            label13.TabIndex = 53;
            label13.Text = "Test Cases";
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
            btn_EditExerciseDetails.Location = new Point(76, 549);
            btn_EditExerciseDetails.Margin = new Padding(3, 2, 3, 2);
            btn_EditExerciseDetails.Name = "btn_EditExerciseDetails";
            btn_EditExerciseDetails.Size = new Size(266, 38);
            btn_EditExerciseDetails.TabIndex = 35;
            btn_EditExerciseDetails.Text = "Update Task";
            btn_EditExerciseDetails.UseVisualStyleBackColor = false;
            btn_EditExerciseDetails.Click += btn_EditExerciseDetails_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(76, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 30);
            label3.TabIndex = 54;
            label3.Text = "Exercise Manager";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.222317F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.57759F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.2000947F));
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_EditExerciseDetails, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0507956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.03246F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9167376F));
            tableLayoutPanel1.Size = new Size(1186, 629);
            tableLayoutPanel1.TabIndex = 55;
            // 
            // ServerTaskUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ServerTaskUpdate";
            Size = new Size(1186, 629);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage3;
        private GeneralComponents.SmartButton btn_EditExerciseDetails;
        private CustomTextBox instruction;
        private Label label25;
        private CustomTextBox subject;
        private Label label8;
        private CustomTextBox exerciseName;
        private Label label9;
        private TabPage tabPage4;
        private ProgrammingTabs.CodeEditor reference;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton1;
        private Label label11;
        private TabPage tabPage1;
        private FlowLayoutPanel testContainer;
        private GeneralComponents.CustomCard customCard7;
        private Label label15;
        private Label label14;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private Label label13;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
