using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class XPlusYEqualsTenQuestionBuilder : BaseGroupsQuestionBuilder, IXPlusYEqualsTenQuestionBuilder
    {

        public XPlusYEqualsTenQuestionBuilder(IRandom rd) : base(rd)
        {
            this.GroupA = new[] { 10 };
            this.GroupB = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        protected override string Format(int a, int b)
        {
            string realA;
            string realB;
            var reverse = this.rd.Next(0, 2) > 0;

            if (reverse)
            {
                realA = b.ToString();
                realB = "______";
            }
            else
            {
                realA = "______";
                realB = b.ToString();
            }

            return $"{realA} + {realB} = 10";
        }
    }
}