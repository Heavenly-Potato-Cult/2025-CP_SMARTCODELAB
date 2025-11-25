using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamLabel : Label
    {
      
        public enum SizeOption
        {
            Huge = 0,       // 48px (Big Stats)
            ExtraLarge = 1, // 32px
            Large = 2,      // 24px (Page Headers)
            Medium = 3,     // 16px (Section Headers)
            Regular = 4,    // 12px (Standard Body)
            Small = 5,      // 10px (Sidebar/Input Text)
            Tiny = 6        // 8px  (Footers/Copyright)
        }

       
        public enum ThemeOption
        {
            Standard,       // White/Blueish (#c7d5e0)
            Muted,          // Grey (#8b95a6)
            Accent,         // Green (#1abf20)
            Error           // Red (#ff4d4d)
        }

        private SizeOption _sizeOption = SizeOption.Regular;
        private ThemeOption _themeOption = ThemeOption.Standard;


        [Category("Steam Appearance")]
        [Description("Controls the font size.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SizeOption SteamSize
        {
            get { return _sizeOption; }
            set
            {
                _sizeOption = value;
                UpdateFont();
            }
        }

        [Category("Steam Appearance")]
        [Description("Controls the text color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ThemeOption SteamTheme
        {
            get { return _themeOption; }
            set
            {
                _themeOption = value;
                UpdateColor();
            }
        }

        // --- CONSTRUCTOR ---
        public SteamLabel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                  ControlStyles.OptimizedDoubleBuffer, true);

            this.DoubleBuffered = true;
            this.AutoSize = true;
            this.BackColor = Color.Transparent;

            // Set defaults
            UpdateFont();
            UpdateColor();
        }

      
        private void UpdateFont()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                // Fallback for Designer (Avoids crash if font isn't loaded)
                float fallbackSize = GetSizeInPoints(_sizeOption);
                this.Font = new Font("Segoe UI", fallbackSize, FontStyle.Regular);
            }
            else
            {
                // Runtime: Use real Geist Font
                float realSize = GetSizeInPoints(_sizeOption);
                FontStyle style = (_sizeOption <= SizeOption.Medium) ? FontStyle.Bold : FontStyle.Regular;

                // Logic: Headers (Medium and up) get Bold, Body text gets Regular
                this.Font = SteamFont.GetFont(realSize, style);
            }
        }

        private void UpdateColor()
        {
            switch (_themeOption)
            {
                case ThemeOption.Muted:
                    this.ForeColor = SteamColors.TextMuted;
                    break;
                case ThemeOption.Accent:
                    this.ForeColor = SteamColors.Accent;
                    break;
                case ThemeOption.Error:
                    this.ForeColor = Color.FromArgb(255, 77, 77); // Red
                    break;
                default: // Standard
                    this.ForeColor = SteamColors.TextMain;
                    break;
            }
        }

        // Helper to convert Enum to actual Float Size
        private float GetSizeInPoints(SizeOption option)
        {
            switch (option)
            {
                case SizeOption.Huge: return 48F;
                case SizeOption.ExtraLarge: return 32F;
                case SizeOption.Large: return 24F;
                case SizeOption.Medium: return 16F;
                case SizeOption.Regular: return 12F;
                case SizeOption.Small: return 10F;
                case SizeOption.Tiny: return 8F;
                default: return 12F;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Makes the text look sharp and professional
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            base.OnPaint(e);
        }
    }
}
