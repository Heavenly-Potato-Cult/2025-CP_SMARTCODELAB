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
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = Color.Gray;
            time.Location = new Point(487, 13);
            time.Name = "time";
            time.Size = new Size(103, 20);
            time.TabIndex = 23;
            time.Text = "2 minutes ago";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.FromArgb(13, 13, 13);
            userName.Location = new Point(75, 13);
            userName.Name = "userName";
            userName.Size = new Size(134, 19);
            userName.TabIndex = 20;
            userName.Text = "Jimmuel Sanggayan";
            userName.Click += userName_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Gray;
            message.Location = new Point(75, 32);
            message.Name = "message";
            message.Size = new Size(223, 20);
            message.TabIndex = 21;
            message.Text = "submitted solution for activity 1 ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 2);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 60);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // NotificationIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Black;
            Controls.Add(time);
            Controls.Add(userName);
            Controls.Add(message);
            Controls.Add(pictureBox5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NotificationIcon";
            Size = new Size(617, 64);
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
