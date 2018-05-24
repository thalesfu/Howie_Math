using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XPlusYQuestionsBuilder : BaseGroupsAddQuestionBuilder, IXPlusYQuestionsBuilder
    {
        public XPlusYQuestionsBuilder(IRandom rd)
            : base(rd)
        {
            this.GroupA = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.GroupB = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}