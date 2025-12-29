namespace SmartCodeLab.CustomComponents.Pages
{
    partial class ClassManagement
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
            search = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            classesContainer = new FlowLayoutPanel();
            btn_AddNewExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panel3 = new Panel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(26, 30, 36);
            search.Location = new Point(292, 172);
            search.Name = "search";
            search.Padding = new Padding(10, 8, 10, 8);
            search.PlaceholderText = "Search Class";
            search.Size = new Size(331, 44);
            search.TabIndex = 69;
            // 
            // classesContainer
            // 
            classesContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            classesContainer.AutoScroll = true;
            classesContainer.BackColor = Color.Transparent;
            classesContainer.Location = new Point(292, 248);
            classesContainer.Name = "classesContainer";
            classesContainer.Padding = new Padding(0, 0, 0, 100);
            classesContainer.Size = new Size(1217, 629);
            classesContainer.TabIndex = 68;
            // 
            // btn_AddNewExercise
            // 
            btn_AddNewExercise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddNewExercise.BackColor = Color.FromArgb(42, 71, 94);
            btn_AddNewExercise.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_AddNewExercise.BorderRadius = 1;
            btn_AddNewExercise.FlatAppearance.BorderSize = 0;
            btn_AddNewExercise.FlatStyle = FlatStyle.Flat;
            btn_AddNewExercise.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddNewExercise.ForeColor = Color.FromArgb(199, 213, 224);
            btn_AddNewExercise.Location = new Point(2991, 15);
            btn_AddNewExercise.Margin = new Padding(2, 4, 2, 4);
            btn_AddNewExercise.Name = "btn_AddNewExercise";
            btn_AddNewExercise.Size = new Size(213, 52);
            btn_AddNewExercise.TabIndex = 66;
            btn_AddNewExercise.Text = "ADD NEW EXERCISE";
            btn_AddNewExercise.TextColor = Color.FromArgb(199, 213, 224);
            btn_AddNewExercise.UseVisualStyleBackColor = false;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel3.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel3.Location = new Point(349, 25);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(310, 32);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel3.TabIndex = 66;
            steamLabel3.Text = "EXERCISE EXPLORER";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(smartButton1);
            panel3.Controls.Add(steamLabel3);
            panel3.Controls.Add(btn_AddNewExercise);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1801, 82);
            panel3.TabIndex = 70;
            // 
            // smartButton1
            // 
            smartButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton1.BackColor = Color.FromArgb(42, 71, 94);
            smartButton1.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton1.BorderRadius = 1;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton1.Location = new Point(1296, 18);
            smartButton1.Margin = new Padding(2, 4, 2, 4);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(213, 52);
            smartButton1.TabIndex = 67;
            smartButton1.Text = "ADD NEW EXERCISE";
            smartButton1.TextColor = Color.FromArgb(199, 213, 224);
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel3);
            Controls.Add(search);
            Controls.Add(classesContainer);
            Name = "ClassManagement";
            Size = new Size(1801, 1049);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SteamThings.SteamTextBox search;
        private FlowLayoutPanel classesContainer;
        private GeneralComponents.SmartButton btn_AddNewExercise;
        private SteamThings.SteamLabel steamLabel3;
        private Panel panel3;
        private GeneralComponents.SmartButton smartButton1;
    }
}
