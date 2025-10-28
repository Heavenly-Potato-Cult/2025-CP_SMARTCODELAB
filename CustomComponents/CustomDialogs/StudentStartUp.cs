using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class StudentStartUp : Form
    {
        public StudentStartUp()
        {
            InitializeComponent();
            Load += (s, e) =>
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
                        //return;
                    }
                    searchServer.CloseMe();
                    userLogIn.Dispose();
                }
                Close();
            };
        }
    }
}
