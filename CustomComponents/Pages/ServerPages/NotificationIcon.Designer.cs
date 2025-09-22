namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class NotificationIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
            label15 = new Label();
            label14 = new Label();
            userName = new Label();
            message = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(204, 42);
            label15.Name = "label15";
            label15.Size = new Size(116, 25);
            label15.TabIndex = 24;
            label15.Text = "IT202200842";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(72, 42);
            label14.Name = "label14";
            label14.Size = new Size(126, 25);
            label14.TabIndex = 23;
            label14.Text = "2 minutes ago";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.FromArgb(13, 13, 13);
            userName.Location = new Point(72, 14);
            userName.Name = "userName";
            userName.Size = new Size(164, 23);
            userName.TabIndex = 20;
            userName.Text = "Jimmuel Sanggayan";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Gray;
            message.Location = new Point(233, 12);
            message.Name = "message";
            message.Size = new Size(270, 25);
            message.TabIndex = 21;
            message.Text = "submitted solution for activity 1 ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 62);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // NotificationIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Black;
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(userName);
            Controls.Add(message);
            Controls.Add(pictureBox5);
            Name = "NotificationIcon";
            Size = new Size(705, 86);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label14;
        private Label userName;
        private Label message;
        private PictureBox pictureBox5;
    }
}
