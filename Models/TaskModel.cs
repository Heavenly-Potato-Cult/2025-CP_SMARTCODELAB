using ProtoBuf;
using SmartCodeLab.Models.Enums;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class TaskModel
    {
        [ProtoMember(1)]
        private static readonly Dictionary<string, LanguageSupported> languageMap = new()
        {
            { "C++", LanguageSupported.Cpp },
            { "Python", LanguageSupported.Python },
            { "Java", LanguageSupported.Java },
            { "Cpp", LanguageSupported.Cpp }
        };
        [ProtoMember(2)]
        public string _taskName { get; set; }
        [ProtoMember(3)]
        public string _instructions { get; set; }

        [ProtoMember(4)]
        public LanguageSupported _language { get; set; }

        [ProtoIgnore]
        public string language { 
            get { return _language.ToString(); }
            set {
                    _language = languageMap[value];

            } }

        [ProtoMember(5)]
        public string subject { get; set; }

        [ProtoMember(6)]
        public string _referenceFile { get; set; }

        [ProtoMember(7)]
        public Dictionary<string, string>? _testCases { get; set; }

        [ProtoMember(8)]
        public Dictionary<int, decimal[]> ratingFactors { get; set; }

        [ProtoMember(9)]
        public bool isTabLocked { get; set; }

        [ProtoIgnore]
        public string filePath { get; set; }
        public TaskModel() {
            _testCases = new Dictionary<string, string>();
        }

        public TaskModel(string taskName) 
        {
            _taskName = taskName;
        }

        public class Builder
        {
            private readonly TaskModel task = new TaskModel();
            public Builder(string actname, string subject, string language, string instruction)
            {
                task._taskName = actname;
                task.subject = subject;
                task.language = language;
                task._instructions = instruction;
            }

            public Builder ReferenceCode(string sourceCode)
            {
                task._referenceFile = sourceCode;
                return this;
            }

            public TaskModel Build()
            {
                return task;
            }
        }
    }
}
