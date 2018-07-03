using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XaSubtractionY0QuestionBuilder : XaSubtractionX0QuestionBuilder, IXaSubtractionY0QuestionBuilder
    {
        public XaSubtractionY0QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override bool IsValid(int a, int b)
        {
            return a >= b * 10;
        }
    }
}