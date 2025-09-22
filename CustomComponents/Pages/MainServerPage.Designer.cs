namespace SmartCodeLab.CustomComponents.Pages
{
    partial class MainServerPage
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
            codeMonitoringToolStripMenuItem = new ToolStripMenuItem();
            submissionStatusToolStripMenuItem = new ToolStripMenuItem();
            viewUsersToolStripMenuItem = new ToolStripMenuItem();
            viewUsersToolStripMenuItem1 = new ToolStripMenuItem();
            container = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            menuStrip1.SuspendLayout();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { codeMonitoringToolStripMenuItem, submissionStatusToolStripMenuItem, viewUsersToolStripMenuItem, viewUsersToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1345, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // codeMonitoringToolStripMenuItem
            // 
            codeMonitoringToolStripMenuItem.Name = "codeMonitoringToolStripMenuItem";
            codeMonitoringToolStripMenuItem.Size = new Size(64, 24);
            codeMonitoringToolStripMenuItem.Text = "Home";
            codeMonitoringToolStripMenuItem.Click += codeMonitoringToolStripMenuItem_Click;
            // 
            // submissionStatusToolStripMenuItem
            // 
            submissionStatusToolStripMenuItem.Name = "submissionStatusToolStripMenuItem";
            submissionStatusToolStripMenuItem.Size = new Size(136, 24);
            submissionStatusToolStripMenuItem.Text = "Code Monitoring";
            submissionStatusToolStripMenuItem.Click += submissionStatusToolStripMenuItem_Click;
            // 
            // viewUsersToolStripMenuItem
            // 
            viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            viewUsersToolStripMenuItem.Size = new Size(50, 24);
            viewUsersToolStripMenuItem.Text = "Task";
            viewUsersToolStripMenuItem.Click += viewUsersToolStripMenuItem_Click;
            // 
            // viewUsersToolStripMenuItem1
            // 
            viewUsersToolStripMenuItem1.Name = "viewUsersToolStripMenuItem1";
            viewUsersToolStripMenuItem1.Size = new Size(94, 24);
            viewUsersToolStripMenuItem1.Text = "View Users";
            viewUsersToolStripMenuItem1.Click += viewUsersToolStripMenuItem1_Click;
            // 
            // container
            // 
            container.Controls.Add(tabPage1);
            container.Controls.Add(tabPage2);
            container.Controls.Add(tabPage3);
            container.Controls.Add(tabPage4);
            container.Depth = 0;
            container.Location = new Point(0, 31);
            container.MouseState = MaterialSkin.MouseState.HOVER;
            container.Multiline = true;
            container.Name = "container";
            container.SelectedIndex = 0;
            container.Size = new Size(1345, 859);
            container.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1337, 826);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1337, 826);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1337, 826);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1337, 826);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainServerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(container);
            Controls.Add(menuStrip1);
            Name = "MainServerPage";
            Size = new Size(1345, 890);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem codeMonitoringToolStripMenuItem;
        private ToolStripMenuItem submissionStatusToolStripMenuItem;
        private ToolStripMenuItem viewUsersToolStripMenuItem;
        private GeneralComponents.SmoothTabControl container;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ToolStripMenuItem viewUsersToolStripMenuItem1;
    }
}
