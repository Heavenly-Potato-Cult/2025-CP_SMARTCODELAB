using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.Models;
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
                SystemSingleton.Instance.sessionLogsPage.Controls.Clear();
                SystemSingleton.Instance.sessionLogsPage.Controls.Add(new SessionsLogsView(session) { Dock = DockStyle.Fill});
            };

            label1.Text = $"{session.server.createdAt.ToString("MMMM dd yyyy hh:mm tt")} - {session.lastModified.ToString("hh:mm tt")}";
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
