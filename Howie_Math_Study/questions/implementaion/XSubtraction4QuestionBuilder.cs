using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XSubtraction4QuestionBuilder : BaseGroupsSubstractionQuestionBuilder, IXSubtraction4QuestionBuilder
    {
        public XSubtraction4QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return 4;
        }

        protected override int GenerateA()
        {
            return this.rd.Next(4, 11);
        }
    }
}