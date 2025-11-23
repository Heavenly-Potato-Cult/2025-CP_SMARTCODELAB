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
        public Color CheckedColor { get; set; } = SteamColors.Accent; // Green
        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color UncheckedColor { get; set; } = Color.FromArgb(100, 110, 120); // Grey Border
        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BgColor { get; set; } = SteamColors.InputBg; // Dark Background

        public SteamCheckBox()
        {
            this.Cursor = Cursors.Hand;
            this.Text = ""; // Clear text so standard layout doesn't freak out

            // 1. Fix Size: Make it a small, perfect square
            this.AutoSize = false;
            this.Size = new Size(24, 24);

            // 2. Transparent Support
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.Transparent;
        }

        // Force the layout engine to treat this as a small square
        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(24, 24);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Calculate Box Position (Centered)
            int boxSize = 16;
            int offset = (this.Height - boxSize) / 2;

            // Ensure box creates a crisp pixel line
            Rectangle boxRect = new Rectangle(offset, offset, boxSize, boxSize);

            // 2. Draw Box Background & Border
            using (SolidBrush bgBrush = new SolidBrush(BgColor))
            using (Pen borderPen = new Pen(UncheckedColor, 1.5f))
            {
                g.FillRectangle(bgBrush, boxRect);
                g.DrawRectangle(borderPen, boxRect);
            }

            // 3. Draw Tick (Only if checked)
            if (this.Checked)
            {
                // Vector coordinates for a nice checkmark
                PointF[] points = new PointF[]
                {
                    new PointF(boxRect.X + 3, boxRect.Y + 8),  // Start (Left)
                    new PointF(boxRect.X + 7, boxRect.Y + 12), // Middle (Bottom)
                    new PointF(boxRect.X + 13, boxRect.Y + 3)  // End (Top Right)
                };

                using (Pen checkPen = new Pen(CheckedColor, 2.0f))
                {
                    g.DrawLines(checkPen, points);
                }
            }

            // NOTE: We intentionally DO NOT draw text here.
        }
    }
}
