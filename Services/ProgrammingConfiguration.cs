using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class ProgrammingConfiguration
    {
        //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string checkStylePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "checkstyle-11.0.1-all.jar");
        public static string checkStyleConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "linters", "java", "simple_checks.xml");
        public static string javaExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners","Java", "jdk-21.0.8","bin", "java.exe");
        public static string javac = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Java", "jdk-21.0.8", "bin", "javac");

        public static string pythonExe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "languageRunners", "Python", "python.exe");
    }
}
