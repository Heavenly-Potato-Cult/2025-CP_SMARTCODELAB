namespace SmartCodeLab
{
    partial class AuthInstructorForm
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
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label2 = new Label();
            customTextBox2 = new SmartCodeLab.CustomComponents.CustomTextBox();
            label1 = new Label();
            customTextBox1 = new SmartCodeLab.CustomComponents.CustomTextBox();
            btn_InstuctorLogin = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label8 = new Label();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(13, 13, 13);
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 0;
            customCard1.Controls.Add(label2);
            customCard1.Controls.Add(customTextBox2);
            customCard1.Controls.Add(label1);
            customCard1.Controls.Add(customTextBox1);
            customCard1.Controls.Add(btn_InstuctorLogin);
            customCard1.Controls.Add(label8);
            customCard1.Location = new Point(252, 35);
            customCard1.Margin = new Padding(3, 4, 3, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(451, 456);
            customCard1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 211);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.FromArgb(10, 10, 10);
            customTextBox2.BorderColor = Color.White;
            customTextBox2.BorderFocusColor = Color.MediumSlateBlue;
            customTextBox2.BorderSize = 0;
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(69, 246);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 7, 10, 7);
            customTextBox2.PasswordChar = true;
            customTextBox2.Size = new Size(312, 41);
            customTextBox2.TabIndex = 11;
            customTextBox2.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 106);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(10, 10, 10);
            customTextBox1.BorderColor = Color.White;
            customTextBox1.BorderFocusColor = Color.MediumSlateBlue;
            customTextBox1.BorderSize = 0;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(69, 141);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(312, 41);
            customTextBox1.TabIndex = 9;
            customTextBox1.UnderlinedStyle = true;
            // 
            // btn_InstuctorLogin
            // 
            btn_InstuctorLogin.BackColor = Color.MediumSlateBlue;
            btn_InstuctorLogin.BorderRadius = 3;
            btn_InstuctorLogin.Cursor = Cursors.Hand;
            btn_InstuctorLogin.FlatAppearance.BorderSize = 0;
            btn_InstuctorLogin.FlatStyle = FlatStyle.Flat;
            btn_InstuctorLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_InstuctorLogin.ForeColor = Color.White;
            btn_InstuctorLogin.Location = new Point(40, 348);
            btn_InstuctorLogin.Name = "btn_InstuctorLogin";
            btn_InstuctorLogin.Size = new Size(347, 51);
            btn_InstuctorLogin.TabIndex = 8;
            btn_InstuctorLogin.Text = "Login";
            btn_InstuctorLogin.UseVisualStyleBackColor = false;
            btn_InstuctorLogin.Click += btn_InstuctorLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(242, 242, 242);
            label8.Location = new Point(64, 19);
            label8.Name = "label8";
            label8.Size = new Size(323, 37);
            label8.TabIndex = 5;
            label8.Text = "LOG IN AS INSTRUCTOR";
            // 
            // AuthInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(952, 526);
            Controls.Add(customCard1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AuthInstructorForm";
            Text = "AuthInstructor";
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomComponents.GeneralComponents.CustomCard customCard1;
        private Label label1;
        private CustomComponents.CustomTextBox customTextBox1;
        private CustomComponents.GeneralComponents.SmartButton btn_InstuctorLogin;
        private Label label8;
        private Label label2;
        private CustomComponents.CustomTextBox customTextBox2;
    }
}