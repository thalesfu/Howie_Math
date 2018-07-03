using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class OneXSubtractionYWithBackQuestionBuilder : BaseSubstractionQuestionBuilder,
        IOneXSubtractionYWithBackQuestionBuilder
    {
        public OneXSubtractionYWithBackQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override int GenerateA()
        {
            return this.rd.Next(10, 20);
        }

        protected override bool IsValid(int a, int b)
        {
            return a % 10 < b;
        }
    }
}