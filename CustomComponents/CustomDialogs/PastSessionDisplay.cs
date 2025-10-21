using SmartCodeLab.CustomComponents.Pages;
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

namespace SmartCodeLab.CustomComponents
{
    public partial class PastSessionDisplay : Form
    {
        public PastSessionDisplay()
        {
            InitializeComponent();
        }
        public PastSessionDisplay(ProgrammingSession session)
        {
            InitializeComponent();
            panel1.Controls.Add(new MainServerPage(session));
        }
    }
}
