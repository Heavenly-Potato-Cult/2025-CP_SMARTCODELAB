using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models.Enums
{
    [ProtoContract]
    public enum NotificationType
    {
        CopyPasted,
        Submitted,
        TestResult,
        LoggedIn,
        LoggedOut,
        ExceptionThrown
    }

    static class NotificationTypeExtensions
    {
        public static string ToFriendlyString(this NotificationType type)
        {
            return type switch
            {
                NotificationType.CopyPasted => "Copy Paste",
                NotificationType.Submitted => "Submission",
                NotificationType.LoggedIn => "Logged In",
                NotificationType.LoggedOut => "Logged Out",
                NotificationType.ExceptionThrown => "Exceptions Encounter",
                _ => string.Empty
            };
        }
    }
}
