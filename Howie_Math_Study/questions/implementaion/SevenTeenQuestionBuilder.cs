using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class SevenTeenQuestionBuilder : BaseMixQuestionBuilder, ISevenTeenQuestionBuilder
    {
        public SevenTeenQuestionBuilder(IRandom rd) : base(rd, 17)
        {
        }
    }
}