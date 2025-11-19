
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartCodeLab.Services
{
    public class SingleStatementBodyChecker
    {
        private enum TokenType
        {
            Code,
            String,
            Comment
        }

        public class DetectionResult
        {
            public bool HasSingleStatementBodies { get; set; }
            public List<string> Details { get; set; } = new List<string>();

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Has Single-Statement Bodies: {HasSingleStatementBodies}");
                if (Details.Count > 0)
                {
                    sb.AppendLine("Details:");
                    foreach (var detail in Details)
                    {
                        sb.AppendLine($"  - {detail}");
                    }
                }
                return sb.ToString();
            }
        }

        public DetectionResult CheckForSingleStatementBodies(string code)
        {
            var result = new DetectionResult();

            // First, remove all strings and comments from the code
            string cleanedCode = RemoveStringsAndComments(code);

            // Split into lines for better analysis
            string[] lines = cleanedCode.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                // Check for control structures (if, else, for, while, do)
                if (IsControlStructure(line))
                {
                    // Check if it's followed by a single statement (no opening brace)
                    if (HasSingleStatementBody(lines, i))
                    {
                        result.HasSingleStatementBodies = true;
                        result.Details.Add($"Line {i + 1}: {line.Substring(0, Math.Min(60, line.Length))}...");
                    }
                }
            }

            return result;
        }

        private string RemoveStringsAndComments(string code)
        {
            var result = new StringBuilder();
            int i = 0;

            while (i < code.Length)
            {
                // Check for single-line comment
                if (i < code.Length - 1 && code[i] == '/' && code[i + 1] == '/')
                {
                    // Skip until end of line
                    while (i < code.Length && code[i] != '\n')
                    {
                        result.Append(' '); // Replace with space to maintain positions
                        i++;
                    }
                    if (i < code.Length)
                    {
                        result.Append('\n');
                        i++;
                    }
                    continue;
                }

                // Check for multi-line comment
                if (i < code.Length - 1 && code[i] == '/' && code[i + 1] == '*')
                {
                    result.Append(' ');
                    result.Append(' ');
                    i += 2;

                    // Skip until end of comment
                    while (i < code.Length - 1)
                    {
                        if (code[i] == '*' && code[i + 1] == '/')
                        {
                            result.Append(' ');
                            result.Append(' ');
                            i += 2;
                            break;
                        }
                        result.Append(code[i] == '\n' ? '\n' : ' '); // Preserve newlines
                        i++;
                    }
                    continue;
                }

                // Check for double-quoted string
                if (code[i] == '"')
                {
                    result.Append(' ');
                    i++;

                    // Skip until end of string
                    while (i < code.Length)
                    {
                        if (code[i] == '\\' && i < code.Length - 1)
                        {
                            // Skip escaped character
                            result.Append(' ');
                            result.Append(' ');
                            i += 2;
                            continue;
                        }
                        if (code[i] == '"')
                        {
                            result.Append(' ');
                            i++;
                            break;
                        }
                        result.Append(' ');
                        i++;
                    }
                    continue;
                }

                // Check for single-quoted string (character literal)
                if (code[i] == '\'')
                {
                    result.Append(' ');
                    i++;

                    // Skip until end of string
                    while (i < code.Length)
                    {
                        if (code[i] == '\\' && i < code.Length - 1)
                        {
                            // Skip escaped character
                            result.Append(' ');
                            result.Append(' ');
                            i += 2;
                            continue;
                        }
                        if (code[i] == '\'')
                        {
                            result.Append(' ');
                            i++;
                            break;
                        }
                        result.Append(' ');
                        i++;
                    }
                    continue;
                }

                // Regular code character
                result.Append(code[i]);
                i++;
            }

            return result.ToString();
        }

        private bool IsControlStructure(string line)
        {
            // Match control structures: if, else if, else, for, while, do-while
            // Must be followed by either parentheses or nothing (for else)
            // Also handles Java/C++ enhanced for loops and C++ range-based for loops

            var patterns = new[]
            {
            @"^\s*if\s*\(",
            @"^\s*else\s+if\s*\(",
            @"^\s*else\s*($|\s)",
            @"^\s*for\s*\(",
            @"^\s*while\s*\(",
            @"^\s*do\s*($|\s)",
            @"^\s*catch\s*\(",  // Java/C++ exception handling
            @"^\s*synchronized\s*\("  // Java synchronized blocks
        };

            foreach (var pattern in patterns)
            {
                if (Regex.IsMatch(line, pattern))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasSingleStatementBody(string[] lines, int controlLineIndex)
        {
            string controlLine = lines[controlLineIndex].Trim();

            // If the control line itself contains an opening brace, it's not a single statement
            if (controlLine.Contains("{"))
            {
                return false;
            }

            // Special case: 'else' might be on the same line as the statement
            if (controlLine.StartsWith("else") && !controlLine.EndsWith("else"))
            {
                // Check if the rest of the line after 'else' is a statement
                string afterElse = controlLine.Substring(4).Trim();
                if (!string.IsNullOrEmpty(afterElse) && !afterElse.StartsWith("if"))
                {
                    return true; // Single statement on same line as else
                }
            }

            // Look at the next non-empty line
            for (int i = controlLineIndex + 1; i < lines.Length; i++)
            {
                string nextLine = lines[i].Trim();

                if (string.IsNullOrWhiteSpace(nextLine))
                {
                    continue; // Skip empty lines
                }

                // If next line starts with opening brace, it's a block statement
                if (nextLine.StartsWith("{"))
                {
                    return false;
                }

                // If we found a non-empty line that's not a brace, it's likely a single statement
                // But we need to check if it's not another control structure with a brace
                if (!nextLine.Contains("{"))
                {
                    return true; // Single statement body detected
                }

                // If the line contains both code and opening brace, check if it's part of the same statement
                // For example: if (x) someFunction() { ... } would be on one line ideally
                // But if broken: if (x) \n someFunction();  <- this is single statement
                return false;
            }

            return false;
        }
    }
}
