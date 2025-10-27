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

namespace SmartCodeLab.CustomComponents.GeneralComponents
{
    public partial class ReadabilityReasons : UserControl
    {
        public ReadabilityReasons()
        {
            InitializeComponent();
        }

        public ReadabilityReasons(string issueName, ReadabilityIssues issue)
        {
            InitializeComponent();
            this.issue.Text = issueName;
            this.description.Text = issue.issueDescription;
            this.goodCode.Text += issue.badCodeExample;
            this.badCode.Text += issue.goodCodeExample;
        }

        private void badCode_Load(object sender, EventArgs e)
        {

        }

        private void ReadabilityReasons_Load(object sender, EventArgs e)
        {

        }
    }
}
