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

        private void button1_Click(object sender, EventArgs e)
        {
            List<NamingConvention> ifDownToTwo = new List<NamingConvention>() { NamingConvention.SnakeCase, NamingConvention.CamelCase};
            NamingConvention namingConvention;
            try
            {
                List<JavaVariableExtractor.VariableInfo> variables = JavaVariableExtractor.GetFirstVariableInClass(codeEditor1.Text);
                if(variables.Count > 1)
                {
                    bool downToTwo = false;

                    foreach (var item in variables)
                    {
                        bool isDownToTwo = downToTwo;
                        string variable = item.Name;
                        downToTwo = (variable == variable.ToLower() && !variable.Contains('_'));
                        if (!downToTwo && !isDownToTwo)
                        {
                            MessageBox.Show(JavaNamingConvention.NamingConventionDetector.AnalyzeIdentifier(variable).ToString());
                            break;
                        }
                        else if (isDownToTwo && !downToTwo) 
                        {
                            namingConvention = JavaNamingConvention.NamingConventionDetector.AnalyzeIdentifier(variable);
                            if(ifDownToTwo.Contains(namingConvention))
                                MessageBox.Show(namingConvention.ToString());
                            else
                                MessageBox.Show("May naming convention error na!!");

                            break;
                        }
                    }
                }
            }
            catch (NullReferenceException) 
            {
            }
        }
    }
}
