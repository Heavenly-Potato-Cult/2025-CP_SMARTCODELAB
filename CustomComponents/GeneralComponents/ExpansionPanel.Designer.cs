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
            titleFlowPanel = new FlowLayoutPanel();
            lblTitle1 = new Label();
            lblTitle2 = new Label();
            lblIcon = new Label();
            contentPanel = new Panel();
            headerPanel.SuspendLayout();
            titleFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(titleFlowPanel);
            headerPanel.Controls.Add(lblIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(639, 48);
            headerPanel.TabIndex = 0;
            // 
            // titleFlowPanel
            // 
            titleFlowPanel.BackColor = Color.Transparent;
            titleFlowPanel.Controls.Add(lblTitle1);
            titleFlowPanel.Controls.Add(lblTitle2);
            titleFlowPanel.Dock = DockStyle.Fill;
            titleFlowPanel.Location = new Point(0, 0);
            titleFlowPanel.Name = "titleFlowPanel";
            titleFlowPanel.Size = new Size(589, 48);
            titleFlowPanel.TabIndex = 0;
            titleFlowPanel.WrapContents = false;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.BackColor = Color.Transparent;
            lblTitle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle1.ForeColor = Color.Black;
            lblTitle1.Location = new Point(3, 15);
            lblTitle1.Margin = new Padding(3, 15, 0, 0);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Padding = new Padding(10, 0, 0, 0);
            lblTitle1.Size = new Size(80, 20);
            lblTitle1.TabIndex = 63;
            lblTitle1.Text = "Test Case";
            lblTitle1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.DimGray;
            lblTitle2.Location = new Point(86, 15);
            lblTitle2.Margin = new Padding(3, 15, 0, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Padding = new Padding(10, 0, 0, 0);
            lblTitle2.Size = new Size(27, 20);
            lblTitle2.TabIndex = 64;
            lblTitle2.Text = "1";
            lblTitle2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = Color.Transparent;
            lblIcon.Cursor = Cursors.Hand;
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
            contentPanel.Cursor = Cursors.Hand;
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
            titleFlowPanel.ResumeLayout(false);
            titleFlowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel contentPanel;
        private Label lblIcon;
        private Label lblTitle1;
        private Label lblTitle2;
        private FlowLayoutPanel titleFlowPanel;
    }
}
