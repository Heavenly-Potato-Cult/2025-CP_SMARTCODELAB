namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    partial class StudTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudTable));
            studtab = new FlowLayoutPanel();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClose = new Button();
            label12 = new Label();
            customCard7 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label3 = new Label();
            label14 = new Label();
            label4 = new Label();
            count = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel1.SuspendLayout();
            customCard7.SuspendLayout();
            SuspendLayout();
            // 
            // studtab
            // 
            studtab.AutoScroll = true;
            studtab.BorderStyle = BorderStyle.FixedSingle;
            studtab.FlowDirection = FlowDirection.TopDown;
            studtab.Location = new Point(30, 150);
            studtab.Margin = new Padding(3, 2, 3, 2);
            studtab.Name = "studtab";
            studtab.Size = new Size(551, 274);
            studtab.TabIndex = 0;
            studtab.WrapContents = false;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.DodgerBlue;
            smartButton2.BackgroundColor = Color.DodgerBlue;
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Image = (Image)resources.GetObject("smartButton2.Image");
            smartButton2.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton2.Location = new Point(30, 62);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(9, 0, 0, 0);
            smartButton2.Size = new Size(126, 38);
            smartButton2.TabIndex = 4;
            smartButton2.Text = " Add Student";
            smartButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 2);
            panel2.TabIndex = 63;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 44);
            panel1.TabIndex = 62;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(566, 17);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(14, 12);
            btnClose.TabIndex = 25;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(30, 7);
            label12.Name = "label12";
            label12.Size = new Size(155, 30);
            label12.TabIndex = 24;
            label12.Text = "Student Table";
            // 
            // customCard7
            // 
            customCard7.BackColor = Color.Gainsboro;
            customCard7.BorderColor = Color.Black;
            customCard7.BorderRadius = 2;
            customCard7.BorderSize = 1;
            customCard7.Controls.Add(label3);
            customCard7.Controls.Add(label14);
            customCard7.Location = new Point(30, 125);
            customCard7.Margin = new Padding(3, 2, 3, 2);
            customCard7.Name = "customCard7";
            customCard7.Size = new Size(550, 26);
            customCard7.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(314, 4);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 19;
            label3.Text = "STUDENT NAME";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(14, 4);
            label14.Name = "label14";
            label14.Size = new Size(92, 20);
            label14.TabIndex = 18;
            label14.Text = "STUDENT ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 13, 13);
            label4.Location = new Point(30, 440);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 65;
            label4.Text = "Total Students :";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count.ForeColor = Color.FromArgb(13, 13, 13);
            count.Location = new Point(165, 440);
            count.Name = "count";
            count.Size = new Size(19, 21);
            count.TabIndex = 66;
            count.Text = "0";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.SeaGreen;
            smartButton1.BackgroundColor = Color.SeaGreen;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Image = (Image)resources.GetObject("smartButton1.Image");
            smartButton1.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton1.Location = new Point(165, 62);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Padding = new Padding(9, 0, 0, 0);
            smartButton1.Size = new Size(126, 38);
            smartButton1.TabIndex = 67;
            smartButton1.Text = " Add Students";
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // StudTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 481);
            Controls.Add(smartButton1);
            Controls.Add(count);
            Controls.Add(label4);
            Controls.Add(customCard7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(smartButton2);
            Controls.Add(studtab);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudTable";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customCard7.ResumeLayout(false);
            customCard7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel studtab;
        private GeneralComponents.SmartButton smartButton2;
        private Panel panel2;
        private Panel panel1;
        private Button btnClose;
        private Label label12;
        private GeneralComponents.CustomCard customCard7;
        private Label label3;
        private Label label14;
        private Label label4;
        private Label count;
        private GeneralComponents.SmartButton smartButton1;
    }
}