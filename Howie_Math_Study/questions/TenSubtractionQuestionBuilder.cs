using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class TenSubtractionQuestionBuilder : BaseGroupsQuestionBuilder, ITenSubtractionQuestionBuilder
    {

        public TenSubtractionQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 10 };
            this.GroupB = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public override string Build()
        {
            var realA = this.GroupA[this.rd.Next(0, this.GroupA.Length)];
            var realB = this.GroupB[this.rd.Next(0, this.GroupB.Length)];


            return $"{realA} - {realB} = ";
        }
    }
}