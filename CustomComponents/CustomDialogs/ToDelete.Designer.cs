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
            consoleTextBox1 = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.ConsoleTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).BeginInit();
            SuspendLayout();
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
            consoleTextBox1.AutoScrollMinSize = new Size(749, 19);
            consoleTextBox1.BackBrush = null;
            consoleTextBox1.BackColor = Color.Black;
            consoleTextBox1.CaretColor = Color.White;
            consoleTextBox1.CharHeight = 19;
            consoleTextBox1.CharWidth = 9;
            consoleTextBox1.Cursor = Cursors.IBeam;
            consoleTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            consoleTextBox1.FoldingIndicatorColor = Color.Gold;
            consoleTextBox1.Font = new Font("Consolas", 9.75F);
            consoleTextBox1.ForeColor = Color.White;
            consoleTextBox1.Hotkeys = resources.GetString("consoleTextBox1.Hotkeys");
            consoleTextBox1.IndentBackColor = Color.Black;
            consoleTextBox1.IsReplaceMode = false;
            consoleTextBox1.LineNumberColor = Color.Gold;
            consoleTextBox1.Location = new Point(12, 41);
            consoleTextBox1.Name = "consoleTextBox1";
            consoleTextBox1.PaddingBackColor = Color.Black;
            consoleTextBox1.Paddings = new Padding(0);
            consoleTextBox1.PreferredLineWidth = 80;
            consoleTextBox1.SelectionColor = Color.FromArgb(150, 255, 255, 255);
            consoleTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("consoleTextBox1.ServiceColors");
            consoleTextBox1.ServiceLinesColor = Color.DimGray;
            consoleTextBox1.Size = new Size(713, 342);
            consoleTextBox1.TabIndex = 0;
            consoleTextBox1.WordWrap = true;
            consoleTextBox1.WordWrapMode = FastColoredTextBoxNS.WordWrapMode.CharWrapPreferredWidth;
            consoleTextBox1.Zoom = 100;
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
            // ToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 682);
            Controls.Add(button1);
            Controls.Add(consoleTextBox1);
            Name = "ToDelete";
            Text = "ToDelete";
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Pages.ProgrammingTabs.ConsoleTextBox consoleTextBox1;
        private Button button1;
    }
}