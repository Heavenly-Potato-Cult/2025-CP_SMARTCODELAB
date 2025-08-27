namespace SmartCodeLab.CustomComponents.MainPages
{
    partial class ServerSetUpPage
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
            panel1 = new Panel();
            label8 = new Label();
            fileContainer1 = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            fileContainer2 = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            smartButton1 = new SmartButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(smartButton1);
            panel1.Controls.Add(fileContainer2);
            panel1.Controls.Add(fileContainer1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(420, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 358);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(112, 11);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 5;
            label8.Text = "Server Set Up";
            // 
            // fileContainer1
            // 
            fileContainer1.AcceptMultipleFiles = false;
            fileContainer1.ContainerHeight = 39;
            fileContainer1.LabelText = "Task File";
            fileContainer1.Location = new Point(10, 72);
            fileContainer1.Name = "fileContainer1";
            fileContainer1.Size = new Size(355, 80);
            fileContainer1.TabIndex = 6;
            // 
            // fileContainer2
            // 
            fileContainer2.AcceptMultipleFiles = false;
            fileContainer2.ContainerHeight = 39;
            fileContainer2.LabelText = "Student Credentials";
            fileContainer2.Location = new Point(10, 197);
            fileContainer2.Name = "fileContainer2";
            fileContainer2.Size = new Size(348, 80);
            fileContainer2.TabIndex = 7;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(102, 305);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(188, 50);
            smartButton1.TabIndex = 8;
            smartButton1.Text = "Start Server";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // ServerSetUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(panel1);
            Name = "ServerSetUpPage";
            Size = new Size(1335, 899);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TaskPageComponents.FileContainer fileContainer2;
        private TaskPageComponents.FileContainer fileContainer1;
        private Label label8;
        private SmartButton smartButton1;
    }
}
