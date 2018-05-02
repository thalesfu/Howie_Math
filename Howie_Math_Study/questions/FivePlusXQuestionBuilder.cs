﻿using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class FivePlusXQuestionBuilder : BaseGroupsAddQuestionBuilder, IFivePlusXQuestionBuilder
    {
        public FivePlusXQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 5 };
            this.GroupB = new[] { 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}