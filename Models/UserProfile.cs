using ProtoBuf;
using SmartCodeLab.Services;
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
        public string? _computerAddress { get; set; }

        [ProtoMember(3)]
        public string? _studentId { get; set; }

        [ProtoMember(4)]
        public string? _password { get; set; }

        public UserProfile()
        {
        }

        public UserProfile(string studentName, string studentId, string password)
        {
            _studentName = studentName;
            _studentId = studentId;
            _password = password;
            _computerAddress = NetworkServices.GetLocalIPv4();
        }

        public UserProfile(string studentId, string password)
        {
            _studentId = studentId;
            _password = password;
            _computerAddress = NetworkServices.GetLocalIPv4();
        }

        public UserProfile(string studentId, string studentName, bool isForTable)
        {
            _studentId = studentId;
            _studentName = studentName;
        }
    }
}
