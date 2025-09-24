namespace SmartCodeLab.CustomComponents.Pages
{
    partial class ServerSetUp
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
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton4 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            exerciseContainer = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            taskContainer = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label15 = new Label();
            language = new SmartCodeLab.CustomComponents.GeneralComponents.CustomComboBox();
            label7 = new Label();
            serverName = new CustomTextBox();
            label4 = new Label();
            label12 = new Label();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            customCard2.SuspendLayout();
            exerciseContainer.SuspendLayout();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.White;
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 10;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(smartButton4);
            customCard2.Controls.Add(exerciseContainer);
            customCard2.Controls.Add(label15);
            customCard2.Controls.Add(language);
            customCard2.Controls.Add(label7);
            customCard2.Controls.Add(serverName);
            customCard2.Controls.Add(label4);
            customCard2.Controls.Add(label12);
            customCard2.Location = new Point(106, 165);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(1110, 679);
            customCard2.TabIndex = 20;
            // 
            // smartButton4
            // 
            smartButton4.BackColor = Color.SeaGreen;
            smartButton4.BackgroundColor = Color.SeaGreen;
            smartButton4.BorderRadius = 5;
            smartButton4.FlatAppearance.BorderSize = 0;
            smartButton4.FlatStyle = FlatStyle.Flat;
            smartButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton4.ForeColor = Color.White;
            smartButton4.Location = new Point(400, 385);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(301, 50);
            smartButton4.TabIndex = 28;
            smartButton4.Text = "Start Session";
            smartButton4.UseVisualStyleBackColor = false;
            smartButton4.Click += smartButton4_Click;
            // 
            // exerciseContainer
            // 
            exerciseContainer.BackColor = Color.White;
            exerciseContainer.BorderColor = Color.Gray;
            exerciseContainer.BorderRadius = 20;
            exerciseContainer.BorderSize = 1;
            exerciseContainer.Controls.Add(taskContainer);
            exerciseContainer.Controls.Add(smartButton3);
            exerciseContainer.Location = new Point(655, 111);
            exerciseContainer.Name = "exerciseContainer";
            exerciseContainer.Size = new Size(368, 45);
            exerciseContainer.TabIndex = 27;
            // 
            // taskContainer
            // 
            taskContainer.BackColor = Color.White;
            taskContainer.BorderColor = Color.White;
            taskContainer.BorderRadius = 20;
            taskContainer.BorderSize = 0;
            taskContainer.Location = new Point(3, 4);
            taskContainer.Name = "taskContainer";
            taskContainer.Size = new Size(283, 38);
            taskContainer.TabIndex = 29;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.MediumSlateBlue;
            smartButton3.BorderRadius = 20;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.ForeColor = Color.White;
            smartButton3.Location = new Point(292, 4);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(73, 38);
            smartButton3.TabIndex = 28;
            smartButton3.Text = "Select";
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(655, 83);
            label15.Name = "label15";
            label15.Size = new Size(124, 25);
            label15.TabIndex = 25;
            label15.Text = "Select Exercise";
            // 
            // language
            // 
            language.BackColor = Color.White;
            language.BorderColor = Color.LightGray;
            language.BorderSize = 1;
            language.DropDownStyle = ComboBoxStyle.DropDown;
            language.Font = new Font("Segoe UI", 10F);
            language.ForeColor = Color.DimGray;
            language.IconColor = Color.Gray;
            language.Items.AddRange(new object[] { "C++", "Java", "Python" });
            language.ListBackColor = Color.FromArgb(230, 228, 245);
            language.ListTextColor = Color.DimGray;
            language.Location = new Point(23, 229);
            language.MinimumSize = new Size(200, 30);
            language.Name = "language";
            language.Padding = new Padding(1);
            language.Size = new Size(250, 41);
            language.TabIndex = 23;
            language.Texts = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(23, 201);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 21;
            label7.Text = "Language";
            // 
            // serverName
            // 
            serverName.BackColor = Color.White;
            serverName.BorderColor = Color.LightGray;
            serverName.BorderFocusColor = Color.FromArgb(64, 64, 64);
            serverName.BorderRadius = 10;
            serverName.BorderSize = 1;
            serverName.ForeColor = SystemColors.ControlText;
            serverName.Location = new Point(23, 111);
            serverName.Name = "serverName";
            serverName.Padding = new Padding(10, 7, 10, 7);
            serverName.ScrollBars = ScrollBars.None;
            serverName.Size = new Size(368, 41);
            serverName.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(23, 83);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 17;
            label4.Text = "Session Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(13, 13, 13);
            label12.Location = new Point(23, 21);
            label12.Name = "label12";
            label12.Size = new Size(181, 31);
            label12.TabIndex = 13;
            label12.Text = "Session Control";
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(192, 255, 192);
            customCard1.BorderColor = Color.Gray;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(label2);
            customCard1.Controls.Add(label1);
            customCard1.Location = new Point(1010, 31);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(206, 69);
            customCard1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(26, 41);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 16;
            label2.Text = "Started 45 minutes ago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(39, 7);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 16;
            label1.Text = "Session Active";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(106, 75);
            label5.Name = "label5";
            label5.Size = new Size(391, 25);
            label5.TabIndex = 18;
            label5.Text = "Control and monitor programming lab sessions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(105, 31);
            label3.Name = "label3";
            label3.Size = new Size(209, 38);
            label3.TabIndex = 17;
            label3.Text = "Set Up Session";
            // 
            // ServerSetUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customCard2);
            Controls.Add(customCard1);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "ServerSetUp";
            Size = new Size(1335, 994);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            exerciseContainer.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GeneralComponents.CustomCard customCard2;
        private Label label15;
        private GeneralComponents.CustomComboBox language;
        private Label label7;
        private CustomTextBox serverName;
        private Label label4;
        private Label label12;
        private GeneralComponents.CustomCard customCard1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private GeneralComponents.CustomCard exerciseContainer;
        private GeneralComponents.SmartButton smartButton3;
        private GeneralComponents.CustomCard taskContainer;
        private GeneralComponents.SmartButton smartButton4;
    }
}
