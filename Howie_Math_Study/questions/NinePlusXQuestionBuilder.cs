using System;
using System.Linq;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class NinePlusXQuestionBuilder : BaseGroupsAddQuestionBuilder, INinePlusXQuestionBuilder
    {
        public NinePlusXQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 9 };
            this.GroupB = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}