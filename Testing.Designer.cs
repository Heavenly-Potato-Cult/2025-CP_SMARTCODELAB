namespace SmartCodeLab
{
    partial class Testing
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
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ExpansionPanel = new SplitContainer();
            button3 = new Button();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpansionPanel).BeginInit();
            ExpansionPanel.Panel1.SuspendLayout();
            ExpansionPanel.Panel2.SuspendLayout();
            ExpansionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1101, 617);
            splitContainer1.SplitterDistance = 366;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new Point(73, 344);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Size = new Size(308, 167);
            splitContainer3.SplitterDistance = 25;
            splitContainer3.TabIndex = 5;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = SystemColors.Info;
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Panel2.Controls.Add(panel3);
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Size = new Size(731, 617);
            splitContainer2.SplitterDistance = 241;
            splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ExpansionPanel);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(217, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 335);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // ExpansionPanel
            // 
            ExpansionPanel.BackColor = SystemColors.Desktop;
            ExpansionPanel.Dock = DockStyle.Top;
            ExpansionPanel.FixedPanel = FixedPanel.Panel1;
            ExpansionPanel.IsSplitterFixed = true;
            ExpansionPanel.Location = new Point(3, 3);
            ExpansionPanel.MaximumSize = new Size(400, 300);
            ExpansionPanel.MinimumSize = new Size(400, 40);
            ExpansionPanel.Name = "ExpansionPanel";
            ExpansionPanel.Orientation = Orientation.Horizontal;
            // 
            // ExpansionPanel.Panel1
            // 
            ExpansionPanel.Panel1.BackColor = SystemColors.GradientActiveCaption;
            ExpansionPanel.Panel1.Controls.Add(button3);
            ExpansionPanel.Panel1MinSize = 40;
            // 
            // ExpansionPanel.Panel2
            // 
            ExpansionPanel.Panel2.BackColor = SystemColors.GrayText;
            ExpansionPanel.Panel2.Controls.Add(textBox1);
            ExpansionPanel.Size = new Size(400, 219);
            ExpansionPanel.SplitterDistance = 40;
            ExpansionPanel.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(311, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "toggle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Location = new Point(3, 228);
            panel4.Name = "panel4";
            panel4.Size = new Size(397, 42);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 29);
            panel5.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Location = new Point(28, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 10);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(361, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 0;
            button1.Text = "open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(28, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 40);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(28, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 60);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // Testing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 617);
            Controls.Add(splitContainer1);
            Name = "Testing";
            Text = "Testing";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ExpansionPanel.Panel1.ResumeLayout(false);
            ExpansionPanel.Panel2.ResumeLayout(false);
            ExpansionPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpansionPanel).EndInit();
            ExpansionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private SplitContainer ExpansionPanel;
        private TextBox textBox1;
        private SplitContainer splitContainer3;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
    }
}