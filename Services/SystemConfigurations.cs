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
        public static readonly string TASK_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks");
        public static readonly string CONFIGURATION_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig");
        public static readonly string SUBJECTS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks","Subjects.txt");
        public static string SESSIONS_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SessionsFolder");

        public static readonly string OPEN_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "setup_firewall.bat");
        public static readonly string REMOVE_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "cleanup_firewall.bat");

        public static readonly string JAVA_BROADCASTEXTRACT_CLASS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "NetworkAddressExtractor");

        public static readonly string MONITORED_MUSIC = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "akatsuki.wav");
        public static readonly string MSG_NOTIFICATION = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "messaged.wav");
    }
}
