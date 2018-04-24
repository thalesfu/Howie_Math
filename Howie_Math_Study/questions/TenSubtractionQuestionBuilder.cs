using System.Linq;
using Ctrip.Duckbill;

namespace Howie_Math_Study.questions
{
    public class TenSubtractionQuestionBuilder : ITenSubtractionQuestionBuilder
    {
        private readonly IRandom rd;

        private int[] GroupA = {10};
        private int[] GroupB = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        public TenSubtractionQuestionBuilder(IRandom rd)
        {
            this.rd = rd;
        }

        public string Build()
        {
            var realA = GroupA[this.rd.Next(0, GroupA.Length)];
            var realB = GroupB[this.rd.Next(0, GroupB.Length)];


            return string.Format("{0} - {1} = ", realA, realB);
        }

        public string[] Build(int count)
        {
            return (new string[count]).Select(i => this.Build()).ToArray();
        }
    }
}