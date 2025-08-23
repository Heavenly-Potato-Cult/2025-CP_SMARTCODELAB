namespace SmartCodeLab
{
    partial class MonitoringForm
    {
        private System.ComponentModel.IContainer components = null;

        // === Declare controls here (fields) ===
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Button btnMenu2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            MaterialSkin.MaterialListBoxItem materialListBoxItem7 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem8 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem9 = new MaterialSkin.MaterialListBoxItem();
            headerPanel = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            sideMenuPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnMenu1 = new Button();
            btnMenu2 = new Button();
            student_Panel = new Panel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            listView2 = new ListView();
            listView1 = new ListView();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            textBox1 = new TextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            files_Panel = new Panel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            textBox2 = new TextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            instructions_Panel = new Panel();
            taskMainPage1 = new CustomComponents.MainPages.TaskMainPage();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            student_Panel.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            files_Panel.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard6.SuspendLayout();
            instructions_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(45, 45, 48);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1386, 40);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart Code Lab";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 50, 50);
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1346, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(60, 63, 65);
            sideMenuPanel.Controls.Add(button2);
            sideMenuPanel.Controls.Add(button1);
            sideMenuPanel.Controls.Add(btnMenu1);
            sideMenuPanel.Controls.Add(btnMenu2);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 40);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(200, 692);
            sideMenuPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(70, 70, 73);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 135);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(70, 70, 73);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 90);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "Instruction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMenu1
            // 
            btnMenu1.BackColor = Color.FromArgb(70, 70, 73);
            btnMenu1.Dock = DockStyle.Top;
            btnMenu1.FlatAppearance.BorderSize = 0;
            btnMenu1.FlatStyle = FlatStyle.Flat;
            btnMenu1.Font = new Font("Segoe UI", 10F);
            btnMenu1.ForeColor = Color.White;
            btnMenu1.Location = new Point(0, 45);
            btnMenu1.Name = "btnMenu1";
            btnMenu1.Size = new Size(200, 45);
            btnMenu1.TabIndex = 0;
            btnMenu1.Text = "Files";
            btnMenu1.UseVisualStyleBackColor = false;
            btnMenu1.Click += btnMenu1_Click;
            // 
            // btnMenu2
            // 
            btnMenu2.BackColor = Color.FromArgb(70, 70, 73);
            btnMenu2.Dock = DockStyle.Top;
            btnMenu2.FlatAppearance.BorderSize = 0;
            btnMenu2.FlatStyle = FlatStyle.Flat;
            btnMenu2.Font = new Font("Segoe UI", 10F);
            btnMenu2.ForeColor = Color.White;
            btnMenu2.Location = new Point(0, 0);
            btnMenu2.Name = "btnMenu2";
            btnMenu2.Size = new Size(200, 45);
            btnMenu2.TabIndex = 1;
            btnMenu2.Text = "Student";
            btnMenu2.UseVisualStyleBackColor = false;
            btnMenu2.Click += btnMenu2_Click;
            // 
            // student_Panel
            // 
            student_Panel.Controls.Add(materialCard4);
            student_Panel.Controls.Add(materialCard3);
            student_Panel.Controls.Add(materialCard2);
            student_Panel.Controls.Add(materialCard1);
            student_Panel.Location = new Point(206, 46);
            student_Panel.Name = "student_Panel";
            student_Panel.Size = new Size(1168, 674);
            student_Panel.TabIndex = 2;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(materialLabel5);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(41, 426);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(1086, 204);
            materialCard4.TabIndex = 6;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(492, 14);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(61, 19);
            materialLabel5.TabIndex = 1;
            materialLabel5.Text = "Analysis";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(listView2);
            materialCard3.Controls.Add(listView1);
            materialCard3.Controls.Add(materialLabel4);
            materialCard3.Controls.Add(materialLabel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(859, 44);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(268, 341);
            materialCard3.TabIndex = 8;
            // 
            // listView2
            // 
            listView2.Location = new Point(17, 227);
            listView2.Name = "listView2";
            listView2.Size = new Size(234, 97);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(17, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(234, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(17, 201);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(138, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Copy-Pasted Codes";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(71, 19);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "Functions";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(textBox1);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(352, 44);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(460, 341);
            materialCard2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(426, 288);
            textBox1.TabIndex = 3;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(144, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Code Review From : ";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialListBox1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(41, 44);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.RightToLeft = RightToLeft.No;
            materialCard1.Size = new Size(283, 341);
            materialCard1.TabIndex = 5;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem7.SecondaryText = "";
            materialListBoxItem7.Tag = null;
            materialListBoxItem7.Text = "Jimmuel";
            materialListBoxItem8.SecondaryText = "";
            materialListBoxItem8.Tag = null;
            materialListBoxItem8.Text = "Clifford";
            materialListBoxItem9.SecondaryText = "";
            materialListBoxItem9.Tag = null;
            materialListBoxItem9.Text = "Angelo";
            materialListBox1.Items.Add(materialListBoxItem7);
            materialListBox1.Items.Add(materialListBoxItem8);
            materialListBox1.Items.Add(materialListBoxItem9);
            materialListBox1.Location = new Point(17, 36);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.RightToLeft = RightToLeft.No;
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(249, 128);
            materialListBox1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(100, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Connected PC";
            // 
            // files_Panel
            // 
            files_Panel.Controls.Add(materialCard5);
            files_Panel.Controls.Add(materialCard6);
            files_Panel.Location = new Point(206, 46);
            files_Panel.Name = "files_Panel";
            files_Panel.Size = new Size(1168, 674);
            files_Panel.TabIndex = 9;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(materialButton3);
            materialCard5.Controls.Add(materialListBox2);
            materialCard5.Controls.Add(materialButton2);
            materialCard5.Controls.Add(materialLabel6);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(41, 44);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(351, 341);
            materialCard5.TabIndex = 5;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(18, 237);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(147, 36);
            materialButton3.TabIndex = 3;
            materialButton3.Text = "Delete File";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialListBox2
            // 
            materialListBox2.BackColor = Color.White;
            materialListBox2.BorderColor = Color.LightGray;
            materialListBox2.Depth = 0;
            materialListBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox2.Location = new Point(17, 36);
            materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox2.Name = "materialListBox2";
            materialListBox2.SelectedIndex = -1;
            materialListBox2.SelectedItem = null;
            materialListBox2.Size = new Size(317, 128);
            materialListBox2.TabIndex = 2;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(18, 189);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(147, 36);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "Add Files";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 14);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(108, 19);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "Reference Files";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(textBox2);
            materialCard6.Controls.Add(materialLabel7);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(483, 44);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(503, 341);
            materialCard6.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 39);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(469, 272);
            textBox2.TabIndex = 4;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(17, 14);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(56, 19);
            materialLabel7.TabIndex = 1;
            materialLabel7.Text = "Preview";
            // 
            // instructions_Panel
            // 
            instructions_Panel.Controls.Add(taskMainPage1);
            instructions_Panel.Location = new Point(206, 46);
            instructions_Panel.Name = "instructions_Panel";
            instructions_Panel.Size = new Size(1168, 674);
            instructions_Panel.TabIndex = 10;
            // 
            // taskMainPage1
            // 
            taskMainPage1.Location = new Point(0, 0);
            taskMainPage1.Margin = new Padding(3, 2, 3, 2);
            taskMainPage1.Name = "taskMainPage1";
            taskMainPage1.Size = new Size(1260, 656);
            taskMainPage1.TabIndex = 0;
            // 
            // MonitoringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 732);
            Controls.Add(sideMenuPanel);
            Controls.Add(headerPanel);
            Controls.Add(files_Panel);
            Controls.Add(student_Panel);
            Controls.Add(instructions_Panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitoringForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonitoringForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            sideMenuPanel.ResumeLayout(false);
            student_Panel.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            files_Panel.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            instructions_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Panel student_Panel;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private ListView listView2;
        private ListView listView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel files_Panel;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private TextBox textBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Panel instructions_Panel;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
    }
}
