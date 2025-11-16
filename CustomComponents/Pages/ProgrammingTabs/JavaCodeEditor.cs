using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class JavaCodeEditor : BaseCodeEditor
    {
        int operatorsCount;
        private int errorCounts = 0;
        TextInputDialog2 toInput;
        TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        //TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        //MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));
        private readonly List<string> linters = new List<string>() {ProgrammingConfiguration.checkstyleMaintainability};
        public JavaCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress)
        {
            foreach (var item in linters)
            {
                string content = LintersServices.javaLinters[item];

                if (item == ProgrammingConfiguration.checkstyleMaintainability && task.ratingFactors.ContainsKey(4))
                {
                    maintainabilityCheck = content.Replace("999", Convert.ToInt32(task.ratingFactors[4][1]).ToString());
                    content = maintainabilityCheck;
                }
                LintersServices.initializeLinter(item, content);
            }


            srcCode.TextChanged += (s, e) =>
            {
                JavaSyntaxHighlight(e);
            };
            this.Load += (s, e) =>
            {
                JavaSyntaxHighlight(new TextChangedEventArgs(srcCode.Range));
            };
        }

        public override async Task RunCode()
        {
            await CompileCode2();
            process?.Dispose();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "java",
                    Arguments = $"\"{filePath}\"",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            await base.RunCode();
        }

        private void JavaSyntaxHighlight(TextChangedEventArgs e)
        {
            srcCode.LeftBracket = '(';
            srcCode.RightBracket = ')';
            srcCode.LeftBracket2 = '\x0';
            srcCode.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|assert|boolean|break|byte|case|catch|char|class|const|continue|
                        default|do|double|else|enum|extends|final|finally|float|for|goto|if|
                        implements|import|instanceof|int|interface|long|native|new|package|private|
                        protected|public|return|short|static|strictfp|super|switch|synchronized|this|
                        throw|throws|transient|try|void|volatile|while)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        public async Task CompileCode2()
        {
            SaveCode();
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            process = CommandRunner($"/c \"javac -cp \"{directory}\" \"{filePath}\"\"");
            await StartprocessAsync(
                process,
                null,
                null,//withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }
        public override async Task RunLinting()
        {
            SaveCode();
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            process = CommandRunner($"/c cd \"{directory}\" && javac -Xlint \"{fileName}\"");

            await StartprocessAsyncExit(
                process,
                null,
                error => errorLine += error,
                null);

            if (errorLine != "")
            {
                string[] lines = errorLine.Split(":");
                int lineIndex = int.Parse(lines[1]) - 1;
                HighlightError(lineIndex, lines[3]);
            }
            else
            {
                NoError();
                await checkMaintainability();
                await checkRobustness();
                //await checkOperatorsCount();
            }
        }

        public override async void RunTest()
        {
            SaveCode();
            SourceCodeInitializer.InitializeEfficiencyCode2(LanguageSupported.Java, filePath, false);
            string directory = Path.GetDirectoryName(filePath);
            CompileCode();
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            commandLine = $"/c \"cd \"{directory}\" && java {fileName}\"";
            base.RunTest();
            await RunLinting();
            //check efficiency
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
            {
                await checkOperatorsCount();
                await checkEfficiencyComparison();
            } else
                updateStats?.Invoke(2, 0, "java");
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"cd \"{directory}\" && java OperatorsCounter\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"cd \"{directory}\" && java BestOperatorsCounter\"", testIntput));
            MessageBox.Show($"Sayo : {studentsGrowth} \nTeacher : {bestGrowth}\nScore:{computeEfficiency(studentsGrowth, bestGrowth)}");
            updateStats?.Invoke(2, computeEfficiency(studentsGrowth, bestGrowth), "java");

            return Task.CompletedTask;
        }

        private async Task checkMaintainability()
        {
            maintainabilityWarning.Clear();
            int maintainabilityCounts = 0;
            string maintainabilityErrors = "";

            if (!File.Exists(ProgrammingConfiguration.checkstyleMaintainability))
                LintersServices.initializeLinter(ProgrammingConfiguration.checkstyleMaintainability, maintainabilityCheck);

            process = CommandRunner($"/c \"java -jar \"{ProgrammingConfiguration.checkStylePath}\" -c \"{ProgrammingConfiguration.checkstyleMaintainability}\" \"{filePath}\"\"");
            maintainabilityRules.Clear();
            await StartprocessAsyncExit(
                process,
                outp => { maintainabilityErrors += (outp + Environment.NewLine); },
                null,
                () =>
                {
                    List<string> errorsList = new List<string>();
                    string[] errors = (maintainabilityErrors.Replace("Starting audit..." + Environment.NewLine, "").Replace("Audit done." + Environment.NewLine, "")).Split(Environment.NewLine);
                    foreach (string standardError in errors)
                    {
                        if (errors[errors.Length - 1] != standardError)
                        {
                            string[] e = standardError.Split(':');
                            string errorMessage = e[e.Length - 1];
                            errorsList.Add(errorMessage);
                            base.HighlightMaintainabilityIssue(int.Parse(e[2]) - 1, errorMessage);
                            maintainabilityCounts++;
                            maintainabilityRules.Add(checkstyleErrorRetriever(errorMessage));
                        }
                    }
                    updateStats?.Invoke(4, maintainabilityCounts, "java");
                });
        }

        private async Task checkRobustness()
        {
            robustnessRules.Clear();
            robustnessWarning.Clear();
            int robustnessCounts = 0;
            string robustnessErrors = "";

            if (!File.Exists(ProgrammingConfiguration.pmdRobustness))
                LintersServices.initializeLinter(ProgrammingConfiguration.pmdRobustness, LintersServices.javaLinters[ProgrammingConfiguration.pmdRobustness]);

            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.pmdPath}\" check --cache ./pmd-cache -d \"{filePath}\" -R \"{ProgrammingConfiguration.pmdRobustness}\" -f text\"");
            await StartprocessAsyncExit(
                process,
                outp => { 
                    robustnessErrors += (outp + Environment.NewLine); 
                },
                null,
                () =>
                {
                    List<string> errorsList = new List<string>();
                    string[] errors = robustnessErrors.Split(Environment.NewLine);
                    foreach (string standardError in errors)
                    {
                        try
                        {
                            string[] errorSliced = standardError.Replace(filePath + ":", "").Split(':');
                            int errorLine = int.Parse(errorSliced[0]);
                            string errorMessage = errorSliced[2].Trim();
                            base.HighlightRobustnessIssue(errorLine - 1, errorMessage);
                            robustnessRules.Add(errorSliced[1].Trim());
                        }
                        catch (FormatException) { }
                    }
                    updateStats?.Invoke(3, robustnessCounts, "java");
                });
        }

        private async Task checkOperatorsCount()
        {
            process = CommandRunner($"/c \"java -jar \"{ProgrammingConfiguration.JAVA_OPERATOR_COUNTER}\" \"{filePath}\"\"");
            operatorsCount = 0;
            await StartprocessAsyncExit(
                process,
                res => operatorsCount = int.Parse(res),
                res => Debug.WriteLine($"error java oper counter : {res}"),
                null);
        }

        private string checkstyleErrorRetriever(string errorMsg)
        {
            int startIndex = errorMsg.LastIndexOf('[');
            if (startIndex == -1) return ""; // no [ found

            int endIndex = errorMsg.LastIndexOf(']');
            if (endIndex == -1 || endIndex < startIndex) return "";

            return errorMsg.Substring(startIndex + 1, endIndex - startIndex - 1);
        }
    }
}