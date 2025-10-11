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

        public SubmittedCode(string sourceCode, UserProfile user, int placement)
        {
            this.sourceCode = sourceCode;
            this.user = user;
            this.placement = placement;
        }

        public SubmittedCode(string sourceCode)
        {
            this.sourceCode = sourceCode;
        }

        [ProtoMember(1)]
        public string sourceCode { get; set; }

        [ProtoMember(2)]
        public UserProfile user {  get; set; }

        [ProtoMember(3)]
        public int placement { get; set; }

        public void IncreasePlacement() 
        {
            placement--;
        }
    }
}
