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
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class JavaCodeEditor : BaseCodeEditor
    {
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

        public override void UpdateTask(TaskModel task)
        {

            //await Task.Run(() =>
            //{
            if (task.ratingFactors.ContainsKey(4))
            {
                string item = ProgrammingConfiguration.checkstyleMaintainability;
                maintainabilityCheck = LintersServices.javaLinters[item].Replace("999", Convert.ToInt32(task.ratingFactors[4][1]).ToString());
                LintersServices.initializeLinter(item, maintainabilityCheck);
            }
            if (task.ratingFactors.ContainsKey(2))
            {
                SourceCodeInitializer.InitializeEfficiencyCode(LanguageSupported.Java, task._referenceFile, Path.GetDirectoryName(filePath));
            }
            //});

            base.UpdateTask(task);
        }

        public async Task CompileCode2()
        {
            SaveCode();
            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            process = CommandRunner($"/c javac \"{filePath}\"");
            await StartprocessAsyncExit(
                process,
                null,
                err => NonBlockingNotification(err),//withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);
        }

        public override async Task RunLinting()
        {
            SaveCode();
            NoError();
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            process = CommandRunner($"/c  \"java -jar \"{ProgrammingConfiguration.JAVA_SYNTAX_CHECKER}\" \"{filePath}\"\"");

            await StartprocessAsyncExit(
                process,
                error => errorLine += error + '\n',
                null,
                null);

            if (errorLine != "")
            {
                string[] lines = errorLine.Split("\n", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    foreach (var line in lines)
                    {
                        string[] lineMsg = line.Split("|=====|");
                        int lineIndex = int.Parse(lineMsg[0]) - 1;
                        HighlightError(lineIndex, lineMsg[1]);
                    }
                }
                catch (IndexOutOfRangeException) { }
            }
            else
            {
                for(int i = 3; i<=4; i++)
                {
                    if (i == 3 && !File.Exists(ProgrammingConfiguration.pmdRobustness))
                        LintersServices.initializeLinter(ProgrammingConfiguration.pmdRobustness, LintersServices.javaLinters[ProgrammingConfiguration.pmdRobustness]);
                    else if (i == 3 && !File.Exists(ProgrammingConfiguration.checkstyleMaintainability))
                        LintersServices.initializeLinter(ProgrammingConfiguration.checkstyleMaintainability, maintainabilityCheck);
                    await runLinters(i);
                }
            }
        }

        public override async void RunTest()
        {
            if (new SingleStatementBodyChecker().CheckForSingleStatementBodies(srcCode.Text).HasSingleStatementBodies)
            {
                NonBlockingNotification("Unbraced statements should be avoided because they can cause ambiguity and lead to inaccurate code analysis or operation counting. Always use braces to ensure clarity and prevent evaluation errors.");
                return;
            }

            string classname = Path.GetFileNameWithoutExtension(filePath);
            string directory = Path.GetDirectoryName(filePath);
            process = CommandRunner($"/c javac \"{filePath}\"");
            StartprocessAsyncExit(
                process,
                null,
                err => NonBlockingNotification(err),//withError => { this.Invoke((Action)(() => output.AppendText(withError + Environment.NewLine))); },
                null);

            string testFilePath = Path.Combine(directory, "Tester.java");
            File.WriteAllText(testFilePath, srcCode.Text);
            SourceCodeInitializer.InitializeEfficiencyCode2(LanguageSupported.Java, testFilePath, false);
            //directory = Path.GetDirectoryName(filePath);

            string fileName = Path.GetFileNameWithoutExtension(filePath);
            commandLine = $"/c \"cd \"{directory}\" && java {fileName}\"";
            base.RunTest();
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
                await checkEfficiencyComparison();
            else
                updateStats?.Invoke(2, 0, "java");

            await RunLinting();
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"cd \"{directory}\" && java OperatorsCounter\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"cd \"{directory}\" && java BestOperatorsCounter\"", testIntput));
            NonBlockingNotification($"Sayo : {studentsGrowth} \nTeacher : {bestGrowth}\nScore:{computeEfficiency(studentsGrowth, bestGrowth)}");
            updateStats?.Invoke(2, computeEfficiency(studentsGrowth, bestGrowth), "java");

            return Task.CompletedTask;
        }

        void NonBlockingNotification(string msg)
        {
            this.BeginInvoke((Action)(() =>
                                MessageBox.Show(
                                msg,
                                "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly | MessageBoxOptions.ServiceNotification
                            )));
        }

        private async Task runLinters(int checkCode)
        {
            string standardErrors = "";
            string configFile = checkCode == 3 ? ProgrammingConfiguration.pmdRobustness : ProgrammingConfiguration.checkstyleMaintainability;
            process = CommandRunner($"/c \"java -jar \"{ProgrammingConfiguration.checkStylePath}\" -c \"{configFile}\" \"{filePath}\"\"");
            await StartprocessAsyncExit(
                process,
                outp => {
                    if (outp.Contains($"[ERROR] {filePath}"))
                        standardErrors += ((outp.Replace($"[ERROR] {filePath}:", "")) + Environment.NewLine);
                },
                null,
                () =>
                {
                    string[] standardErr = standardErrors.Split(
                                            new[] { Environment.NewLine },
                                            StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in standardErr)
                    {
                        (int lineLoc, string msg) = checkStyleLineMsgRetriever(item);
                        if(checkCode == 3)
                            base.HighlightRobustnessIssue(lineLoc - 1, msg);
                        else
                            base.HighlightMaintainabilityIssue(lineLoc - 1, msg);
                    }
                    updateStats?.Invoke(checkCode, standardErr.Length, "java");
                });
        }

        private (int,string) checkStyleLineMsgRetriever(string line)
        {
            string remainingLine = line;
            int errorline = 0;
            string msg = string.Empty;
            //get the line first
            errorline = int.Parse(remainingLine.Substring(0, line.IndexOf(':')));

            //now remove the column
            remainingLine = remainingLine.Substring(line.IndexOf(':') + 1).Substring(remainingLine.IndexOf(':') + 2);
            msg = (remainingLine.Substring(0, remainingLine.LastIndexOf('[')));
            return (errorline, msg);
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