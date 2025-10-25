namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class ExerciseCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseCard));
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            dateModified = new Label();
            subject = new Label();
            lbl_ExerciseModifiedUpdate = new Label();
            lbl_ExerciseTitle = new Label();
            smartButton9 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton7 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label1 = new Label();
            testCounts = new Label();
            customCard1.SuspendLayout();
            SuspendLayout();
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Silver;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(testCounts);
            customCard1.Controls.Add(label1);
            customCard1.Controls.Add(dateModified);
            customCard1.Controls.Add(subject);
            customCard1.Controls.Add(lbl_ExerciseModifiedUpdate);
            customCard1.Controls.Add(lbl_ExerciseTitle);
            customCard1.Controls.Add(smartButton9);
            customCard1.Controls.Add(smartButton7);
            customCard1.Location = new Point(0, 0);
            customCard1.Margin = new Padding(3, 3, 30, 20);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(496, 264);
            customCard1.TabIndex = 1;
            // 
            // dateModified
            // 
            dateModified.AutoSize = true;
            dateModified.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.ForeColor = Color.DimGray;
            dateModified.Location = new Point(298, 152);
            dateModified.Name = "dateModified";
            dateModified.Size = new Size(120, 25);
            dateModified.TabIndex = 64;
            dateModified.Text = "Last Modified";
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject.ForeColor = Color.DimGray;
            subject.Location = new Point(18, 66);
            subject.Name = "subject";
            subject.Size = new Size(70, 25);
            subject.TabIndex = 63;
            subject.Text = "Subject";
            // 
            // lbl_ExerciseModifiedUpdate
            // 
            lbl_ExerciseModifiedUpdate.AutoSize = true;
            lbl_ExerciseModifiedUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseModifiedUpdate.ForeColor = Color.DimGray;
            lbl_ExerciseModifiedUpdate.Location = new Point(298, 127);
            lbl_ExerciseModifiedUpdate.Name = "lbl_ExerciseModifiedUpdate";
            lbl_ExerciseModifiedUpdate.Size = new Size(120, 25);
            lbl_ExerciseModifiedUpdate.TabIndex = 24;
            lbl_ExerciseModifiedUpdate.Text = "Last Modified";
            // 
            // lbl_ExerciseTitle
            // 
            lbl_ExerciseTitle.AutoSize = true;
            lbl_ExerciseTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ExerciseTitle.ForeColor = Color.FromArgb(13, 13, 13);
            lbl_ExerciseTitle.Location = new Point(18, 35);
            lbl_ExerciseTitle.Name = "lbl_ExerciseTitle";
            lbl_ExerciseTitle.Size = new Size(144, 31);
            lbl_ExerciseTitle.TabIndex = 19;
            lbl_ExerciseTitle.Text = "Hello World";
            // 
            // smartButton9
            // 
            smartButton9.Anchor = AnchorStyles.None;
            smartButton9.BackColor = Color.FromArgb(239, 67, 67);
            smartButton9.BackgroundColor = Color.FromArgb(239, 67, 67);
            smartButton9.BorderRadius = 10;
            smartButton9.FlatAppearance.BorderSize = 0;
            smartButton9.FlatStyle = FlatStyle.Flat;
            smartButton9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton9.ForeColor = Color.DimGray;
            smartButton9.Image = (Image)resources.GetObject("smartButton9.Image");
            smartButton9.Location = new Point(401, 194);
            smartButton9.Margin = new Padding(3, 4, 3, 4);
            smartButton9.Name = "smartButton9";
            smartButton9.Size = new Size(64, 52);
            smartButton9.TabIndex = 62;
            smartButton9.TextColor = Color.DimGray;
            smartButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton9.UseVisualStyleBackColor = false;
            smartButton9.Click += smartButton9_Click;
            // 
            // smartButton7
            // 
            smartButton7.Anchor = AnchorStyles.None;
            smartButton7.BackColor = Color.FromArgb(240, 247, 255);
            smartButton7.BackgroundColor = Color.FromArgb(240, 247, 255);
            smartButton7.BorderRadius = 10;
            smartButton7.FlatAppearance.BorderSize = 0;
            smartButton7.FlatStyle = FlatStyle.Flat;
            smartButton7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton7.ForeColor = Color.DodgerBlue;
            smartButton7.Location = new Point(18, 194);
            smartButton7.Margin = new Padding(3, 4, 3, 4);
            smartButton7.Name = "smartButton7";
            smartButton7.Size = new Size(255, 52);
            smartButton7.TabIndex = 60;
            smartButton7.Text = "Edit";
            smartButton7.TextColor = Color.DodgerBlue;
            smartButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton7.UseVisualStyleBackColor = false;
            smartButton7.Click += smartButton7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(18, 127);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 65;
            label1.Text = "Total Test Cases";
            // 
            // testCounts
            // 
            testCounts.AutoSize = true;
            testCounts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testCounts.ForeColor = Color.FromArgb(13, 13, 13);
            testCounts.Location = new Point(18, 152);
            testCounts.Name = "testCounts";
            testCounts.Size = new Size(27, 31);
            testCounts.TabIndex = 66;
            testCounts.Text = "0";
            // 
            // ExerciseCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderRadius = 10;
            Controls.Add(customCard1);
            Name = "ExerciseCard";
            Size = new Size(496, 264);
            customCard1.ResumeLayout(false);
            customCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CustomCard customCard1;
        private Label lbl_ExerciseModifiedUpdate;
        private Label lbl_ExerciseTitle;
        private GeneralComponents.SmartButton smartButton9;
        private GeneralComponents.SmartButton smartButton7;
        private Label subject;
        private Label dateModified;
        private Label testCounts;
        private Label label1;
    }
}
