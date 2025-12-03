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
            richTextBox2 = new RichTextBox();
            steamChatBox1 = new SmartCodeLab.CustomComponents.SteamThings.SteamChatBox();
            studentName = new Label();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Dock = DockStyle.Bottom;
            richTextBox2.Location = new Point(0, 326);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(434, 92);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // steamChatBox1
            // 
            steamChatBox1.BackColor = Color.FromArgb(23, 26, 33);
            steamChatBox1.BorderStyle = BorderStyle.None;
            steamChatBox1.Dock = DockStyle.Fill;
            steamChatBox1.DrawMode = DrawMode.OwnerDrawVariable;
            steamChatBox1.FormattingEnabled = true;
            steamChatBox1.IntegralHeight = false;
            steamChatBox1.Location = new Point(0, 20);
            steamChatBox1.Name = "steamChatBox1";
            steamChatBox1.Size = new Size(434, 306);
            steamChatBox1.TabIndex = 3;
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Dock = DockStyle.Top;
            studentName.Location = new Point(0, 0);
            studentName.Name = "studentName";
            studentName.Size = new Size(50, 20);
            studentName.TabIndex = 2;
            studentName.Text = "label1";
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 418);
            Controls.Add(steamChatBox1);
            Controls.Add(studentName);
            Controls.Add(richTextBox2);
            Name = "ChatBox";
            Text = "MessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox2;
        private SteamThings.SteamChatBox steamChatBox1;
        private Label studentName;
    }
}