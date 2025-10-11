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
            SuspendLayout();
            // 
            // userName
            // 
            userName.BackColor = Color.White;
            userName.BorderColor = Color.White;
            userName.BorderFocusColor = Color.MediumSlateBlue;
            userName.ForeColor = Color.DimGray;
            userName.Location = new Point(77, 60);
            userName.Margin = new Padding(3, 4, 3, 4);
            userName.Name = "userName";
            userName.Padding = new Padding(10, 7, 10, 7);
            userName.PlaceHolderColor = Color.DarkGray;
            userName.PlaceholderText = "";
            userName.ScrollBars = ScrollBars.None;
            userName.Size = new Size(360, 41);
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
            smartButton2.Location = new Point(270, 127);
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
            smartButton3.Location = new Point(77, 127);
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
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(77, 28);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 30;
            label1.Text = "Student ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 216);
            panel3.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 1);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(513, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 215);
            panel4.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(1, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 1);
            panel1.TabIndex = 34;
            // 
            // UserLogInDIalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(514, 216);
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
    }
}