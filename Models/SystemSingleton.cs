using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    public class SystemSingleton
    {
        private static readonly Lazy<SystemSingleton> _instance =
        new Lazy<SystemSingleton>(() => new SystemSingleton());

        private SystemSingleton() { }

        public static SystemSingleton Instance => _instance.Value;

        public TcpClient? client { get; set; }

        public bool _loggedIn = false;
        public string? currentTaskPath { get; set; }

        public TabPage page1 {  get; set; }
        public TabPage page2 { get; set; }
        public TabPage page3 { get; set; }
        public TabPage sessionLogsPage { get; set; }

        public Action saveSession { get; set; }
    }
}
