﻿using System;
using System.Linq;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class EightPlusXQuestionBuilder : BaseGroupsAddQuestionBuilder, IEightPlusXQuestionBuilder
    {
        public EightPlusXQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 8 };
            this.GroupB = new[] { 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}