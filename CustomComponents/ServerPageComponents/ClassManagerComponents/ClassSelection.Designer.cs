namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    partial class ClassSelection
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
            studCount = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            subCode = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            subject = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamCard1 = new SmartCodeLab.CustomComponents.SteamThings.SteamCard();
            selected = new CheckBox();
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
            steamLabel1.Location = new Point(308, 9);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(109, 19);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Small;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 69;
            steamLabel1.Text = "Total Students";
            // 
            // studCount
            // 
            studCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studCount.AutoSize = true;
            studCount.BackColor = Color.Transparent;
            studCount.Font = new Font("Geist", 12F);
            studCount.ForeColor = Color.FromArgb(199, 213, 224);
            studCount.Location = new Point(396, 38);
            studCount.Name = "studCount";
            studCount.Size = new Size(21, 23);
            studCount.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            studCount.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            studCount.TabIndex = 70;
            studCount.Text = "0";
            // 
            // subCode
            // 
            subCode.AutoSize = true;
            subCode.BackColor = Color.Transparent;
            subCode.Font = new Font("Geist", 12F);
            subCode.ForeColor = Color.FromArgb(199, 213, 224);
            subCode.Location = new Point(12, 9);
            subCode.Name = "subCode";
            subCode.Size = new Size(157, 23);
            subCode.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            subCode.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            subCode.TabIndex = 71;
            subCode.Text = "Total Test Cases";
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
            steamCard1.Controls.Add(selected);
            steamCard1.Controls.Add(steamLabel1);
            steamCard1.Controls.Add(subject);
            steamCard1.Controls.Add(studCount);
            steamCard1.Controls.Add(subCode);
            steamCard1.Dock = DockStyle.Top;
            steamCard1.Location = new Point(0, 0);
            steamCard1.Name = "steamCard1";
            steamCard1.Padding = new Padding(20);
            steamCard1.Size = new Size(470, 72);
            steamCard1.TabIndex = 73;
            // 
            // selected
            // 
            selected.AutoSize = true;
            selected.Location = new Point(429, 9);
            selected.Name = "selected";
            selected.Size = new Size(18, 17);
            selected.TabIndex = 73;
            selected.UseVisualStyleBackColor = true;
            // 
            // ClassSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(steamCard1);
            Name = "ClassSelection";
            Size = new Size(470, 75);
            steamCard1.ResumeLayout(false);
            steamCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamLabel steamLabel1;
        private SteamThings.SteamLabel studCount;
        private SteamThings.SteamLabel subCode;
        private SteamThings.SteamLabel subject;
        private SteamThings.SteamCard steamCard1;
        private CheckBox selected;
    }
}
