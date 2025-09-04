using SmartCodeLab.CustomComponents.GeneralComponents;

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
            testContainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Btn_AddTestCase = new SmartButton();
            txtbox_instruction = new TextBox();
            languageUsed = new CustomComboBox();
            actName = new CustomTextBox();
            associateContainer = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            externalResourceCon = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            label3 = new Label();
            SuspendLayout();
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.BackColor = Color.FromArgb(13, 13, 13);
            testContainer.BorderStyle = BorderStyle.FixedSingle;
            testContainer.Location = new Point(42, 428);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(985, 286);
            testContainer.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 29;
            label1.Text = "Activity Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(335, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 30;
            label2.Text = "Language";
            // 
            // Btn_AddTestCase
            // 
            Btn_AddTestCase.BackColor = Color.MediumSlateBlue;
            Btn_AddTestCase.BorderRadius = 5;
            Btn_AddTestCase.Cursor = Cursors.Hand;
            Btn_AddTestCase.FlatAppearance.BorderSize = 0;
            Btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            Btn_AddTestCase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Btn_AddTestCase.ForeColor = Color.FromArgb(242, 242, 242);
            Btn_AddTestCase.Location = new Point(42, 373);
            Btn_AddTestCase.Margin = new Padding(3, 4, 3, 4);
            Btn_AddTestCase.Name = "Btn_AddTestCase";
            Btn_AddTestCase.Size = new Size(160, 48);
            Btn_AddTestCase.TabIndex = 35;
            Btn_AddTestCase.Text = "ADD TEST CASE";
            Btn_AddTestCase.TextColor = Color.FromArgb(242, 242, 242);
            Btn_AddTestCase.UseVisualStyleBackColor = false;
            Btn_AddTestCase.Click += Btn_AddTestCase_Click;
            // 
            // txtbox_instruction
            // 
            txtbox_instruction.BackColor = Color.FromArgb(13, 13, 13);
            txtbox_instruction.BorderStyle = BorderStyle.FixedSingle;
            txtbox_instruction.ForeColor = Color.FromArgb(179, 179, 179);
            txtbox_instruction.Location = new Point(42, 183);
            txtbox_instruction.Margin = new Padding(3, 4, 3, 4);
            txtbox_instruction.Multiline = true;
            txtbox_instruction.Name = "txtbox_instruction";
            txtbox_instruction.Size = new Size(521, 126);
            txtbox_instruction.TabIndex = 36;
            // 
            // languageUsed
            // 
            languageUsed.BackColor = Color.FromArgb(13, 13, 13);
            languageUsed.BorderColor = Color.Gray;
            languageUsed.BorderSize = 1;
            languageUsed.DropDownStyle = ComboBoxStyle.DropDown;
            languageUsed.Font = new Font("Segoe UI", 10F);
            languageUsed.ForeColor = Color.FromArgb(179, 179, 179);
            languageUsed.IconColor = Color.MediumSlateBlue;
            languageUsed.Items.AddRange(new object[] { "Cpp", "Java", "Python" });
            languageUsed.ListBackColor = Color.FromArgb(13, 13, 13);
            languageUsed.ListTextColor = Color.DimGray;
            languageUsed.Location = new Point(335, 53);
            languageUsed.Margin = new Padding(3, 4, 3, 4);
            languageUsed.MinimumSize = new Size(229, 40);
            languageUsed.Name = "languageUsed";
            languageUsed.Padding = new Padding(1);
            languageUsed.Size = new Size(229, 44);
            languageUsed.TabIndex = 38;
            languageUsed.Texts = "";
            // 
            // actName
            // 
            actName.BackColor = Color.FromArgb(13, 13, 13);
            actName.BorderColor = Color.DimGray;
            actName.BorderFocusColor = Color.DimGray;
            actName.BorderSize = 1;
            actName.ForeColor = Color.FromArgb(179, 179, 179);
            actName.Location = new Point(42, 55);
            actName.Name = "actName";
            actName.Padding = new Padding(10, 7, 10, 7);
            actName.Size = new Size(277, 41);
            actName.TabIndex = 39;
            // 
            // associateContainer
            // 
            associateContainer.AcceptMultipleFiles = false;
            associateContainer.BackColor = Color.Transparent;
            associateContainer.ContainerHeight = 50;
            associateContainer.ForeColor = Color.FromArgb(242, 242, 242);
            associateContainer.LabelText = "Associate Files";
            associateContainer.Location = new Point(680, 21);
            associateContainer.Name = "associateContainer";
            associateContainer.Size = new Size(347, 112);
            associateContainer.TabIndex = 40;
            // 
            // externalResourceCon
            // 
            externalResourceCon.AcceptMultipleFiles = true;
            externalResourceCon.BackColor = Color.Transparent;
            externalResourceCon.ContainerHeight = 115;
            externalResourceCon.ForeColor = Color.FromArgb(242, 242, 242);
            externalResourceCon.LabelText = "Exernal Files";
            externalResourceCon.Location = new Point(680, 151);
            externalResourceCon.Name = "externalResourceCon";
            externalResourceCon.Size = new Size(347, 200);
            externalResourceCon.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(242, 242, 242);
            label3.Location = new Point(42, 151);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 42;
            label3.Text = "Instruction";
            // 
            // TaskTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(label3);
            Controls.Add(externalResourceCon);
            Controls.Add(associateContainer);
            Controls.Add(actName);
            Controls.Add(languageUsed);
            Controls.Add(txtbox_instruction);
            Controls.Add(Btn_AddTestCase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(testContainer);
            Name = "TaskTabPage";
            Size = new Size(1097, 731);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel testContainer;
        private Label label1;
        private Label label2;
        private SmartButton Btn_AddTestCase;
        private TextBox txtbox_instruction;
        private CustomComboBox languageUsed;
        private CustomTextBox actName;
        private TaskPageComponents.FileContainer associateContainer;
        private TaskPageComponents.FileContainer externalResourceCon;
        private Label label3;
    }
}
