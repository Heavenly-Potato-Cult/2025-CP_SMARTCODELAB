using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamStatRow : Control
    {
        // --- PROPERTIES ---

        [Category("Steam Data")]
        [Description("The label text (e.g. ACCURACY)")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelText { get; set; } = "ACCURACY";

        private int _value = 85;
        [Category("Steam Data")]
        [Description("The percentage value (0-100)")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get => _value;
            set
            {
                _value = Math.Max(0, Math.Min(value, 100));
                Invalidate();
            }
        }

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ThemeColor { get; set; } = SteamColors.Accent;

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color InactiveColor { get; set; } = Color.FromArgb(45, 50, 60);

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SegmentCount { get; set; } = 20;

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int GapSize { get; set; } = 2;

        // --- CONSTRUCTOR ---
        public SteamStatRow()
        {
            // 1. THE FIX: Enable Transparent Background Support FIRST
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // 2. Set other styles
            this.SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent; // Now this won't crash!
            this.Size = new Size(300, 45);
        }

        // --- PAINTING ---
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. DRAW TEXT ROW
            int textY = 0;

            // Draw Label (Left)
            using (Font titleFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(120, 130, 140)))
            {
                g.DrawString(LabelText.ToUpper(), titleFont, brush, 0, textY);
            }

            // Draw Value (Right)
            string valStr = $"{Value}%";
            using (Font valFont = SteamFont.GetFont(9F, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(ThemeColor))
            {
                SizeF size = g.MeasureString(valStr, valFont);
                g.DrawString(valStr, valFont, brush, this.Width - size.Width, textY);
            }

            // 2. DRAW SEGMENTED BAR
            int barY = 20;
            int barHeight = this.Height - barY;
            if (barHeight < 4) barHeight = 4;

            float availableWidth = this.Width - ((SegmentCount - 1) * GapSize);
            float blockWidth = availableWidth / SegmentCount;

            float percent = (float)Value / 100f;
            int activeBlocks = (int)Math.Round(percent * SegmentCount);

            g.SmoothingMode = SmoothingMode.None;

            for (int i = 0; i < SegmentCount; i++)
            {
                float x = i * (blockWidth + GapSize);

                // Color Logic
                bool isActive = i < activeBlocks;
                Color blockColor = isActive ? ThemeColor : InactiveColor;

                RectangleF blockRect = new RectangleF(x, barY, blockWidth, barHeight);

                using (SolidBrush brush = new SolidBrush(blockColor))
                {
                    g.FillRectangle(brush, blockRect);
                }
            }
        }
    }
}
