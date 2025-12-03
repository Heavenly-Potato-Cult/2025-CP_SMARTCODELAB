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

        [ProtoMember(3)]
        public string senderName { get; set; }

        [ProtoMember(4)]
        public bool IsBroadcast { get; set; }
        public UserMessage(string message)
        {
            this.message = message;
            this.isFromMe = true;
        }

        public UserMessage(string message, bool isFromMe, string senderName = "", bool isBroadcast = false)
        {
            this.message = message;
            this.isFromMe = false;
            this.senderName = senderName;
            this.IsBroadcast = isBroadcast;
        }

        public UserMessage()
        {
        }
    }
}
