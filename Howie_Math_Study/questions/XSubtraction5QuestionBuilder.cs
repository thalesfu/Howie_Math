﻿using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    internal class XSubtraction5QuestionBuilder : BaseGroupsSubstractionQuestionBuilder, IXSubtraction5QuestionBuilder
    {
        public XSubtraction5QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return 5;
        }

        protected override int GenerateA()
        {
            return this.rd.Next(5, 11);
        }
    }
}