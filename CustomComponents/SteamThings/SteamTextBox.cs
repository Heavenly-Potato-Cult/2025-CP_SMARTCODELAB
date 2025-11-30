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

        // --- NEW PROPERTIES FOR MULTILINE SUPPORT ---

        [Category("Steam Behavior")]
        [Description("Controls whether the text can span more than one line.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set => innerTextBox.Multiline = value;
        }

        [Category("Steam Behavior")]
        [Description("Indicates whether a multiline text box automatically wraps words.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool WordWrap
        {
            get => innerTextBox.WordWrap;
            set => innerTextBox.WordWrap = value;
        }

        [Category("Steam Behavior")]
        [Description("Specifies which scroll bars should appear.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ScrollBars ScrollBars
        {
            get => innerTextBox.ScrollBars;
            set => innerTextBox.ScrollBars = value;
        }

        [Category("Steam Behavior")]
        [Description("Controls whether the text in the edit control can be changed.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ReadOnly
        {
            get => innerTextBox.ReadOnly;
            set
            {
                innerTextBox.ReadOnly = value;

                // Optional: Visually dim the background if ReadOnly
                if (value)
                {
                    innerTextBox.BackColor = Color.FromArgb(20, 22, 26); // Slightly darker
                    this.BackColor = Color.FromArgb(20, 22, 26);
                    innerTextBox.ForeColor = Color.Gray; // Dimmed Text
                }
                else
                {
                    innerTextBox.BackColor = SteamColors.InputBg;
                    this.BackColor = SteamColors.InputBg;
                    innerTextBox.ForeColor = SteamColors.TextMain;
                }

                this.Invalidate();
            }
        }

        // --- EXISTING PROPERTIES ---

        [Browsable(true)]
        public override string Text
        {
            get => innerTextBox.Text;
            set => innerTextBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText { get; set; } = "";

        // --- CONSTRUCTOR ---
        public SteamTextBox()
        {
            this.DoubleBuffered = true;
            this.BackColor = SteamColors.InputBg;
            this.Size = new Size(250, 35);
            // Default padding: Top/Bottom 8px centers single line text nicely.
            // It also looks good for multi-line as a margin.
            this.Padding = new Padding(10, 8, 10, 8);
            this.Cursor = Cursors.IBeam;

            InitializeInnerTextBox();
        }

        private void InitializeInnerTextBox()
        {
            innerTextBox = new TextBox();
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.BackColor = SteamColors.InputBg;
            innerTextBox.ForeColor = SteamColors.TextMain; // Ensure text color is visible
            innerTextBox.Font = SteamFont.GetFont(10F, FontStyle.Regular); // Use Helper
            innerTextBox.Dock = DockStyle.Fill;

            // Event Wiring
            innerTextBox.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            innerTextBox.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            innerTextBox.Click += (s, e) => { this.OnClick(e); };
            innerTextBox.TextChanged += (s, e) => { this.OnTextChanged(e); }; // Bubble up text change

            this.Controls.Add(innerTextBox);
        }

        // --- PAINTING ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 1. Draw Background
            using (SolidBrush bgBrush = new SolidBrush(SteamColors.InputBg))
            {
                e.Graphics.FillRectangle(bgBrush, this.ClientRectangle);
            }

            // 2. Draw Border (Green focus / Grey normal)
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
