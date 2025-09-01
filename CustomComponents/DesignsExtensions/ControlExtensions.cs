using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.DesignsExtensions
{
    public static class ControlExtensions
    {
        // Extension method to add rounded corners to any control
        public static void MakeRounded(this Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int curveSize = radius * 2; // This is the key fix

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, curveSize, curveSize), 180, 90);
            path.AddArc(new Rectangle(control.Width - curveSize, 0, curveSize, curveSize), 270, 90);
            path.AddArc(new Rectangle(control.Width - curveSize, control.Height - curveSize, curveSize, curveSize), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - curveSize, curveSize, curveSize), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
