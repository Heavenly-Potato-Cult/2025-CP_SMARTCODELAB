namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class TextForm
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
            msg = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // msg
            // 
            msg.BackColor = Color.FromArgb(255, 255, 255);
            msg.BorderStyle = BorderStyle.None;
            msg.Depth = 0;
            msg.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            msg.ForeColor = Color.FromArgb(222, 0, 0, 0);
            msg.Location = new Point(3, 2);
            msg.MouseState = MaterialSkin.MouseState.HOVER;
            msg.Name = "msg";
            msg.Size = new Size(347, 76);
            msg.TabIndex = 0;
            msg.Text = "";
            msg.TextChanged += msg_TextChanged;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Crimson;
            smartButton1.BackgroundColor = Color.Crimson;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(63, 84);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(95, 41);
            smartButton1.TabIndex = 1;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 20;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(185, 84);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(84, 41);
            smartButton2.TabIndex = 2;
            smartButton2.Text = "Send";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 128);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(msg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextForm";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox msg;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton2;
    }
}