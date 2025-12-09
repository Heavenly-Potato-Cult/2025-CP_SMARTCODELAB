using SmartCodeLab.CustomComponents.Pages.ServerPages;
using SmartCodeLab.CustomComponents.Pages.SessionViewing;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.WPFComponents;
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
using System.Windows.Forms.Integration;

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
            DashboardPage.Controls.Add(new SessionDisplayHome(session, session.notifications, session.lastModified, session.copyPasteCount) { Dock = DockStyle.Fill });
            //DashboardPage.Controls.Add(new ServerHomePage() { Dock = DockStyle.Fill });
            
            List<string> withProgressStudentsIds = session.userProgress.Select(s => s.Key).ToList();
            Dictionary<string, UserProfile> withProgressStudents = session.server.Users.Where(user => withProgressStudentsIds.Contains(user.Key)).ToDictionary();
            MonitoringPage.Controls.Add(new TempServerPage(session.userProgress, withProgressStudents, session.server.ServerTask.ratingFactors) { Dock = DockStyle.Fill });
            SubmissionPage.Controls.Add(new ProgressSubmissionPage(session.codeSubmission, session.server.ServerTask.ratingFactors, session.server.ProgrammingLanguage, session.userProgress) { Dock = DockStyle.Fill });
            SessionNavigationMenu();
        }

        private void SessionNavigationMenu()
        {
            // 1. Guard clause at the top
            if (panelNavHost2 == null)
            {
                return;
            }

            // 2. Calculate and set the panel's new, scaled height
            float dpiScale;
            using (Graphics g = this.CreateGraphics())
            {
                // Gets the system scale ( 1.25 for 125%)
                dpiScale = g.DpiX / 96f;
            }

            // Gets your designer height and sets the new runtime height (e.g., 58)
            panelNavHost2.Height = (int)(panelNavHost2.Height * dpiScale);

            var navMenu = new SessionNavbar2();

            navMenu.OnNavigationClicked = (tabIndex) =>
            {
                if(tabIndex == 3)
                {
                    ExitLogView(this, EventArgs.Empty);
                    return;
                }

                if (LogViewContainer != null) // Guard clause
                {
                    LogViewContainer.SuspendLayout();

                    try
                    {
                        LogViewContainer.SelectedIndex = tabIndex;

                    }
                    finally
                    {

                        LogViewContainer.ResumeLayout(true);
                    }
                }
            };

            var host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = navMenu
            };


            if (panelNavHost2 != null)
            {
                panelNavHost2.Controls.Add(host);
            }

        }


        private void ExitLogView(object sender, EventArgs e)
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
