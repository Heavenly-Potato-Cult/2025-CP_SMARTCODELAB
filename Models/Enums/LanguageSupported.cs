using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models.Enums
{
    [ProtoContract]
    public enum LanguageSupported
    {
        Cpp = 0,
        Java = 1,
        Python = 2
    }
}
