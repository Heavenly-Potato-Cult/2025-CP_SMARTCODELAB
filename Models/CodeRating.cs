using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    [ProtoContract]
    public class CodeRating
    {
        public CodeRating()
        {
            totalRating = 0;
            testScore = 0;
            maxTestScore = 0;
            readabilityViolations = new List<string>();
            recommendedCycComplexity = 0;
            actualCycComplexity = 0;
            statsGrade = new Dictionary<int, float>();
            trackbarValues = new Dictionary<int, int>();
        }

        [ProtoMember(1)]
        public float totalRating { get; set; }

        [ProtoMember(2)]
        public int testScore { get; set; }

        [ProtoMember(3)]
        public int maxTestScore { get; set; }

        [ProtoMember(4)]
        public List<string> readabilityViolations { get; set; }

        [ProtoMember(5)]
        public int recommendedCycComplexity { get; set; }

        [ProtoMember(6)]
        public int actualCycComplexity { get; set; }

        [ProtoMember(7)]
        public Dictionary<int, float> statsGrade { get; set; }

        [ProtoMember(8)]
        public Dictionary<int, int> trackbarValues;

        public class Builder
        {
            private readonly CodeRating _codeRating;

            public Builder()
            {
                _codeRating = new CodeRating
                {
                    readabilityViolations = new List<string>(),
                    statsGrade = new Dictionary<int, float>()
                };
            }

            public Builder WithTotalRating(float totalRating)
            {
                _codeRating.totalRating = totalRating;
                return this;
            }

            public Builder WithTestScore(int testScore)
            {
                _codeRating.testScore = testScore;
                return this;
            }

            public Builder WithMaxTestScore(int maxTestScore)
            {
                _codeRating.maxTestScore = maxTestScore;
                return this;
            }

            public Builder WithReadabilityViolations(List<string> violations)
            {
                _codeRating.readabilityViolations = violations ?? new List<string>();
                return this;
            }

            public Builder AddReadabilityViolation(string violation)
            {
                _codeRating.readabilityViolations.Add(violation);
                return this;
            }

            public Builder AddReadabilityViolations(IEnumerable<string> violations)
            {
                _codeRating.readabilityViolations.AddRange(violations);
                return this;
            }

            public Builder WithRecommendedCycComplexity(int complexity)
            {
                _codeRating.recommendedCycComplexity = complexity;
                return this;
            }

            public Builder WithActualCycComplexity(int complexity)
            {
                _codeRating.actualCycComplexity = complexity;
                return this;
            }

            public Builder WithStatsGrade(Dictionary<int, float> statsGrade)
            {
                _codeRating.statsGrade = statsGrade ?? new Dictionary<int, float>();
                return this;
            }

            public Builder WithTrackBarValues(Dictionary<int, int> trackbarValues)
            {
                _codeRating.trackbarValues = trackbarValues;
                return this;
            }
            public CodeRating Build()
            {
                return _codeRating;
            }
        }
    }
}
