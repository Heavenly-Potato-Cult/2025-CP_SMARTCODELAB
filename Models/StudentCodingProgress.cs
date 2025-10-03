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

        public StudentCodingProgress()
        {
            CodeProgress = new List<string>();
        }

        public StudentCodingProgress(string msg)
        {
            this.sourceCode = msg;
            CodeProgress = new List<string>();
        }

        //the file naming format of this object will be {activityName}_{studentName}_prog.bin

        public static StudentCodingProgress Deserialize(string filePath) 
        {
            try
            {
                using (var file = File.OpenRead(filePath))
                {
                    return Serializer.DeserializeWithLengthPrefix<StudentCodingProgress>(file,PrefixStyle.Base128);
                }
            }
            catch (EndOfStreamException e)
            {
                return null;
            }
        }
    }
}
