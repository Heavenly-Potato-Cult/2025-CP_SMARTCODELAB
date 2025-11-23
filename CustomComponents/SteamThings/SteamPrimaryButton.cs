using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamPrimaryButton : Button
    {
        public SteamPrimaryButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(200, 50);
            this.Cursor = Cursors.Hand;
            this.Font = SteamFont.GetFont(12F, FontStyle.Bold);
            this.Text = "▶ START SESSION";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Colors
            Color bgColor = this.IsMouseOver() ? Color.FromArgb(200, SteamColors.Accent) : SteamColors.Accent;
            Color textColor = Color.Black; // accent-foreground is #0b0e11 (near black)

            // 1. Draw Button Background
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (SolidBrush brush = new SolidBrush(bgColor))
            {
                g.FillRectangle(brush, rect);
            }

            // 2. Draw Glow/Shadow Effect (Simulated)
            // CSS: boxShadow: "0 0 20px rgba(26, 191, 32, 0.5)"
            if (this.IsMouseOver())
            {
                using (Pen glowPen = new Pen(Color.FromArgb(100, SteamColors.Accent), 4))
                {
                    g.DrawRectangle(glowPen, 2, 2, this.Width - 4, this.Height - 4);
                }
            }

            // 3. Draw Text
            TextRenderer.DrawText(g, this.Text, this.Font, rect, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Helper to detect hover state without extra boolean flags
        private bool IsMouseOver()
        {
            return this.ClientRectangle.Contains(this.PointToClient(Cursor.Position));
        }
    }
}
