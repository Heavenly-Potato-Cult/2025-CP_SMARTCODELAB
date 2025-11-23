namespace SmartCodeLab.CustomComponents
{
    partial class CodeEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditorControl));
            scintilla = new ScintillaNET.Scintilla();
            statusStrip1 = new StatusStrip();
            lblLine = new ToolStripStatusLabel();
            lblColumn = new ToolStripStatusLabel();
            ddbZoom = new ToolStripDropDownButton();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scintilla
            // 
            scintilla.AutocompleteListSelectedBackColor = Color.FromArgb(0, 120, 215);
            scintilla.Dock = DockStyle.Fill;
            scintilla.LexerName = null;
            scintilla.Location = new Point(0, 0);
            scintilla.Margin = new Padding(0);
            scintilla.Name = "scintilla";
            scintilla.ScrollWidth = 57;
            scintilla.Size = new Size(675, 394);
            scintilla.TabIndex = 0;
            scintilla.Text = "scintilla1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ddbZoom, lblLine, lblColumn });
            statusStrip1.Location = new Point(0, 394);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(675, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblLine
            // 
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(39, 20);
            lblLine.Text = "Ln: 1";
            // 
            // lblColumn
            // 
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(46, 20);
            lblColumn.Text = "Col: 1";
            // 
            // ddbZoom
            // 
            ddbZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ddbZoom.Image = (Image)resources.GetObject("ddbZoom.Image");
            ddbZoom.ImageTransparentColor = Color.Magenta;
            ddbZoom.Name = "ddbZoom";
            ddbZoom.Size = new Size(34, 24);
            ddbZoom.Text = "100%";
            // 
            // CodeEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scintilla);
            Controls.Add(statusStrip1);
            Name = "CodeEditorControl";
            Size = new Size(675, 420);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScintillaNET.Scintilla scintilla;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLine;
        private ToolStripStatusLabel lblColumn;
        private ToolStripDropDownButton ddbZoom;
    }
}
