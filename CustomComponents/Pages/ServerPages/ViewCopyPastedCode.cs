using FastColoredTextBoxNS;
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
    public partial class ViewCopyPastedCode : Form
    {
        public ViewCopyPastedCode(CopyPastedCode code)
        {
            InitializeComponent();
            codeEditor1.Text = code.wholeCode;
            Style backColorStyle = new TextStyle(Brushes.Black, Brushes.Yellow, FontStyle.Regular);
            for (int i = code.start; i <= code.end; i++)
            {
                codeEditor1.GetLine(i).SetStyle(backColorStyle);
            }
        }
    }
}
