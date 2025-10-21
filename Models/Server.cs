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
    public class Server
    {
        [ProtoMember(1)]
        public string ServerName { get; set; }

        [ProtoMember(2)]
        public TaskModel ServerTask { get; set; }

        [ProtoMember(3)]
        public LanguageSupported ProgrammingLanguage { get; set; }

        [ProtoMember(4)]
        public string Password { get; set; }

        [ProtoIgnore]
        public string programmingLanguage //servers as the controller for getting the value of ProgrammingLanguage
        {
            get
            {
                return ProgrammingLanguage.ToString();
            } 
            set 
            { 
                ProgrammingLanguage = langaugeMap[value];
            } }

        [ProtoIgnore]
        private readonly Dictionary<string, LanguageSupported> langaugeMap = new Dictionary<string, LanguageSupported>()
        {
            {"C++", LanguageSupported.Cpp},
            {"Java", LanguageSupported.Java },
            {"Python", LanguageSupported.Python },
            { "Cpp", LanguageSupported.Cpp }
        };


        [ProtoMember(5)]
        public Dictionary<string, UserProfile> Users;

        [ProtoMember(6)]
        public int submittedCount { get; set; }

        [ProtoMember(7)]
        public Dictionary<int, int> CodeRatingFactors { get; set; }

        [ProtoMember(8)]
        public DateTime createdAt { get; set; }

        public Server()
        {
            Users = new Dictionary<string, UserProfile>();
        }

        public Server(string serverName, string password, TaskModel serverTask, string programmingLanguage, Dictionary<string,UserProfile> users)
        {
            ServerName = serverName;
            this.programmingLanguage = programmingLanguage;
            this.Password = password;
            ServerTask = serverTask;
            ServerTask._language = ProgrammingLanguage;
            ServerTask._taskName = serverName;
            Users = users;
            submittedCount = 0;
            createdAt = DateTime.Now;
        }
    }
}
