using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SmartCodeLab.Models;

namespace SmartCodeLab.Services
{
    public class ProgrammingConfiguration
    {
        //Python
        public static string pythonExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Python", "python.exe");

        public static string lizardExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "lizard_portable.exe");
        public static string pylintExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "pylint_portable.exe");
        public static string readabilityConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "readabilityConfig.pylintrc");
        public static string errorConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "errorConfig.pylintrc");


        public static string ruffExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff.exe");
        public static string ruffConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff_config.toml");

        //C++
        public static string gccExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "C++", "MinGW64", "bin","g++");
        public static string gccBin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "C++", "MinGW64", "bin");
        public static string CPPLINT_EXE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "cpplint_wrapper.exe");
        public static string CPPLINT_CONFIG = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "syntax_checker.cpplintrc");

        //Java
        public static Dictionary<NamingConvention, string> namingConventionProperties = new Dictionary<NamingConvention, string>()
        { 
            {NamingConvention.SnakeCase, "^[a-z][a-z0-9]*(_[a-z0-9]+)*$"},
            {NamingConvention.CamelCase, "^[a-z][a-zA-Z0-9]*$" },
            {NamingConvention.Unknown, "^[a-z][a-zA-Z0-9]*$" },
            {NamingConvention.PascalCase, "^[A-Z][a-zA-Z0-9]*$" },
            {NamingConvention.UpperSnakeCase, "^[A-Z][A-Z0-9]*(_[A-Z0-9]+)*$" },
        };
        public static string checkStylePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "checkstyle-11.0.1-all.jar");
        public static string checkStyleConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "simple_checks.xml");
        public static string javaExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Java", "jdk-21.0.8", "bin", "java.exe");
        public static string javac = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Java", "jdk-21.0.8", "bin", "javac");
        public static string namingConventionChecker = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "defaultNamingConvention.xml");

        //activity file locations
        public static string javaFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabactivities", "java");
        public static string pythonFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabactivities", "python");
        public static string cppFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabactivities", "cpp");

        //readability comments
        public static readonly Dictionary<string, ReadabilityIssues> readabilityIssues = new Dictionary<string, ReadabilityIssues>()
        {
            {
                "Improper or Inconsistent Indentation",
                new ReadabilityIssues(
                    "Inconsistent indentation makes code difficult to follow and understand. Proper indentation visually represents the structure of your code, showing which statements belong together.",
                    "if (x > 0)\n{\n    cout << \"Positive\";\n    if (x > 10)\n    {\n        cout << \"Large\";\n    }\n}",
                    "if (x > 0) {\ncout << \"Positive\";\n    if (x > 10) {\n    cout << \"Large\";\n}\n}"
                )
            },
            {
                "Using Different Naming Conventions",
                new ReadabilityIssues(
                    "Mixing naming styles (like camelCase, snake_case, and PascalCase) causes confusion and inconsistency across your codebase. Consistent naming improves readability and professionalism.",
                    "int studentName;\nint studentAge;\nint studentGrade;",
                    "int StudentName;\nint student_age;\nint STUDENTgrade;"
                )
            },
            {
                "Multiple Assignments per Line",
                new ReadabilityIssues(
                    "Placing multiple assignments on the same line makes the code harder to debug and understand, especially when side effects are involved. Each line should express a single idea.",
                    "a = 0;\nb = 0;\nc = 0;\n\nx = 5;\ny = 10;\nz = 15;",
                    "a = b = c = 0;\nx = 5; y = 10; z = 15;"
                )
            },
            {
                "Multiple Variable Declarations per Line",
                new ReadabilityIssues(
                    "Declaring multiple variables on one line can hide initialization issues and reduce clarity. Declaring one per line makes the purpose of each variable clear.",
                    "int x = 0;\nint y = 1;\nint z = 2;",
                    "int x = 0, y = 1, z = 2;"
                )
            },
            {
                "Nested Loops and Conditional Statements",
                new ReadabilityIssues(
                    "Deep nesting (e.g., loops inside conditionals inside loops) quickly becomes hard to read and debug. Try breaking logic into smaller functions or using early returns.",
                    "for (int i = 0; i < n; i++)\n{\n    if (arr[i] > 0)\n    {\n        handleMatch(arr[i], data, m);\n    }\n}\n\nvoid handleMatch(int value, int data[], int m)\n{\n    for (int j = 0; j < m; j++)\n    {\n        if (data[j] == value)\n        {\n            process(value, j);\n        }\n    }\n}",
                    "for (int i = 0; i < n; i++) {\n    if (arr[i] > 0) {\n        for (int j = 0; j < m; j++) {\n            if (data[j] == arr[i]) {\n                process(i, j);\n            }\n        }\n    }\n}"
                )
            },
            {
                "Multiple Conditional Expressions",
                new ReadabilityIssues(
                    "Long conditions with several logical operators (&&, ||) are hard to read and reason about. Breaking them into smaller, named checks makes logic clearer.",
                    "bool isEligibleByAge = (age > 18 && score >= 75);\nbool isEligibleByMembership = (isMember && credits > 10 && !banned);\n\nif (isEligibleByAge || isEligibleByMembership)\n{\n    approve();\n}",
                    "if ((age > 18 && score >= 75) || (isMember && credits > 10 && !banned)) {\n    approve();\n}"
                )
            }
        };

        

    }
}
