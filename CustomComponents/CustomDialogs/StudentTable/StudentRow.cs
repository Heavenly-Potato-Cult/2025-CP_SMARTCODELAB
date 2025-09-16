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
    public partial class StudentRow : UserControl
    {
        public StudentRow()
        {
            InitializeComponent();
        }

        public StudentRow(string studentId, string name)
        {
            InitializeComponent();
            this.studId.Text = studentId;
            this.studName.Text = name;
        }
    }
}
