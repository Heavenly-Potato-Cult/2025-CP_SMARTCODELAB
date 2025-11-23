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
            logicalComplexityLabel = new Label();
            efficiencyLabel = new Label();
            accuracyLabel = new Label();
            label14 = new Label();
            robustnessT = new TrackBar();
            label11 = new Label();
            maintainabilityT = new TrackBar();
            label2 = new Label();
            efficiencyT = new TrackBar();
            label8 = new Label();
            accuracyT = new TrackBar();
            label13 = new Label();
            readabilityLabel = new Label();
            robustnessBox = new CheckBox();
            efficiencyCB = new CheckBox();
            maintainabilityCB = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)robustnessT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maintainabilityT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)efficiencyT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accuracyT).BeginInit();
            SuspendLayout();
            // 
            // logicalComplexityLabel
            // 
            logicalComplexityLabel.Anchor = AnchorStyles.Right;
            logicalComplexityLabel.AutoSize = true;
            logicalComplexityLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logicalComplexityLabel.ForeColor = Color.DimGray;
            logicalComplexityLabel.Location = new Point(387, 388);
            logicalComplexityLabel.Name = "logicalComplexityLabel";
            logicalComplexityLabel.Size = new Size(37, 25);
            logicalComplexityLabel.TabIndex = 46;
            logicalComplexityLabel.Text = "0%";
            // 
            // efficiencyLabel
            // 
            efficiencyLabel.Anchor = AnchorStyles.Right;
            efficiencyLabel.AutoSize = true;
            efficiencyLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            efficiencyLabel.ForeColor = Color.DimGray;
            efficiencyLabel.Location = new Point(387, 293);
            efficiencyLabel.Name = "efficiencyLabel";
            efficiencyLabel.Size = new Size(37, 25);
            efficiencyLabel.TabIndex = 45;
            efficiencyLabel.Text = "0%";
            // 
            // accuracyLabel
            // 
            accuracyLabel.Anchor = AnchorStyles.Right;
            accuracyLabel.AutoSize = true;
            accuracyLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accuracyLabel.ForeColor = Color.DimGray;
            accuracyLabel.Location = new Point(387, 104);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(57, 25);
            accuracyLabel.TabIndex = 44;
            accuracyLabel.Text = "100%";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(30, 293);
            label14.Name = "label14";
            label14.Size = new Size(103, 25);
            label14.TabIndex = 43;
            label14.Text = "Robustness";
            // 
            // robustnessT
            // 
            robustnessT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            robustnessT.Enabled = false;
            robustnessT.Location = new Point(30, 324);
            robustnessT.Margin = new Padding(3, 4, 3, 4);
            robustnessT.Name = "robustnessT";
            robustnessT.Size = new Size(391, 56);
            robustnessT.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(30, 388);
            label11.Name = "label11";
            label11.Size = new Size(127, 25);
            label11.TabIndex = 41;
            label11.Text = "Maintainability";
            // 
            // maintainabilityT
            // 
            maintainabilityT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maintainabilityT.Enabled = false;
            maintainabilityT.Location = new Point(30, 419);
            maintainabilityT.Margin = new Padding(3, 4, 3, 4);
            maintainabilityT.Name = "maintainabilityT";
            maintainabilityT.Size = new Size(391, 56);
            maintainabilityT.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(30, 199);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 39;
            label2.Text = "Efficiency";
            // 
            // efficiencyT
            // 
            efficiencyT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            efficiencyT.Enabled = false;
            efficiencyT.Location = new Point(30, 229);
            efficiencyT.Margin = new Padding(3, 4, 3, 4);
            efficiencyT.Name = "efficiencyT";
            efficiencyT.Size = new Size(391, 56);
            efficiencyT.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(30, 104);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 37;
            label8.Text = "Code Accuracy";
            // 
            // accuracyT
            // 
            accuracyT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accuracyT.Location = new Point(30, 135);
            accuracyT.Margin = new Padding(3, 4, 3, 4);
            accuracyT.Name = "accuracyT";
            accuracyT.Size = new Size(391, 56);
            accuracyT.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(30, 31);
            label13.Name = "label13";
            label13.Size = new Size(206, 37);
            label13.TabIndex = 35;
            label13.Text = "Grading Criteria";
            // 
            // readabilityLabel
            // 
            readabilityLabel.Anchor = AnchorStyles.Right;
            readabilityLabel.AutoSize = true;
            readabilityLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readabilityLabel.ForeColor = Color.DimGray;
            readabilityLabel.Location = new Point(387, 199);
            readabilityLabel.Name = "readabilityLabel";
            readabilityLabel.Size = new Size(37, 25);
            readabilityLabel.TabIndex = 47;
            readabilityLabel.Text = "0%";
            // 
            // robustnessBox
            // 
            robustnessBox.AutoSize = true;
            robustnessBox.Location = new Point(154, 299);
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
            efficiencyCB.Enabled = false;
            efficiencyCB.Location = new Point(154, 204);
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
            maintainabilityCB.Enabled = false;
            maintainabilityCB.Location = new Point(154, 393);
            maintainabilityCB.Margin = new Padding(3, 4, 3, 4);
            maintainabilityCB.Name = "maintainabilityCB";
            maintainabilityCB.Size = new Size(18, 17);
            maintainabilityCB.TabIndex = 52;
            maintainabilityCB.UseVisualStyleBackColor = true;
            maintainabilityCB.CheckedChanged += maintainabilityCB_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(281, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 53;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CodeQualityChoices2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderRadius = 10;
            Controls.Add(button1);
            Controls.Add(maintainabilityCB);
            Controls.Add(efficiencyCB);
            Controls.Add(robustnessBox);
            Controls.Add(readabilityLabel);
            Controls.Add(logicalComplexityLabel);
            Controls.Add(efficiencyLabel);
            Controls.Add(accuracyLabel);
            Controls.Add(label14);
            Controls.Add(robustnessT);
            Controls.Add(label11);
            Controls.Add(maintainabilityT);
            Controls.Add(label2);
            Controls.Add(efficiencyT);
            Controls.Add(label8);
            Controls.Add(accuracyT);
            Controls.Add(label13);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CodeQualityChoices2";
            Size = new Size(451, 511);
            ((System.ComponentModel.ISupportInitialize)robustnessT).EndInit();
            ((System.ComponentModel.ISupportInitialize)maintainabilityT).EndInit();
            ((System.ComponentModel.ISupportInitialize)efficiencyT).EndInit();
            ((System.ComponentModel.ISupportInitialize)accuracyT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logicalComplexityLabel;
        private Label efficiencyLabel;
        private Label accuracyLabel;
        private Label label14;
        private TrackBar robustnessT;
        private Label label11;
        private TrackBar maintainabilityT;
        private Label label2;
        private TrackBar efficiencyT;
        private Label label8;
        private TrackBar accuracyT;
        private Label label13;
        private Label readabilityLabel;
        private CheckBox robustnessBox;
        private CheckBox efficiencyCB;
        private CheckBox maintainabilityCB;
        private Button button1;
    }
}
