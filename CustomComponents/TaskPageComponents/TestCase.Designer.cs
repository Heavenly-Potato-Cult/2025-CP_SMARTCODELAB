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
            inputs = new TextBox();
            output = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputs
            // 
            inputs.Location = new Point(3, 28);
            inputs.Multiline = true;
            inputs.Name = "inputs";
            inputs.ScrollBars = ScrollBars.Both;
            inputs.Size = new Size(203, 105);
            inputs.TabIndex = 0;
            inputs.WordWrap = false;
            // 
            // output
            // 
            output.Location = new Point(3, 165);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Both;
            output.Size = new Size(203, 72);
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
            label2.Location = new Point(3, 142);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Expected Output";
            // 
            // TestCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(inputs);
            Name = "TestCase";
            Size = new Size(209, 240);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputs;
        private TextBox output;
        private Label label1;
        private Label label2;
    }
}
