using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public abstract class BaseGroupsQuestionBuilder : BaseQuestionBuilder
    {
        protected int[] GroupA;
        protected int[] GroupB;

        protected BaseGroupsQuestionBuilder(IRandom rd) : base(rd)
        {
        }
    }
}