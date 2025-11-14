namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    partial class CmdPanel
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTextBox1.Size = new Size(602, 200);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // CmdPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CmdPanel";
            Size = new Size(602, 200);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}
