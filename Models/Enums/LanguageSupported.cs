﻿using ProtoBuf;
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
        [ProtoEnum]
        Cpp = 0,
        [ProtoEnum]
        Java = 1,
        [ProtoEnum]
        Python = 2
    }
}
