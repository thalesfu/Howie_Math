using System;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class Include20AddAndSubtractionCarryOverMixQuestionBuilder : BaseQuestionBuilder,
        IInclude20AddAndSubtractionCarryOverMixQuestionBuilder
    {
        public Include20AddAndSubtractionCarryOverMixQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        public override string Build()
        {
            int a;
            int b;
            string operation;

            do
            {
                operation = this.GenerateOperation();
                a = this.GenerateA(operation);
                b = this.GenerateB();
            } while (!this.IsValid(a, b, operation));

            return this.Format(a, b, operation);
        }

        private string Format(int a, int b, string operation)
        {
            if (operation == "+")
            {
                return $"{a} + {b} = ______";
            }

            return $"{a} - {b} = ______";
        }

        private bool IsValid(int a, int b, string operation)
        {
            if (operation == "+")
            {
                return a + b > 10;
            }

            return a - 10 < b;
        }

        private string GenerateOperation()
        {
            return this.rd.Next(0, 2) == 1 ? "+" : "-";
        }

        protected override string Format(int a, int b)
        {
            return string.Empty;
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override int GenerateA()
        {
            return 0;
        }

        protected int GenerateA(string operation)
        {
            if (operation == "+")
            {
                return this.rd.Next(1, 10);
            }

            return this.rd.Next(11, 20);
        }
    }
}