using ProtoBuf;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class Notification
    {
        [ProtoMember(1)]
        public NotificationType Type { get; set; }

        [ProtoMember(2)]
        public string Message { get; set; }

        [ProtoMember(3)]
        public string UserName { get; set; }

        public Notification(NotificationType type, string message, string userName)
        {
            Type = type;
            Message = message;
            UserName = userName;
        }
    }
}
