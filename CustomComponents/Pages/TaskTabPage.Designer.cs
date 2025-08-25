namespace SmartCodeLab.CustomComponents.Pages
{
    partial class TaskTabPage
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
            actName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            languageUsed = new MaterialSkin.Controls.MaterialComboBox();
            testContainer = new FlowLayoutPanel();
            associateContainer = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            externalResourceCon = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            openFile1 = new SmartButton();
            smartButton1 = new SmartButton();
            Btn_AddTestCase = new SmartButton();
            txtbox_instruction = new TextBox();
            SuspendLayout();
            // 
            // actName
            // 
            actName.AnimateReadOnly = false;
            actName.BorderStyle = BorderStyle.None;
            actName.Depth = 0;
            actName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            actName.LeadingIcon = null;
            actName.Location = new Point(37, 40);
            actName.MaxLength = 50;
            actName.MouseState = MaterialSkin.MouseState.OUT;
            actName.Multiline = false;
            actName.Name = "actName";
            actName.Size = new Size(234, 50);
            actName.TabIndex = 16;
            actName.Text = "";
            actName.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(37, 115);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(76, 19);
            materialLabel10.TabIndex = 15;
            materialLabel10.Text = "Instruction";
            // 
            // languageUsed
            // 
            languageUsed.AutoCompleteCustomSource.AddRange(new string[] { "Cpp", "Java", "Python" });
            languageUsed.AutoResize = false;
            languageUsed.BackColor = Color.FromArgb(255, 255, 255);
            languageUsed.Depth = 0;
            languageUsed.DrawMode = DrawMode.OwnerDrawVariable;
            languageUsed.DropDownHeight = 174;
            languageUsed.DropDownStyle = ComboBoxStyle.DropDownList;
            languageUsed.DropDownWidth = 121;
            languageUsed.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            languageUsed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            languageUsed.FormattingEnabled = true;
            languageUsed.IntegralHeight = false;
            languageUsed.ItemHeight = 43;
            languageUsed.Items.AddRange(new object[] { "Cpp", "Java", "Python" });
            languageUsed.Location = new Point(307, 41);
            languageUsed.Margin = new Padding(3, 2, 3, 2);
            languageUsed.MaxDropDownItems = 4;
            languageUsed.MouseState = MaterialSkin.MouseState.OUT;
            languageUsed.Name = "languageUsed";
            languageUsed.Size = new Size(167, 49);
            languageUsed.StartIndex = 0;
            languageUsed.TabIndex = 24;
            languageUsed.SelectedIndexChanged += languageUsed_SelectedIndexChanged;
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.BackColor = Color.White;
            testContainer.BorderStyle = BorderStyle.FixedSingle;
            testContainer.Location = new Point(37, 352);
            testContainer.Margin = new Padding(3, 2, 3, 2);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(856, 184);
            testContainer.TabIndex = 25;
            // 
            // associateContainer
            // 
            associateContainer.AcceptMultipleFiles = false;
            associateContainer.BorderStyle = BorderStyle.FixedSingle;
            associateContainer.Location = new Point(529, 41);
            associateContainer.Margin = new Padding(3, 2, 3, 2);
            associateContainer.Name = "associateContainer";
            associateContainer.Size = new Size(222, 49);
            associateContainer.TabIndex = 27;
            // 
            // externalResourceCon
            // 
            externalResourceCon.AcceptMultipleFiles = true;
            externalResourceCon.Location = new Point(529, 137);
            externalResourceCon.Margin = new Padding(3, 2, 3, 2);
            externalResourceCon.Name = "externalResourceCon";
            externalResourceCon.Size = new Size(224, 95);
            externalResourceCon.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 29;
            label1.Text = "Activity Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 15);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 30;
            label2.Text = "Language";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(529, 16);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 31;
            label3.Text = "Associate Files";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(529, 111);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 32;
            label4.Text = "Resources Files";
            // 
            // openFile1
            // 
            openFile1.BackColor = Color.RoyalBlue;
            openFile1.BackgroundColor = Color.RoyalBlue;
            openFile1.BorderRadius = 5;
            openFile1.Cursor = Cursors.Hand;
            openFile1.FlatAppearance.BorderSize = 0;
            openFile1.FlatStyle = FlatStyle.Flat;
            openFile1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            openFile1.ForeColor = Color.White;
            openFile1.Location = new Point(770, 40);
            openFile1.Name = "openFile1";
            openFile1.Size = new Size(123, 32);
            openFile1.TabIndex = 33;
            openFile1.Text = "OPEN FILE";
            openFile1.UseVisualStyleBackColor = false;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.RoyalBlue;
            smartButton1.BackgroundColor = Color.RoyalBlue;
            smartButton1.BorderRadius = 5;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(770, 136);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(123, 32);
            smartButton1.TabIndex = 34;
            smartButton1.Text = "OPEN FILE";
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // Btn_AddTestCase
            // 
            Btn_AddTestCase.BackColor = Color.RoyalBlue;
            Btn_AddTestCase.BackgroundColor = Color.RoyalBlue;
            Btn_AddTestCase.BorderRadius = 5;
            Btn_AddTestCase.Cursor = Cursors.Hand;
            Btn_AddTestCase.FlatAppearance.BorderSize = 0;
            Btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            Btn_AddTestCase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Btn_AddTestCase.ForeColor = Color.White;
            Btn_AddTestCase.Location = new Point(37, 311);
            Btn_AddTestCase.Name = "Btn_AddTestCase";
            Btn_AddTestCase.Size = new Size(140, 36);
            Btn_AddTestCase.TabIndex = 35;
            Btn_AddTestCase.Text = "ADD TEST CASE";
            Btn_AddTestCase.UseVisualStyleBackColor = false;
            Btn_AddTestCase.Click += Btn_AddTestCase_Click;
            // 
            // txtbox_instruction
            // 
            txtbox_instruction.BorderStyle = BorderStyle.FixedSingle;
            txtbox_instruction.Location = new Point(37, 137);
            txtbox_instruction.Multiline = true;
            txtbox_instruction.Name = "txtbox_instruction";
            txtbox_instruction.Size = new Size(437, 95);
            txtbox_instruction.TabIndex = 36;
            // 
            // TaskTabPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(txtbox_instruction);
            Controls.Add(Btn_AddTestCase);
            Controls.Add(smartButton1);
            Controls.Add(openFile1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(externalResourceCon);
            Controls.Add(associateContainer);
            Controls.Add(testContainer);
            Controls.Add(languageUsed);
            Controls.Add(actName);
            Controls.Add(materialLabel10);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaskTabPage";
            Size = new Size(1058, 548);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox actName;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox languageUsed;
        private FlowLayoutPanel testContainer;
        private TaskPageComponents.FileContainer associateContainer;
        private TaskPageComponents.FileContainer externalResourceCon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private SmartButton openFile1;
        private SmartButton smartButton1;
        private SmartButton Btn_AddTestCase;
        private TextBox txtbox_instruction;
    }
}
