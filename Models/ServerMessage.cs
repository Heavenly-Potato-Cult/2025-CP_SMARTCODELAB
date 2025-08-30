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
    public class ServerMessage
    {
        [ProtoMember(1)]
        public MessageType? _messageType {  get; set; }

        [ProtoMember(2)]
        public TaskModel? _task {  get; set; }

        [ProtoMember(3)]
        public StudentCodingProgress? _progress { get; set; }

        public ServerMessage()
        {
        }

        public class Builder
        {
            private readonly ServerMessage msg = new ServerMessage();

            public Builder MessageType(MessageType messageType)
            {
                msg._messageType = messageType;
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

            public ServerMessage Build()
            {
                // Validation can be added here
                if (msg._messageType == null)
                    throw new InvalidOperationException("Message Type is required");

                bool isNotRequest = msg._messageType != Enums.MessageType.ServerTaskRequest;

                if (msg._progress == null && msg._messageType == null && isNotRequest)
                    throw new InvalidOperationException("Message Content is required");

                return msg;
            }
        }
    }
}
