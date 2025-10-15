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
        public Dictionary<int, int> codeStats { get; set; }

        public StudentCodingProgress()
        {
            CodeProgress = new List<string>();
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
            CodeProgress = new List<string>();
        }

        public void UpdateStats(Dictionary<int, int> updatedStats)
        {
            foreach (var item in updatedStats)
            {
                codeStats[item.Key] = item.Value;
            }
        }
    }
}
