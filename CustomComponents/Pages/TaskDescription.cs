using SmartCodeLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages
{
    public partial class TaskDescription : UserControl
    {
        public TaskDescription()
        {
            InitializeComponent();
        }

        public void SetDescription(TaskModel task)
        {
            description.SelectionStart = description.TextLength;
            description.SelectionFont = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            description.AppendText($"{task._taskName}\n\n");

            description.SelectionStart = description.TextLength;
            description.SelectionFont = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            description.AppendText("Description\n");

            description.SelectionStart = description.TextLength;
            description.SelectionFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            description.AppendText($"{task._instructions}\n\n");

            description.SelectionStart = description.TextLength;
            description.SelectionFont = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            description.AppendText("Test Cases\n");

            int itemNum = 1;
            foreach(var item in task._testCases)
            {
                description.SelectionStart = description.TextLength;
                description.SelectionFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                description.AppendText($"""
                    Test Case {itemNum++}:
                    Inputs:
                        {item.Key}

                    Output:
                        {item.Value}
                    """ + "\n\n");
                if (itemNum == 3)
                    break;
            }
        }
    }
}
