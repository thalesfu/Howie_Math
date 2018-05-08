using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class XPlus8QuestionBuilder : BaseGroupsAddQuestionBuilder, IXPlus8QuestionBuilder
    {
        public XPlus8QuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 8 };
            this.GroupB = new[] { 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}