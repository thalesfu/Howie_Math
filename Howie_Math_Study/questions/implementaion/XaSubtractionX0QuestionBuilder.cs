using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaSubtractionX0QuestionBuilder : BaseSubstractionQuestionBuilder, IXaSubtractionX0QuestionBuilder
    {
        public XaSubtractionX0QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override int GenerateA()
        {
            return this.rd.Next(11, 100);
        }

        protected override bool IsValid(int a, int b)
        {
            return a - (a % 10) == b * 10;
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b}0 = ______";
        }
    }
}