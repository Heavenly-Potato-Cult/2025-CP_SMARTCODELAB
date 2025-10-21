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

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class SessionLogsDisplay : RoundedUserControl
    {
        public SessionLogsDisplay()
        {
            InitializeComponent();
        }
        public SessionLogsDisplay(ProgrammingSession session)
        {
            InitializeComponent();
            sessionName.Text = session.server.ServerName;
            smartButton1.Click += (sender, e) =>
            {
                new PastSessionDisplay(session).ShowDialog();
            };
        }
    }
}
