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

        public List<string> CodeProgress = new List<string>();

        public StudentCodingProgress()
        {
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
        }
    }
}
