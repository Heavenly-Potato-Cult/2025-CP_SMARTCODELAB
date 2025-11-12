namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class TextInputDialog
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
            customTextBox1 = new CustomTextBox();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(0, 1);
            customTextBox1.Margin = new Padding(3, 2, 3, 2);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(9, 5, 9, 5);
            customTextBox1.PlaceHolderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.ScrollBars = ScrollBars.None;
            customTextBox1.Size = new Size(283, 32);
            customTextBox1.TabIndex = 0;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Red;
            smartButton1.BackgroundColor = Color.Red;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(22, 36);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(101, 28);
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
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(157, 36);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(101, 28);
            smartButton2.TabIndex = 2;
            smartButton2.Text = "OK";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // TextInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 67);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(customTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TextInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextInputDialog";
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton2;
    }
}