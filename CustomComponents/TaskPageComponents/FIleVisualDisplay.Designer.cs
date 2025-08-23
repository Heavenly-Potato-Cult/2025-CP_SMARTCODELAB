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
            button1 = new Button();
            fileName = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(192, -2);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.BackColor = SystemColors.ActiveCaption;
            fileName.Location = new Point(3, 7);
            fileName.Name = "fileName";
            fileName.Size = new Size(50, 20);
            fileName.TabIndex = 2;
            fileName.Text = "label1";
            // 
            // FIleVisualDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fileName);
            Controls.Add(button1);
            Name = "FIleVisualDisplay";
            Size = new Size(220, 34);
            Load += FIleVisualDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label fileName;
    }
}
