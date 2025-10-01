namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class ToDelete
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDelete));
            button1 = new Button();
            consoleTextBox1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.ConsoleTextBox();
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(202, 462);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // consoleTextBox1
            // 
            consoleTextBox1.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            consoleTextBox1.AutoScrollMinSize = new Size(31, 18);
            consoleTextBox1.BackBrush = null;
            consoleTextBox1.CharHeight = 18;
            consoleTextBox1.CharWidth = 10;
            consoleTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            consoleTextBox1.Font = new Font("Courier New", 9.75F);
            consoleTextBox1.Hotkeys = resources.GetString("consoleTextBox1.Hotkeys");
            consoleTextBox1.IsReplaceMode = false;
            consoleTextBox1.Location = new Point(144, 107);
            consoleTextBox1.Name = "consoleTextBox1";
            consoleTextBox1.Paddings = new Padding(0);
            consoleTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            consoleTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("consoleTextBox1.ServiceColors");
            consoleTextBox1.Size = new Size(500, 188);
            consoleTextBox1.TabIndex = 2;
            consoleTextBox1.Zoom = 100;
            // 
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 682);
            Controls.Add(consoleTextBox1);
            Controls.Add(button1);
            Name = "ToDelete";
            Text = "ToDelete";
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Pages.ProgrammingTabs.ConsoleTextBox consoleTextBox1;
    }
}