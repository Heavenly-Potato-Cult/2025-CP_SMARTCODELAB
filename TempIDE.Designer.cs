namespace SmartCodeLab
{
    partial class TempIDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempIDE));
            studentIdentity = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            panel_Main = new Panel();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            btn_test = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_submit = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            btn_run = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            tabControl_RightSide = new TabControl();
            ActivityTab = new TabPage();
            ActivityPanel = new Panel();
            activity_expansion_panel = new SmartCodeLab.CustomComponents.ExpansionPanel();
            description = new TextBox();
            MessagesTab = new TabPage();
            richTextBox2 = new RichTextBox();
            msgBox = new RichTextBox();
            Leaderboards = new TabPage();
            panel_leaderboards = new Panel();
            Score = new TabPage();
            expansion_expansion_panel = new MaterialSkin.Controls.MaterialExpansionPanel();
            studentCodeRating = new SmartCodeLab.CustomComponents.ServerPageComponents.StudentCodeRating();
            steamGradientPanel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamGradientPanel();
            steamCard1 = new SmartCodeLab.CustomComponents.SteamThings.SteamCard();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            customCard2.SuspendLayout();
            tabControl_RightSide.SuspendLayout();
            ActivityTab.SuspendLayout();
            ActivityPanel.SuspendLayout();
            activity_expansion_panel.SuspendLayout();
            MessagesTab.SuspendLayout();
            Leaderboards.SuspendLayout();
            Score.SuspendLayout();
            expansion_expansion_panel.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            steamCard1.SuspendLayout();
            SuspendLayout();
            // 
            // studentIdentity
            // 
            studentIdentity.AutoSize = true;
            studentIdentity.BackColor = Color.Transparent;
            studentIdentity.Font = new Font("Geist", 12F);
            studentIdentity.ForeColor = Color.FromArgb(139, 149, 166);
            studentIdentity.Location = new Point(100, 41);
            studentIdentity.Name = "studentIdentity";
            studentIdentity.Size = new Size(309, 23);
            studentIdentity.SteamSize = CustomComponents.SteamThings.SteamLabel.SizeOption.Regular;
            studentIdentity.SteamTheme = CustomComponents.SteamThings.SteamLabel.ThemeOption.Muted;
            studentIdentity.TabIndex = 19;
            studentIdentity.Text = "Jimmuel Sanggayan | 2022-00842";
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(100, 9);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(211, 32);
            steamLabel1.SteamSize = CustomComponents.SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = CustomComponents.SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 18;
            steamLabel1.Text = "SmartCodeLab";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1486, 24);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 17;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 63);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 80);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel_Main);
            splitContainer1.Panel1.Controls.Add(customCard2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl_RightSide);
            splitContainer1.Size = new Size(1602, 936);
            splitContainer1.SplitterDistance = 1231;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 71, 94);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 1);
            panel1.TabIndex = 0;
            // 
            // panel_Main
            // 
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.Location = new Point(0, 54);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1231, 882);
            panel_Main.TabIndex = 20;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.FromArgb(21, 28, 38);
            customCard2.BorderColor = Color.FromArgb(42, 71, 94);
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 0;
            customCard2.Controls.Add(steamLabel2);
            customCard2.Controls.Add(btn_test);
            customCard2.Controls.Add(btn_submit);
            customCard2.Controls.Add(btn_run);
            customCard2.Dock = DockStyle.Top;
            customCard2.Location = new Point(0, 0);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(1231, 54);
            customCard2.TabIndex = 22;
            // 
            // btn_test
            // 
            btn_test.BackColor = Color.FromArgb(42, 71, 94);
            btn_test.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_test.BorderRadius = 1;
            btn_test.FlatAppearance.BorderSize = 0;
            btn_test.FlatStyle = FlatStyle.Flat;
            btn_test.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_test.ForeColor = Color.FromArgb(199, 213, 224);
            btn_test.Location = new Point(241, 11);
            btn_test.Margin = new Padding(2, 4, 2, 4);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(89, 32);
            btn_test.TabIndex = 37;
            btn_test.Text = "Test";
            btn_test.TextColor = Color.FromArgb(199, 213, 224);
            btn_test.UseVisualStyleBackColor = false;
            btn_test.Click += btn_test_Click;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.FromArgb(42, 71, 94);
            btn_submit.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_submit.BorderRadius = 1;
            btn_submit.FlatAppearance.BorderSize = 0;
            btn_submit.FlatStyle = FlatStyle.Flat;
            btn_submit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submit.ForeColor = Color.FromArgb(199, 213, 224);
            btn_submit.Location = new Point(132, 11);
            btn_submit.Margin = new Padding(2, 4, 2, 4);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(89, 32);
            btn_submit.TabIndex = 36;
            btn_submit.Text = "Submit";
            btn_submit.TextColor = Color.FromArgb(199, 213, 224);
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_run
            // 
            btn_run.BackColor = Color.FromArgb(42, 71, 94);
            btn_run.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_run.BorderRadius = 1;
            btn_run.FlatAppearance.BorderSize = 0;
            btn_run.FlatStyle = FlatStyle.Flat;
            btn_run.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_run.ForeColor = Color.FromArgb(199, 213, 224);
            btn_run.Location = new Point(23, 11);
            btn_run.Margin = new Padding(2, 4, 2, 4);
            btn_run.Name = "btn_run";
            btn_run.Size = new Size(89, 32);
            btn_run.TabIndex = 35;
            btn_run.Text = "Run Code";
            btn_run.TextColor = Color.FromArgb(199, 213, 224);
            btn_run.UseVisualStyleBackColor = false;
            btn_run.Click += btn_run_Click;
            // 
            // tabControl_RightSide
            // 
            tabControl_RightSide.Alignment = TabAlignment.Right;
            tabControl_RightSide.Controls.Add(ActivityTab);
            tabControl_RightSide.Controls.Add(MessagesTab);
            tabControl_RightSide.Controls.Add(Leaderboards);
            tabControl_RightSide.Controls.Add(Score);
            tabControl_RightSide.Dock = DockStyle.Fill;
            tabControl_RightSide.Location = new Point(0, 0);
            tabControl_RightSide.Multiline = true;
            tabControl_RightSide.Name = "tabControl_RightSide";
            tabControl_RightSide.SelectedIndex = 0;
            tabControl_RightSide.Size = new Size(366, 936);
            tabControl_RightSide.SizeMode = TabSizeMode.Fixed;
            tabControl_RightSide.TabIndex = 9;
            tabControl_RightSide.Resize += tabControl_RightSide_Resize;
            // 
            // ActivityTab
            // 
            ActivityTab.Controls.Add(ActivityPanel);
            ActivityTab.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActivityTab.Location = new Point(4, 4);
            ActivityTab.Name = "ActivityTab";
            ActivityTab.Size = new Size(332, 928);
            ActivityTab.TabIndex = 2;
            ActivityTab.Text = "Activity";
            ActivityTab.UseVisualStyleBackColor = true;
            // 
            // ActivityPanel
            // 
            ActivityPanel.Controls.Add(activity_expansion_panel);
            ActivityPanel.Dock = DockStyle.Fill;
            ActivityPanel.Location = new Point(0, 0);
            ActivityPanel.Margin = new Padding(3, 4, 3, 4);
            ActivityPanel.Name = "ActivityPanel";
            ActivityPanel.Size = new Size(332, 928);
            ActivityPanel.TabIndex = 0;
            // 
            // activity_expansion_panel
            // 
            activity_expansion_panel.Controls.Add(description);
            activity_expansion_panel.Dock = DockStyle.Top;
            activity_expansion_panel.HeaderColor = Color.White;
            activity_expansion_panel.HeaderHeight = 64;
            activity_expansion_panel.IconText = "v";
            activity_expansion_panel.Location = new Point(0, 0);
            activity_expansion_panel.Margin = new Padding(3, 4, 3, 4);
            activity_expansion_panel.Name = "activity_expansion_panel";
            activity_expansion_panel.Size = new Size(332, 248);
            activity_expansion_panel.TabIndex = 18;
            activity_expansion_panel.Title1 = "ActivityName";
            activity_expansion_panel.Title2 = "";
            // 
            // description
            // 
            description.Dock = DockStyle.Bottom;
            description.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.Location = new Point(0, 66);
            description.Multiline = true;
            description.Name = "description";
            description.ReadOnly = true;
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(332, 182);
            description.TabIndex = 76;
            // 
            // MessagesTab
            // 
            MessagesTab.Controls.Add(richTextBox2);
            MessagesTab.Controls.Add(msgBox);
            MessagesTab.Location = new Point(4, 4);
            MessagesTab.Name = "MessagesTab";
            MessagesTab.Padding = new Padding(3);
            MessagesTab.Size = new Size(332, 928);
            MessagesTab.TabIndex = 1;
            MessagesTab.Text = "Messages";
            MessagesTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Dock = DockStyle.Top;
            richTextBox2.Location = new Point(3, 528);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(326, 104);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            richTextBox2.KeyUp += richTextBox2_KeyUp;
            // 
            // msgBox
            // 
            msgBox.BorderStyle = BorderStyle.FixedSingle;
            msgBox.Dock = DockStyle.Top;
            msgBox.Location = new Point(3, 3);
            msgBox.Name = "msgBox";
            msgBox.ReadOnly = true;
            msgBox.Size = new Size(326, 525);
            msgBox.TabIndex = 0;
            msgBox.Text = "";
            // 
            // Leaderboards
            // 
            Leaderboards.Controls.Add(panel_leaderboards);
            Leaderboards.Location = new Point(4, 4);
            Leaderboards.Name = "Leaderboards";
            Leaderboards.Padding = new Padding(3);
            Leaderboards.Size = new Size(461, 928);
            Leaderboards.TabIndex = 0;
            Leaderboards.Text = "Leaderboards";
            Leaderboards.UseVisualStyleBackColor = true;
            // 
            // panel_leaderboards
            // 
            panel_leaderboards.AutoScroll = true;
            panel_leaderboards.Dock = DockStyle.Fill;
            panel_leaderboards.Location = new Point(3, 3);
            panel_leaderboards.Margin = new Padding(3, 4, 3, 4);
            panel_leaderboards.Name = "panel_leaderboards";
            panel_leaderboards.Padding = new Padding(0, 27, 0, 0);
            panel_leaderboards.Size = new Size(455, 922);
            panel_leaderboards.TabIndex = 18;
            // 
            // Score
            // 
            Score.Controls.Add(expansion_expansion_panel);
            Score.Location = new Point(4, 4);
            Score.Margin = new Padding(3, 4, 3, 4);
            Score.Name = "Score";
            Score.Size = new Size(461, 928);
            Score.TabIndex = 3;
            Score.Text = "Score";
            Score.UseVisualStyleBackColor = true;
            // 
            // expansion_expansion_panel
            // 
            expansion_expansion_panel.BackColor = Color.FromArgb(255, 255, 255);
            expansion_expansion_panel.BorderStyle = BorderStyle.FixedSingle;
            expansion_expansion_panel.CancelButtonText = "";
            expansion_expansion_panel.Controls.Add(studentCodeRating);
            expansion_expansion_panel.Depth = 0;
            expansion_expansion_panel.Description = "";
            expansion_expansion_panel.Dock = DockStyle.Top;
            expansion_expansion_panel.ExpandHeight = 403;
            expansion_expansion_panel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            expansion_expansion_panel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            expansion_expansion_panel.Location = new Point(0, 0);
            expansion_expansion_panel.Margin = new Padding(3, 21, 3, 21);
            expansion_expansion_panel.MouseState = MaterialSkin.MouseState.HOVER;
            expansion_expansion_panel.Name = "expansion_expansion_panel";
            expansion_expansion_panel.Padding = new Padding(27, 85, 27, 21);
            expansion_expansion_panel.Size = new Size(461, 403);
            expansion_expansion_panel.TabIndex = 81;
            expansion_expansion_panel.Title = "Scores";
            expansion_expansion_panel.ValidationButtonText = " ";
            // 
            // studentCodeRating
            // 
            studentCodeRating.BackColor = Color.White;
            studentCodeRating.Dock = DockStyle.Fill;
            studentCodeRating.Location = new Point(27, 85);
            studentCodeRating.Name = "studentCodeRating";
            studentCodeRating.Size = new Size(405, 295);
            studentCodeRating.TabIndex = 79;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(splitContainer1);
            steamGradientPanel1.Controls.Add(steamCard1);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1602, 1016);
            steamGradientPanel1.TabIndex = 11;
            // 
            // steamCard1
            // 
            steamCard1.BackColor = Color.Transparent;
            steamCard1.Controls.Add(button1);
            steamCard1.Controls.Add(studentIdentity);
            steamCard1.Controls.Add(pictureBox1);
            steamCard1.Controls.Add(steamLabel1);
            steamCard1.Dock = DockStyle.Top;
            steamCard1.Location = new Point(0, 0);
            steamCard1.Name = "steamCard1";
            steamCard1.Padding = new Padding(20);
            steamCard1.Size = new Size(1602, 80);
            steamCard1.TabIndex = 11;
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.FromArgb(29, 7, 18);
            steamLabel2.Font = new Font("Geist", 8F);
            steamLabel2.ForeColor = Color.FromArgb(255, 77, 77);
            steamLabel2.Location = new Point(1101, 9);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Padding = new Padding(10);
            steamLabel2.Size = new Size(122, 36);
            steamLabel2.SteamSize = CustomComponents.SteamThings.SteamLabel.SizeOption.Tiny;
            steamLabel2.SteamTheme = CustomComponents.SteamThings.SteamLabel.ThemeOption.Error;
            steamLabel2.TabIndex = 20;
            steamLabel2.Text = "Being Watched";
            // 
            // TempIDE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1602, 1016);
            Controls.Add(steamGradientPanel1);
            DoubleBuffered = true;
            Name = "TempIDE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TempIDE";
            WindowState = FormWindowState.Maximized;
            FormClosing += TempIDE_FormClosing;
            Shown += TempIDE_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            customCard2.PerformLayout();
            tabControl_RightSide.ResumeLayout(false);
            ActivityTab.ResumeLayout(false);
            ActivityPanel.ResumeLayout(false);
            activity_expansion_panel.ResumeLayout(false);
            activity_expansion_panel.PerformLayout();
            MessagesTab.ResumeLayout(false);
            Leaderboards.ResumeLayout(false);
            Score.ResumeLayout(false);
            expansion_expansion_panel.ResumeLayout(false);
            expansion_expansion_panel.PerformLayout();
            steamGradientPanel1.ResumeLayout(false);
            steamCard1.ResumeLayout(false);
            steamCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private SplitContainer splitContainer1;
        private Panel panel_Main;
        private TabControl tabControl_RightSide;
        private TabPage ActivityTab;
        private Panel ActivityPanel;
        private CustomComponents.ExpansionPanel activity_expansion_panel;
        private TextBox description;
        private TabPage MessagesTab;
        private RichTextBox richTextBox2;
        private RichTextBox msgBox;
        private TabPage Leaderboards;
        private Panel panel_leaderboards;
        private TabPage Score;
        private MaterialSkin.Controls.MaterialExpansionPanel expansion_expansion_panel;
        private CustomComponents.ServerPageComponents.StudentCodeRating studentCodeRating;
        private CustomComponents.SteamThings.SteamGradientPanel steamGradientPanel1;
        private CustomComponents.SteamThings.SteamLabel steamLabel1;
        private CustomComponents.SteamThings.SteamLabel studentIdentity;
        private CustomComponents.SteamThings.SteamCard steamCard1;
        private CustomComponents.GeneralComponents.CustomCard customCard1;
        private CustomComponents.GeneralComponents.CustomCard customCard2;
        private CustomComponents.GeneralComponents.SmartButton btn_test;
        private CustomComponents.GeneralComponents.SmartButton btn_submit;
        private CustomComponents.GeneralComponents.SmartButton btn_run;
        private Panel panel1;
        private CustomComponents.SteamThings.SteamLabel steamLabel2;
    }
}