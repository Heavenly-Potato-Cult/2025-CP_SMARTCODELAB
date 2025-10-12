using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class SubmittedCode
    {
        public SubmittedCode()
        {
        }

        public SubmittedCode(string sourceCode, UserProfile user)
        {
            this.sourceCode = sourceCode;
            this.user = user;
        }

        public SubmittedCode(string sourceCode)
        {
            this.sourceCode = sourceCode;
        }

        [ProtoMember(1)]
        public string sourceCode { get; set; }

        [ProtoMember(2)]
        public UserProfile user {  get; set; }
    }
}
