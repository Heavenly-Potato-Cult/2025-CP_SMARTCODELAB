using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    // The Enum 'SteamTheme' is already defined in SteamComboBox.cs, 
    // so we don't define it here to avoid CS0101.

    [DefaultEvent("TextChanged")]
    public class SteamTextBox : UserControl
    {
        private struct SteamLightColors
        {
            public static readonly Color InputBg = Color.FromArgb(242, 242, 242);
            public static readonly Color TextMain = Color.FromArgb(45, 45, 45);
            public static readonly Color TextMuted = Color.FromArgb(120, 120, 120);
            public static readonly Color Border = Color.FromArgb(210, 210, 210);
            public static readonly Color ReadOnlyBg = Color.FromArgb(225, 225, 225);
        }

        public TextBox innerTextBox;
        private bool isFocused = false;
        private bool isPlaceholderActive = false;
        private string _placeholderText = "";
        private Color _realForeColor;
        private SteamTheme _theme = SteamTheme.Dark;
        private Color _placeholderColor = Color.DarkGray;

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SteamTheme Theme
        {
            get => _theme;
            set
            {
                if (_theme == value) return;
                _theme = value;
                ApplyThemeStyles();
            }
        }

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                _placeholderColor = value;
                if (isPlaceholderActive)
                    innerTextBox.ForeColor = _placeholderColor;
            }
        }

        private bool _autoScrollBars = true;
        private ScrollBars _requestedScrollBars = ScrollBars.None;

        [Category("Steam Behavior")]
        [DefaultValue(true)]
        public bool AutoScrollBars
        {
            get => _autoScrollBars;
            set { _autoScrollBars = value; UpdateAutoScrollBars(); }
        }

        [Category("Steam Behavior")]
        [DefaultValue(false)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set { innerTextBox.Multiline = value; UpdateAutoScrollBars(); }
        }

        [Category("Steam Behavior")]
        [DefaultValue(true)]
        public bool WordWrap
        {
            get => innerTextBox.WordWrap;
            set { innerTextBox.WordWrap = value; UpdateAutoScrollBars(); }
        }

        [Category("Steam Behavior")]
        [DefaultValue(ScrollBars.None)]
        public ScrollBars ScrollBars
        {
            get => _requestedScrollBars;
            set { _requestedScrollBars = value; UpdateAutoScrollBars(); }
        }

        [Category("Steam Behavior")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => innerTextBox.ReadOnly;
            set
            {
                innerTextBox.ReadOnly = value;
                ApplyThemeStyles();
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get => isPlaceholderActive ? "" : innerTextBox.Text;
            set
            {
                RemovePlaceholder();
                innerTextBox.Text = value;
                if (string.IsNullOrEmpty(innerTextBox.Text))
                {
                    ApplyPlaceholder();
                    if (this.ActiveControl == innerTextBox)
                        this.ActiveControl = null;
                }
                UpdateAutoScrollBars();
            }
        }

        [Category("Steam Behavior")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                if (isPlaceholderActive)
                {
                    innerTextBox.Text = value;
                    innerTextBox.ForeColor = _placeholderColor;
                    UpdateAutoScrollBars();
                }
            }
        }

        public SteamTextBox()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(250, 35);
            this.Padding = new Padding(10, 8, 10, 8);
            this.Cursor = Cursors.IBeam;

            InitializeInnerTextBox();
            ApplyThemeStyles();
        }

        private void InitializeInnerTextBox()
        {
            innerTextBox = new TextBox();
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.Font = SteamFont.GetFont(10F, FontStyle.Regular);
            innerTextBox.Dock = DockStyle.Fill;

            innerTextBox.GotFocus += InnerTextBox_GotFocus;
            innerTextBox.LostFocus += InnerTextBox_LostFocus;
            innerTextBox.Click += (s, e) => { this.OnClick(e); };
            innerTextBox.TextChanged += (s, e) => { this.OnTextChanged(e); UpdateAutoScrollBars(); };
            innerTextBox.SizeChanged += (s, e) => { UpdateAutoScrollBars(); };
            innerTextBox.FontChanged += (s, e) => { UpdateAutoScrollBars(); };

            this.SizeChanged += (s, e) => { UpdateAutoScrollBars(); };

            this.Controls.Add(innerTextBox);

            ApplyPlaceholder();
            UpdateAutoScrollBars();
        }

        private void ApplyThemeStyles()
        {
            if (innerTextBox == null) return;

            Color defaultBg = GetThemedColor(SteamColors.InputBg, SteamLightColors.InputBg);
            Color readOnlyBg = GetThemedColor(Color.FromArgb(20, 22, 26), SteamLightColors.ReadOnlyBg);
            Color activeBg = ReadOnly ? readOnlyBg : defaultBg;

            _realForeColor = GetThemedColor(SteamColors.TextMain, SteamLightColors.TextMain);
            Color activeFg = ReadOnly ? Color.Gray : _realForeColor;

            this.BackColor = activeBg;
            innerTextBox.BackColor = activeBg;

            if (!isPlaceholderActive)
            {
                innerTextBox.ForeColor = activeFg;
            }

            this.Invalidate();
        }

        private Color GetThemedColor(Color dark, Color light)
            => _theme == SteamTheme.Dark ? dark : light;

        private void InnerTextBox_LostFocus(object sender, EventArgs e)
        {
            isFocused = false;
            if (string.IsNullOrEmpty(innerTextBox.Text))
                ApplyPlaceholder();

            this.Invalidate();
        }

        private void InnerTextBox_GotFocus(object sender, EventArgs e)
        {
            isFocused = true;
            if (isPlaceholderActive)
                RemovePlaceholder();

            this.Invalidate();
        }

        private void ApplyPlaceholder()
        {
            if (string.IsNullOrEmpty(innerTextBox.Text))
            {
                isPlaceholderActive = true;
                innerTextBox.Text = _placeholderText;
                innerTextBox.ForeColor = _placeholderColor;
            }
        }

        private void RemovePlaceholder()
        {
            if (!isPlaceholderActive) return;
            isPlaceholderActive = false;
            innerTextBox.Text = "";
            innerTextBox.ForeColor = _realForeColor;
        }

        private void UpdateAutoScrollBars()
        {
            if (innerTextBox == null) return;

            if (!_autoScrollBars)
            {
                innerTextBox.ScrollBars = _requestedScrollBars;
                return;
            }

            ScrollBars applied = ScrollBars.None;

            if ((_requestedScrollBars == ScrollBars.Vertical || _requestedScrollBars == ScrollBars.Both) && innerTextBox.Multiline)
            {
                if (NeedsVerticalScrollbar()) applied |= ScrollBars.Vertical;
            }

            if ((_requestedScrollBars == ScrollBars.Horizontal || _requestedScrollBars == ScrollBars.Both) && !innerTextBox.WordWrap)
            {
                if (NeedsHorizontalScrollbar()) applied |= ScrollBars.Horizontal;
            }

            innerTextBox.ScrollBars = applied;
        }

        private bool NeedsVerticalScrollbar()
        {
            int lineCount = innerTextBox.GetLineFromCharIndex(Math.Max(0, innerTextBox.TextLength - 1)) + 1;
            int lineHeight = innerTextBox.Font.Height;
            int visibleLines = Math.Max(1, innerTextBox.ClientSize.Height / Math.Max(1, lineHeight));
            return lineCount > visibleLines;
        }

        private bool NeedsHorizontalScrollbar()
        {
            if (innerTextBox.WordWrap) return false;

            int maxWidth = 0;
            var lines = innerTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var size = TextRenderer.MeasureText(line + " ", innerTextBox.Font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding);
                if (size.Width > maxWidth) maxWidth = size.Width;
            }
            int clientWidth = Math.Max(0, innerTextBox.ClientSize.Width - 4);
            return maxWidth > clientWidth;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderBase = GetThemedColor(SteamColors.Border, SteamLightColors.Border);
            Color borderColor = isFocused ? SteamColors.Accent : borderBase;

            using (Pen borderPen = new Pen(borderColor, 1))
            {
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(borderPen, rect);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            innerTextBox.Focus();
        }
    }
}