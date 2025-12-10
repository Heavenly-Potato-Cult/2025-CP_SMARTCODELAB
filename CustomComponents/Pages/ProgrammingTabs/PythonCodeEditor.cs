using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.CustomDialogs;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace SmartCodeLab.CustomComponents.Pages.ProgrammingTabs
{
    public class PythonCodeEditor : BaseCodeEditor
    {
        private string[] checksToRun = [string.Empty, string.Empty, string.Empty, ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability];
        private List<string> linters = new List<string>() {ProgrammingConfiguration.ruffRobustness, ProgrammingConfiguration.ruffMaintainability};
        private int standardComplexity;
        public PythonCodeEditor(string filePath, TaskModel task, StudentCodingProgress progress, Action<int, int, string> updateStats, Func<Task> sendProgress) : base(filePath, task, progress, updateStats, sendProgress) 
        {
            standardComplexity = 9999;
            foreach (var item in linters)
            {
                string content = LintersServices.pythonLinters[item];

                if(item == ProgrammingConfiguration.ruffMaintainability && task.ratingFactors.ContainsKey(4))
                {
                    standardComplexity = Convert.ToInt32(task.ratingFactors[4][1]);
                }
                LintersServices.initializeLinter(item, content);
            }

            srcCode.TextChanged += (s, e) =>
            {
                PythonSyntaxHighlight(e);
            };
            this.Load += (s, e) =>
            {
                PythonSyntaxHighlight(new TextChangedEventArgs(srcCode.Range));
            };
        }


        private void PythonSyntaxHighlight(TextChangedEventArgs e)
        {
            // Set brackets for Python (parentheses, brackets, braces)
            srcCode.LeftBracket = '(';
            srcCode.RightBracket = ')';
            srcCode.LeftBracket2 = '[';
            srcCode.RightBracket2 = ']';
            // Could add third bracket for braces if needed

            // Clear styles of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            // String highlighting - Python strings
            // Single quotes: '...', Triple single quotes: '''...'''
            // Double quotes: "...", Triple double quotes: """..."""
            // f-strings: f'...', f"...", f'''...''', f"""..."""
            e.ChangedRange.SetStyle(BrownStyle,
                @"(?<range>('''[\s\S]*?'''))|" +  // Triple single quotes
                @"(?<range>(\""""""[\s\S]*?\""""""))|" +  // Triple double quotes  
                @"(?<range>(f?r?b?u?f?'([^'\\]|\\.)*'))|" +  // Single quotes with optional prefixes
                @"(?<range>(f?r?b?u?f?\""([^\""\\]|\\.)*\""))"  // Double quotes with optional prefixes
            );

            // Comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"#.*$", RegexOptions.Multiline);

            // Number highlighting - Python numbers
            e.ChangedRange.SetStyle(MagentaStyle,
                @"\b\d+\.?\d*([eE][+-]?\d+)?\b|" +  // Decimal, float, scientific notation
                @"\b0x[0-9a-fA-F]+\b|" +  // Hex
                @"\b0o[0-7]+\b|" +  // Octal
                @"\b0b[01]+\b"  // Binary
            );

            // Decorator highlighting (like attributes)
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>@\w+(\.\w+)*)", RegexOptions.Multiline);

            // Class/Function definition highlighting
            // Class names
            e.ChangedRange.SetStyle(BoldStyle,
                @"\b(class)\s+(?<range>\w+?)(?:\([\w\s,]*\))?\s*:"  // class MyClass:
            );

            // Function/def names (including async)
            e.ChangedRange.SetStyle(BoldStyle,
                @"\b(async\s+)?def\s+(?<range>\w+?)\s*(?=\()"  // def my_function, async def my_func
            );

            // Keyword highlighting - Python keywords
            e.ChangedRange.SetStyle(BlueStyle,
                @"\b(False|None|True|and|as|assert|async|await|break|class|continue|def|del|elif|" +
                @"else|except|finally|for|from|global|if|import|in|is|lambda|nonlocal|not|or|pass|" +
                @"raise|return|try|while|with|yield)\b"
            );

            // Special literals highlighting (self, cls, etc.)
            e.ChangedRange.SetStyle(GrayStyle,
                @"\b(self|cls|super)\b"
            );

            // Built-in functions and types
            e.ChangedRange.SetStyle(BrownStyle,  // Different color for built-ins
                @"\b(abs|all|any|ascii|bin|bool|breakpoint|bytearray|bytes|callable|chr|" +
                @"classmethod|compile|complex|delattr|dict|dir|divmod|enumerate|eval|exec|" +
                @"filter|float|format|frozenset|getattr|globals|hasattr|hash|help|hex|id|" +
                @"input|int|isinstance|issubclass|iter|len|list|locals|map|max|memoryview|" +
                @"min|next|object|oct|open|ord|pow|print|property|range|repr|reversed|" +
                @"round|set|setattr|slice|sorted|staticmethod|str|sum|tuple|type|vars|zip)\b(?=\()"
            );

            // Clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            // Set folding markers for Python
            e.ChangedRange.SetFoldingMarkers(@"'''", @"'''");  // Triple quote strings
            e.ChangedRange.SetFoldingMarkers(@"\""""""", @"\""""""");  // Triple double quote strings
            e.ChangedRange.SetFoldingMarkers(@"^\s*#region\b", @"^\s*#endregion\b", RegexOptions.Multiline);  // Custom regions
            e.ChangedRange.SetFoldingMarkers(@"^\s*class\s+\w+.*:", @"^\s*$", RegexOptions.Multiline);  // Class blocks
            e.ChangedRange.SetFoldingMarkers(@"^\s*def\s+\w+.*:", @"^\s*$", RegexOptions.Multiline);  // Function blocks

            // Multi-line parentheses/brackets/braces folding
            e.ChangedRange.SetFoldingMarkers(@"\[", @"\]");
            e.ChangedRange.SetFoldingMarkers(@"\(", @"\)");
            e.ChangedRange.SetFoldingMarkers(@"\{", @"\}");
        }

        public override async Task RunCode()
        {
            process?.Dispose();
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "py",
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

        public override async void RunTest()
        {
            SourceCodeInitializer.InitializeEfficiencyCode2(Models.Enums.LanguageSupported.Python, filePath, false);
            commandLine = $"/c \"py \"{filePath}\"\"";
            base.RunTest();
            if (task.ratingFactors.ContainsKey(2) && mgaGinawangTama.Count > 0)
                await checkEfficiencyComparison();
        }

        private Task checkEfficiencyComparison()
        {
            int luckyNumber = new Random().Next(0, mgaGinawangTama.Count - 1);
            string testIntput = mgaGinawangTama[luckyNumber].Key;
            string directory = Path.GetDirectoryName(filePath);
            int studentsGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"py \"{Path.Combine(directory,"OperatorsCounter.py")}\"\"", testIntput));
            int bestGrowth = int.Parse(ExecuteCommandCaptureOutput($"/c \"py \"{Path.Combine(directory, "BestOperatorsCounter.py")}\"\"", testIntput));
            NonBlockingNotification($"Sayo : {studentsGrowth} \nTeacher : {bestGrowth}");
            updateStats?.Invoke(2, computeEfficiency(studentsGrowth, bestGrowth), "python");

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

        public override async Task RunLinting()
        {
            SaveCode();
            NoError();
            //for error checking
            process = CommandRunner($"/c \"py \"{ProgrammingConfiguration.SYNTAX_CHECKER}\" \"{filePath}\"\"");
            string errorOutput = "";
            await StartprocessAsync(
                process,
                err =>
                {
                    errorOutput += err + Environment.NewLine;
                },
                null,
                async () =>
                {
                    try
                    {
                        if (errorOutput == "")//means no syntax error
                        {
                            for (int i = 3; i < 5; i++)
                            {
                                await checkStandards(checksToRun[i], standardClearer(i), violationsHighLighter(i), i);
                            }
                        }
                        else
                        {
                            string[] errors = errorOutput.Split(Environment.NewLine);
                            int line = int.Parse(errors[0]);
                            string errorMsg = errors[1];
                            HighlightError(line, errorMsg);
                        }
                    }
                    catch (ArgumentOutOfRangeException)//will be thrown if no syntax error detected 
                    { }
                }
            );
        }

        public override void UpdateTask(TaskModel newTask)
        {
            if (task.ratingFactors.ContainsKey(4))
            {
                string item = ProgrammingConfiguration.ruffMaintainability;
                if (task.ratingFactors.ContainsKey(4))
                    standardComplexity = Convert.ToInt32(task.ratingFactors[4][1]);

                LintersServices.initializeLinter(item, maintainabilityCheck);
            }
            if (task.ratingFactors.ContainsKey(2))
            {
                SourceCodeInitializer.InitializeEfficiencyCode(LanguageSupported.Python, task._referenceFile, Path.GetDirectoryName(filePath));
            }
            base.UpdateTask(newTask);
        }

        private async Task checkStandards(string ruffFilePath, Action warningClearer, Action<int, string> highlighter, int updateStatsNum)
        {
            warningClearer?.Invoke();
            if (!File.Exists(ruffFilePath) && ruffFilePath == ProgrammingConfiguration.ruffMaintainability)
                LintersServices.initializeLinter(ruffFilePath, maintainabilityCheck);
            else if(!File.Exists(ruffFilePath))
                LintersServices.initializeLinter(ruffFilePath, LintersServices.pythonLinters[filePath]);

            process = CommandRunner($"/c \"\"{ProgrammingConfiguration.ruffExe}\" check \"{filePath}\" --config \"{ruffFilePath}\"\"");
            string checksViolations = "";
            string totalError = "";
            await StartprocessAsyncExit(
                process,
                output =>
                {
                    int mainPyIndex = output.IndexOf("Main.py");
                    if (mainPyIndex > 0)
                        checksViolations += output.Substring(output.IndexOf("Main.py") + 8) + Environment.NewLine;
                },
                err => totalError+=err + '\n',
                () =>
                {
                    int violationCounts = 0;
                    if (checksViolations != "")
                    {
                        foreach (var item in checksViolations.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
                        {
                            try
                            {
                                string[] slicedViolation = item.Split(':');
                                int errorLine = int.Parse(slicedViolation[0]);
                                string violatedRule = ruffCodeRetriever(slicedViolation[2]);
                                string violationMessage = item.Substring(item.IndexOf(violatedRule) + violatedRule.Length);

                                if (errorLine > 0)
                                {
                                    highlighter.Invoke(errorLine - 1, violationMessage);
                                    violationCounts++;
                                }
                            }
                            catch (ArgumentOutOfRangeException) { }
                            catch (FormatException) { }
                            catch (TypeInitializationException) { }
                            catch (IndexOutOfRangeException) { }
                            catch (KeyNotFoundException knfe)
                            {
                                Debug.WriteLine(knfe.Message);
                            }
                        }

                    }
                    //if (updateStatsNum == 4 && standardComplexity < 9999)
                    //{
                    //    int totalCC = CodeComplexityReference.CodeComplexityCounter(filePath);
                    //    Debug.WriteLine($"{totalCC} && {standardComplexity}");
                    //    if (totalCC > standardComplexity)
                    //    {
                    //        highlighter.Invoke(0, $"Cyclomatic complexity too high ({totalCC} > {standardComplexity}). Simplify your code by reducing nested conditions, loops, and branch points.");

                    //        violationCounts++;
                    //    }
                    //}
                    updateStats?.Invoke(updateStatsNum, violationCounts, "python");
                }
            );
        }

        private Action<int, string> violationsHighLighter(int i)
        {
            if (i == 3)
                return new Action<int, string>((int num, string msg) =>
                {
                    base.HighlightRobustnessIssue(num, msg);
                });
            else
                return new Action<int, string>((int num, string msg) =>
                {
                    base.HighlightMaintainabilityIssue(num, msg);
                });
        }

        private Action standardClearer(int lintercheck) //2 = readability , 3 = robustness, else = maintainability
        {
            if (lintercheck == 2)
                return new Action(() =>
                {
                    readabilityRules.Clear();
                    readabilityWarning.Clear();
                });
            else if (lintercheck == 3)
                return new Action(() =>
                {
                    robustnessRules.Clear();
                    robustnessWarning.Clear();
                });
            else
                return new Action(() =>
                {
                    maintainabilityRules.Clear();
                    maintainabilityWarning.Clear();
                });
        }

        private string ruffCodeRetriever(string errorMsg)
        {
            string newMsg = errorMsg.Remove(0, 1);
            return newMsg.Split(" ")[0];
        }
    }
}
