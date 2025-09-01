namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class LoadingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loader = new Label();
            smartButton1 = new SmartButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 7);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Temporary Loading Dialog";
            // 
            // loader
            // 
            loader.AutoSize = true;
            loader.Location = new Point(62, 35);
            loader.Name = "loader";
            loader.Size = new Size(94, 15);
            loader.TabIndex = 1;
            loader.Text = "Searching Server";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Crimson;
            smartButton1.BackgroundColor = Color.Crimson;
            smartButton1.BorderRadius = 10;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(83, 60);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(126, 26);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 88);
            Controls.Add(smartButton1);
            Controls.Add(loader);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoadingDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Current Loading Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label loader;
        private SmartButton smartButton1;
    }
}