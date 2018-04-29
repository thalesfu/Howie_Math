using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    internal class TenPlusTenQuestionsBuilder : BaseGroupsAddQuestionBuilder, ITenPlusTenQuestionsBuilder
    {
        public TenPlusTenQuestionsBuilder(IRandom rd)
            : base(rd)
        {
            this.GroupA = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            this.GroupB = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        }
    }
}