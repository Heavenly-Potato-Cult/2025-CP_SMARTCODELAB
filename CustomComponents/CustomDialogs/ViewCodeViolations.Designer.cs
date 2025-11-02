namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ViewCodeViolations
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
            readability = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            label1 = new Label();
            label2 = new Label();
            maintainability = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            label3 = new Label();
            robustness = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            SuspendLayout();
            // 
            // readability
            // 
            readability.BackColor = Color.FromArgb(255, 255, 255);
            readability.BorderStyle = BorderStyle.None;
            readability.Depth = 0;
            readability.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            readability.ForeColor = Color.FromArgb(222, 0, 0, 0);
            readability.Location = new Point(12, 29);
            readability.MouseState = MaterialSkin.MouseState.HOVER;
            readability.Name = "readability";
            readability.Size = new Size(360, 130);
            readability.TabIndex = 0;
            readability.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 1;
            label1.Text = "Readability Violations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 200);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 3;
            label2.Text = "Maintainability Violations";
            // 
            // maintainability
            // 
            maintainability.BackColor = Color.FromArgb(255, 255, 255);
            maintainability.BorderStyle = BorderStyle.None;
            maintainability.Depth = 0;
            maintainability.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            maintainability.ForeColor = Color.FromArgb(222, 0, 0, 0);
            maintainability.Location = new Point(15, 220);
            maintainability.MouseState = MaterialSkin.MouseState.HOVER;
            maintainability.Name = "maintainability";
            maintainability.Size = new Size(360, 130);
            maintainability.TabIndex = 2;
            maintainability.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 384);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Robustness Violations";
            // 
            // robustness
            // 
            robustness.BackColor = Color.FromArgb(255, 255, 255);
            robustness.BorderStyle = BorderStyle.None;
            robustness.Depth = 0;
            robustness.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            robustness.ForeColor = Color.FromArgb(222, 0, 0, 0);
            robustness.Location = new Point(15, 404);
            robustness.MouseState = MaterialSkin.MouseState.HOVER;
            robustness.Name = "robustness";
            robustness.Size = new Size(360, 130);
            robustness.TabIndex = 4;
            robustness.Text = "";
            // 
            // ViewCodeViolations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 550);
            Controls.Add(label3);
            Controls.Add(robustness);
            Controls.Add(label2);
            Controls.Add(maintainability);
            Controls.Add(label1);
            Controls.Add(readability);
            Name = "ViewCodeViolations";
            Text = "ViewCodeViolations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox readability;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox maintainability;
        private Label label3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox robustness;
    }
}