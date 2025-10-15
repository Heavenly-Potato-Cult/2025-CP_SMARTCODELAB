using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    }
}
