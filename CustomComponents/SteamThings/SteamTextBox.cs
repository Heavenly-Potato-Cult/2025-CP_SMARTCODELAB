using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamTextBox : UserControl
    {
        public TextBox innerTextBox;
        private bool isFocused = false;

       
        public override string Text
        {
            get => innerTextBox.Text;
            set => innerTextBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText { get; set; } = "";

        public SteamTextBox()
        {
            this.DoubleBuffered = true;
            this.BackColor = SteamColors.InputBg;
            this.Size = new Size(250, 35);
            this.Padding = new Padding(10, 8, 10, 8); // px-4 py-2 logic
            this.Cursor = Cursors.IBeam;

            InitializeInnerTextBox();
        }

        private void InitializeInnerTextBox()
        {
            innerTextBox = new TextBox();
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.BackColor = SteamColors.InputBg;
            innerTextBox.ForeColor = SteamColors.TextMuted;
            innerTextBox.Font = SteamFont.GetFont(12F, FontStyle.Regular);
            innerTextBox.Dock = DockStyle.Fill;

            innerTextBox.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            innerTextBox.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            innerTextBox.Click += (s, e) => { this.OnClick(e); }; 

            this.Controls.Add(innerTextBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

          
            using (SolidBrush bgBrush = new SolidBrush(SteamColors.InputBg))
            {
                e.Graphics.FillRectangle(bgBrush, this.ClientRectangle);
            }

            Color borderColor = isFocused ? SteamColors.Accent : SteamColors.Border;

            using (Pen borderPen = new Pen(borderColor, 1))
            {
                
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(borderPen, rect);
            }

            
            if (string.IsNullOrEmpty(innerTextBox.Text) && !isFocused && !string.IsNullOrEmpty(PlaceholderText))
            {
                
            }
        }

       
        protected override void OnClick(EventArgs e)
        {
            innerTextBox.Focus();
        }
    }
}
