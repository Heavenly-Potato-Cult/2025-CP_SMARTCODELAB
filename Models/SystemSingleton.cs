using System;
using System.Collections.Generic;
using System.Linq;
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

        public string? currentTaskPath { get; set; }

        public TabPage page1 {  get; set; }
    }
}
