using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    public class TaskModel
    {
        private static readonly Dictionary<string, LanguageSupported> languageMap = new()
        {
            { "C++", LanguageSupported.Cpp },
            { "Python", LanguageSupported.Python },
            { "Java", LanguageSupported.Java }
        };

        public string _taskName { get; set; }
        public string _instructions { get; set; }

        private LanguageSupported? _language;
        public string language { 
            get { return _language?.ToString() ?? ""; }
            set {
                if (value != null && languageMap.TryGetValue(value, out var mappedValue))
                {
                    _language = mappedValue;
                }
                else
                {
                    _language = null;
                }
            } }

        //will be provided by the user(most probably a teacher) to test the students code
        private KeyValuePair<string, string> _referenceFile; // the file that will be provided by the user as a quality reference of the students code
        private Dictionary<string, string> _externalResources; // the file that contains the functions and properties needed to complete the task

        private Dictionary<string, string> _testCases; // will be provided by the user to test the students code

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
            return _taskName + "\n" + _instructions + "\n" + _language;
        }
    }
}
