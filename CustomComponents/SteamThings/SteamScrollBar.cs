using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    [DefaultEvent("Scroll")]
    public class SteamScrollBar : Control
    {
        // --- EVENTS ---
        public event EventHandler Scroll;

        // --- PROPERTIES ---
        private int _value = 0;
        private int _maximum = 100;
        private int _largeChange = 10;
        private bool _isDragging = false;
        private int _clickPoint;
        private int _thumbTop;

        [Category("Steam Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Value
        {
            get => _value;
            set
            {
                if (_value == value) return;
                _value = Math.Max(0, Math.Min(value, _maximum));
                Invalidate();
                Scroll?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("Steam Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; Invalidate(); }
        }

        [Category("Steam Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int LargeChange // Represents "Page Size"
        {
            get => _largeChange;
            set { _largeChange = value; Invalidate(); }
        }

        // --- COLORS ---
        private Color TrackColor = Color.FromArgb(23, 26, 33); // Dark Background
        private Color ThumbColor = Color.FromArgb(58, 62, 70); // Lighter Grey
        private Color ThumbHoverColor = SteamColors.Accent;    // Green when active

        public SteamScrollBar()
        {
            this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.Width = 10; // Slim width
            this.Cursor = Cursors.Hand;
        }

        // --- PAINTING ---
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.None; // Sharp edges for track

            // 1. Draw Track
            using (SolidBrush brush = new SolidBrush(TrackColor))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }

            // 2. Calculate Thumb Height & Position
            int trackHeight = this.Height;
            int thumbHeight = GetThumbHeight();

            // Prevent division by zero
            int scrollRange = (_maximum - _largeChange);
            if (scrollRange <= 0) scrollRange = 1;

            float viewableRatio = (float)_value / scrollRange;
            int thumbY = (int)(viewableRatio * (trackHeight - thumbHeight));

            Rectangle thumbRect = new Rectangle(1, thumbY, this.Width - 2, thumbHeight);

            // 3. Draw Thumb (Rounded)
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(_isDragging ? ThumbHoverColor : ThumbColor))
            {
                // Draw rounded pill
                using (GraphicsPath path = GetRoundedPath(thumbRect, 4))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private int GetThumbHeight()
        {
            // Calculate proportion of visible content
            int trackHeight = this.Height;
            float contentRatio = (float)_largeChange / (_maximum + _largeChange);
            int height = (int)(trackHeight * contentRatio);

            return Math.Max(20, height); // Minimum size 20px
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

        // --- MOUSE INTERACTION ---
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isDragging = true;
            _clickPoint = e.Y;
            // Store current thumb Y to calculate delta
            int scrollRange = (_maximum - _largeChange);
            if (scrollRange > 0)
            {
                float viewableRatio = (float)_value / scrollRange;
                _thumbTop = (int)(viewableRatio * (this.Height - GetThumbHeight()));
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging)
            {
                // Calculate drag delta
                int deltaY = e.Y - _clickPoint;
                int newThumbY = _thumbTop + deltaY;

                // Convert pixels back to Value
                int trackHeight = this.Height;
                int thumbHeight = GetThumbHeight();
                int scrollableHeight = trackHeight - thumbHeight;

                if (scrollableHeight > 0)
                {
                    float ratio = (float)newThumbY / scrollableHeight;
                    int range = _maximum - _largeChange;
                    this.Value = (int)(ratio * range);
                }
            }
        }
    }
}
