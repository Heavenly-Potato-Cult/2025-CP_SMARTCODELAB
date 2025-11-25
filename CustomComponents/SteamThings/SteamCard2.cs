using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamCard2 : Panel
    {
        // --- CONSTRUCTOR ---
        public SteamCard2()
        {
            // Optimization settings for smooth rendering
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redraw gradient when size changes
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Default padding for content inside
            this.Padding = new Padding(15);
            this.BackColor = Color.Transparent; // Important for the corners
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Define the Colors based on your Tailwind prompt
            // "from-secondary/40" -> Secondary #2a475e at 40% Opacity
            // Alpha: 255 * 0.40 = 102
            Color startColor = Color.FromArgb(102, 42, 71, 94);

            // "via-primary/60" -> Primary #1b2838 at 60% Opacity
            // Alpha: 255 * 0.60 = 153
            Color midColor = Color.FromArgb(153, 27, 40, 56);

            // "to-[#0f1419]" -> Solid Deep Gunmetal
            Color endColor = ColorTranslator.FromHtml("#0f1419");

            // 2. Create the Multi-Stop Gradient
            Rectangle rect = this.ClientRectangle;

            if (rect.Width == 0 || rect.Height == 0) return; // Guard clause against minimize crash

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.Black, Color.Black, 45f)) // 45 degrees = Top-Left to Bottom-Right
            {
                // Create the blend of 3 colors
                ColorBlend blend = new ColorBlend();

                // The Colors
                blend.Colors = new Color[] { startColor, midColor, endColor };

                // The Positions (0.0 = Start, 0.5 = Middle, 1.0 = End)
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };

                brush.InterpolationColors = blend;

                // 3. Draw the Card Background
                // We define a slight curve (Radius 4) for a modern look
                using (GraphicsPath path = GetRoundedPath(rect, 4))
                {
                    g.FillPath(brush, path);

                    // 4. Draw Subtle Border (Glass Effect)
                    // A faint white border helps separating it from the dark background
                    using (Pen borderPen = new Pen(Color.FromArgb(30, 255, 255, 255), 1))
                    {
                        g.DrawPath(borderPen, path);
                    }
                }
            }
        }

        // Helper for Rounded Corners
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            // Top Left
            path.AddArc(arc, 180, 90);

            // Top Right
            arc.X = rect.Right - diameter - 1; // -1 for pixel adjustment
            path.AddArc(arc, 270, 90);

            // Bottom Right
            arc.Y = rect.Bottom - diameter - 1;
            path.AddArc(arc, 0, 90);

            // Bottom Left
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
