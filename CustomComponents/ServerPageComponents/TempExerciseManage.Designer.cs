namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempExerciseManage
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
            panel3 = new Panel();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            btn_AddNewExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            flowLayoutPanel_Exercises = new FlowLayoutPanel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            subjects = new SmartCodeLab.CustomComponents.SteamThings.SteamComboBox();
            customTextBox1 = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            panel3.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(steamLabel3);
            panel3.Controls.Add(btn_AddNewExercise);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1801, 82);
            panel3.TabIndex = 55;
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
            btn_AddNewExercise.Location = new Point(1390, 15);
            btn_AddNewExercise.Margin = new Padding(2, 4, 2, 4);
            btn_AddNewExercise.Name = "btn_AddNewExercise";
            btn_AddNewExercise.Size = new Size(213, 52);
            btn_AddNewExercise.TabIndex = 66;
            btn_AddNewExercise.Text = "ADD NEW EXERCISE";
            btn_AddNewExercise.TextColor = Color.FromArgb(199, 213, 224);
            btn_AddNewExercise.UseVisualStyleBackColor = false;
            btn_AddNewExercise.Click += btn_AddNewExercise_Click_1;
            // 
            // flowLayoutPanel_Exercises
            // 
            flowLayoutPanel_Exercises.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel_Exercises.AutoScroll = true;
            flowLayoutPanel_Exercises.BackColor = Color.Transparent;
            flowLayoutPanel_Exercises.Location = new Point(349, 221);
            flowLayoutPanel_Exercises.Name = "flowLayoutPanel_Exercises";
            flowLayoutPanel_Exercises.Padding = new Padding(0, 0, 0, 100);
            flowLayoutPanel_Exercises.Size = new Size(1217, 629);
            flowLayoutPanel_Exercises.TabIndex = 59;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(subjects);
            steamGradientPanel1.Controls.Add(customTextBox1);
            steamGradientPanel1.Controls.Add(flowLayoutPanel_Exercises);
            steamGradientPanel1.Controls.Add(panel3);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1801, 1049);
            steamGradientPanel1.TabIndex = 66;
            // 
            // subjects
            // 
            subjects.BackColor = Color.FromArgb(26, 30, 36);
            subjects.Items.AddRange(new object[] { "All" });
            subjects.Location = new Point(715, 145);
            subjects.Name = "subjects";
            subjects.Padding = new Padding(1);
            subjects.Size = new Size(174, 44);
            subjects.TabIndex = 67;
            subjects.SelectedIndexChanged += subjects_SelectedIndexChanged;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.FromArgb(26, 30, 36);
            customTextBox1.Location = new Point(349, 145);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 8, 10, 8);
            customTextBox1.PlaceholderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "Search exercise";
            customTextBox1.Size = new Size(331, 44);
            customTextBox1.TabIndex = 66;
            // 
            // TempExerciseManage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(steamGradientPanel1);
            DoubleBuffered = true;
            Name = "TempExerciseManage";
            Size = new Size(1801, 1049);
            Load += TempExerciseManage_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            steamGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private GeneralComponents.SmartButton btn_AddNewExercise;
        private FlowLayoutPanel flowLayoutPanel_Exercises;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamTextBox customTextBox1;
        private SteamThings.SteamComboBox subjects;
    }
}
