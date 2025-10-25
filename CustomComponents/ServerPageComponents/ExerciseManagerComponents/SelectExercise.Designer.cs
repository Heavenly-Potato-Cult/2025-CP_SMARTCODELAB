namespace SmartCodeLab.CustomComponents.ServerPageComponents.ExerciseManagerComponents
{
    partial class SelectExercise
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchBox = new CustomTextBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(445, 529);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = SystemColors.Window;
            searchBox.ForeColor = Color.DimGray;
            searchBox.Location = new Point(12, 8);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 7, 10, 7);
            searchBox.PlaceHolderColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search Text Box";
            searchBox.ScrollBars = ScrollBars.None;
            searchBox.Size = new Size(285, 41);
            searchBox.TabIndex = 1;
            searchBox._TextChanged += searchBox__TextChanged;
            // 
            // SelectExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 596);
            Controls.Add(searchBox);
            Controls.Add(flowLayoutPanel1);
            Name = "SelectExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectExercise";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CustomTextBox searchBox;
    }
}