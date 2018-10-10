using Howie_Math_Study.questions.implementaion;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    internal class ThirteenQuestionBuilder : BaseMixQuestionBuilder, IThirteenQuestionBuilder
    {
        public ThirteenQuestionBuilder(IRandom rd) : base(rd, 13)
        {
        }
    }
}