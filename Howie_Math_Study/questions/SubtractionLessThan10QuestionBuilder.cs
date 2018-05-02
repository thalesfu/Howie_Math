﻿using System;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    internal class SubtractionLessThan10QuestionBuilder : BaseQuestionBuilder, ISubtractionLessThan10QuestionBuilder
    {
        public SubtractionLessThan10QuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b} = ";
        }

        protected override int GenerateA()
        {
            return this.rd.Next(0, 11);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override bool IsValid(int a, int b)
        {
            return a > b;
        }
    }
}