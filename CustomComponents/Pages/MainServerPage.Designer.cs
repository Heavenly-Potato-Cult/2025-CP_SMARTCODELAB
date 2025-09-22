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
            container = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            viewUsersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { codeMonitoringToolStripMenuItem, submissionStatusToolStripMenuItem, viewUsersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1345, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // codeMonitoringToolStripMenuItem
            // 
            codeMonitoringToolStripMenuItem.Name = "codeMonitoringToolStripMenuItem";
            codeMonitoringToolStripMenuItem.Size = new Size(136, 24);
            codeMonitoringToolStripMenuItem.Text = "Code Monitoring";
            codeMonitoringToolStripMenuItem.Click += codeMonitoringToolStripMenuItem_Click;
            // 
            // submissionStatusToolStripMenuItem
            // 
            submissionStatusToolStripMenuItem.Name = "submissionStatusToolStripMenuItem";
            submissionStatusToolStripMenuItem.Size = new Size(50, 24);
            submissionStatusToolStripMenuItem.Text = "Task";
            submissionStatusToolStripMenuItem.Click += submissionStatusToolStripMenuItem_Click;
            // 
            // container
            // 
            container.Controls.Add(tabPage1);
            container.Controls.Add(tabPage2);
            container.Controls.Add(tabPage3);
            container.Location = new Point(0, 31);
            container.Name = "container";
            container.SelectedIndex = 0;
            container.Size = new Size(1345, 856);
            container.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1337, 823);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1337, 823);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1337, 823);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewUsersToolStripMenuItem
            // 
            viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            viewUsersToolStripMenuItem.Size = new Size(94, 24);
            viewUsersToolStripMenuItem.Text = "View Users";
            viewUsersToolStripMenuItem.Click += viewUsersToolStripMenuItem_Click;
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
        private TabControl container;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ToolStripMenuItem viewUsersToolStripMenuItem;
    }
}
