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
            tabPage1.Controls.Add(new SessionDisplayHome(session.server, session.notifications, session.lastModified, session.copyPasteCount));
            List<string> withProgressStudentsIds = session.userProgress.Select(s => s.Key).ToList();
            Dictionary<string, UserProfile> withProgressStudents = session.server.Users.Where(user => withProgressStudentsIds.Contains(user.Key)).ToDictionary();
            tabPage2.Controls.Add(new TempServerPage(session.userProgress, withProgressStudents, session.server.ServerTask.ratingFactors));
            tabPage3.Controls.Add(new ProgressSubmissionPage(session.codeSubmission, session.server.ServerTask.ratingFactors));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
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
}
