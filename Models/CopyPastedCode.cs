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
        public string wholeCode {  get; set; }

        [ProtoMember(2)]
        public int start { get; set; }

        [ProtoMember(3)]
        public int end { get; set; }

        public CopyPastedCode(string wholeCode, int start, int end)
        {
            this.wholeCode = wholeCode;
            this.start = start;
            this.end = end;
        }

        public CopyPastedCode()
        {
        }
    }
}
