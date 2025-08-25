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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            headerPanel = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            sideMenuPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnMenu2 = new Button();
            instructions_Panel = new Panel();
            taskMainPage2 = new SmartCodeLab.CustomComponents.MainPages.TaskMainPage();
            student_Panel = new Panel();
            customCard4 = new SmartCodeLab.CustomComponents.CustomCard();
            label5 = new Label();
            customCard3 = new SmartCodeLab.CustomComponents.CustomCard();
            listView4 = new ListView();
            listView3 = new ListView();
            label4 = new Label();
            label3 = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.CustomCard();
            textBox1 = new TextBox();
            label2 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.CustomCard();
            materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            label1 = new Label();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            instructions_Panel.SuspendLayout();
            student_Panel.SuspendLayout();
            customCard4.SuspendLayout();
            customCard3.SuspendLayout();
            customCard2.SuspendLayout();
            customCard1.SuspendLayout();
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
            btnClose.Click += btnClose_Click;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.FromArgb(60, 63, 65);
            sideMenuPanel.Controls.Add(button2);
            sideMenuPanel.Controls.Add(button1);
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
            button2.Location = new Point(0, 90);
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
            button1.Location = new Point(0, 45);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "Instruction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // instructions_Panel
            // 
            instructions_Panel.Controls.Add(taskMainPage2);
            instructions_Panel.Location = new Point(206, 46);
            instructions_Panel.Name = "instructions_Panel";
            instructions_Panel.Size = new Size(1168, 674);
            instructions_Panel.TabIndex = 10;
            // 
            // taskMainPage2
            // 
            taskMainPage2.Location = new Point(16, 16);
            taskMainPage2.Margin = new Padding(3, 2, 3, 2);
            taskMainPage2.Name = "taskMainPage2";
            taskMainPage2.Size = new Size(1260, 656);
            taskMainPage2.TabIndex = 0;
            // 
            // student_Panel
            // 
            student_Panel.Controls.Add(customCard4);
            student_Panel.Controls.Add(customCard3);
            student_Panel.Controls.Add(customCard2);
            student_Panel.Controls.Add(customCard1);
            student_Panel.Location = new Point(206, 46);
            student_Panel.Name = "student_Panel";
            student_Panel.Size = new Size(1168, 674);
            student_Panel.TabIndex = 2;
            student_Panel.Paint += student_Panel_Paint;
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.White;
            customCard4.BorderColor = Color.Gray;
            customCard4.BorderRadius = 2;
            customCard4.BorderSize = 0;
            customCard4.Controls.Add(label5);
            customCard4.Location = new Point(41, 428);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(1086, 226);
            customCard4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(564, 9);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Analysis";
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.White;
            customCard3.BorderColor = Color.Gray;
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 0;
            customCard3.Controls.Add(listView4);
            customCard3.Controls.Add(listView3);
            customCard3.Controls.Add(label4);
            customCard3.Controls.Add(label3);
            customCard3.Location = new Point(841, 44);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(286, 341);
            customCard3.TabIndex = 6;
            // 
            // listView4
            // 
            listView4.Location = new Point(11, 200);
            listView4.Name = "listView4";
            listView4.Size = new Size(261, 97);
            listView4.TabIndex = 8;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(11, 40);
            listView3.Name = "listView3";
            listView3.Size = new Size(261, 97);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 176);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 6;
            label4.Text = "Copy-Pasted Codes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 16);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Functions";
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 0;
            customCard2.Controls.Add(textBox1);
            customCard2.Controls.Add(label2);
            customCard2.Location = new Point(321, 44);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(476, 341);
            customCard2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(11, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(452, 272);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 16);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 4;
            label2.Text = "Code View From : ";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 0;
            customCard1.Controls.Add(materialListBox2);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(41, 44);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(243, 341);
            customCard1.TabIndex = 4;
            // 
            // materialListBox2
            // 
            materialListBox2.BackColor = Color.Transparent;
            materialListBox2.BorderColor = Color.Transparent;
            materialListBox2.Depth = 0;
            materialListBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "Jimmuel";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Clifford";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Angelo";
            materialListBox2.Items.Add(materialListBoxItem1);
            materialListBox2.Items.Add(materialListBoxItem2);
            materialListBox2.Items.Add(materialListBoxItem3);
            materialListBox2.Location = new Point(11, 52);
            materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox2.Name = "materialListBox2";
            materialListBox2.RightToLeft = RightToLeft.No;
            materialListBox2.SelectedIndex = -1;
            materialListBox2.SelectedItem = null;
            materialListBox2.Size = new Size(215, 128);
            materialListBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 4;
            label1.Text = "Connected PC";
            // 
            // MonitoringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 732);
            Controls.Add(sideMenuPanel);
            Controls.Add(headerPanel);
            Controls.Add(instructions_Panel);
            Controls.Add(student_Panel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonitoringForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonitoringForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            sideMenuPanel.ResumeLayout(false);
            instructions_Panel.ResumeLayout(false);
            student_Panel.ResumeLayout(false);
            customCard4.ResumeLayout(false);
            customCard4.PerformLayout();
            customCard3.ResumeLayout(false);
            customCard3.PerformLayout();
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Panel instructions_Panel;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
        private Panel student_Panel;
        private CustomComponents.MainPages.TaskMainPage taskMainPage2;
        private CustomComponents.CustomCard customCard1;
        private Label label1;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private CustomComponents.CustomCard customCard2;
        private TextBox textBox1;
        private Label label2;
        private CustomComponents.CustomCard customCard3;
        private Label label3;
        private CustomComponents.CustomCard customCard4;
        private Label label5;
        private ListView listView4;
        private ListView listView3;
        private Label label4;
    }
}
