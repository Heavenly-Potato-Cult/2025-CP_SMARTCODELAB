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
            SuspendLayout();
            // 
            // userName
            // 
            userName.BackColor = SystemColors.Window;
            userName.ForeColor = Color.DimGray;
            userName.Location = new Point(12, 76);
            userName.Name = "userName";
            userName.Padding = new Padding(10, 7, 10, 7);
            userName.Size = new Size(360, 41);
            userName.TabIndex = 0;
            userName._TextChanged += userName__TextChanged;
            // 
            // folderLoc
            // 
            folderLoc.BackColor = SystemColors.Window;
            folderLoc.ForeColor = Color.DimGray;
            folderLoc.Location = new Point(12, 134);
            folderLoc.Name = "folderLoc";
            folderLoc.Padding = new Padding(10, 7, 10, 7);
            folderLoc.Size = new Size(255, 41);
            folderLoc.TabIndex = 1;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(273, 134);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(99, 42);
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
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(205, 201);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(167, 50);
            smartButton2.TabIndex = 3;
            smartButton2.Text = "Enter Room";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.SlateGray;
            smartButton3.BackgroundColor = Color.SlateGray;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(12, 201);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(166, 50);
            smartButton3.TabIndex = 4;
            smartButton3.Text = "Cancel";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // UserLogInDIalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 263);
            Controls.Add(smartButton3);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(folderLoc);
            Controls.Add(userName);
            Name = "UserLogInDIalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogInDIalog";
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox userName;
        private CustomTextBox folderLoc;
        private SmartButton smartButton1;
        private SmartButton smartButton2;
        private SmartButton smartButton3;
    }
}