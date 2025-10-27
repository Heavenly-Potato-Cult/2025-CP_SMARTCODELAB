namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ChatBox
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            studentName = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(431, 267);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(2, 314);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(431, 92);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(2, 18);
            studentName.Name = "studentName";
            studentName.Size = new Size(50, 20);
            studentName.TabIndex = 2;
            studentName.Text = "label1";
            // 
            // MessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 418);
            Controls.Add(studentName);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "MessageBox";
            Text = "MessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label studentName;
    }
}