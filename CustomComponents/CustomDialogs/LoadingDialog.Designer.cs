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
            label1 = new Label();
            loader = new Label();
            smartButton1 = new SmartButton();
            serverContainer = new FlowLayoutPanel();
            picturebox_loadingGIF = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturebox_loadingGIF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Temporary Loading Dialog";
            // 
            // loader
            // 
            loader.AutoSize = true;
            loader.Location = new Point(71, 47);
            loader.Name = "loader";
            loader.Size = new Size(119, 20);
            loader.TabIndex = 1;
            loader.Text = "Searching Server";
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Crimson;
            smartButton1.BackgroundColor = Color.Crimson;
            smartButton1.BorderRadius = 10;
            smartButton1.Cursor = Cursors.Hand;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(95, 80);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(144, 35);
            smartButton1.TabIndex = 2;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // serverContainer
            // 
            serverContainer.AutoScroll = true;
            serverContainer.FlowDirection = FlowDirection.TopDown;
            serverContainer.Location = new Point(8, 121);
            serverContainer.Name = "serverContainer";
            serverContainer.Size = new Size(305, 332);
            serverContainer.TabIndex = 3;
            serverContainer.WrapContents = false;
            // 
            // picturebox_loadingGIF
            // 
            picturebox_loadingGIF.BackColor = Color.Silver;
            picturebox_loadingGIF.Image = (Image)resources.GetObject("picturebox_loadingGIF.Image");
            picturebox_loadingGIF.Location = new Point(273, 31);
            picturebox_loadingGIF.Name = "picturebox_loadingGIF";
            picturebox_loadingGIF.Size = new Size(145, 122);
            picturebox_loadingGIF.TabIndex = 5;
            picturebox_loadingGIF.TabStop = false;
            // 
            // LoadingDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 465);
            Controls.Add(picturebox_loadingGIF);
            Controls.Add(serverContainer);
            Controls.Add(smartButton1);
            Controls.Add(loader);
            Controls.Add(label1);
            Name = "LoadingDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Current Loading Dialog";
            ((System.ComponentModel.ISupportInitialize)picturebox_loadingGIF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label loader;
        private SmartButton smartButton1;
        private FlowLayoutPanel serverContainer;
        private PictureBox picturebox_loadingGIF;
    }
}