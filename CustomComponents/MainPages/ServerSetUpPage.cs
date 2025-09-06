using SmartCodeLab.CustomComponents.Pages;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
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

namespace SmartCodeLab.CustomComponents.MainPages
{
    public partial class ServerSetUpPage : UserControl
    {
        public ServerSetUpPage()
        {
            InitializeComponent();
        }
        private void smartButton1_Click(object sender, EventArgs e)
        {
            TaskModel taskModel = JsonFileService.LoadFromText<TaskModel>(taskContainer.getFile().Value.Value);
            if (taskModel == null)
            {
                MessageBox.Show("Invalid File Content");
                return;
            }
            Debug.WriteLine(taskModel);
            SystemSingleton.Instance.page1.Controls.Clear();
            SystemSingleton.Instance.page1.AutoScroll = true;
            SystemSingleton.Instance.page1.Controls.Add(new TempServerPage(taskModel));
        }
    }
}
