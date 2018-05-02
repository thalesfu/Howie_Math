using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public abstract class BaseGroupsQuestionBuilder : BaseQuestionBuilder
    {
        protected int[] GroupA;
        protected int[] GroupB;

        protected BaseGroupsQuestionBuilder(IRandom rd) : base(rd)
        {
        }

        protected override int GenerateB()
        {
            return this.GroupB[this.rd.Next(0, this.GroupB.Length)];
        }

        protected override int GenerateA()
        {
            return this.GroupA[this.rd.Next(0, this.GroupA.Length)];
        }
    }
}