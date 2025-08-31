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
            folderLoc = new CustomTextBox();
            smartButton1 = new SmartButton();
            smartButton2 = new SmartButton();
            smartButton3 = new SmartButton();
            lblTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(13, 13, 13);
            userName.BorderColor = Color.White;
            userName.BorderFocusColor = Color.MediumSlateBlue;
            userName.ForeColor = Color.FromArgb(179, 179, 179);
            userName.Location = new Point(66, 48);
            userName.Margin = new Padding(3, 2, 3, 2);
            userName.Name = "userName";
            userName.Padding = new Padding(9, 5, 9, 5);
            userName.Size = new Size(315, 32);
            userName.TabIndex = 0;
            userName.UnderlinedStyle = true;
            userName._TextChanged += userName__TextChanged;
            // 
            // folderLoc
            // 
            folderLoc.BackColor = Color.FromArgb(13, 13, 13);
            folderLoc.BorderColor = Color.White;
            folderLoc.BorderFocusColor = Color.MediumSlateBlue;
            folderLoc.ForeColor = Color.FromArgb(179, 179, 179);
            folderLoc.Location = new Point(65, 123);
            folderLoc.Margin = new Padding(3, 2, 3, 2);
            folderLoc.Name = "folderLoc";
            folderLoc.Padding = new Padding(9, 5, 9, 5);
            folderLoc.Size = new Size(223, 32);
            folderLoc.TabIndex = 1;
            folderLoc.UnderlinedStyle = true;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(294, 123);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(87, 32);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Select";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(235, 199);
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
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(66, 199);
            smartButton3.Margin = new Padding(3, 2, 3, 2);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(145, 38);
            smartButton3.TabIndex = 4;
            smartButton3.Text = "Cancel";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(65, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(80, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 101);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 6;
            label1.Text = "Folder Location";
            // 
            // UserLogInDIalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(447, 274);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(smartButton3);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(folderLoc);
            Controls.Add(userName);
            DoubleBuffered = true;
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
        private CustomTextBox folderLoc;
        private SmartButton smartButton1;
        private SmartButton smartButton2;
        private SmartButton smartButton3;
        private Label lblTitle;
        private Label label1;
    }
}