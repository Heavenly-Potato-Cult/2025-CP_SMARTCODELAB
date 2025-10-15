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
    }
}
