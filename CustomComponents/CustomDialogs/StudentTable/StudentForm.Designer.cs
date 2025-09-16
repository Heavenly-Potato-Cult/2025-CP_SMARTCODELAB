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
            studId = new CustomTextBox();
            studName = new CustomTextBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // studId
            // 
            studId.BackColor = SystemColors.Window;
            studId.ForeColor = Color.DimGray;
            studId.Location = new Point(0, 0);
            studId.Name = "studId";
            studId.Padding = new Padding(10, 7, 10, 7);
            studId.ScrollBars = ScrollBars.None;
            studId.Size = new Size(190, 41);
            studId.TabIndex = 0;
            // 
            // studName
            // 
            studName.BackColor = SystemColors.Window;
            studName.ForeColor = Color.DimGray;
            studName.Location = new Point(0, 47);
            studName.Name = "studName";
            studName.Padding = new Padding(10, 7, 10, 7);
            studName.ScrollBars = ScrollBars.None;
            studName.Size = new Size(403, 41);
            studName.TabIndex = 1;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(12, 94);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(148, 50);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 20;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(244, 94);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(148, 50);
            smartButton2.TabIndex = 3;
            smartButton2.Text = "Add";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 153);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(studName);
            Controls.Add(studId);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox studId;
        private CustomTextBox studName;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton2;
    }
}