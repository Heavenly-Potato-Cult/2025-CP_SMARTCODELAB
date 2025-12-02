using ProtoBuf;

namespace SmartCodeLab.Models.Enums
{
    [ProtoContract]
    public enum MessageType
    {
        STUDENT_PROGRESS,
        PROGRESS_REQUEST,
        SERVER_TASK,
        SERVER_TASK_REQUEST,
        USER_PROFILE,
        LOG_IN_SUCCESSFUL,
        LOG_IN_FAILED,
        TASK_UPDATE,
        NOTIFICATION,
        CODE_SUBMISSION,
        USER_MESSAGE,
        LEADERBOARDS_UPDATE,
        MONITORED,
        LEFT_ALONE,
        KICKED
    }
}
