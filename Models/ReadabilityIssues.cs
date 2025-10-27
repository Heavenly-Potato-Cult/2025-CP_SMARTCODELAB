using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    public class ReadabilityIssues
    {
        public string issueDescription { get; set; }
        public string goodCodeExample { get; set; }
        public string badCodeExample { get; set; }

        public ReadabilityIssues(string issueDescription, string goodCodeExample, string badCodeExample)
        {
            this.issueDescription = issueDescription;
            this.goodCodeExample = goodCodeExample;
            this.badCodeExample = badCodeExample;
        }
    }
}
