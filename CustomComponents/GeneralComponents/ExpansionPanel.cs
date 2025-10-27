using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class ExpansionPanel : UserControl
    {
        private bool _isExpanded = true;
        private int _expandedHeight;
        private int _collapsedHeight;

        #region Public Properties

        /// <summary>
        /// Gets or sets the main title text.
        /// </summary>
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => lblTitle1.Text;
            set => lblTitle1.Text = value;
        }

        /// <summary>
        /// Gets or sets the subtitle text. Hides the label if empty.
        /// </summary>
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Subtitle
        {
            get => lblTitle2.Text;
            set
            {
                lblTitle2.Text = value;
                // Hide the subtitle label if it's empty
                lblTitle2.Visible = !string.IsNullOrEmpty(value);
            }
        }

        /// <summary>
        /// Gets the panel that holds the content.
        /// You can add controls to this panel in the form designer.
        /// </summary>
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel
        {
            get => contentPanel;
        }

        #endregion

        public ExpansionPanel()
        {
            InitializeComponent();

            // Store the collapsed height (just the header)
            _collapsedHeight = headerPanel.Height;
            // Store the fully expanded height (as designed)
            _expandedHeight = this.Height;

            // Hook up click events to all header controls
            // This ensures the panel toggles no matter where the user clicks.
            headerPanel.Click += TogglePanel_Click;
            lblIcon.Click += TogglePanel_Click;
            lblTitle1.Click += TogglePanel_Click;
            lblTitle2.Click += TogglePanel_Click;
        }

        /// <summary>
        /// Main toggle logic to expand or collapse the panel.
        /// </summary>
        private void TogglePanel_Click(object sender, EventArgs e)
        {
            _isExpanded = !_isExpanded; // Flip the state

            if (_isExpanded)
            {
                Expand();
            }
            else
            {
                Collapse();
            }
        }

        /// <summary>
        /// Expands the panel to show content.
        /// </summary>
        public void Expand()
        {
            _isExpanded = true;
            this.Height = _expandedHeight;
            contentPanel.Visible = true;
            lblIcon.Text = "v";
        }

        /// <summary>
        /// Collapses the panel to hide content.
        /// </summary>
        public void Collapse()
        {
            _isExpanded = false;

            // We must store the current height *before* collapsing,
            // in case the panel was resized.
            _expandedHeight = this.Height;

            this.Height = _collapsedHeight;
            contentPanel.Visible = false;
            lblIcon.Text = ">";
        }
    }
}
