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
            panel19 = new Panel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            score = new Label();
            label9 = new Label();
            readabilityContainer = new Panel();
            efficiency = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label2 = new Label();
            robustnessContainer = new Panel();
            robustness = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label3 = new Label();
            maintainabilityContainer = new Panel();
            label1 = new Label();
            maintainability = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            accuracyPanel = new Panel();
            accuracy = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label15 = new Label();
            panel2 = new Panel();
            panel19.SuspendLayout();
            readabilityContainer.SuspendLayout();
            robustnessContainer.SuspendLayout();
            maintainabilityContainer.SuspendLayout();
            accuracyPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.Controls.Add(smartButton1);
            panel19.Controls.Add(score);
            panel19.Controls.Add(label9);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(442, 56);
            panel19.TabIndex = 77;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 5;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(339, 18);
            smartButton1.Margin = new Padding(3, 4, 3, 4);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(86, 34);
            smartButton1.TabIndex = 82;
            smartButton1.Text = "View More";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.FromArgb(66, 110, 232);
            score.Location = new Point(81, 16);
            score.Name = "score";
            score.Size = new Size(27, 31);
            score.TabIndex = 81;
            score.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(66, 110, 232);
            label9.Location = new Point(8, 16);
            label9.Name = "label9";
            label9.Size = new Size(73, 31);
            label9.TabIndex = 79;
            label9.Text = "Score";
            // 
            // readabilityContainer
            // 
            readabilityContainer.BackColor = Color.White;
            readabilityContainer.Controls.Add(efficiency);
            readabilityContainer.Controls.Add(label2);
            readabilityContainer.Dock = DockStyle.Top;
            readabilityContainer.Location = new Point(0, 40);
            readabilityContainer.Name = "readabilityContainer";
            readabilityContainer.Size = new Size(437, 40);
            readabilityContainer.TabIndex = 0;
            // 
            // efficiency
            // 
            efficiency.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            efficiency.Location = new Point(139, 16);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(283, 13);
            efficiency.TabIndex = 83;
            efficiency.Value = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 3);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 82;
            label2.Text = "Efficiency";
            // 
            // robustnessContainer
            // 
            robustnessContainer.Controls.Add(robustness);
            robustnessContainer.Controls.Add(label3);
            robustnessContainer.Dock = DockStyle.Top;
            robustnessContainer.Location = new Point(0, 80);
            robustnessContainer.Name = "robustnessContainer";
            robustnessContainer.Size = new Size(437, 40);
            robustnessContainer.TabIndex = 85;
            // 
            // robustness
            // 
            robustness.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            robustness.Location = new Point(139, 12);
            robustness.Name = "robustness";
            robustness.Size = new Size(283, 13);
            robustness.TabIndex = 81;
            robustness.Value = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(5, 4);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 80;
            label3.Text = "Robustness";
            // 
            // maintainabilityContainer
            // 
            maintainabilityContainer.Controls.Add(label1);
            maintainabilityContainer.Controls.Add(maintainability);
            maintainabilityContainer.Dock = DockStyle.Top;
            maintainabilityContainer.Location = new Point(0, 120);
            maintainabilityContainer.Margin = new Padding(3, 4, 3, 4);
            maintainabilityContainer.Name = "maintainabilityContainer";
            maintainabilityContainer.Size = new Size(437, 40);
            maintainabilityContainer.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 80;
            label1.Text = "Maintainability";
            // 
            // maintainability
            // 
            maintainability.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maintainability.Location = new Point(139, 13);
            maintainability.Name = "maintainability";
            maintainability.Size = new Size(283, 13);
            maintainability.TabIndex = 84;
            maintainability.Value = 100;
            // 
            // accuracyPanel
            // 
            accuracyPanel.Controls.Add(accuracy);
            accuracyPanel.Controls.Add(label15);
            accuracyPanel.Dock = DockStyle.Top;
            accuracyPanel.Location = new Point(0, 0);
            accuracyPanel.Name = "accuracyPanel";
            accuracyPanel.Size = new Size(437, 40);
            accuracyPanel.TabIndex = 1;
            // 
            // accuracy
            // 
            accuracy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accuracy.Location = new Point(139, 13);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(283, 13);
            accuracy.TabIndex = 81;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(5, 4);
            label15.Name = "label15";
            label15.Size = new Size(84, 25);
            label15.TabIndex = 80;
            label15.Text = "Accuracy";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(maintainabilityContainer);
            panel2.Controls.Add(robustnessContainer);
            panel2.Controls.Add(readabilityContainer);
            panel2.Controls.Add(accuracyPanel);
            panel2.Location = new Point(3, 63);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 191);
            panel2.TabIndex = 89;
            // 
            // StudentCodeRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel19);
            Name = "StudentCodeRating";
            Size = new Size(442, 256);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            readabilityContainer.ResumeLayout(false);
            readabilityContainer.PerformLayout();
            robustnessContainer.ResumeLayout(false);
            robustnessContainer.PerformLayout();
            maintainabilityContainer.ResumeLayout(false);
            maintainabilityContainer.PerformLayout();
            accuracyPanel.ResumeLayout(false);
            accuracyPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel19;
        private Label label9;
        private GeneralComponents.StatsBar efficiency;
        private Label label2;
        private Label label1;
        private GeneralComponents.StatsBar maintainability;
        private Panel robustnessContainer;
        private GeneralComponents.StatsBar robustness;
        private Label label3;
        private Label score;
        private Panel maintainabilityContainer;
        private Panel readabilityContainer;
        private Panel accuracyPanel;
        private GeneralComponents.StatsBar accuracy;
        private Label label15;
        private GeneralComponents.SmartButton smartButton1;
        private Panel panel2;
    }
}
