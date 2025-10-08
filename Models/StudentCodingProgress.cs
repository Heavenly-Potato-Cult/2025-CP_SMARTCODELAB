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
        public readonly Dictionary<string, int> codeStats = new Dictionary<string, int>() 
        {
            {"accuracy",0 },
            {"readability", 0 },
            {"efficiency", 0 }
        };

        public StudentCodingProgress()
        {
            CodeProgress = new List<string>();
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
            CodeProgress = new List<string>();
        }

        public void UpdateStats(Dictionary<string, int> updatedStats)
        {
            foreach (var item in updatedStats)
            {
                codeStats[item.Key] = item.Value;
            }
        }
    }
}
