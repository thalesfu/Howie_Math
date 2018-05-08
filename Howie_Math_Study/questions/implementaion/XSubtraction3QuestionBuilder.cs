using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XSubtraction3QuestionBuilder : BaseGroupsSubstractionQuestionBuilder, IXSubtraction3QuestionBuilder
    {
        public XSubtraction3QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return 3;
        }

        protected override int GenerateA()
        {
            return this.rd.Next(3, 11);
        }
    }
}