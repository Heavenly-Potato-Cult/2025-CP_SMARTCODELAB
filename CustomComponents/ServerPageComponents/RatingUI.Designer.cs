namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class RatingUI
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
            steamTrackBar1 = new SmartCodeLab.CustomComponents.SteamThings.SteamTrackBar();
            name = new Label();
            score = new Label();
            SuspendLayout();
            // 
            // steamTrackBar1
            // 
            steamTrackBar1.BackColor = Color.Transparent;
            steamTrackBar1.Location = new Point(0, 17);
            steamTrackBar1.Maximum = 100;
            steamTrackBar1.Name = "steamTrackBar1";
            steamTrackBar1.Size = new Size(423, 16);
            steamTrackBar1.TabIndex = 0;
            steamTrackBar1.Text = "steamTrackBar1";
            steamTrackBar1.Value = 0;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.White;
            name.Location = new Point(3, 0);
            name.Name = "name";
            name.Size = new Size(51, 20);
            name.TabIndex = 3;
            name.Text = "label1";
            // 
            // score
            // 
            score.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            score.AutoSize = true;
            score.ForeColor = Color.White;
            score.ImageAlign = ContentAlignment.MiddleRight;
            score.Location = new Point(373, 0);
            score.Name = "score";
            score.Size = new Size(50, 20);
            score.TabIndex = 4;
            score.Text = "label2";
            // 
            // RatingUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(score);
            Controls.Add(name);
            Controls.Add(steamTrackBar1);
            Name = "RatingUI";
            Size = new Size(426, 36);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SteamThings.SteamTrackBar steamTrackBar1;
        private Label name;
        private Label score;
    }
}
