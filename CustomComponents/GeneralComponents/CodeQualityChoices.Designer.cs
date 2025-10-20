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
            accuracyW = new CustomNumericUpDown();
            readabilityW = new CustomNumericUpDown();
            efficiencyW = new CustomNumericUpDown();
            complexityW = new CustomNumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)accuracyW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readabilityW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)efficiencyW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)complexityW).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Accuracy";
            // 
            // accuracy
            // 
            accuracy.AutoSize = true;
            accuracy.Location = new Point(131, 37);
            accuracy.Margin = new Padding(3, 2, 3, 2);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(15, 14);
            accuracy.TabIndex = 1;
            accuracy.UseVisualStyleBackColor = true;
            // 
            // readability
            // 
            readability.AutoSize = true;
            readability.Location = new Point(131, 66);
            readability.Margin = new Padding(3, 2, 3, 2);
            readability.Name = "readability";
            readability.Size = new Size(15, 14);
            readability.TabIndex = 3;
            readability.UseVisualStyleBackColor = true;
            readability.CheckedChanged += readability_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Readability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Efficiency";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 116);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 5;
            label4.Text = "Logical Complexity";
            // 
            // efficiency
            // 
            efficiency.AutoSize = true;
            efficiency.Location = new Point(131, 94);
            efficiency.Margin = new Padding(3, 2, 3, 2);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(15, 14);
            efficiency.TabIndex = 6;
            efficiency.UseVisualStyleBackColor = true;
            efficiency.CheckedChanged += efficiency_CheckedChanged;
            // 
            // complexity
            // 
            complexity.AutoSize = true;
            complexity.Location = new Point(131, 118);
            complexity.Margin = new Padding(3, 2, 3, 2);
            complexity.Name = "complexity";
            complexity.Size = new Size(15, 14);
            complexity.TabIndex = 7;
            complexity.UseVisualStyleBackColor = true;
            complexity.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // accuracyW
            // 
            accuracyW.Location = new Point(152, 29);
            accuracyW.Name = "accuracyW";
            accuracyW.Size = new Size(57, 23);
            accuracyW.TabIndex = 8;
            accuracyW.Value = new decimal(new int[] { 100, 0, 0, 0 });
            accuracyW.recentValue = 100;
            // 
            // readabilityW
            // 
            readabilityW.Enabled = false;
            readabilityW.Location = new Point(152, 58);
            readabilityW.Name = "readabilityW";
            readabilityW.Size = new Size(57, 23);
            readabilityW.TabIndex = 9;
            // 
            // efficiencyW
            // 
            efficiencyW.Enabled = false;
            efficiencyW.Location = new Point(152, 84);
            efficiencyW.Name = "efficiencyW";
            efficiencyW.Size = new Size(57, 23);
            efficiencyW.TabIndex = 10;
            // 
            // complexityW
            // 
            complexityW.Enabled = false;
            complexityW.Location = new Point(152, 108);
            complexityW.Name = "complexityW";
            complexityW.Size = new Size(57, 23);
            complexityW.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(152, 11);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 12;
            label5.Text = "Weight";
            // 
            // CodeQualityChoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(complexityW);
            Controls.Add(efficiencyW);
            Controls.Add(readabilityW);
            Controls.Add(accuracyW);
            Controls.Add(complexity);
            Controls.Add(efficiency);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(readability);
            Controls.Add(label2);
            Controls.Add(accuracy);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CodeQualityChoices";
            Size = new Size(227, 138);
            ((System.ComponentModel.ISupportInitialize)accuracyW).EndInit();
            ((System.ComponentModel.ISupportInitialize)readabilityW).EndInit();
            ((System.ComponentModel.ISupportInitialize)efficiencyW).EndInit();
            ((System.ComponentModel.ISupportInitialize)complexityW).EndInit();
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
        private CustomNumericUpDown accuracyW;
        private CustomNumericUpDown readabilityW;
        private CustomNumericUpDown efficiencyW;
        private CustomNumericUpDown complexityW;
        private Label label5;
    }
}
