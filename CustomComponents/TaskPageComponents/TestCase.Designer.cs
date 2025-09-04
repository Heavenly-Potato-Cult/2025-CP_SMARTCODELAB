namespace SmartCodeLab.CustomComponents.TaskPageComponents
{
    partial class TestCase
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
            output = new TextBox();
            label1 = new Label();
            label2 = new Label();
            inputs = new RichTextBox();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(3, 185);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(314, 82);
            output.TabIndex = 1;
            output.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Inputs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 162);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Expected Output";
            // 
            // inputs
            // 
            inputs.Location = new Point(3, 28);
            inputs.Name = "inputs";
            inputs.Size = new Size(314, 120);
            inputs.TabIndex = 4;
            inputs.Text = "";
            // 
            // TestCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(inputs);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Name = "TestCase";
            Size = new Size(320, 270);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox output;
        private Label label1;
        private Label label2;
        private RichTextBox inputs;
    }
}
