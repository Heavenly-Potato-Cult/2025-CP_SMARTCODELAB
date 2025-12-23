using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartCodeLab.Services
{
    public class SystemConfigurations
    {
        static string APP_LOCAL_DATA_FOLDER_NAME = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SmartCodeLab"
        );
        public static readonly string TASK_FOLDER = Path.Combine(APP_LOCAL_DATA_FOLDER_NAME,"tasks");

        public static readonly string CONFIGURATION_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig");
        public static readonly string SUBJECTS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks","Subjects.txt");
        public static string SESSIONS_FOLDER = Path.Combine(APP_LOCAL_DATA_FOLDER_NAME, "SessionsFolder");

        public static readonly string OPEN_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "setup_firewall.bat");
        public static readonly string REMOVE_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "cleanup_firewall.bat");

        public static readonly string JAVA_BROADCASTEXTRACT_CLASS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "NetworkAddressExtractor");

        public static readonly string MONITORED_MUSIC = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "akatsuki.wav");
        public static readonly string MSG_NOTIFICATION = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "messaged.wav");

        public static string javaFolder = Path.Combine(APP_LOCAL_DATA_FOLDER_NAME, "smartcodelabactivities", "java");
        public static string pythonFolder = Path.Combine(APP_LOCAL_DATA_FOLDER_NAME, "smartcodelabactivities", "python");
        public static string cppFolder = Path.Combine(APP_LOCAL_DATA_FOLDER_NAME, "smartcodelabactivities", "cpp");
    }
}
