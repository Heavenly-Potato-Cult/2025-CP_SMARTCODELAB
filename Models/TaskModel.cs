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
            { "Cpp", LanguageSupported.Cpp },
            { "Python", LanguageSupported.Python },
            { "Java", LanguageSupported.Java }
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

        //will be provided by the user(most probably a teacher) to test the students code
        [ProtoMember(5)]
        public KeyValuePair<string, string>? _referenceFile { get; set; } // the file that will be provided by the user as a quality reference of the students code
        [ProtoMember(6)]
        public Dictionary<string, string>? _externalResources { get; set; } // the file that contains the functions and properties needed to complete the task

        [ProtoMember(7)]
        public Dictionary<string, string>? _testCases { get; set; } // will be provided by the user to test the students code

        public TaskModel() { }

        public TaskModel(string taskName, string instructions, string lang, KeyValuePair<string, string> referenceFile, List<KeyValuePair<string,string>> externalResources, List<KeyValuePair<string, string>> testCases)
        {
            _taskName = taskName;
            _instructions = instructions;
            _language = languageMap[lang];
            _referenceFile = referenceFile;
            _externalResources = new Dictionary<string, string>();
            _testCases = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> resource in externalResources)
            {
                _externalResources.Add(resource.Key, resource.Value);
            }

            foreach (KeyValuePair<string, string> testCase in testCases)
            {
                _testCases.Add(testCase.Key, testCase.Value);
            }
        }

        public override string? ToString()
        {
            return _taskName + "\n" + _instructions + "\n" + language +"\n" +_referenceFile + "\n" + (_externalResources != null ? string.Join(", ", _externalResources.Values) : "");
        }
    }
}
