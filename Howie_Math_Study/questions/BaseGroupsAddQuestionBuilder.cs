using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class BaseGroupsAddQuestionBuilder : BaseGroupsQuestionBuilder
    {
        public BaseGroupsAddQuestionBuilder(IRandom rd)
            : base(rd)
        {
        }

        public override string Build()
        {
            int realA;
            int realB;

            var a = this.GroupA[this.rd.Next(0, this.GroupA.Length)];
            var b = this.GroupB[this.rd.Next(0, this.GroupB.Length)];

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