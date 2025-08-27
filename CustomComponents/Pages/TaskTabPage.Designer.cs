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
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            testContainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Btn_AddTestCase = new SmartButton();
            txtbox_instruction = new TextBox();
            languageUsed = new CustomComboBox();
            actName = new CustomTextBox();
            associateContainer = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            externalResourceCon = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            SuspendLayout();
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(42, 153);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(76, 19);
            materialLabel10.TabIndex = 15;
            materialLabel10.Text = "Instruction";
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.BackColor = Color.White;
            testContainer.BorderStyle = BorderStyle.FixedSingle;
            testContainer.Location = new Point(42, 469);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(978, 245);
            testContainer.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 29;
            label1.Text = "Activity Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(351, 20);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 30;
            label2.Text = "Language";
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
            Btn_AddTestCase.Location = new Point(42, 415);
            Btn_AddTestCase.Margin = new Padding(3, 4, 3, 4);
            Btn_AddTestCase.Name = "Btn_AddTestCase";
            Btn_AddTestCase.Size = new Size(160, 48);
            Btn_AddTestCase.TabIndex = 35;
            Btn_AddTestCase.Text = "ADD TEST CASE";
            Btn_AddTestCase.UseVisualStyleBackColor = false;
            Btn_AddTestCase.Click += Btn_AddTestCase_Click;
            // 
            // txtbox_instruction
            // 
            txtbox_instruction.BorderStyle = BorderStyle.FixedSingle;
            txtbox_instruction.Location = new Point(42, 183);
            txtbox_instruction.Margin = new Padding(3, 4, 3, 4);
            txtbox_instruction.Multiline = true;
            txtbox_instruction.Name = "txtbox_instruction";
            txtbox_instruction.Size = new Size(521, 126);
            txtbox_instruction.TabIndex = 36;
            // 
            // languageUsed
            // 
            languageUsed.BackColor = Color.WhiteSmoke;
            languageUsed.BorderColor = Color.Gray;
            languageUsed.BorderSize = 1;
            languageUsed.DropDownStyle = ComboBoxStyle.DropDown;
            languageUsed.Font = new Font("Segoe UI", 10F);
            languageUsed.ForeColor = Color.DimGray;
            languageUsed.IconColor = Color.RoyalBlue;
            languageUsed.Items.AddRange(new object[] { "Cpp", "Java", "Python" });
            languageUsed.ListBackColor = Color.FromArgb(230, 228, 245);
            languageUsed.ListTextColor = Color.DimGray;
            languageUsed.Location = new Point(335, 53);
            languageUsed.Margin = new Padding(3, 4, 3, 4);
            languageUsed.MinimumSize = new Size(229, 40);
            languageUsed.Name = "languageUsed";
            languageUsed.Padding = new Padding(1);
            languageUsed.Size = new Size(229, 49);
            languageUsed.TabIndex = 38;
            languageUsed.Texts = "";
            // 
            // actName
            // 
            actName.BackColor = SystemColors.Window;
            actName.ForeColor = Color.DimGray;
            actName.Location = new Point(42, 55);
            actName.Name = "actName";
            actName.Padding = new Padding(10, 7, 10, 7);
            actName.Size = new Size(276, 41);
            actName.TabIndex = 39;
            // 
            // associateContainer
            // 
            associateContainer.AcceptMultipleFiles = false;
            associateContainer.ContainerHeight = 50;
            associateContainer.LabelText = "Associate Files";
            associateContainer.Location = new Point(605, 21);
            associateContainer.Name = "associateContainer";
            associateContainer.Size = new Size(348, 88);
            associateContainer.TabIndex = 40;
            // 
            // externalResourceCon
            // 
            externalResourceCon.AcceptMultipleFiles = true;
            externalResourceCon.ContainerHeight = 115;
            externalResourceCon.LabelText = "Exernal Files";
            externalResourceCon.Location = new Point(605, 153);
            externalResourceCon.Name = "externalResourceCon";
            externalResourceCon.Size = new Size(348, 156);
            externalResourceCon.TabIndex = 41;
            // 
            // TaskTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(externalResourceCon);
            Controls.Add(associateContainer);
            Controls.Add(actName);
            Controls.Add(languageUsed);
            Controls.Add(txtbox_instruction);
            Controls.Add(Btn_AddTestCase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(testContainer);
            Controls.Add(materialLabel10);
            Name = "TaskTabPage";
            Size = new Size(1209, 731);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private FlowLayoutPanel testContainer;
        private Label label1;
        private Label label2;
        private SmartButton Btn_AddTestCase;
        private TextBox txtbox_instruction;
        private CustomComboBox languageUsed;
        private CustomTextBox actName;
        private TaskPageComponents.FileContainer associateContainer;
        private TaskPageComponents.FileContainer externalResourceCon;
    }
}
