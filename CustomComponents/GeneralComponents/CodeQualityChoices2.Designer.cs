namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    partial class CodeQualityChoices2
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
            robustnessBox = new CheckBox();
            efficiencyCB = new CheckBox();
            maintainabilityCB = new CheckBox();
            accuracyT = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            efficiencyT = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            robustnessT = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            maintainabilityT = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel4 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel5 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            logicalComplexityLabel = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            efficiencyLabel = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            readabilityLabel = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            accuracyLabel = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // robustnessBox
            // 
            robustnessBox.AutoSize = true;
            robustnessBox.Location = new Point(31, 295);
            robustnessBox.Margin = new Padding(3, 4, 3, 4);
            robustnessBox.Name = "robustnessBox";
            robustnessBox.Size = new Size(18, 17);
            robustnessBox.TabIndex = 50;
            robustnessBox.UseVisualStyleBackColor = true;
            robustnessBox.CheckedChanged += robustnessBox_CheckedChanged_1;
            // 
            // efficiencyCB
            // 
            efficiencyCB.AutoSize = true;
            efficiencyCB.Location = new Point(31, 201);
            efficiencyCB.Margin = new Padding(3, 4, 3, 4);
            efficiencyCB.Name = "efficiencyCB";
            efficiencyCB.Size = new Size(18, 17);
            efficiencyCB.TabIndex = 51;
            efficiencyCB.UseVisualStyleBackColor = true;
            efficiencyCB.CheckedChanged += efficiencyCB_CheckedChanged;
            // 
            // maintainabilityCB
            // 
            maintainabilityCB.AutoSize = true;
            maintainabilityCB.Location = new Point(31, 387);
            maintainabilityCB.Margin = new Padding(3, 4, 3, 4);
            maintainabilityCB.Name = "maintainabilityCB";
            maintainabilityCB.Size = new Size(18, 17);
            maintainabilityCB.TabIndex = 52;
            maintainabilityCB.UseVisualStyleBackColor = true;
            maintainabilityCB.CheckedChanged += maintainabilityCB_CheckedChanged;
            // 
            // accuracyT
            // 
            accuracyT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accuracyT.BackColor = Color.Transparent;
            accuracyT.Location = new Point(30, 132);
            accuracyT.Maximum = 100;
            accuracyT.Name = "accuracyT";
            accuracyT.Size = new Size(394, 29);
            accuracyT.TabIndex = 54;
            accuracyT.Text = "steamTrackBar1";
            accuracyT.Value = 0;
            // 
            // efficiencyT
            // 
            efficiencyT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            efficiencyT.BackColor = Color.Transparent;
            efficiencyT.Enabled = false;
            efficiencyT.Location = new Point(30, 226);
            efficiencyT.Maximum = 100;
            efficiencyT.Name = "efficiencyT";
            efficiencyT.Size = new Size(394, 29);
            efficiencyT.TabIndex = 55;
            efficiencyT.Text = "steamTrackBar2";
            efficiencyT.Value = 0;
            // 
            // robustnessT
            // 
            robustnessT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            robustnessT.BackColor = Color.Transparent;
            robustnessT.Enabled = false;
            robustnessT.Location = new Point(30, 320);
            robustnessT.Maximum = 100;
            robustnessT.Name = "robustnessT";
            robustnessT.Size = new Size(394, 29);
            robustnessT.TabIndex = 56;
            robustnessT.Text = "steamTrackBar3";
            robustnessT.Value = 0;
            // 
            // maintainabilityT
            // 
            maintainabilityT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maintainabilityT.BackColor = Color.Transparent;
            maintainabilityT.Enabled = false;
            maintainabilityT.Location = new Point(30, 414);
            maintainabilityT.Maximum = 100;
            maintainabilityT.Name = "maintainabilityT";
            maintainabilityT.Size = new Size(394, 29);
            maintainabilityT.TabIndex = 57;
            maintainabilityT.Text = "steamTrackBar4";
            maintainabilityT.Value = 0;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(30, 31);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(225, 32);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 58;
            steamLabel1.Text = "Grading Criteria";
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel2.Location = new Point(44, 106);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(143, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel2.TabIndex = 59;
            steamLabel2.Text = "Code Accuracy";
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 12F);
            steamLabel3.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel3.Location = new Point(54, 195);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(94, 23);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel3.TabIndex = 60;
            steamLabel3.Text = "Efficiency";
            // 
            // steamLabel4
            // 
            steamLabel4.AutoSize = true;
            steamLabel4.BackColor = Color.Transparent;
            steamLabel4.Font = new Font("Geist", 12F);
            steamLabel4.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel4.Location = new Point(54, 289);
            steamLabel4.Name = "steamLabel4";
            steamLabel4.Size = new Size(113, 23);
            steamLabel4.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel4.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel4.TabIndex = 61;
            steamLabel4.Text = "Robustness";
            // 
            // steamLabel5
            // 
            steamLabel5.AutoSize = true;
            steamLabel5.BackColor = Color.Transparent;
            steamLabel5.Font = new Font("Geist", 12F);
            steamLabel5.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel5.Location = new Point(54, 383);
            steamLabel5.Name = "steamLabel5";
            steamLabel5.Size = new Size(133, 23);
            steamLabel5.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel5.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel5.TabIndex = 62;
            steamLabel5.Text = "Maintainability";
            // 
            // logicalComplexityLabel
            // 
            logicalComplexityLabel.Anchor = AnchorStyles.Right;
            logicalComplexityLabel.AutoSize = true;
            logicalComplexityLabel.BackColor = Color.Transparent;
            logicalComplexityLabel.Font = new Font("Geist", 10F);
            logicalComplexityLabel.ForeColor = Color.FromArgb(139, 149, 166);
            logicalComplexityLabel.Location = new Point(370, 387);
            logicalComplexityLabel.Margin = new Padding(0, 0, 0, 5);
            logicalComplexityLabel.Name = "logicalComplexityLabel";
            logicalComplexityLabel.Size = new Size(33, 19);
            logicalComplexityLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            logicalComplexityLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            logicalComplexityLabel.TabIndex = 66;
            logicalComplexityLabel.Text = "0%";
            // 
            // efficiencyLabel
            // 
            efficiencyLabel.Anchor = AnchorStyles.Right;
            efficiencyLabel.AutoSize = true;
            efficiencyLabel.BackColor = Color.Transparent;
            efficiencyLabel.Font = new Font("Geist", 10F);
            efficiencyLabel.ForeColor = Color.FromArgb(139, 149, 166);
            efficiencyLabel.Location = new Point(370, 293);
            efficiencyLabel.Margin = new Padding(0, 0, 0, 5);
            efficiencyLabel.Name = "efficiencyLabel";
            efficiencyLabel.Size = new Size(33, 19);
            efficiencyLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            efficiencyLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            efficiencyLabel.TabIndex = 65;
            efficiencyLabel.Text = "0%";
            // 
            // readabilityLabel
            // 
            readabilityLabel.Anchor = AnchorStyles.Right;
            readabilityLabel.AutoSize = true;
            readabilityLabel.BackColor = Color.Transparent;
            readabilityLabel.Font = new Font("Geist", 10F);
            readabilityLabel.ForeColor = Color.FromArgb(139, 149, 166);
            readabilityLabel.Location = new Point(370, 199);
            readabilityLabel.Margin = new Padding(0, 0, 0, 5);
            readabilityLabel.Name = "readabilityLabel";
            readabilityLabel.Size = new Size(33, 19);
            readabilityLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            readabilityLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            readabilityLabel.TabIndex = 64;
            readabilityLabel.Text = "0%";
            // 
            // accuracyLabel
            // 
            accuracyLabel.Anchor = AnchorStyles.Right;
            accuracyLabel.AutoSize = true;
            accuracyLabel.BackColor = Color.Transparent;
            accuracyLabel.Font = new Font("Geist", 10F);
            accuracyLabel.ForeColor = Color.FromArgb(139, 149, 166);
            accuracyLabel.Location = new Point(370, 105);
            accuracyLabel.Margin = new Padding(0, 0, 0, 5);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(33, 19);
            accuracyLabel.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            accuracyLabel.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            accuracyLabel.TabIndex = 63;
            accuracyLabel.Text = "0%";
            // 
            // button1
            // 
            button1.Location = new Point(271, -1);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 67;
            button1.Text = "Change Reference Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CodeQualityChoices2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(logicalComplexityLabel);
            Controls.Add(efficiencyLabel);
            Controls.Add(readabilityLabel);
            Controls.Add(accuracyLabel);
            Controls.Add(steamLabel5);
            Controls.Add(steamLabel4);
            Controls.Add(steamLabel3);
            Controls.Add(steamLabel2);
            Controls.Add(steamLabel1);
            Controls.Add(maintainabilityT);
            Controls.Add(robustnessT);
            Controls.Add(efficiencyT);
            Controls.Add(accuracyT);
            Controls.Add(maintainabilityCB);
            Controls.Add(efficiencyCB);
            Controls.Add(robustnessBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CodeQualityChoices2";
            Size = new Size(451, 511);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox robustnessBox;
        private CheckBox efficiencyCB;
        private CheckBox maintainabilityCB;
        private SteamThings.SteamTrackBar accuracyT;
        private SteamThings.SteamTrackBar efficiencyT;
        private SteamThings.SteamTrackBar robustnessT;
        private SteamThings.SteamTrackBar maintainabilityT;
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamLabel steamLabel4;
        private SteamThings.SteamLabel steamLabel5;
        private SteamThings.SteamLabel logicalComplexityLabel;
        private SteamThings.SteamLabel efficiencyLabel;
        private SteamThings.SteamLabel readabilityLabel;
        private SteamThings.SteamLabel accuracyLabel;
        private Button button1;
    }
}
