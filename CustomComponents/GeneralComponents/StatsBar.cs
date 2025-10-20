using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public class StatsBar : ProgressBar
    {
        private Task? _updateDisplay;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly object _animationLock = new object();
        private int _targetValue;

        public float theValue {  get; private set; }
        public StatsBar()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint |
                         ControlStyles.OptimizedDoubleBuffer, true);
            Value = 38;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // More efficient painting
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, ClientRectangle);

            Rectangle fillRect = ClientRectangle;
            fillRect.Inflate(-2, -2); // Border padding
            fillRect.Width = (int)(fillRect.Width * ((double)Value / Maximum));

            // Pick color based on value
            Color fillColor = Value <= 33 ? Color.Red :
                             Value <= 67 ? Color.Yellow : Color.Green;

            using (var brush = new SolidBrush(fillColor))
            {
                e.Graphics.FillRectangle(brush, fillRect);
            }
        }

        public void ChangeValue(int value)
        {
            theValue = Convert.ToSingle(Math.Clamp(value, 0, 100));
            lock (_animationLock)
            {
                _targetValue = Math.Clamp(value, 0, 100);


                // Cancel previous animation
                if (_updateDisplay != null && !_updateDisplay.IsCompleted)
                {
                    _cancellationTokenSource.Cancel();
                    try
                    {
                        _updateDisplay.Wait(50); // Brief wait for cleanup
                    }
                    catch (AggregateException) { } // Expected
                    _cancellationTokenSource.Dispose();
                }

                _cancellationTokenSource = new CancellationTokenSource();
                var token = _cancellationTokenSource.Token;

                _updateDisplay = Task.Run(async () =>
                {
                    await AnimateValueAsync(token);
                });
            }
        }

        private async Task AnimateValueAsync(CancellationToken token)
        {
            const int frameDelay = 16; // ~60 FPS (smooth but not excessive)
            int currentVal = Value;
            int step = Math.Sign(_targetValue - currentVal);

            try
            {
                while (currentVal != _targetValue && !token.IsCancellationRequested)
                {
                    currentVal += step;

                    // Update UI thread safely
                    if (InvokeRequired)
                    {
                        BeginInvoke((Action)(() =>
                        {
                            if (!token.IsCancellationRequested)
                            {
                                Value = currentVal;
                                Refresh(); // More efficient than Invalidate()
                            }
                        }));
                    }
                    else
                    {
                        if (!token.IsCancellationRequested)
                        {
                            Value = currentVal;
                            Refresh();
                        }
                    }

                    await Task.Delay(frameDelay, token);
                }
            }
            catch (OperationCanceledException)
            {
                // Animation was cancelled - normal operation
            }
        }

        public float GetValue()
        {
            return Convert.ToSingle(this.Value);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cancellationTokenSource?.Cancel();
                _cancellationTokenSource?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
