using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SmartCodeLab.CustomComponents
{
    public class SmoothTabControl : MaterialTabControl
    {
        public SmoothTabControl()
        {
            // Enable double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
    }



}

