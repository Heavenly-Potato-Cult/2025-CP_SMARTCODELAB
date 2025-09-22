using ProtoBuf;

namespace SmartCodeLab.Models.Enums
{
    [ProtoContract]
    public enum MessageType
    {
        StudentProgress,
        ServerTask,
        ServerTaskRequest,
        UserProfile,
        LogInSuccessful,
        LogInFailed,
        IsEyesOnMe,
        TaskUpdate,
        Notification
    }
}
