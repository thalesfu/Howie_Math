using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class BaseGroupsAddQuestionBuilder : BaseGroupsQuestionBuilder
    {
        public BaseGroupsAddQuestionBuilder(IRandom rd)
            : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            int realA;
            int realB;
            var reverse = this.rd.Next(0, 2) > 0;

            if (reverse)
            {
                realA = b;
                realB = a;
            }
            else
            {
                realA = a;
                realB = b;
            }

            return $"{realA} + {realB} = ";
        }
    }
}