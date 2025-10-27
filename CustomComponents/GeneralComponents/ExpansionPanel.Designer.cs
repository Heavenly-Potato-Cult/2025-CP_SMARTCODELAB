namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    partial class ExpansionPanel
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
            headerPanel = new Panel();
            lblTitle2 = new Label();
            lblTitle1 = new Label();
            lblIcon = new Label();
            contentPanel = new Panel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(lblTitle2);
            headerPanel.Controls.Add(lblTitle1);
            headerPanel.Controls.Add(lblIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(639, 48);
            headerPanel.TabIndex = 0;
            // 
            // lblTitle2
            // 
            lblTitle2.Dock = DockStyle.Left;
            lblTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.DimGray;
            lblTitle2.Location = new Point(86, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Padding = new Padding(10, 0, 0, 0);
            lblTitle2.Size = new Size(86, 48);
            lblTitle2.TabIndex = 64;
            lblTitle2.Text = "1";
            lblTitle2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle1
            // 
            lblTitle1.Dock = DockStyle.Left;
            lblTitle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle1.ForeColor = Color.DimGray;
            lblTitle1.Location = new Point(0, 0);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Padding = new Padding(10, 0, 0, 0);
            lblTitle1.Size = new Size(86, 48);
            lblTitle1.TabIndex = 63;
            lblTitle1.Text = "Test Case";
            lblTitle1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.Dock = DockStyle.Right;
            lblIcon.Location = new Point(589, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(50, 48);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "v";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 48);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(639, 138);
            contentPanel.TabIndex = 1;
            // 
            // ExpansionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Name = "ExpansionPanel";
            Size = new Size(639, 186);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel contentPanel;
        private Label lblIcon;
        private Label lblTitle1;
        private Label lblTitle2;
    }
}
