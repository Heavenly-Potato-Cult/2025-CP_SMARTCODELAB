namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class AddNewTestCase
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
            btn_ConfirmAddNewTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            txtbox_AddTestCaseName = new CustomTextBox();
            label4 = new Label();
            txtbox_AddTestCaseInput = new CustomTextBox();
            label1 = new Label();
            label2 = new Label();
            txtbox_AddTestCaseOuput = new CustomTextBox();
            btn_CancelAddNewTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel1 = new Panel();
            btnClose = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ConfirmAddNewTestCase
            // 
            btn_ConfirmAddNewTestCase.BackColor = Color.DodgerBlue;
            btn_ConfirmAddNewTestCase.BackgroundColor = Color.DodgerBlue;
            btn_ConfirmAddNewTestCase.BorderRadius = 10;
            btn_ConfirmAddNewTestCase.FlatAppearance.BorderSize = 0;
            btn_ConfirmAddNewTestCase.FlatStyle = FlatStyle.Flat;
            btn_ConfirmAddNewTestCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ConfirmAddNewTestCase.ForeColor = Color.White;
            btn_ConfirmAddNewTestCase.Location = new Point(403, 547);
            btn_ConfirmAddNewTestCase.Name = "btn_ConfirmAddNewTestCase";
            btn_ConfirmAddNewTestCase.Size = new Size(84, 50);
            btn_ConfirmAddNewTestCase.TabIndex = 29;
            btn_ConfirmAddNewTestCase.Text = "OK";
            btn_ConfirmAddNewTestCase.UseVisualStyleBackColor = false;
            // 
            // txtbox_AddTestCaseName
            // 
            txtbox_AddTestCaseName.BackColor = Color.White;
            txtbox_AddTestCaseName.BorderColor = Color.DarkGray;
            txtbox_AddTestCaseName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddTestCaseName.BorderRadius = 10;
            txtbox_AddTestCaseName.BorderSize = 1;
            txtbox_AddTestCaseName.ForeColor = SystemColors.ControlText;
            txtbox_AddTestCaseName.Location = new Point(34, 468);
            txtbox_AddTestCaseName.Name = "txtbox_AddTestCaseName";
            txtbox_AddTestCaseName.Padding = new Padding(10, 7, 10, 7);
            txtbox_AddTestCaseName.ScrollBars = ScrollBars.None;
            txtbox_AddTestCaseName.Size = new Size(453, 41);
            txtbox_AddTestCaseName.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 440);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 30;
            label4.Text = "Mark / Points";
            // 
            // txtbox_AddTestCaseInput
            // 
            txtbox_AddTestCaseInput.BackColor = Color.White;
            txtbox_AddTestCaseInput.BorderColor = Color.DarkGray;
            txtbox_AddTestCaseInput.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddTestCaseInput.BorderRadius = 10;
            txtbox_AddTestCaseInput.BorderSize = 1;
            txtbox_AddTestCaseInput.ForeColor = SystemColors.ControlText;
            txtbox_AddTestCaseInput.Location = new Point(34, 112);
            txtbox_AddTestCaseInput.Multiline = true;
            txtbox_AddTestCaseInput.Name = "txtbox_AddTestCaseInput";
            txtbox_AddTestCaseInput.Padding = new Padding(10, 7, 10, 7);
            txtbox_AddTestCaseInput.ScrollBars = ScrollBars.None;
            txtbox_AddTestCaseInput.Size = new Size(453, 131);
            txtbox_AddTestCaseInput.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(34, 84);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 32;
            label1.Text = "Input Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 257);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 34;
            label2.Text = "Expected Output";
            // 
            // txtbox_AddTestCaseOuput
            // 
            txtbox_AddTestCaseOuput.BackColor = Color.White;
            txtbox_AddTestCaseOuput.BorderColor = Color.DarkGray;
            txtbox_AddTestCaseOuput.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtbox_AddTestCaseOuput.BorderRadius = 10;
            txtbox_AddTestCaseOuput.BorderSize = 1;
            txtbox_AddTestCaseOuput.ForeColor = SystemColors.ControlText;
            txtbox_AddTestCaseOuput.Location = new Point(34, 285);
            txtbox_AddTestCaseOuput.Multiline = true;
            txtbox_AddTestCaseOuput.Name = "txtbox_AddTestCaseOuput";
            txtbox_AddTestCaseOuput.Padding = new Padding(10, 7, 10, 7);
            txtbox_AddTestCaseOuput.ScrollBars = ScrollBars.None;
            txtbox_AddTestCaseOuput.Size = new Size(453, 131);
            txtbox_AddTestCaseOuput.TabIndex = 35;
            // 
            // btn_CancelAddNewTestCase
            // 
            btn_CancelAddNewTestCase.BackColor = Color.Transparent;
            btn_CancelAddNewTestCase.BackgroundColor = Color.Transparent;
            btn_CancelAddNewTestCase.BorderColor = Color.Silver;
            btn_CancelAddNewTestCase.BorderRadius = 10;
            btn_CancelAddNewTestCase.BorderSize = 1;
            btn_CancelAddNewTestCase.FlatAppearance.BorderSize = 0;
            btn_CancelAddNewTestCase.FlatStyle = FlatStyle.Flat;
            btn_CancelAddNewTestCase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelAddNewTestCase.ForeColor = Color.Black;
            btn_CancelAddNewTestCase.Location = new Point(263, 547);
            btn_CancelAddNewTestCase.Name = "btn_CancelAddNewTestCase";
            btn_CancelAddNewTestCase.Size = new Size(123, 50);
            btn_CancelAddNewTestCase.TabIndex = 36;
            btn_CancelAddNewTestCase.Text = "Cancel";
            btn_CancelAddNewTestCase.TextColor = Color.Black;
            btn_CancelAddNewTestCase.UseVisualStyleBackColor = false;
            btn_CancelAddNewTestCase.Click += btn_CancelAddNewTestCase_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 59);
            panel1.TabIndex = 52;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 50, 50);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(485, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 59);
            btnClose.TabIndex = 25;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(34, 9);
            label12.Name = "label12";
            label12.Size = new Size(216, 38);
            label12.TabIndex = 24;
            label12.Text = "Add Test Name";
            // 
            // AddNewTestCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 623);
            Controls.Add(panel1);
            Controls.Add(btn_CancelAddNewTestCase);
            Controls.Add(txtbox_AddTestCaseOuput);
            Controls.Add(label2);
            Controls.Add(txtbox_AddTestCaseInput);
            Controls.Add(label1);
            Controls.Add(txtbox_AddTestCaseName);
            Controls.Add(label4);
            Controls.Add(btn_ConfirmAddNewTestCase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewTestCase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewTestCase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GeneralComponents.SmartButton btn_ConfirmAddNewTestCase;
        private CustomTextBox txtbox_AddTestCaseName;
        private Label label4;
        private CustomTextBox txtbox_AddTestCaseInput;
        private Label label1;
        private Label label2;
        private CustomTextBox txtbox_AddTestCaseOuput;
        private GeneralComponents.SmartButton btn_CancelAddNewTestCase;
        private Panel panel1;
        private Button btnClose;
        private Label label12;
    }
}