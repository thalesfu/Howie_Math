using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaSubtractionYWithBackQuestionBuilder : BaseSubstractionQuestionBuilder,
        IXaSubtractionYWithBackQuestionBuilder
    {
        public XaSubtractionYWithBackQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override int GenerateA()
        {
            return this.rd.Next(10, 100);
        }

        protected override bool IsValid(int a, int b)
        {
            return a % 10 < b;
        }
    }
}