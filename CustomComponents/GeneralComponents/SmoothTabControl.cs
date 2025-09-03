using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public class SmoothTabControl : MaterialTabControl
    {
        public SmoothTabControl()
        {
            // Enable double buffering
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
            UpdateStyles();
        }

        // 🔹 Add this override
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Prevent flickering background redraw
            base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            base.OnPaint(e);
        }
    }



}

