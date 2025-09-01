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
            customTextBox1.BackColor = Color.FromArgb(10, 10, 10);
            customTextBox1.BorderColor = Color.DimGray;
            customTextBox1.BorderFocusColor = Color.Transparent;
            customTextBox1.BorderSize = 0;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(14, 13);
            customTextBox1.Margin = new Padding(3, 2, 3, 2);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(9, 5, 9, 5);
            customTextBox1.Size = new Size(258, 32);
            customTextBox1.TabIndex = 0;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.LightSteelBlue;
            smartButton1.BackgroundColor = Color.LightSteelBlue;
            smartButton1.BorderRadius = 10;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(14, 57);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(122, 27);
            smartButton1.TabIndex = 1;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 10;
            smartButton2.Cursor = Cursors.Hand;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(150, 57);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(122, 27);
            smartButton2.TabIndex = 2;
            smartButton2.Text = "Ok";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // StringInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(287, 96);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(customTextBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StringInputDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StringInputDialog";
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private SmartButton smartButton1;
        private SmartButton smartButton2;
    }
}