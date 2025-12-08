using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    [DefaultEvent("TextChanged")]
    public class SteamTextBox : UserControl
    {
        public TextBox innerTextBox;
        private bool isFocused = false;
        private bool isPlaceholderActive = false;
        private string _placeholderText = "";
        private Color _realForeColor;

        // Placeholder color (configurable)
        private Color _placeholderColor = Color.DarkGray;

        [Category("Steam Appearance")]
        [Description("The color used to render placeholder text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "DarkGray")]
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

        // Auto-manage scrollbars
        private bool _autoScrollBars = true;
        private ScrollBars _requestedScrollBars = ScrollBars.None;

        [Category("Steam Behavior")]
        [Description("When true, shows/hides scrollbars automatically based on content.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool AutoScrollBars
        {
            get => _autoScrollBars;
            set
            {
                _autoScrollBars = value;
                UpdateAutoScrollBars();
            }
        }

        [Category("Steam Behavior")]
        [Description("Controls whether the text can span more than one line.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set
            {
                innerTextBox.Multiline = value;
                UpdateAutoScrollBars();
            }
        }

        [Category("Steam Behavior")]
        [Description("Indicates whether a multiline text box automatically wraps words.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool WordWrap
        {
            get => innerTextBox.WordWrap;
            set
            {
                innerTextBox.WordWrap = value;
                UpdateAutoScrollBars();
            }
        }

        [Category("Steam Behavior")]
        [Description("Specifies which scroll bars are allowed to appear (Vertical/Horizontal/Both).")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(ScrollBars.None)]
        public ScrollBars ScrollBars
        {
            get => _requestedScrollBars;
            set
            {
                _requestedScrollBars = value;
                UpdateAutoScrollBars();
            }
        }

        [Category("Steam Behavior")]
        [Description("Controls whether the text in the edit control can be changed.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => innerTextBox.ReadOnly;
            set
            {
                innerTextBox.ReadOnly = value;
                if (value)
                {
                    innerTextBox.BackColor = Color.FromArgb(20, 22, 26);
                    this.BackColor = Color.FromArgb(20, 22, 26);
                    innerTextBox.ForeColor = isPlaceholderActive ? _placeholderColor : Color.Gray;
                }
                else
                {
                    innerTextBox.BackColor = SteamColors.InputBg;
                    this.BackColor = SteamColors.InputBg;
                    innerTextBox.ForeColor = isPlaceholderActive ? _placeholderColor : _realForeColor;
                }
                this.Invalidate();
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
        [Description("The text that is displayed when the control has no text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
            this.BackColor = SteamColors.InputBg;
            this.Size = new Size(250, 35);
            this.Padding = new Padding(10, 8, 10, 8);
            this.Cursor = Cursors.IBeam;

            InitializeInnerTextBox();
        }

        private void InitializeInnerTextBox()
        {
            innerTextBox = new TextBox();
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.BackColor = SteamColors.InputBg;
            _realForeColor = innerTextBox.ForeColor = SteamColors.TextMain;
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

        // Auto scrollbar logic
        private void UpdateAutoScrollBars()
        {
            if (!_autoScrollBars)
            {
                innerTextBox.ScrollBars = _requestedScrollBars;
                return;
            }

            ScrollBars applied = ScrollBars.None;

            // Vertical
            if (( _requestedScrollBars == ScrollBars.Vertical || _requestedScrollBars == ScrollBars.Both ) && innerTextBox.Multiline)
            {
                if (NeedsVerticalScrollbar())
                    applied |= ScrollBars.Vertical;
            }

            // Horizontal (only meaningful when WordWrap is false)
            if (( _requestedScrollBars == ScrollBars.Horizontal || _requestedScrollBars == ScrollBars.Both ) && !innerTextBox.WordWrap)
            {
                if (NeedsHorizontalScrollbar())
                    applied |= ScrollBars.Horizontal;
            }

            innerTextBox.ScrollBars = applied;
        }

        private bool NeedsVerticalScrollbar()
        {
            // Estimate visible lines
            int lineCount = innerTextBox.GetLineFromCharIndex(Math.Max(0, innerTextBox.TextLength - 1)) + 1;
            int lineHeight = innerTextBox.Font.Height;
            int visibleLines = Math.Max(1, innerTextBox.ClientSize.Height / Math.Max(1, lineHeight));
            return lineCount > visibleLines;
        }

        private bool NeedsHorizontalScrollbar()
        {
            if (innerTextBox.WordWrap) return false;

            // Check widest line width
            int maxWidth = 0;
            var lines = innerTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var size = TextRenderer.MeasureText(line + " ", innerTextBox.Font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding);
                if (size.Width > maxWidth) maxWidth = size.Width;
            }
            // Account for internal padding/margins of TextBox
            int clientWidth = Math.Max(0, innerTextBox.ClientSize.Width - 4);
            return maxWidth > clientWidth;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = isFocused ? SteamColors.Accent : SteamColors.Border;
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
