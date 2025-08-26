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
        private System.Windows.Forms.Button btnSideMenu_Student;

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
            button3 = new Button();
            btnSideMenu_Settings = new Button();
            btnSideMenu_Instruction = new Button();
            btnSideMenu_Student = new Button();
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
            settings_Panel = new Panel();
            customCard8 = new SmartCodeLab.CustomComponents.CustomCard();
            label10 = new Label();
            label6 = new Label();
            customToggleButton1 = new SmartCodeLab.CustomComponents.CustomToggleButton();
            customCard5 = new SmartCodeLab.CustomComponents.CustomCard();
            customToggleButton2 = new SmartCodeLab.CustomComponents.CustomToggleButton();
            label7 = new Label();
            label8 = new Label();
            customToggleButton3 = new SmartCodeLab.CustomComponents.CustomToggleButton();
            label9 = new Label();
            headerPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            instructions_Panel.SuspendLayout();
            student_Panel.SuspendLayout();
            customCard4.SuspendLayout();
            customCard3.SuspendLayout();
            customCard2.SuspendLayout();
            customCard1.SuspendLayout();
            settings_Panel.SuspendLayout();
            customCard8.SuspendLayout();
            customCard5.SuspendLayout();
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
            sideMenuPanel.Controls.Add(button3);
            sideMenuPanel.Controls.Add(btnSideMenu_Settings);
            sideMenuPanel.Controls.Add(btnSideMenu_Instruction);
            sideMenuPanel.Controls.Add(btnSideMenu_Student);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 40);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(200, 692);
            sideMenuPanel.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(70, 70, 73);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 135);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSideMenu_Settings
            // 
            btnSideMenu_Settings.BackColor = Color.FromArgb(70, 70, 73);
            btnSideMenu_Settings.FlatAppearance.BorderSize = 0;
            btnSideMenu_Settings.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Settings.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Settings.ForeColor = Color.White;
            btnSideMenu_Settings.Location = new Point(0, 90);
            btnSideMenu_Settings.Name = "btnSideMenu_Settings";
            btnSideMenu_Settings.Size = new Size(200, 45);
            btnSideMenu_Settings.TabIndex = 3;
            btnSideMenu_Settings.Text = "Settings";
            btnSideMenu_Settings.UseVisualStyleBackColor = false;
            btnSideMenu_Settings.Click += button2_Click;
            // 
            // btnSideMenu_Instruction
            // 
            btnSideMenu_Instruction.BackColor = Color.FromArgb(70, 70, 73);
            btnSideMenu_Instruction.FlatAppearance.BorderSize = 0;
            btnSideMenu_Instruction.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Instruction.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Instruction.ForeColor = Color.White;
            btnSideMenu_Instruction.Location = new Point(0, 45);
            btnSideMenu_Instruction.Name = "btnSideMenu_Instruction";
            btnSideMenu_Instruction.Size = new Size(200, 45);
            btnSideMenu_Instruction.TabIndex = 2;
            btnSideMenu_Instruction.Text = "Instruction";
            btnSideMenu_Instruction.UseVisualStyleBackColor = false;
            btnSideMenu_Instruction.Click += button1_Click;
            // 
            // btnSideMenu_Student
            // 
            btnSideMenu_Student.BackColor = Color.FromArgb(70, 70, 73);
            btnSideMenu_Student.FlatAppearance.BorderSize = 0;
            btnSideMenu_Student.FlatStyle = FlatStyle.Flat;
            btnSideMenu_Student.Font = new Font("Segoe UI", 10F);
            btnSideMenu_Student.ForeColor = Color.White;
            btnSideMenu_Student.Location = new Point(0, 0);
            btnSideMenu_Student.Name = "btnSideMenu_Student";
            btnSideMenu_Student.Size = new Size(200, 45);
            btnSideMenu_Student.TabIndex = 1;
            btnSideMenu_Student.Text = "Student";
            btnSideMenu_Student.UseVisualStyleBackColor = false;
            btnSideMenu_Student.Click += btnMenu2_Click;
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
            student_Panel.Controls.Add(settings_Panel);
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
            // settings_Panel
            // 
            settings_Panel.Controls.Add(customCard5);
            settings_Panel.Controls.Add(customCard8);
            settings_Panel.Location = new Point(0, 0);
            settings_Panel.Name = "settings_Panel";
            settings_Panel.Size = new Size(1168, 674);
            settings_Panel.TabIndex = 7;
            // 
            // customCard8
            // 
            customCard8.BackColor = Color.White;
            customCard8.BorderColor = Color.Gray;
            customCard8.BorderRadius = 2;
            customCard8.BorderSize = 0;
            customCard8.Controls.Add(customToggleButton1);
            customCard8.Controls.Add(label6);
            customCard8.Controls.Add(label10);
            customCard8.Location = new Point(41, 44);
            customCard8.Name = "customCard8";
            customCard8.Size = new Size(243, 98);
            customCard8.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 16);
            label10.Name = "label10";
            label10.Size = new Size(101, 21);
            label10.TabIndex = 4;
            label10.Text = "Connections";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 51);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Start Session";
            // 
            // customToggleButton1
            // 
            customToggleButton1.AutoSize = true;
            customToggleButton1.Location = new Point(181, 51);
            customToggleButton1.MinimumSize = new Size(45, 22);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColor = Color.Gray;
            customToggleButton1.OffToggleColor = Color.Gainsboro;
            customToggleButton1.OnBackColor = Color.MediumSlateBlue;
            customToggleButton1.OnToggleColor = Color.WhiteSmoke;
            customToggleButton1.Size = new Size(45, 22);
            customToggleButton1.TabIndex = 6;
            customToggleButton1.UseVisualStyleBackColor = true;
            // 
            // customCard5
            // 
            customCard5.BackColor = Color.White;
            customCard5.BorderColor = Color.Gray;
            customCard5.BorderRadius = 2;
            customCard5.BorderSize = 0;
            customCard5.Controls.Add(customToggleButton3);
            customCard5.Controls.Add(label9);
            customCard5.Controls.Add(customToggleButton2);
            customCard5.Controls.Add(label7);
            customCard5.Controls.Add(label8);
            customCard5.Location = new Point(372, 44);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(322, 162);
            customCard5.TabIndex = 7;
            // 
            // customToggleButton2
            // 
            customToggleButton2.AutoSize = true;
            customToggleButton2.Location = new Point(181, 51);
            customToggleButton2.MinimumSize = new Size(45, 22);
            customToggleButton2.Name = "customToggleButton2";
            customToggleButton2.OffBackColor = Color.Gray;
            customToggleButton2.OffToggleColor = Color.Gainsboro;
            customToggleButton2.OnBackColor = Color.MediumSlateBlue;
            customToggleButton2.OnToggleColor = Color.WhiteSmoke;
            customToggleButton2.Size = new Size(45, 22);
            customToggleButton2.TabIndex = 6;
            customToggleButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 51);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 5;
            label7.Text = "Allow Hint ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 16);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 4;
            label8.Text = "Student IDE Features";
            // 
            // customToggleButton3
            // 
            customToggleButton3.AutoSize = true;
            customToggleButton3.Location = new Point(181, 78);
            customToggleButton3.MinimumSize = new Size(45, 22);
            customToggleButton3.Name = "customToggleButton3";
            customToggleButton3.OffBackColor = Color.Gray;
            customToggleButton3.OffToggleColor = Color.Gainsboro;
            customToggleButton3.OnBackColor = Color.MediumSlateBlue;
            customToggleButton3.OnToggleColor = Color.WhiteSmoke;
            customToggleButton3.Size = new Size(45, 22);
            customToggleButton3.TabIndex = 8;
            customToggleButton3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 78);
            label9.Name = "label9";
            label9.Size = new Size(164, 20);
            label9.TabIndex = 7;
            label9.Text = "Allow Suggestion Panel";
            // 
            // MonitoringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 732);
            Controls.Add(sideMenuPanel);
            Controls.Add(headerPanel);
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
            settings_Panel.ResumeLayout(false);
            customCard8.ResumeLayout(false);
            customCard8.PerformLayout();
            customCard5.ResumeLayout(false);
            customCard5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSideMenu_Settings;
        private Button btnSideMenu_Instruction;
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
        private Button button3;
        private Panel settings_Panel;
        private CustomComponents.CustomCard customCard5;
        private CustomComponents.CustomToggleButton customToggleButton3;
        private Label label9;
        private CustomComponents.CustomToggleButton customToggleButton2;
        private Label label7;
        private Label label8;
        private CustomComponents.CustomCard customCard8;
        private CustomComponents.CustomToggleButton customToggleButton1;
        private Label label6;
        private Label label10;
    }
}
