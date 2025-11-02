namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    partial class TempExerciseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempExerciseManage));
            panel3 = new Panel();
            btn_AddNewExercise = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            label2 = new Label();
            panel1 = new Panel();
            smartButton4 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            flowLayoutPanel_Exercises = new FlowLayoutPanel();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            customTextBox1 = new CustomTextBox();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_AddNewExercise);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1576, 95);
            panel3.TabIndex = 55;
            // 
            // btn_AddNewExercise
            // 
            btn_AddNewExercise.Anchor = AnchorStyles.None;
            btn_AddNewExercise.BackColor = SystemColors.Highlight;
            btn_AddNewExercise.BackgroundColor = SystemColors.Highlight;
            btn_AddNewExercise.BorderRadius = 10;
            btn_AddNewExercise.FlatAppearance.BorderSize = 0;
            btn_AddNewExercise.FlatStyle = FlatStyle.Flat;
            btn_AddNewExercise.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddNewExercise.ForeColor = Color.White;
            btn_AddNewExercise.Image = (Image)resources.GetObject("btn_AddNewExercise.Image");
            btn_AddNewExercise.Location = new Point(1054, 28);
            btn_AddNewExercise.Name = "btn_AddNewExercise";
            btn_AddNewExercise.Size = new Size(186, 39);
            btn_AddNewExercise.TabIndex = 57;
            btn_AddNewExercise.Text = "Add New Exercise";
            btn_AddNewExercise.TextAlign = ContentAlignment.MiddleRight;
            btn_AddNewExercise.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddNewExercise.UseVisualStyleBackColor = false;
            btn_AddNewExercise.Click += btn_AddNewExercise_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 13, 13);
            label2.Location = new Point(305, 32);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 13;
            label2.Text = "Exercise Manager";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1576, 1);
            panel1.TabIndex = 56;
            // 
            // smartButton4
            // 
            smartButton4.BackColor = SystemColors.Highlight;
            smartButton4.BackgroundColor = SystemColors.Highlight;
            smartButton4.BorderRadius = 10;
            smartButton4.FlatAppearance.BorderSize = 0;
            smartButton4.FlatStyle = FlatStyle.Flat;
            smartButton4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton4.ForeColor = Color.White;
            smartButton4.Location = new Point(305, 110);
            smartButton4.Name = "smartButton4";
            smartButton4.Size = new Size(137, 39);
            smartButton4.TabIndex = 58;
            smartButton4.Text = "All Exercises";
            smartButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_Exercises
            // 
            flowLayoutPanel_Exercises.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel_Exercises.AutoScroll = true;
            flowLayoutPanel_Exercises.Location = new Point(305, 202);
            flowLayoutPanel_Exercises.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel_Exercises.Name = "flowLayoutPanel_Exercises";
            flowLayoutPanel_Exercises.Padding = new Padding(0, 0, 0, 75);
            flowLayoutPanel_Exercises.Size = new Size(935, 436);
            flowLayoutPanel_Exercises.TabIndex = 59;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.Gainsboro;
            smartButton1.BackgroundColor = Color.Gainsboro;
            smartButton1.BorderRadius = 10;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smartButton1.ForeColor = Color.DimGray;
            smartButton1.Location = new Point(448, 110);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(104, 39);
            smartButton1.TabIndex = 63;
            smartButton1.Text = "By Class";
            smartButton1.TextColor = Color.DimGray;
            smartButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            smartButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Gray;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(305, 154);
            customTextBox1.Margin = new Padding(3, 2, 3, 2);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(9, 5, 9, 5);
            customTextBox1.PlaceHolderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.ScrollBars = ScrollBars.None;
            customTextBox1.Size = new Size(692, 32);
            customTextBox1.TabIndex = 64;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 118;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 29;
            materialComboBox1.Location = new Point(1018, 154);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 35);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 65;
            materialComboBox1.UseTallSize = false;
            // 
            // TempExerciseManage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialComboBox1);
            Controls.Add(customTextBox1);
            Controls.Add(smartButton1);
            Controls.Add(smartButton4);
            Controls.Add(flowLayoutPanel_Exercises);
            Controls.Add(panel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TempExerciseManage";
            Size = new Size(1576, 787);
            Load += TempExerciseManage_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private GeneralComponents.SmartButton btn_AddNewExercise;
        private Panel panel1;
        private GeneralComponents.SmartButton smartButton4;
        private FlowLayoutPanel flowLayoutPanel_Exercises;
        private GeneralComponents.SmartButton smartButton1;
        private CustomTextBox customTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}
