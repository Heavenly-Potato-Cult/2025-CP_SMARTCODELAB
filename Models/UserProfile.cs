using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class UserProfile
    {
        [ProtoMember(1)]
        public string _studentName { get; set; }

        [ProtoMember(2)]
        public IPAddress _computerAddress { get; set; }
    }
}
