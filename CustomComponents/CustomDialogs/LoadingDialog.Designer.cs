using SmartCodeLab.CustomComponents.GeneralComponents;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class LoadingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingDialog));
            loader = new Label();
            smartButton1 = new SmartButton();
            serverContainer = new FlowLayoutPanel();
            picturebox_loadingGIF = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picturebox_loadingGIF).BeginInit();
            SuspendLayout();
            // 
            // loader
            // 
            loader.AutoSize = true;
            loader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loader.Location = new Point(84, 32);
            loader.Name = "loader";
            loader.Size = new Size(234, 32);
            loader.TabIndex = 1;
            loader.Text = "Searching For Server";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Crimson;
            smartButton1.BackgroundColor = Color.Crimson;
            smartButton1.BorderRadius = 10;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(131, 259);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(140, 37);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // serverContainer
            // 
            serverContainer.AutoScroll = true;
            serverContainer.FlowDirection = FlowDirection.TopDown;
            serverContainer.Location = new Point(68, 117);
            serverContainer.Margin = new Padding(3, 2, 3, 2);
            serverContainer.Name = "serverContainer";
            serverContainer.Size = new Size(267, 84);
            serverContainer.TabIndex = 3;
            serverContainer.WrapContents = false;
            // 
            // picturebox_loadingGIF
            // 
            picturebox_loadingGIF.BackColor = SystemColors.Control;
            picturebox_loadingGIF.Image = (Image)resources.GetObject("picturebox_loadingGIF.Image");
            picturebox_loadingGIF.Location = new Point(138, 103);
            picturebox_loadingGIF.Margin = new Padding(3, 2, 3, 2);
            picturebox_loadingGIF.Name = "picturebox_loadingGIF";
            picturebox_loadingGIF.Size = new Size(127, 126);
            picturebox_loadingGIF.TabIndex = 5;
            picturebox_loadingGIF.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 391);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 1);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 390);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(401, 1);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 390);
            panel4.TabIndex = 7;
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 392);
            Controls.Add(smartButton1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(picturebox_loadingGIF);
            Controls.Add(serverContainer);
            Controls.Add(loader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoadingDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Current Loading Dialog";
            ((System.ComponentModel.ISupportInitialize)picturebox_loadingGIF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loader;
        private SmartButton smartButton1;
        private FlowLayoutPanel serverContainer;
        private PictureBox picturebox_loadingGIF;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}