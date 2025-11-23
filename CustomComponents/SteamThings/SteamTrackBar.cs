using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;


namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class ValueChangingEventArgs : EventArgs
    {
        public int NewValue { get; set; } // The value the mouse WANTS to set
        public bool Cancel { get; set; }  // Set true to stop the change
    }

    [DefaultEvent("ValueChanged")]
    public class SteamTrackBar : Control
    {
        // --- EVENTS ---
        public event EventHandler ValueChanged;

        public event EventHandler<ValueChangingEventArgs> ValueChanging;

        // --- PROPERTIES ---
        private int _value = 0;
        private int _maximum = 100;

        // Colors
        private Color _trackColor = Color.FromArgb(40, 50, 60); // Dark Grey (Empty)
        private Color _fillColor = SteamColors.Accent;          // Green (Filled)
        private Color _thumbColor = Color.White;                // The Handle

        [Category("Steam Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get { return _value; }
            set
            {
                int newValue = Clamp(value, 0, _maximum);
                if (_value != newValue)
                {
                    _value = newValue;
                    Invalidate(); // Redraw
                    ValueChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        [Category("Steam Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                Invalidate();
            }
        }

        // --- STATE MANAGEMENT ---
        private bool _isDragging = false;

        // --- CONSTRUCTOR ---
        public SteamTrackBar()
        {


            // 2. ENABLE TRANSPARENCY SUPPORT (The Magic Part)
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            this.Height = 30; // Default height
            this.Cursor = Cursors.Hand;
        }

        // --- PAINTING LOGIC ---
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Dimensions
            int trackHeight = 4;
            int thumbSize = 14;
            int cy = this.Height / 2; // Vertical Center

            // Calculate pixel width based on Value
            // "Where should the thumb be?"
            // Logic: (Value / Max) * (Width - ThumbSize)
            float percentage = (float)_value / _maximum;
            if (_maximum == 0) percentage = 0;

            int availableWidth = this.Width - thumbSize;
            int thumbX = (int)(percentage * availableWidth);

            // 1. Draw Empty Track (Background Line)
            using (SolidBrush trackBrush = new SolidBrush(_trackColor))
            {
                Rectangle trackRect = new Rectangle(thumbSize / 2, cy - (trackHeight / 2), this.Width - thumbSize, trackHeight);
                g.FillRectangle(trackBrush, trackRect);
            }

            // 2. Draw Filled Track (Active Color)
            using (SolidBrush fillBrush = new SolidBrush(_fillColor))
            {
                Rectangle fillRect = new Rectangle(thumbSize / 2, cy - (trackHeight / 2), thumbX, trackHeight);
                g.FillRectangle(fillBrush, fillRect);
            }

            // 3. Draw Thumb (The Handle)
            Rectangle thumbRect = new Rectangle(thumbX, cy - (thumbSize / 2), thumbSize, thumbSize);

            // Draw Thumb Shadow (Subtle depth)
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, thumbRect.X + 1, thumbRect.Y + 1, thumbSize, thumbSize);
            }

            // Draw Thumb Circle
            using (SolidBrush thumbBrush = new SolidBrush(_thumbColor))
            {
                g.FillEllipse(thumbBrush, thumbRect);
            }
        }

        // --- MOUSE INTERACTION ---

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                MoveThumbTo(e.X);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging)
            {
                MoveThumbTo(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
        }

        // Helper to convert Mouse X Position -> Value (0-100)
        private void MoveThumbTo(int xMouse)
        {
            int thumbSize = 14;
            int availableWidth = this.Width - thumbSize;
            int relativeX = Clamp(xMouse - (thumbSize / 2), 0, availableWidth);
            float percentage = (float)relativeX / availableWidth;

            // Calculate what the value WOULD be
            int proposedValue = (int)(percentage * _maximum);

            // Update
            SetValueInternal(proposedValue);
        }

        private void SetValueInternal(int proposedValue)
        {
            proposedValue = Clamp(proposedValue, 0, _maximum);

            // 1. ASK PERMISSION FIRST
            if (ValueChanging != null)
            {
                var args = new ValueChangingEventArgs { NewValue = proposedValue };
                ValueChanging(this, args);

                // If the parent modified the value (e.g. capped it), use that instead!
                proposedValue = args.NewValue;

                if (args.Cancel) return; // Parent said "Stop!"
            }

            // 2. ONLY CHANGE IF IT'S ACCEPTED
            if (_value != proposedValue)
            {
                _value = proposedValue;
                Invalidate();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        // Helper method to keep numbers in range
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
