namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    partial class SessionLogsPage
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
            label3 = new Label();
            panel1 = new Panel();
            sessionsContainer = new FlowLayoutPanel();
            sessionLogsDisplay1 = new SmartCodeLab.CustomComponents.ServerPageComponents.SessionLogsDisplay();
            panel1.SuspendLayout();
            sessionsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(505, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 38);
            label3.TabIndex = 19;
            label3.Text = "Session Logs";
            // 
            // panel1
            // 
            panel1.Controls.Add(sessionsContainer);
            panel1.Location = new Point(458, 163);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 799);
            panel1.TabIndex = 20;
            // 
            // sessionsContainer
            // 
            sessionsContainer.AutoScroll = true;
            sessionsContainer.Controls.Add(sessionLogsDisplay1);
            sessionsContainer.FlowDirection = FlowDirection.TopDown;
            sessionsContainer.Location = new Point(20, 16);
            sessionsContainer.Margin = new Padding(4);
            sessionsContainer.Name = "sessionsContainer";
            sessionsContainer.Size = new Size(845, 766);
            sessionsContainer.TabIndex = 17;
            sessionsContainer.WrapContents = false;
            // 
            // sessionLogsDisplay1
            // 
            sessionLogsDisplay1.BackColor = Color.FromArgb(240, 247, 255);
            sessionLogsDisplay1.BorderColor = Color.Gray;
            sessionLogsDisplay1.BorderRadius = 20;
            sessionLogsDisplay1.BorderSize = 0;
            sessionLogsDisplay1.Location = new Point(4, 2);
            sessionLogsDisplay1.Margin = new Padding(4, 2, 4, 2);
            sessionLogsDisplay1.Name = "sessionLogsDisplay1";
            sessionLogsDisplay1.Size = new Size(825, 80);
            sessionLogsDisplay1.TabIndex = 0;
            // 
            // SessionLogsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "SessionLogsPage";
            Size = new Size(1801, 1049);
            Load += SessionLogsPage_Load;
            panel1.ResumeLayout(false);
            sessionsContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel sessionsContainer;
        private ServerPageComponents.SessionLogsDisplay sessionLogsDisplay1;
    }
}
