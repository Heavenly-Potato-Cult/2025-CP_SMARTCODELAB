using ProtoBuf;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class ProgrammingSession
    {
        [ProtoMember(1)]
        public Server server { get; set; }

        [ProtoMember(2)]
        public Dictionary<string, StudentCodingProgress> userProgress { get; set; }

        [ProtoMember(3)]
        public List<Notification> notifications { get; set; }

        [ProtoMember(4)]
        public List<SubmittedCode> codeSubmission { get; set; }

        [ProtoMember(5)]
        public DateTime lastModified { get; set; }

        [ProtoMember(6)]
        public Dictionary<string, UserProfile> users;

        public ProgrammingSession(Server server, Dictionary<string,
            StudentCodingProgress> userProgress,
            List<Notification> notifications,
            List<SubmittedCode> codeSubmission, Dictionary<string, UserProfile> users)
        {
            this.server = server;
            this.userProgress = userProgress;
            this.notifications = notifications;
            this.codeSubmission = codeSubmission;
            lastModified = DateTime.Now;
            this.users = users;
        }

        public ProgrammingSession()
        {
        }
    }
}
