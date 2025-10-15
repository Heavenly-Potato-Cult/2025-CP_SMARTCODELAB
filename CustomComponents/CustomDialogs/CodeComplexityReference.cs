using FastColoredTextBoxNS;
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

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class CodeComplexityReference : Form
    {

        public int total_cyclomatic_complexity;
        public CodeComplexityReference()
        {
            InitializeComponent();
            total_cyclomatic_complexity = 0;
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            File.WriteAllText(Path.Combine(ProgrammingConfiguration.javaFolder, "CountComplexity.java"), referenceCode.Text);
            total_cyclomatic_complexity = CodeComplexityCounter(Path.Combine(ProgrammingConfiguration.javaFolder, "CountComplexity.java"),true);
            Close();
        }

        public static int CodeComplexityCounter(string filePath, bool willDeleteAfter = false)
        {
            int totalComplexity = 0;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ProgrammingConfiguration.lizardExe,
                Arguments = filePath,
                UseShellExecute = false,               // required for redirection
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = startInfo })
            {
                string allOutput = string.Empty;
                process.OutputDataReceived += (s, e) => { if (e.Data != null) allOutput += e.Data + "\n"; };
                process.ErrorDataReceived += (s, e) => { if (e.Data != null) Debug.WriteLine("ERR: " + e.Data); };
                process.Exited += (s, e) =>
                {
                    string fourthLine = allOutput.Split('\n')[3];
                    try
                    {
                        totalComplexity = int.Parse(((fourthLine.Split("      ")[2]).ToCharArray()[0]).ToString());
                    }
                    catch (IndexOutOfRangeException) { totalComplexity = 1; }
                    if (willDeleteAfter)
                    {
                        File.Delete(filePath);
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();
                int exitCode = process.ExitCode;
                return totalComplexity;
            }
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
