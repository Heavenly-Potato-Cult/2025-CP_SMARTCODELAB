using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class LoadingDialog : Form
    {
        private bool isCancelled {  get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TcpClient client { get; set; }
        public LoadingDialog()
        {
            InitializeComponent();
            isCancelled = false;
            TcpClient client = new TcpClient();
            _ = Task.Run(() =>
            {
                while (!isCancelled && !client.Connected)
                {
                    try
                    {
                        client.Connect("127.0.0.1", 1901);
                    }
                    catch (SocketException e) 
                    {
                        Debug.WriteLine("No connection");
                    }//if no connection was found
                }
                this.Invoke(new Action(() => Close()));
            });
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            isCancelled = true;
        }
    }
}
