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
    public class ClassInformation
    {
        [ProtoMember(1)]
        public string subjectCode { get; set; }
        [ProtoMember(2)]
        public string subjectDesc { get; set; }
        [ProtoMember(3)]
        public string schoolYear { get; set; }
        [ProtoMember(4)]
        public Semester semester { get; set; }
        [ProtoMember(5)]
        public string course { get; set; }
        [ProtoMember(6)]
        public string section { get; set; }
        [ProtoMember(7)]
        public int yearLevel { get; set; }
        [ProtoMember(8)]
        public List<UserProfile> students { get; set; }
        [ProtoMember(9)]
        public string filepath { get; set; }

        public ClassInformation()
        {

            schoolYear = string.Empty;
            subjectCode = string.Empty;
            students = new List<UserProfile>();
        }

        public class Builder
        {
            private ClassInformation _classInfo;

            public Builder()
            {
                _classInfo = new ClassInformation();
            }

            public Builder WithSubjectCode(string subjectCode)
            {
                _classInfo.subjectCode = subjectCode;
                return this;
            }

            public Builder WithSubjectDesc(string subjectDesc)
            {
                _classInfo.subjectDesc = subjectDesc;
                return this;
            }

            public Builder WithSchoolYear(string schoolYear)
            {
                _classInfo.schoolYear = schoolYear;
                return this;
            }

            public Builder WithSemester(Semester semester)
            {
                _classInfo.semester = semester;
                return this;
            }

            public Builder WithCourse(string course)
            {
                _classInfo.course = course;
                return this;
            }

            public Builder WithSection(string section)
            {
                _classInfo.section = section;
                return this;
            }

            public Builder WithYearLevel(int yearLevel)
            {
                _classInfo.yearLevel = yearLevel;
                return this;
            }

            public Builder WithStudents(List<UserProfile> student)
            {
                _classInfo.students = student ?? new List<UserProfile>();
                return this;
            }

            public Builder WithFilepath(string filepath)
            {
                _classInfo.filepath = filepath;
                return this;
            }

            public ClassInformation Build()
            {
                return _classInfo;
            }
        }
    }
}
