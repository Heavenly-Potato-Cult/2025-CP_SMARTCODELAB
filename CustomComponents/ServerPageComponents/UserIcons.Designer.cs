namespace SmartCodeLab.CustomComponents
{
    partial class UserIcons
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
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            status = new Label();
            username = new Label();
            customCard3.SuspendLayout();
            SuspendLayout();
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.White;
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 10;
            customCard3.BorderSize = 1;
            customCard3.Controls.Add(status);
            customCard3.Controls.Add(username);
            customCard3.Location = new Point(3, 3);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(240, 61);
            customCard3.TabIndex = 9;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.ForeColor = Color.FromArgb(0, 192, 0);
            status.Location = new Point(28, 33);
            status.Name = "status";
            status.Size = new Size(42, 17);
            status.TabIndex = 10;
            status.Text = "Active";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.FromArgb(13, 13, 13);
            username.Location = new Point(28, 9);
            username.Name = "username";
            username.Size = new Size(85, 23);
            username.TabIndex = 9;
            username.Text = "username";
            // 
            // UserIcons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(customCard3);
            Name = "UserIcons";
            Size = new Size(246, 66);
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CustomCard customCard3;
        private Label status;
        private Label username;
    }
}
