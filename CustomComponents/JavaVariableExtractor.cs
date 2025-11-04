using SmartCodeLab.CustomComponents;
using SmartCodeLab.CustomComponents.Pages.ProgrammingTabs;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services.NamingConventions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SmartCodeLab.CustomComponents.JavaVariableExtractor;

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

        // Method to find ALL variables inside a class (including main method, other methods, and class-level)
        public static List<VariableInfo> GetAllVariablesInClass(string javaCode)
        {
            List<VariableInfo> variables = new List<VariableInfo>();

            // Clean the code first
            string cleanCode = RemoveCommentsAndStrings(javaCode);

            // Split into lines for processing
            string[] lines = cleanCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            bool inClass = false;
            int classBraceLevel = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                // Skip empty lines
                if (string.IsNullOrEmpty(line))
                    continue;

                // Skip package and import declarations
                if (line.StartsWith("package ") || line.StartsWith("import "))
                    continue;

                // Skip comments
                if (line.StartsWith("//") || line.StartsWith("/*") || line.StartsWith("*"))
                    continue;

                // Check if we're entering a class
                if (line.Contains("class ") && !line.Contains("//"))
                {
                    inClass = true;
                    classBraceLevel = 0;
                    classBraceLevel += line.Count(c => c == '{');
                    continue;
                }

                // If we're inside a class, look for variables
                if (inClass)
                {
                    // Update brace level
                    classBraceLevel += line.Count(c => c == '{') - line.Count(c => c == '}');

                    // If we've exited the class
                    if (classBraceLevel <= 0)
                    {
                        inClass = false;
                        continue;
                    }

                    // Extract variable from this line
                    var variable = ExtractVariableFromLine(line, i + 1);
                    //string var = variable.Value;

                    //if (var != var.ToLower() || var.Contains("_")) 
                    //{
                        
                    //}

                    //check if the variable is not in all lowerCase
                    if (variable != null)
                    {
                        variables.Add(variable);
                    }
                }
            }

            return variables;
        }

        // Method to get the FIRST variable inside a class (including main method)
        public static List<VariableInfo> GetFirstVariableInClass(string javaCode)
        {
            return GetAllVariablesInClass(javaCode);
        }

        public static NamingConvention GetVariableNamingConvention(string javaCode)
        {
            List<NamingConvention> ifDownToTwo = new List<NamingConvention>() { NamingConvention.SnakeCase, NamingConvention.CamelCase };
            NamingConvention namingConvention;
            try
            {
                List<VariableInfo> variables = GetAllVariablesInClass(javaCode);
                if (variables.Count > 1)
                {
                    bool downToTwo = false;

                    foreach (var item in variables)
                    {
                        bool isDownToTwo = downToTwo;
                        string variable = item.Name;
                        downToTwo = (variable == variable.ToLower() && !variable.Contains('_'));
                        if (!downToTwo && !isDownToTwo)
                        {
                            return JavaNamingConvention.NamingConventionDetector.AnalyzeIdentifier(variable);
                        }
                        else if (isDownToTwo && !downToTwo)
                        {
                            namingConvention = JavaNamingConvention.NamingConventionDetector.AnalyzeIdentifier(variable);
                            if (ifDownToTwo.Contains(namingConvention))
                                return namingConvention;
                            else
                                return NamingConvention.Unknown;
                        }
                    }
                }else
                    return NamingConvention.CamelCase;
            }
            catch (NullReferenceException)
            {
            }
            return NamingConvention.Unknown;
        }

        // Method to get variables by location within the class
        public static class ClassVariablesFinder
        {
            public static List<VariableInfo> GetClassLevelVariables(string javaCode)
            {
                return GetVariablesByLocation(javaCode, VariableLocation.ClassLevel);
            }

            public static List<VariableInfo> GetMainMethodVariables(string javaCode)
            {
                return GetVariablesByLocation(javaCode, VariableLocation.MainMethod);
            }

            public static List<VariableInfo> GetOtherMethodVariables(string javaCode)
            {
                return GetVariablesByLocation(javaCode, VariableLocation.OtherMethods);
            }

            public static List<VariableInfo> GetAllMethodVariables(string javaCode)
            {
                var mainVars = GetMainMethodVariables(javaCode);
                var otherVars = GetOtherMethodVariables(javaCode);
                var allMethodVars = new List<VariableInfo>();
                allMethodVars.AddRange(mainVars);
                allMethodVars.AddRange(otherVars);
                return allMethodVars;
            }

            private static List<VariableInfo> GetVariablesByLocation(string javaCode, VariableLocation location)
            {
                List<VariableInfo> variables = new List<VariableInfo>();

                // Clean the code first
                string cleanCode = JavaVariableExtractor.RemoveCommentsAndStrings(javaCode);

                // Split into lines for processing
                string[] lines = cleanCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                bool inClass = false;
                bool inMainMethod = false;
                bool inOtherMethod = false;
                bool mainMethodStarted = false;
                bool otherMethodStarted = false;

                int classBraceLevel = 0;
                int mainMethodBraces = 0;
                int otherMethodBraces = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();

                    // Skip empty lines, package, import, comments
                    if (string.IsNullOrEmpty(line) || line.StartsWith("package ") ||
                        line.StartsWith("import ") || line.StartsWith("//") ||
                        line.StartsWith("/*") || line.StartsWith("*"))
                        continue;

                    // Track class entry
                    if (line.Contains("class ") && !line.Contains("//"))
                    {
                        inClass = true;
                        classBraceLevel = line.Count(c => c == '{');
                        continue;
                    }

                    if (!inClass) continue;

                    // Update class brace level
                    int lineOpenBraces = line.Count(c => c == '{');
                    int lineCloseBraces = line.Count(c => c == '}');
                    classBraceLevel += lineOpenBraces - lineCloseBraces;

                    // Exit class if braces balance to 0
                    if (classBraceLevel <= 0)
                    {
                        inClass = false;
                        continue;
                    }

                    // Track main method
                    if (line.Contains("public static void main") || line.Contains("static void main"))
                    {
                        inMainMethod = true;
                        mainMethodStarted = false;
                        mainMethodBraces = lineOpenBraces;

                        if (line.Contains("{"))
                            mainMethodStarted = true;
                        continue;
                    }

                    // Track other methods (not main)
                    if (!inMainMethod && IsMethodDeclaration(line))
                    {
                        inOtherMethod = true;
                        otherMethodStarted = false;
                        otherMethodBraces = lineOpenBraces;

                        if (line.Contains("{"))
                            otherMethodStarted = true;
                        continue;
                    }

                    // Handle main method processing
                    if (inMainMethod)
                    {
                        if (!mainMethodStarted && line.Contains("{"))
                        {
                            mainMethodStarted = true;
                            mainMethodBraces += lineOpenBraces;
                        }

                        if (mainMethodStarted)
                        {
                            mainMethodBraces += lineOpenBraces - lineCloseBraces;

                            if (mainMethodBraces <= 0)
                            {
                                inMainMethod = false;
                                mainMethodStarted = false;
                                continue;
                            }

                            if (location == VariableLocation.MainMethod)
                            {
                                var variable = JavaVariableExtractor.ExtractVariableFromLine(line, i + 1);
                                if (variable != null)
                                    variables.Add(variable);
                            }
                        }
                        continue;
                    }

                    // Handle other method processing
                    if (inOtherMethod)
                    {
                        if (!otherMethodStarted && line.Contains("{"))
                        {
                            otherMethodStarted = true;
                            otherMethodBraces += lineOpenBraces;
                        }

                        if (otherMethodStarted)
                        {
                            otherMethodBraces += lineOpenBraces - lineCloseBraces;

                            if (otherMethodBraces <= 0)
                            {
                                inOtherMethod = false;
                                otherMethodStarted = false;
                                continue;
                            }

                            if (location == VariableLocation.OtherMethods)
                            {
                                var variable = JavaVariableExtractor.ExtractVariableFromLine(line, i + 1);
                                if (variable != null)
                                    variables.Add(variable);
                            }
                        }
                        continue;
                    }

                    // Class-level variables (not inside any method)
                    if (!inMainMethod && !inOtherMethod && location == VariableLocation.ClassLevel)
                    {
                        var variable = JavaVariableExtractor.ExtractVariableFromLine(line, i + 1);
                        if (variable != null)
                            variables.Add(variable);
                    }
                }

                return variables;
            }

            private static bool IsMethodDeclaration(string line)
            {
                // Check for method patterns: [modifiers] returnType methodName(parameters)
                string methodPattern = @"(public|private|protected)?\s*(static)?\s*(void|\w+)\s+\w+\s*\([^)]*\)\s*\{?";
                return Regex.IsMatch(line, methodPattern) && !line.Contains("class ") && !line.Contains("main");
            }
        }

        public enum VariableLocation
        {
            ClassLevel,    // Variables declared at class level (fields)
            MainMethod,    // Variables inside main method
            OtherMethods   // Variables inside other methods
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

    // Advanced Parser Class
    public class JavaCodeParser
    {
        private string[] lines;
        private int currentLine;
        private bool inClass = false;
        private bool inMethod = false;
        private bool inMainMethod = false;
        private int braceLevel = 0;

        public JavaCodeParser(string javaCode)
        {
            string cleanCode = JavaVariableExtractor.RemoveCommentsAndStrings(javaCode);
            lines = cleanCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            currentLine = 0;
        }

        public VariableInfo FindFirstInitializedVariable()
        {
            for (currentLine = 0; currentLine < lines.Length; currentLine++)
            {
                string line = lines[currentLine].Trim();

                if (string.IsNullOrEmpty(line))
                    continue;

                UpdateParsingState(line);

                // Skip package and import statements
                if (line.StartsWith("package ") || line.StartsWith("import "))
                    continue;

                // Skip if we're in main method (excluding parameters)
                if (inMainMethod)
                    continue;

                // Look for variable declarations
                var variable = ParseVariableDeclaration(line);
                if (variable != null && !string.IsNullOrEmpty(variable.Value))
                {
                    return variable;
                }
            }

            return null;
        }

        private void UpdateParsingState(string line)
        {
            // Track class declarations
            if (line.Contains("class ") && !line.Contains("//"))
                inClass = true;

            // Track main method
            if (line.Contains("public static void main") || line.Contains("static void main"))
                inMainMethod = true;

            // Track other methods
            if (Regex.IsMatch(line, @"(public|private|protected)?\s*(static)?\s*\w+\s+\w+\s*\([^)]*\)\s*\{?"))
            {
                if (!line.Contains("main"))
                    inMethod = true;
            }

            // Track brace levels
            braceLevel += line.Count(c => c == '{') - line.Count(c => c == '}');

            // Exit main method when its braces close
            if (inMainMethod && braceLevel == 1 && line.Contains("}"))
                inMainMethod = false;
        }

        private VariableInfo ParseVariableDeclaration(string line)
        {
            // Enhanced patterns for different variable declarations
            List<string> patterns = new List<string>
        {
            // Basic types with initialization
            @"(int|double|float|long|short|byte|char|boolean)\s+(\w+)\s*=\s*([^;]+);",
            
            // String type
            @"(String)\s+(\w+)\s*=\s*([^;]+);",
            
            // Generic types (ArrayList, HashMap, etc.)
            @"(\w+(?:<[^>]+>)?)\s+(\w+)\s*=\s*([^;]+);",
            
            // var keyword (Java 10+)
            @"(var)\s+(\w+)\s*=\s*([^;]+);",
            
            // Final variables
            @"final\s+(int|double|float|long|short|byte|char|boolean|String|\w+(?:<[^>]+>)?)\s+(\w+)\s*=\s*([^;]+);",
            
            // Static variables (class level)
            @"static\s+(int|double|float|long|short|byte|char|boolean|String|\w+(?:<[^>]+>)?)\s+(\w+)\s*=\s*([^;]+);",
        };

            foreach (string pattern in patterns)
            {
                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var groups = match.Groups;
                    int typeIndex = 1;
                    int nameIndex = 2;
                    int valueIndex = 3;

                    // Handle patterns with "final" or "static"
                    if (pattern.Contains("final\\s+") || pattern.Contains("static\\s+"))
                    {
                        typeIndex = 2;
                        nameIndex = 3;
                        valueIndex = 4;
                    }

                    return new VariableInfo
                    {
                        Type = groups[typeIndex].Value.Trim(),
                        Name = groups[nameIndex].Value.Trim(),
                        Value = groups[valueIndex].Value.Trim(),
                        LineNumber = currentLine + 1,
                        FullDeclaration = match.Value.Trim()
                    };
                }
            }

            return null;
        }
    }
}
