using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using SmartCodeLab.CustomComponents.WPFComponents;

namespace SmartCodeLab
{
    
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
            NavigationMenu();
            SessionNavigationMenu();
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
                if (tabcontrol_MainNav != null) // Guard clause
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
            // 1. Guard clause at the top
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
                if (tabcontrol_session != null) // Guard clause
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
    }


}
