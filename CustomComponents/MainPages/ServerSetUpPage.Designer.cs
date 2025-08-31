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
            smartButton1 = new SmartButton();
            fileContainer2 = new TaskPageComponents.FileContainer();
            taskContainer = new TaskPageComponents.FileContainer();
            label8 = new Label();
            customCard1 = new CustomCard();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 3;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(42, 266);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(304, 38);
            smartButton1.TabIndex = 8;
            smartButton1.Text = "Start Server";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // fileContainer2
            // 
            fileContainer2.AcceptMultipleFiles = false;
            fileContainer2.ContainerHeight = 39;
            fileContainer2.ForeColor = Color.FromArgb(179, 179, 179);
            fileContainer2.LabelText = "Student Credentials";
            fileContainer2.Location = new Point(42, 159);
            fileContainer2.Margin = new Padding(3, 2, 3, 2);
            fileContainer2.Name = "fileContainer2";
            fileContainer2.Size = new Size(304, 81);
            fileContainer2.TabIndex = 7;
            // 
            // taskContainer
            // 
            taskContainer.AcceptMultipleFiles = false;
            taskContainer.ContainerHeight = 39;
            taskContainer.ForeColor = Color.FromArgb(179, 179, 179);
            taskContainer.LabelText = "Task File";
            taskContainer.Location = new Point(42, 65);
            taskContainer.Margin = new Padding(3, 2, 3, 2);
            taskContainer.Name = "taskContainer";
            taskContainer.Size = new Size(304, 90);
            taskContainer.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(242, 242, 242);
            label8.Location = new Point(115, 13);
            label8.Name = "label8";
            label8.Size = new Size(164, 30);
            label8.TabIndex = 5;
            label8.Text = "SERVER SET UP";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(13, 13, 13);
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 0;
            customCard1.Controls.Add(smartButton1);
            customCard1.Controls.Add(label8);
            customCard1.Controls.Add(fileContainer2);
            customCard1.Controls.Add(taskContainer);
            customCard1.Location = new Point(365, 166);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(395, 342);
            customCard1.TabIndex = 1;
            // 
            // ServerSetUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(customCard1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ServerSetUpPage";
            Size = new Size(1168, 674);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TaskPageComponents.FileContainer fileContainer2;
        private TaskPageComponents.FileContainer taskContainer;
        private Label label8;
        private SmartButton smartButton1;
        private CustomCard customCard1;
    }
}
