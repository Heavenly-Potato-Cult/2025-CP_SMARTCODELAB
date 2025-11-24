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
            flowLayoutPanel_Exercises = new FlowLayoutPanel();
            customTextBox1 = new CustomTextBox();
            subjects = new MaterialSkin.Controls.MaterialComboBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_AddNewExercise);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1801, 127);
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
            btn_AddNewExercise.Location = new Point(1205, 37);
            btn_AddNewExercise.Margin = new Padding(3, 4, 3, 4);
            btn_AddNewExercise.Name = "btn_AddNewExercise";
            btn_AddNewExercise.Size = new Size(213, 52);
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
            label2.Location = new Point(349, 43);
            label2.Name = "label2";
            label2.Size = new Size(238, 38);
            label2.TabIndex = 13;
            label2.Text = "Exercise Explorer";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(1801, 1);
            panel1.TabIndex = 56;
            // 
            // flowLayoutPanel_Exercises
            // 
            flowLayoutPanel_Exercises.AutoScroll = true;
            flowLayoutPanel_Exercises.Location = new Point(349, 269);
            flowLayoutPanel_Exercises.Name = "flowLayoutPanel_Exercises";
            flowLayoutPanel_Exercises.Padding = new Padding(0, 0, 0, 100);
            flowLayoutPanel_Exercises.Size = new Size(1069, 581);
            flowLayoutPanel_Exercises.TabIndex = 59;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.BorderColor = Color.Gray;
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(349, 205);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.PlaceHolderColor = Color.DarkGray;
            customTextBox1.PlaceholderText = "";
            customTextBox1.ScrollBars = ScrollBars.None;
            customTextBox1.Size = new Size(361, 41);
            customTextBox1.TabIndex = 64;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // subjects
            // 
            subjects.AutoResize = false;
            subjects.BackColor = Color.FromArgb(255, 255, 255);
            subjects.Depth = 0;
            subjects.DrawMode = DrawMode.OwnerDrawVariable;
            subjects.DropDownHeight = 118;
            subjects.DropDownStyle = ComboBoxStyle.DropDownList;
            subjects.DropDownWidth = 121;
            subjects.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            subjects.ForeColor = Color.FromArgb(222, 0, 0, 0);
            subjects.FormattingEnabled = true;
            subjects.IntegralHeight = false;
            subjects.ItemHeight = 29;
            subjects.Items.AddRange(new object[] { "All" });
            subjects.Location = new Point(716, 211);
            subjects.Margin = new Padding(3, 4, 3, 4);
            subjects.MaxDropDownItems = 4;
            subjects.MouseState = MaterialSkin.MouseState.OUT;
            subjects.Name = "subjects";
            subjects.Size = new Size(138, 35);
            subjects.StartIndex = 0;
            subjects.TabIndex = 65;
            subjects.UseTallSize = false;
            subjects.SelectedIndexChanged += subjects_SelectedIndexChanged;
            // 
            // TempExerciseManage
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(subjects);
            Controls.Add(customTextBox1);
            Controls.Add(flowLayoutPanel_Exercises);
            Controls.Add(panel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            Name = "TempExerciseManage";
            Size = new Size(1801, 1049);
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
        private FlowLayoutPanel flowLayoutPanel_Exercises;
        private CustomTextBox customTextBox1;
        private MaterialSkin.Controls.MaterialComboBox subjects;
    }
}
