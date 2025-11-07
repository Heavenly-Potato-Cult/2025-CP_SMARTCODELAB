using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public partial class TestCaseResult2 : UserControl
    {
        public TestCaseResult2()
        {
            Size = new Size(1030, 30);
            InitializeComponent();
        }

        public TestCaseResult2(int number, bool isCorrect, string input, string expOutput, string actOutput)
        {
            this.Size = new Size(1030, 30);
            InitializeComponent();
            this.inputs.Text = input;
            this.expectedOutput.Text = expOutput;
            this.actualOutput.Text = actOutput;
            //num.Text = number.ToString();
            //if (isCorrect)
            //{
            //    BackColor = Color.LightGreen;
            //    panel1.BackColor = Color.LightGreen;
            //    result.Text = "Correct";
            //}
            //else
            //{
            //    BackColor = Color.Red;
            //    panel1.BackColor = Color.Red;
            //    result.Text = "Incorrect";
            //}
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (this.Size.Height > 31)
        //    {
        //        this.Size = new Size(1030, 31);
        //        button1.Text = "Open";
        //    }
        //    else
        //    {
        //        this.Size = new Size(1030, 241);
        //        button1.Text = "Close";
        //    }
        //}
    }
}
