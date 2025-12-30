namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    partial class SelectClass
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchBox = new CustomTextBox();
            holder = new Panel();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = SystemColors.Window;
            searchBox.BorderColor = Color.FromArgb(224, 224, 224);
            searchBox.BorderFocusColor = Color.Silver;
            searchBox.ForeColor = Color.DimGray;
            searchBox.Location = new Point(20, 22);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 7, 10, 7);
            searchBox.PlaceHolderColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search exercise";
            searchBox.ScrollBars = ScrollBars.None;
            searchBox.Size = new Size(285, 41);
            searchBox.TabIndex = 1;
            searchBox.UnderlinedStyle = true;
            searchBox._TextChanged += searchBox__TextChanged;
            // 
            // holder
            // 
            holder.AutoScroll = true;
            holder.BackColor = Color.Transparent;
            holder.Location = new Point(7, 96);
            holder.Name = "holder";
            holder.Size = new Size(454, 488);
            holder.TabIndex = 2;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(searchBox);
            steamGradientPanel1.Controls.Add(holder);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(469, 596);
            steamGradientPanel1.TabIndex = 3;
            // 
            // SelectExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 596);
            Controls.Add(steamGradientPanel1);
            Name = "SelectExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectExercise";
            steamGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomTextBox searchBox;
        private Panel holder;
        private SteamThings.SteamGradientPanel steamGradientPanel1;
    }
}