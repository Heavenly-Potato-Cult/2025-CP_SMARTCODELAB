using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class ProgrammingConfiguration
    {
        //Python
        public static string pythonExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Python", "python.exe");

        public static string lizardExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "lizard_portable.exe");
        public static string pylintExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "pylint_portable.exe");
        public static string blackExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "black_portable.exe");
        public static string readabilityConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "readabilityConfig.pylintrc");
        public static string SYNTAX_CHECKER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "SyntaxChecker.py");
        public static string PYTHON_OPERATOR_COUNTER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "operator_counter.py");
        public static string PYTHON_COUNTER_INITIALIZER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "PythonOperatorCounterInitializer.py");

        public static string ruffExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff.exe");
        public static string ruffConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff_config.toml");
        public static string ruffReadability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff_config.toml");
        public static string ruffMaintainability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff_maintainability_rules.toml");
        public static string ruffRobustness = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "python", "ruff_robustness_rules.toml");

        //C++
        public static string gccExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "C++", "MinGW64", "bin","g++");
        public static string gccBin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "C++", "MinGW64", "bin");
        public static string CLANG_TIDY_EXE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "LLVM", "bin", "clang-tidy.exe");
        public static string CLANG_FORMAT_EXE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "LLVM", "bin", "clang-format.exe");
        public static string CPPLINT_EXE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "cpplint_wrapper.exe");
        public static string CPPLINT_CONFIG = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "syntax_checker.cpplintrc");
        public static string CPP_OPERATOR_COUNTER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "operator_counter.py");
        public static string CPP_COUNTER_INITIALIZER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "CppOperatorCounterInitializer.py");
        public static string CPP_ROBUSTNESS_CHECKS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "robustness.clang-tidy");
        public static string CPP_MAINTAINABILITY_CHECKS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "cpp", "maintainability.clang-tidy");

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
        public static string pmdPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "pmd-bin-7.17.0", "bin", "pmd");
        public static string checkStyleConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "simple_checks.xml");
        public static string javaExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Java", "jdk-21.0.8", "bin", "java.exe");
        public static string javac = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Java", "jdk-21.0.8", "bin", "javac");
        public static string namingConventionChecker = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "defaultNamingConvention.xml");
        public static string checkstyleReadability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java","checkstyle_rules", "readability_rules.xml");
        public static string checkstyleMaintainability = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "checkstyle_rules", "maintainability_rules.xml");
        public static string pmdRobustness = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "checkstyle_rules", "robustness_rules.xml");
        public static string JAVA_OPERATOR_COUNTER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "JavaEfficiencyAnalyzer-1.0.jar");
        public static string JAVA_COUNTER_INITIALIZER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "JavaOperatorCounterInitializer.jar");
        public static string JAVA_SYNTAX_CHECKER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "SyntaxChecker.jar");
        public static string JAVA_SYNTAX_FORMATTER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "java-formatter.jar");

        //activity file locations
        public static string COUNTER_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "counter");

    }
}
