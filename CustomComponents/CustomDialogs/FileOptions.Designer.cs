namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class FileOptions
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
            optionContainer = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // optionContainer
            // 
            optionContainer.AutoSize = true;
            optionContainer.FlowDirection = FlowDirection.TopDown;
            optionContainer.Location = new Point(1, 30);
            optionContainer.Name = "optionContainer";
            optionContainer.Size = new Size(250, 30);
            optionContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(229, 3);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // FileOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(250, 60);
            Controls.Add(label1);
            Controls.Add(optionContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FileOptions";
            Text = "FileOptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel optionContainer;
        private Label label1;
    }
}