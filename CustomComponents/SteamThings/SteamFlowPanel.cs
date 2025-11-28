using System;
using System.Windows.Forms;
using System.Drawing;

namespace SmartCodeLab.CustomComponents.SteamThings
{
    public class SteamFlowPanel : FlowLayoutPanel
    {
        public SteamFlowPanel()
        {
          
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            
            this.FlowDirection = FlowDirection.TopDown; 
            this.WrapContents = false; 
            this.AutoScroll = true;    
            this.BackColor = Color.Transparent; 
        }

       
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            int targetWidth = this.ClientSize.Width - this.Padding.Horizontal;

          
            targetWidth -= SystemInformation.VerticalScrollBarWidth;

         
            foreach (Control child in this.Controls)
            {
               
                if (child.Width != targetWidth)
                {
                    child.Width = targetWidth;

                  
                    child.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }
            }
        }


        protected override Point ScrollToControl(Control activeControl)
        {
          
            return this.AutoScrollPosition;
        }
    }
}
