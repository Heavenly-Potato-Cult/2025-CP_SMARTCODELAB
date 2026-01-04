using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public enum SteamTheme { Dark, Light }

    [DefaultEvent("SelectedIndexChanged")]
    public class SteamComboBox : UserControl
    {
        // --- INTERNAL LIGHT THEME DEFINITIONS ---
        private struct SteamLightColors
        {
            public static readonly Color InputBg = Color.FromArgb(242, 242, 242);
            public static readonly Color TextMain = Color.FromArgb(45, 45, 45);
            public static readonly Color TextMuted = Color.FromArgb(120, 120, 120);
            public static readonly Color Border = Color.FromArgb(210, 210, 210);
            public static readonly Color CardBg = Color.FromArgb(255, 255, 255);
            public static readonly Color SecondaryBg = Color.FromArgb(230, 230, 230);
        }

        private ComboBox innerCombo;
        private bool isFocused = false;
        private SteamTheme _theme = SteamTheme.Dark;

        // --- PROPERTIES ---

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
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Items => innerCombo.Items;

        [Category("Steam Appearance")]
        [Browsable(true)]
        public override string Text
        {
            get => innerCombo.Text;
            set => innerCombo.Text = value;
        }

        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => innerCombo.SelectedIndex;
            set => innerCombo.SelectedIndex = value;
        }

        // Added back the missing property causing your error
        [Category("Steam Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => innerCombo.SelectedItem;
            set => innerCombo.SelectedItem = value;
        }

        public event EventHandler SelectedIndexChanged;

        // --- CONSTRUCTOR ---

        public SteamComboBox()
        {
            this.Size = new Size(250, 45);
            this.Padding = new Padding(1);
            this.Cursor = Cursors.Hand;
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;

            InitializeInnerCombo();
            ApplyThemeStyles();
        }

        private void InitializeInnerCombo()
        {
            innerCombo = new ComboBox();
            innerCombo.FlatStyle = FlatStyle.Flat;
            innerCombo.Font = SteamFont.GetFont(10F, FontStyle.Regular);
            innerCombo.DrawMode = DrawMode.OwnerDrawFixed;
            innerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            innerCombo.ItemHeight = 24;
            innerCombo.IntegralHeight = false;
            innerCombo.Anchor = AnchorStyles.None;

            innerCombo.DrawItem += InnerCombo_DrawItem;
            innerCombo.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            innerCombo.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            innerCombo.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);
            innerCombo.Click += (s, e) => ToggleDropdown();

            this.Controls.Add(innerCombo);
        }

        private void ApplyThemeStyles()
        {
            if (innerCombo == null) return;

            Color bg = GetThemedColor(SteamColors.InputBg, SteamLightColors.InputBg);
            Color fg = GetThemedColor(SteamColors.TextMain, SteamLightColors.TextMain);

            this.BackColor = bg;
            innerCombo.BackColor = bg;
            innerCombo.ForeColor = fg;

            this.Invalidate(true);
        }

        private Color GetThemedColor(Color dark, Color light)
            => _theme == SteamTheme.Dark ? dark : light;

        private void ToggleDropdown()
        {
            if (innerCombo == null) return;
            innerCombo.Focus();
            innerCombo.DroppedDown = !innerCombo.DroppedDown;
        }

        // --- LAYOUT ---

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboLayout();
        }

        private void AdjustComboLayout()
        {
            if (innerCombo == null) return;

            int width = this.Width;
            int y = (this.Height - innerCombo.Height) / 2;
            innerCombo.SetBounds(0, y, width, innerCombo.Height);

            Rectangle cropRect = new Rectangle(2, 2, width - 25, innerCombo.Height - 4);
            innerCombo.Region = new Region(cropRect);
        }

        // --- PAINTING ---

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FillControlBackground(e.Graphics);
            DrawControlBorder(e.Graphics);
            DrawArrowIcon(e.Graphics);
        }

        private void FillControlBackground(Graphics g)
        {
            using (SolidBrush bgBrush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(bgBrush, this.ClientRectangle);
            }
        }

        private void DrawControlBorder(Graphics g)
        {
            Color borderBase = GetThemedColor(SteamColors.Border, SteamLightColors.Border);
            Color borderColor = isFocused ? SteamColors.Accent : borderBase;

            using (Pen borderPen = new Pen(borderColor, 1))
            {
                g.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void DrawArrowIcon(Graphics g)
        {
            int x = this.Width - 20;
            int y = (this.Height / 2) - 2;
            Point[] arrowPoints = { new Point(x, y), new Point(x + 8, y), new Point(x + 4, y + 5) };

            Color arrowColor = GetThemedColor(SteamColors.TextMuted, SteamLightColors.TextMuted);
            using (SolidBrush arrowBrush = new SolidBrush(arrowColor))
            {
                g.FillPolygon(arrowBrush, arrowPoints);
            }
        }

        // --- DROPDOWN ITEM RENDERING ---

        private void InnerCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool isEditBox = (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color bgColor = CalculateItemBg(isEditBox, isSelected);
            Color textColor = CalculateItemFg(isEditBox, isSelected);

            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            RenderText(e.Graphics, e.Bounds, e.Index, textColor);
        }

        private void RenderText(Graphics g, Rectangle bounds, int index, Color color)
        {
            string text = innerCombo.Items[index].ToString();
            Rectangle textRect = new Rectangle(bounds.X + 5, bounds.Y, bounds.Width - 5, bounds.Height);
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;

            TextRenderer.DrawText(g, text, innerCombo.Font, textRect, color, flags);
        }

        private Color CalculateItemBg(bool isEdit, bool isSelected)
        {
            if (isEdit) return GetThemedColor(SteamColors.InputBg, SteamLightColors.InputBg);
            if (isSelected) return GetThemedColor(SteamColors.SecondaryBg, SteamLightColors.SecondaryBg);

            return GetThemedColor(SteamColors.CardBg, SteamLightColors.CardBg);
        }

        private Color CalculateItemFg(bool isEdit, bool isSelected)
        {
            if (isEdit) return GetThemedColor(SteamColors.TextMain, SteamLightColors.TextMain);
            if (isSelected && _theme == SteamTheme.Dark) return Color.White;

            return GetThemedColor(SteamColors.TextMain, SteamLightColors.TextMain);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ToggleDropdown();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}