using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SmartCodeLab.Models;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamChatBox : ListBox
    {
        public SteamChatBox()
        {
            
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.BackColor = Color.FromArgb(23, 26, 33);
            this.BorderStyle = BorderStyle.None;
            this.IntegralHeight = false;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count) return;

            if (this.Items[e.Index] is not UserMessage msg)
            {
                e.ItemHeight = 20;
                return;
            }

            
            int maxTextWidth = (this.Width * 70) / 100;
            Font font = this.Font ?? SystemFonts.DefaultFont;

            Size size = TextRenderer.MeasureText(msg.message, font, new Size(maxTextWidth, 0), TextFormatFlags.WordBreak);
            if (maxTextWidth < 10) maxTextWidth = 100; 


            e.ItemHeight = size.Height + 50;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count) return;
            if (this.Items[e.Index] is not UserMessage msg) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            
            using (SolidBrush bg = new SolidBrush(this.BackColor))
                g.FillRectangle(bg, e.Bounds);

            int maxBubbleWidth = (this.Width * 70) / 100;
            Font font = this.Font ?? SystemFonts.DefaultFont;

           
            Size textSize = TextRenderer.MeasureText(g, msg.message, font, new Size(maxBubbleWidth, 0), TextFormatFlags.WordBreak);

            int bubbleWidth = textSize.Width + 24; 
            int bubbleHeight = textSize.Height + 16; 

            
            int bubbleX;
            Color bubbleColor;
            Color textColor = Color.White;
            string headerText;
            StringAlignment align;

            if (msg.IsBroadcast)
            {
                
                bubbleColor = Color.FromArgb(180, 80, 0);
                bubbleX = e.Bounds.Left + 10;
                headerText = "📢 BROADCAST";
                align = StringAlignment.Near;
            }
            else if (msg.isFromMe)
            {
                
                bubbleColor = SteamColors.Accent;
                bubbleX = e.Bounds.Right - bubbleWidth - 15;
                headerText = "Me";
                align = StringAlignment.Far; 
                textColor = Color.Black; 
            }
            else
            {
                
                bubbleColor = Color.FromArgb(40, 45, 55);
                bubbleX = e.Bounds.Left + 15; 
                headerText = msg.senderName ?? "User";
                align = StringAlignment.Near;
                textColor = Color.White;
            }

            // --- DRAWING ---

            // name
            
            using (Font headFont = SteamFont.GetFont(8F, FontStyle.Bold))
            using (SolidBrush headBrush = new SolidBrush(Color.Gray))
            {
                // Calculate Header X
                int headX = (align == StringAlignment.Far)
                    ? (e.Bounds.Right - 15 - (int)g.MeasureString(headerText, headFont).Width)
                    : (bubbleX + 2);

                g.DrawString(headerText, headFont, headBrush, headX, e.Bounds.Y + 4);
            }

            //  Bubble Background
            Rectangle bubbleRect = new Rectangle(bubbleX, e.Bounds.Y + 20, bubbleWidth, bubbleHeight);

            using (SolidBrush brush = new SolidBrush(bubbleColor))
            using (GraphicsPath path = GetRoundedPath(bubbleRect, 8))
            {
                g.FillPath(brush, path);
            }

            //  Message Text
            Rectangle textRect = new Rectangle(bubbleX + 12, e.Bounds.Y + 20 + 8, textSize.Width, textSize.Height);

            TextFormatFlags flags = TextFormatFlags.WordBreak | TextFormatFlags.Left;
            TextRenderer.DrawText(g, msg.message, font, textRect, textColor, flags);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }



        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.ClearSelected();
        }
    }
}
