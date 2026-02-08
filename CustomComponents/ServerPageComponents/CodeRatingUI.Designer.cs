namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class CodeRatingUI
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
            holder = new FlowLayoutPanel();
            accuracy = new RatingUI();
            efficiency = new RatingUI();
            robustness = new RatingUI();
            maintainability = new RatingUI();
            holder.SuspendLayout();
            SuspendLayout();
            // 
            // holder
            // 
            holder.BackColor = Color.Transparent;
            holder.Controls.Add(accuracy);
            holder.Controls.Add(efficiency);
            holder.Controls.Add(robustness);
            holder.Controls.Add(maintainability);
            holder.Dock = DockStyle.Fill;
            holder.Location = new Point(0, 0);
            holder.Name = "holder";
            holder.Size = new Size(432, 248);
            holder.TabIndex = 0;
            // 
            // accuracy
            // 
            accuracy.BackColor = Color.Transparent;
            accuracy.Location = new Point(3, 3);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(426, 45);
            accuracy.TabIndex = 0;
            // 
            // efficiency
            // 
            efficiency.BackColor = Color.Transparent;
            efficiency.Location = new Point(3, 54);
            efficiency.Name = "efficiency";
            efficiency.Size = new Size(426, 45);
            efficiency.TabIndex = 1;
            // 
            // robustness
            // 
            robustness.BackColor = Color.Transparent;
            robustness.Location = new Point(3, 105);
            robustness.Name = "robustness";
            robustness.Size = new Size(426, 45);
            robustness.TabIndex = 2;
            // 
            // maintainability
            // 
            maintainability.BackColor = Color.Transparent;
            maintainability.Location = new Point(3, 156);
            maintainability.Name = "maintainability";
            maintainability.Size = new Size(426, 45);
            maintainability.TabIndex = 3;
            // 
            // CodeRatingUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(holder);
            Name = "CodeRatingUI";
            Size = new Size(432, 248);
            holder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel holder;
        private RatingUI accuracy;
        private RatingUI efficiency;
        private RatingUI robustness;
        private RatingUI maintainability;
    }
}
