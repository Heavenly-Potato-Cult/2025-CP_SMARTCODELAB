namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class PastedCodeIcon
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
            time = new Label();
            codeLine = new Label();
            SuspendLayout();
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = Color.Black;
            time.Location = new Point(227, 10);
            time.Name = "time";
            time.Size = new Size(89, 25);
            time.TabIndex = 18;
            time.Text = "12:43 PM";
            // 
            // codeLine
            // 
            codeLine.AutoSize = true;
            codeLine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeLine.ForeColor = Color.Black;
            codeLine.Location = new Point(16, 10);
            codeLine.Name = "codeLine";
            codeLine.Size = new Size(32, 25);
            codeLine.TabIndex = 17;
            codeLine.Text = "12";
            // 
            // PastedCodeIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(time);
            Controls.Add(codeLine);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PastedCodeIcon";
            Size = new Size(343, 46);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label time;
        private Label codeLine;
    }
}
