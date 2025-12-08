namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    partial class ServerTaskUpdate
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerTaskUpdate));
            reference = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            btn_EditExerciseDetails = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel2 = new Panel();
            testcase_panel = new Panel();
            smartButton5 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            reference_panel = new Panel();
            smartButton3 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            detail_panel = new Panel();
            btn_details = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            panel6 = new Panel();
            task_tabcontrol = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage2 = new TabPage();
            instruction = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            steamLabel4 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            subject = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            steamLabel3 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            exerciseName = new SmartCodeLab.CustomComponents.SteamThings.SteamTextBox();
            steamLabel2 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            tabPage5 = new TabPage();
            smartButton6 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamLabel5 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            tabPage6 = new TabPage();
            testContainer = new Panel();
            btn_AddTestCase = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            steamLabel6 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            steamLabel1 = new SmartCodeLab.CustomComponents.SteamThings.SteamLabel();
            panel7 = new Panel();
            panel1 = new Panel();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customCard1 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard2 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard3 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard4 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            customCard5 = new SmartCodeLab.CustomComponents.GeneralComponents.CustomCard();
            ((System.ComponentModel.ISupportInitialize)reference).BeginInit();
            panel2.SuspendLayout();
            testcase_panel.SuspendLayout();
            reference_panel.SuspendLayout();
            detail_panel.SuspendLayout();
            task_tabcontrol.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            customCard1.SuspendLayout();
            customCard2.SuspendLayout();
            SuspendLayout();
            // 
            // reference
            // 
            reference.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reference.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            reference.AutoScrollMinSize = new Size(2, 18);
            reference.BackBrush = null;
            reference.BackColor = Color.Transparent;
            reference.BorderStyle = BorderStyle.FixedSingle;
            reference.CharHeight = 18;
            reference.CharWidth = 10;
            reference.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            reference.Font = new Font("Courier New", 9.75F);
            reference.ForeColor = Color.FromArgb(224, 224, 224);
            reference.Hotkeys = resources.GetString("reference.Hotkeys");
            reference.IndentBackColor = Color.Transparent;
            reference.IsReplaceMode = false;
            reference.Location = new Point(16, 57);
            reference.Name = "reference";
            reference.Paddings = new Padding(0);
            reference.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            reference.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("reference.ServiceColors");
            reference.Size = new Size(1372, 542);
            reference.TabIndex = 57;
            reference.Zoom = 100;
            // 
            // btn_EditExerciseDetails
            // 
            btn_EditExerciseDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditExerciseDetails.BackColor = Color.FromArgb(42, 71, 94);
            btn_EditExerciseDetails.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_EditExerciseDetails.BorderRadius = 5;
            btn_EditExerciseDetails.FlatAppearance.BorderSize = 0;
            btn_EditExerciseDetails.FlatStyle = FlatStyle.Flat;
            btn_EditExerciseDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditExerciseDetails.ForeColor = Color.White;
            btn_EditExerciseDetails.Location = new Point(1127, 41);
            btn_EditExerciseDetails.Name = "btn_EditExerciseDetails";
            btn_EditExerciseDetails.Size = new Size(374, 51);
            btn_EditExerciseDetails.TabIndex = 35;
            btn_EditExerciseDetails.Text = "Save Changes";
            btn_EditExerciseDetails.UseVisualStyleBackColor = false;
            btn_EditExerciseDetails.Click += btn_EditExerciseDetails_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 26, 33);
            panel2.Controls.Add(testcase_panel);
            panel2.Controls.Add(reference_panel);
            panel2.Controls.Add(detail_panel);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1049);
            panel2.TabIndex = 55;
            // 
            // testcase_panel
            // 
            testcase_panel.Controls.Add(smartButton5);
            testcase_panel.Dock = DockStyle.Top;
            testcase_panel.Location = new Point(0, 209);
            testcase_panel.Name = "testcase_panel";
            testcase_panel.Padding = new Padding(10, 0, 0, 0);
            testcase_panel.Size = new Size(250, 42);
            testcase_panel.TabIndex = 69;
            // 
            // smartButton5
            // 
            smartButton5.BackColor = Color.FromArgb(23, 26, 33);
            smartButton5.BackgroundColor = Color.FromArgb(23, 26, 33);
            smartButton5.BorderRadius = 1;
            smartButton5.Dock = DockStyle.Fill;
            smartButton5.FlatAppearance.BorderSize = 0;
            smartButton5.FlatStyle = FlatStyle.Flat;
            smartButton5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton5.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton5.Location = new Point(10, 0);
            smartButton5.Margin = new Padding(2, 4, 2, 4);
            smartButton5.Name = "smartButton5";
            smartButton5.Size = new Size(240, 42);
            smartButton5.TabIndex = 67;
            smartButton5.Text = "Test Cases";
            smartButton5.TextAlign = ContentAlignment.MiddleLeft;
            smartButton5.TextColor = Color.FromArgb(199, 213, 224);
            smartButton5.UseVisualStyleBackColor = false;
            smartButton5.Click += smartButton5_Click_1;
            // 
            // reference_panel
            // 
            reference_panel.Controls.Add(smartButton3);
            reference_panel.Dock = DockStyle.Top;
            reference_panel.Location = new Point(0, 167);
            reference_panel.Name = "reference_panel";
            reference_panel.Padding = new Padding(10, 0, 0, 0);
            reference_panel.Size = new Size(250, 42);
            reference_panel.TabIndex = 69;
            // 
            // smartButton3
            // 
            smartButton3.BackColor = Color.FromArgb(23, 26, 33);
            smartButton3.BackgroundColor = Color.FromArgb(23, 26, 33);
            smartButton3.BorderRadius = 1;
            smartButton3.Dock = DockStyle.Fill;
            smartButton3.FlatAppearance.BorderSize = 0;
            smartButton3.FlatStyle = FlatStyle.Flat;
            smartButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton3.ForeColor = Color.FromArgb(199, 213, 224);
            smartButton3.Location = new Point(10, 0);
            smartButton3.Margin = new Padding(2, 4, 2, 4);
            smartButton3.Name = "smartButton3";
            smartButton3.Size = new Size(240, 42);
            smartButton3.TabIndex = 67;
            smartButton3.Text = "Reference Code";
            smartButton3.TextAlign = ContentAlignment.MiddleLeft;
            smartButton3.TextColor = Color.FromArgb(199, 213, 224);
            smartButton3.UseVisualStyleBackColor = false;
            smartButton3.Click += smartButton3_Click_1;
            // 
            // detail_panel
            // 
            detail_panel.BackColor = Color.FromArgb(23, 26, 33);
            detail_panel.Controls.Add(btn_details);
            detail_panel.Dock = DockStyle.Top;
            detail_panel.Location = new Point(0, 125);
            detail_panel.Name = "detail_panel";
            detail_panel.Padding = new Padding(10, 0, 0, 0);
            detail_panel.Size = new Size(250, 42);
            detail_panel.TabIndex = 68;
            // 
            // btn_details
            // 
            btn_details.BackColor = Color.FromArgb(23, 26, 33);
            btn_details.BackgroundColor = Color.FromArgb(23, 26, 33);
            btn_details.BorderRadius = 1;
            btn_details.Dock = DockStyle.Fill;
            btn_details.FlatAppearance.BorderSize = 0;
            btn_details.FlatStyle = FlatStyle.Flat;
            btn_details.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_details.ForeColor = Color.FromArgb(199, 213, 224);
            btn_details.Location = new Point(10, 0);
            btn_details.Margin = new Padding(2, 4, 2, 4);
            btn_details.Name = "btn_details";
            btn_details.Size = new Size(240, 42);
            btn_details.TabIndex = 67;
            btn_details.Text = "General Details";
            btn_details.TextAlign = ContentAlignment.MiddleLeft;
            btn_details.TextColor = Color.FromArgb(199, 213, 224);
            btn_details.UseVisualStyleBackColor = false;
            btn_details.Click += btn_details_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 56;
            // 
            // task_tabcontrol
            // 
            task_tabcontrol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            task_tabcontrol.Controls.Add(tabPage2);
            task_tabcontrol.Controls.Add(tabPage5);
            task_tabcontrol.Controls.Add(tabPage6);
            task_tabcontrol.Depth = 0;
            task_tabcontrol.Location = new Point(35, 22);
            task_tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            task_tabcontrol.Multiline = true;
            task_tabcontrol.Name = "task_tabcontrol";
            task_tabcontrol.SelectedIndex = 0;
            task_tabcontrol.Size = new Size(1450, 689);
            task_tabcontrol.TabIndex = 56;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(19, 27, 36);
            tabPage2.Controls.Add(instruction);
            tabPage2.Controls.Add(steamLabel4);
            tabPage2.Controls.Add(subject);
            tabPage2.Controls.Add(steamLabel3);
            tabPage2.Controls.Add(exerciseName);
            tabPage2.Controls.Add(steamLabel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1442, 656);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            // 
            // instruction
            // 
            instruction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            instruction.AutoScroll = true;
            instruction.BackColor = Color.FromArgb(26, 30, 36);
            instruction.Location = new Point(22, 208);
            instruction.Multiline = true;
            instruction.Name = "instruction";
            instruction.Padding = new Padding(10, 8, 10, 8);
            instruction.PlaceholderColor = Color.DarkGray;
            instruction.PlaceholderText = "Enter exercise instructions...";
            instruction.ReadOnly = false;
            instruction.ScrollBars = ScrollBars.Vertical;
            instruction.Size = new Size(1113, 337);
            instruction.TabIndex = 63;
            instruction.WordWrap = true;
            // 
            // steamLabel4
            // 
            steamLabel4.AutoSize = true;
            steamLabel4.BackColor = Color.Transparent;
            steamLabel4.Font = new Font("Geist", 12F);
            steamLabel4.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel4.Location = new Point(22, 165);
            steamLabel4.Name = "steamLabel4";
            steamLabel4.Size = new Size(100, 23);
            steamLabel4.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel4.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel4.TabIndex = 62;
            steamLabel4.Text = "Instruction";
            // 
            // subject
            // 
            subject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subject.BackColor = Color.FromArgb(26, 30, 36);
            subject.Location = new Point(824, 74);
            subject.Multiline = false;
            subject.Name = "subject";
            subject.Padding = new Padding(10, 8, 10, 8);
            subject.PlaceholderColor = Color.DarkGray;
            subject.PlaceholderText = "";
            subject.ReadOnly = false;
            subject.ScrollBars = ScrollBars.None;
            subject.Size = new Size(311, 44);
            subject.TabIndex = 61;
            subject.WordWrap = true;
            // 
            // steamLabel3
            // 
            steamLabel3.AutoSize = true;
            steamLabel3.BackColor = Color.Transparent;
            steamLabel3.Font = new Font("Geist", 12F);
            steamLabel3.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel3.Location = new Point(824, 32);
            steamLabel3.Name = "steamLabel3";
            steamLabel3.Size = new Size(75, 23);
            steamLabel3.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel3.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel3.TabIndex = 60;
            steamLabel3.Text = "Subject";
            // 
            // exerciseName
            // 
            exerciseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exerciseName.BackColor = Color.FromArgb(26, 30, 36);
            exerciseName.Location = new Point(22, 74);
            exerciseName.Multiline = false;
            exerciseName.Name = "exerciseName";
            exerciseName.Padding = new Padding(10, 8, 10, 8);
            exerciseName.PlaceholderColor = Color.DarkGray;
            exerciseName.PlaceholderText = "Enter exercise name";
            exerciseName.ReadOnly = false;
            exerciseName.ScrollBars = ScrollBars.None;
            exerciseName.Size = new Size(311, 44);
            exerciseName.TabIndex = 59;
            exerciseName.WordWrap = true;
            // 
            // steamLabel2
            // 
            steamLabel2.AutoSize = true;
            steamLabel2.BackColor = Color.Transparent;
            steamLabel2.Font = new Font("Geist", 12F);
            steamLabel2.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel2.Location = new Point(22, 32);
            steamLabel2.Name = "steamLabel2";
            steamLabel2.Size = new Size(135, 23);
            steamLabel2.SteamSize = SteamThings.SteamLabel.SizeOption.Regular;
            steamLabel2.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel2.TabIndex = 58;
            steamLabel2.Text = "Execise Name";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(19, 27, 36);
            tabPage5.Controls.Add(smartButton6);
            tabPage5.Controls.Add(steamLabel5);
            tabPage5.Controls.Add(reference);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1442, 656);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "tabPage5";
            // 
            // smartButton6
            // 
            smartButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton6.BackColor = Color.FromArgb(42, 71, 94);
            smartButton6.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton6.BorderRadius = 5;
            smartButton6.FlatAppearance.BorderSize = 0;
            smartButton6.FlatStyle = FlatStyle.Flat;
            smartButton6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton6.ForeColor = Color.White;
            smartButton6.Location = new Point(1227, 6);
            smartButton6.Name = "smartButton6";
            smartButton6.Size = new Size(161, 42);
            smartButton6.TabIndex = 60;
            smartButton6.Text = "Upload Code";
            smartButton6.UseVisualStyleBackColor = false;
            smartButton6.Click += smartButton6_Click;
            // 
            // steamLabel5
            // 
            steamLabel5.AutoSize = true;
            steamLabel5.BackColor = Color.Transparent;
            steamLabel5.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel5.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel5.Location = new Point(16, 14);
            steamLabel5.Name = "steamLabel5";
            steamLabel5.Size = new Size(265, 32);
            steamLabel5.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel5.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel5.TabIndex = 59;
            steamLabel5.Text = "Reference Solution";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(19, 27, 36);
            tabPage6.Controls.Add(testContainer);
            tabPage6.Controls.Add(btn_AddTestCase);
            tabPage6.Controls.Add(steamLabel6);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(0);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1442, 656);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "tabPage6";
            // 
            // testContainer
            // 
            testContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            testContainer.AutoScroll = true;
            testContainer.Location = new Point(16, 73);
            testContainer.Name = "testContainer";
            testContainer.Padding = new Padding(0, 0, 0, 30);
            testContainer.Size = new Size(1390, 560);
            testContainer.TabIndex = 62;
            // 
            // btn_AddTestCase
            // 
            btn_AddTestCase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddTestCase.BackColor = Color.FromArgb(42, 71, 94);
            btn_AddTestCase.BackgroundColor = Color.FromArgb(42, 71, 94);
            btn_AddTestCase.BorderRadius = 5;
            btn_AddTestCase.FlatAppearance.BorderSize = 0;
            btn_AddTestCase.FlatStyle = FlatStyle.Flat;
            btn_AddTestCase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddTestCase.ForeColor = Color.White;
            btn_AddTestCase.Location = new Point(1245, 9);
            btn_AddTestCase.Name = "btn_AddTestCase";
            btn_AddTestCase.Size = new Size(161, 42);
            btn_AddTestCase.TabIndex = 61;
            btn_AddTestCase.Text = "Add Test Case";
            btn_AddTestCase.UseVisualStyleBackColor = false;
            btn_AddTestCase.Click += btn_AddTestCase_Click_1;
            // 
            // steamLabel6
            // 
            steamLabel6.AutoSize = true;
            steamLabel6.BackColor = Color.Transparent;
            steamLabel6.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel6.ForeColor = Color.FromArgb(139, 149, 166);
            steamLabel6.Location = new Point(16, 14);
            steamLabel6.Name = "steamLabel6";
            steamLabel6.Size = new Size(157, 32);
            steamLabel6.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel6.SteamTheme = SteamThings.SteamLabel.ThemeOption.Muted;
            steamLabel6.TabIndex = 60;
            steamLabel6.Text = "Test Cases";
            // 
            // steamLabel1
            // 
            steamLabel1.AutoSize = true;
            steamLabel1.BackColor = Color.Transparent;
            steamLabel1.Font = new Font("Geist", 16F, FontStyle.Bold);
            steamLabel1.ForeColor = Color.FromArgb(199, 213, 224);
            steamLabel1.Location = new Point(55, 46);
            steamLabel1.Name = "steamLabel1";
            steamLabel1.Size = new Size(135, 32);
            steamLabel1.SteamSize = SteamThings.SteamLabel.SizeOption.Medium;
            steamLabel1.SteamTheme = SteamThings.SteamLabel.ThemeOption.Standard;
            steamLabel1.TabIndex = 57;
            steamLabel1.Text = "Edit Task\r\n";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(27, 40, 56);
            panel7.Controls.Add(steamLabel1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(251, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1550, 125);
            panel7.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 40, 56);
            panel1.Controls.Add(smartButton2);
            panel1.Controls.Add(btn_EditExerciseDetails);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(251, 906);
            panel1.Name = "panel1";
            panel1.Size = new Size(1550, 143);
            panel1.TabIndex = 59;
            // 
            // smartButton2
            // 
            smartButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            smartButton2.BackColor = Color.FromArgb(42, 71, 94);
            smartButton2.BackgroundColor = Color.FromArgb(42, 71, 94);
            smartButton2.BorderRadius = 5;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(883, 41);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(222, 51);
            smartButton2.TabIndex = 36;
            smartButton2.Text = "Change Exercise";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click_1;
            // 
            // customCard1
            // 
            customCard1.BackColor = Color.FromArgb(11, 14, 17);
            customCard1.BorderColor = Color.Transparent;
            customCard1.BorderRadius = 2;
            customCard1.BorderSize = 1;
            customCard1.Controls.Add(customCard2);
            customCard1.Dock = DockStyle.Fill;
            customCard1.Location = new Point(251, 126);
            customCard1.Margin = new Padding(0);
            customCard1.Name = "customCard1";
            customCard1.Padding = new Padding(20);
            customCard1.Size = new Size(1550, 779);
            customCard1.TabIndex = 108;
            // 
            // customCard2
            // 
            customCard2.BackColor = Color.FromArgb(19, 27, 36);
            customCard2.BorderColor = Color.FromArgb(42, 71, 94);
            customCard2.BorderRadius = 2;
            customCard2.BorderSize = 1;
            customCard2.Controls.Add(task_tabcontrol);
            customCard2.Dock = DockStyle.Fill;
            customCard2.Location = new Point(20, 20);
            customCard2.Margin = new Padding(20, 3, 20, 3);
            customCard2.Name = "customCard2";
            customCard2.Size = new Size(1510, 739);
            customCard2.TabIndex = 109;
            // 
            // customCard3
            // 
            customCard3.BackColor = Color.FromArgb(23, 29, 37);
            customCard3.BorderColor = Color.FromArgb(42, 71, 94);
            customCard3.BorderRadius = 2;
            customCard3.BorderSize = 1;
            customCard3.Dock = DockStyle.Left;
            customCard3.Location = new Point(250, 0);
            customCard3.Margin = new Padding(0);
            customCard3.Name = "customCard3";
            customCard3.Size = new Size(1, 1049);
            customCard3.TabIndex = 110;
            // 
            // customCard4
            // 
            customCard4.BackColor = Color.FromArgb(23, 29, 37);
            customCard4.BorderColor = Color.FromArgb(42, 71, 94);
            customCard4.BorderRadius = 2;
            customCard4.BorderSize = 1;
            customCard4.Dock = DockStyle.Top;
            customCard4.Location = new Point(251, 125);
            customCard4.Margin = new Padding(0);
            customCard4.Name = "customCard4";
            customCard4.Size = new Size(1550, 1);
            customCard4.TabIndex = 111;
            // 
            // customCard5
            // 
            customCard5.BackColor = Color.FromArgb(23, 29, 37);
            customCard5.BorderColor = Color.FromArgb(42, 71, 94);
            customCard5.BorderRadius = 2;
            customCard5.BorderSize = 1;
            customCard5.Dock = DockStyle.Bottom;
            customCard5.Location = new Point(251, 905);
            customCard5.Margin = new Padding(0);
            customCard5.Name = "customCard5";
            customCard5.Size = new Size(1550, 1);
            customCard5.TabIndex = 112;
            // 
            // ServerTaskUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 29, 37);
            Controls.Add(customCard1);
            Controls.Add(customCard5);
            Controls.Add(panel1);
            Controls.Add(customCard4);
            Controls.Add(panel7);
            Controls.Add(customCard3);
            Controls.Add(panel2);
            Name = "ServerTaskUpdate";
            Size = new Size(1801, 1049);
            ((System.ComponentModel.ISupportInitialize)reference).EndInit();
            panel2.ResumeLayout(false);
            testcase_panel.ResumeLayout(false);
            reference_panel.ResumeLayout(false);
            detail_panel.ResumeLayout(false);
            task_tabcontrol.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            customCard1.ResumeLayout(false);
            customCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GeneralComponents.SmartButton btn_EditExerciseDetails;
        private Label label25;
        private Label label8;
        private ProgrammingTabs.CodeEditor reference;
        private GeneralComponents.CustomCard customCard7;
        private Label label15;
        private Label label14;
        private GeneralComponents.SmartButton btn_AddTestCase;
        private Label label13;
        private Panel panel2;
        private GeneralComponents.SmartButton btn_AddNewExercise;
        private Panel detail_panel;
        private Panel testcase_panel;
        private GeneralComponents.SmartButton smartButton5;
        private Panel reference_panel;
        private GeneralComponents.SmartButton smartButton3;
        private Panel panel6;
        private GeneralComponents.SmoothTabControl smoothTabControl1;
        private TabPage tabPage2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private SteamThings.SteamLabel steamLabel1;
        private Panel panel7;
        private Panel panel1;
        private SteamThings.SteamLabel steamLabel2;
        private SteamThings.SteamTextBox exerciseName;
        private Label label9;
        private SteamThings.SteamTextBox subject;
        private SteamThings.SteamLabel steamLabel3;
        private SteamThings.SteamTextBox instruction;
        private SteamThings.SteamLabel steamLabel4;
        private GeneralComponents.CustomCard customCard1;
        private GeneralComponents.CustomCard customCard2;
        private GeneralComponents.CustomCard customCard3;
        private GeneralComponents.CustomCard customCard4;
        private GeneralComponents.CustomCard customCard5;
        private SteamThings.SteamLabel steamLabel5;
        private GeneralComponents.SmartButton btn_details;
        private GeneralComponents.SmoothTabControl task_tabcontrol;
        private GeneralComponents.SmartButton smartButton1;
        private SteamThings.SteamLabel steamLabel6;
        private Panel testContainer;
        private Panel panel3;
        private SteamThings.SteamLabel steamLabel7;
        private GeneralComponents.SmartButton smartButton2;
        private GeneralComponents.SmartButton smartButton6;
    }
}
