using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SmartCodeLab.CustomComponents
{
    
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design")]
    public class ExpansionPanel : Panel 
    {
        // --- Internal Controls ---
        private Panel headerPanel;
        private Label lblIcon;
        private Label lblTitle1;
        private Label lblTitle2;
        private FlowLayoutPanel titleFlowPanel;

        // --- State ---
        private bool isExpanded = true;
        private int defaultHeight = 186;
        private int collapsedHeight = 48;

        // --- Event to notify hosts ---
        /// <summary>
        /// Raised after the expanded/collapsed state changes.
        /// </summary>
        public event EventHandler? ExpandedChanged;

        // --- Constructor ---
        public ExpansionPanel()
        {
            
            InitializeComponent();

            this.collapsedHeight = this.headerPanel.Height;
            this.defaultHeight = this.Height;

            
            this.headerPanel.Click += new EventHandler(ToggleCollapse);
            this.lblIcon.Click += new EventHandler(ToggleCollapse);
            this.titleFlowPanel.Click += new EventHandler(ToggleCollapse);
            this.lblTitle1.Click += new EventHandler(ToggleCollapse);
            this.lblTitle2.Click += new EventHandler(ToggleCollapse);

            
            //this.ControlAdded += new ControlEventHandler(this.FinalAccordion_ControlAdded);

            
            UpdateVisualState();
        }

        
        private void ToggleCollapse(object? sender, EventArgs e)
        {
            
            this.IsExpanded = !this.IsExpanded;
        }

        
        [Category("Appearance")]
        [Description("Determines if the panel is expanded or collapsed.")]
        [DefaultValue(true)]
        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                // Only update if the value has changed
                if (isExpanded == value)
                {
                    return;
                }

                isExpanded = value;
                UpdateVisualState();

                // Notify subscribers
                OnExpandedChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Raises the ExpandedChanged event.
        /// </summary>
        protected virtual void OnExpandedChanged(EventArgs e)
        {
            ExpandedChanged?.Invoke(this, e);
        }

        /// <summary>
        /// This method updates the UI (Height, icon, and control visibility)
        /// based on the current state of the IsExpanded property.
        /// </summary>
        private void UpdateVisualState()
        {
            if (!isExpanded)
            {
                // --- Collapse ---
                // Store the current expanded height, in case the user resized it
                this.defaultHeight = this.Height;
                this.Height = this.collapsedHeight;
                this.lblIcon.Text = ">";

                // Loop through all controls and hide them (except the header)
                foreach (Control c in this.Controls)
                {
                    if (c == this.headerPanel)
                    {
                        continue;
                    }
                    c.Visible = false;
                }
            }
            else
            {
                
                this.Height = this.defaultHeight;
                this.lblIcon.Text = "v";

                foreach (Control c in this.Controls)
                {
                    if (c == this.headerPanel)
                    {
                        continue; 
                    }
                    c.Visible = true;
                }
            }

            // Ensure the control and parent get layout notifications immediately.
            // Setting Height already triggers SizeChanged, but call OnSizeChanged explicitly
            // and request parent layout so containers with AutoSize update right away.
            OnSizeChanged(EventArgs.Empty);
            Parent?.PerformLayout();
        }

        // --- Public Properties ---
        [Category("Appearance")]
        [Description("The main title text for the panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title1
        {
            get { return this.lblTitle1.Text; }
            set { this.lblTitle1.Text = value; }
        }

        [Category("Appearance")]
        [Description("The secondary title text for the panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title2
        {
            get { return this.lblTitle2.Text; }
            set { this.lblTitle2.Text = value; }
        }

        [Category("Appearance")]
        [Description("The text or character for the toggle icon.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string IconText
        {
            get { return this.lblIcon.Text; }
            set { this.lblIcon.Text = value; }
        }

        [Category("Appearance")]
        [Description("The color of the header panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HeaderColor
        {
            get { return headerPanel.BackColor; }
            set { headerPanel.BackColor = value; }
        }

        
        //private void FinalAccordion_ControlAdded(object? sender, ControlEventArgs e)
        //{
        //    if (e.Control == null)
        //    {
        //        return;
        //    }

        //    if (e.Control == this.headerPanel)
        //    {
        //        return;
        //    }

        //    this.headerPanel.BringToFront();
        //}

        [DefaultValue(186)]
        public new int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                
                if (isExpanded)
                {
                    this.defaultHeight = value;
                }
            }
        }

        
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            titleFlowPanel = new FlowLayoutPanel();
            lblTitle1 = new Label();
            lblTitle2 = new Label();
            lblIcon = new Label();

            headerPanel.SuspendLayout();
            titleFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(titleFlowPanel);
            headerPanel.Controls.Add(lblIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(639, 48);
            headerPanel.TabIndex = 0;
            // 
            // titleFlowPanel
            // 
            titleFlowPanel.BackColor = Color.Transparent;
            titleFlowPanel.Controls.Add(lblTitle1);
            titleFlowPanel.Controls.Add(lblTitle2);
            titleFlowPanel.Dock = DockStyle.Fill;
            titleFlowPanel.Location = new Point(0, 0);
            titleFlowPanel.Name = "titleFlowPanel";
            titleFlowPanel.Size = new Size(589, 48);
            titleFlowPanel.TabIndex = 0;
            titleFlowPanel.WrapContents = false;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.BackColor = Color.Transparent;
            lblTitle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle1.ForeColor = Color.Black;
            lblTitle1.Location = new Point(3, 15);
            lblTitle1.Margin = new Padding(3, 15, 0, 0);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Padding = new Padding(10, 0, 0, 0);
            lblTitle1.Size = new Size(80, 20);
            lblTitle1.TabIndex = 63;
            lblTitle1.Text = "Test Case";
            lblTitle1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.DimGray;
            lblTitle2.Location = new Point(86, 15);
            lblTitle2.Margin = new Padding(3, 15, 0, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Padding = new Padding(10, 0, 0, 0);
            lblTitle2.Size = new Size(27, 20);
            lblTitle2.TabIndex = 64;
            lblTitle2.Text = "1";
            lblTitle2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = Color.Transparent;
            lblIcon.Cursor = Cursors.Hand;
            lblIcon.Dock = DockStyle.Right;
            lblIcon.Location = new Point(589, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(50, 48);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "v";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;

            
            lblIcon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIcon.ForeColor = Color.DimGray;
            // ----------------------------------------------

           
            Controls.Add(headerPanel);
            Name = "FinalAccordion";
            Size = new Size(639, 186);
            headerPanel.ResumeLayout(false);
            titleFlowPanel.ResumeLayout(false);
            titleFlowPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}