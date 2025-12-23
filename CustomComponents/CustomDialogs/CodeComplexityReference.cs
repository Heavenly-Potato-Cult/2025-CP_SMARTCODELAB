using FastColoredTextBoxNS;
using SmartCodeLab.Models.Enums;
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
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.CustomDialogs
{
    public partial class CodeComplexityReference : Form
    {
        public int total_operator_count;
        public int total_cyclomatic_complexity;
        private string language;
        public string sourceCode { get; private set; }

        private readonly Dictionary<string, string> file_extensions = new Dictionary<string, string>()
        {
            { "Java", "java"},
            { "C++", "cpp"},
            { "Python", "py"}
        };
        private readonly Dictionary<string, string> counterLocation = new Dictionary<string, string>()
        {
            { "Java", $"\"{ProgrammingConfiguration.JAVA_OPERATOR_COUNTER}\""},
            { "C++", $"\"{ProgrammingConfiguration.CPP_OPERATOR_COUNTER}\""},
            { "Python", $"\"{ProgrammingConfiguration.PYTHON_OPERATOR_COUNTER}\""}
        };
        private readonly Dictionary<string, string> extensions = new Dictionary<string, string>()
        {
            { "Java", "java"},
            { "C++", "cpp"},
            { "Python", "py"}
        };
        public CodeComplexityReference(string language, string currentCode)
        {
            InitializeComponent();
            total_cyclomatic_complexity = 0;
            referenceCode.Text = currentCode;
            if (language == "Java")
                MessageBox.Show("Ensure that the class name is changed to \"Main\" to avoid any potential conflicts.");
            this.language = language;
        }

        private void smartButton2_Click(object sender, EventArgs e)
        {

            if ((language != "Python") && new SingleStatementBodyChecker().CheckForSingleStatementBodies(referenceCode.Text).HasSingleStatementBodies)
            {
                MessageBox.Show(this, "Unbraced statements should be avoided because they can cause ambiguity and lead to inaccurate code analysis or operation counting. Always use braces to ensure clarity and prevent evaluation errors.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            File.WriteAllText(Path.Combine(SystemConfigurations.javaFolder, "CountComplexity." + extensions[language]), referenceCode.Text);
            total_cyclomatic_complexity = CodeComplexityCounter(Path.Combine(SystemConfigurations.javaFolder, "CountComplexity." + extensions[language]), true);
            total_operator_count = CountOperators();
            sourceCode = referenceCode.Text;
            Close();
        }

        public static int CodeComplexityCounter(string filePath, bool willDeleteAfter = false)
        {
            int totalComplexity = 1;
            using (var process = getProcess($"/c \"\"{ProgrammingConfiguration.lizardExe}\" \"{filePath}\"\""))
            {
                string allOutput = string.Empty;
                process.OutputDataReceived += (s, e) => { if (e.Data != null) allOutput += e.Data + "\n"; };
                process.ErrorDataReceived += (s, e) => { if (e.Data != null) Debug.WriteLine("ERR: " + e.Data); };
                process.Exited += (s, e) =>
                {
                    try
                    {
                        totalComplexity = cycComplexityOutputExtractor(allOutput);
                        Debug.WriteLine(allOutput);
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
            int lastIndex = 0;
            for (int i = 3; i < outputs.Length; i++)
            {
                if (outputs[i].ToLower().Contains("file analyzed."))
                {
                    break;
                }
                else
                {
                    complexitiesCounted.Add(outputs[i]);
                    lastIndex++;
                }
            }
            if (lastIndex == 0 || complexitiesCounted.Count == 0)
                return 1;

            int totalCycComplexity = 0;
            foreach (var line in complexitiesCounted)
            {
                totalCycComplexity += ExtractSecondNumber(line);
            }
            return totalCycComplexity;
        }

        public static int ExtractSecondNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return -1;

            // Match one or more digits separated by whitespace
            var matches = Regex.Matches(input, @"\b\d+\b");

            // Get the second match (index 1)
            if (matches.Count >= 2)
            {
                if (int.TryParse(matches[1].Value, out int result))
                {
                    return result;
                }
            }

            return -1;
        }

        public int CountOperators()
        {
            string counterPath = counterLocation[language];
            int totalOperators = 0;
            string mainPath = Path.Combine(ProgrammingConfiguration.COUNTER_FOLDER, $"Main.{file_extensions[language]}");
            File.WriteAllText(mainPath, referenceCode.Text);
            string forJava = language == "Java" ? "java -jar " : "\"" + ProgrammingConfiguration.pythonExe + "\" ";
            using (var process = getProcess($"/c \"{forJava}{counterLocation[language]} \"{mainPath}\"\""))
            {
                string allOutput = string.Empty;
                process.OutputDataReceived += (s, e) => { if (e.Data != null) allOutput += e.Data + ""; };
                process.ErrorDataReceived += (s, e) => Debug.WriteLine("count err" + e.Data);
                process.Exited += (s, e) =>
                {
                    ; totalOperators = int.Parse(allOutput);
                };
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
                int exitCode = process.ExitCode;

                return totalOperators;
            }
        }

        private static Process getProcess(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = command,
                UseShellExecute = false,               // required for redirection
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            return new Process { StartInfo = processStartInfo };
        }
        private void smartButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
