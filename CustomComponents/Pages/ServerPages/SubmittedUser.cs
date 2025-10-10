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

namespace SmartCodeLab.CustomComponents.Pages.ServerPages
{
    public partial class SubmittedUser : UserControl
    {
        private SubmittedCode submittedCode;

        public SubmittedUser()
        {
            InitializeComponent();
        }

        public SubmittedUser(SubmittedCode submittedCode)
        {
            InitializeComponent();
            this.submittedCode = submittedCode;
        }
    }
}
