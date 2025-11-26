using System;
using System.Drawing;
using System.Windows.Forms;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamLogBox : ListBox
    {
        public SteamLogBox()
        {
           
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.BackColor = Color.FromArgb(23, 26, 33);
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.IntegralHeight = false;

            this.DrawMode = DrawMode.OwnerDrawVariable;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

      
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.ItemHeight = 35;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count) return;
            if (this.Items[e.Index] is not Notification notification) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle bounds = e.Bounds;

            //  DRAW BACKGROUND (Zebra Striping)
            Color rowColor = (e.Index % 2 == 0)
                ? Color.FromArgb(23, 26, 33)
                : Color.FromArgb(28, 32, 40);

            using (SolidBrush bgBrush = new SolidBrush(rowColor))
            {
                g.FillRectangle(bgBrush, bounds);
            }

            //  DRAW ACCENT STRIP
            Color accentColor = GetColorByType(notification.Type);
            using (SolidBrush accentBrush = new SolidBrush(accentColor))
            {
                g.FillRectangle(accentBrush, bounds.X, bounds.Y, 4, bounds.Height);
            }

            // --- TEXT LAYOUT ---
            int x = bounds.X + 12;
            int y = bounds.Y + 8;

            //  TIMESTAMP 
            string timeStr = $"[{notification.timeOccurred:hh:mm tt}]";

            
            using (Font timeFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush timeBrush = new SolidBrush(Color.FromArgb(100, 110, 120)))
            {
                g.DrawString(timeStr, timeFont, timeBrush, x, y);
                x += (int)g.MeasureString(timeStr, timeFont).Width + 5;
            }

            // USERNAME 
            using (Font nameFont = SteamFont.GetFont(9F, FontStyle.Bold))
            using (SolidBrush nameBrush = new SolidBrush(Color.White))
            {
                g.DrawString(notification.UserName, nameFont, nameBrush, x, y);
                x += (int)g.MeasureString(notification.UserName, nameFont).Width;
            }

            // SEPARATOR
            using (Font sepFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush sepBrush = new SolidBrush(Color.Gray))
            {
                string sep = " : ";
                g.DrawString(sep, sepFont, sepBrush, x, y);
                x += (int)g.MeasureString(sep, sepFont).Width;
            }

            // MESSAGE
            using (Font msgFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush msgBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            {
                int maxMsgWidth = bounds.Width - x - 5;
                RectangleF msgRect = new RectangleF(x, y, maxMsgWidth, bounds.Height);
                StringFormat format = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };

                g.DrawString(notification.Message, msgFont, msgBrush, msgRect, format);
            }
        }

        private Color GetColorByType(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.CopyPasted: return Color.FromArgb(255, 70, 70);
                case NotificationType.Submitted: return Color.FromArgb(80, 200, 80);
                case NotificationType.TestResult: return Color.FromArgb(255, 200, 0);
                case NotificationType.LoggedIn: return Color.FromArgb(60, 150, 255);
                case NotificationType.ExceptionThrown: return Color.FromArgb(255, 70, 70);
                default: return Color.Gray;
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.ClearSelected();
        }
    }
}