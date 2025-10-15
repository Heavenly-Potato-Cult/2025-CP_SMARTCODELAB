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
            loader.Location = new Point(86, 43);
            loader.Name = "loader";
            loader.Size = new Size(289, 41);
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
            smartButton1.Location = new Point(148, 361);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(160, 49);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // serverContainer
            // 
            serverContainer.AutoScroll = true;
            serverContainer.FlowDirection = FlowDirection.TopDown;
            serverContainer.Location = new Point(86, 227);
            serverContainer.Name = "serverContainer";
            serverContainer.Size = new Size(305, 112);
            serverContainer.TabIndex = 3;
            serverContainer.WrapContents = false;
            // 
            // picturebox_loadingGIF
            // 
            picturebox_loadingGIF.BackColor = SystemColors.Control;
            picturebox_loadingGIF.Image = (Image)resources.GetObject("picturebox_loadingGIF.Image");
            picturebox_loadingGIF.Location = new Point(163, 91);
            picturebox_loadingGIF.Name = "picturebox_loadingGIF";
            picturebox_loadingGIF.Size = new Size(145, 130);
            picturebox_loadingGIF.TabIndex = 5;
            picturebox_loadingGIF.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 1);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 521);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(459, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 521);
            panel4.TabIndex = 7;
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 523);
            Controls.Add(smartButton1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(picturebox_loadingGIF);
            Controls.Add(serverContainer);
            Controls.Add(loader);
            FormBorderStyle = FormBorderStyle.None;
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