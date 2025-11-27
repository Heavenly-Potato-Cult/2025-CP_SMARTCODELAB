using System;
using System.Drawing;
using System.Windows.Forms;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamLogBox : ListBox
    {
        private SteamScrollBar _externalScrollBar;
        public SteamLogBox()
        {
           
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.BackColor = Color.FromArgb(23, 26, 33);
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.IntegralHeight = false;

            this.DrawMode = DrawMode.OwnerDrawVariable;
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        
        public SteamScrollBar ExternalScrollBar
        {
            get => _externalScrollBar;
            set
            {
                _externalScrollBar = value;
                if (_externalScrollBar != null)
                {
                    // Wiring: When ScrollBar moves, scroll the ListBox
                    _externalScrollBar.Scroll += (s, e) =>
                    {
                        if (this.Items.Count > 0)
                        {
                            this.TopIndex = _externalScrollBar.Value;
                        }
                    };
                    UpdateScrollbar();
                }
            }
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;

        //        // 1. Keep the Flicker Fix (Safe for Designer)
        //        // WS_EX_COMPOSITED (0x02000000) helps text rendering
        //        cp.ExStyle |= 0x02000000;

        //        // 2. HIDE SCROLLBAR (Runtime Only)
        //        // We check LicenseManager because 'this.DesignMode' is often false in the constructor
        //        if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
        //        {
        //            // Remove WS_VSCROLL (0x00200000)
        //            // Only do this when the app is running!
        //            cp.Style = cp.Style & ~0x00200000;
        //        }
                
        //        return cp;
        //    }
        //}
        protected override void OnResize(EventArgs e) { base.OnResize(e); UpdateScrollbar(); }
        protected override void OnDataSourceChanged(EventArgs e) { base.OnDataSourceChanged(e); UpdateScrollbar(); }

      
        public new void Invalidate()
        {
            base.Invalidate();
            UpdateScrollbar(); 
        }

       
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
           
            int delta = -e.Delta / 120; // Direction
            if (_externalScrollBar != null)
            {
                _externalScrollBar.Value += delta;
            }
        }

        private void UpdateScrollbar()
        {
            if (_externalScrollBar == null) return;

        

            int visibleItems = this.ClientSize.Height / this.ItemHeight;
            _externalScrollBar.Maximum = this.Items.Count;
            _externalScrollBar.LargeChange = visibleItems;

           
            if (this.TopIndex >= 0)
            {
                _externalScrollBar.Value = this.TopIndex;
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
            e.ItemHeight = 40;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count) return;
            if (this.Items[e.Index] is not Notification notification) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle bounds = e.Bounds;

            // Background
            Color rowColor = (e.Index % 2 == 0) ? Color.FromArgb(23, 26, 33) : Color.FromArgb(28, 32, 40);
            using (SolidBrush bgBrush = new SolidBrush(rowColor)) g.FillRectangle(bgBrush, bounds);

            // Strip
            Color accentColor = GetColorByType(notification.Type);
            using (SolidBrush accentBrush = new SolidBrush(accentColor)) g.FillRectangle(accentBrush, bounds.X, bounds.Y, 4, bounds.Height);

            // --- LAYOUT LOGIC ---

            StringFormat centerFormat = new StringFormat
            {
                LineAlignment = StringAlignment.Center, // Vertical Center
                Alignment = StringAlignment.Near,       // Left Align
                FormatFlags = StringFormatFlags.NoWrap
            };

            float currentX = bounds.X + 12;

            //  TIMESTAMP
            string timeStr = $"[{notification.timeOccurred:hh:mm tt}]";
            using (Font timeFont = SteamFont.GetFont(9F, FontStyle.Regular, "Geist Mono"))
            using (SolidBrush timeBrush = new SolidBrush(Color.FromArgb(100, 110, 120)))
            {
                
                SizeF size = g.MeasureString(timeStr, timeFont);

                RectangleF timeRect = new RectangleF(currentX, bounds.Y, size.Width + 10, bounds.Height);
                g.DrawString(timeStr, timeFont, timeBrush, timeRect, centerFormat);

                // Move X by the REAL drawn width
                currentX += size.Width;
            }

            //  USERNAME
            using (Font nameFont = SteamFont.GetFont(9F, FontStyle.Bold))
            using (SolidBrush nameBrush = new SolidBrush(Color.White))
            {
                
                SizeF size = g.MeasureString(notification.UserName, nameFont);

                RectangleF nameRect = new RectangleF(currentX, bounds.Y, size.Width + 10, bounds.Height);
                g.DrawString(notification.UserName, nameFont, nameBrush, nameRect, centerFormat);

                currentX += size.Width;
            }

            // SEPARATOR (" : ")
            using (Font sepFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush sepBrush = new SolidBrush(Color.Gray))
            {
                string sep = " : ";
                SizeF size = g.MeasureString(sep, sepFont);

                RectangleF sepRect = new RectangleF(currentX, bounds.Y, size.Width + 10, bounds.Height);
                g.DrawString(sep, sepFont, sepBrush, sepRect, centerFormat);

                currentX += size.Width;
            }

            using (Font msgFont = SteamFont.GetFont(9F, FontStyle.Regular))
            using (SolidBrush msgBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            {
                float remainingWidth = bounds.Width - currentX - 5;
                if (remainingWidth > 0)
                {
                    RectangleF msgRect = new RectangleF(currentX, bounds.Y, remainingWidth, bounds.Height);

                    
                    centerFormat.Trimming = StringTrimming.EllipsisCharacter;

                    g.DrawString(notification.Message, msgFont, msgBrush, msgRect, centerFormat);
                }
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