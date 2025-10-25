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
            customToggleButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomToggleButton();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            accuracy = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label15 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            accuracyPanel = new Panel();
            button3 = new Button();
            result = new Label();
            label7 = new Label();
            readabilityContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            readability = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            button2 = new Button();
            label2 = new Label();
            standardErrors = new RichTextBox();
            efficiencyContainer = new Panel();
            efficiency = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            actualCycComplexity = new Label();
            expectedCycComplexity = new Label();
            label5 = new Label();
            label4 = new Label();
            complexity = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label1 = new Label();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            accuracyPanel.SuspendLayout();
            readabilityContainer.SuspendLayout();
            panel4.SuspendLayout();
            efficiencyContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(240, 247, 255);
            panel19.Controls.Add(score);
            panel19.Controls.Add(customToggleButton1);
            panel19.Controls.Add(pictureBox7);
            panel19.Controls.Add(label9);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(391, 56);
            panel19.TabIndex = 77;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.FromArgb(66, 110, 232);
            score.Location = new Point(125, 13);
            score.Name = "score";
            score.Size = new Size(27, 31);
            score.TabIndex = 81;
            score.Text = "0";
            // 
            // customToggleButton1
            // 
            customToggleButton1.AutoSize = true;
            customToggleButton1.Checked = true;
            customToggleButton1.CheckState = CheckState.Checked;
            customToggleButton1.Location = new Point(333, 15);
            customToggleButton1.Margin = new Padding(3, 4, 3, 4);
            customToggleButton1.MinimumSize = new Size(51, 29);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColor = Color.Gray;
            customToggleButton1.OffToggleColor = Color.Gainsboro;
            customToggleButton1.OnBackColor = Color.MediumSlateBlue;
            customToggleButton1.OnToggleColor = Color.WhiteSmoke;
            customToggleButton1.Size = new Size(51, 29);
            customToggleButton1.TabIndex = 80;
            customToggleButton1.UseVisualStyleBackColor = true;
            customToggleButton1.CheckedChanged += customToggleButton1_CheckedChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(23, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 25);
            pictureBox7.TabIndex = 78;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(66, 110, 232);
            label9.Location = new Point(51, 13);
            label9.Name = "label9";
            label9.Size = new Size(73, 31);
            label9.TabIndex = 79;
            label9.Text = "Score";
            // 
            // accuracy
            // 
            accuracy.Location = new Point(120, 11);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(206, 13);
            accuracy.TabIndex = 81;
            accuracy.Value = 38;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(accuracyPanel);
            flowLayoutPanel1.Controls.Add(readabilityContainer);
            flowLayoutPanel1.Controls.Add(efficiencyContainer);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(385, 165);
            flowLayoutPanel1.TabIndex = 79;
            flowLayoutPanel1.WrapContents = false;
            // 
            // accuracyPanel
            // 
            accuracyPanel.Controls.Add(button3);
            accuracyPanel.Controls.Add(result);
            accuracyPanel.Controls.Add(label7);
            accuracyPanel.Controls.Add(accuracy);
            accuracyPanel.Controls.Add(label15);
            accuracyPanel.Location = new Point(3, 3);
            accuracyPanel.Name = "accuracyPanel";
            accuracyPanel.Size = new Size(377, 36);
            accuracyPanel.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(330, 3);
            button3.Name = "button3";
            button3.Size = new Size(23, 24);
            button3.TabIndex = 90;
            button3.Text = "V";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(117, 38);
            result.Name = "result";
            result.Size = new Size(18, 20);
            result.TabIndex = 89;
            result.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 38);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 88;
            label7.Text = "Test Result";
            // 
            // readabilityContainer
            // 
            readabilityContainer.Controls.Add(panel4);
            readabilityContainer.Controls.Add(standardErrors);
            readabilityContainer.Location = new Point(3, 45);
            readabilityContainer.Name = "readabilityContainer";
            readabilityContainer.Size = new Size(377, 36);
            readabilityContainer.TabIndex = 83;
            // 
            // panel4
            // 
            panel4.Controls.Add(readability);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 31);
            panel4.TabIndex = 0;
            // 
            // readability
            // 
            readability.Location = new Point(114, 12);
            readability.Name = "readability";
            readability.Size = new Size(209, 13);
            readability.TabIndex = 83;
            readability.Value = 38;
            // 
            // button2
            // 
            button2.Location = new Point(328, 3);
            button2.Name = "button2";
            button2.Size = new Size(23, 24);
            button2.TabIndex = 1;
            button2.Text = "V";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(-2, 5);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 82;
            label2.Text = "Readability";
            // 
            // standardErrors
            // 
            standardErrors.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            standardErrors.Location = new Point(3, 40);
            standardErrors.Name = "standardErrors";
            standardErrors.Size = new Size(350, 347);
            standardErrors.TabIndex = 1;
            standardErrors.Text = "Readability errors";
            // 
            // efficiencyContainer
            // 
            efficiencyContainer.Controls.Add(efficiency);
            efficiencyContainer.Controls.Add(label3);
            efficiencyContainer.Location = new Point(3, 87);
            efficiencyContainer.Name = "efficiencyContainer";
            efficiencyContainer.Size = new Size(377, 33);
            efficiencyContainer.TabIndex = 85;
            // 
            // efficiency
            // 
            efficiency.Location = new Point(120, 11);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(234, 13);
            efficiency.TabIndex = 81;
            efficiency.Value = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(5, 4);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 80;
            label3.Text = "Efficiency";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(actualCycComplexity);
            panel1.Controls.Add(expectedCycComplexity);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(complexity);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 33);
            panel1.TabIndex = 84;
            // 
            // button1
            // 
            button1.Location = new Point(330, 2);
            button1.Name = "button1";
            button1.Size = new Size(23, 24);
            button1.TabIndex = 89;
            button1.Text = "V";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // actualCycComplexity
            // 
            actualCycComplexity.AutoSize = true;
            actualCycComplexity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actualCycComplexity.Location = new Point(221, 67);
            actualCycComplexity.Name = "actualCycComplexity";
            actualCycComplexity.Size = new Size(18, 20);
            actualCycComplexity.TabIndex = 88;
            actualCycComplexity.Text = "0";
            // 
            // expectedCycComplexity
            // 
            expectedCycComplexity.AutoSize = true;
            expectedCycComplexity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expectedCycComplexity.Location = new Point(221, 36);
            expectedCycComplexity.Name = "expectedCycComplexity";
            expectedCycComplexity.Size = new Size(18, 20);
            expectedCycComplexity.TabIndex = 87;
            expectedCycComplexity.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 67);
            label5.Name = "label5";
            label5.Size = new Size(177, 17);
            label5.TabIndex = 86;
            label5.Text = "Actual Cyclomatic Complexity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 36);
            label4.Name = "label4";
            label4.Size = new Size(179, 17);
            label4.TabIndex = 85;
            label4.Text = "Target Cyclomatic Complexity";
            // 
            // complexity
            // 
            complexity.Location = new Point(120, 11);
            complexity.Name = "complexity";
            complexity.Size = new Size(206, 13);
            complexity.TabIndex = 84;
            complexity.Value = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(5, 4);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 80;
            label1.Text = "Complexity";
            // 
            // StudentCodeRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel19);
            Name = "StudentCodeRating";
            Size = new Size(391, 229);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            accuracyPanel.ResumeLayout(false);
            accuracyPanel.PerformLayout();
            readabilityContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            efficiencyContainer.ResumeLayout(false);
            efficiencyContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel19;
        private PictureBox pictureBox7;
        private Label label9;
        private GeneralComponents.StatsBar accuracy;
        private Label label15;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel accuracyPanel;
        private FlowLayoutPanel readabilityContainer;
        private Panel panel4;
        private GeneralComponents.StatsBar readability;
        private Button button2;
        private Label label2;
        private RichTextBox standardErrors;
        private Panel panel1;
        private Label label1;
        private GeneralComponents.StatsBar complexity;
        private Panel efficiencyContainer;
        private GeneralComponents.StatsBar efficiency;
        private Label label3;
        private GeneralComponents.CustomToggleButton customToggleButton1;
        private Label score;
        private Label label5;
        private Label label4;
        private Label actualCycComplexity;
        private Label expectedCycComplexity;
        private Button button1;
        private Label result;
        private Label label7;
        private Button button3;
    }
}
