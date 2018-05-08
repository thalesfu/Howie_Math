using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class BaseGroupsSubstractionQuestionBuilder : BaseGroupsQuestionBuilder
    {
        public BaseGroupsSubstractionQuestionBuilder(IRandom rd)
            : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b} = ";
        }

        protected override bool IsValid(int a, int b)
        {
            return a >= b;
        }
    }
}