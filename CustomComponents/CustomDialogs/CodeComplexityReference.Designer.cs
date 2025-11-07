namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    partial class CodeComplexityReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeComplexityReference));
            referenceCode = new SmartCodeLab.CustomComponents.Pages.ProgrammingTabs.CodeEditor();
            smartButton1 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            smartButton2 = new SmartCodeLab.CustomComponents.GeneralComponents.SmartButton();
            ((System.ComponentModel.ISupportInitialize)referenceCode).BeginInit();
            SuspendLayout();
            // 
            // referenceCode
            // 
            referenceCode.AutoCompleteBracketsList = new char[]
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
            referenceCode.AutoScrollMinSize = new Size(27, 14);
            referenceCode.BackBrush = null;
            referenceCode.CharHeight = 14;
            referenceCode.CharWidth = 8;
            referenceCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            referenceCode.Hotkeys = resources.GetString("referenceCode.Hotkeys");
            referenceCode.IsReplaceMode = false;
            referenceCode.Location = new Point(0, 1);
            referenceCode.Margin = new Padding(3, 2, 3, 2);
            referenceCode.Name = "referenceCode";
            referenceCode.Paddings = new Padding(0);
            referenceCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            referenceCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("referenceCode.ServiceColors");
            referenceCode.Size = new Size(859, 578);
            referenceCode.TabIndex = 0;
            referenceCode.Zoom = 100;
            // 
            // smartButton1
            // 
            smartButton1.BackColor = Color.MediumSlateBlue;
            smartButton1.BorderRadius = 20;
            smartButton1.FlatAppearance.BorderSize = 0;
            smartButton1.FlatStyle = FlatStyle.Flat;
            smartButton1.ForeColor = Color.White;
            smartButton1.Location = new Point(248, 602);
            smartButton1.Margin = new Padding(3, 2, 3, 2);
            smartButton1.Name = "smartButton1";
            smartButton1.Size = new Size(164, 38);
            smartButton1.TabIndex = 1;
            smartButton1.Text = "Cancel";
            smartButton1.UseVisualStyleBackColor = false;
            smartButton1.Click += smartButton1_Click;
            // 
            // smartButton2
            // 
            smartButton2.BackColor = Color.MediumSlateBlue;
            smartButton2.BorderRadius = 20;
            smartButton2.FlatAppearance.BorderSize = 0;
            smartButton2.FlatStyle = FlatStyle.Flat;
            smartButton2.ForeColor = Color.White;
            smartButton2.Location = new Point(429, 602);
            smartButton2.Margin = new Padding(3, 2, 3, 2);
            smartButton2.Name = "smartButton2";
            smartButton2.Size = new Size(164, 38);
            smartButton2.TabIndex = 2;
            smartButton2.Text = "OK";
            smartButton2.UseVisualStyleBackColor = false;
            smartButton2.Click += smartButton2_Click;
            // 
            // CodeComplexityReference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 651);
            Controls.Add(smartButton2);
            Controls.Add(smartButton1);
            Controls.Add(referenceCode);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CodeComplexityReference";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeComplexityReference";
            ((System.ComponentModel.ISupportInitialize)referenceCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Pages.ProgrammingTabs.CodeEditor referenceCode;
        private GeneralComponents.SmartButton smartButton1;
        private GeneralComponents.SmartButton smartButton2;
    }
}