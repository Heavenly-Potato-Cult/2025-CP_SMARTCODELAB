using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartCodeLab.Services.NamingConventions
{
    public class JavaNamingConvention
    {
        public static class NamingConventionDetector
        {
            // Regex patterns for each naming convention
            private static readonly Regex PascalCaseRegex =
                new Regex(@"^[A-Z][a-zA-Z0-9]*$", RegexOptions.Compiled);

            private static readonly Regex CamelCaseRegex =
                new Regex(@"^[a-z][a-zA-Z0-9]*$", RegexOptions.Compiled);

            private static readonly Regex SnakeCaseRegex =
                new Regex(@"^[a-z][a-z0-9]*(_[a-z0-9]+)*$", RegexOptions.Compiled);

            private static readonly Regex UpperSnakeCaseRegex =
                new Regex(@"^[A-Z][A-Z0-9]*(_[A-Z0-9]+)*$", RegexOptions.Compiled);

            private static readonly Regex KebabCaseRegex =
                new Regex(@"^[a-z][a-z0-9]*(-[a-z0-9]+)*$", RegexOptions.Compiled);

            /// <summary>
            /// Detects the naming convention of a given word/identifier
            /// </summary>
            /// <param name="identifier">The word to analyze</param>
            /// <returns>The detected naming convention</returns>
            public static NamingConvention DetectConvention(string identifier)
            {
                if (string.IsNullOrWhiteSpace(identifier))
                    return NamingConvention.Unknown;

                // Check for simple cases first
                //if (identifier.All(char.IsUpper))
                //    return NamingConvention.UpperCase;

                if (identifier.All(char.IsLower))
                    return NamingConvention.LowerCase;

                // Check complex naming conventions
                if (PascalCaseRegex.IsMatch(identifier))
                    return NamingConvention.PascalCase;

                if (CamelCaseRegex.IsMatch(identifier))
                    return NamingConvention.CamelCase;

                if (UpperSnakeCaseRegex.IsMatch(identifier))
                    return NamingConvention.UpperSnakeCase;

                if (SnakeCaseRegex.IsMatch(identifier))
                    return NamingConvention.SnakeCase;

                if (KebabCaseRegex.IsMatch(identifier))
                    return NamingConvention.KebabCase;

                return NamingConvention.Unknown;
            }

            /// <summary>
            /// Detects convention and returns detailed information
            /// </summary>
            public static NamingConvention AnalyzeIdentifier(string identifier)
            {
                return DetectConvention(identifier);
            }

        }
    }
}
