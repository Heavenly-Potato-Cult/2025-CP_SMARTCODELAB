namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    partial class ReadabilityReasons
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadabilityReasons));
            issue = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            description = new AutoResizeTextBox();
            badCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeDisplay();
            goodCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeDisplay();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)badCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodCode).BeginInit();
            SuspendLayout();
            // 
            // issue
            // 
            issue.AutoSize = true;
            issue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issue.ForeColor = Color.FromArgb(13, 13, 13);
            issue.Location = new Point(1, 0);
            issue.Name = "issue";
            issue.Size = new Size(355, 25);
            issue.TabIndex = 1;
            issue.Text = "Multiple Variable Declarations per Line";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(description);
            flowLayoutPanel1.Controls.Add(badCode);
            flowLayoutPanel1.Controls.Add(goodCode);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 339);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // description
            // 
            description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.Location = new Point(3, 3);
            description.Multiline = true;
            description.Name = "description";
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(350, 19);
            description.TabIndex = 0;
            // 
            // badCode
            // 
            badCode.AutoCompleteBracketsList = new char[]
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
            badCode.AutoScrollMinSize = new Size(147, 28);
            badCode.BackBrush = null;
            badCode.CharHeight = 14;
            badCode.CharWidth = 8;
            badCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            badCode.Hotkeys = resources.GetString("badCode.Hotkeys");
            badCode.IsReplaceMode = false;
            badCode.Location = new Point(3, 28);
            badCode.Name = "badCode";
            badCode.Paddings = new Padding(0);
            badCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            badCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("badCode.ServiceColors");
            badCode.Size = new Size(350, 150);
            badCode.TabIndex = 1;
            badCode.Text = "✅ Good Example:\r\n";
            badCode.Zoom = 100;
            // 
            // goodCode
            // 
            goodCode.AutoCompleteBracketsList = new char[]
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
            goodCode.AutoScrollMinSize = new Size(147, 28);
            goodCode.BackBrush = null;
            goodCode.CharHeight = 14;
            goodCode.CharWidth = 8;
            goodCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            goodCode.Hotkeys = resources.GetString("goodCode.Hotkeys");
            goodCode.IsReplaceMode = false;
            goodCode.Location = new Point(3, 184);
            goodCode.Name = "goodCode";
            goodCode.Paddings = new Padding(0);
            goodCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            goodCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("goodCode.ServiceColors");
            goodCode.Size = new Size(353, 150);
            goodCode.TabIndex = 2;
            goodCode.Text = "✅ Good Example:\r\n";
            goodCode.Zoom = 100;
            // 
            // ReadabilityReasons
            // 
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(issue);
            Name = "ReadabilityReasons";
            Size = new Size(365, 370);
            Load += ReadabilityReasons_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)badCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label issue;
        private FlowLayoutPanel flowLayoutPanel1;
        private AutoResizeTextBox description;
        private Pages.ProgrammingTabs.CodeDisplay badCode;
        private Pages.ProgrammingTabs.CodeDisplay goodCode;
    }
}
