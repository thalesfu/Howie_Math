using System;
using System.Linq;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class TenPlusXQuestionBuilder : BaseGroupsAddQuestionBuilder,ITenPlusXQuestionBuilder
    {
        public TenPlusXQuestionBuilder(IRandom rd):base(rd)
        {
            this.GroupA = new[] { 10 };
            this.GroupB = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}