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
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            openFile1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            instruction = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            actName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            languageUsed = new MaterialSkin.Controls.MaterialComboBox();
            testContainer = new FlowLayoutPanel();
            associateContainer = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            externalResourceCon = new SmartCodeLab.CustomComponents.TaskPageComponents.FileContainer();
            SuspendLayout();
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(1018, 261);
            materialButton5.Margin = new Padding(5, 8, 5, 8);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(112, 48);
            materialButton5.TabIndex = 23;
            materialButton5.Text = "Open File";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += materialButton5_Click;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(754, 153);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(111, 19);
            materialLabel12.TabIndex = 22;
            materialLabel12.Text = "Resources Files";
            // 
            // openFile1
            // 
            openFile1.AutoSize = false;
            openFile1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openFile1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            openFile1.Depth = 0;
            openFile1.HighEmphasis = true;
            openFile1.Icon = null;
            openFile1.Location = new Point(1018, 38);
            openFile1.Margin = new Padding(5, 8, 5, 8);
            openFile1.MouseState = MaterialSkin.MouseState.HOVER;
            openFile1.Name = "openFile1";
            openFile1.NoAccentTextColor = Color.Empty;
            openFile1.Size = new Size(112, 48);
            openFile1.TabIndex = 21;
            openFile1.Text = "Open File";
            openFile1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            openFile1.UseAccentColor = false;
            openFile1.UseVisualStyleBackColor = true;
            openFile1.Click += openFile1_Click;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(754, 23);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(107, 19);
            materialLabel11.TabIndex = 20;
            materialLabel11.Text = "Associate Files";
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(32, 424);
            materialButton4.Margin = new Padding(5, 8, 5, 8);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(168, 48);
            materialButton4.TabIndex = 19;
            materialButton4.Text = "Add Test Case";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // instruction
            // 
            instruction.BackColor = Color.FromArgb(255, 255, 255);
            instruction.BorderStyle = BorderStyle.FixedSingle;
            instruction.Depth = 0;
            instruction.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            instruction.ForeColor = Color.FromArgb(222, 0, 0, 0);
            instruction.Location = new Point(42, 182);
            instruction.Margin = new Padding(3, 4, 3, 4);
            instruction.MouseState = MaterialSkin.MouseState.HOVER;
            instruction.Name = "instruction";
            instruction.Size = new Size(593, 127);
            instruction.TabIndex = 18;
            instruction.Text = "";
            // 
            // actName
            // 
            actName.AnimateReadOnly = false;
            actName.BorderStyle = BorderStyle.None;
            actName.Depth = 0;
            actName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            actName.LeadingIcon = null;
            actName.Location = new Point(42, 53);
            actName.Margin = new Padding(3, 4, 3, 4);
            actName.MaxLength = 50;
            actName.MouseState = MaterialSkin.MouseState.OUT;
            actName.Multiline = false;
            actName.Name = "actName";
            actName.Size = new Size(271, 50);
            actName.TabIndex = 16;
            actName.Text = "";
            actName.TrailingIcon = null;
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
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(380, 23);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(72, 19);
            materialLabel9.TabIndex = 14;
            materialLabel9.Text = "Language";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(42, 23);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(99, 19);
            materialLabel8.TabIndex = 13;
            materialLabel8.Text = "Activity Name";
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
            languageUsed.Location = new Point(380, 54);
            languageUsed.MaxDropDownItems = 4;
            languageUsed.MouseState = MaterialSkin.MouseState.OUT;
            languageUsed.Name = "languageUsed";
            languageUsed.Size = new Size(255, 49);
            languageUsed.StartIndex = 0;
            languageUsed.TabIndex = 24;
            // 
            // testContainer
            // 
            testContainer.AutoScroll = true;
            testContainer.Location = new Point(32, 492);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(1159, 223);
            testContainer.TabIndex = 25;
            // 
            // associateContainer
            // 
            associateContainer.AcceptMultipleFiles = false;
            associateContainer.BorderStyle = BorderStyle.FixedSingle;
            associateContainer.Location = new Point(754, 45);
            associateContainer.Name = "associateContainer";
            associateContainer.Size = new Size(254, 41);
            associateContainer.TabIndex = 27;
            // 
            // externalResourceCon
            // 
            externalResourceCon.AcceptMultipleFiles = true;
            externalResourceCon.Location = new Point(754, 182);
            externalResourceCon.Name = "externalResourceCon";
            externalResourceCon.Size = new Size(256, 127);
            externalResourceCon.TabIndex = 28;
            // 
            // TaskTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(externalResourceCon);
            Controls.Add(associateContainer);
            Controls.Add(testContainer);
            Controls.Add(languageUsed);
            Controls.Add(materialButton5);
            Controls.Add(materialLabel12);
            Controls.Add(openFile1);
            Controls.Add(materialLabel11);
            Controls.Add(materialButton4);
            Controls.Add(instruction);
            Controls.Add(actName);
            Controls.Add(materialLabel10);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel8);
            Name = "TaskTabPage";
            Size = new Size(1209, 731);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton openFile1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox instruction;
        private MaterialSkin.Controls.MaterialTextBox actName;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox languageUsed;
        private FlowLayoutPanel testContainer;
        private TaskPageComponents.FileContainer associateContainer;
        private TaskPageComponents.FileContainer externalResourceCon;
    }
}
