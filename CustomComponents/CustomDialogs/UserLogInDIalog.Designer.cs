using SmartCodeLab.CustomComponents.GeneralComponents;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class UserLogInDIalog
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
            userName = new CustomTextBox();
            smartButton2 = new SmartButton();
            smartButton3 = new SmartButton();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            password = new CustomTextBox();
            SuspendLayout();
            // 
            // userName
            // 
            userName.BackColor = Color.White;
            userName.BorderColor = Color.White;
            userName.BorderFocusColor = Color.MediumSlateBlue;
            userName.ForeColor = Color.DimGray;
            userName.Location = new Point(67, 45);
            userName.Name = "userName";
            userName.Padding = new Padding(9, 5, 9, 5);
            userName.PlaceHolderColor = Color.DarkGray;
            userName.PlaceholderText = "";
            userName.ScrollBars = ScrollBars.None;
            userName.Size = new Size(315, 32);
            userName.TabIndex = 0;
            userName.UnderlinedStyle = true;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 20;
            smartButton2.Cursor = Cursors.Hand;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(236, 159);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(146, 38);
            smartButton2.TabIndex = 3;
            smartButton2.Text = "Enter Room";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.DarkSlateBlue;
            smartButton3.BackgroundColor = Color.DarkSlateBlue;
            smartButton3.BorderRadius = 20;
            smartButton3.Cursor = Cursors.Hand;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(67, 159);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(145, 38);
            smartButton3.TabIndex = 4;
            smartButton3.Text = "Cancel";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(67, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 30;
            label1.Text = "Student ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 221);
            panel3.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 1);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(449, 1);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 220);
            panel4.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(1, 220);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 1);
            panel1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(67, 95);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 36;
            label2.Text = "Server Password";
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderColor = Color.White;
            password.BorderFocusColor = Color.MediumSlateBlue;
            password.ForeColor = Color.DimGray;
            password.Location = new Point(67, 119);
            password.Name = "password";
            password.Padding = new Padding(9, 5, 9, 5);
            password.PlaceHolderColor = Color.DarkGray;
            password.PlaceholderText = "";
            password.ScrollBars = ScrollBars.None;
            password.Size = new Size(315, 32);
            password.TabIndex = 35;
            password.UnderlinedStyle = true;
            // 
            // UserLogInDIalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(450, 221);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(smartButton3);
            Controls.Add(smartButton2);
            Controls.Add(userName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLogInDIalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogInDIalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTextBox userName;
        private SmartButton smartButton2;
        private SmartButton smartButton3;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel1;
        private Label label2;
        private CustomTextBox password;
    }
}