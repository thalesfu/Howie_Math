using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class SixPlusXQuestionBuilder : BaseGroupsAddQuestionBuilder, ISixPlusXQuestionBuilder
    {
        public SixPlusXQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 6 };
            this.GroupB = new[] { 4, 5, 6, 7, 8, 9 };
        }
    }
}