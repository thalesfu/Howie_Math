using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaPlusYCarryQuestionsBuilder : BaseQuestionBuilder, IXaPlusYCarryQuestionsBuilder
    {
        public XaPlusYCarryQuestionsBuilder(IRandom rd) : base(rd)
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

            return $"{realA} + {realB} = ______";
        }

        protected override int GenerateA()
        {
            return this.rd.Next(10, 100);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override bool IsValid(int a, int b)
        {
            return a % 10 + b >= 10 && a + b < 100;
        }
    }
}