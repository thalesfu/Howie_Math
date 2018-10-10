using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class FifteenQuestionBuilder : BaseMixQuestionBuilder, IFifteenQuestionBuilder
    {
        public FifteenQuestionBuilder(IRandom rd) : base(rd, 15)
        {
        }
    }
}