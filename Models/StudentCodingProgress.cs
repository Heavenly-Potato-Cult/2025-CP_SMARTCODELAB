using ProtoBuf;
using System.Diagnostics;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class StudentCodingProgress
    {
        [ProtoMember(1)]
        public string sourceCode { get; set; }

        [ProtoMember(2)]
        public List<string> CodeProgress { get; set; }

        [ProtoMember(3)]
        public List<CopyPastedCode> pastedCode { get; set; }

        [ProtoMember(4)]
        public CodeRating codeRating { get; set; }

        public StudentCodingProgress()
        {
            CodeProgress = new List<string>();
            codeRating = new CodeRating();
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
            CodeProgress = new List<string>();
        }
    }
}
