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
            lbl_ExerciseYearAndSection = new Label();
            lbl_ExerciseModifiedUpdate = new Label();
            lbl_ExerciseTotalLinkedClass = new Label();
            lbl_ExerciseCourse = new Label();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            lbl_ExerciseLanguange = new Label();
            lbl_ExerciseTitle = new Label();
            smartButton9 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton8 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton7 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard1.SuspendLayout();
            customCard2.SuspendLayout();
            SuspendLayout();
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.White;
            customCard1.BorderColor = Color.Silver;
            customCard1.BorderRadius = 10;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(lbl_ExerciseYearAndSection);
            customCard1.Controls.Add(lbl_ExerciseModifiedUpdate);
            customCard1.Controls.Add(lbl_ExerciseTotalLinkedClass);
            customCard1.Controls.Add(lbl_ExerciseCourse);
            customCard1.Controls.Add(customCard2);
            customCard1.Controls.Add(lbl_ExerciseTitle);
            customCard1.Controls.Add(smartButton9);
            customCard1.Controls.Add(smartButton8);
            customCard1.Controls.Add(smartButton7);
            customCard1.Location = new Point(0, 0);
            customCard1.Margin = new Padding(3, 3, 30, 20);
            customCard1.Name = "customCard1";
            customCard1.Size = new Size(496, 264);
            customCard1.TabIndex = 1;
            // 
            // lbl_ExerciseYearAndSection
            // 
            lbl_ExerciseYearAndSection.AutoSize = true;
            lbl_ExerciseYearAndSection.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseYearAndSection.ForeColor = Color.Black;
            lbl_ExerciseYearAndSection.Location = new Point(60, 76);
            lbl_ExerciseYearAndSection.Name = "lbl_ExerciseYearAndSection";
            lbl_ExerciseYearAndSection.Size = new Size(34, 25);
            lbl_ExerciseYearAndSection.TabIndex = 63;
            lbl_ExerciseYearAndSection.Text = "4A";
            // 
            // lbl_ExerciseModifiedUpdate
            // 
            lbl_ExerciseModifiedUpdate.AutoSize = true;
            lbl_ExerciseModifiedUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseModifiedUpdate.ForeColor = Color.DimGray;
            lbl_ExerciseModifiedUpdate.Location = new Point(338, 127);
            lbl_ExerciseModifiedUpdate.Name = "lbl_ExerciseModifiedUpdate";
            lbl_ExerciseModifiedUpdate.Size = new Size(135, 25);
            lbl_ExerciseModifiedUpdate.TabIndex = 24;
            lbl_ExerciseModifiedUpdate.Text = "Modified today";
            // 
            // lbl_ExerciseTotalLinkedClass
            // 
            lbl_ExerciseTotalLinkedClass.AutoSize = true;
            lbl_ExerciseTotalLinkedClass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseTotalLinkedClass.ForeColor = Color.DimGray;
            lbl_ExerciseTotalLinkedClass.Location = new Point(18, 127);
            lbl_ExerciseTotalLinkedClass.Name = "lbl_ExerciseTotalLinkedClass";
            lbl_ExerciseTotalLinkedClass.Size = new Size(142, 25);
            lbl_ExerciseTotalLinkedClass.TabIndex = 23;
            lbl_ExerciseTotalLinkedClass.Text = "Linked to 1 class";
            // 
            // lbl_ExerciseCourse
            // 
            lbl_ExerciseCourse.AutoSize = true;
            lbl_ExerciseCourse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseCourse.ForeColor = Color.Black;
            lbl_ExerciseCourse.Location = new Point(18, 76);
            lbl_ExerciseCourse.Name = "lbl_ExerciseCourse";
            lbl_ExerciseCourse.Size = new Size(46, 25);
            lbl_ExerciseCourse.TabIndex = 22;
            lbl_ExerciseCourse.Text = "BSIT";
            // 
            // customCard2
            // 
            customCard2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customCard2.BackColor = Color.FromArgb(192, 255, 192);
            customCard2.BorderColor = Color.Gray;
            customCard2.BorderRadius = 15;
            customCard2.BorderSize = 0;
            customCard2.Controls.Add(lbl_ExerciseLanguange);
            customCard2.Location = new Point(386, 35);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(87, 31);
            customCard2.TabIndex = 21;
            // 
            // lbl_ExerciseLanguange
            // 
            lbl_ExerciseLanguange.AutoSize = true;
            lbl_ExerciseLanguange.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ExerciseLanguange.ForeColor = Color.Green;
            lbl_ExerciseLanguange.Location = new Point(11, 2);
            lbl_ExerciseLanguange.Name = "lbl_ExerciseLanguange";
            lbl_ExerciseLanguange.Size = new Size(68, 25);
            lbl_ExerciseLanguange.TabIndex = 21;
            lbl_ExerciseLanguange.Text = "Python";
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
            smartButton9.Location = new Point(409, 194);
            smartButton9.Margin = new Padding(3, 4, 3, 4);
            smartButton9.Name = "smartButton9";
            smartButton9.Size = new Size(64, 52);
            smartButton9.TabIndex = 62;
            smartButton9.TextColor = Color.DimGray;
            smartButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton9.UseVisualStyleBackColor = false;
            // 
            // smartButton8
            // 
            smartButton8.Anchor = AnchorStyles.None;
            smartButton8.BackColor = Color.WhiteSmoke;
            smartButton8.BackgroundColor = Color.WhiteSmoke;
            smartButton8.BorderRadius = 10;
            smartButton8.FlatAppearance.BorderSize = 0;
            smartButton8.FlatStyle = FlatStyle.Flat;
            smartButton8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton8.ForeColor = Color.DimGray;
            smartButton8.Location = new Point(278, 194);
            smartButton8.Margin = new Padding(3, 4, 3, 4);
            smartButton8.Name = "smartButton8";
            smartButton8.Size = new Size(127, 52);
            smartButton8.TabIndex = 61;
            smartButton8.Text = "Link";
            smartButton8.TextColor = Color.DimGray;
            smartButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton8.UseVisualStyleBackColor = false;
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
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GeneralComponents.CustomCard customCard1;
        private Label lbl_ExerciseModifiedUpdate;
        private Label lbl_ExerciseTotalLinkedClass;
        private Label lbl_ExerciseCourse;
        private GeneralComponents.CustomCard customCard2;
        private Label lbl_ExerciseLanguange;
        private Label lbl_ExerciseTitle;
        private GeneralComponents.SmartButton smartButton9;
        private GeneralComponents.SmartButton smartButton8;
        private GeneralComponents.SmartButton smartButton7;
        private Label lbl_ExerciseYearAndSection;
    }
}
