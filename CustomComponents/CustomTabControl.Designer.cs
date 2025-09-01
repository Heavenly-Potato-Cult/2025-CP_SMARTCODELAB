namespace SmartCodeLab.CustomComponents
{
    partial class CustomTabControl
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
            tabControl1 = new TabControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(0, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1097, 808);
            tabControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(0, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1217, 29);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // CustomTabControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Name = "CustomTabControl";
            Size = new Size(1097, 841);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
