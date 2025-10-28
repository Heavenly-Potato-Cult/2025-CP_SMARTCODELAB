﻿using FastColoredTextBoxNS;
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
            commandLine = $"/c \"{ProgrammingConfiguration.javac}\" -cp {directory} {filePath} && {ProgrammingConfiguration.javaExe} -cp {directory} {classname}";
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
        public async override void RunLinting()
        {
            SaveCode();
            string fileName = Path.GetFileName(filePath);
            string directory = Path.GetDirectoryName(filePath);
            string errorLine = "";
            process = CommandRunner($"/c cd {directory} && \"{ProgrammingConfiguration.javac}\" -Xlint {fileName}");

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
                standardError.Clear();
                errorCounts = 0;
                NamingConvention namingConvention = JavaVariableExtractor.GetVariableNamingConvention(srcCode.Text);
                string expression = ProgrammingConfiguration.namingConventionProperties[namingConvention];
                string updatedFile = File.ReadAllText(ProgrammingConfiguration.checkStyleConfig).Replace("regex!!", expression);
                File.WriteAllText(ProgrammingConfiguration.checkStyleConfig, updatedFile);

                CheckCodingStandards($"/c {ProgrammingConfiguration.javaExe} -jar {ProgrammingConfiguration.checkStylePath} -c {ProgrammingConfiguration.checkStyleConfig} {filePath}",
                    new Action(() => File.WriteAllTextAsync(ProgrammingConfiguration.namingConventionChecker, updatedFile.Replace(expression, "regex!!"))));
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

        //protected override void HighLightStandardError(int errorLine, string msg)
        //{
        //    try
        //    {
        //        var lineRange = srcCode.GetLine(errorLine);
        //        lineRange.SetStyle(yellowWavy);
        //        if (standardError.ContainsKey(errorLine))
        //            standardError.Remove(errorLine);
        //        standardError.Add(errorLine, msg);
        //    }
        //    catch (ArgumentException) {}
        //}

        public override void RunTest()
        {
            string directory = Path.GetDirectoryName(filePath);
            testerFile = Path.Combine(directory, "Tester.java");
            commandLine = $"/c cd {directory} && \"{ProgrammingConfiguration.javac}\" Tester.java && {ProgrammingConfiguration.javaExe} Tester";
            base.RunTest();
        }
    }
}