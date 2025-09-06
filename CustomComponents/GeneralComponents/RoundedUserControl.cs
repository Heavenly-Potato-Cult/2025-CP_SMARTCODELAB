using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class RoundedUserControl : UserControl
    {
        private int borderRadius = 20;
        private Color borderColor = Color.Gray;
        private int borderSize = 0;

        [Browsable(true)]
        [Category("Custom Appearance")]
        [Description("The radius of the card's rounded corners.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Custom Appearance")]
        [Description("The color of the card border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Custom Appearance")]
        [Description("The thickness of the card border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        public RoundedUserControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.DarkGray;

            // Optional: smoother rendering
            //SetStyle(ControlStyles.UserPaint |
            //         ControlStyles.AllPaintingInWmPaint |
            //         ControlStyles.OptimizedDoubleBuffer, true);
        }

     

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius * 2f;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            using (GraphicsPath pathSurface = GetRoundedRect(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedRect(rectBorder,borderRadius - borderSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                // Fill background
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, pathSurface);
                }

                // Draw border
                if (borderSize > 0)
                {
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }

                // Set region so children also respect round corners
                Region = new Region(pathSurface);
            }
        }
    }
}
