// This custom button is based on RJButton (Rounded Button Control)
// Modified for SmartCodeLab project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public class CustomToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        //Properties
        [Category("SmartCodeLab")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                Invalidate();
            }
        }

        [Category("SmartCodeLab")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color OnToggleColor
        {
            get
            {
                return onToggleColor;
            }

            set
            {
                onToggleColor = value;
                Invalidate();
            }
        }

        [Category("SmartCodeLab")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }

            set
            {
                offBackColor = value;
                Invalidate();
            }
        }

        [Category("SmartCodeLab")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color OffToggleColor
        {
            get
            {
                return offToggleColor;
            }

            set
            {
                offToggleColor = value;
                Invalidate();
            }
        }

        [Category("SmartCodeLab")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }

            set
            {
                solidStyle = value;
                Invalidate();
            }
        }

        //Constructor
        public CustomToggleButton()
        {
            this.MinimumSize = new Size(45, 22);

            // THE FIX: Enable 'SupportsTransparentBackColor'
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // Set BackColor to Transparent (and don't touch it in OnPaint!)
            this.BackColor = Color.Transparent;
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // REMOVED: pevent.Graphics.Clear(Parent.BackColor); 
            // ^ This line was causing the black box. Do not clear. 
            // The "Transparent" property handles the background automatically.

            int toggleSize = this.Height - 5;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath path = GetFigurePath(rect, this.Height - 1);

            if (this.Checked) // ON State
            {
                // Draw Track
                if (SolidStyle)
                    g.FillPath(new SolidBrush(OnBackColor), path);
                else
                    g.DrawPath(new Pen(OnBackColor, 2), path);

                // Draw Knob (Right Side)
                g.FillEllipse(new SolidBrush(OnToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else // OFF State
            {
                // Draw Track
                if (SolidStyle)
                    g.FillPath(new SolidBrush(OffBackColor), path);
                else
                    g.DrawPath(new Pen(OffBackColor, 2), path);

                // Draw Knob (Left Side)
                g.FillEllipse(new SolidBrush(OffToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }


        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 90, 180);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 180);
            path.CloseFigure();
            return path;
        }
    }
}