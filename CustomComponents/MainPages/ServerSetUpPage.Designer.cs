using SmartCodeLab.CustomComponents.GeneralComponents;

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
            userCredentials = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            taskContainer = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
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
            smartButton1.Location = new Point(48, 355);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(347, 51);
            smartButton1.TabIndex = 8;
            smartButton1.Text = "Start Server";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // userCredentials
            // 
            userCredentials.AcceptMultipleFiles = false;
            userCredentials.ContainerHeight = 39;
            userCredentials.ForeColor = Color.FromArgb(179, 179, 179);
            userCredentials.LabelText = "Student Credentials";
            userCredentials.Location = new Point(48, 212);
            userCredentials.Name = "userCredentials";
            userCredentials.Size = new Size(347, 108);
            userCredentials.TabIndex = 7;
            // 
            // taskContainer
            // 
            taskContainer.AcceptMultipleFiles = false;
            taskContainer.ContainerHeight = 39;
            taskContainer.ForeColor = Color.FromArgb(179, 179, 179);
            taskContainer.LabelText = "Task File";
            taskContainer.Location = new Point(48, 87);
            taskContainer.Name = "taskContainer";
            taskContainer.Size = new Size(347, 120);
            taskContainer.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(242, 242, 242);
            label8.Location = new Point(131, 17);
            label8.Name = "label8";
            label8.Size = new Size(210, 37);
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
            customCard1.Controls.Add(userCredentials);
            customCard1.Controls.Add(taskContainer);
            customCard1.Location = new Point(417, 221);
            customCard1.Margin = new Padding(3, 4, 3, 4);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(451, 456);
            customCard1.TabIndex = 1;
            // 
            // ServerSetUpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(customCard1);
            Name = "ServerSetUpPage";
            Size = new Size(1335, 994);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TaskPageComponents.FileContainer userCredentials;
        private TaskPageComponents.FileContainer taskContainer;
        private Label label8;
        private SmartButton smartButton1;
        private CustomCard customCard1;
    }
}
