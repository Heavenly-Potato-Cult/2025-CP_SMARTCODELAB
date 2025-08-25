namespace SmartCodeLab.CustomComponents
{
    partial class CustomTextBox
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 22);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_MouseEnter;
            // 
            // CustomTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(textBox1);
            ForeColor = Color.DimGray;
            Name = "CustomTextBox";
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(250, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
