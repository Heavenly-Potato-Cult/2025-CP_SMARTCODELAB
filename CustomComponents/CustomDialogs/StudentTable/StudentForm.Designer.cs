namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            studName = new CustomTextBox();
            label2 = new Label();
            studId = new CustomTextBox();
            label4 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.Green;
            smartButton2.BackgroundColor = Color.Green;
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Image = (Image)resources.GetObject("smartButton2.Image");
            smartButton2.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton2.Location = new Point(237, 173);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(9, 0, 0, 0);
            smartButton2.Size = new Size(126, 38);
            smartButton2.TabIndex = 3;
            smartButton2.Text = " Add Student";
            smartButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = SystemColors.WindowFrame;
            smartButton1.BackgroundColor = SystemColors.WindowFrame;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton1.Location = new Point(144, 173);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(88, 38);
            smartButton1.TabIndex = 22;
            smartButton1.Text = "Cancel";
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // studName
            // 
            studName.BackColor = Color.White;
            studName.BorderColor = Color.DarkGray;
            studName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            studName.BorderRadius = 10;
            studName.BorderSize = 1;
            studName.ForeColor = SystemColors.ControlText;
            studName.Location = new Point(38, 116);
            studName.Margin = new Padding(3, 2, 3, 2);
            studName.Name = "studName";
            studName.Padding = new Padding(9, 5, 9, 5);
            studName.PlaceHolderColor = Color.DarkGray;
            studName.PlaceholderText = "";
            studName.ScrollBars = ScrollBars.None;
            studName.Size = new Size(325, 32);
            studName.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 59;
            label2.Text = "Student Name";
            // 
            // studId
            // 
            studId.BackColor = Color.White;
            studId.BorderColor = Color.DarkGray;
            studId.BorderFocusColor = Color.FromArgb(64, 64, 64);
            studId.BorderRadius = 10;
            studId.BorderSize = 1;
            studId.ForeColor = SystemColors.ControlText;
            studId.Location = new Point(38, 49);
            studId.Margin = new Padding(3, 2, 3, 2);
            studId.Name = "studId";
            studId.Padding = new Padding(9, 5, 9, 5);
            studId.PlaceHolderColor = Color.DarkGray;
            studId.PlaceholderText = "";
            studId.ScrollBars = ScrollBars.None;
            studId.Size = new Size(325, 32);
            studId.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 29);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 54;
            label4.Text = "Student ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 2);
            panel2.TabIndex = 61;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(393, 241);
            Controls.Add(panel2);
            Controls.Add(studName);
            Controls.Add(label2);
            Controls.Add(studId);
            Controls.Add(label4);
            Controls.Add(smartButton1);
            Controls.Add(smartButton2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton1;
        private CustomTextBox studName;
        private Label label2;
        private CustomTextBox studId;
        private Label label4;
        private Panel panel2;
    }
}