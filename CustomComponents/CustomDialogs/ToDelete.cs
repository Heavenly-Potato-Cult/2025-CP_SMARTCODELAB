using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
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

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class ToDelete : Form
    {
        public ToDelete()
        {
            InitializeComponent();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => 
            {
                Debug.WriteLine("Task 1 started");
                Thread.Sleep(499);
                Debug.WriteLine("Task 1 finished");
            } );
            await Task.Run(() => 
            {
                Debug.WriteLine("Task 2 started");
                Thread.Sleep(499);
                Debug.WriteLine("Task 2 finished");
            });
        }
    }
}
