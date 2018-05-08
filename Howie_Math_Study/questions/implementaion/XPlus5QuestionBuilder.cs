using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class XPlus5QuestionBuilder : BaseGroupsAddQuestionBuilder, IXPlus5QuestionBuilder
    {
        public XPlus5QuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 5 };
            this.GroupB = new[] { 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}