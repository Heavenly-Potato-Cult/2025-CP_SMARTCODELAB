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
        
        public SteamCard2()
        {
            
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            
            this.Padding = new Padding(15);
            this.BackColor = Color.Transparent; // Important for the corners
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            
            Color startColor = Color.FromArgb(102, 42, 71, 94);

            Color midColor = Color.FromArgb(153, 27, 40, 56);

            Color endColor = ColorTranslator.FromHtml("#0f1419");

            
            Rectangle rect = this.ClientRectangle;

            if (rect.Width == 0 || rect.Height == 0) return; 

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.Black, Color.Black, 45f)) 
            {
                
                ColorBlend blend = new ColorBlend();

                
                blend.Colors = new Color[] { startColor, midColor, endColor };

                
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f };

                brush.InterpolationColors = blend;

               
                using (GraphicsPath path = GetRoundedPath(rect, 4))
                {
                    g.FillPath(brush, path);

                    
                    using (Pen borderPen = new Pen(Color.FromArgb(30, 255, 255, 255), 1))
                    {
                        g.DrawPath(borderPen, path);
                    }
                }
            }
        }

       
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            
            path.AddArc(arc, 180, 90);

            
            arc.X = rect.Right - diameter - 1;
            path.AddArc(arc, 270, 90);

            
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
