namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class ExerciseSelection
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
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            testCounts = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            taskName = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            subject = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamCard1 = new SmartCodeLab.CustomComponents.SteamThings.SteamCard();
            steamCard1.SuspendLayout();
            SuspendLayout();
            // 
            // steamLabel1
            // 
            steamLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 10F);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(336, 9);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(125, 19);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 69;
            steamLabel1.Text = "Total Test Cases";
            // 
            // testCounts
            // 
            testCounts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            testCounts.AutoSize = true;
            testCounts.BackColor = Color.Transparent;
            testCounts.Font = new Font("Geist", 12F);
            testCounts.ForeColor = Color.FromArgb(199, 213, 224);
            testCounts.Location = new Point(411, 38);
            testCounts.Name = "testCounts";
            testCounts.Size = new Size(21, 23);
            testCounts.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            testCounts.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            testCounts.TabIndex = 70;
            testCounts.Text = "0";
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.BackColor = Color.Transparent;
            taskName.Font = new Font("Geist", 12F);
            taskName.ForeColor = Color.FromArgb(199, 213, 224);
            taskName.Location = new Point(12, 9);
            taskName.Name = "taskName";
            taskName.Size = new Size(157, 23);
            taskName.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            taskName.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            taskName.TabIndex = 71;
            taskName.Text = "Total Test Cases";
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.BackColor = Color.Transparent;
            subject.Font = new Font("Geist", 10F);
            subject.ForeColor = Color.FromArgb(199, 213, 224);
            subject.Location = new Point(12, 42);
            subject.Name = "subject";
            subject.Size = new Size(63, 19);
            subject.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            subject.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            subject.TabIndex = 72;
            subject.Text = "Subject";
            // 
            // steamCard1
            // 
            steamCard1.BackColor = Color.Transparent;
            steamCard1.Controls.Add(steamLabel1);
            steamCard1.Controls.Add(subject);
            steamCard1.Controls.Add(testCounts);
            steamCard1.Controls.Add(taskName);
            steamCard1.Dock = DockStyle.Top;
            steamCard1.Location = new Point(0, 0);
            steamCard1.Name = "steamCard1";
            steamCard1.Padding = new Padding(20);
            steamCard1.Size = new Size(470, 72);
            steamCard1.TabIndex = 73;
            // 
            // ExerciseSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(steamCard1);
            Name = "ExerciseSelection";
            Size = new Size(470, 75);
            steamCard1.ResumeLayout(false);
            steamCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamLabel testCounts;
        private SteamThings.SteamLabel taskName;
        private SteamThings.SteamLabel subject;
        private SteamThings.SteamCard steamCard1;
    }
}
