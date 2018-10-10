using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class TweleveQuestionBuilder : BaseMixQuestionBuilder, ITweleveQuestionBuilder
    {
        public TweleveQuestionBuilder(IRandom rd) : base(rd, 12)
        {
        }
    }
}