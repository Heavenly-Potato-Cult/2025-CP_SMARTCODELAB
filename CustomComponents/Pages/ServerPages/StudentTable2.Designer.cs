namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class StudentTable2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTable2));
            panel1 = new Panel();
            label3 = new Label();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            count = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 89);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(110, 29);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 11;
            label3.Text = "Student Table";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.SeaGreen;
            smartButton1.BackgroundColor = Color.SeaGreen;
            smartButton1.BorderRadius = 15;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Image = (Image)resources.GetObject("smartButton1.Image");
            smartButton1.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton1.Location = new Point(245, 118);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Padding = new Padding(9, 0, 0, 0);
            smartButton1.Size = new Size(126, 38);
            smartButton1.TabIndex = 69;
            smartButton1.Text = " Add Students";
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.DodgerBlue;
            smartButton2.BackgroundColor = Color.DodgerBlue;
            smartButton2.BorderRadius = 15;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Image = (Image)resources.GetObject("smartButton2.Image");
            smartButton2.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton2.Location = new Point(110, 118);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(9, 0, 0, 0);
            smartButton2.Size = new Size(126, 38);
            smartButton2.TabIndex = 68;
            smartButton2.Text = " Add Student";
            smartButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton2.UseVisualStyleBackColor = false;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            materialListView1.Depth = 0;
            materialListView1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(110, 178);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(700, 100);
            materialListView1.TabIndex = 70;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student ID";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Student Name";
            columnHeader2.Width = 500;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count.ForeColor = Color.FromArgb(13, 13, 13);
            count.Location = new Point(788, 135);
            count.Name = "count";
            count.Size = new Size(19, 21);
            count.TabIndex = 72;
            count.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 13, 13);
            label4.Location = new Point(653, 135);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 71;
            label4.Text = "Total Students :";
            // 
            // StudentTable2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(count);
            Controls.Add(label4);
            Controls.Add(materialListView1);
            Controls.Add(smartButton1);
            Controls.Add(smartButton2);
            Controls.Add(panel1);
            Name = "StudentTable2";
            Size = new Size(991, 874);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label count;
        private Label label4;
    }
}
