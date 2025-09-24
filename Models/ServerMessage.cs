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
        public bool? isFocused { get; set; }

        [ProtoMember(7)]
        public Notification notification { get; set; }
        public ServerMessage()
        {
        }

        public class Builder
        {
            private readonly ServerMessage msg = new ServerMessage();

            private readonly List<MessageType> messageTypesRequiringContent = new List<MessageType>
            {
                Enums.MessageType.ServerTask,
                Enums.MessageType.StudentProgress,
                Enums.MessageType.LogInSuccessful,
                Enums.MessageType.UserProfile,
                Enums.MessageType.IsEyesOnMe
            };

            public Builder(MessageType messageType)
            {
                msg._messageType = messageType;
            }

            public Builder MessageType(MessageType messageType)
            {
                msg._messageType = messageType;
                return this;
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

            public Builder Focused(bool isFocused)
            {
                msg.isFocused = isFocused;
                return this;
            }

            public Builder Notification(Notification notification)
            {
                msg.notification = notification;
                return this;
            }

            public ServerMessage Build()
            {
                // Validation can be added here
                if (msg._messageType == null)
                    throw new InvalidOperationException("Message Type is required");

                bool isContentRequired = messageTypesRequiringContent.Contains(msg._messageType.Value);
                bool hasContent = msg._task != null || msg._progress != null || msg._userProfile != null || msg.isFocused != null;
                if (!hasContent && isContentRequired)
                    throw new InvalidOperationException("Message Content is required");

                return msg;
            }
        }
    }
}
