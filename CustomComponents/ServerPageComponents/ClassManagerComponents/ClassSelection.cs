using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents.ClassManagerComponents
{
    public partial class ClassSelection : UserControl
    {
        public ClassSelection()
        {
            InitializeComponent();
        }

        public ClassSelection(ClassInformation classInfo, bool isChecked, Action<bool, string> action)
        {
            InitializeComponent();

            selected.Checked = isChecked;
            subCode.Text = classInfo.subjectCode;
            subject.Text = classInfo.subjectDesc;
            studCount.Text = classInfo.students?.Count.ToString() ?? "0";

            EventHandler clickAction = (s, e) => selected.Checked = !selected.Checked;

            this.Cursor = Cursors.Hand;
            this.Click += clickAction;
            WireAllControls(this, clickAction);

            selected.CheckedChanged += (s, e) => action(selected.Checked, classInfo.subjectCode);
        }

        /// <summary>
        /// Loops through every control inside the component and gives them the click event
        /// </summary>
        private void WireAllControls(Control parent, EventHandler action)
        {
            foreach (Control child in parent.Controls)
            {
                if(child != selected) // Prevent multiple event assignment
                {
                    child.Click += action;
                    child.Cursor = Cursors.Hand;

                    if (child.HasChildren)
                    {
                        WireAllControls(child, action);
                    }
                }
            }
        }
    }
}
