﻿namespace SmartCodeLab.CustomComponents.Pages
{
    partial class MainServerPage2
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
            container = new SmartCodeLab.CustomComponents.GeneralComponents.SmoothTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            panelNavHost2 = new Panel();
            tabPage5 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            sessionLogsDisplay1 = new SmartCodeLab.CustomComponents.ServerPageComponents.SessionLogsDisplay();
            label3 = new Label();
            panel1 = new Panel();
            container.SuspendLayout();
            tabPage5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.Controls.Add(tabPage1);
            container.Controls.Add(tabPage2);
            container.Controls.Add(tabPage3);
            container.Controls.Add(tabPage4);
            container.Controls.Add(tabPage5);
            container.Depth = 0;
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 36);
            container.Margin = new Padding(3, 2, 3, 2);
            container.MouseState = MaterialSkin.MouseState.HOVER;
            container.Multiline = true;
            container.Name = "container";
            container.SelectedIndex = 0;
            container.Size = new Size(1484, 690);
            container.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1476, 662);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1476, 662);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1476, 662);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.AutoScroll = true;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1476, 662);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelNavHost2
            // 
            panelNavHost2.BackColor = Color.FromArgb(42, 46, 53);
            panelNavHost2.Dock = DockStyle.Top;
            panelNavHost2.Location = new Point(0, 0);
            panelNavHost2.Margin = new Padding(0);
            panelNavHost2.Name = "panelNavHost2";
            panelNavHost2.Size = new Size(1484, 36);
            panelNavHost2.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(flowLayoutPanel1);
            tabPage5.Controls.Add(panel1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1476, 662);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(sessionLogsDisplay1);
            flowLayoutPanel1.Location = new Point(480, 126);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(676, 350);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // sessionLogsDisplay1
            // 
            sessionLogsDisplay1.BackColor = Color.FromArgb(240, 247, 255);
            sessionLogsDisplay1.BorderColor = Color.Gray;
            sessionLogsDisplay1.BorderRadius = 20;
            sessionLogsDisplay1.BorderSize = 0;
            sessionLogsDisplay1.Location = new Point(3, 2);
            sessionLogsDisplay1.Margin = new Padding(3, 2, 3, 2);
            sessionLogsDisplay1.Name = "sessionLogsDisplay1";
            sessionLogsDisplay1.Size = new Size(660, 64);
            sessionLogsDisplay1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 13, 13);
            label3.Location = new Point(500, 55);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 14;
            label3.Text = "Session Logs";
            // 
            // panel1
            // 
            panel1.Location = new Point(462, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 376);
            panel1.TabIndex = 15;
            // 
            // MainServerPage2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(container);
            Controls.Add(panelNavHost2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainServerPage2";
            Size = new Size(1484, 726);
            container.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GeneralComponents.SmoothTabControl container;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panelNavHost2;
        private TabPage tabPage5;
        private FlowLayoutPanel flowLayoutPanel1;
        private ServerPageComponents.SessionLogsDisplay sessionLogsDisplay1;
        private Label label3;
        private Panel panel1;
    }
}
