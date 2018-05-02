using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class TenSubtractionXQuestionBuilder : BaseGroupsQuestionBuilder, ITenSubtractionXQuestionBuilder
    {

        public TenSubtractionXQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 10 };
            this.GroupB = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b} = ";
        }
    }
}