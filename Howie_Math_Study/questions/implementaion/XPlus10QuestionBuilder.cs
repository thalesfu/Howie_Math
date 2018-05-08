using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class XPlus10QuestionBuilder : BaseGroupsAddQuestionBuilder,IXPlus10QuestionBuilder
    {
        public XPlus10QuestionBuilder(IRandom rd):base(rd)
        {
            this.GroupA = new[] { 10 };
            this.GroupB = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}