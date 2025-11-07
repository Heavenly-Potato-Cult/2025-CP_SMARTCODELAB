using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace SmartCodeLab.CustomComponents
{
    [Designer(typeof(SmartCodeLab.CustomComponents.ExpansionPanelDesigner))]
    public partial class ExpansionPanel2 : UserControl
    {
        private int _expandedHeight;
        private const int _collapsedHeight = 40;

        public ExpansionPanel2()
        {
            InitializeComponent();

            // --- Setup SplitContainer ---
            ExpansionPanel.Panel1MinSize = _collapsedHeight;
            ExpansionPanel.Panel2MinSize = 0; 
            ExpansionPanel.SplitterDistance = _collapsedHeight;
            ExpansionPanel.Panel2Collapsed = false; 
            ExpansionPanel.IsSplitterFixed = true; 
            ExpansionPanel.SplitterWidth = 1;

            
            ExpansionPanel.Dock = DockStyle.Fill;

            
            _expandedHeight = this.Height;

            
            button3.Click += ToggleExpansion;
        }

        [Category("Content")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SplitterPanel ContentArea
        {
            get { return this.ExpansionPanel.Panel2; }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            
            if (!ExpansionPanel.Panel2Collapsed)
            {
                _expandedHeight = this.Height;
            }

            foreach (Control c in ExpansionPanel.Panel2.Controls)
            {
                c.BringToFront();
            }
        }

        private void ToggleExpansion(object sender, EventArgs e)
        {
            
            if (!ExpansionPanel.Panel2Collapsed)
            {
                _expandedHeight = this.Height;

                ExpansionPanel.Panel2Collapsed = true;

                this.Height = _collapsedHeight;
                return;
            }

            if (ExpansionPanel.Panel2Collapsed)
            {
                ExpansionPanel.Panel2Collapsed = false;

                this.Height = _expandedHeight;

                foreach (Control c in ExpansionPanel.Panel2.Controls)
                {
                    c.BringToFront();
                }
                return;
            }
        }
    }

    internal class ExpansionPanelDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            // Get the UserControl itself
            ExpansionPanel2 panel = this.Control as ExpansionPanel2;
            if (panel == null)
            {
                return;
            }

            // This is the magic line:
            // It tells the designer to "forward" all design-time
            // capabilities (like drag-and-drop) to the ContentArea (Panel2).
            this.EnableDesignMode(panel.ContentArea, "ContentArea");
        }
    }
}