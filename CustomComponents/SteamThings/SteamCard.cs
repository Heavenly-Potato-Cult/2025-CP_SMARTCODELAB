using System.Drawing;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamCard : Panel
    {
        public SteamCard()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(20); // Default padding like p-8
            this.BackColor = Color.Transparent; // Important for transparency
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Graphics Setup
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 1. Define the Rect
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // 2. Fill Background (Simulating bg-secondary/40)
            // We use an alpha value (100) to mimic the /40 opacity
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, SteamColors.SecondaryBg)))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // 3. Draw Border (border-border)
            using (Pen pen = new Pen(SteamColors.Border, 1))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
