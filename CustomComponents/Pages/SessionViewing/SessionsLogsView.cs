using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.Pages.SessionViewing;
using SmartCodeLab.CustomComponents.ServerPageComponents;
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

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class SessionsLogsView : UserControl
    {
        public SessionsLogsView()
        {
            InitializeComponent();
        }

        public SessionsLogsView(ProgrammingSession session)
        {
            InitializeComponent();
            DashboardPage.Controls.Add(new SessionDisplayHome(session.server, session.notifications, session.lastModified, session.copyPasteCount) { Dock = DockStyle.Fill });
            //DashboardPage.Controls.Add(new ServerHomePage() { Dock = DockStyle.Fill });
            
            List<string> withProgressStudentsIds = session.userProgress.Select(s => s.Key).ToList();
            Dictionary<string, UserProfile> withProgressStudents = session.server.Users.Where(user => withProgressStudentsIds.Contains(user.Key)).ToDictionary();
            MonitoringPage.Controls.Add(new TempServerPage(session.userProgress, withProgressStudents, session.server.ServerTask.ratingFactors) { Dock = DockStyle.Fill });
            SubmissionPage.Controls.Add(new ProgressSubmissionPage(session.codeSubmission, session.server.ServerTask.ratingFactors, session.server.ProgrammingLanguage) { Dock = DockStyle.Fill });
        }

      

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LogViewContainer.SelectedIndex = 0;
        }

        private void btn_monitoring_Click(object sender, EventArgs e)
        {
            LogViewContainer.SelectedIndex = 1;

        }

        private void btn_submissions_Click(object sender, EventArgs e)
        {
            LogViewContainer.SelectedIndex = 2;

        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            var container = SystemSingleton.Instance.sessionLogsPage;


            container.SuspendLayout();

            try
            {

                container.Controls.Clear();

                var newPage = new SessionLogsPage()
                {
                    Dock = DockStyle.Fill
                };

                container.Controls.Add(newPage);
            }
            finally
            {

                container.ResumeLayout(true);
            }
        }
    }
}
