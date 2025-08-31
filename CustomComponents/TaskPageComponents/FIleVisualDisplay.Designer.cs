namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class FIleVisualDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIleVisualDisplay));
            button1 = new Button();
            fileName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(49, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(3);
            button1.Size = new Size(20, 20);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.BackColor = Color.Transparent;
            fileName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileName.Location = new Point(3, 0);
            fileName.Name = "fileName";
            fileName.Size = new Size(43, 17);
            fileName.TabIndex = 2;
            fileName.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(fileName);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(73, 27);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // FIleVisualDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FIleVisualDisplay";
            Size = new Size(73, 27);
            Load += FIleVisualDisplay_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label fileName;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
