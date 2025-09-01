using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents
{
    public partial class UserIcons : UserControl
    {
        public UserIcons(string studentName)
        {
            InitializeComponent();
            label1.Text = studentName;
            this.Size = new System.Drawing.Size(250, 50);
            this.BackColor = Color.Red; // Temporary - to see if it exists
            this.BorderStyle = BorderStyle.FixedSingle; // Add border
            this.Visible = true;
        }
    }
}
