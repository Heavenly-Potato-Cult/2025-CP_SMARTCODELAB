using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    [DefaultEvent("CheckedChanged")]
    public class SteamCheckBox : CheckBox
    {
        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CheckedColor { get; set; } = SteamColors.Accent;

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color UncheckedColor { get; set; } = Color.FromArgb(100, 110, 120);

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BgColor { get; set; } = SteamColors.InputBg;

        public SteamCheckBox()
        {
            this.Cursor = Cursors.Hand;
            this.Text = "";
            this.AutoSize = false;
            this.Size = new Size(24, 24);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // FIX 1: Add ResizeRedraw to prevent "ghosting" artifacts when window resizes
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.BackColor = Color.Transparent;
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(24, 24);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 1. Calculate Box Position
            int boxSize = 14; // Slightly smaller to ensure border fits
            int offset = (this.Height - boxSize) / 2;
            Rectangle boxRect = new Rectangle(offset, offset, boxSize, boxSize);

            // FIX 2: Turn OFF AntiAlias for the square box
            // This ensures the border is sharp (pixel-perfect) and corners don't look broken
            g.SmoothingMode = SmoothingMode.None;

            using (SolidBrush bgBrush = new SolidBrush(BgColor))
            using (Pen borderPen = new Pen(UncheckedColor, 1)) // Use integer width (1) for crisp lines
            {
                g.FillRectangle(bgBrush, boxRect);

                // Adjust rect slightly for the border so it sits *inside* the pixels
                // otherwise it spills out and looks clipped
                Rectangle borderRect = new Rectangle(offset, offset, boxSize - 1, boxSize - 1);
                g.DrawRectangle(borderPen, borderRect);
            }

            // 3. Draw Tick
            if (this.Checked)
            {
                // FIX 3: Turn ON AntiAlias ONLY for the checkmark
                // This makes the diagonal lines look smooth, not jagged
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality; // Fixes sub-pixel rendering

                // Adjusted coordinates to center the checkmark perfectly
                PointF[] points = new PointF[]
                {
                    new PointF(offset + 3, offset + 7),   // Start
                    new PointF(offset + 6, offset + 10),  // Middle
                    new PointF(offset + 11, offset + 3)   // End
                };

                using (Pen checkPen = new Pen(CheckedColor, 2.0f))
                {
                    g.DrawLines(checkPen, points);
                }
            }
        }
    }
}