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
        public List<Notification> notifications { get; set; }

        //[ProtoMember(4)]
        //public List<SubmittedCode> codeSubmission { get; set; }

        [ProtoMember(3)]
        public DateTime lastModified { get; set; }

        [ProtoMember(4)]
        public int copyPasteCount { get; set; }

        [ProtoMember(5)]
        public Dictionary<string, StudentCodingProgress> userProgress { get; set; }

        //[ProtoMember(6)]
        //public Dictionary<string, UserProfile> users;

        public ProgrammingSession(Server server,
            List<Notification> notifications,
            //List<SubmittedCode> codeSubmission, 
            //Dictionary<string, UserProfile> users,
            int copyPasteCount,
            Dictionary<string, StudentCodingProgress> userProgress
            )
        {
            this.server = server;
            this.userProgress = userProgress ?? new Dictionary<string, StudentCodingProgress>();
            this.notifications = notifications  ?? new List<Notification>();
            //this.codeSubmission = codeSubmission ?? new List<SubmittedCode>();
            lastModified = DateTime.Now;
            this.copyPasteCount = copyPasteCount;
            //this.users = users;
        }

        public ProgrammingSession()
        {
            server = new Server();
            userProgress = new Dictionary<string, StudentCodingProgress>();
            notifications = new List<Notification>();
            //codeSubmission = new List<SubmittedCode>();
            //users = new Dictionary<string, UserProfile>();
            lastModified = DateTime.Now;
            copyPasteCount = 0;
        }
    }
}
