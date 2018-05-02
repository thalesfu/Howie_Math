using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class XPlus7QuestionBuilder : BaseGroupsAddQuestionBuilder, IXPlus7QuestionBuilder
    {
        public XPlus7QuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 7 };
            this.GroupB = new[] { 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}