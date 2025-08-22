namespace SmartCodeLab.CustomComponents.MainPages
{
    partial class TaskMainPage
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem1 = new ToolStripMenuItem();
            fileTree = new TreeView();
            smoothTabControl2 = new SmoothTabControl();
            tabPage6 = new TabPage();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            menuStrip1.SuspendLayout();
            smoothTabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1440, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, openFolderToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(174, 26);
            openFolderToolStripMenuItem.Text = "New File";
            // 
            // openFolderToolStripMenuItem1
            // 
            openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
            openFolderToolStripMenuItem1.Size = new Size(174, 26);
            openFolderToolStripMenuItem1.Text = "Open Folder";
            openFolderToolStripMenuItem1.Click += openFolderToolStripMenuItem1_Click;
            // 
            // fileTree
            // 
            fileTree.Location = new Point(3, 33);
            fileTree.Name = "fileTree";
            fileTree.Size = new Size(208, 438);
            fileTree.TabIndex = 6;
            fileTree.AfterSelect += fileTree_AfterSelect;
            // 
            // smoothTabControl2
            // 
            smoothTabControl2.Anchor = AnchorStyles.None;
            smoothTabControl2.Controls.Add(tabPage6);
            smoothTabControl2.Depth = 0;
            smoothTabControl2.Location = new Point(217, 64);
            smoothTabControl2.Margin = new Padding(3, 4, 3, 4);
            smoothTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            smoothTabControl2.Multiline = true;
            smoothTabControl2.Name = "smoothTabControl2";
            smoothTabControl2.SelectedIndex = 0;
            smoothTabControl2.Size = new Size(1220, 787);
            smoothTabControl2.TabIndex = 8;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 4, 3, 4);
            tabPage6.Size = new Size(1212, 754);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "task2";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = smoothTabControl2;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(217, 34);
            materialTabSelector1.Margin = new Padding(3, 4, 3, 4);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1223, 31);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TaskMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(smoothTabControl2);
            Controls.Add(materialTabSelector1);
            Controls.Add(fileTree);
            Controls.Add(menuStrip1);
            Name = "TaskMainPage";
            Size = new Size(1440, 874);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            smoothTabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem1;
        private TreeView fileTree;
        private SmoothTabControl smoothTabControl2;
        private TabPage tabPage6;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}
