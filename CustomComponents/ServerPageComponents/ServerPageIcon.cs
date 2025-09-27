using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class ServerPageIcon : RoundedUserControl
    {
        private Action<IPEndPoint> action;
        public ServerPageIcon(Server server,IPEndPoint point, Action<IPEndPoint> act)
        {
            InitializeComponent();
            taskName.Text = server.ServerName;
            subject.Text = server.programmingLanguage;
            action = act;

            this.Click += (s, e) => ConnectServer(point);
        }

        private void ConnectServer(IPEndPoint point)
        {
            action?.Invoke(point);
        }
    }
}
