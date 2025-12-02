using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SoloTickBox : CheckBox
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.Gray;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TickColor { get; set; } = Color.White;

        public SoloTickBox()
        {
            // Crucial: Turn off AutoSize so you can stretch it
            this.AutoSize = false;
            this.Text = ""; // We don't need text
            this.Size = new Size(30, 30); // Default starter size
            this.Cursor = Cursors.Hand;

            // Reduce flickering
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Draw Background (using the control's BackColor)
            using (var brush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }

            // 2. Draw Border (Uses the full size of the control)
            // We subtract a few pixels to ensure the thick border doesn't get clipped
            int penWidth = 2;
            Rectangle borderRect = new Rectangle(
                penWidth / 2,
                penWidth / 2,
                this.Width - penWidth - 1,
                this.Height - penWidth - 1
            );

            using (var pen = new Pen(BorderColor, penWidth))
            {
                g.DrawRectangle(pen, borderRect);
            }

            // 3. Draw the "Tick" (Checkmark) if checked
            if (this.Checked)
            {
                using (var pen = new Pen(TickColor, 3)) // Thickness of the tick
                {
                    // Create points for a "V" shape checkmark
                    // These percentages ensure it looks good at any size (10px or 100px)
                    Point p1 = new Point((int)(this.Width * 0.2), (int)(this.Height * 0.5)); // Left
                    Point p2 = new Point((int)(this.Width * 0.45), (int)(this.Height * 0.75)); // Bottom Middle
                    Point p3 = new Point((int)(this.Width * 0.8), (int)(this.Height * 0.25)); // Top Right

                    g.DrawLines(pen, new Point[] { p1, p2, p3 });
                }
            }
        }
    }
}
