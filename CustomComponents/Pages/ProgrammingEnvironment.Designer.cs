namespace SmartCodeLab.CustomComponents.Pages
{
    partial class ProgrammingEnvironment
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
            customTabControl1 = new CustomTabControl();
            fileTree = new TreeView();
            menuStrip1 = new MenuStrip();
            runToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // customTabControl1
            // 
            customTabControl1.BackColor = SystemColors.AppWorkspace;
            customTabControl1.Location = new Point(217, 30);
            customTabControl1.Name = "customTabControl1";
            customTabControl1.Size = new Size(1100, 838);
            customTabControl1.TabIndex = 10;
            // 
            // fileTree
            // 
            fileTree.Location = new Point(3, 30);
            fileTree.Name = "fileTree";
            fileTree.Size = new Size(208, 438);
            fileTree.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runToolStripMenuItem, testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1329, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(48, 24);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(49, 24);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // ProgrammingEnvironment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(customTabControl1);
            Controls.Add(fileTree);
            Controls.Add(menuStrip1);
            Name = "ProgrammingEnvironment";
            Size = new Size(1329, 871);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTabControl customTabControl1;
        private TreeView fileTree;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
    }
}
