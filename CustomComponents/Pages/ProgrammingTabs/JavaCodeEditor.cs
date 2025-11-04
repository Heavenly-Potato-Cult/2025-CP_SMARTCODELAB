using FastColoredTextBoxNS;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class JavaCodeEditor : BaseCodeEditor
    {
        private int errorCounts = 0;
        TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        //TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        //MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));
        public JavaCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, List<string>> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress)
        {
            srcCode.TextChanged += (s, e) =>
            {
                JavaSyntaxHighlight(e);
            };
            this.Load += (s, e) =>
            {
                JavaSyntaxHighlight(new TextChangedEventArgs(srcCode.Range));
            };
        }

        public override void RunCode()
        {
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            commandLine = $"/c javac -cp {directory} {filePath} && java -cp {directory} {classname}";
            base.RunCode();
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

        public async override void CompileCode()
        {
            SaveCode();
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);

            process = CommandRunner($"/c \"{ProgrammingConfiguration.javac}\" -cp {directory} {filePath}");
            await StartprocessAsync(
                process,
                null,
                withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }
        public override async Task RunLinting()
        {
            SaveCode();
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            process = CommandRunner($"/c cd {directory} && javac -Xlint {fileName}");

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
                await checkReadability();
                await checkRobustness();
            }
        }

        public async override void CheckCodingStandards(string command, Action reRun = null)
        {
            standardError.Clear();
            process = CommandRunner(command);
            string errorLine = "";
            await StartprocessAsyncExit(
                process,
                outp => { errorLine += (outp + Environment.NewLine); },
                null,
                () =>
                {
                    reRun?.Invoke();
                    List<string> errorsList = new List<string>();
                    string[] errors = (errorLine.Replace("Starting audit..." + Environment.NewLine, "").Replace("Audit done." + Environment.NewLine, "")).Split(Environment.NewLine);
                    foreach (string standardError in errors)
                    {
                        if (errors[errors.Length - 1] != standardError)
                        {
                            string[] e = standardError.Split(':');
                            string errorMessage = e[e.Length - 1];
                            errorsList.Add(errorMessage);
                            base.HighLightStandardError(int.Parse(e[2]) - 1, errorMessage);
                            errorCounts++;
                        }
                    }
                    updateStats?.Invoke(2, errorCounts, errorsList);
                });
        }

        public override void RunTest()
        {
            string directory = Path.GetDirectoryName(filePath);
            testerFile = Path.Combine(directory, "Tester.java");
            commandLine = $"/c cd {directory} && javac Tester.java && java Tester";
            base.RunTest();
        }

        private async Task checkMaintainability()
        {
            maintainabilityWarning.Clear();
            int maintainabilityCounts = 0;
            string maintainabilityErrors = "";
            process = CommandRunner($"/c java -jar {ProgrammingConfiguration.checkStylePath} -c {ProgrammingConfiguration.checkstyleMaintainability} {filePath}");
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
                            Debug.WriteLine(standardError);
                            string[] e = standardError.Split(':');
                            string errorMessage = e[e.Length - 1];
                            errorsList.Add(errorMessage);
                            base.HighlightMaintainabilityIssue(int.Parse(e[2]) - 1, errorMessage);
                            maintainabilityCounts++;
                            maintainabilityRules.Add(checkstyleErrorRetriever(errorMessage));
                        }
                    }
                    updateStats?.Invoke(4, maintainabilityCounts, errorsList);
                });
        }

        private async Task checkReadability()
        {
            readabilityWarning.Clear();
            int readabilityCounts = 0;
            string readabilityErrors = "";
            readabilityRules.Clear();
            process = CommandRunner($"/c java -jar {ProgrammingConfiguration.checkStylePath} -c {ProgrammingConfiguration.checkstyleReadability} {filePath}");
            await StartprocessAsyncExit(
                process,
                outp => { readabilityErrors += (outp + Environment.NewLine); },
                null,
                () =>
                {
                    List<string> errorsList = new List<string>();
                    string[] errors = (readabilityErrors.Replace("Starting audit..." + Environment.NewLine, "").Replace("Audit done." + Environment.NewLine, "")).Split(Environment.NewLine);
                    foreach (string standardError in errors)
                    {
                        if (errors[errors.Length - 1] != standardError)
                        {
                            string[] e = standardError.Split(':');
                            string errorMessage = e[e.Length - 1];
                            errorsList.Add(errorMessage);
                            base.HighlightReadabilityIssue(int.Parse(e[2]) - 1, errorMessage);
                            readabilityCounts++;
                            readabilityRules.Add(checkstyleErrorRetriever(errorMessage));
                        }
                    }
                    updateStats?.Invoke(2, readabilityCounts, errorsList);
                });
        }

        private async Task checkRobustness()
        {
            robustnessRules.Clear();
            robustnessWarning.Clear();
            int robustnessCounts = 0;
            string robustnessErrors = "";
            process = CommandRunner($"/c {ProgrammingConfiguration.pmdPath} check --cache ./pmd-cache -d {filePath} -R {ProgrammingConfiguration.pmdRobustness} -f text");
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
                    updateStats?.Invoke(3, robustnessCounts, errorsList);
                });
        }

        private string checkstyleErrorRetriever(string errorMsg)
        {
            string ruleName = "";
            foreach (var item in errorMsg.Reverse())
            {
                if (item == '[')
                    break;

                ruleName = item + ruleName;
            }

            return ruleName.Replace("]", "");
        }

    }
}