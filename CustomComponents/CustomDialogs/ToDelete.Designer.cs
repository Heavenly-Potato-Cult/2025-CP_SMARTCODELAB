namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ToDelete
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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            testCaseResult1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.TestCaseResult();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(132, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 125);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(505, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(66, 110, 232);
            label2.Location = new Point(0, 65);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 81;
            label2.Text = "Test Cases";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(66, 110, 232);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 80;
            label1.Text = "Test Cases";
            // 
            // testCaseResult1
            // 
            testCaseResult1.Location = new Point(54, 305);
            testCaseResult1.Name = "testCaseResult1";
            testCaseResult1.Size = new Size(1029, 31);
            testCaseResult1.TabIndex = 1;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 682);
            Controls.Add(panel1);
            Controls.Add(testCaseResult1);
            Name = "ToDelete";
            Text = "ToDelete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Pages.ProgrammingTabs.TestCaseResult testCaseResult1;
    }
}