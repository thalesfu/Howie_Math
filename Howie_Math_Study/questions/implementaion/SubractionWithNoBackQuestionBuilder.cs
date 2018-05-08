using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class SubractionWithNoBackQuestionBuilder : BaseQuestionBuilder, ISubractionWithNoBackQuestionBuilder
    {
        public SubractionWithNoBackQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} - {b} = ______";
        }

        protected override int GenerateA()
        {
            return this.rd.Next(0, 100);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 10);
        }

        protected override bool IsValid(int a, int b)
        {
            return (a % 10) >= b;
        }
    }
}