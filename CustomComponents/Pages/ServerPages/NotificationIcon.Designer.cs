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
            time = new Label();
            userName = new Label();
            message = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // time
            // 
            time.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = Color.Gray;
            time.Location = new Point(603, 30);
            time.Name = "time";
            time.Size = new Size(78, 25);
            time.TabIndex = 23;
            time.Text = "2:00 pm";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.FromArgb(13, 13, 13);
            userName.Location = new Point(86, 17);
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
            message.Location = new Point(86, 43);
            message.Name = "message";
            message.Size = new Size(270, 25);
            message.TabIndex = 21;
            message.Text = "submitted solution for activity 1 ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 65);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // NotificationIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Black;
            Controls.Add(time);
            Controls.Add(userName);
            Controls.Add(message);
            Controls.Add(pictureBox5);
            Name = "NotificationIcon";
            Size = new Size(705, 85);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label time;
        private Label userName;
        private Label message;
        private PictureBox pictureBox5;
    }
}
