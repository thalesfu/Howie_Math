using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaSubractionYWithNoBackQuestionBuilder : BaseSubstractionQuestionBuilder, IXaSubractionYWithNoBackQuestionBuilder
    {
        public XaSubractionYWithNoBackQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateA()
        {
            return this.rd.Next(11, 100);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override bool IsValid(int a, int b)
        {
            return (a % 10) >= b;
        }
    }
}