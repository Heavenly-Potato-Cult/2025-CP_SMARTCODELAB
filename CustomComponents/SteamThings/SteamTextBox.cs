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

        // New: configurable placeholder color
        private Color _placeholderColor = Color.DarkGray;

        [Category("Steam Appearance")]
        [Description("The color used to render placeholder text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                _placeholderColor = value;
                if (isPlaceholderActive)
                {
                    // Re-apply to reflect the new color immediately
                    innerTextBox.ForeColor = _placeholderColor;
                }
            }
        }

        // --- NEW PROPERTIES FOR MULTILINE SUPPORT ---

        [Category("Steam Behavior")]
        [Description("Controls whether the text can span more than one line.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set => innerTextBox.Multiline = value;
        }

        [Category("Steam Behavior")]
        [Description("Indicates whether a multiline text box automatically wraps words.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool WordWrap
        {
            get => innerTextBox.WordWrap;
            set => innerTextBox.WordWrap = value;
        }

        [Category("Steam Behavior")]
        [Description("Specifies which scroll bars should appear.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ScrollBars ScrollBars
        {
            get => innerTextBox.ScrollBars;
            set => innerTextBox.ScrollBars = value;
        }

        [Category("Steam Behavior")]
        [Description("Controls whether the text in the edit control can be changed.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        // --- EXISTING PROPERTIES ---

        [Browsable(true)]
        public override string Text
        {
            get => isPlaceholderActive ? "" : innerTextBox.Text;
            set
            {
                RemovePlaceholder();
                innerTextBox.Text = value;
                // If the text is set to empty, re-apply the placeholder on losing focus
                if (string.IsNullOrEmpty(innerTextBox.Text))
                {
                   ApplyPlaceholder();
                   // Since it's now a placeholder, we shouldn't have focus.
                   // This handles the edge case of setting Text = "" programmatically.
                   if(this.ActiveControl == innerTextBox)
                   {
                       this.ActiveControl = null;
                   }
                }
            }
        }

        [Category("Steam Behavior")]
        [Description("The text that is displayed when the control has no text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                // If placeholder is currently active, update its text and keep placeholder color
                if (isPlaceholderActive)
                {
                    innerTextBox.Text = value;
                    innerTextBox.ForeColor = _placeholderColor;
                }
            }
        }

        // --- CONSTRUCTOR ---
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
            
            // Event Wiring
            innerTextBox.GotFocus += InnerTextBox_GotFocus;
            innerTextBox.LostFocus += InnerTextBox_LostFocus;
            innerTextBox.Click += (s, e) => { this.OnClick(e); };
            innerTextBox.TextChanged += (s, e) => { this.OnTextChanged(e); };

            this.Controls.Add(innerTextBox);

            // Set initial state
            ApplyPlaceholder();
        }

        private void InnerTextBox_LostFocus(object sender, EventArgs e)
        {
            isFocused = false;
            if (string.IsNullOrEmpty(innerTextBox.Text))
            {
                ApplyPlaceholder();
            }
            this.Invalidate(); // Redraw border
        }

        private void InnerTextBox_GotFocus(object sender, EventArgs e)
        {
            isFocused = true;
            if (isPlaceholderActive)
            {
                RemovePlaceholder();
            }
            this.Invalidate(); // Redraw border
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

        // --- PAINTING ---
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
