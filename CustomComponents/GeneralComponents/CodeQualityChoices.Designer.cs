namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    partial class CodeQualityChoices
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
            label1 = new Label();
            accuracy = new CheckBox();
            readability = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            efficiency = new CheckBox();
            complexity = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Accuracy";
            // 
            // accuracy
            // 
            accuracy.AutoSize = true;
            accuracy.Location = new Point(150, 15);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(18, 17);
            accuracy.TabIndex = 1;
            accuracy.UseVisualStyleBackColor = true;
            // 
            // readability
            // 
            readability.AutoSize = true;
            readability.Location = new Point(150, 35);
            readability.Name = "readability";
            readability.Size = new Size(18, 17);
            readability.TabIndex = 3;
            readability.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Readability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 52);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Efficiency";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 72);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 5;
            label4.Text = "Logical Complexity";
            // 
            // efficiency
            // 
            efficiency.AutoSize = true;
            efficiency.Location = new Point(150, 55);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(18, 17);
            efficiency.TabIndex = 6;
            efficiency.UseVisualStyleBackColor = true;
            // 
            // complexity
            // 
            complexity.AutoSize = true;
            complexity.Location = new Point(150, 75);
            complexity.Name = "complexity";
            complexity.Size = new Size(18, 17);
            complexity.TabIndex = 7;
            complexity.UseVisualStyleBackColor = true;
            complexity.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // CodeQualityChoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(complexity);
            Controls.Add(efficiency);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(readability);
            Controls.Add(label2);
            Controls.Add(accuracy);
            Controls.Add(label1);
            Name = "CodeQualityChoices";
            Size = new Size(184, 105);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox accuracy;
        private CheckBox readability;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox efficiency;
        private CheckBox complexity;
    }
}
