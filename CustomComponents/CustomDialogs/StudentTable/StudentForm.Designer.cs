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
            panel1 = new Panel();
            btnClose = new Button();
            label12 = new Label();
            studId = new CustomTextBox();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
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
            smartButton2.Location = new Point(271, 299);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(10, 0, 0, 0);
            smartButton2.Size = new Size(144, 50);
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
            smartButton1.Location = new Point(164, 299);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(101, 50);
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
            studName.Location = new Point(44, 223);
            studName.Name = "studName";
            studName.Padding = new Padding(10, 7, 10, 7);
            studName.ScrollBars = ScrollBars.None;
            studName.Size = new Size(371, 41);
            studName.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 197);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 59;
            label2.Text = "Student Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 59);
            panel1.TabIndex = 58;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(399, 21);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(16, 16);
            btnClose.TabIndex = 25;
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
            label12.Size = new Size(249, 38);
            label12.TabIndex = 24;
            label12.Text = "Add New Student";
            // 
            // studId
            // 
            studId.BackColor = Color.White;
            studId.BorderColor = Color.DarkGray;
            studId.BorderFocusColor = Color.FromArgb(64, 64, 64);
            studId.BorderRadius = 10;
            studId.BorderSize = 1;
            studId.ForeColor = SystemColors.ControlText;
            studId.Location = new Point(44, 133);
            studId.Name = "studId";
            studId.Padding = new Padding(10, 7, 10, 7);
            studId.ScrollBars = ScrollBars.None;
            studId.Size = new Size(371, 41);
            studId.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 107);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 54;
            label4.Text = "Student ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 2);
            panel2.TabIndex = 61;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 370);
            Controls.Add(panel2);
            Controls.Add(studName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(studId);
            Controls.Add(label4);
            Controls.Add(smartButton1);
            Controls.Add(smartButton2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            Load += StudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton1;
        private CustomTextBox studName;
        private Label label2;
        private Panel panel1;
        private Button btnClose;
        private Label label12;
        private CustomTextBox studId;
        private Label label4;
        private Panel panel2;
    }
}