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

        [ProtoMember(4)]
        public string testResult { get; set; }

        [ProtoMember(5)]
        public DateTime timeOccurred { get; set; }


        public Notification(NotificationType type, string userName, string testResult = "")
        {
            Type = type;
            UserName = userName;
            this.testResult = testResult;
            Message = NotificationMessage(type, testResult);
            timeOccurred = DateTime.Now;
        }

        public Notification()
        {
        }

        private string NotificationMessage(NotificationType type, string testResult = "")
        {
            switch (type)
            {
                case NotificationType.CopyPasted:
                    return "performed code copy-paste";

                case NotificationType.Submitted:
                    return "submitted their code for evaluation";

                case NotificationType.TestResult:
                    return $"tested the code with a result of {testResult}";

                case NotificationType.LoggedIn:
                    return "has logged into the programming server";

                case NotificationType.LoggedOut:
                    return "has logged out of the programming server";
                case NotificationType.ExceptionThrown:
                    return $"code threw an \"{testResult}\"";

                default:
                    return "has performed an action";
            }
        }
    }
}
