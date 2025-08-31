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
            client = new TcpClient();
            _ = Task.Run(() =>
            {
                while (!isCancelled && !client.Connected)
                {
                    try
                    {
                        client.Connect("127.0.0.1", 1901);
                        Debug.WriteLine("Connected");
                    }
                    catch (SocketException e) 
                    {
                        //Debug.WriteLine("No connection");
                    }//if no connection was found
                    catch (ObjectDisposedException) {
                        break;
                    } //cancelled even before connection
                }
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        if (Visible) Hide(); // hide immediately
                        Close();
                    }));
                }
                catch (InvalidOperationException) { }
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(!client.Connected) client.Close();
            }
            base.Dispose(disposing);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            isCancelled = true;
        }
    }
}
