using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class StudentCodingProgress
    {
        [ProtoMember(1)]
        public string msg { get; set; }

        public StudentCodingProgress()
        {
        }

        public StudentCodingProgress(string msg)
        {
            this.msg = msg;
        }
    }
}
