using FastColoredTextBoxNS;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                    try
                    {
                        Debug.WriteLine(allOutput);
                        totalComplexity = cycComplexityOutputExtractor(allOutput);
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

        public static int cycComplexityOutputExtractor(string outputLine)
        {
            string[] outputs = outputLine.Split('\n');
            List<string> complexitiesCounted = new List<string>();
            //will determine which index the 'file analyzed is'
            int lastIndex = 0;
            for (int i = 3; i < outputs.Length; i++)
            {
                if (outputs[i].ToLower().Contains("file analyzed."))
                    break;
                else
                    complexitiesCounted.Add(outputs[i]);

                lastIndex++;
            }

            if (lastIndex == 0 || complexitiesCounted.Count == 0)
                return 1;

            int totalCycComplexity = 0;
            foreach (var line in complexitiesCounted)
            {
                totalCycComplexity += int.Parse(((line.Split("      ")[2]).ToCharArray()[0]).ToString());
            }
            return totalCycComplexity;
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
