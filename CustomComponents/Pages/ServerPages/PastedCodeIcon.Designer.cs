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
            panelIcon = new SmartCodeLab.CustomComponents.GeneralComponents.RoundedUserControl();
            SuspendLayout();
            // 
            // time
            // 
            time.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            time.AutoSize = true;
            time.BackColor = Color.LightGray;
            time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = Color.Black;
            time.Location = new Point(285, 3);
            time.Name = "time";
            time.Size = new Size(87, 25);
            time.TabIndex = 18;
            time.Text = "12:43 PM";
            // 
            // codeLine
            // 
            codeLine.AutoSize = true;
            codeLine.BackColor = Color.LightGray;
            codeLine.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeLine.ForeColor = Color.Black;
            codeLine.Location = new Point(5, 3);
            codeLine.Name = "codeLine";
            codeLine.Size = new Size(32, 25);
            codeLine.TabIndex = 17;
            codeLine.Text = "12";
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.LightGray;
            panelIcon.BorderColor = Color.Gray;
            panelIcon.BorderRadius = 2;
            panelIcon.BorderSize = 0;
            panelIcon.Dock = DockStyle.Fill;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(376, 36);
            panelIcon.TabIndex = 19;
            // 
            // PastedCodeIcon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderRadius = 2;
            Controls.Add(time);
            Controls.Add(codeLine);
            Controls.Add(panelIcon);
            Margin = new Padding(3, 3, 3, 10);
            Name = "PastedCodeIcon";
            Padding = new Padding(0, 0, 0, 5);
            Size = new Size(376, 41);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label time;
        private Label codeLine;
        private GeneralComponents.RoundedUserControl panelIcon;
    }
}
