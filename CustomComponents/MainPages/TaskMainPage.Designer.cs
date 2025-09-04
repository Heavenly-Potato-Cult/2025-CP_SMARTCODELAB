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
            customTabControl1 = new CustomTabControl();
            panel_cover1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(13, 13, 13);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1296, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, openFolderToolStripMenuItem1 });
            fileToolStripMenuItem.ForeColor = Color.FromArgb(242, 242, 242);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.BackColor = Color.FromArgb(13, 13, 13);
            openFolderToolStripMenuItem.ForeColor = Color.FromArgb(242, 242, 242);
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(174, 26);
            openFolderToolStripMenuItem.Text = "New File";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem1
            // 
            openFolderToolStripMenuItem1.BackColor = Color.FromArgb(13, 13, 13);
            openFolderToolStripMenuItem1.ForeColor = Color.FromArgb(242, 242, 242);
            openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
            openFolderToolStripMenuItem1.Size = new Size(174, 26);
            openFolderToolStripMenuItem1.Text = "Open Folder";
            openFolderToolStripMenuItem1.Click += openFolderToolStripMenuItem1_Click;
            // 
            // fileTree
            // 
            fileTree.BackColor = Color.FromArgb(13, 13, 13);
            fileTree.BorderStyle = BorderStyle.None;
            fileTree.ForeColor = Color.FromArgb(242, 242, 242);
            fileTree.Location = new Point(0, 32);
            fileTree.Name = "fileTree";
            fileTree.Size = new Size(208, 440);
            fileTree.TabIndex = 6;
            fileTree.NodeMouseClick += fileTree_NodeMouseClick;
            // 
            // customTabControl1
            // 
            customTabControl1.BackColor = Color.FromArgb(10, 10, 10);
            customTabControl1.Location = new Point(217, 33);
            customTabControl1.Name = "customTabControl1";
            customTabControl1.Size = new Size(1097, 772);
            customTabControl1.TabIndex = 7;
            // 
            // panel_cover1
            // 
            panel_cover1.Location = new Point(217, 34);
            panel_cover1.Margin = new Padding(3, 4, 3, 4);
            panel_cover1.Name = "panel_cover1";
            panel_cover1.Size = new Size(1097, 771);
            panel_cover1.TabIndex = 8;
            // 
            // TaskMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(panel_cover1);
            Controls.Add(customTabControl1);
            Controls.Add(fileTree);
            Controls.Add(menuStrip1);
            Name = "TaskMainPage";
            Size = new Size(1296, 875);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem1;
        private TreeView fileTree;
        private CustomTabControl customTabControl1;
        private Panel panel_cover1;
    }
}
