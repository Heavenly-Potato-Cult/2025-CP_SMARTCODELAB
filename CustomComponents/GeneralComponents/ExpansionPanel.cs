using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    [Designer(typeof(ParentControlDesigner))]
    public partial class ExpansionPanel : UserControl
    {
        private bool _isExpanded = true;
        private int _expandedHeight;
        private int _collapsedHeight;

        #region Public Properties

       
        [Category("Appearance")]
        [Description("The main title text shown in the header.")]
        [DefaultValue("")] 
        public string Title
        {
            get => lblTitle1.Text;
            set => lblTitle1.Text = value;
        }

        
        [Category("Appearance")]
        [Description("The subtitle text shown next to the main title.")]
        [DefaultValue("")] 
        public string Subtitle
        {
            get => lblTitle2.Text;
            set
            {
                lblTitle2.Text = value;
                lblTitle2.Visible = !string.IsNullOrEmpty(value);
            }
        }

        
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel
        {
            get => contentPanel;
        }

        
        [Category("Appearance")]
        [Description("Controls whether the panel is in its collapsed state.")]
        [DefaultValue(false)] 
        public bool Collapsed
        {
            get => !_isExpanded;
            set
            {
              
                if (value == !_isExpanded)
                {
                    return;
                }

                if (value)
                {
                    Collapse();
                }
                else
                {
                    Expand();
                }
            }
        }

        #endregion

        public ExpansionPanel()
        {
            InitializeComponent();

            _collapsedHeight = headerPanel.Height;
            _expandedHeight = this.Height;

            headerPanel.Click += TogglePanel_Click;
            lblIcon.Click += TogglePanel_Click;
            lblTitle1.Click += TogglePanel_Click;
            lblTitle2.Click += TogglePanel_Click;

            
            if (Collapsed)
            {
                Collapse();
            }
            else
            {
                Expand();
            }
        }

        
        private void TogglePanel_Click(object sender, EventArgs e)
        {
            
            this.Collapsed = !this.Collapsed;
        }

        
        public void Expand()
        {
            _isExpanded = true;
            this.Height = _expandedHeight;
            contentPanel.Visible = true;
            lblIcon.Text = "v";
        }

        
        public void Collapse()
        {
            
            if (_isExpanded) 
            {
                _expandedHeight = this.Height;
            }

            _isExpanded = false;
            this.Height = _collapsedHeight;
            contentPanel.Visible = false;
            lblIcon.Text = ">";
        }
    }
}