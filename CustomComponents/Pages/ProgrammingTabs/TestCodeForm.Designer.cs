namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class TestCodeForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label17 = new Label();
            label1 = new Label();
            currentScore = new Label();
            label3 = new Label();
            total = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(1, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1053, 573);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(1, 9);
            label17.Name = "label17";
            label17.Size = new Size(91, 31);
            label17.TabIndex = 79;
            label17.Text = "Testing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(546, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 80;
            label1.Text = "Score";
            // 
            // currentScore
            // 
            currentScore.AutoSize = true;
            currentScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentScore.ForeColor = Color.Black;
            currentScore.Location = new Point(625, 9);
            currentScore.Name = "currentScore";
            currentScore.Size = new Size(27, 31);
            currentScore.TabIndex = 81;
            currentScore.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(648, 9);
            label3.Name = "label3";
            label3.Size = new Size(24, 31);
            label3.TabIndex = 82;
            label3.Text = "/";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.Black;
            total.Location = new Point(667, 9);
            total.Name = "total";
            total.Size = new Size(73, 31);
            total.TabIndex = 81;
            total.Text = "Score";
            // 
            // TestCodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 645);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(currentScore);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(flowLayoutPanel1);
            Name = "TestCodeForm";
            Text = "TestCodeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label17;
        private Label label1;
        private Label currentScore;
        private Label label3;
        private Label total;
    }
}