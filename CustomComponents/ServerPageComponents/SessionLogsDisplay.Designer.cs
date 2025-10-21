namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class SessionLogsDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sessionName = new Label();
            label11 = new Label();
            timeStart = new Label();
            timeEnd = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // sessionName
            // 
            sessionName.AutoSize = true;
            sessionName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sessionName.ForeColor = Color.FromArgb(13, 13, 13);
            sessionName.Location = new Point(24, 14);
            sessionName.Name = "sessionName";
            sessionName.Size = new Size(310, 25);
            sessionName.TabIndex = 14;
            sessionName.Text = "Object-Oriented Programming Lab ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(24, 44);
            label11.Name = "label11";
            label11.Size = new Size(124, 25);
            label11.TabIndex = 19;
            label11.Text = "July 30, 2025 |";
            // 
            // timeStart
            // 
            timeStart.AutoSize = true;
            timeStart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeStart.ForeColor = Color.Gray;
            timeStart.Location = new Point(141, 44);
            timeStart.Name = "timeStart";
            timeStart.Size = new Size(77, 25);
            timeStart.TabIndex = 20;
            timeStart.Text = "1:00 PM";
            // 
            // timeEnd
            // 
            timeEnd.AutoSize = true;
            timeEnd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeEnd.ForeColor = Color.Gray;
            timeEnd.Location = new Point(212, 44);
            timeEnd.Name = "timeEnd";
            timeEnd.Size = new Size(89, 25);
            timeEnd.TabIndex = 21;
            timeEnd.Text = "- 3:00 PM";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(546, 19);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(188, 50);
            smartButton1.TabIndex = 22;
            smartButton1.Text = "View Session";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // SessionLogsDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 247, 255);
            Controls.Add(smartButton1);
            Controls.Add(timeEnd);
            Controls.Add(timeStart);
            Controls.Add(label11);
            Controls.Add(sessionName);
            Name = "SessionLogsDisplay";
            Size = new Size(754, 85);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sessionName;
        private Label label11;
        private Label timeStart;
        private Label timeEnd;
        private GeneralComponents.SmartButton smartButton1;
    }
}
