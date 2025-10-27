using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class UserMessage
    {

        [ProtoMember(1)]
        public string message { get; set; }

        [ProtoMember(2)]
        public bool isFromMe { get; set; }

        public UserMessage(string message)
        {
            this.message = message;
            this.isFromMe = true;
        }

        public UserMessage(string message, bool isFromMe)
        {
            this.message = message;
            this.isFromMe = false;
        }

        public UserMessage()
        {
        }
    }
}
