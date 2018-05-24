using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaPlusYbNotCarryQuestionsBuilder : BaseQuestionBuilder, IXaPlusYbNotCarryQuestionsBuilder
    {
        public XaPlusYbNotCarryQuestionsBuilder(IRandom rd) : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} + {b} = ______";
        }

        protected override int GenerateA()
        {
            return this.rd.Next(10, 100);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(10, 100);
        }

        protected override bool IsValid(int a, int b)
        {
            return a % 10 + b % 10 < 10 && a + b < 100;
        }
    }
}