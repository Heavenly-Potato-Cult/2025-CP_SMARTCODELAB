using ProtoBuf;
using SmartCodeLab.CustomComponents.Pages.ServerPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class ProgrammingSession
    {
        //[ProtoMember(1)]
        //public Server server { get; set; }

        //public ProgrammingSession(Server server)
        //{
        //    this.server = server;
        //}

        [ProtoMember(1)]
        public Dictionary<string, StudentCodingProgress> userProgress { get; set; }

        [ProtoMember(2)]
        public List<Notification> notifications { get; set; }

        public ProgrammingSession(Dictionary<string, StudentCodingProgress> userProgress, List<Notification> notifications)
        {
            this.userProgress = userProgress;
            this.notifications = notifications;
        }



        [ProtoMember(3)]
        public Dictionary<string, StudentSubmittedIcon> codeSubmission { get; set; }

        public ProgrammingSession(Dictionary<string, StudentCodingProgress> userProgress, List<Notification> notifications, Dictionary<string, StudentSubmittedIcon> codeSubmission) : this(userProgress, notifications)
        {
            this.codeSubmission = codeSubmission;
        }


        //public ProgrammingSession(Server server, Dictionary<string, 
        //    StudentCodingProgress> userProgress, 
        //    List<Notification> notifications, 
        //    Dictionary<string, StudentSubmittedIcon> codeSubmission)
        //{
        //    this.server = server;
        //    this.userProgress = userProgress;
        //    this.notifications = notifications;
        //    this.codeSubmission = codeSubmission;
        //}



        public ProgrammingSession()
        {
        }
    }
}
