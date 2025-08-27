namespace SmartCodeLab.CustomComponents
{
    partial class StringInputDialog
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
            smartButton1 = new SmartButton();
            smartButton2 = new SmartButton();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(1, 3);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(295, 41);
            customTextBox1.TabIndex = 0;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.LightSteelBlue;
            smartButton1.BackgroundColor = Color.LightSteelBlue;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(1, 50);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(139, 36);
            smartButton1.TabIndex = 1;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(157, 50);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(139, 36);
            smartButton2.TabIndex = 2;
            smartButton2.Text = "Ok";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // StringInputDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 88);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(customTextBox1);
            Name = "StringInputDialog";
            Text = "StringInputDialog";
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private SmartButton smartButton1;
        private SmartButton smartButton2;
    }
}