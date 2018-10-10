using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class SixteenQuestionBuilder : BaseMixQuestionBuilder, ISixteenQuestionBuilder
    {
        public SixteenQuestionBuilder(IRandom rd) : base(rd, 16)
        {
        }
    }
}