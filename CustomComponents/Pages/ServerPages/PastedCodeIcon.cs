using SmartCodeLab.CustomComponents.GeneralComponents;
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
    public partial class PastedCodeIcon : RoundedUserControl
    {
        public PastedCodeIcon(CopyPastedCode code)
        {
            InitializeComponent();
            this.Click += (s, e) =>
            {
                var dialog = new ViewCopyPastedCode(code);
                dialog.ShowDialog();
            };
        }
    }
}
