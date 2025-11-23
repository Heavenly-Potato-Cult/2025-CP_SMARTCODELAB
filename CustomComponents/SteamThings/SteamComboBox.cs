using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    [DefaultEvent("SelectedIndexChanged")]
    public class SteamComboBox : UserControl
    {
        private ComboBox innerCombo;
        private bool isFocused = false;

        // --- PROPERTIES ---
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
            
            this.BackColor = SteamColors.InputBg;
            this.Size = new Size(250, 45);
            this.Padding = new Padding(1);
            this.Cursor = Cursors.Hand;
            this.BorderStyle = BorderStyle.None;

            InitializeInnerCombo();
        }

        private void InitializeInnerCombo()
        {
            innerCombo = new ComboBox();
            innerCombo.FlatStyle = FlatStyle.Flat;
            innerCombo.BackColor = SteamColors.InputBg;
            innerCombo.ForeColor = SteamColors.TextMain;
            innerCombo.Font = SteamFont.GetFont(10F, FontStyle.Regular);

            innerCombo.DrawMode = DrawMode.OwnerDrawFixed;
            innerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            innerCombo.ItemHeight = 24;
            innerCombo.IntegralHeight = false;

            // Anchor None allows us to move it freely inside our container
            innerCombo.Anchor = AnchorStyles.None;

            // EVENTS
            innerCombo.DrawItem += InnerCombo_DrawItem;
            innerCombo.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            innerCombo.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            innerCombo.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);

            // CLICK LOGIC
            innerCombo.Click += (s, e) => ToggleDropdown();
            innerCombo.MouseClick += (s, e) => ToggleDropdown();

            this.Controls.Add(innerCombo);
        }

        private void ToggleDropdown()
        {
            innerCombo.Focus();
            innerCombo.DroppedDown = !innerCombo.DroppedDown;
        }

        // --- LAYOUT & REGION CROP ---
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

            // FIX FOR WHITE LINE: Increased cut from 20 to 25.
            // This cuts deeper into the right side to ensure the button edge is gone.
            Rectangle cropRect = new Rectangle(2, 2, width - 25, innerCombo.Height - 4);

            innerCombo.Region = new Region(cropRect);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            AdjustComboLayout();
        }

        // --- PAINTING (Container) ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 1. Draw Background
            using (SolidBrush bgBrush = new SolidBrush(SteamColors.InputBg))
            {
                e.Graphics.FillRectangle(bgBrush, this.ClientRectangle);
            }

            // 2. Draw Frame
            Color borderColor = isFocused ? SteamColors.Accent : SteamColors.Border;
            using (Pen borderPen = new Pen(borderColor, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // 3. Draw Arrow
            DrawCustomArrow(e.Graphics);
        }

        private void DrawCustomArrow(Graphics g)
        {
            int x = this.Width - 20;
            int y = (this.Height / 2) - 2;

            Point[] arrowPoints = new Point[]
            {
                new Point(x, y),
                new Point(x + 8, y),
                new Point(x + 4, y + 5)
            };

            using (SolidBrush arrowBrush = new SolidBrush(SteamColors.TextMuted))
            {
                g.FillPolygon(arrowBrush, arrowPoints);
            }
        }

        // --- LIST PAINTING (The Logic Fix) ---
        private void InnerCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // FIX: Detect if we are drawing the "Box" (Closed) or the "List" (Open)
            bool isEditBox = (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color bgColor;
            Color textColor;

            if (isEditBox)
            {
                // If it's the Closed Box, ALWAYS use Dark Background. Never Blue.
                bgColor = SteamColors.InputBg;
                textColor = SteamColors.TextMain;
            }
            else
            {
                // If it's the List, allow Blue Highlight on Hover
                bgColor = isSelected ? SteamColors.SecondaryBg : SteamColors.CardBg;
                textColor = isSelected ? Color.White : SteamColors.TextMain;
            }

            // Draw Background
            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            // Draw Text
            string text = innerCombo.Items[e.Index].ToString();
            Rectangle textRect = new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height);

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
            TextRenderer.DrawText(e.Graphics, text, innerCombo.Font, textRect, textColor, flags);
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
                // WS_EX_COMPOSITED: Forces the Container and Child to paint simultaneously
                // This stops the background from "erasing" the text before it's drawn
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
