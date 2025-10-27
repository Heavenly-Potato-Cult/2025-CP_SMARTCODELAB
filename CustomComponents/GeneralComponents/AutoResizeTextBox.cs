using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public class AutoResizeTextBox : TextBox
    {
        public AutoResizeTextBox()
        {
            this.Multiline = true;
            this.WordWrap = true;
            this.ScrollBars = ScrollBars.Vertical;
            this.AutoSize = false; // Important: We'll handle sizing manuallytry
            //try
            //{
            //    this.Font = new Font("Poppins", 9f, FontStyle.Regular, GraphicsUnit.Point);
            //}
            //catch (ArgumentException e)
            //{
            //        // Fallback fonts if Poppins is not installed
            //        try
            //        {
            //            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
            //        }
            //        catch
            //        {
            //            this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point);
            //        }
            //    }

            //// Set appropriate initial height for Poppins size 9
            //this.Height = GetBaseHeight();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            AdjustHeight();
        }
        private int GetBaseHeight()
        {
            // Calculate base height for single line with Poppins size 9
            return this.Font.Height + 12; // Extra padding for borders
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustHeight();
        }

        private void AdjustHeight()
        {
            // Calculate required height based on text content
            int border = 3; // Account for borders
            using (Graphics g = this.CreateGraphics())
            {
                SizeF size = g.MeasureString(this.Text, this.Font, this.Width - border);
                int requiredHeight = (int)Math.Ceiling(size.Height) + this.Padding.Top + this.Padding.Bottom + border;

                // Set minimum and maximum heights
                requiredHeight = Math.Max(this.Font.Height + border, requiredHeight);
                requiredHeight = Math.Min(requiredHeight, 200); // Max height limit

                if (this.Height != requiredHeight)
                {
                    this.Height = requiredHeight;
                }
            }
        }
    }
}
