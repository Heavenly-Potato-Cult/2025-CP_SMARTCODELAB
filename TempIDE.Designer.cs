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
            headerPanel = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel_MiddlePart_Main = new Panel();
            customTabControl1 = new SmartCodeLab.CustomComponents.WPFComponents.CustomTabControl();
            panel1 = new Panel();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
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
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            studentIdentity = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel_MiddlePart_Main.SuspendLayout();
            panel1.SuspendLayout();
            tabControl_RightSide.SuspendLayout();
            ActivityTab.SuspendLayout();
            ActivityPanel.SuspendLayout();
            activity_expansion_panel.SuspendLayout();
            MessagesTab.SuspendLayout();
            Leaderboards.SuspendLayout();
            Score.SuspendLayout();
            expansion_expansion_panel.SuspendLayout();
            steamGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(studentIdentity);
            headerPanel.Controls.Add(steamLabel1);
            headerPanel.Controls.Add(button1);
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1602, 80);
            headerPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1516, 0);
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
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 80);
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
            splitContainer1.Panel1.Controls.Add(panel_MiddlePart_Main);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl_RightSide);
            splitContainer1.Size = new Size(1602, 936);
            splitContainer1.SplitterDistance = 1102;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 10;
            // 
            // panel_MiddlePart_Main
            // 
            panel_MiddlePart_Main.Controls.Add(customTabControl1);
            panel_MiddlePart_Main.Controls.Add(panel1);
            panel_MiddlePart_Main.Dock = DockStyle.Fill;
            panel_MiddlePart_Main.Location = new Point(0, 0);
            panel_MiddlePart_Main.Name = "panel_MiddlePart_Main";
            panel_MiddlePart_Main.Size = new Size(1102, 936);
            panel_MiddlePart_Main.TabIndex = 20;
            // 
            // customTabControl1
            // 
            customTabControl1.Dock = DockStyle.Fill;
            customTabControl1.Location = new Point(0, 61);
            customTabControl1.Name = "customTabControl1";
            customTabControl1.Size = new Size(1102, 875);
            customTabControl1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(smartButton3);
            panel1.Controls.Add(smartButton1);
            panel1.Controls.Add(smartButton2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 61);
            panel1.TabIndex = 9;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.Gray;
            smartButton3.BackgroundColor = Color.Gray;
            smartButton3.BorderRadius = 10;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            smartButton3.ForeColor = Color.Transparent;
            smartButton3.Image = (Image)resources.GetObject("smartButton3.Image");
            smartButton3.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton3.Location = new Point(277, 11);
            smartButton3.Name = "smartButton3";
            smartButton3.Padding = new Padding(21, 0, 0, 0);
            smartButton3.Size = new Size(107, 39);
            smartButton3.TabIndex = 5;
            smartButton3.Text = " Test";
            smartButton3.TextColor = Color.Transparent;
            smartButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.LimeGreen;
            smartButton1.BackgroundColor = Color.LimeGreen;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Image = (Image)resources.GetObject("smartButton1.Image");
            smartButton1.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton1.Location = new Point(13, 11);
            smartButton1.Name = "smartButton1";
            smartButton1.Padding = new Padding(10, 0, 0, 0);
            smartButton1.Size = new Size(118, 39);
            smartButton1.TabIndex = 3;
            smartButton1.Text = "Run Code";
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.DodgerBlue;
            smartButton2.BackgroundColor = Color.DodgerBlue;
            smartButton2.BorderRadius = 10;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Image = (Image)resources.GetObject("smartButton2.Image");
            smartButton2.ImageAlign = ContentAlignment.MiddleLeft;
            smartButton2.Location = new Point(149, 11);
            smartButton2.Name = "smartButton2";
            smartButton2.Padding = new Padding(10, 0, 0, 0);
            smartButton2.Size = new Size(107, 39);
            smartButton2.TabIndex = 4;
            smartButton2.Text = " Submit";
            smartButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // tabControl_RightSide
            // 
            tabControl_RightSide.Controls.Add(ActivityTab);
            tabControl_RightSide.Controls.Add(MessagesTab);
            tabControl_RightSide.Controls.Add(Leaderboards);
            tabControl_RightSide.Controls.Add(Score);
            tabControl_RightSide.Dock = DockStyle.Fill;
            tabControl_RightSide.Location = new Point(0, 0);
            tabControl_RightSide.Multiline = true;
            tabControl_RightSide.Name = "tabControl_RightSide";
            tabControl_RightSide.SelectedIndex = 0;
            tabControl_RightSide.Size = new Size(495, 936);
            tabControl_RightSide.SizeMode = TabSizeMode.Fixed;
            tabControl_RightSide.TabIndex = 9;
            tabControl_RightSide.Resize += tabControl_RightSide_Resize;
            // 
            // ActivityTab
            // 
            ActivityTab.Controls.Add(ActivityPanel);
            ActivityTab.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActivityTab.Location = new Point(4, 29);
            ActivityTab.Name = "ActivityTab";
            ActivityTab.Size = new Size(487, 903);
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
            ActivityPanel.Size = new Size(487, 903);
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
            activity_expansion_panel.Size = new Size(487, 248);
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
            description.Size = new Size(487, 182);
            description.TabIndex = 76;
            // 
            // MessagesTab
            // 
            MessagesTab.Controls.Add(richTextBox2);
            MessagesTab.Controls.Add(msgBox);
            MessagesTab.Location = new Point(4, 29);
            MessagesTab.Name = "MessagesTab";
            MessagesTab.Padding = new Padding(3);
            MessagesTab.Size = new Size(487, 901);
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
            richTextBox2.Size = new Size(481, 104);
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
            msgBox.Size = new Size(481, 525);
            msgBox.TabIndex = 0;
            msgBox.Text = "";
            // 
            // Leaderboards
            // 
            Leaderboards.Controls.Add(panel_leaderboards);
            Leaderboards.Location = new Point(4, 29);
            Leaderboards.Name = "Leaderboards";
            Leaderboards.Padding = new Padding(3);
            Leaderboards.Size = new Size(487, 901);
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
            panel_leaderboards.Size = new Size(481, 895);
            panel_leaderboards.TabIndex = 18;
            // 
            // Score
            // 
            Score.Controls.Add(expansion_expansion_panel);
            Score.Location = new Point(4, 29);
            Score.Margin = new Padding(3, 4, 3, 4);
            Score.Name = "Score";
            Score.Size = new Size(487, 901);
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
            expansion_expansion_panel.Size = new Size(487, 403);
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
            studentCodeRating.Size = new Size(431, 295);
            studentCodeRating.TabIndex = 79;
            // 
            // steamGradientPanel1
            // 
            steamGradientPanel1.Controls.Add(splitContainer1);
            steamGradientPanel1.Controls.Add(headerPanel);
            steamGradientPanel1.Dock = DockStyle.Fill;
            steamGradientPanel1.GradientAngle = 90F;
            steamGradientPanel1.GradientBottomColor = Color.FromArgb(26, 30, 36);
            steamGradientPanel1.GradientTopColor = Color.FromArgb(11, 14, 17);
            steamGradientPanel1.Location = new Point(0, 0);
            steamGradientPanel1.Name = "steamGradientPanel1";
            steamGradientPanel1.Size = new Size(1602, 1016);
            steamGradientPanel1.TabIndex = 11;
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(87, 9);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(211, 32);
            steamLabel1.SteamSize = CustomComponents.SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = CustomComponents.SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 18;
            steamLabel1.Text = "SmartCodeLab";
            // 
            // studentIdentity
            // 
            studentIdentity.AutoSize = true;
            studentIdentity.BackColor = Color.Transparent;
            studentIdentity.Font = new Font("Geist", 12F);
            studentIdentity.ForeColor = Color.FromArgb(139, 149, 166);
            studentIdentity.Location = new Point(87, 41);
            studentIdentity.Name = "studentIdentity";
            studentIdentity.Size = new Size(309, 23);
            studentIdentity.SteamSize = CustomComponents.SteamThings.SteamLabel.SizeOption.Regular;
            studentIdentity.SteamTheme = CustomComponents.SteamThings.SteamLabel.ThemeOption.Muted;
            studentIdentity.TabIndex = 19;
            studentIdentity.Text = "Jimmuel Sanggayan | 2022-00842";
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
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel_MiddlePart_Main.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private PictureBox pictureBox1;
        private CustomComponents.GeneralComponents.SmartButton smartButton5;
        private Button button1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private SplitContainer splitContainer1;
        private Panel panel_MiddlePart_Main;
        private CustomComponents.WPFComponents.CustomTabControl customTabControl1;
        private Panel panel1;
        private CustomComponents.GeneralComponents.SmartButton smartButton3;
        private CustomComponents.GeneralComponents.SmartButton smartButton1;
        private CustomComponents.GeneralComponents.SmartButton smartButton2;
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
    }
}