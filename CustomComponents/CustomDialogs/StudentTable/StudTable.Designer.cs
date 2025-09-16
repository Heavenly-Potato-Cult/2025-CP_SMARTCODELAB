namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    partial class StudTable
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
            studtab = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // studtab
            // 
            studtab.AutoScroll = true;
            studtab.BorderStyle = BorderStyle.FixedSingle;
            studtab.FlowDirection = FlowDirection.TopDown;
            studtab.Location = new Point(2, 41);
            studtab.Name = "studtab";
            studtab.Size = new Size(624, 466);
            studtab.TabIndex = 0;
            studtab.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 18);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(515, 3);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(70, 35);
            smartButton1.TabIndex = 3;
            smartButton1.Text = "Add";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // StudTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 509);
            Controls.Add(smartButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(studtab);
            Name = "StudTable";
            Text = "StudTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel studtab;
        private Label label1;
        private Label label2;
        private GeneralComponents.SmartButton smartButton1;
    }
}