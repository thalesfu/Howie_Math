using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XSubtractionYLessThan100QuestionBuilder : BaseSubstractionQuestionBuilder,
        IXSubtractionYLessThan100QuestionBuilder
    {
        public XSubtractionYLessThan100QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return this.rd.Next(0, 100);
        }

        protected override int GenerateA()
        {
            return this.rd.Next(0, 100);
        }
    }
}