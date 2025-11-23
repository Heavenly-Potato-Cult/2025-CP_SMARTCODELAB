using System;
using System.Drawing;
using System.Windows.Forms;
using ScintillaNET; // Make sure this is using the Scintilla5.NET namespace
using System.Linq; // Add this for OrderByDescending

namespace SmartCodeLab.CustomComponents
{
    public partial class CodeEditorControl : UserControl
    {
        private int maxLineNumberCharLength;

        public CodeEditorControl()  
        {
            InitializeComponent();

            if (this.scintilla == null) { /* ... error handling ... */ }

            // --- Apply the custom dark theme to the StatusStrip ---
            // This MUST be called before other setup
            statusStrip1.Renderer = new DarkThemeRenderer();

            // --- Run all our setup methods ---
            SetupEditorStyles();
            SetupJavaSyntax();
            SetupLineNumbers();
            //SetupCodeFolding();
            SetupZoomDropDown();

            // --- CONNECT INTERNAL EVENTS TO HANDLERS ---
            scintilla.UpdateUI += scintilla_UpdateUI_UpdateStatus;
            scintilla.ZoomChanged += scintilla_InternalZoomChanged;
        }

        #region Setup Methods

        private void SetupEditorStyles()
        {
            // --- GENERAL STYLES ---
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 12;
            scintilla.Styles[Style.Default].BackColor = Color.FromArgb(255, 30, 30, 30);
            scintilla.Styles[Style.Default].ForeColor = Color.FromArgb(255, 220, 220, 220);
            scintilla.StyleClearAll();

            // --- CARET (Cursor) ---
            scintilla.CaretForeColor = Color.White;
            scintilla.CaretLineBackColor = Color.FromArgb(255, 40, 40, 40);

            // --- SELECTION ---
            scintilla.SelectionBackColor = Color.FromArgb(255, 60, 60, 100);

           
            scintilla.Margins[1].Width = 30;
           

            // --- STYLE STATUS STRIP LABELS ---
            var lightGray = Color.FromArgb(255, 220, 220, 220);
            if (this.ddbZoom != null)
                this.ddbZoom.ForeColor = lightGray;
            if (this.lblLine != null)
                this.lblLine.ForeColor = lightGray;
            if (this.lblColumn != null)
                this.lblColumn.ForeColor = lightGray;
        }

        private void SetupJavaSyntax()
        {
            scintilla.LexerName = "cpp";
            string javaKeywords = "abstract continue for new switch assert default goto package synchronized " +
                                  "boolean do if private this break double implements protected throw " +
                                  "byte else import public throws case enum instanceof return transient " +
                                  "catch extends int short try char final interface static void " +
                                  "class finally long strictfp volatile const float native super while";
            scintilla.SetKeywords(0, javaKeywords);
            scintilla.Styles[Style.Cpp.Number].ForeColor = Color.FromArgb(255, 181, 206, 168);
            scintilla.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(255, 86, 156, 214);
            scintilla.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(255, 214, 157, 133);
            scintilla.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(255, 106, 153, 85);
            scintilla.Styles[Style.Cpp.CommentDoc].ForeColor = Color.FromArgb(255, 106, 153, 85);
        }

        private void SetupLineNumbers()
        {
            scintilla.Margins[0].Type = MarginType.Number;
            scintilla.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 45, 45, 45);
            scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);
            scintilla_TextChanged_AutoResize(this, null);
            scintilla.TextChanged += scintilla_TextChanged_AutoResize;
        }

        /// <summary>
        /// Configures the editor to support code folding (collapsible blocks).
        /// </summary>
        private void SetupCodeFolding()
        {
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");

            // --- Configure Margin 2 for folding ---
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 40;
            //scintilla.Margins[2].BackColor = Color.FromArgb(255, 45, 45, 45);



            // --- Define the folding markers (the + and - boxes) ---
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;

            // --- Set marker colors ---
            Color backColor = Color.FromArgb(255, 45, 45, 45);
            Color foreColor = Color.FromArgb(255, 220, 220, 220);
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintilla.Markers[i].SetBackColor(backColor);
                scintilla.Markers[i].SetForeColor(foreColor);
            }

            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
        }

        private void SetupZoomDropDown()
        {
            ddbZoom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            int[] zoomLevels = { 50, 75, 90, 100, 125, 150, 200, 400 };

            foreach (int level in zoomLevels)
            {
                var item = new ToolStripMenuItem($"{level}%");
                item.Click += (sender, e) =>
                {
                    int percent = int.Parse(((ToolStripMenuItem)sender).Text.Replace("%", ""));
                    scintilla.Zoom = (percent - 100) / 10;
                };
                ddbZoom.DropDownItems.Add(item);
            }
        }

        #endregion

        #region Event Handlers

        private void scintilla_TextChanged_AutoResize(object sender, EventArgs e)
        {
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void scintilla_UpdateUI_UpdateStatus(object sender, UpdateUIEventArgs e)
        {
            int pos = scintilla.CurrentPosition;
            int line = scintilla.LineFromPosition(pos) + 1;
            int col = scintilla.GetColumn(pos) + 1;

            lblLine.Text = $"Ln: {line}";
            lblColumn.Text = $"Col: {col}";
        }

        private void scintilla_InternalZoomChanged(object sender, EventArgs e)
        {
            int zoomPercent = 100 + (scintilla.Zoom * 10);
            ddbZoom.Text = $"{zoomPercent}%";
        }

        #endregion
    }

    // --- CLASS TO FIX THE STATUSSTRIP COLOR ---
    // This class forces the StatusStrip to use our custom dark colors
    public class DarkThemeRenderer : ToolStripProfessionalRenderer
    {
        private Color backColor = Color.FromArgb(255, 30, 30, 30);

        public DarkThemeRenderer() : base(new DarkColors()) { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // Do nothing to prevent drawing a border
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.AffectedBounds);
            }
        }

        private class DarkColors : ProfessionalColorTable
        {
            private Color backColor = Color.FromArgb(255, 30, 30, 30);
            private Color selectColor = Color.FromArgb(255, 60, 60, 100);

            public override Color ToolStripDropDownBackground { get { return backColor; } }
            public override Color MenuBorder { get { return backColor; } }
            public override Color MenuItemBorder { get { return selectColor; } }
            public override Color MenuItemSelected { get { return selectColor; } }
            public override Color ImageMarginGradientBegin { get { return backColor; } }
            public override Color ImageMarginGradientMiddle { get { return backColor; } }
            public override Color ImageMarginGradientEnd { get { return backColor; } }
        }
    }
}