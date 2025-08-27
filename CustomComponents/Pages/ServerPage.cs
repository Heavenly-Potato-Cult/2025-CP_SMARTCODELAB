using SmartCodeLab.CustomComponents.MainPages;
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

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class ServerPage : UserControl
    {
        public ServerPage()
        {
            InitializeComponent();
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.Controls.Add(new ServerSetUpPage());
        }
    }
}
