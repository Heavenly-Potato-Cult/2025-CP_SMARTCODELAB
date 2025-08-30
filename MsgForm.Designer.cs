namespace SmartCodeLab
{
    partial class MsgForm
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
            msgs = new TextBox();
            tosend = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // msgs
            // 
            msgs.Location = new Point(12, 12);
            msgs.Multiline = true;
            msgs.Name = "msgs";
            msgs.ReadOnly = true;
            msgs.Size = new Size(474, 385);
            msgs.TabIndex = 0;
            // 
            // tosend
            // 
            tosend.Location = new Point(12, 403);
            tosend.Name = "tosend";
            tosend.Size = new Size(371, 27);
            tosend.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(392, 401);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            // 
            // MsgForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(498, 592);
            Controls.Add(button1);
            Controls.Add(tosend);
            Controls.Add(msgs);
            Name = "MsgForm";
            Text = "MsgForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox msgs;
        private TextBox tosend;
        private Button button1;
    }
}