using ProtoBuf;
using SmartCodeLab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class ServerMessage
    {
        [ProtoMember(1)]
        public MessageType? _messageType {  get; set; }

        [ProtoMember(2)]
        public TaskModel? _task {  get; set; }

        [ProtoMember(3)]
        public StudentCodingProgress? _progress { get; set; }

        [ProtoMember(4)]
        public UserProfile? _userProfile { get; set; }

        [ProtoMember(5)]
        public string? _errorMessage { get; set; }

        [ProtoMember(6)]
        public Notification notification { get; set; }

        [ProtoMember(7)]
        public SubmittedCode submittedCode { get; set; }

        [ProtoMember(8)]
        public UserMessage userMessage { get; private set; }

        [ProtoMember(9)]
        public List<SubmittedCode> leaderboards { get; set; }
        public ServerMessage()
        {
        }

        public class Builder
        {
            private readonly ServerMessage msg = new ServerMessage();

            private readonly List<MessageType> messageTypesRequiringContent = new List<MessageType>
            {
                Enums.MessageType.SERVER_TASK,
                Enums.MessageType.STUDENT_PROGRESS,
                Enums.MessageType.LOG_IN_SUCCESSFUL,
                Enums.MessageType.USER_PROFILE,
                Enums.MessageType.CODE_SUBMISSION
            };

            public Builder(MessageType messageType)
            {
                msg._messageType = messageType;
            }

            public Builder ErrorMessage(string errorMessage)
            {
                msg._errorMessage = errorMessage;
                return this;
            }

            public Builder Task(TaskModel task)
            {
                msg._task = task;
                return this;
            }

            public Builder StudentProgress(StudentCodingProgress progress)
            {
                msg._progress = progress;
                return this;
            }

            public Builder UserProfile(UserProfile profile)
            {
                msg._userProfile = profile;
                return this;
            }

            public Builder Notification(Notification notification)
            {
                msg.notification = notification;
                return this;
            }

            public Builder SubmittedCode(SubmittedCode submittedCode)
            {
                msg.submittedCode = submittedCode;
                return this;
            }

            public Builder Leaderboards(List<SubmittedCode> leaderboards)
            {
                msg.leaderboards = leaderboards;
                return this;
            }

            public Builder UserMessage(UserMessage userMessage)
            {
                msg.userMessage = userMessage;
                return this;
            }

            public ServerMessage Build()
            {
                bool isContentRequired = messageTypesRequiringContent.Contains(msg._messageType.Value);
                bool hasContent = msg._task != null || msg._progress != null || msg._userProfile != null || msg.submittedCode != null;
                if (!hasContent && isContentRequired)
                    throw new InvalidOperationException("Message Content is required");

                return msg;
            }
        }
    }
}
