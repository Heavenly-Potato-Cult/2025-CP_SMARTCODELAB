namespace SmartCodeLab.CustomComponents
{
    partial class ExpansionPanel2
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
            ExpansionPanel = new SplitContainer();
            label2 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ExpansionPanel).BeginInit();
            ExpansionPanel.Panel1.SuspendLayout();
            ExpansionPanel.Panel2.SuspendLayout();
            ExpansionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ExpansionPanel
            // 
            ExpansionPanel.BackColor = SystemColors.Desktop;
            ExpansionPanel.Dock = DockStyle.Fill;
            ExpansionPanel.FixedPanel = FixedPanel.Panel1;
            ExpansionPanel.IsSplitterFixed = true;
            ExpansionPanel.Location = new Point(0, 0);
            ExpansionPanel.MaximumSize = new Size(1000, 400);
            ExpansionPanel.MinimumSize = new Size(400, 40);
            ExpansionPanel.Name = "ExpansionPanel";
            ExpansionPanel.Orientation = Orientation.Horizontal;
            // 
            // ExpansionPanel.Panel1
            // 
            ExpansionPanel.Panel1.BackColor = SystemColors.GradientActiveCaption;
            ExpansionPanel.Panel1.Controls.Add(label2);
            ExpansionPanel.Panel1.Controls.Add(button3);
            ExpansionPanel.Panel1MinSize = 40;
            // 
            // ExpansionPanel.Panel2
            // 
            ExpansionPanel.Panel2.BackColor = SystemColors.GrayText;
            ExpansionPanel.Panel2.Controls.Add(textBox1);
            ExpansionPanel.Size = new Size(504, 293);
            ExpansionPanel.SplitterDistance = 40;
            ExpansionPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(426, 9);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "toggle";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // ExpansionPanel2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(ExpansionPanel);
            MinimumSize = new Size(400, 40);
            Name = "ExpansionPanel2";
            Size = new Size(504, 293);
            ExpansionPanel.Panel1.ResumeLayout(false);
            ExpansionPanel.Panel1.PerformLayout();
            ExpansionPanel.Panel2.ResumeLayout(false);
            ExpansionPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpansionPanel).EndInit();
            ExpansionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer ExpansionPanel;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
    }
}
