using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs.StudentTable
{
    public partial class FloatingOptions : Form
    {
        public Action deleteRecord;
        public Action editRecord;
        public Action _kickStudent;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action kickStudent
        {
            get;
            set
            {
                _kickStudent = value;
                button3.Visible = true;
                Size = new Size(208, 81);
            }
        }
        public FloatingOptions()
        {
            InitializeComponent();

            // Set form properties for floating behavior
            ShowInTaskbar = false;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;

            // Set location with bounds checking
            SetFormLocation(Cursor.Position);

            // Use Deactivate instead of LostFocus for forms
            Deactivate += (s, e) => Close();

            button3.Visible = false;
            Size = new Size(208, 55);

            // Also close when clicking outside
            this.MouseLeave += (s, e) => CheckForClose();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Focus(); // Better to focus after form is loaded
        }

        private void SetFormLocation(Point cursorPos)
        {
            // Adjust location so form stays on screen
            Screen currentScreen = Screen.FromPoint(cursorPos);
            Rectangle workingArea = currentScreen.WorkingArea;

            Location = new Point(
                Math.Max(workingArea.Left, Math.Min(cursorPos.X, workingArea.Right - Width)),
                Math.Max(workingArea.Top, Math.Min(cursorPos.Y, workingArea.Bottom - Height))
            );
        }

        private void CheckForClose()
        {
            if (!this.Bounds.Contains(Cursor.Position))
            {
                Close();
            }
        }

        // Optional: Add keyboard escape support
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRecord?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editRecord?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _kickStudent?.Invoke();
        }
    }
}
