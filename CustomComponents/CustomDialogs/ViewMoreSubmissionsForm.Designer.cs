namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ViewMoreSubmissionsForm
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
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialExpansionPanel4 = new MaterialSkin.Controls.MaterialExpansionPanel();
            expandPanel_Accuracy = new MaterialSkin.Controls.MaterialExpansionPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            expandPanel_Accuracy.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "";
            materialExpansionPanel1.Collapse = true;
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "";
            materialExpansionPanel1.ExpandHeight = 294;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(16, 226);
            materialExpansionPanel1.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(0, 64, 0, 0);
            materialExpansionPanel1.Size = new Size(563, 48);
            materialExpansionPanel1.TabIndex = 97;
            materialExpansionPanel1.Title = "Readability";
            materialExpansionPanel1.ValidationButtonText = "";
            // 
            // materialExpansionPanel2
            // 
            materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel2.CancelButtonText = "";
            materialExpansionPanel2.Collapse = true;
            materialExpansionPanel2.Depth = 0;
            materialExpansionPanel2.Description = "";
            materialExpansionPanel2.ExpandHeight = 294;
            materialExpansionPanel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel2.Location = new Point(16, 275);
            materialExpansionPanel2.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel2.Name = "materialExpansionPanel2";
            materialExpansionPanel2.Padding = new Padding(0, 64, 0, 0);
            materialExpansionPanel2.Size = new Size(563, 48);
            materialExpansionPanel2.TabIndex = 97;
            materialExpansionPanel2.Title = "Efficiency";
            materialExpansionPanel2.ValidationButtonText = "";
            // 
            // materialExpansionPanel4
            // 
            materialExpansionPanel4.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel4.CancelButtonText = "";
            materialExpansionPanel4.Collapse = true;
            materialExpansionPanel4.Depth = 0;
            materialExpansionPanel4.Description = "";
            materialExpansionPanel4.ExpandHeight = 294;
            materialExpansionPanel4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel4.Location = new Point(16, 324);
            materialExpansionPanel4.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel4.Name = "materialExpansionPanel4";
            materialExpansionPanel4.Padding = new Padding(0, 64, 0, 0);
            materialExpansionPanel4.Size = new Size(563, 48);
            materialExpansionPanel4.TabIndex = 98;
            materialExpansionPanel4.Title = "Complexity";
            materialExpansionPanel4.ValidationButtonText = "";
            // 
            // expandPanel_Accuracy
            // 
            expandPanel_Accuracy.AutoSize = true;
            expandPanel_Accuracy.BackColor = Color.FromArgb(255, 255, 255);
            expandPanel_Accuracy.CancelButtonText = "";
            expandPanel_Accuracy.Controls.Add(flowLayoutPanel2);
            expandPanel_Accuracy.Depth = 0;
            expandPanel_Accuracy.Description = "";
            expandPanel_Accuracy.ExpandHeight = 200;
            expandPanel_Accuracy.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            expandPanel_Accuracy.ForeColor = Color.FromArgb(222, 0, 0, 0);
            expandPanel_Accuracy.Location = new Point(16, 16);
            expandPanel_Accuracy.Margin = new Padding(16);
            expandPanel_Accuracy.MouseState = MaterialSkin.MouseState.HOVER;
            expandPanel_Accuracy.Name = "expandPanel_Accuracy";
            expandPanel_Accuracy.Padding = new Padding(0, 64, 0, 0);
            expandPanel_Accuracy.Size = new Size(638, 200);
            expandPanel_Accuracy.TabIndex = 99;
            expandPanel_Accuracy.Title = "Accuracy";
            expandPanel_Accuracy.ValidationButtonText = "";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Red;
            flowLayoutPanel2.Location = new Point(3, 51);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(560, 139);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(expandPanel_Accuracy);
            flowLayoutPanel1.Controls.Add(materialExpansionPanel1);
            flowLayoutPanel1.Controls.Add(materialExpansionPanel2);
            flowLayoutPanel1.Controls.Add(materialExpansionPanel4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(25, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(595, 551);
            flowLayoutPanel1.TabIndex = 100;
            flowLayoutPanel1.WrapContents = false;
            // 
            // ViewMoreSubmissionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 638);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewMoreSubmissionsForm";
            Text = "ViewMore";
            expandPanel_Accuracy.ResumeLayout(false);
            expandPanel_Accuracy.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel4;
        private MaterialSkin.Controls.MaterialExpansionPanel expandPanel_Accuracy;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}