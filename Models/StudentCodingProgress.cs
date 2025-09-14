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
        public string sourceCode { get; set; }

        [ProtoMember(2)]
        public List<string> CodeProgress { get; set; }

        public StudentCodingProgress()
        {
            CodeProgress = new List<string>();
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
            CodeProgress = new List<string>();
        }
    }
}
