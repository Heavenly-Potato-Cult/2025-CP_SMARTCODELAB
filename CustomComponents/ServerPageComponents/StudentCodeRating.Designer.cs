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
            pictureBox7 = new PictureBox();
            label9 = new Label();
            accuracy = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label15 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            readabilityContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            readability = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            button2 = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            efficiencyContainer = new Panel();
            efficiency = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label3 = new Label();
            panel1 = new Panel();
            complexity = new SmartCodeLab.CustomComponents.GeneralComponents.StatsBar();
            label1 = new Label();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            readabilityContainer.SuspendLayout();
            panel4.SuspendLayout();
            efficiencyContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(240, 247, 255);
            panel19.Controls.Add(pictureBox7);
            panel19.Controls.Add(label9);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(455, 56);
            panel19.TabIndex = 77;
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
            accuracy.Size = new Size(290, 13);
            accuracy.TabIndex = 81;
            accuracy.Value = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(4, 4);
            label15.Name = "label15";
            label15.Size = new Size(84, 25);
            label15.TabIndex = 80;
            label15.Text = "Accuracy";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(readabilityContainer);
            flowLayoutPanel1.Controls.Add(efficiencyContainer);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(452, 168);
            flowLayoutPanel1.TabIndex = 79;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(accuracy);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(436, 33);
            panel3.TabIndex = 0;
            // 
            // readabilityContainer
            // 
            readabilityContainer.Controls.Add(panel4);
            readabilityContainer.Controls.Add(richTextBox1);
            readabilityContainer.Location = new Point(3, 42);
            readabilityContainer.Name = "readabilityContainer";
            readabilityContainer.Size = new Size(436, 39);
            readabilityContainer.TabIndex = 83;
            // 
            // panel4
            // 
            panel4.Controls.Add(readability);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 31);
            panel4.TabIndex = 0;
            // 
            // readability
            // 
            readability.Location = new Point(114, 12);
            readability.Name = "readability";
            readability.Size = new Size(290, 13);
            readability.TabIndex = 83;
            readability.Value = 38;
            // 
            // button2
            // 
            button2.Location = new Point(404, 5);
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(437, 347);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Readability errors";
            // 
            // efficiencyContainer
            // 
            efficiencyContainer.Controls.Add(efficiency);
            efficiencyContainer.Controls.Add(label3);
            efficiencyContainer.Location = new Point(3, 87);
            efficiencyContainer.Name = "efficiencyContainer";
            efficiencyContainer.Size = new Size(436, 33);
            efficiencyContainer.TabIndex = 85;
            // 
            // efficiency
            // 
            efficiency.Location = new Point(120, 11);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(290, 13);
            efficiency.TabIndex = 81;
            efficiency.Value = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(4, 4);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 80;
            label3.Text = "Efficiency";
            // 
            // panel1
            // 
            panel1.Controls.Add(complexity);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 33);
            panel1.TabIndex = 84;
            // 
            // complexity
            // 
            complexity.Location = new Point(120, 10);
            complexity.Name = "complexity";
            complexity.Size = new Size(290, 13);
            complexity.TabIndex = 84;
            complexity.Value = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(4, 4);
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
            Size = new Size(455, 230);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private FlowLayoutPanel readabilityContainer;
        private Panel panel4;
        private GeneralComponents.StatsBar readability;
        private Button button2;
        private Label label2;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label label1;
        private GeneralComponents.StatsBar complexity;
        private Panel efficiencyContainer;
        private GeneralComponents.StatsBar efficiency;
        private Label label3;
    }
}
