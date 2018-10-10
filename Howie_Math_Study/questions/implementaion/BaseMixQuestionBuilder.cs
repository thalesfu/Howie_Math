using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
{
    public class BaseMixQuestionBuilder : BaseQuestionBuilder
    {
        private readonly int baseNumber;

        public BaseMixQuestionBuilder(IRandom rd, int baseNumber) : base(rd)
        {
            this.baseNumber = baseNumber;
        }

        protected override string Format(int a, int b)
        {
            switch (this.rd.Next(1, 6))
            {
                case 1:
                    var b1 = this.baseNumber - a;
                    return $"{a} + {b1} = ______";
                case 2:
                    var b2 = this.baseNumber - a;
                    return $"{b2} + {a} = ______";
                case 3:
                    return $"{a} + ______ = {baseNumber}";
                case 4:
                    return $"______ + {a} = {baseNumber}";
                case 5:
                    return $"{baseNumber} - {a} = ______";
                default:
                    return $"{baseNumber} - ______ = {a}";
            }
        }

        protected override int GenerateA()
        {
            return this.rd.Next(this.baseNumber - 9, 9);
        }

        protected override int GenerateB()
        {
            return 0;
        }

        protected override bool IsValid(int a, int b)
        {
            return (this.baseNumber - a).ToString().Length == 1;
        }
    }
}