using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class SubmittedCode
    {
        public SubmittedCode()
        {
        }

        public SubmittedCode(string sourceCode, UserProfile user)
        {
            this.sourceCode = sourceCode;
            this.user = user;
        }

        public SubmittedCode(string sourceCode)
        {
            this.sourceCode = sourceCode;
        }

        private SubmittedCode(int placement, UserProfile user, float score)
        {
            this.placement = placement;
            username = user._studentName;
            this.score = Convert.ToInt16(score);
        }

        public SubmittedCode(string sourceCode, StudentCodingProgress progress)
        {
            this.sourceCode = sourceCode;
            this.progress = progress;
        }

        [ProtoMember(1)]
        public string sourceCode { get; set; }

        [ProtoMember(2)]
        public UserProfile user {  get; set; }

        [ProtoMember(3)]
        public StudentCodingProgress progress {  get; set; }
        
        //below will be used for leader boards in the student side
        [ProtoMember(4)]
        public int placement { get; set; }

        [ProtoMember(5)]
        public int score { get; set; }

        [ProtoMember(6)]
        public string username { get; set; }

        public SubmittedCode getPlacement() 
        {
            return new SubmittedCode(placement, user, progress.codeRating.totalRating);
        }
    }
}
