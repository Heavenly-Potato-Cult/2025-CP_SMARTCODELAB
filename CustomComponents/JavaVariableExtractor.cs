using SmartCodeLab.CustomComponents;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartCodeLab.CustomComponents
{
    public class JavaVariableExtractor
    {
        public class VariableInfo
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
            public int LineNumber { get; set; }
            public string FullDeclaration { get; set; }
        }

        // Method 1: Detects variables including those in main method (excluding parameters)
        public static VariableInfo GetFirstVariable(string javaCode, bool includeMainMethod = false)
        {
            // Clean the code first
            string cleanCode = RemoveCommentsAndStrings(javaCode);

            // Split into lines for processing
            string[] lines = cleanCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            bool inMainMethod = false;
            bool mainMethodStarted = false;
            int mainMethodBraces = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                // Skip empty lines
                if (string.IsNullOrEmpty(line))
                    continue;

                // Skip package and import declarations
                if (line.StartsWith("package ") || line.StartsWith("import "))
                    continue;

                // Skip class declarations, comments
                if (line.Contains("class ") && !line.Contains("//"))
                    continue;
                if (line.StartsWith("//") || line.StartsWith("/*") || line.StartsWith("*"))
                    continue;

                // Check if this line contains main method declaration
                if (line.Contains("public static void main") || line.Contains("static void main"))
                {
                    inMainMethod = true;
                    mainMethodStarted = false;
                    mainMethodBraces = 0;

                    // Count opening braces on the main method line
                    mainMethodBraces += line.Count(c => c == '{');

                    // If opening brace is on same line as main declaration
                    if (line.Contains("{"))
                    {
                        mainMethodStarted = true;
                    }

                    // If we don't want to include main method variables, skip to next iteration
                    if (!includeMainMethod)
                        continue;
                    else
                        continue; // Skip the main method declaration line itself
                }

                // If we're in main method but haven't started processing yet
                if (inMainMethod && !mainMethodStarted)
                {
                    // Look for opening brace
                    if (line.Contains("{"))
                    {
                        mainMethodStarted = true;
                        mainMethodBraces += line.Count(c => c == '{');
                    }
                    continue; // Skip until we find the opening brace
                }

                // Count braces to track when we exit main method
                if (inMainMethod && mainMethodStarted)
                {
                    int openBraces = line.Count(c => c == '{');
                    int closeBraces = line.Count(c => c == '}');
                    mainMethodBraces += openBraces - closeBraces;

                    // If braces balance out to 0, we've exited main method
                    if (mainMethodBraces <= 0)
                    {
                        inMainMethod = false;
                        mainMethodStarted = false;
                        continue;
                    }

                    // If we're including main method, process the line for variables
                    if (includeMainMethod)
                    {
                        var variable = ExtractVariableFromLine(line, i + 1);
                        if (variable != null)
                            return variable;
                    }

                    continue; // Skip if we're not including main method
                }

                // Process lines outside main method (when includeMainMethod = false)
                if (!inMainMethod)
                {
                    var variable = ExtractVariableFromLine(line, i + 1);
                    if (variable != null)
                        return variable;
                }
            }

            return null;
        }

        // Method specifically for variables ONLY in main method (excluding parameters)
        public static VariableInfo GetFirstVariableFromMain(string javaCode)
        {
            return GetFirstVariable(javaCode, includeMainMethod: true);
        }

        // Method for variables OUTSIDE main method (original behavior)
        public static VariableInfo GetFirstVariableOutsideMain(string javaCode)
        {
            return GetFirstVariable(javaCode, includeMainMethod: false);
        }

        // Backward compatibility - keep the old method name
        public static VariableInfo GetFirstInitializedVariable(string javaCode)
        {
            return GetFirstVariable(javaCode, includeMainMethod: false);
        }

        private static VariableInfo ExtractVariableFromLine(string line, int lineNumber)
        {
            // Skip method declarations and control structures
            if (line.Contains("(") && line.Contains(")") &&
                (line.Contains("public ") || line.Contains("private ") || line.Contains("protected ") ||
                 line.Contains("for(") || line.Contains("if(") || line.Contains("while(")))
            {
                return null;
            }

            // Pattern 1: Variable with initialization - type variableName = value;
            string initializedPattern = @"^\s*((?:int|double|float|long|short|byte|char|boolean|String|Scanner|\w+(?:<[^>]*>)?)\s+)(\w+)\s*=\s*([^;]+);";

            Match initializedMatch = Regex.Match(line, initializedPattern);
            if (initializedMatch.Success)
            {
                return new VariableInfo
                {
                    Type = initializedMatch.Groups[1].Value.Trim(),
                    Name = initializedMatch.Groups[2].Value.Trim(),
                    Value = initializedMatch.Groups[3].Value.Trim(),
                    LineNumber = lineNumber,
                    FullDeclaration = initializedMatch.Value.Trim()
                };
            }

            // Pattern 2: Variable without initialization - type variableName;
            string uninitializedPattern = @"^\s*((?:int|double|float|long|short|byte|char|boolean|String|Scanner|\w+(?:<[^>]*>)?)\s+)(\w+)\s*;";

            Match uninitializedMatch = Regex.Match(line, uninitializedPattern);
            if (uninitializedMatch.Success)
            {
                return new VariableInfo
                {
                    Type = uninitializedMatch.Groups[1].Value.Trim(),
                    Name = uninitializedMatch.Groups[2].Value.Trim(),
                    Value = null, // No initialization value
                    LineNumber = lineNumber,
                    FullDeclaration = uninitializedMatch.Value.Trim()
                };
            }

            // Pattern 3: Multiple variable declarations - type var1, var2, var3;
            string multiplePattern = @"^\s*((?:int|double|float|long|short|byte|char|boolean|String|Scanner|\w+(?:<[^>]*>)?)\s+)(\w+(?:\s*,\s*\w+)*)\s*;";

            Match multipleMatch = Regex.Match(line, multiplePattern);
            if (multipleMatch.Success)
            {
                string type = multipleMatch.Groups[1].Value.Trim();
                string variables = multipleMatch.Groups[2].Value.Trim();

                // Get the first variable from the list
                string firstName = variables.Split(',')[0].Trim();

                return new VariableInfo
                {
                    Type = type,
                    Name = firstName,
                    Value = null, // Multiple declarations usually don't have initialization
                    LineNumber = lineNumber,
                    FullDeclaration = multipleMatch.Value.Trim()
                };
            }

            // Pattern 4: Static/Final variables with modifiers
            string modifierPattern = @"^\s*((?:static|final|private|public|protected)\s+)*\s*((?:int|double|float|long|short|byte|char|boolean|String|Scanner|\w+(?:<[^>]*>)?)\s+)(\w+)(?:\s*=\s*([^;]+))?\s*;";

            Match modifierMatch = Regex.Match(line, modifierPattern);
            if (modifierMatch.Success)
            {
                return new VariableInfo
                {
                    Type = modifierMatch.Groups[2].Value.Trim(),
                    Name = modifierMatch.Groups[3].Value.Trim(),
                    Value = modifierMatch.Groups[4].Success ? modifierMatch.Groups[4].Value.Trim() : null,
                    LineNumber = lineNumber,
                    FullDeclaration = modifierMatch.Value.Trim()
                };
            }

            return null;
        }

        public static string RemoveCommentsAndStrings(string code)
        {
            // Remove single-line comments
            code = Regex.Replace(code, @"//.*?$", "", RegexOptions.Multiline);

            // Remove multi-line comments
            code = Regex.Replace(code, @"/\*.*?\*/", "", RegexOptions.Singleline);

            // Remove string literals (basic approach)
            code = Regex.Replace(code, @"""([^""\\]|\\.)*""", "\"\"", RegexOptions.Singleline);

            return code;
        }
    }
}
