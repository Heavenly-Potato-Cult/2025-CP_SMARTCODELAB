namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class ServerMemberContainer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            customTextBox1 = new CustomTextBox();
            label4 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 90);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(284, 572);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.TabStop = true;
            flowLayoutPanel1.WrapContents = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.WhiteSmoke;
            customTextBox1.BorderColor = Color.White;
            customTextBox1.BorderFocusColor = Color.Transparent;
            customTextBox1.BorderRadius = 10;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(11, 43);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(228, 41);
            customTextBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 13, 13);
            label4.Location = new Point(28, 12);
            label4.Name = "label4";
            label4.Size = new Size(201, 28);
            label4.TabIndex = 8;
            label4.Text = "Connected Students";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 20;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(label4);
            customCard1.Controls.Add(flowLayoutPanel1);
            customCard1.Controls.Add(customTextBox1);
            customCard1.Location = new Point(3, 3);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(290, 681);
            customCard1.TabIndex = 10;
            // 
            // ServerMemberContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customCard1);
            Name = "ServerMemberContainer";
            Size = new Size(300, 687);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CustomTextBox customTextBox1;
        private Label label4;
        private GeneralComponents.CustomCard customCard1;
    }
}
