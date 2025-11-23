using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamGradientPanel : Panel
    {
        // 1. Expose Properties to the Visual Studio Designer
        [Category("Steam Appearance")]
        [Description("The color at the top of the gradient.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientTopColor { get; set; } = ColorTranslator.FromHtml("#0b0e11"); // Steam Dark Gunmetal

        [Category("Steam Appearance")]
        [Description("The color at the bottom of the gradient.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color GradientBottomColor { get; set; } = ColorTranslator.FromHtml("#1a1e24"); // Steam Lighter Blue-Grey

        [Category("Steam Appearance")]
        [Description("The angle of the gradient (90 = Vertical).")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public float GradientAngle { get; set; } = 90F;

        // 2. Constructor: Enable DoubleBuffering to stop flickering
        public SteamGradientPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redraw when resized
        }

        // 3. The Painting Logic
        protected override void OnPaint(PaintEventArgs e)
        {
            // Guard clause: If size is 0, don't try to draw
            if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0) return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                this.GradientTopColor,
                this.GradientBottomColor,
                this.GradientAngle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Paint any child controls (standard behavior)
            base.OnPaint(e);
        }
    }
}
