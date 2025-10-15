using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class SystemConfigurations
    {
        public static readonly string TASK_FOLDER = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks");

        public static readonly string OPEN_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "setup_firewall.bat");
        public static readonly string REMOVE_FIREWALL_PORTS_BAT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "smartcodelabconfig", "cleanup_firewall.bat");
    }
}
