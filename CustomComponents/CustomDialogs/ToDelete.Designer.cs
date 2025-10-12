namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ToDelete
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
            submittedContainer = new FlowLayoutPanel();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label1 = new Label();
            label6 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            customCard7.SuspendLayout();
            SuspendLayout();
            // 
            // submittedContainer
            // 
            submittedContainer.AutoScroll = true;
            submittedContainer.FlowDirection = FlowDirection.TopDown;
            submittedContainer.Location = new Point(34, 97);
            submittedContainer.Name = "submittedContainer";
            submittedContainer.Size = new Size(532, 560);
            submittedContainer.TabIndex = 70;
            submittedContainer.WrapContents = false;
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.Gainsboro;
            customCard7.BorderColor = Color.Silver;
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 0;
            customCard7.Controls.Add(label1);
            customCard7.Controls.Add(label6);
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(34, 64);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(532, 34);
            customCard7.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 21;
            label1.Text = "No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(423, 5);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 20;
            label6.Text = "Rating";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(92, 5);
            label14.Name = "label14";
            label14.Size = new Size(125, 25);
            label14.TabIndex = 18;
            label14.Text = "Student Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 71;
            // 
            // button1
            // 
            button1.Location = new Point(218, 18);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 72;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 682);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(submittedContainer);
            Controls.Add(customCard7);
            Name = "ToDelete";
            Text = "ToDelete";
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel submittedContainer;
        private GeneralComponents.CustomCard customCard7;
        private Label label1;
        private Label label6;
        private Label label14;
        private TextBox textBox1;
        private Button button1;
    }
}