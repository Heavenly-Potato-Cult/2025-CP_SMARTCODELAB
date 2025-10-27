namespace SmartCodeLab.CustomComponents.Pages
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
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.Controls.Add(tabPage1);
            container.Controls.Add(tabPage2);
            container.Controls.Add(tabPage3);
            container.Controls.Add(tabPage4);
            container.Depth = 0;
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 36);
            container.Margin = new Padding(3, 2, 3, 2);
            container.MouseState = MaterialSkin.MouseState.HOVER;
            container.Multiline = true;
            container.Name = "container";
            container.SelectedIndex = 0;
            container.Size = new Size(1476, 671);
            container.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1468, 643);
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
            tabPage2.Size = new Size(1468, 643);
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
            tabPage3.Size = new Size(1468, 643);
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
            tabPage4.Size = new Size(1468, 643);
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
            panelNavHost2.Size = new Size(1476, 36);
            panelNavHost2.TabIndex = 2;
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
            Size = new Size(1476, 707);
            container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GeneralComponents.SmoothTabControl container;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panelNavHost2;
    }
}
