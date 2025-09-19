using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class CopyPastedCode
    {
        [ProtoMember(1)]
        public int line {  get; set; }

        [ProtoMember(2)]
        public string pastedCode { get; set; }

        [ProtoMember(3)]
        public string codeBefore { get; set; }

        [ProtoMember(4)]
        public string codeAfter { get; set; }
    }
}
