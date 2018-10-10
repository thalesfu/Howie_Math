using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class ElevenMixQuestionBuilder : BaseMixQuestionBuilder, IElevenMixQuestionBuilder
    {
        public ElevenMixQuestionBuilder(IRandom rd) : base(rd, 11)
        {
        }
    }
}