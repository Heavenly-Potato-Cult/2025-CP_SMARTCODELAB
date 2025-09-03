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
            folderLoc = new CustomTextBox();
            smartButton1 = new SmartButton();
            smartButton2 = new SmartButton();
            smartButton3 = new SmartButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(13, 13, 13);
            userName.BorderColor = Color.White;
            userName.BorderFocusColor = Color.MediumSlateBlue;
            userName.ForeColor = Color.DimGray;
            userName.Location = new Point(120, 85);
            userName.Margin = new Padding(3, 4, 3, 4);
            userName.Name = "userName";
            userName.Padding = new Padding(10, 7, 10, 7);
            userName.Size = new Size(360, 41);
            userName.TabIndex = 0;
            userName.UnderlinedStyle = true;
            // 
            // folderLoc
            // 
            folderLoc.BackColor = Color.FromArgb(13, 13, 13);
            folderLoc.BorderColor = Color.White;
            folderLoc.BorderFocusColor = Color.MediumSlateBlue;
            folderLoc.ForeColor = Color.FromArgb(179, 179, 179);
            folderLoc.Location = new Point(120, 193);
            folderLoc.Name = "folderLoc";
            folderLoc.Padding = new Padding(10, 7, 10, 7);
            folderLoc.Size = new Size(255, 41);
            folderLoc.TabIndex = 1;
            folderLoc.UnderlinedStyle = true;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 5;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(381, 193);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(99, 43);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Select";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
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
            smartButton2.Location = new Point(313, 304);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(167, 51);
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
            smartButton3.Location = new Point(120, 304);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(166, 51);
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
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(120, 53);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 30;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(120, 163);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 31;
            label2.Text = "Folder Location";
            // 
            // UserLogInDIalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(600, 407);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(smartButton3);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(folderLoc);
            Controls.Add(userName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private Label label1;
        private Label label2;
    }
}