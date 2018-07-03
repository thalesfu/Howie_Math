using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XSubtractionYLessThan10QuestionBuilder : BaseSubstractionQuestionBuilder,
        IXSubtractionYLessThan10QuestionBuilder
    {
        public XSubtractionYLessThan10QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateA()
        {
            return this.rd.Next(0, 11);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(0, 10);
        }
    }
}