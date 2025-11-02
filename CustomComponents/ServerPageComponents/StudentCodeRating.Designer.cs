namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class StudentCodeRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCodeRating));
            panel19 = new Panel();
            score = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            readabilityContainer = new Panel();
            readability = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label2 = new Label();
            efficiencyContainer = new Panel();
            efficiency = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            complexity = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            accuracyPanel = new Panel();
            accuracy = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label15 = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            readabilityContainer.SuspendLayout();
            efficiencyContainer.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            accuracyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(240, 247, 255);
            panel19.Controls.Add(smartButton1);
            panel19.Controls.Add(score);
            panel19.Controls.Add(pictureBox7);
            panel19.Controls.Add(label9);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 0);
            panel19.Margin = new Padding(3, 2, 3, 2);
            panel19.Name = "panel19";
            panel19.Size = new Size(391, 42);
            panel19.TabIndex = 77;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.FromArgb(66, 110, 232);
            score.Location = new Point(109, 10);
            score.Name = "score";
            score.Size = new Size(45, 25);
            score.TabIndex = 81;
            score.Text = "100";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(20, 14);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 19);
            pictureBox7.TabIndex = 78;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(66, 110, 232);
            label9.Location = new Point(45, 10);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 79;
            label9.Text = "Score";
            // 
            // readabilityContainer
            // 
            readabilityContainer.BackColor = Color.White;
            readabilityContainer.Controls.Add(readability);
            readabilityContainer.Controls.Add(label2);
            readabilityContainer.Location = new Point(3, 36);
            readabilityContainer.Margin = new Padding(3, 2, 3, 2);
            readabilityContainer.Name = "readabilityContainer";
            readabilityContainer.Size = new Size(376, 30);
            readabilityContainer.TabIndex = 0;
            // 
            // readability
            // 
            readability.Location = new Point(122, 12);
            readability.Margin = new Padding(3, 2, 3, 2);
            readability.Name = "readability";
            readability.Size = new Size(242, 10);
            readability.TabIndex = 83;
            readability.Value = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(4, 2);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 82;
            label2.Text = "Readability";
            // 
            // efficiencyContainer
            // 
            efficiencyContainer.Controls.Add(efficiency);
            efficiencyContainer.Controls.Add(label3);
            efficiencyContainer.Location = new Point(3, 70);
            efficiencyContainer.Margin = new Padding(3, 2, 3, 2);
            efficiencyContainer.Name = "efficiencyContainer";
            efficiencyContainer.Size = new Size(376, 30);
            efficiencyContainer.TabIndex = 85;
            // 
            // efficiency
            // 
            efficiency.Location = new Point(122, 9);
            efficiency.Margin = new Padding(3, 2, 3, 2);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(242, 10);
            efficiency.TabIndex = 81;
            efficiency.Value = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(4, 3);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 80;
            label3.Text = "Robustness";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(complexity);
            panel1.Location = new Point(3, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 30);
            panel1.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 80;
            label1.Text = "Maintainability";
            // 
            // complexity
            // 
            complexity.Location = new Point(122, 10);
            complexity.Margin = new Padding(3, 2, 3, 2);
            complexity.Name = "complexity";
            complexity.Size = new Size(242, 10);
            complexity.TabIndex = 84;
            complexity.Value = 100;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(accuracyPanel);
            flowLayoutPanel1.Controls.Add(readabilityContainer);
            flowLayoutPanel1.Controls.Add(efficiencyContainer);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(382, 143);
            flowLayoutPanel1.TabIndex = 88;
            flowLayoutPanel1.WrapContents = false;
            // 
            // accuracyPanel
            // 
            accuracyPanel.Controls.Add(accuracy);
            accuracyPanel.Controls.Add(label15);
            accuracyPanel.Location = new Point(3, 2);
            accuracyPanel.Margin = new Padding(3, 2, 3, 2);
            accuracyPanel.Name = "accuracyPanel";
            accuracyPanel.Size = new Size(376, 30);
            accuracyPanel.TabIndex = 1;
            // 
            // accuracy
            // 
            accuracy.Location = new Point(122, 10);
            accuracy.Margin = new Padding(3, 2, 3, 2);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(242, 10);
            accuracy.TabIndex = 81;
            accuracy.Value = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(4, 3);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 80;
            label15.Text = "Accuracy";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(230, 5);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(140, 34);
            smartButton1.TabIndex = 82;
            smartButton1.Text = "View More";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // StudentCodeRating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel19);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentCodeRating";
            Size = new Size(391, 193);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            readabilityContainer.ResumeLayout(false);
            readabilityContainer.PerformLayout();
            efficiencyContainer.ResumeLayout(false);
            efficiencyContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            accuracyPanel.ResumeLayout(false);
            accuracyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel19;
        private PictureBox pictureBox7;
        private Label label9;
        private GeneralComponents.StatsBar readability;
        private Label label2;
        private Label label1;
        private GeneralComponents.StatsBar complexity;
        private Panel efficiencyContainer;
        private GeneralComponents.StatsBar efficiency;
        private Label label3;
        private Label score;
        private Panel panel1;
        private Panel readabilityContainer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel accuracyPanel;
        private GeneralComponents.StatsBar accuracy;
        private Label label15;
        private GeneralComponents.SmartButton smartButton1;
    }
}
