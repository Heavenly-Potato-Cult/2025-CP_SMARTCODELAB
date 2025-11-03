using ProtoBuf;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.CustomComponents.WPFComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SmartCodeLab
{

    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
            NavigationMenu();
            SessionNavigationMenu();
            SystemSingleton.Instance.page1 = tabPage10;
            this.Load += (sender, e) =>
            {
                Task.Run(() => 
                {
                    this.Invoke(new Action(() =>
                    {
                        sessionsContainer.Controls.Clear();
                    }));
                    foreach (var item in Directory.EnumerateFiles(SystemConfigurations.SESSIONS_FOLDER))
                    {
                        using (FileStream sessionFile = File.OpenRead(item)) 
                        {
                            ProgrammingSession session = Serializer.DeserializeWithLengthPrefix<ProgrammingSession>(sessionFile, PrefixStyle.Base128);
                            if (session != null)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    sessionsContainer.Controls.Add(new SessionLogsDisplay(session));
                                }));
                            }
                        }
                    }
                });
            };
        }

        private void NavigationMenu()
        {
            if (panelNavHost == null) return;

            float dpiScale;
            using (Graphics g = this.CreateGraphics())
            {
                dpiScale = g.DpiX / 96f;
            }
            panelNavHost.Height = (int)(panelNavHost.Height * dpiScale);


            var navMenu = new Navbar();
            navMenu.OnNavigationClicked = (tabIndex) =>
            {
                if (tabcontrol_MainNav != null)
                {
                    tabcontrol_MainNav.SelectedIndex = tabIndex;
                }
            };

            var host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = navMenu
            };


            if (panelNavHost != null)
            {
                panelNavHost.Controls.Add(host);
            }

        }

        private void SessionNavigationMenu()
        {

            if (panelNavHost2 == null)
            {
                return;
            }

            // 2. Calculate and set the panel's new, scaled height
            float dpiScale;
            using (Graphics g = this.CreateGraphics())
            {
                // Gets the system scale (e.g., 1.25 for 125%)
                dpiScale = g.DpiX / 96f;
            }

            // Gets your designer height (e.g., 46) and sets the new runtime height (e.g., 58)
            panelNavHost2.Height = (int)(panelNavHost2.Height * dpiScale);

            var navMenu = new SessionNavbar();

            navMenu.OnNavigationClicked = (tabIndex) =>
            {
                if (tabcontrol_session != null)
                {
                    tabcontrol_session.SelectedIndex = tabIndex;
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
        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            //new ToDelete().ShowDialog();
            if (!SystemSingleton.Instance._loggedIn)
            {
                TcpClient client = new TcpClient();
                var searchServer = new LoadingDialog(client);
                searchServer.ShowDialog();
                if (client.Connected)
                {
                    var userLogIn = new UserLogInDIalog(client);
                    if (userLogIn.ShowDialog() == DialogResult.OK)
                    {
                        var studentProgramming = new TempIDE(userLogIn._userName, userLogIn.serverTask, userLogIn.progress, userLogIn._stream);
                        SystemSingleton.Instance._loggedIn = true;
                        studentProgramming.ShowDialog();
                    }
                    else
                    {
                        SystemSingleton.Instance._loggedIn = false;
                        userLogIn.Dispose();
                        return;
                    }
                    searchServer.CloseMe();
                    userLogIn.Dispose();
                }
                else
                    return;
            }
        }

       
    }


}
