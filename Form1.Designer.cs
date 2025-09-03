using SmartCodeLab.CustomComponents.GeneralComponents;

namespace SmartCodeLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabPage4 = new TabPage();
            taskMainPage1 = new CustomComponents.MainPages.TaskMainPage();
            tabPage3 = new TabPage();
            fileTree = new TreeView();
            smoothTabControl2 = new CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage5 = new TabPage();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            openFile1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            tabPage6 = new TabPage();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem1 = new ToolStripMenuItem();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            tabPage2 = new TabPage();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            textBox2 = new TextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            tabPage1 = new TabPage();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            listView2 = new ListView();
            listView1 = new ListView();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            textBox1 = new TextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            smoothTabControl1 = new CustomComponents.GeneralComponents.SmoothTabControl();
            openFileDialog1 = new OpenFileDialog();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            smoothTabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard5.SuspendLayout();
            tabPage1.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            smoothTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = SystemColors.ControlDark;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(743, 585);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(144, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Enter";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "file_white.png");
            imageList1.Images.SetKeyName(1, "group_white.png");
            imageList1.Images.SetKeyName(2, "instruction_white.png");
            imageList1.Images.SetKeyName(3, "logout_white.png");
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(taskMainPage1);
            tabPage4.ImageKey = "logout_white.png";
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1261, 652);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exit";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // taskMainPage1
            // 
            taskMainPage1.Location = new Point(3, 2);
            taskMainPage1.Margin = new Padding(3, 2, 3, 2);
            taskMainPage1.Name = "taskMainPage1";
            taskMainPage1.Size = new Size(1263, 656);
            taskMainPage1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(fileTree);
            tabPage3.Controls.Add(smoothTabControl2);
            tabPage3.Controls.Add(menuStrip1);
            tabPage3.Controls.Add(materialTabSelector1);
            tabPage3.ImageKey = "instruction_white.png";
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1261, 652);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Instructions";
            // 
            // fileTree
            // 
            fileTree.Location = new Point(3, 25);
            fileTree.Margin = new Padding(3, 2, 3, 2);
            fileTree.Name = "fileTree";
            fileTree.Size = new Size(250, 464);
            fileTree.TabIndex = 5;
            // 
            // smoothTabControl2
            // 
            smoothTabControl2.Anchor = AnchorStyles.None;
            smoothTabControl2.Controls.Add(tabPage5);
            smoothTabControl2.Controls.Add(tabPage6);
            smoothTabControl2.Depth = 0;
            smoothTabControl2.Location = new Point(249, 48);
            smoothTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            smoothTabControl2.Multiline = true;
            smoothTabControl2.Name = "smoothTabControl2";
            smoothTabControl2.SelectedIndex = 0;
            smoothTabControl2.Size = new Size(932, 413);
            smoothTabControl2.TabIndex = 3;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(materialButton5);
            tabPage5.Controls.Add(materialLabel12);
            tabPage5.Controls.Add(openFile1);
            tabPage5.Controls.Add(materialLabel11);
            tabPage5.Controls.Add(materialButton4);
            tabPage5.Controls.Add(materialMultiLineTextBox1);
            tabPage5.Controls.Add(materialTextBox2);
            tabPage5.Controls.Add(materialTextBox1);
            tabPage5.Controls.Add(materialLabel10);
            tabPage5.Controls.Add(materialLabel9);
            tabPage5.Controls.Add(materialLabel8);
            tabPage5.ForeColor = SystemColors.ControlText;
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(924, 385);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "task1";
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(768, 103);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(98, 36);
            materialButton5.TabIndex = 12;
            materialButton5.Text = "Open File";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(645, 107);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(107, 19);
            materialLabel12.TabIndex = 11;
            materialLabel12.Text = "Associate Files";
            // 
            // openFile1
            // 
            openFile1.AutoSize = false;
            openFile1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openFile1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            openFile1.Depth = 0;
            openFile1.HighEmphasis = true;
            openFile1.Icon = null;
            openFile1.Location = new Point(768, 6);
            openFile1.Margin = new Padding(4, 6, 4, 6);
            openFile1.MouseState = MaterialSkin.MouseState.HOVER;
            openFile1.Name = "openFile1";
            openFile1.NoAccentTextColor = Color.Empty;
            openFile1.Size = new Size(98, 36);
            openFile1.TabIndex = 10;
            openFile1.Text = "Open File";
            openFile1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            openFile1.UseAccentColor = false;
            openFile1.UseVisualStyleBackColor = true;
            openFile1.Click += openFile1_Click;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(645, 10);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(107, 19);
            materialLabel11.TabIndex = 9;
            materialLabel11.Text = "Associate Files";
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(39, 279);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(147, 36);
            materialButton4.TabIndex = 8;
            materialButton4.Text = "Add Test Case";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.FixedSingle;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(48, 129);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(519, 96);
            materialMultiLineTextBox1.TabIndex = 7;
            materialMultiLineTextBox1.Text = "";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(330, 32);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(237, 50);
            materialTextBox2.TabIndex = 6;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(48, 32);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(237, 50);
            materialTextBox1.TabIndex = 5;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(48, 107);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(76, 19);
            materialLabel10.TabIndex = 4;
            materialLabel10.Text = "Instruction";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(330, 10);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(72, 19);
            materialLabel9.TabIndex = 2;
            materialLabel9.Text = "Language";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(48, 10);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(99, 19);
            materialLabel8.TabIndex = 0;
            materialLabel8.Text = "Activity Name";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(924, 385);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "task2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1261, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, openFolderToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(139, 22);
            openFolderToolStripMenuItem.Text = "New File";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem1
            // 
            openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
            openFolderToolStripMenuItem1.Size = new Size(139, 22);
            openFolderToolStripMenuItem1.Text = "Open Folder";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = smoothTabControl2;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(249, 26);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(925, 23);
            materialTabSelector1.TabIndex = 2;
            materialTabSelector1.Text = "materialTabSelector1";
            materialTabSelector1.Click += materialTabSelector1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(materialCard6);
            tabPage2.Controls.Add(materialCard5);
            tabPage2.ImageKey = "file_white.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1261, 652);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Files";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(textBox2);
            materialCard6.Controls.Add(materialLabel7);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(488, 62);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(503, 341);
            materialCard6.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 39);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(469, 272);
            textBox2.TabIndex = 4;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(17, 14);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(56, 19);
            materialLabel7.TabIndex = 1;
            materialLabel7.Text = "Preview";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(materialButton3);
            materialCard5.Controls.Add(materialListBox2);
            materialCard5.Controls.Add(materialButton2);
            materialCard5.Controls.Add(materialLabel6);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(63, 62);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(351, 341);
            materialCard5.TabIndex = 2;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(18, 237);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(147, 36);
            materialButton3.TabIndex = 3;
            materialButton3.Text = "Delete File";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialListBox2
            // 
            materialListBox2.BackColor = Color.White;
            materialListBox2.BorderColor = Color.LightGray;
            materialListBox2.Depth = 0;
            materialListBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox2.Location = new Point(17, 36);
            materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox2.Name = "materialListBox2";
            materialListBox2.SelectedIndex = -1;
            materialListBox2.SelectedItem = null;
            materialListBox2.Size = new Size(317, 128);
            materialListBox2.TabIndex = 2;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(18, 189);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(147, 36);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "Add Files";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 14);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(108, 19);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "Reference Files";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(materialCard4);
            tabPage1.Controls.Add(materialCard3);
            tabPage1.Controls.Add(materialCard2);
            tabPage1.Controls.Add(materialCard1);
            tabPage1.ImageKey = "group_white.png";
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1261, 652);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Students";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(materialLabel5);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(63, 444);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(1086, 204);
            materialCard4.TabIndex = 3;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(492, 14);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(61, 19);
            materialLabel5.TabIndex = 1;
            materialLabel5.Text = "Analysis";
            materialLabel5.Click += materialLabel5_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(listView2);
            materialCard3.Controls.Add(listView1);
            materialCard3.Controls.Add(materialLabel4);
            materialCard3.Controls.Add(materialLabel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(881, 62);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(268, 341);
            materialCard3.TabIndex = 4;
            // 
            // listView2
            // 
            listView2.Location = new Point(17, 227);
            listView2.Name = "listView2";
            listView2.Size = new Size(234, 97);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(17, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(234, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(17, 201);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(138, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Copy-Pasted Codes";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(71, 19);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "Functions";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(textBox1);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(374, 62);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(460, 341);
            materialCard2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(426, 288);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(144, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Code Review From : ";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialListBox1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(63, 62);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.RightToLeft = RightToLeft.No;
            materialCard1.Size = new Size(283, 341);
            materialCard1.TabIndex = 1;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "Jimmuel";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Clifford";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Angelo";
            materialListBox1.Items.Add(materialListBoxItem1);
            materialListBox1.Items.Add(materialListBoxItem2);
            materialListBox1.Items.Add(materialListBoxItem3);
            materialListBox1.Location = new Point(17, 36);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.RightToLeft = RightToLeft.No;
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(249, 128);
            materialListBox1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(100, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Connected PC";
            // 
            // smoothTabControl1
            // 
            smoothTabControl1.Controls.Add(tabPage1);
            smoothTabControl1.Controls.Add(tabPage2);
            smoothTabControl1.Controls.Add(tabPage3);
            smoothTabControl1.Controls.Add(tabPage4);
            smoothTabControl1.Depth = 0;
            smoothTabControl1.Dock = DockStyle.Fill;
            smoothTabControl1.ImageList = imageList1;
            smoothTabControl1.Location = new Point(3, 64);
            smoothTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            smoothTabControl1.Multiline = true;
            smoothTabControl1.Name = "smoothTabControl1";
            smoothTabControl1.SelectedIndex = 0;
            smoothTabControl1.Size = new Size(1269, 680);
            smoothTabControl1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 747);
            Controls.Add(smoothTabControl1);
            Controls.Add(materialButton1);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = smoothTabControl1;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SmartCodeLab";
            Load += Form1_Load;
            tabPage4.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            smoothTabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            tabPage1.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            smoothTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ImageList imageList1;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private TextBox textBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private ListView listView2;
        private ListView listView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private SmoothTabControl smoothTabControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private SmoothTabControl smoothTabControl2;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private TabPage tabPage6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton openFile1;
        private OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private TreeView fileTree;
        private CustomComponents.MainPages.TaskMainPage taskMainPage1;
    }
}
