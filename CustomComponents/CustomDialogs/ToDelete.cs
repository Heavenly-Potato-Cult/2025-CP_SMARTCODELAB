using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{

    public partial class ToDelete : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
        public ToDelete()
        {
            InitializeComponent();
        }

        private void ToDelete_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void ToDelete_Leave(object sender, EventArgs e)
        {
        }

        private void ToDelete_Deactivate(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
            ShowWindow(this.Handle, SW_RESTORE);
        }
    }
}
