using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public abstract class BaseSubstractionQuestionBuilder : BaseQuestionBuilder
    {
        protected BaseSubstractionQuestionBuilder(IRandom rd)
            : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b} = ______";
        }

        protected override bool IsValid(int a, int b)
        {
            return a >= b;
        }
    }
}