using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    internal class XPlusYLessThen100QuestionsBuilder : BaseQuestionBuilder, IXPlusYLessThen100QuestionsBuilder
    {
        public XPlusYLessThen100QuestionsBuilder(IRandom rd) : base(rd)
        {
        }

        protected override string Format(int a, int b)
        {
            return $"{a} + {b} = ______";
        }

        protected override int GenerateA()
        {
            return this.rd.Next(1, 100);
        }

        protected override int GenerateB()
        {
            return this.rd.Next(1, 100);
        }

        protected override bool IsValid(int a, int b)
        {
            return a + b < 100;
        }
    }
}